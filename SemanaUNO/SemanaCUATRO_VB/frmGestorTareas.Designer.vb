<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestorTareas
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
        Me.lblNuevaTarea = New System.Windows.Forms.Label()
        Me.txtTarea = New System.Windows.Forms.TextBox()
        Me.bntAgregarTarea = New System.Windows.Forms.Button()
        Me.lbtTarea = New System.Windows.Forms.ListBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNuevaTarea
        '
        Me.lblNuevaTarea.AutoSize = True
        Me.lblNuevaTarea.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaTarea.Location = New System.Drawing.Point(266, 43)
        Me.lblNuevaTarea.Name = "lblNuevaTarea"
        Me.lblNuevaTarea.Size = New System.Drawing.Size(250, 41)
        Me.lblNuevaTarea.TabIndex = 0
        Me.lblNuevaTarea.Text = "NUEVA TAREA"
        '
        'txtTarea
        '
        Me.txtTarea.Location = New System.Drawing.Point(234, 110)
        Me.txtTarea.Name = "txtTarea"
        Me.txtTarea.Size = New System.Drawing.Size(298, 20)
        Me.txtTarea.TabIndex = 1
        '
        'bntAgregarTarea
        '
        Me.bntAgregarTarea.Location = New System.Drawing.Point(234, 157)
        Me.bntAgregarTarea.Name = "bntAgregarTarea"
        Me.bntAgregarTarea.Size = New System.Drawing.Size(146, 23)
        Me.bntAgregarTarea.TabIndex = 2
        Me.bntAgregarTarea.Text = "Agregar Tarea"
        Me.bntAgregarTarea.UseVisualStyleBackColor = True
        '
        'lbtTarea
        '
        Me.lbtTarea.FormattingEnabled = True
        Me.lbtTarea.Location = New System.Drawing.Point(214, 216)
        Me.lbtTarea.Name = "lbtTarea"
        Me.lbtTarea.Size = New System.Drawing.Size(350, 199)
        Me.lbtTarea.TabIndex = 3
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(386, 157)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(146, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar Seleccionado"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmGestorTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lbtTarea)
        Me.Controls.Add(Me.bntAgregarTarea)
        Me.Controls.Add(Me.txtTarea)
        Me.Controls.Add(Me.lblNuevaTarea)
        Me.Name = "frmGestorTareas"
        Me.Text = "frmGestorTareas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNuevaTarea As Label
    Friend WithEvents txtTarea As TextBox
    Friend WithEvents bntAgregarTarea As Button
    Friend WithEvents lbtTarea As ListBox
    Friend WithEvents btnEliminar As Button
End Class
