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
    public partial class Estilo : Form
    {
        conexionbd conexion = new conexionbd();
        public Estilo()
        {
            InitializeComponent();
            this.Load += new EventHandler(EstiloForm_Load);
        }

        private void EstiloForm_Load(object sender, EventArgs e)
        {
            LoalEstiloData();
        }

        private void LoalEstiloData()
        {
            string consulta = @"
            SELECT 
                Estilo.Id,
                Estilo.Nombre
            FROM Estilo";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_Estilo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de estilo" + ex.Message);
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
                  Estilo.Id,
                  Estilo.Nombre
            FROM Estilo
            WHERE Estilo.Nombre LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_Estilo.DataSource = dt;
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
            LoalEstiloData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_Estilo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el estilo para eliminar.");
                return;
            }


            int estiloId = Convert.ToInt32(dataGV_Estilo.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este estilo?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM Estilo WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", estiloId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Estilo eliminado correctamente.");
                        LoalEstiloData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el estilo.");
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

                
                string query = @"
                INSERT INTO Estilo
                (Nombre) 
                VALUES 
                (@Nombre)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Estilo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoalEstiloData();
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
