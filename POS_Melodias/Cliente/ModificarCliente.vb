Public Class ModificarCliente
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

    Private Sub ApellidosTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApellidosTextBox.KeyPress
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

    Private Sub DNITextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DNITextBox.KeyPress
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

    Private Sub NroContactoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NroContactoTextBox.KeyPress
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

    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(DNITextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NombresTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ApellidosTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NroContactoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(CorreoElectronicoTextBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el cliente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Clients.ClienteTableAdapter.ModificarCliente(DNITextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text, DNITextBox.Text)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        NroContactoTextBox.Clear()
        CorreoElectronicoTextBox.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class