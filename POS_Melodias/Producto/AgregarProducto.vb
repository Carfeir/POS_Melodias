Public Class AgregarProducto
    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.MelodiasDataSet.proveedor)
        'TODO: This line of code loads data into the 'MelodiasDataSet.color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
        'TODO: This line of code loads data into the 'MelodiasDataSet.marca' table. You can move, or remove it, as needed.
        Me.MarcaTableAdapter.Fill(Me.MelodiasDataSet.marca)
        'TODO: This line of code loads data into the 'MelodiasDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.MelodiasDataSet.categoria)

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

    Private Sub precioUTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles precioUTextBox.KeyPress
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
        If Trim(NombreTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(PrecioUTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(PrecioUTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(PrecioUTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(PrecioUTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(PrecioUTextBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el producto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            'Products.ProductoTableAdapter.AgregarProducto(DNITextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        NombreTextBox.Clear()
        PrecioUTextBox.Clear()
    End Sub
End Class