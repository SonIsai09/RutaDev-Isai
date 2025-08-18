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
        Me.pnlInzquierdo = New System.Windows.Forms.Panel()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlInzquierdo.SuspendLayout()
        Me.pnlSuperior.SuspendLayout()
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
        'pnlInzquierdo
        '
        Me.pnlInzquierdo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlInzquierdo.Controls.Add(Me.Button3)
        Me.pnlInzquierdo.Controls.Add(Me.Button2)
        Me.pnlInzquierdo.Controls.Add(Me.Button1)
        Me.pnlInzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.pnlInzquierdo.Name = "pnlInzquierdo"
        Me.pnlInzquierdo.Size = New System.Drawing.Size(112, 398)
        Me.pnlInzquierdo.TabIndex = 0
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Formulario simple"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Formulario simple"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 56)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Formulario simple"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 398)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlInzquierdo.ResumeLayout(False)
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents pnlInzquierdo As Panel
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
