Imports System.Text
Imports System.Data.SqlClient

Public Class BackUp2
    Dim con As New SqlConnection("Data Source=DESKTOP-R1FDA93\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True")

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim dlg As New FolderBrowserDialog()
        If (dlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBoxDirectorio.Text = dlg.SelectedPath
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim database As String = con.Database.ToString()
        Dim cmd As New SqlCommand
        If (TextBoxDirectorio.Text Is String.Empty) Then
            MessageBox.Show("Por favor ingresar ubicacion del archivo Backup")
        Else

            Dim str As String = "BACKUP DATABASE [" + database + "]  TO DISK = N'" + TextBoxDirectorio.Text + "\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak'" + "WITH NOFORMAT,NOINIT, NAME=N'MELODIAS-DATABASE',SKIP,NOREWIND, NOUNLOAD,STATS=10"
            cmd = New SqlCommand(str, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Backup de base de datos se realizo correctamente")
        End If
    End Sub

    Private Sub btnExaminarRecuperar_Click(sender As Object, e As EventArgs) Handles btnExaminarRecuperar.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Filter = "SQL SERVER BACKUP FILE|* .bak"
        dlg.Title = "Restore Database"
        If (dlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBoxDirectorioRecuperar.Text = dlg.FileName
        End If
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Dim database As String = con.Database.ToString()
        Dim cmd1 As New SqlCommand

        con.Open()
        cmd1 = New SqlCommand("ALTER DATABASE " + database + " SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE " + database + " FROM DISK ='" + TextBoxDirectorioRecuperar.Text + "'", con)
        cmd1.ExecuteNonQuery()
        MessageBox.Show("RESTAURACION DE BASE DE DATOS SE REALIZO CORRECTAMENTE")
        con.Close()
    End Sub
End Class