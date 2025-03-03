using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexionsqlserver
{
    public partial class Exhibicion : Form
    {
        conexionbd conexion = new conexionbd();
        private string usuario;
        private int rolId;
        public Exhibicion(string usuarioAutenticado)
        {
            InitializeComponent();
            this.Load += new EventHandler(Exhibicion_Load);
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
                dateTp_FInicio.Enabled = false;
                dateTimePFinalizacion.Enabled = false;
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

        private void Exhibicion_Load(object sender, EventArgs e) 
        {
            LoadExhibicionData();
           

        }

        private void LoadExhibicionData()
        {
            string consulta = "SELECT * FROM Exhibicion";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridViewExhibicion.DataSource = dt; // Asegurar que se asigne al DataGridView
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
                LoadExhibicionData(); // Si el campo está vacío, carga todos los datos.
                return;
            }

            try
            {
                conexion.abrir();

                // Consulta SQL para buscar por nombre (ajusta según el campo que desees buscar)
                string query = @"
                SELECT 
                    Id,
                    Nombre,
                    FechaInicio,
                    FechaFinalizacion
                FROM Exhibicion
                WHERE Nombre LIKE @search OR FechaInicio LIKE @search OR FechaFinalizacion LIKE @search";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.conectarbd);
                adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Mostrar los datos en la DataGridView
                dataGridViewExhibicion.DataSource = dt;

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
            LoadExhibicionData();
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

                string query = @"INSERT INTO Exhibicion (Nombre, FechaInicio, FechaFinalizacion) 
                         VALUES (@Nombre, @FechaInicio, @FechaFinalizacion)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);
                comando.Parameters.AddWithValue("@FechaInicio", dateTp_FInicio.Value.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@FechaFinalizacion", dateTimePFinalizacion.Value.ToString("yyyy-MM-dd"));

                
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Exhibición guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔹 Recargar los datos en el DataGridView
                    LoadExhibicionData();
                }
                else
                {
                    MessageBox.Show("No se guardó la exhibición. Verifica los datos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            text_nombre.Clear();
            dateTp_FInicio.Value = DateTime.Now;
            dateTimePFinalizacion.Value = DateTime.Now; 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewExhibicion.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Seleccione la exhibicion para eliminar.");
                return;

            }
            int exhibicionId = Convert.ToInt32(dataGridViewExhibicion.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta exhibicion?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = "DELETE FROM Exhibicion WHERE Id = @Id";

            try
            {
                conexion.abrir();

                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))

                {
                    cmd.Parameters.AddWithValue("@Id", exhibicionId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Objeto eliminado correctamente.");
                        LoadExhibicionData(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el objeto.");
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al eliminar la exihibicion: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }

        }
    }

}
