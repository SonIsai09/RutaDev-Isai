<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio11
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
        Me.btnEjercicio11 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEjercicio11
        '
        Me.btnEjercicio11.Location = New System.Drawing.Point(32, 47)
        Me.btnEjercicio11.Name = "btnEjercicio11"
        Me.btnEjercicio11.Size = New System.Drawing.Size(75, 23)
        Me.btnEjercicio11.TabIndex = 0
        Me.btnEjercicio11.Text = "Botón"
        Me.btnEjercicio11.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(156, 47)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Ejercicio11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 86)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEjercicio11)
        Me.Name = "Ejercicio11"
        Me.Text = "Ejercicio11"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEjercicio11 As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
End Class
