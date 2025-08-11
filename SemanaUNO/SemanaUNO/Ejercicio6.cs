using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    class Ejercicio6
    {
        public void ParImpart() { 
        
            Console.Clear();
            double resultado;


            Console.WriteLine("Ingrese un número:");
            resultado = Convert.ToDouble(Console.ReadLine());

            if (resultado % 2 == 0)
            {
                Console.WriteLine("El número es par");

            }
            else
            {
                Console.WriteLine("el numero es impar");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
