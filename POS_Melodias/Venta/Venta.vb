Public Class Venta
    Private Sub TSAgregarCliente_Click(sender As Object, e As EventArgs) Handles TSAgregarCliente.Click
        AgregarVenta.Show()
        Me.Hide()

    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        ReporteVenta.Show()
        Me.Hide()
    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.venta' table. You can move, or remove it, as needed.
        Me.VentaTableAdapter.Fill(Me.MelodiasDataSet.venta)
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class