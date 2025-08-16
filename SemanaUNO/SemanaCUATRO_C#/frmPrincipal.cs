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
            this.IsMdiContainer = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void AbrirFormulario(Form formularioHijo)
        {
            // Cerrar el formulario hijo actual si existe
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formularioHijo.GetType())
                {
                    frm.Close();
                    break;
                }
            }

            formularioHijo.MdiParent = this;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            
            formularioHijo.Show();
        }

        private void btnFormSimple_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFormSimple());
        }
    }
}
