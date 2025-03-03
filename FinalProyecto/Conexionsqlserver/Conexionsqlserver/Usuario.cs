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
    public partial class Usuario : Form
    {
        conexionbd conexion = new conexionbd();
        public Usuario()
        {
            InitializeComponent();
            this.Load += new EventHandler(UsuarioForm_Load);
        }
        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            LoadUsuarioData();
            LoadRolesList();


        }

        private void LoadUsuarioData()
        {
            string consulta = @"
            SELECT 
                Usuarios.Id,
                Usuarios.NombreUsuario,
                Usuarios.Contraseña,
                Usuarios.DNI,
                Usuarios.Apellido,
                Usuarios.Nombre,
                Usuarios.Direccion,
                Usuarios.Telefono,
                ISNULL(Roles.Nombre, 'Desconocido') AS RolId
            FROM Usuarios
            LEFT JOIN Roles ON Usuarios.RolId = Roles.Id;";

            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGV_usuario.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LoadRolesList()
        {
            string consultaPaises = "SELECT Id, Nombre FROM Roles";
            try
            {
                conexion.abrir();
                SqlDataAdapter adaptador = new SqlDataAdapter(consultaPaises, conexion.conectarbd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbx_Rol.DataSource = dt;
                cmbx_Rol.DisplayMember = "Nombre";
                cmbx_Rol.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
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
                Usuarios.NombreUsuario,
                Usuarios.Contraseña,
                Usuarios.DNI,
                Usuarios.Apellido,
                Usuarios.Nombre,
                Usuarios.Direccion,
                Usuarios.Telefono,
                ISNULL(Roles.Nombre, 'Desconocido') AS RolId
            FROM Usuarios
            LEFT JOIN Roles ON Usuarios.RolId = Roles.Id
            WHERE Usuarios.NombreUsuario LIKE @Busqueda OR Usuarios.DNI LIKE @Busqueda OR Usuarios.Apellido LIKE @Busqueda OR Usuarios.Nombre LIKE @Busqueda OR Usuarios.Direccion LIKE @Busqueda OR Usuarios.Telefono LIKE @Busqueda OR Usuarios.RolId LIKE @Busqueda";

            try
            {
                conexion.abrir();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.conectarbd))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Busqueda", "%" + textb_buscar.Text + "%");
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGV_usuario.DataSource = dt;
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
            LoadUsuarioData();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            tab_modificado.SelectedTab = tabPage2;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGV_usuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el usuario para eliminar.");
                return;
            }

           
            int artistaId = Convert.ToInt32(dataGV_usuario.SelectedRows[0].Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este Usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

           
            string query = "DELETE FROM Usuarios WHERE Id = @Id";

            try
            {
                conexion.abrir();
                using (SqlCommand cmd = new SqlCommand(query, conexion.conectarbd))
                {
                    cmd.Parameters.AddWithValue("@Id", artistaId);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        LoadUsuarioData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Usuario: " + ex.Message);
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
                INSERT INTO Usuarios 
                (NombreUsuario, Contraseña, DNI, Apellido, Nombre, Direccion, Telefono, RolId) 
                VALUES 
                (@NombreUsuario, @Contraseña, @DNI, @Apellido, @Nombre, @Direccion, @Telefono, @RolId)";

                SqlCommand comando = new SqlCommand(query, conexion.conectarbd);

                // Asignar valores desde los ComboBox y DateTimePicke
                comando.Parameters.AddWithValue("@NombreUsuario", text_nombreUsuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", textb_contrasenia.Text);
                comando.Parameters.AddWithValue("@DNI", textb_dni.Text);
                comando.Parameters.AddWithValue("@Apellido", text_apellido.Text);
                comando.Parameters.AddWithValue("@Nombre", text_nombre.Text);
                comando.Parameters.AddWithValue("@Direccion", text_direccion.Text);
                comando.Parameters.AddWithValue("@Telefono", textb_telef.Text);
                comando.Parameters.AddWithValue("@RolId", cmbx_Rol.SelectedValue);
                

               
                comando.ExecuteNonQuery();

                MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                LoadUsuarioData();
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

            text_nombreUsuario.Clear();
            textb_contrasenia.Clear();
            textb_dni.Clear();
            text_apellido.Clear();
            text_nombre.Clear();
            text_direccion.Clear();
            textb_telef.Clear();
            cmbx_Rol.SelectedIndex = -1;
        }
    }
}
