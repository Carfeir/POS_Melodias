Public Class AgregarUsuario
    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(CUITTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NomYApeTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ContactoTextBox.Text) = "" Then
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

        CUITTextBox.Clear()
        NomYApeTextBox.Clear()
        ContactoTextBox.Clear()
        CorreoElectronicoTextBox.Clear()
        NUsuarioTextBox.Clear()
        ContraseñaTextBox.Clear()
        ComboBox2.Text = ""
        ConfTextBox.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub NombresTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NomYApeTextBox.KeyPress
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


    Private Sub DNITextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CUITTextBox.KeyPress
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

    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.rol' table. You can move, or remove it, as needed.
        Me.RolTableAdapter.Fill(Me.MelodiasDataSet.rol)

    End Sub
End Class