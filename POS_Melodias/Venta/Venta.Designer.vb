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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAgregarCliente, Me.ReporteDeVentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(186, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(275, 75)
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
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(113, 71)
        Me.ReporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 272)
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
End Class
