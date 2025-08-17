namespace SemanaCUATRO_C_
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnFormSimple = new System.Windows.Forms.Button();
            this.btnSeparacionLog = new System.Windows.Forms.Button();
            this.btnCalLogica = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgInicio = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormSimple
            // 
            this.btnFormSimple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormSimple.Location = new System.Drawing.Point(12, 21);
            this.btnFormSimple.Name = "btnFormSimple";
            this.btnFormSimple.Size = new System.Drawing.Size(154, 55);
            this.btnFormSimple.TabIndex = 0;
            this.btnFormSimple.Text = "Formulario Simple (C#)";
            this.btnFormSimple.UseVisualStyleBackColor = true;
            this.btnFormSimple.Click += new System.EventHandler(this.btnFormSimple_Click);
            // 
            // btnSeparacionLog
            // 
            this.btnSeparacionLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparacionLog.Location = new System.Drawing.Point(12, 210);
            this.btnSeparacionLog.Name = "btnSeparacionLog";
            this.btnSeparacionLog.Size = new System.Drawing.Size(154, 55);
            this.btnSeparacionLog.TabIndex = 5;
            this.btnSeparacionLog.Text = "Separación Básica (C#)";
            this.btnSeparacionLog.UseVisualStyleBackColor = true;
            // 
            // btnCalLogica
            // 
            this.btnCalLogica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalLogica.Location = new System.Drawing.Point(12, 149);
            this.btnCalLogica.Name = "btnCalLogica";
            this.btnCalLogica.Size = new System.Drawing.Size(154, 55);
            this.btnCalLogica.TabIndex = 5;
            this.btnCalLogica.Text = "Calculadora (C#)";
            this.btnCalLogica.UseVisualStyleBackColor = true;
            this.btnCalLogica.Click += new System.EventHandler(this.btnCalLogica_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(12, 82);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(154, 55);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Diseño de Calculadora (C#)";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(384, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 31);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "WinForms C# ";
            // 
            // imgInicio
            // 
            this.imgInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgInicio.Image = ((System.Drawing.Image)(resources.GetObject("imgInicio.Image")));
            this.imgInicio.Location = new System.Drawing.Point(208, 95);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(507, 318);
            this.imgInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInicio.TabIndex = 5;
            this.imgInicio.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlSuperior);
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.imgInicio);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(740, 425);
            this.pnlContenedor.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnCalLogica);
            this.panel1.Controls.Add(this.btnFormSimple);
            this.panel1.Controls.Add(this.btnSeparacionLog);
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 425);
            this.panel1.TabIndex = 6;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlSuperior.Controls.Add(this.lblInicio);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(173, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(567, 57);
            this.pnlSuperior.TabIndex = 7;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(189, 10);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(203, 33);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "WinForms C#";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 425);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormSimple;
        private System.Windows.Forms.Button btnSeparacionLog;
        private System.Windows.Forms.Button btnCalLogica;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgInicio;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Panel panel1;
    }
}