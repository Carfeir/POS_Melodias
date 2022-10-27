Public Class AgregarUsuario
    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(DNITextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NombresTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ContactoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(DireccionTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(CorreoElectronicoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NUsuarioTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ComboBox2.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ContraseñaTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ConfTextBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        DNITextBox.Clear()
        NombresTextBox.Clear()
        ContactoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoElectronicoTextBox.Clear()
        NUsuarioTextBox.Clear()
        ContraseñaTextBox.Clear()
        ComboBox2.Text = ""
        ConfTextBox.Clear()
    End Sub
End Class