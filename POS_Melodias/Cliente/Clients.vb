Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Clients

    Private Sub NomYapeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NomYapeTextBox.KeyPress, AgregarNomYapeTextBox.KeyPress
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

    Private Sub DNITextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DNITextBox.KeyPress, AgregarDNITextBox.KeyPress
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

    Private Sub NroContactoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NroContactoTextBox.KeyPress, AgregarNroContactoTextBox.KeyPress
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

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim result As DialogResult = MessageBox.Show("Seguro que quieres modificar este cliente?", "Modificar Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.ClienteTableAdapter.ModificarCliente(DNITextBox.Text, NomYapeTextBox.Text, NroContactoTextBox.Text, CorreoElectronicoTextBox.Text, DireccionTextBox.Text, DNITextBox.Text)
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ClienteTableAdapter.BuscarCliente(MelodiasDataSet.cliente, BuscadorTextBox.Text)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
    End Sub

    Private Sub BuscadorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BuscadorTextBox.KeyPress
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

    Private Sub AgregarBtnLimpiar_Click(sender As Object, e As EventArgs) Handles AgregarBtnLimpiar.Click
        AgregarDNITextBox.Clear()
        AgregarNomYapeTextBox.Clear()
        AgregarNroContactoTextBox.Clear()
        AgregarCorreoElectronicoTextBox.Clear()
        AgregarDireccionTextBox.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BuscadorTextBox.Clear()
    End Sub

    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(AgregarDNITextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarNomYapeTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarNroContactoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarCorreoElectronicoTextBox.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(AgregarDireccionTextBox.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If Not Validar_campos() Then
            MessageBox.Show("Completar todos los campos para agregar el cliente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        ElseIf ClienteRegistrado(AgregarDNITextBox.Text) Then
            MessageBox.Show("El Cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.ClienteTableAdapter.AgregarCliente(AgregarDNITextBox.Text, AgregarNomYapeTextBox.Text, AgregarCorreoElectronicoTextBox.Text, AgregarNroContactoTextBox.Text, AgregarDireccionTextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.MelodiasDataSet.cliente)
        End If
    End Sub
    Function ClienteRegistrado(ByVal DNI As String) As Boolean
        Dim con As New SqlConnection("Data Source=DESKTOP-R1FDA93\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True")
        Dim dr As SqlDataReader
        Dim resultado As Boolean = False
        con.Open()
        Try
            Dim cmd As New SqlCommand("Select * From cliente where DNI='" & DNI & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en el procedemiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

End Class