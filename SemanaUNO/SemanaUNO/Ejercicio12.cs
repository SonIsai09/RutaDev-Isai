using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaUNO
{
    internal class Ejercicio12
    {

        public void AdinaNumero() {
          
            Console.Clear();
            int numeroSecreto = 2;
            int numeroUsuario = 0;



            while (numeroUsuario != numeroSecreto)
            {
                Console.WriteLine("Adivina el numero secreto");
                numeroUsuario = Convert.ToInt32(Console.ReadLine());
                if (numeroUsuario == numeroSecreto)
                {
                    Console.WriteLine("Felicidades adivinaste el numero secreto");
                }
                else
                {
                    Console.WriteLine("Vuelve a intentarlo");
                }

            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
