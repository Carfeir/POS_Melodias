Public Class Clients
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        AgregarCliente.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres modificar este cliente?", "Modificar Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ClienteTableAdapter.ModificarCliente(DNITextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text, DNITextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ClienteTableAdapter.EliminarCliente(DNITextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Me.ClienteTableAdapter.BuscarCliente(MelodiasDataSet.cliente, BuscadorTextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Sub TSAgregarCliente_Click(sender As Object, e As EventArgs) Handles TSAgregarCliente.Click
        AgregarCliente.Show()
        Me.Hide()
    End Sub
End Class