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
    public partial class ExhibicionObj : Form
    {
        conexionbd conexion = new conexionbd();
        public ExhibicionObj()
        {
            InitializeComponent();
            this.Load += new EventHandler(ObjExhibicionForm_Load);
        }

        private void ObjExhibicionForm_Load(object sender, EventArgs e)
        {
            LoadObjExhibicionoData();
            LoadExhibicionList();
            LoadObjetoList();

        }

        private void LoadObjExhibicionoData()
        {
            string consulta = @"
            SELECT 
                ExhibicionObjetoDeArte.Id,
                ISNULL(Exhibicion.Nombre, 'Desconocido') AS ExhibicionId,
                ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS ObjetoDeArteId
            FROM ExhibicionObjetoDeArte
            LEFT JOIN ObjetoDeArte ON ExhibicionObjetoDeArte.ObjetoDeArteId = ObjetoDeArte.Id
            LEFT JOIN Exhibicion ON ExhibicionObjetoDeArte.ExhibicionId = Exhibicion.Id;";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_ObjExhibicion.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del objeto exhibicion: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }
        private void LoadExhibicionList()
        {
            string consultaPaises = "SELECT Id, Nombre FROM Exhibicion";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbox_exhibicion.DataSource = dt;
                cmbox_exhibicion.DisplayMember = "Nombre";
                cmbox_exhibicion.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el objeto de exhibicion: " + ex.Message);
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
                    ExhibicionObjetoDeArte.Id,
                    ISNULL(Exhibicion.Nombre, 'Desconocido') AS ExhibicionId,
                    ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS ObjetoDeArteId
                FROM ExhibicionObjetoDeArte
                LEFT JOIN ObjetoDeArte ON ExhibicionObjetoDeArte.ObjetoDeArteId = ObjetoDeArte.Id
                LEFT JOIN Exhibicion ON ExhibicionObjetoDeArte.ExhibicionId = Exhibicion.Id
                WHERE ExhibicionObjetoDeArte.Id LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_ObjExhibicion.DataSource = dt;
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
            LoadObjExhibicionoData(); 
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_ObjExhibicion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el objeto para eliminar.");
                return;
            }


            int objetoId = Convert.ToInt32(dataGV_ObjExhibicion.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este objeto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM ExhibicionObjetoDeArte WHERE Id = @Id";

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
                        LoadObjExhibicionoData();
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
                INSERT INTO ExhibicionObjetoDeArte
                (ObjetoDeArteId, ExhibicionId) 
                VALUES 
                (@ObjetoDeArteId, @ExhibicionId)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicke
                comando.Parameters.AddWithValue("@ObjetoDeArteId", cmbox_obj.SelectedValue);
                comando.Parameters.AddWithValue("@ExhibicionId", cmbox_exhibicion.SelectedValue);

                comando.ExecuteNonQuery();

                MessageBox.Show("Objeto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadObjExhibicionoData();
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
            cmbox_exhibicion.SelectedIndex = -1;
        }
    }
}
