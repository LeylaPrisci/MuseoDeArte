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
    public partial class Tipo : Form
    {
        conexionbd conexion = new conexionbd();
        public Tipo()
        {
            InitializeComponent();
            this.Load += new EventHandler(TipoForm_Load);
        }
        private void TipoForm_Load(object sender, EventArgs e)
        {
            LoadTipoData();
        }
        private void LoadTipoData()
        {
            string consulta = @"
            SELECT 
                Tipo.Id,
                Tipo.Nombre
            FROM Tipo";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_tipo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de tipo: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textb_buscar.Text))
            {
                MessageBox.Show("Ingrese un término de búsqueda.");
                return;
            }

            string consulta = @"
               SELECT 
                Tipo.Id,
                Tipo.Nombre
            FROM Tipo
            WHERE Tipo.Nombre LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_tipo.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            LoadTipoData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_tipo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el usuario para eliminar.");
                return;
            }


            int artistaId = Convert.ToInt32(dataGV_tipo.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este tipo?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM Tipo WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", artistaId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Tipo eliminado correctamente.");
                        LoadTipoData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el tipo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();

                // Consulta SQL para insertar los datos en ObjetoDeArte
                string query = @"
                INSERT INTO Tipo
                (Nombre) 
                VALUES 
                (@Nombre)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicke
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Tipo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTipoData();
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
        }
    }
}
