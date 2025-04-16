using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio8
    {
        public void ComparacionNum() {
            Console.Clear();
            int numero1, numero2;

            Console.WriteLine("Ingrese el primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());


            if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales");

            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("El primer numero " + numero1 + " Es mayor que el segundo numero " + numero2);

            }
            else
            {
                Console.WriteLine("El segundo numero  " + numero2 + " Es mayor que primer numero " + numero1);
            }


            Console.ReadKey();
            Console.Clear();
        }
    }
}
