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
    public partial class frmCalculadora2 : Form
    {
        private LogicaCalculadora calculadora = new LogicaCalculadora();
        public frmCalculadora2()
        {
            InitializeComponent();
            txtResultado.Text = calculadora.Texto;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculadora.Limpiar();
            txtResultado.Text = calculadora.Texto;
        }
        private void NumeroClick(string num)
        {
            calculadora.AgregarNumero(num);
            txtResultado.Text = calculadora.Texto;
        }
        private void btnUno_Click(object sender, EventArgs e)
        {
            NumeroClick("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            NumeroClick("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            NumeroClick("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            NumeroClick("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            NumeroClick("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            NumeroClick("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            NumeroClick("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            NumeroClick("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            NumeroClick("9");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            NumeroClick("0");
        }
        private void OperacionClick(string op)
        {
            calculadora.GuardarOperacion(op);
            txtResultado.Text = calculadora.Texto;
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            
                OperacionClick("+");
            }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacionClick("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OperacionClick("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacionClick("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calculadora.Calcular();
            txtResultado.Text = calculadora.Texto;
        }
    }
}
