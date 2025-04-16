using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio3
    {

        public void Operaciones() {
            Console.Clear();
            double num1 = 50,
                num2 = 20;
            Console.WriteLine("Los numeros declarados son "+ num1 +" y "+ num2);
            Console.WriteLine("");
            double Sumar = num1 + num2;
            double Restar = num1 - num2;
            double Multiplicar = num1 * num2;
            double Dividir = num1 / num2;
            Console.WriteLine("El resultado de la suma es: " + Sumar + "\nla Resta es: " + Restar + "\nLa multiplicación es: " + Multiplicar + "\nDividir es: " + Dividir);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
