using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaDOS
{
    internal class Estudiante: Persona
    {

        public string Matricula { get; set; }


        public Estudiante() { }
        public Estudiante(string nombre, int edad, string matricula) 
            : base(nombre, edad)
        {
            Matricula = matricula;
        }

        public void MostrarInformacion() { 
        
            Console.Clear();
            Saludar();
            Console.WriteLine("Matricula es: "+Matricula);


        }

    }
}
