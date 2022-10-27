Public Class HomeEmpleado
    Private Sub AgregarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarVentaToolStripMenuItem.Click
        AgregarVenta.Show()
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        Venta.Show()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Clients.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem2.Click
        ChangePassword.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        AgregarVenta.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem1.Click
        Venta.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Clients.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub
End Class