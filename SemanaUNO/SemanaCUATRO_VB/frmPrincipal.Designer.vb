<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlInzquierdo = New System.Windows.Forms.Panel()
        Me.btnTarea = New System.Windows.Forms.Button()
        Me.btnPrincipal = New System.Windows.Forms.Button()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlSuperior.SuspendLayout()
        Me.pnlInzquierdo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.pnlSuperior)
        Me.pnlPrincipal.Controls.Add(Me.pnlInzquierdo)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(654, 398)
        Me.pnlPrincipal.TabIndex = 0
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlSuperior.Controls.Add(Me.lblTitulo)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.Location = New System.Drawing.Point(112, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(542, 62)
        Me.pnlSuperior.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblTitulo.Location = New System.Drawing.Point(170, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(140, 27)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "WinForm VB"
        '
        'pnlInzquierdo
        '
        Me.pnlInzquierdo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlInzquierdo.Controls.Add(Me.btnTarea)
        Me.pnlInzquierdo.Controls.Add(Me.btnPrincipal)
        Me.pnlInzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.pnlInzquierdo.Name = "pnlInzquierdo"
        Me.pnlInzquierdo.Size = New System.Drawing.Size(112, 398)
        Me.pnlInzquierdo.TabIndex = 0
        '
        'btnTarea
        '
        Me.btnTarea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarea.Location = New System.Drawing.Point(0, 160)
        Me.btnTarea.Name = "btnTarea"
        Me.btnTarea.Size = New System.Drawing.Size(112, 56)
        Me.btnTarea.TabIndex = 2
        Me.btnTarea.Text = "Gesto de tarea"
        Me.btnTarea.UseVisualStyleBackColor = True
        '
        'btnPrincipal
        '
        Me.btnPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrincipal.Location = New System.Drawing.Point(0, 98)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(112, 56)
        Me.btnPrincipal.TabIndex = 0
        Me.btnPrincipal.Text = "Formulario simple"
        Me.btnPrincipal.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 398)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        Me.pnlInzquierdo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents pnlInzquierdo As Panel
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnTarea As Button
    Friend WithEvents btnPrincipal As Button
End Class
