Public Class HomeSupervisor
    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click, VendorToolStripMenuItem.Click
        Users.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem2.Click
        ChangePassword.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        Back_up.Show()
    End Sub
End Class