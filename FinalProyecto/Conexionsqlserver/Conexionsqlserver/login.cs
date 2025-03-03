using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexionsqlserver
{
    public partial class login : Form
    {
        conexionbd conexion = new conexionbd(); // Instancia de la conexión a la base de datos

        public login()
        {
            InitializeComponent();
        }

        public string UsuarioAutenticado { get; private set; }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            string usuario = textb_usuario.Text;
            string contraseña = textb_contraseña.Text;

            if (ValidarUsuario(usuario, contraseña))
            {
                UsuarioAutenticado = usuario; // Guarda el usuario autenticado
                this.DialogResult = DialogResult.OK; // Indica que el login fue exitoso
                this.Close(); // Cierra el formulario de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textb_usuario.Clear();
                textb_contraseña.Clear();
                textb_usuario.Focus();
            }
        }



        private bool ValidarUsuario(string usuario, string contraseña)
        {
            bool esValido = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.conectarbd.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            esValido = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message);
            }

            return esValido;
        }

        private void btn_cerrarSeccion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }
    }
}