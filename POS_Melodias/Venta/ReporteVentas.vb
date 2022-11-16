Imports System.Data.SqlClient
Imports System.Data
Public Class ReporteVentas

    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MelodiasDataSet.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.MelodiasDataSet.venta)
    End Sub

    Private Sub BFil1_Click(sender As Object, e As EventArgs) Handles BFil1.Click
        Me.VentaTableAdapter.BuscarVenta(MelodiasDataSet.venta, idVenta.Text)
    End Sub

    Private Sub BFiltrar2_Click(sender As Object, e As EventArgs) Handles BFiltrar2.Click
        Dim desde As DateTime = dpDesde.Value
        Dim hasta As DateTime = dpHasta.Value
        dgvLista.DataSource = melodiasDataSetTableAdapters.ventaTableAdapter



    End Sub
End Class