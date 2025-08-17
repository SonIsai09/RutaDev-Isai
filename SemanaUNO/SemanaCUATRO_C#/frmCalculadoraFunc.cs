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
        bool nuevaOperacion = true;
        public frmCalculadoraFunc()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
          
            txtResultado.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
                txtResultado.Text += "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
          
        }
    }
}
