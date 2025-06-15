using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaDOS
{
    internal class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura; 
        }

        public double CalcularPerimetro()
        {
            return 2 * Base + 2 * Altura; 

        }
    }
}
