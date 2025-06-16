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
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void Saludar()
        {
          
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
           
           

        }

    }
}
