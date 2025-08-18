using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SemanaCUATRO_C_
{
    public partial class frmCalculadoraFunc : Form
    {
        double primerNumero = 0;
        string operacion = "";
        bool limpiar = false;
        public string Texto { get; private set; } = "0";
        public frmCalculadoraFunc()
        {
            InitializeComponent();
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            primerNumero = 0;
            operacion = "";
        }

      
        private void btnUno_Click(object sender, EventArgs e) { AgregarNumero("1"); }
        private void btnDos_Click(object sender, EventArgs e) { AgregarNumero("2"); }
        private void btnTres_Click(object sender, EventArgs e) { AgregarNumero("3"); }
        private void btnCuatro_Click(object sender, EventArgs e) { AgregarNumero("4"); }
        private void btnCinco_Click(object sender, EventArgs e) { AgregarNumero("5"); }
        private void btnSeis_Click(object sender, EventArgs e) { AgregarNumero("6"); }
        private void btnSiete_Click(object sender, EventArgs e) { AgregarNumero("7"); }
        private void btnOcho_Click(object sender, EventArgs e) { AgregarNumero("8"); }
        private void btnNueve_Click(object sender, EventArgs e) { AgregarNumero("9"); }
        private void btnCero_Click(object sender, EventArgs e) { AgregarNumero("0"); }

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




        private void GuardarOperacion(string op)
        {
            if (double.TryParse(txtResultado.Text, out primerNumero))
            {
                operacion = op;
                limpiar = true; 
            }
        }

       

        private void btnMas_Click(object sender, EventArgs e)
        {
            GuardarOperacion("+");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            GuardarOperacion("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            GuardarOperacion("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            GuardarOperacion("/");
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtResultado.Text, out double segundoNumero))
            {
                double resultado = 0;

                switch (operacion)
                {
                    case "+": resultado = primerNumero + segundoNumero; break;
                    case "-": resultado = primerNumero - segundoNumero; break;
                    case "*": resultado = primerNumero * segundoNumero; break;
                    case "/":
                        if (segundoNumero == 0)
                        {
                            txtResultado.Text = "Error: no se puede dividir entre cero";
                            return;
                        }
                        resultado = primerNumero / segundoNumero;
                        break;
                }

                txtResultado.Text = resultado.ToString();
                limpiar = true;
            }
        }

        private void frmCalculadoraFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
