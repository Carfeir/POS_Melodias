<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSAgregarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SellID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAgregarCliente, Me.ReporteDeVentasToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(726, 75)
        Me.MenuStrip1.TabIndex = 181
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSAgregarCliente
        '
        Me.TSAgregarCliente.Font = New System.Drawing.Font("Miriam", 11.25!)
        Me.TSAgregarCliente.Image = CType(resources.GetObject("TSAgregarCliente.Image"), System.Drawing.Image)
        Me.TSAgregarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSAgregarCliente.Name = "TSAgregarCliente"
        Me.TSAgregarCliente.Size = New System.Drawing.Size(154, 71)
        Me.TSAgregarCliente.Text = "&Agregar Nueva Venta"
        Me.TSAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ReporteDeVentasToolStripMenuItem
        '
        Me.ReporteDeVentasToolStripMenuItem.Font = New System.Drawing.Font("Miriam", 11.25!)
        Me.ReporteDeVentasToolStripMenuItem.Image = CType(resources.GetObject("ReporteDeVentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReporteDeVentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(137, 71)
        Me.ReporteDeVentasToolStripMenuItem.Text = "&Reporte de Ventas"
        Me.ReporteDeVentasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Font = New System.Drawing.Font("Miriam", 11.25!)
        Me.VolverToolStripMenuItem.Image = CType(resources.GetObject("VolverToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VolverToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(62, 71)
        Me.VolverToolStripMenuItem.Text = "Volver"
        Me.VolverToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Font = New System.Drawing.Font("Miriam", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(12, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 16)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "Ultimas 10 ventas"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.SellID, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 122)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(699, 162)
        Me.ListView1.TabIndex = 185
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'SellID
        '
        Me.SellID.Text = "ID Venta"
        Me.SellID.Width = 84
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Cliente"
        Me.ColumnHeader8.Width = 141
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID Detalle Venta"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Monto Total"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Fecha"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 81
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Metodo de Pago"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 120
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 296)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSAgregarCliente As ToolStripMenuItem
    Friend WithEvents ReporteDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label13 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents SellID As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
