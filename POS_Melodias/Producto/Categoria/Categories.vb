Public Class Categories

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub CategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)
    End Sub

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSetCategoria.categoria' table. You can move, or remove it, as needed.
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

    Private Function Validar_campo() As Boolean 'Se valida que el campo Nombre no este vacio'
        If Trim(NombreTextBox.Text) = "" Then
            Validar_campo = False
        Else
            Validar_campo = True
        End If
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Not Validar_campo() Then
            MessageBox.Show("Completar el campo Nombre para agregar la categoria", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.CategoriaTableAdapter.AgregarCategoria(NombreTextBox.Text)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar esta categoria?", "Eliminar Categoria", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.CategoriaTableAdapter.EliminarCategoria(NombreTextBox.Text)
            Me.CategoriaTableAdapter.Fill(Me.MelodiasDataSet.categoria)
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.CategoriaTableAdapter.Fill(Me.MelodiasDataSet.categoria)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.CategoriaTableAdapter.BuscarCategoria(MelodiasDataSet.categoria, BuscadorTextBox.Text)
    End Sub
End Class