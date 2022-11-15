Imports System.IO

Public Class Back_up
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    'Falta hacer referencia a la BD'
    'Busca y conecta con cualquier base de datos que se necesite'
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conString As String = "server=LAPTOP-CV4L1LJF\SQLEXPRESS; uid=LAPTOP-CV4L1LJF\Maurizio; pwd=; database=melodias"

        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = conString

        conexion.Open()

        Dim cmd As New SqlClient.SqlCommand("SELECT name from sys.databases", conexion)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                cboBaseDatos.Items.Add(fila(0).ToString)
            Next

            cboBaseDatos.SelectedIndex = 0
        End If
    End Sub
    'Hay que ver si hacerle .bak o .sql
    'Se selecciona la carpeta donde guardar y guarda la el nombre de la base de datos con la fecha y hora actual 
    Private Sub btnRutaGuardar_Click(sender As Object, e As EventArgs) Handles btnRutaGuardar.Click

        SaveFileDialog1.Filter = "SQL Backup files|*.bak"
        SaveFileDialog1.FileName = cboBaseDatos.Text & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaGuardar.Text = SaveFileDialog1.FileName
        End If

    End Sub

    'Verificar si se guarda en el lugar seleccionado o lo guarda en la carpeta que crea
    Private Sub btnBackup_Click(sender As Object, e As EventArgs)
        Try
            'Verifica que exista la carpeta, en caso contrario la crea
            If Not Directory.Exists("D:\Backup") Then
                Directory.CreateDirectory("D:\Backup")
            End If

            Process.Start("cmd", "/k" & "sqlcmd -S localhost\SQLEXPRESS -E -Q ""BACKUP DATABASE [" & cboBaseDatos.Text & "] TO DISK='" & txtRutaGuardar.Text & "'""")

            MessageBox.Show("Backup exitoso!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

End Class