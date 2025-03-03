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
    public partial class ObjEstilo : Form
    {
        conexionbd conexion = new conexionbd();
        public ObjEstilo()
        {
            InitializeComponent();
            this.Load += new EventHandler(ObjEstiloForm_Load);
        }

        private void ObjEstiloForm_Load(object sender, EventArgs e)
        {
            LoadObjEstiloData();
            LoadObjetoEstiloList();
            LoadObjetoList();

        }

        private void LoadObjEstiloData()
        {
            string consulta = @"
            SELECT 
                ObjetoDeArteEstilo.Id,
                ISNULL(Estilo.Nombre, 'Desconocido') AS EstiloId,
                ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS ObjetoDeArteId
            FROM ObjetoDeArteEstilo
            LEFT JOIN ObjetoDeArte ON ObjetoDeArteEstilo.ObjetoDeArteId = ObjetoDeArte.Id
            LEFT JOIN Estilo ON ObjetoDeArteEstilo.EstiloId = Estilo.Id;";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_ObjEstilo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del objeto estilo: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadObjetoEstiloList()
        {
            string consultaPaises = "SELECT Id, Nombre FROM Estilo";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbox_estilo.DataSource = dt;
                cmbox_estilo.DisplayMember = "Nombre";
                cmbox_estilo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el objeto de estilo: " + ex.Message);
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
                cmbox_obj.DataSource = dt;
                cmbox_obj.DisplayMember = "Titulo";
                cmbox_obj.ValueMember = "Id";
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
            if (string.IsNullOrWhiteSpace(textb_buscar.Text))
            {
                MessageBox.Show("Ingrese un término de búsqueda.");
                return;
            }

            string consulta = @"
                SELECT 
                    ObjetoDeArteEstilo.Id,
                    ISNULL(Estilo.Nombre, 'Desconocido') AS EstiloId,
                    ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS ObjetoDeArteId
                FROM ObjetoDeArteEstilo
                LEFT JOIN ObjetoDeArte ON ObjetoDeArteEstilo.ObjetoDeArteId = ObjetoDeArte.Id
                LEFT JOIN Estilo ON ObjetoDeArteEstilo.EstiloId = Estilo.Id
                WHERE   ObjetoDeArteEstilo.Id LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_ObjEstilo.DataSource = dt;
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
            LoadObjEstiloData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_ObjEstilo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el objeto para eliminar.");
                return;
            }


            int objetoId = Convert.ToInt32(dataGV_ObjEstilo.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este objeto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM ObjetoDeArteEstilo WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", objetoId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Objeto eliminado correctamente.");
                        LoadObjEstiloData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Objeto.");
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
                INSERT INTO ObjetoDeArteEstilo
                (ObjetoDeArteId, EstiloId) 
                VALUES 
                (@ObjetoDeArteId, @EstiloId)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicke
                comando.Parameters.AddWithValue("@ObjetoDeArteId", cmbox_obj.SelectedValue);
                comando.Parameters.AddWithValue("@EstiloId", cmbox_estilo.SelectedValue);

                comando.ExecuteNonQuery();

                MessageBox.Show("Objeto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadObjEstiloData();
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

            cmbox_obj.SelectedIndex = -1;
            cmbox_estilo.SelectedIndex = -1;
        }
    }
}
