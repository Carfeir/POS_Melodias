Public Class Products
    Private Sub TSAgregarProducto_Click(sender As Object, e As EventArgs) Handles TSAgregarProducto.Click
        AgregarProducto.Show()
        Me.Hide()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres modificar este producto?", "Modificar Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            'Me.ProductoTableAdapter.ModificarProducto(NombreTextBox.Text, PrecioUTextBox.Text, CantidadTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text, DNITextBox.Text)
            Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ProductoTableAdapter.EliminarProducto(NombreTextBox.Text)
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

End Class