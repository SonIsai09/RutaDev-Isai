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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
     
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormHijo(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);


            imgInicio.Visible = false;

    
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

         
            this.pnlContenedor.Controls.Add(formHijo);
            this.pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        

        }



        private void btnFormSimple_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmFormSimple());
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCalculadora());
        }

        private void btnCalLogica_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCalculadoraFunc());
        }

        private void btnSeparacionLog_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCalculadora2());
        }
    }
}
