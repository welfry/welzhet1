using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.Logica {
    class Storage { 
        public Boolean agregarEstudiante(string nombre, string apellido, int matricula) {
            Boolean result = false;
            var conexion = new Conexion().abrirConexion();
            if (conexion.State == System.Data.ConnectionState.Open) {
                try {
                    string query = "INSERT INTO estudiantes (nombre, apellido, matricula) VALUES (@nombre, @apellido, @matricula)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();          
                    MessageBox.Show("Estudiante agregado correctamente");
                    result = true;
                } catch (MySqlException ex) {
                    if (ex.Message.StartsWith("Duplicate entry")) {
                        MessageBox.Show("Ya existe otro estudiante con ese numero de matricula", null);
                    } else {
                        MessageBox.Show("Ocurrio un error al agregar el estudiante", null);
                    }
                    System.Diagnostics.Debug.WriteLine("Error al agregar el estudiante: " + ex.Message);
                }
                conexion.Close();
            }
            return result;
        }

        public Estudiante buscarEstudiante(int matricula) {
            Estudiante estudiante = null;
            try {
                Conexion conexion = new Conexion();
                var conn = conexion.abrirConexion();
                if (conn.State == System.Data.ConnectionState.Open) {
                    string query = "SELECT * FROM estudiantes WHERE matricula = @matricula";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read()) {
                        estudiante = new Estudiante(reader.GetString("nombre"), reader.GetString("apellido"), reader.GetInt32("matricula"), 
                            reader.IsDBNull(reader.GetOrdinal("parcial1")) ? -1 : reader.GetInt32("parcial1"), reader.IsDBNull(reader.GetOrdinal("parcial2")) ? -1 : reader.GetInt32("parcial2"),
                            reader.IsDBNull(reader.GetOrdinal("parcial3")) ? -1 : reader.GetInt32("parcial3"), reader.IsDBNull(reader.GetOrdinal("practica1")) ? -1 : reader.GetInt32("practica1"),
                            reader.IsDBNull(reader.GetOrdinal("practica2")) ? -1 : reader.GetInt32("practica2"), reader.IsDBNull(reader.GetOrdinal("practica3")) ? -1 : reader.GetInt32("practica3"));
                    }
                    reader.Close();
                    cmd.Dispose();
                    conexion.cerrarConexion();
                }
            }catch(MySqlException ex) {
                MessageBox.Show("Ocurrio un error al buscar el estudiante", null);
                System.Diagnostics.Debug.WriteLine("Error al buscar el estudiante: " + ex.Message);
            }

            return estudiante;
        }
    }
}
