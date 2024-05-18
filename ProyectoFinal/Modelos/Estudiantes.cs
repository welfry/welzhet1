using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{


    public class Estudiante
    {
        internal object nombre;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        public int parcial1 { get; set; }
        public int parcial2 { get; set; }
        public int parcial3 { get; set; }
        public int practica1 { get; set; }
        public int practica2 { get; set; }
        public int practica3 { get; set; }




        public Estudiante()
        {

        }
        public Estudiante(string Nombre, string Apellido, int Matricula, int parcial1, int parcial2, int parcial3, int practica1, int practica2, int practica3)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Matricula = Matricula;
            this.parcial1 = parcial1;
            this.parcial2 = parcial2;
            this.parcial3 = parcial3;   
            this.practica1 = practica1;
            this.practica2 = practica2;
            this.practica3 = practica3;

        }
    

    }
}
    