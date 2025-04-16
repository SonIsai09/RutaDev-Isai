using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SemanaUNO
{
    internal class Ejercicio4
    {
        public void EntradaUsuario() { 
        Console.Clear();

            string nombre;

            int edad;

            try {
                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Su nombre es: " + nombre + " y su edad es: " + edad);
                Console.ReadKey();
                Console.Clear();
            }
            catch (FormatException )
            {
                Console.WriteLine("Dato incorrecto: por favor ingrese datos válido.");
                Console.ReadKey();
                Console.Clear();
            }
           

        }
    }
}
