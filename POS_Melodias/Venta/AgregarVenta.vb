Public Class AgregarVenta
    Private Sub BtnAgregarNuevoCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarNuevoCliente.Click
        AgregarCliente.Show()
        Me.Hide()
    End Sub
End Class