using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio13
    {

        public void ValidarEntrada() {

            Console.Clear();
            int edad = 0;


            while (true)
            {

                Console.WriteLine("Ingrese Edad");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad == 0)
                {
                    Console.WriteLine("Edad incorrecta");
                }
                else if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta");
                }
                else
                {
                    Console.WriteLine("Su edad es " + edad);

                    break;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
