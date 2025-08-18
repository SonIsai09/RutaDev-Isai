namespace SemanaCUATRO_C_
{
    partial class frmFormSimple
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
            this.pnlFormSimple = new System.Windows.Forms.Panel();
            this.lblSimple = new System.Windows.Forms.Label();
            this.lblSimpe = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.pnlFormSimple.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormSimple
            // 
            this.pnlFormSimple.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFormSimple.Controls.Add(this.lblSimple);
            this.pnlFormSimple.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormSimple.Location = new System.Drawing.Point(0, 0);
            this.pnlFormSimple.Name = "pnlFormSimple";
            this.pnlFormSimple.Size = new System.Drawing.Size(800, 58);
            this.pnlFormSimple.TabIndex = 1;
            // 
            // lblSimple
            // 
            this.lblSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSimple.AutoSize = true;
            this.lblSimple.BackColor = System.Drawing.Color.Transparent;
            this.lblSimple.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimple.ForeColor = System.Drawing.Color.White;
            this.lblSimple.Location = new System.Drawing.Point(299, 13);
            this.lblSimple.Name = "lblSimple";
            this.lblSimple.Size = new System.Drawing.Size(275, 33);
            this.lblSimple.TabIndex = 1;
            this.lblSimple.Text = "Formulario Simple";
            this.lblSimple.Click += new System.EventHandler(this.lblSimple_Click);
            // 
            // lblSimpe
            // 
            this.lblSimpe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimpe.AutoSize = true;
            this.lblSimpe.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpe.Location = new System.Drawing.Point(42, 104);
            this.lblSimpe.Name = "lblSimpe";
            this.lblSimpe.Size = new System.Drawing.Size(126, 45);
            this.lblSimpe.TabIndex = 2;
            this.lblSimpe.Text = "label1";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(50, 175);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(97, 42);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Haz Clic Aquí";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // frmFormSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblSimpe);
            this.Controls.Add(this.pnlFormSimple);
            this.Name = "frmFormSimple";
            this.Text = "frmFormSimple";
            this.pnlFormSimple.ResumeLayout(false);
            this.pnlFormSimple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFormSimple;
        private System.Windows.Forms.Label lblSimple;
        private System.Windows.Forms.Label lblSimpe;
        private System.Windows.Forms.Button btnClick;
    }
}