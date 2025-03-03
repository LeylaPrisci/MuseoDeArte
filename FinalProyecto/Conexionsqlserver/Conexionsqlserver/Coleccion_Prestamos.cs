using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexionsqlserver
{
    public partial class Colecciones : Form
    {
        conexionbd conexion = new conexionbd();
        private string usuario;
        private int rolId;
        public Colecciones(string usuarioAutenticado)
        {
            InitializeComponent();
            this.Load += new EventHandler(Coleccionn_Load);
            usuario = usuarioAutenticado;
            CargarDatosUsuario();
        }
        private void AplicarRestricciones()
        {
            if (rolId == 3)
            {
                // Deshabilitar botones de agregar, eliminar, guardar y cancelar
                btn_agregar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;

                // Deshabilitar todos los textboxes y comboboxes
                text_nombre.Enabled = false;
                text_descripcion.Enabled = false;
                text_telefono.Enabled = false;
                text_nombre_Contac.Enabled = false;
                textb_tipo.Enabled = false;
                text_direccion.Enabled = false;
                text_Apellido.Enabled = false;
            }

        }

        private void CargarDatosUsuario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.conectarbd.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT u.RolId
                    FROM Usuarios u
                    WHERE u.NombreUsuario = @Usuario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            rolId = Convert.ToInt32(result);
                            AplicarRestricciones();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del usuario: " + ex.Message);
            }
        }

        private void Coleccionn_Load(object sender, EventArgs e)
        {
            LoadColeccionData();
           

        }

        private void LoadColeccionData()
        {
            string consulta = "SELECT * FROM Coleccion";
           

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_coleccion.DataSource = dt; // Asegurar que se asigne al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de exhibiciones: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string searchText = textb_buscar.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadColeccionData();
                return;
            }
            try
            {
                conexion.abrir();
                string query = @"
                SELECT 
                    Id,
                    Nombre,
                    Tipo,
                    Descripcion,
                    Direccion,
                    Telefono,
                    NombreContacto,
                    ApellidoContacto
                FROM Coleccion
                WHERE Nombre LIKE @search OR Tipo LIKE @search OR Descripcion LIKE @search OR Direccion LIKE @search OR Telefono LIKE @search OR NombreContacto LIKE @search OR ApellidoContacto LIKE @search";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.conectarbd);
                adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_coleccion.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.");
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message);

            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            LoadColeccionData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage3;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();

                //Consulta SQL 
                string query = @"INSERT INTO Coleccion (Nombre, Tipo, Descripcion, Direccion, Telefono, NombreContacto, ApellidoContacto) 
                         VALUES (@Nombre, @Tipo, @Descripcion, @Direccion, @Telefono, @NombreContacto, @ApellidoContacto)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                //Pasar los valores de los TextBox 
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);
                comando.Parameters.AddWithValue("@Tipo", textb_tipo.Text);
                comando.Parameters.AddWithValue("@Descripcion", text_descripcion.Text);
                comando.Parameters.AddWithValue("@Direccion", text_direccion.Text);
                comando.Parameters.AddWithValue("@Telefono", text_telefono.Text);
                comando.Parameters.AddWithValue("@NombreContacto", text_nombre_Contac.Text);
                comando.Parameters.AddWithValue("@ApellidoContacto", text_Apellido.Text);

                // Ejecutar la consulta de inserción
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Colección guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar los datos en el DataGridView después de guardar
                    LoadColeccionData();
                }
                else
                {
                    MessageBox.Show("No se guardó la colección. Verifica los datos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            text_nombre.Clear();
            text_descripcion.Clear();
            text_telefono.Clear();
            textb_tipo.Clear();
            text_direccion.Clear();
            text_Apellido.Clear();
            text_nombre_Contac.Clear();

            MessageBox.Show("Los campos han sido limpiados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_coleccion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la coleccion para eliminar.");
                return;

            }

            int coleccionId = Convert.ToInt32(dataGV_coleccion.SelectedRows[0].Cells["Id"].Value);
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta coleccion?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }
            string query = "DELETE FROM Coleccion WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", coleccionId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Objeto eliminado correctamente.");
                        LoadColeccionData(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el objeto.");
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al eliminar la coleccion: " + ex.Message);

            }
            finally
            {
                conexion.cerrar();
            }

        }
    }
}
