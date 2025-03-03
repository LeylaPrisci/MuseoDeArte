using System;
using System.Windows.Forms;

namespace Conexionsqlserver
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el login primero
            login loginForm = new login();
            if (loginForm.ShowDialog() == DialogResult.OK) // Si el login es exitoso
            {
                // Obtener el usuario autenticado desde el login
                string usuarioAutenticado = loginForm.UsuarioAutenticado;

                // Pasarlo al formulario principal
                Application.Run(new principal(usuarioAutenticado));

            }
        }
    }
}
