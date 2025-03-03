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
    public partial class Caracteristica : Form
    {
        conexionbd conexion = new conexionbd();
        public Caracteristica()
        {
            InitializeComponent();
            this.Load += new EventHandler(CaracteristicaForm_Load);
        }

        private void CaracteristicaForm_Load(object sender, EventArgs e)
        {
            LoadCaracteristicaData();
            LoadObjetoList();

        }

        private void LoadCaracteristicaData()
        {
            string consulta = @"
                SELECT 
                    CaracteristicasObjetoDeArte.Id,
                    CaracteristicasObjetoDeArte.TipoPintura,
                    CaracteristicasObjetoDeArte.Altura,
                    CaracteristicasObjetoDeArte.Anchura,
                    CaracteristicasObjetoDeArte.DetalleOtro,
                    ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS TituloObjeto
                FROM CaracteristicasObjetoDeArte
                LEFT JOIN ObjetoDeArte ON CaracteristicasObjetoDeArte.ObjetoDeArteId = ObjetoDeArte.Id;";   

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_carect.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las características del objeto: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadObjetoList()
        {
            string consultaPaises = "SELECT Id, Titulo FROM ObjetoDeArte";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbx_arte.DataSource = dt;
                cmbx_arte.DisplayMember = "Titulo";
                cmbx_arte.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el objeto de arte: " + ex.Message);
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
                LoadCaracteristicaData();
                return;
            }

            try
            {
                conexion.abrir();
                string query = @"
                SELECT 
                    CaracteristicasObjetoDeArte.Id,
                    CaracteristicasObjetoDeArte.TipoPintura,
                    CaracteristicasObjetoDeArte.Altura,
                    CaracteristicasObjetoDeArte.Anchura,
                    CaracteristicasObjetoDeArte.DetalleOtro,
                    ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS TituloObjeto
                FROM CaracteristicasObjetoDeArte
                LEFT JOIN ObjetoDeArte ON CaracteristicasObjetoDeArte.ObjetoDeArteId = ObjetoDeArte.Id
                WHERE 
                    CaracteristicasObjetoDeArte.TipoPintura LIKE @Busqueda 
                    OR CAST(CaracteristicasObjetoDeArte.Altura AS VARCHAR) LIKE @Busqueda 
                    OR CAST(CaracteristicasObjetoDeArte.Anchura AS VARCHAR) LIKE @Busqueda
                    OR CaracteristicasObjetoDeArte.DetalleOtro LIKE @Busqueda";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.conectarbd);
                adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + searchText + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_carect.DataSource = dt;

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
            LoadCaracteristicaData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage3;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_carect.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la caracteristica para eliminar.");
                return;

            }

            int caracteristicaId = Convert.ToInt32(dataGV_carect.SelectedRows[0].Cells["Id"].Value);
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta caracteristica?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }
            string query = "DELETE FROM CaracteristicasObjetoDeArte WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", caracteristicaId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Caracteristica eliminada correctamente.");
                        LoadCaracteristicaData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar caracteristica.");
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();

                //Consulta SQL 
                string query = @"INSERT INTO CaracteristicasObjetoDeArte (ObjetoDeArteId, TipoPintura, Altura, Anchura, DetalleOtro) 
                         VALUES (@ObjetoDeArteId, @TipoPintura, @Altura, @Anchura, @DetalleOtro)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                //Pasar los valores de los TextBox 
                comando.Parameters.AddWithValue("@ObjetoDeArteId", cmbx_arte.SelectedValue);
                comando.Parameters.AddWithValue("@TipoPintura", text_pintura.Text);
                comando.Parameters.AddWithValue("@Altura", textb_altura.Text);
                comando.Parameters.AddWithValue("@Anchura", text_grosor.Text);
                comando.Parameters.AddWithValue("@DetalleOtro", text_detalles.Text);

                // Ejecutar la consulta de inserción
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Caracteristica guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    LoadCaracteristicaData();
                }
                else
                {
                    MessageBox.Show("No se guardó la caracteristica. Verifica los datos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cmbx_arte.SelectedIndex = -1;
            text_pintura.Clear();
            textb_altura.Clear();
            text_grosor.Clear();
            text_detalles.Clear();
        }
    }
}
