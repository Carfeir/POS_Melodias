Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ModificarUsuario
    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(DNITextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NombresTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ContactoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(DireccionTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(CorreoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NUsuarioTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ComboBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        NombresTextBox.Clear()
        ContactoTextBox.Clear()
        DireccionTextBox.Clear()
        CorreoTextBox.Clear()
        NUsuarioTextBox.Clear()
        ComboBox.Text = ""
    End Sub
    Private Sub NombresTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombresTextBox.KeyPress
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