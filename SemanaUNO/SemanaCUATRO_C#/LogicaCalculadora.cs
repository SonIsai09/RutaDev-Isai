using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanaCUATRO_C_
{
    public class LogicaCalculadora
    {
        private double primerNumero = 0;
        private string operacion = "";
        private bool limpiar = false;

        public string Texto { get; private set; } = "0";


        public void AgregarNumero(string numero)
        {
            if (limpiar || Texto == "0")
            {
                Texto = numero;
                limpiar = false;
            }
            else
            {
                Texto += numero;
            }
        }

        public void GuardarOperacion(string op)
        {
            if (double.TryParse(Texto, out primerNumero))
            {
                operacion = op;
                limpiar = true;
            }
        }

        
        public void Calcular()
        {
            if (!double.TryParse(Texto, out double segundoNumero))
                return;

            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = primerNumero + segundoNumero; break;
                case "-": resultado = primerNumero - segundoNumero; break;
                case "*": resultado = primerNumero * segundoNumero; break;
                case "/":
                    if (segundoNumero == 0)
                    {
                        Texto = "Error: no se puede dividir entre cero";
                        limpiar = true;
                        return;
                    }
                    resultado = primerNumero / segundoNumero;
                    break;
            }

            Texto = resultado.ToString();
            limpiar = true;
        }

       
        public void Limpiar()
        {
            Texto = "0";
            primerNumero = 0;
            operacion = "";
            limpiar = false;
        }
    }
}
