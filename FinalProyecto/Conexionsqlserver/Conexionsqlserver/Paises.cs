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
    public partial class Paises : Form
    {
        conexionbd conexion = new conexionbd();
        public Paises()
        {
            InitializeComponent();
            this.Load += new EventHandler(PaisForm_Load);
        }

        private void PaisForm_Load(object sender, EventArgs e)
        {
            LoadPaisData();
        }

        private void LoadPaisData()
        {
            string consulta = @"
            SELECT 
                Pais.Id,
                Pais.Nombre
            FROM Pais";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_pais.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de pais: " + ex.Message);
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
                Pais.Id,
                Pais.Nombre
            FROM Pais
            WHERE Pais.Nombre LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_pais.DataSource = dt;
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
            LoadPaisData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_pais.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el pais para eliminar.");
                return;
            }


            int paisId = Convert.ToInt32(dataGV_pais.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este pais?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM Pais WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", paisId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Pais eliminado correctamente.");
                        LoadPaisData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el pais.");
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
                INSERT INTO Pais
                (Nombre) 
                VALUES 
                (@Nombre)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicke
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Pais guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPaisData();
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
