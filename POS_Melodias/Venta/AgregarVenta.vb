Public Class AgregarVenta
    Private Sub BtnAgregarNuevoCliente_Click(sender As Object, e As EventArgs)
        Clients.Show()
        Me.Hide()
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)

    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)

    End Sub

    Private Sub AgregarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.detalleVenta' table. You can move, or remove it, as needed.
        Me.DetalleVentaTableAdapter.Fill(Me.MelodiasDataSet.detalleVenta)
        'TODO: This line of code loads data into the 'MelodiasDataSet.venta' table. You can move, or remove it, as needed.
        Me.VentaTableAdapter.Fill(Me.MelodiasDataSet.venta)
        'TODO: This line of code loads data into the 'MelodiasDataSet.color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
        'TODO: This line of code loads data into the 'MelodiasDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.MelodiasDataSet.categoria)
        'TODO: This line of code loads data into the 'MelodiasDataSet.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
        'TODO: This line of code loads data into the 'MelodiasDataSet.metodoPago' table. You can move, or remove it, as needed.
        Me.MetodoPagoTableAdapter.Fill(Me.MelodiasDataSet.metodoPago)
        'TODO: This line of code loads data into the 'MelodiasDataSet.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        'TODO: This line of code loads data into the 'MelodiasDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.MostrarProductosDisponibles(Me.MelodiasDataSet.producto)

    End Sub

    Private Sub btnMostrarClientes_Click(sender As Object, e As EventArgs) Handles btnMostrarClientes.Click
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Me.ClienteTableAdapter.BuscarCliente(MelodiasDataSet.cliente, BuscadorClienteTextBox.Text)
    End Sub

    Private Sub btnLimpiarCliente_Click(sender As Object, e As EventArgs) Handles btnLimpiarCliente.Click
        BuscadorClienteTextBox.Clear()
    End Sub

    Private Sub btnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        TextBoxDNIclienteSeleccionado.Text = DNITextBox.Text
        TextBoxClienteSeleccionado.Text = NomYapeTextBox.Text
    End Sub

    Private Sub btnMostrarProductos_Click(sender As Object, e As EventArgs) Handles btnMostrarProductos.Click
        Me.ProductoTableAdapter.MostrarProductosDisponibles(Me.MelodiasDataSet.producto)
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Me.ProductoTableAdapter.BuscarProductoDisponible(MelodiasDataSet.producto, BuscadorProductoTextBox.Text)
    End Sub

    Private Sub btnLimpiarProducto_Click(sender As Object, e As EventArgs) Handles btnLimpiarProducto.Click
        BuscadorProductoTextBox.Clear()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        'Me.DetalleVentaTableAdapter.AgregarDetalleVenta()
    End Sub

    Private Sub BtnModificarDetalle_Click(sender As Object, e As EventArgs) Handles BtnModificarDetalle.Click
        'Me.DetalleVentaTableAdapter.ModificarDetalleVenta()
    End Sub
End Class