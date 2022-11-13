Public Class Brands
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MarcaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MarcaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MarcaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)
    End Sub

    Private Sub Brands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.marca' table. You can move, or remove it, as needed.
        Me.MarcaTableAdapter.Fill(Me.MelodiasDataSet.marca)
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

    Private Function Validar_campo() As Boolean 'Se valida que el campo Nombre no este vacio'
        If Trim(NombreTextBox.Text) = "" Then
            Validar_campo = False
        Else
            Validar_campo = True
        End If
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not Validar_campo() Then
            MessageBox.Show("Completar el campo Nombre para agregar la marca", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.MarcaTableAdapter.AgregarMarca(NombreTextBox.Text)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar esta Marca?", "Eliminar marca", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.MarcaTableAdapter.EliminarMarca(NombreTextBox.Text)
            Me.MarcaTableAdapter.Fill(Me.MelodiasDataSet.marca)
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.MarcaTableAdapter.Fill(Me.MelodiasDataSet.marca)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.MarcaTableAdapter.BuscarMarca(MelodiasDataSet.marca, BuscadorTextBox.Text)
    End Sub
End Class