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
    public partial class ObjMaterial : Form
    {
        conexionbd conexion = new conexionbd();
        public ObjMaterial()
        {
            InitializeComponent();
            this.Load += new EventHandler(ObjMaterialForm_Load);
        }

        private void ObjMaterialForm_Load(object sender, EventArgs e)
        {
            LoadObjMaterialData();
            LoadObjetoMaterialList();
            LoadObjetoList();



        }
        private void LoadObjMaterialData()
        {
            string consulta = @"
            SELECT 
                 ObjetoDeArteMaterial.Id,
                ISNULL(Material.Nombre, 'Desconocido') AS MaterialId,
                ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS ObjetoDeArteId
            FROM ObjetoDeArteMaterial
            LEFT JOIN ObjetoDeArte ON ObjetoDeArteMaterial.ObjetoDeArteId = ObjetoDeArte.Id
            LEFT JOIN Material ON ObjetoDeArteMaterial.MaterialId = Material.Id;";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_ObjMaterial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del objeto material: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadObjetoMaterialList()
        {
            string consultaPaises = "SELECT Id, Nombre FROM Material";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbox_material.DataSource = dt;
                cmbox_material.DisplayMember = "Nombre";
                cmbox_material.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el objeto de material: " + ex.Message);
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
               ObjetoDeArteMaterial.Id,
                ISNULL(Material.Nombre, 'Desconocido') AS MaterialId,
                ISNULL(ObjetoDeArte.Titulo, 'Desconocido') AS ObjetoDeArteId
            FROM ObjetoDeArteMaterial
            LEFT JOIN ObjetoDeArte ON ObjetoDeArteMaterial.ObjetoDeArteId = ObjetoDeArte.Id
            LEFT JOIN Material ON ObjetoDeArteMaterial.MaterialId = Material.Id
            WHERE  ObjetoDeArteMaterial.Id LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_ObjMaterial.DataSource = dt;
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
            LoadObjMaterialData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();

                // Consulta SQL para insertar los datos en ObjetoDeArte
                string query = @"
                INSERT INTO ObjetoDeArteMaterial
                (ObjetoDeArteId, MaterialId) 
                VALUES 
                (@ObjetoDeArteId, @MaterialId)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicke
                comando.Parameters.AddWithValue("@ObjetoDeArteId", cmbox_obj.SelectedValue);
                comando.Parameters.AddWithValue("@MaterialId", cmbox_material.SelectedValue);

                comando.ExecuteNonQuery();

                MessageBox.Show("Objeto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadObjMaterialData();
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
            cmbox_material.SelectedIndex = -1;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_ObjMaterial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el objeto para eliminar.");
                return;
            }


            int objetoId = Convert.ToInt32(dataGV_ObjMaterial.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este objeto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }


            string query = "DELETE FROM ObjetoDeArteMaterial WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", objetoId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Pais eliminado correctamente.");
                        LoadObjMaterialData();
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
    }
}
