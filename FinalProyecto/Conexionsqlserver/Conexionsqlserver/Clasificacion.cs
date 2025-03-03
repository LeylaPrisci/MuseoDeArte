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
    public partial class Clasificacion : Form
    {
        conexionbd conexion = new conexionbd();
        public Clasificacion()
        {
            InitializeComponent();
            this.Load += new EventHandler(ClasificacionForm_Load);
        }

        private void ClasificacionForm_Load(object sender, EventArgs e)
        {
            LoadClasificacionData();
        }

        private void LoadClasificacionData()
        {
            string consulta = @"
            SELECT 
                Clasificacion.Id,
                Clasificacion.Nombre
            FROM Clasificacion";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_clasif.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la clasificación: " + ex.Message);
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
                Clasificacion.Id,
                Clasificacion.Nombre
            FROM Clasificacion
            WHERE Clasificacion.Nombre LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_clasif.DataSource = dt;
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
            LoadClasificacionData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (dataGV_clasif.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el clasificación para eliminar.");
                return;
            }


            int clasificacionId = Convert.ToInt32(dataGV_clasif.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este clasificación?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM Clasificacion WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", clasificacionId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("clasificacion eliminado correctamente.");
                        LoadClasificacionData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el clasificion.");
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
                INSERT INTO Clasificacion
                (Nombre) 
                VALUES 
                (@Nombre)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

               
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Clasificacion guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClasificacionData();
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
