Public Class Colors
    Private Sub ColorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ColorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ColorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)
    End Sub
    Private Sub Colors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
    End Sub

    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgregarNombreTextBox.KeyPress
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
        If Trim(AgregarNombreTextBox.Text) = "" Then
            Validar_campo = False
        Else
            Validar_campo = True
        End If
    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not Validar_campo() Then
            MessageBox.Show("Completar el campo Nombre para agregar el Color", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.ColorTableAdapter.AgregarColor(AgregarNombreTextBox.Text)
            Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este Color?", "Eliminar Color", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ColorTableAdapter.EliminarColor(IdColorTextBox.Text)
            Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ColorTableAdapter.Fill(Me.MelodiasDataSet.color)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ColorTableAdapter.BuscarColor(MelodiasDataSet.color, BuscadorTextBox.Text)
    End Sub
End Class