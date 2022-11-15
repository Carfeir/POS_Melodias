Imports System.Text
Imports System.Data.SqlClient

Public Class BackUp2
    Public m As New Metodos
    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click

    End Sub

    Private Function crear_backup() As Boolean

        Dim conecsb As New SqlConnectionStringBuilder
        conecsb.DataSource = Me.txtServidor.Text
        conecsb.InitialCatalog = "master"
        conecsb.IntegratedSecurity = True

        If txtDirPathBackup.Text.Length <> 3 Then
            txtDirPathBackup.Text = txtDirPathBackup.Text + "\" + txtNom_Backup.Text + ".bak"
        Else
            txtDirPathBackup.Text = txtDirPathBackup.Text + txtNom_Backup.Text + ".bak"
        End If

        Using con As New SqlConnection(conecsb.ConnectionString)
            Try
                con.Open()
                Dim sCmd As New StringBuilder

                sCmd.Append("BACKUP DATABASE [" + cboBaseDatos.Text + "] TO  DISK = N'" + txtDirPathBackup.Text + "' ")
                sCmd.Append("WITH DESCRIPTION = N'" + txtDescrip_Backup.Text + "', NOFORMAT, NOINIT, ")
                sCmd.Append("NAME = N'" + txtNom_Backup.Text + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                Dim cmd As New SqlCommand(sCmd.ToString, con)
                cmd.ExecuteNonQuery()
                crear_backup = True
            Catch ex As Exception
                crear_backup = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class