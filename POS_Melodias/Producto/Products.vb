Public Class Products
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
        'TODO: This line of code loads data into the 'MelodiasDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.MelodiasDataSet.categoria)
        'TODO: This line of code loads data into the 'MelodiasDataSet.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
        'TODO: This line of code loads data into the 'MelodiasDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres modificar este producto?", "Modificar Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ProductoTableAdapter.ModificarProducto(IdProveedorComboBox.SelectedIndex, NombreTextBox.Text, IdCategoriaComboBox.SelectedIndex, IdMarcaComboBox.SelectedIndex, IdColorComboBox.SelectedIndex, CantidadNumericUpDown.Value, PrecioUTextBox.Text, IdProductoTextBox.Text, IdProductoTextBox.Text)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ProductoTableAdapter.EliminarProducto(IdProductoTextBox.Text)
            Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Me.ProductoTableAdapter.BuscarProducto(MelodiasDataSet.producto, BuscadorTextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub AgregarPrecioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgregarPrecioTextBox.KeyPress
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
        If Trim(AgregarNombreTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarPrecioTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf AgregarCantidadNumericUpDown.Value = 0 Then
            Validar_campos = False
        ElseIf AgregarCategoriaComboBox.SelectedValue = -1 Then
            Validar_campos = False
        ElseIf AgregarColorComboBox.SelectedValue = -1 Then
            Validar_campos = False
        ElseIf AgregarMarcaComboBox.SelectedValue = -1 Then
            Validar_campos = False
        ElseIf AgregarProveedorComboBox.SelectedValue = -1 Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el producto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.ProductoTableAdapter.AgregarProducto(AgregarProveedorComboBox.SelectedValue, AgregarNombreTextBox.Text, AgregarCategoriaComboBox.SelectedValue, AgregarMarcaComboBox.SelectedValue, AgregarColorComboBox.Text, AgregarCantidadNumericUpDown.Value, AgregarPrecioTextBox.Text)
            Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)
        End If
    End Sub

    Private Sub AgregarBtnLimpiar_Click(sender As Object, e As EventArgs) Handles AgregarBtnLimpiar.Click
        AgregarProveedorComboBox.SelectedValue = -1
        AgregarNombreTextBox.Clear()
        AgregarCantidadNumericUpDown.Value = 1
        AgregarCategoriaComboBox.SelectedValue = -1
        AgregarColorComboBox.SelectedValue = -1
        AgregarMarcaComboBox.SelectedValue = -1
        AgregarPrecioTextBox.Clear()
    End Sub
End Class