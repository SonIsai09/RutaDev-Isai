using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio2
    {
        public void Datos() {
            Console.Clear();
            int Edad = 29;
            string Nombre = "Isai Alvarez";
            double estatura = 1.75;
            bool activo = true;
            char inicial = 'I';


            Console.WriteLine("Mi nombre es: " + Nombre + "\nEdad: " + Edad + "\nEstaura " + estatura + "m"+ " \nUsuario activo: " + activo + "\nInicial: " + inicial);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
