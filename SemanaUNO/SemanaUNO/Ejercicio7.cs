using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    class Ejercicio7
    {
        public void PosiNegativCero() { 
        
        Console.Clear();


            int Numero;

            Console.WriteLine("Ingrese  un numero ");
            Numero = Convert.ToInt32(Console.ReadLine());


            if (Numero > 0)
            {
                Console.WriteLine("El numero es positivo");

            }
            else if (Numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es cero");

            }

            Console.ReadKey();

            Console.Clear();

        }
    }
}
