Public Class Suppliers
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)

    End Sub

    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)

    End Sub

    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgregarTextBoxNombre.KeyPress
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

    Private Sub ContactoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgregarTextBoxNroContacto.KeyPress
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
        If Trim(AgregarTextBoxNombre.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxCorreo.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxDescripcion.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxNroContacto.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarTextBoxDireccion.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el proveedor", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.ProveedorTableAdapter.AgregarProveedor(AgregarTextBoxNombre.Text, AgregarTextBoxCorreo.Text, AgregarTextBoxNroContacto.Text, AgregarTextBoxDireccion.Text, AgregarTextBoxDescripcion.Text)
            Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub AgregarBtnLimpiar_Click(sender As Object, e As EventArgs) Handles AgregarBtnLimpiar.Click
        AgregarTextBoxNombre.Clear()
        AgregarTextBoxCorreo.Clear()
        AgregarTextBoxDescripcion.Clear()
        AgregarTextBoxDireccion.Clear()
        AgregarTextBoxNroContacto.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ProveedorTableAdapter.BuscarProveedor(MelodiasDataSet.proveedor, BuscadorTextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ProveedorTableAdapter.EliminarProveedor(IdProveedorTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres modificar este producto?", "Modificar Proveedor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ProveedorTableAdapter.ModificarProveedor(NombreTextBox.Text, CorreoElectronicoTextBox.Text, NroContactoTextBox.Text, DireccionTextBox.Text, DescripcionTextBox.Text, IdProveedorTextBox.Text, IdProveedorTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
        End If
    End Sub
End Class