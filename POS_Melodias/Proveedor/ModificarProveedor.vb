Public Class ModificarProveedor
    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(NombreTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(CorreoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ContactoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(DireccionTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(DescripTextBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        NombreTextBox.Clear()
        CorreoTextBox.Clear()
        ContactoTextBox.Clear()
        DireccionTextBox.Clear()
        DescripTextBox.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class