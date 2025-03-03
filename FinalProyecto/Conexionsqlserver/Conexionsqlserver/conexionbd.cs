using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //libreria para la conexion

namespace Conexionsqlserver
{
    internal class conexionbd
    {
        //Cadena de conexion 
        string cadena = "Data Source=DESKTOP-59R7A1D\\SQLEXPRESS;Initial Catalog=MuseoDeBellasArte;Integrated Security=True";
        //Conexion
        public SqlConnection conectarbd = new SqlConnection();
        //Contructor
        public conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }

        //Iniciar bd
        public void abrir()
        {

            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion iniciada");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar la base de datos" + ex.Message);
            }

        }

        //Cerrar bd
        public void cerrar()
        {

            conectarbd.Close();
            Console.WriteLine("Conexion cerrada");

        }
    }
}
