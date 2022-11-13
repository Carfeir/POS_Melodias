Public Class MetodoDePago
    Private Sub MetodoPagoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MetodoPagoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MetodoPagoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)
    End Sub

    Private Sub MetodoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.metodoPago' table. You can move, or remove it, as needed.
        Me.MetodoPagoTableAdapter.Fill(Me.MelodiasDataSet.metodoPago)
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
            MessageBox.Show("Completar el campo Nombre para agregar el metodo de pago", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.MetodoPagoTableAdapter.AgregarMetodoPago(AgregarNombreTextBox.Text)
            Me.MetodoPagoTableAdapter.Fill(Me.MelodiasDataSet.metodoPago)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este metodo de pago?", "Eliminar MetodoPago", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.MetodoPagoTableAdapter.EliminarMetodoPago(IdMetodoPagoTextBox.Text)
            Me.MetodoPagoTableAdapter.Fill(Me.MelodiasDataSet.metodoPago)
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.MetodoPagoTableAdapter.Fill(Me.MelodiasDataSet.metodoPago)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.MetodoPagoTableAdapter.BuscarMetodoPago(MelodiasDataSet.metodoPago, BuscadorTextBox.Text)
    End Sub
End Class