using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio11
    {
        public void TablaMultiplicar()
        {
            Console.Clear();

            int numero = 0;

            Console.WriteLine("Ingrese el numero a multiplicar");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}
