Public Class Users
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres modificar este usuario?", "Modificar Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.UsuarioTableAdapter.ModificarUsuario(CUITTextBox.Text, NomYApeTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text, NombreUsuarioTextBox.Text, AgregarComboBoxRol.ValueMember, CUITTextBox.Text)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        HomeSupervisor.Show()
        Me.Hide()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.MelodiasDataSet.usuario)
        'TODO: This line of code loads data into the 'MelodiasDataSet.rol' table. You can move, or remove it, as needed.
        Me.RolTableAdapter.Fill(Me.MelodiasDataSet.rol)
    End Sub

    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(AgregarTextBoxContacto.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxContra.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxCorreo.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxCUIT.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxNomApe.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxNomUsuario.Text) = "" Then
            Validar_campos = False
        ElseIf AgregarComboBoxRol.SelectedValue = -1 Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el cliente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.UsuarioTableAdapter.AgregarUsuario(AgregarTextBoxCUIT.Text, AgregarTextBoxNomApe.Text, AgregarTextBoxContacto.Text, AgregarTextBoxCorreo.Text, AgregarTextBoxNomUsuario.Text, AgregarTextBoxContra.Text, AgregarComboBoxRol.ValueMember)
            Me.UsuarioTableAdapter.Fill(Me.MelodiasDataSet.usuario)
        End If
    End Sub

    Private Sub AgregarBtnLimpiar_Click(sender As Object, e As EventArgs) Handles AgregarBtnLimpiar.Click
        AgregarComboBoxRol.SelectedValue = -1
        AgregarTextBoxContacto.Clear()
        AgregarTextBoxContra.Clear()
        AgregarTextBoxCorreo.Clear()
        AgregarTextBoxCUIT.Clear()
        AgregarTextBoxNomApe.Clear()
        AgregarTextBoxNomUsuario.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.UsuarioTableAdapter.BuscarUsuario(MelodiasDataSet.usuario, BuscadorTextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.UsuarioTableAdapter.Fill(Me.MelodiasDataSet.usuario)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.UsuarioTableAdapter.EliminarUsuario(CUITTextBox.Text)
            Me.UsuarioTableAdapter.Fill(Me.MelodiasDataSet.usuario)
        End If
    End Sub
End Class