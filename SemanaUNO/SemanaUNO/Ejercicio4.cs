using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio4
    {
        public void EntradaUsuario() { 
        Console.Clear();

            string nombre;

            int edad;


            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su nombre es: " + nombre + " y su edad es: "+edad);
            Console.ReadKey();
            Console.Clear();

        }
    }
}
