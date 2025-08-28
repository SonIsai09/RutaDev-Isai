Public Class frmPrincipal

    Private Sub AbrirFormEnPanel(Of T As {Form, New})()
        Dim formulario As Form
        formulario = pnlPrincipal.Controls.OfType(Of T)().FirstOrDefault()


        If formulario Is Nothing Then
            formulario = New T()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            pnlPrincipal.Controls.Add(formulario)
            pnlPrincipal.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        AbrirFormEnPanel(Of frmSimple)()
    End Sub

    Private Sub btnTarea_Click(sender As Object, e As EventArgs) Handles btnTarea.Click
        AbrirFormEnPanel(Of frmGestorTareas)()
    End Sub
End Class