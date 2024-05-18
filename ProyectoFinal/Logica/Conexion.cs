using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProyectoFinal.Logica{
    class Conexion{

        private static MySqlConnection conexion = new MySqlConnection();

        private static string servidor = "localhost";//la direccion del servidor en este caso la propia maquina, tambien puede ser una ip 127.0.0.1
        private static string puerto = "3306"; //el puerto por defecto de mysql
        private static string usuario = "root"; //el usuario de la base de datos
        private static string password = ""; //la contraseña del usuario
        private static string baseDeDatos = "estudiantes"; //el nombre de la base de datos (no confundir con la tabla)
        private static int timeout = 10; //el tiempo de espera para la conexion

        private static string cadenaConexion = $"server={servidor};port={puerto};user id={usuario};password={password};database={baseDeDatos};Connection Timeout={timeout};"; 

        public MySqlConnection abrirConexion() {
            try {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
            }catch (MySqlException ex) {
                MessageBox.Show("Ocurrio un error al establecer conexion con la base de datos", null);
                System.Diagnostics.Debug.WriteLine("Error al abrir la conexion: " + ex.Message);
            }
            return conexion;
        }

        public void cerrarConexion() {
            try {
                if (conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            } catch (MySqlException ex) {
                System.Diagnostics.Debug.WriteLine("Error al cerrar la conexion: " + ex.Message);
            }
        }
    }
}
