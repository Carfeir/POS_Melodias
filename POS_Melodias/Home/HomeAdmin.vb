
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

    Private Sub RegistrationToolStripMenuItem2_Click(sender As Object, e As EventArgs) 
        ChangePassword.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem1.Click
        Venta.Show()
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

    Private Sub MetodosDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetodosDePagoToolStripMenuItem.Click
        MetodoDePago.Show()
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MelodiasDataSet)

    End Sub

    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.MelodiasDataSet.producto)

    End Sub
End Class