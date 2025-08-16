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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnCalLogica = new System.Windows.Forms.Button();
            this.btnSeparacionLog = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormSimple
            // 
            this.btnFormSimple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormSimple.Location = new System.Drawing.Point(0, 10);
            this.btnFormSimple.Name = "btnFormSimple";
            this.btnFormSimple.Size = new System.Drawing.Size(154, 55);
            this.btnFormSimple.TabIndex = 0;
            this.btnFormSimple.Text = "Formulario Simple (C#)";
            this.btnFormSimple.UseVisualStyleBackColor = true;
            this.btnFormSimple.Click += new System.EventHandler(this.btnFormSimple_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.btnSeparacionLog);
            this.panel1.Controls.Add(this.btnCalLogica);
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.btnFormSimple);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 425);
            this.panel1.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(0, 71);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(154, 55);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Diseño de Calculadora (C#)";
            this.btnCal.UseVisualStyleBackColor = true;
            // 
            // btnCalLogica
            // 
            this.btnCalLogica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalLogica.Location = new System.Drawing.Point(0, 132);
            this.btnCalLogica.Name = "btnCalLogica";
            this.btnCalLogica.Size = new System.Drawing.Size(154, 55);
            this.btnCalLogica.TabIndex = 5;
            this.btnCalLogica.Text = "Implementación Lógica Calculadora (C#)";
            this.btnCalLogica.UseVisualStyleBackColor = true;
            // 
            // btnSeparacionLog
            // 
            this.btnSeparacionLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparacionLog.Location = new System.Drawing.Point(0, 193);
            this.btnSeparacionLog.Name = "btnSeparacionLog";
            this.btnSeparacionLog.Size = new System.Drawing.Size(154, 55);
            this.btnSeparacionLog.TabIndex = 5;
            this.btnSeparacionLog.Text = "Separación Básica (C#)";
            this.btnSeparacionLog.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(324, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 31);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "WinForms C# ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormSimple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeparacionLog;
        private System.Windows.Forms.Button btnCalLogica;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}