using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio5
    {
        public void Calculadora() { 
        Console.Clear();

            int num1, num2, resultado;


            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");

            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + resultado);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
