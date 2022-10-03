
Public Class HomeAdmin
    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Products.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        Categories.Show()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Colors.Show()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        Brands.Show()
    End Sub

    Private Sub AgregarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProveedorToolStripMenuItem.Click
        Suppliers.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem2.Click
        ChangePassword.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem1.Click
        SellsRecord.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Products.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Suppliers.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub
End Class