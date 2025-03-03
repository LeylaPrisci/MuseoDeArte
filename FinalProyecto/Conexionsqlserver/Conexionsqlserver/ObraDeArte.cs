using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexionsqlserver
{

    public partial class ObraDeArte : Form
    {

        conexionbd conexion = new conexionbd();
        private string usuario;
        private int rolId;
        public ObraDeArte(string usuarioAutenticado)
        {
            InitializeComponent();
            this.Load += new EventHandler(ObraDeArte_Load);
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
                cmbx_Artista.Enabled = false;
                cmbx_tipo.Enabled = false;
                cmbx_categoria.Enabled = false;
                cmbx_Pais.Enabled = false;
                cmbox_clasificacion.Enabled = false;
                cmbox_usuario.Enabled = false;
                dateTp_fechacreacion.Enabled=false;
                text_descripcion.Enabled = false;
                dateTp_adquisicion.Enabled = false;
                dateTp_prestamo.Enabled = false;
                textb_estado.Enabled = false;
                text_titulo.Enabled = false;
                texb_epoca.Enabled = false;
                textb_coste.Enabled = false;
                dateTp_devolucion.Enabled = false;
                dateTp_fecha_alta.Enabled = false;
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

        private void ObraDeArte_Load(object sender, EventArgs e)
        {
            LoadObraDeArteData();
            LoadCountryList();
            LoadArtistaList();
            LoadTipoList();
            LoadColeccionList();
            LoadUsuarioList();  // Llamar al método para cargar usuarios
            LoadClasificacionList();
        }


        private void LoadObraDeArteData()
        {
            try
            {
                conexion.abrir();

                // Consulta SQL corregida
                string query = @"
                SELECT 
                     O.Id,
                    A.Nombre AS Artista,
                    O.AnioCreacion,
                    O.Titulo,
                    O.Descripcion,
                    T.Nombre AS Tipo,
                    C.Nombre AS Clasificacion,
                    O.FechaAdquisicion,
                    O.Coste,
                    C.Nombre AS ColeccionPropietaria,
                    O.FechaPrestamo,
                    O.FechaDevolucion,
                    P.Nombre AS PaisOrigen,
                    O.Epoca,
                    O.Estado,
                    U.NombreUsuario AS Usuario,
                    O.FechaHoraAlta    
                FROM ObjetoDeArte O
                  LEFT JOIN Artista A ON O.Artistaid = A.Id
                  LEFT JOIN Tipo T ON O.Tipoid = T.Id
                  LEFT JOIN Clasificacion C ON O.Clasificacionid = C.Id
                  LEFT JOIN Coleccion CP ON O.ColeccionPropietariaid = CP.Id
                  LEFT JOIN Pais P ON O.PaisOrigenid = P.Id
                  LEFT JOIN Usuarios U ON O.Usuario = U.Id;";


                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Asegurar que la DataGridView muestre los datos
                dgv_Objetos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }




        private void LoadCountryList()
        {
            string consultaPaises = "SELECT Id, Nombre FROM Pais";
            SqlDataAdapter adaptadorPaises = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
            DataTable dtPaises = new DataTable();
            adaptadorPaises.Fill(dtPaises);

            cmbx_Pais.DataSource = dtPaises;
            cmbx_Pais.DisplayMember = "Nombre";  // Muestra el nombre
            cmbx_Pais.ValueMember = "Id";  // Usa el Id como valor
        }

        

       private void LoadArtistaList()
        {
            string consultaArtista = "SELECT Id, Nombre FROM Artista";
            SqlDataAdapter adaptadorArtista = new SqlDataAdapter(consultaArtista, conexion.conectarbd);
            DataTable dtArtista = new DataTable();
            adaptadorArtista.Fill(dtArtista);

            cmbx_Artista.DataSource = dtArtista;
            cmbx_Artista.DisplayMember = "Nombre";
            cmbx_Artista.ValueMember = "Id"; // Usa el Id como valor
        }

        private void LoadTipoList()
        {
            try
            {
                conexion.abrir();

                // Consulta SQL para combinar los tipos
                string consultaTipo = "SELECT Id, Nombre FROM Tipo";
                SqlDataAdapter adaptadorTipo = new SqlDataAdapter(consultaTipo, conexion.conectarbd);
                DataTable dtTipo = new DataTable();

                adaptadorTipo.Fill(dtTipo);

                // Configurar el ComboBox
                cmbx_tipo.DataSource = dtTipo;
                cmbx_tipo.DisplayMember = "Nombre";  // Muestra el nombre (Pintura, Escultura, Otro)
                cmbx_tipo.ValueMember = "Id";       // Usa el Id (1, 2, 3) como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadColeccionList()
        {
            try
            {
                conexion.abrir();

                // Consulta SQL para combinar los tipos
                string consultaColeccion = "SELECT Id, Nombre FROM Coleccion";
                SqlDataAdapter adaptadorCategoria = new SqlDataAdapter(consultaColeccion, conexion.conectarbd);
                DataTable dtCategoria = new DataTable();

                adaptadorCategoria.Fill(dtCategoria);

                // Configurar el ComboBox
                cmbx_categoria.DataSource = dtCategoria;
                cmbx_categoria.DisplayMember = "Nombre";  // Muestra el nombre (Pintura, Escultura, Otro)
                cmbx_categoria.ValueMember = "Id";       // Usa el Id (1, 2, 3) como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }
        private void LoadUsuarioList()
        {
            try
            {
                conexion.abrir();

                // Consulta SQL para obtener la lista de usuarios
                string consultaUsuarios = "SELECT Id, NombreUsuario FROM Usuarios";
                SqlDataAdapter adaptadorUsuarios = new SqlDataAdapter(consultaUsuarios, conexion.conectarbd);
                DataTable dtUsuarios = new DataTable();
                adaptadorUsuarios.Fill(dtUsuarios);

                // Configurar el ComboBox
                cmbox_usuario.DataSource = dtUsuarios;
                cmbox_usuario.DisplayMember = "NombreUsuario";  // Muestra el nombre de usuario
                cmbox_usuario.ValueMember = "Id";  // Usa el Id como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadClasificacionList()
        {
            try
            {
                conexion.abrir();

                // Consulta SQL para obtener la lista de usuarios
                string consultaClasificacion = "SELECT Id, Nombre FROM Clasificacion";
                SqlDataAdapter adaptadorClasificacion = new SqlDataAdapter(consultaClasificacion, conexion.conectarbd);
                DataTable dtClasificacion = new DataTable();
                adaptadorClasificacion.Fill(dtClasificacion);

                // Configurar el ComboBox
                cmbox_clasificacion.DataSource = dtClasificacion;
                cmbox_clasificacion.DisplayMember = "Nombre";  // Muestra el nombre de usuario
                cmbox_clasificacion.ValueMember = "Id";  // Usa el Id como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message);
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
                LoadObraDeArteData(); // Si el textbox está vacío, cargar todos los datos
                return;
            }

            try
            {
                conexion.abrir();

                // Consulta SQL con búsqueda flexible
                string query = @"
                SELECT 
                    O.Id,
                    A.Nombre AS Artista,
                    O.AnioCreacion,
                    O.Titulo,
                    O.Descripcion,
                    T.Nombre AS Tipo,
                    C.Nombre AS Clasificacion,
                    O.FechaAdquisicion,
                    O.Coste,
                    C.Nombre AS ColeccionPropietaria,
                    O.FechaPrestamo,
                    O.FechaDevolucion,
                    P.Nombre AS PaisOrigen,
                    O.Epoca,
                    O.Estado,
                    U.NombreUsuario AS Usuario,
                    O.FechaHoraAlta    
                FROM ObjetoDeArte O
                  LEFT JOIN Artista A ON O.Artistaid = A.Id
                  LEFT JOIN Tipo T ON O.Tipoid = T.Id
                  LEFT JOIN Clasificacion C ON O.Clasificacionid = C.Id
                  LEFT JOIN Coleccion CP ON O.ColeccionPropietariaid = CP.Id
                  LEFT JOIN Pais P ON O.PaisOrigenid = P.Id
                  LEFT JOIN Usuarios U ON O.Usuario = U.Id
                WHERE 
                    O.Titulo LIKE @search OR
                    A.Nombre LIKE @search OR
                    P.Nombre LIKE @search OR
                    CP.Nombre LIKE @search";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.conectarbd);
                adaptador.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Mostrar los datos en la DataGridView
                dgv_Objetos.DataSource = dt;
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
            LoadObraDeArteData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Objetos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Objeto para eliminar.");
                return;
            }
            int objetoId = Convert.ToInt32(dgv_Objetos.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este objeto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = "DELETE FROM ObjetoDeArte WHERE Id = @Id";

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
                        LoadObraDeArteData(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el objeto.");
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
                INSERT INTO ObjetoDeArte 
                (Artistaid, AnioCreacion, Titulo, Descripcion, Tipoid, Clasificacionid, FechaAdquisicion, Coste, ColeccionPropietariaid, 
                FechaPrestamo, FechaDevolucion, PaisOrigenid, Epoca, Estado, Usuario, FechaHoraAlta) 
                VALUES 
                (@Artistaid, @AnioCreacion, @Titulo, @Descripcion, @Tipoid, @Clasificacionid, @FechaAdquisicion, @Coste, @ColeccionPropietariaid, 
                @FechaPrestamo, @FechaDevolucion, @PaisOrigenid, @Epoca, @Estado, @Usuario, @FechaHoraAlta)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicker
                comando.Parameters.AddWithValue("@Artistaid", cmbx_Artista.SelectedValue);
                comando.Parameters.AddWithValue("@AnioCreacion", dateTp_fechacreacion.Value.Year); // Solo el año de creación
                comando.Parameters.AddWithValue("@Titulo", text_titulo.Text);
                comando.Parameters.AddWithValue("@Descripcion", text_descripcion.Text);
                comando.Parameters.AddWithValue("@Tipoid", cmbx_tipo.SelectedValue);
                comando.Parameters.AddWithValue("@Clasificacionid", cmbox_clasificacion.SelectedValue);
                comando.Parameters.AddWithValue("@FechaAdquisicion", dateTp_adquisicion.Value);
                comando.Parameters.AddWithValue("@Coste", textb_coste.Text);
                comando.Parameters.AddWithValue("@ColeccionPropietariaid", cmbx_categoria.SelectedValue);
                comando.Parameters.AddWithValue("@FechaPrestamo", dateTp_prestamo.Value);
                comando.Parameters.AddWithValue("@FechaDevolucion", dateTp_devolucion.Value);
                comando.Parameters.AddWithValue("@PaisOrigenid", cmbx_Pais.SelectedValue);
                comando.Parameters.AddWithValue("@Epoca", texb_epoca.Text);
                comando.Parameters.AddWithValue("@Estado", textb_estado.Text);
                comando.Parameters.AddWithValue("@Usuario", cmbox_usuario.SelectedValue);
                comando.Parameters.AddWithValue("@FechaHoraAlta", dateTp_fecha_alta.Value);

                // Ejecutar la consulta
                comando.ExecuteNonQuery();

                MessageBox.Show("Objeto de Arte guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar los datos en el DataGridView
                LoadObraDeArteData();
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
            // Limpiar los TextBox
            text_descripcion.Clear();
            textb_estado.Clear();
            text_titulo.Clear();
            texb_epoca.Clear();
            textb_coste.Clear();

            cmbx_Artista.SelectedIndex = -1;
            cmbx_tipo.SelectedIndex = -1;
            cmbx_categoria.SelectedIndex = -1;
            cmbx_Pais.SelectedIndex = -1;
            cmbox_clasificacion.SelectedIndex = -1;
            cmbox_usuario.SelectedIndex = -1;

            dateTp_fechacreacion.Value = DateTime.Now;
            dateTp_adquisicion.Value = DateTime.Now;
            dateTp_prestamo.Value = DateTime.Now;
            dateTp_devolucion.Value = DateTime.Now;
            dateTp_fecha_alta.Value = DateTime.Now; 

        }
    }
}
