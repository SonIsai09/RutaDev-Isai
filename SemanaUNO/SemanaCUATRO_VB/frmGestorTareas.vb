Public Class frmGestorTareas
    Private Sub bntAgregarTarea_Click(sender As Object, e As EventArgs) Handles bntAgregarTarea.Click

        Dim tarea As String = txtTarea.Text.Trim()


        If String.IsNullOrWhiteSpace(tarea) Then
            MessageBox.Show("Escribe una tarea antes de agregar.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTarea.Focus()
            Return
        End If


        lbtTarea.Items.Add(tarea)

        txtTarea.Clear()
        txtTarea.Focus()
    End Sub


    Private Sub txtTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTarea.KeyDown
        If e.KeyCode = Keys.Enter Then
            bntAgregarTarea.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lbtTarea.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona una tarea antes de eliminar.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lbtTarea.Items.RemoveAt(lbtTarea.SelectedIndex)
    End Sub
End Class