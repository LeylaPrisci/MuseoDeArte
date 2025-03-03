using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexionsqlserver
{
    public partial class ArtistForm : Form
    {
        conexionbd conexion = new conexionbd();
        private string usuario;
        private int rolId;

        public ArtistForm(string usuarioAutenticado)
        {
            InitializeComponent();
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
                text_epoca.Enabled = false;
                text_descripcion.Enabled = false;
                dateTp_fch_naci.Enabled = false;
                dateTp_fch_fallecimiento.Enabled = false;
                cmbx_Pais.Enabled = false;
                cmbx_Estilo.Enabled = false;
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

        private void ArtistForm_Load(object sender, EventArgs e)
        {
            LoadArtistData();
            LoadCountryList();
            LoadEstiloList();
        }

        private void LoadArtistData()
        {
            string consulta = @"
            SELECT 
                Artista.Id,
                Artista.Nombre,
                Artista.FechaNacimiento,
                Artista.FechaFallecimiento,
                ISNULL(Pais.Nombre, 'Desconocido') AS PaisOrigenId,
                Artista.Epoca,
                ISNULL(Estilo.Nombre, 'Desconocido') AS EstiloPrincipal,
                Artista.Descripcion
            FROM Artista
            LEFT JOIN Estilo ON Artista.EstiloPrincipal = Estilo.Id
            LEFT JOIN Pais ON Artista.PaisOrigenId = Pais.Id;";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de artistas: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadCountryList()
        {
            string consultaPaises = "SELECT Id, Nombre FROM Pais";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbx_Pais.DataSource = dt;
                cmbx_Pais.DisplayMember = "Nombre";
                cmbx_Pais.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar países: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadEstiloList()
        {
            string consultaEstilos = "SELECT Id, Nombre FROM Estilo";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaEstilos, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbx_Estilo.DataSource = dt;
                cmbx_Estilo.DisplayMember = "Nombre";
                cmbx_Estilo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estilos: " + ex.Message);
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
                    Artista.Id,
                    Artista.Nombre,
                    Artista.FechaNacimiento,
                    Artista.FechaFallecimiento,
                    ISNULL(Pais.Id, 0) AS PaisOrigenId,
                    Artista.Epoca,
                    Artista.EstiloPrincipal,
                    Artista.Descripcion
                FROM Artista
                LEFT JOIN Pais ON Artista.PaisOrigenId = Pais.Id
                WHERE Artista.Nombre LIKE @Busqueda OR Artista.Epoca LIKE @Busqueda OR Artista.EstiloPrincipal LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
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
            LoadArtistData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage3;
        }

       
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            text_nombre.Clear();
            text_epoca.Clear();
            text_descripcion.Clear();
            dateTp_fch_naci.Value = DateTime.Today;
            dateTp_fch_fallecimiento.Value = DateTime.Today;
            cmbx_Pais.SelectedIndex = -1;
            cmbx_Estilo.SelectedIndex = -1;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un artista para eliminar.");
                return;
            }

            // Obtener el ID del artista seleccionado
            int artistaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este artista?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Consulta SQL para eliminar
            string query = "DELETE FROM Artista WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", artistaId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Artista eliminado correctamente.");
                        LoadArtistData(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el artista.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar artista: " + ex.Message);
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
                INSERT INTO Artista 
                (Nombre, FechaNacimiento, FechaFallecimiento, PaisOrigenId, Epoca, EstiloPrincipal, Descripcion) 
                VALUES 
                (@Nombre, @FechaNacimiento, @FechaFallecimiento, @PaisOrigenId, @Epoca, @EstiloPrincipal, @Descripcion)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicker
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);
                comando.Parameters.AddWithValue("@PaisOrigenId", cmbx_Pais.SelectedValue);
                comando.Parameters.AddWithValue("@Epoca", text_epoca.Text);
                comando.Parameters.AddWithValue("@EstiloPrincipal", cmbx_Estilo.SelectedValue);
                comando.Parameters.AddWithValue("@FechaNacimiento", dateTp_fch_naci.Value);
                comando.Parameters.AddWithValue("@FechaFallecimiento", dateTp_fch_fallecimiento.Value);
                comando.Parameters.AddWithValue("@Descripcion", text_descripcion.Text);

                // Ejecutar la consulta
                comando.ExecuteNonQuery();

                MessageBox.Show("Objeto de Arte guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar los datos en el DataGridView
                LoadArtistData();
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
    }
}
