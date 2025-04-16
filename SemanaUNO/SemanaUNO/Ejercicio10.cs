using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio10
    {
        public void SumaAcumulada()
        {
            Console.Clear();

            int numero = 0;


            Console.WriteLine("Ingrese el limite a sumar  desde a 1 has N ");
            numero = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for (int i = 1; i <= numero; i++)
            {
                suma = suma + i;




            }

            Console.WriteLine(" la suma total es " + suma);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
