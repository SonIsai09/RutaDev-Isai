using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaDOS
{
    internal class Calculadora
    {
        public double sumar(double a, double b) { 
        
        return a + b;

        }

        public double restar(double a, double b) {

            return a - b;

        }

        public double multiplicar(double a, double b)
        {
            return a * b;
        }

        public double dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }

            return a / b;

        }
    }
}
