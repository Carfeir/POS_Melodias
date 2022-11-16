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
        If (TextBoxDirectorio.Text Is String.Empty) Then
            MessageBox.Show("Por favor ingresar ubicacion del archivo Backup")
        Else

            Dim str As String = "BACKUP  [" & database & "]  A = " & TextBoxDirectorio.Text & "\" & "database" & "-" & DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") & ".bak"
            Dim cmd As New SqlCommand(str, con)
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
        con.Open()
        Dim str1 As String = String.Format("ALTER DATABASE [" + database + "] Set SINGLE_USER With ROLLBACK INMEDIATE")
        Dim cmd1 As New SqlCommand(str1, con)
        cmd1.ExecuteNonQuery()

        Dim str2 As String = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + TextBoxDirectorioRecuperar.Text + "WITH REPLACE"
        Dim cmd2 As New SqlCommand(str2, con)
        cmd2.ExecuteNonQuery()

        Dim str3 As String = String.Format("ALTER DATABASE [" + database + "] SER MULTI_USER")
        Dim cmd3 As New SqlCommand(str3, con)
        cmd3.ExecuteNonQuery()

        MessageBox.Show("RESTAURACION DE BASE DE DATOS SE REALIZO CORRECTAMENTE")
        con.Close()
    End Sub
End Class