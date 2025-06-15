using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaDOS
{
    internal class Persona
    {
       
        public string Nombre { get; set; }
    
        private int _edad;  
        public int Edad
        {
            get => _edad;
            set => _edad = value < 0 ? 0 : value;  
        }

        public Persona() { }
         public Persona(string nombre, int edad)
        {
          nombre = nombre;
            Edad = edad;
        }

        public void Saludar()
        {
            Console.Clear();
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
