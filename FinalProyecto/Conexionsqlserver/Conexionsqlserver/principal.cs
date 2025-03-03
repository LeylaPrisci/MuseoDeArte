using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexionsqlserver
{
    public partial class principal : Form
    {

        conexionbd conexion = new conexionbd();
        private string usuario;
        private int rolId;
        public principal(string usuarioAutenticado)
        {
            InitializeComponent();
            usuario = usuarioAutenticado;
            CargarDatosUsuario(); // Obtiene nombre, rol y habilita/deshabilita el botón
            InicializarPanelMenu(); // Configuración inicial del panel
        }

        private void InicializarPanelMenu()
        {
            panel_menu.Visible = false; // Asegurarse de que inicie oculto
            panel_menu.BringToFront(); // Asegurarse de que está por encima de otros controles
        }

        private void CargarDatosUsuario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.conectarbd.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT u.NombreUsuario, u.RolId, r.Nombre 
                    FROM Usuarios u
                    INNER JOIN Roles r ON u.RolId = r.Id
                    WHERE u.NombreUsuario = @usuario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label_usuario.Text = "Usuario: " + reader["NombreUsuario"].ToString();
                                label_rol.Text = "Rol: " + reader["Nombre"].ToString(); // Muestra el nombre del rol

                                rolId = Convert.ToInt32(reader["RolId"]); // Guarda el rol del usuario
                                btn_menu.Enabled = (rolId == 1); // Habilita btn_menu solo si el rol es 1 (admin)
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el usuario en la base de datos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del usuario: " + ex.Message);
            }
        }


       

        private void AlternarMenu()
        {
            panel_menu.Visible = !panel_menu.Visible; // Alternar visibilidad
            panel_menu.BringToFront(); // Asegurar que el panel se muestre por encima de otros controles
            panel_menu.Refresh(); // Forzar redibujado
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionbd conexion = new conexionbd();
            conexion.abrir();
            panel_menu.BringToFront();
        }



        private void btn_artistas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ArtistForm
            ArtistForm artistForm = new ArtistForm(usuario);

            // Mostrar ArtistForm y ocultar Form1
            artistForm.Show();
            this.Hide();

            // Evento para mostrar Form1 nuevamente cuando ArtistForm se cierre
            artistForm.FormClosed += (s, args) => this.Show();
        }

        private void btn_obras_Click(object sender, EventArgs e)
        {
             // Crear una instancia del formulario ArtistForm
            ObraDeArte obraDeArte = new ObraDeArte(usuario);

            // Mostrar ArtistForm y ocultar Form1
            obraDeArte.Show();
            this.Hide();

            // Evento para mostrar Form1 nuevamente cuando ObraDeArte se cierre
            obraDeArte.FormClosed += (s, args) => this.Show();
        }

        private void btn_exibicion_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ArtistForm
            Exhibicion exhibicion = new Exhibicion(usuario);

            // Mostrar ArtistForm y ocultar Form1
            exhibicion.Show();
            this.Hide();

            // Evento para mostrar Form1 nuevamente cuando ObraDeArte se cierre
            exhibicion.FormClosed += (s, args) => this.Show();
        }

        private void btn_coleccion_prestamo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ArtistForm
            Colecciones coleccion_Prestamos = new Colecciones(usuario);

            // Mostrar ArtistForm y ocultar Form1
            coleccion_Prestamos.Show();
            this.Hide();

            // Evento para mostrar Form1 nuevamente cuando ObraDeArte se cierre
            coleccion_Prestamos.FormClosed += (s, args) => this.Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            AlternarMenu();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ArtistForm
            Usuario Usuario= new Usuario();

            // Mostrar ArtistForm y ocultar Form1
            Usuario.Show();
            this.Hide();

            // Evento para mostrar Form1 nuevamente cuando ObraDeArte se cierre
            Usuario.FormClosed += (s, args) => this.Show();
        }

        private void btn_tipo_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario ArtistForm
            Tipo Tipo = new Tipo();

            // Mostrar ArtistForm y ocultar Form1
            Tipo.Show();
            this.Hide();

            // Evento para mostrar Form1 nuevamente cuando ObraDeArte se cierre
            Tipo.FormClosed += (s, args) => this.Show();
        }

        private void btn_paises_Click(object sender, EventArgs e)
        {
           
            Paises Paises = new Paises();

            Paises.Show();
            this.Hide();

            Paises.FormClosed += (s, args) => this.Show();
        }

        private void btn_obj_material_Click(object sender, EventArgs e)
        {
            ObjMaterial ObjMaterial = new ObjMaterial();

            ObjMaterial.Show();
            this.Hide();

            ObjMaterial.FormClosed += (s, args) => this.Show();
        }

        private void btn_obj_estilo_Click(object sender, EventArgs e)
        {
            ObjEstilo ObjEstilo = new ObjEstilo();

            ObjEstilo.Show();
            this.Hide();

            ObjEstilo.FormClosed += (s, args) => this.Show();
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            Material Material = new Material();

            Material.Show();
            this.Hide();

            Material.FormClosed += (s, args) => this.Show();
        }

        private void btn_obj_exhibicion_Click(object sender, EventArgs e)
        {
            ExhibicionObj ExhibicionObj = new ExhibicionObj();

            ExhibicionObj.Show();
            this.Hide();

            ExhibicionObj.FormClosed += (s, args) => this.Show();
        }

        private void btn_estilo_Click(object sender, EventArgs e)
        {
            Estilo Estilo = new Estilo();

            Estilo.Show();
            this.Hide();

            Estilo.FormClosed += (s, args) => this.Show();
        }

        private void btn_clasif_Click(object sender, EventArgs e)
        {
            Clasificacion Clasificacion = new Clasificacion();

            Clasificacion.Show();
            this.Hide();

            Clasificacion.FormClosed += (s, args) => this.Show();
        }

        private void btn_caracterist_Click(object sender, EventArgs e)
        {
            Caracteristica Caracteristica = new Caracteristica();

            Caracteristica.Show();
            this.Hide();

            Caracteristica.FormClosed += (s, args) => this.Show();
        }
    }
}
