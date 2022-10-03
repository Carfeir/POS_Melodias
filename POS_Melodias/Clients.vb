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

    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(DNITextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NombresTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(ApellidosTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(NroContactoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(CorreoElectronicoTextBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el cliente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf Me.ClienteTableAdapter.BuscarCliente(MelodiasDataSet.cliente, DNITextBox.Text) Then
            MessageBox.Show("Ya existe un cliente con los datos ingresados", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.ClienteTableAdapter.AgregarCliente(DNITextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el cliente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            Me.ClienteTableAdapter.ModificarCliente(DNITextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text, DNITextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.ClienteTableAdapter.EliminarCliente(DNITextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ClienteTableAdapter.BuscarCliente(MelodiasDataSet.cliente, DNITextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
    End Sub
End Class