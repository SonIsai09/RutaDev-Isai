using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio14
    {
        public void CalProm() {

            Console.Clear();
            int cantidadNotas = 0, contado = 0;
            double nota = 0;
            double suma = 0;
            Console.WriteLine("Ingrese cantidad de notas a ingresar");
            cantidadNotas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidadNotas; i++)
            {
                Console.WriteLine("Ingrese la nota " + i);
                nota = Convert.ToDouble(Console.ReadLine());

                suma = suma + nota;

            }

            double promedio = suma / cantidadNotas;


            Console.WriteLine("" + promedio);

            Console.ReadKey();
            Console.Clear();

        }
    }
}
