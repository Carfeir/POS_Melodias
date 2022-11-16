<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteVentas))
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.IdVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalleVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMetodoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
        Me.idVenta = New System.Windows.Forms.Label()
        Me.BCuit = New System.Windows.Forms.TextBox()
        Me.dpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BFiltrar2 = New System.Windows.Forms.Button()
        Me.VentaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.ventaTableAdapter()
        Me.BFil1 = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AutoGenerateColumns = False
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVentaDataGridViewTextBoxColumn, Me.IdDetalleVentaDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn, Me.IdMetodoPagoDataGridViewTextBoxColumn})
        Me.dgvLista.DataSource = Me.VentaBindingSource
        Me.dgvLista.Location = New System.Drawing.Point(2, 63)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(829, 150)
        Me.dgvLista.TabIndex = 0
        '
        'IdVentaDataGridViewTextBoxColumn
        '
        Me.IdVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta"
        Me.IdVentaDataGridViewTextBoxColumn.HeaderText = "idVenta"
        Me.IdVentaDataGridViewTextBoxColumn.Name = "IdVentaDataGridViewTextBoxColumn"
        Me.IdVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDetalleVentaDataGridViewTextBoxColumn
        '
        Me.IdDetalleVentaDataGridViewTextBoxColumn.DataPropertyName = "idDetalleVenta"
        Me.IdDetalleVentaDataGridViewTextBoxColumn.HeaderText = "idDetalleVenta"
        Me.IdDetalleVentaDataGridViewTextBoxColumn.Name = "IdDetalleVentaDataGridViewTextBoxColumn"
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "montoTotal"
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "montoTotal"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        '
        'IdMetodoPagoDataGridViewTextBoxColumn
        '
        Me.IdMetodoPagoDataGridViewTextBoxColumn.DataPropertyName = "idMetodoPago"
        Me.IdMetodoPagoDataGridViewTextBoxColumn.HeaderText = "idMetodoPago"
        Me.IdMetodoPagoDataGridViewTextBoxColumn.Name = "IdMetodoPagoDataGridViewTextBoxColumn"
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me.MelodiasDataSetBindingSource
        '
        'MelodiasDataSetBindingSource
        '
        Me.MelodiasDataSetBindingSource.DataSource = Me.MelodiasDataSet
        Me.MelodiasDataSetBindingSource.Position = 0
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'idVenta
        '
        Me.idVenta.AutoSize = True
        Me.idVenta.Location = New System.Drawing.Point(19, 35)
        Me.idVenta.Name = "idVenta"
        Me.idVenta.Size = New System.Drawing.Size(54, 13)
        Me.idVenta.TabIndex = 1
        Me.idVenta.Text = "IDVENTA"
        '
        'BCuit
        '
        Me.BCuit.Location = New System.Drawing.Point(79, 29)
        Me.BCuit.Name = "BCuit"
        Me.BCuit.Size = New System.Drawing.Size(125, 20)
        Me.BCuit.TabIndex = 2
        '
        'dpDesde
        '
        Me.dpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDesde.Location = New System.Drawing.Point(415, 28)
        Me.dpDesde.Name = "dpDesde"
        Me.dpDesde.Size = New System.Drawing.Size(84, 20)
        Me.dpDesde.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BUSCAR POR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha"
        '
        'dpHasta
        '
        Me.dpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpHasta.Location = New System.Drawing.Point(581, 29)
        Me.dpHasta.Name = "dpHasta"
        Me.dpHasta.Size = New System.Drawing.Size(84, 20)
        Me.dpHasta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(517, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hasta"
        '
        'BFiltrar2
        '
        Me.BFiltrar2.Location = New System.Drawing.Point(690, 30)
        Me.BFiltrar2.Name = "BFiltrar2"
        Me.BFiltrar2.Size = New System.Drawing.Size(75, 23)
        Me.BFiltrar2.TabIndex = 9
        Me.BFiltrar2.Text = "Filtrar"
        Me.BFiltrar2.UseVisualStyleBackColor = True
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'BFil1
        '
        Me.BFil1.Location = New System.Drawing.Point(220, 30)
        Me.BFil1.Name = "BFil1"
        Me.BFil1.Size = New System.Drawing.Size(75, 23)
        Me.BFil1.TabIndex = 10
        Me.BFil1.Text = "Filtrar"
        Me.BFil1.UseVisualStyleBackColor = True
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 450)
        Me.Controls.Add(Me.BFil1)
        Me.Controls.Add(Me.BFiltrar2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dpHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dpDesde)
        Me.Controls.Add(Me.BCuit)
        Me.Controls.Add(Me.idVenta)
        Me.Controls.Add(Me.dgvLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteVentas"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents MelodiasDataSetBindingSource As BindingSource
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As melodiasDataSetTableAdapters.ventaTableAdapter
    Friend WithEvents IdVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMetodoPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idVenta As Label
    Friend WithEvents BCuit As TextBox
    Friend WithEvents dpDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dpHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BFiltrar2 As Button
    Friend WithEvents BFil1 As Button
End Class
