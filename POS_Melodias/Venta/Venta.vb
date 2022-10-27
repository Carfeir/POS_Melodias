Public Class Venta
    Private Sub TSAgregarCliente_Click(sender As Object, e As EventArgs) Handles TSAgregarCliente.Click
        AgregarVenta.Show()
        Me.Hide()

    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        ReporteVenta.Show()
        Me.Hide()
    End Sub
End Class