Public Class HomeSupervisor
    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click, VendorToolStripMenuItem.Click
        Users.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem2_Click(sender As Object, e As EventArgs) 
        ChangePassword.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        BackUp2.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        BackUp2.Show()
    End Sub

    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click
        Rols.Show()
    End Sub

    Private Sub HomeSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuarioTableAdapter.Fill(Me.MelodiasDataSet.usuario)
    End Sub
End Class