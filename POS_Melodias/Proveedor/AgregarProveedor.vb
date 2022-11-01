Public Class AgregarProveedor
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

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
    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ContactoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactoTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class