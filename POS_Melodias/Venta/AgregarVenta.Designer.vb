<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DNILabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim NroContactoLabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarVenta))
        Dim Label25 As System.Windows.Forms.Label
        Dim IdProductoLabel As System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBoxMetodoPago = New System.Windows.Forms.ComboBox()
        Me.MetodoPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTaxAmt = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Save = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomYapeTextBox = New System.Windows.Forms.TextBox()
        Me.NroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.IdProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdCategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdMarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdColorComboBox = New System.Windows.Forms.ComboBox()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrecioUTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadProductoSeleccionado = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnQuitarDetalle = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBoxClienteSeleccionado = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarCliente = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.BuscadorClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarProducto = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.BuscadorProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.clienteTableAdapter()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPagoTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.metodoPagoTableAdapter()
        Me.ProveedorTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.proveedorTableAdapter()
        Me.CategoriaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.categoriaTableAdapter()
        Me.ColorTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.colorTableAdapter()
        Me.btnMostrarClientes = New System.Windows.Forms.Button()
        Me.btnMostrarProductos = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxDNIclienteSeleccionado = New System.Windows.Forms.TextBox()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.ventaTableAdapter()
        Me.IdVentaTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleVentaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.detalleVentaTableAdapter()
        Me.DetalleVentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnModificarDetalle = New System.Windows.Forms.Button()
        Me.CantidadNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IdProductoTextBox1 = New System.Windows.Forms.TextBox()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        IdProductoLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.MetodoPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadProductoSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoBindingNavigator.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleVentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DNILabel.Location = New System.Drawing.Point(13, 24)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(31, 15)
        DNILabel.TabIndex = 0
        DNILabel.Text = "DNI:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(13, 48)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(110, 15)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre y Apellido:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(13, 71)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(84, 15)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Nro. Contacto:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(13, 93)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(111, 15)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Correo Electronico:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label2.Location = New System.Drawing.Point(12, 170)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 15)
        Label2.TabIndex = 162
        Label2.Text = "Precio U:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label5.Location = New System.Drawing.Point(12, 193)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(40, 15)
        Label5.TabIndex = 164
        Label5.Text = "Stock:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label7.Location = New System.Drawing.Point(12, 70)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(66, 15)
        Label7.TabIndex = 0
        Label7.Text = "Proveedor:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label9.Location = New System.Drawing.Point(12, 47)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(55, 15)
        Label9.TabIndex = 2
        Label9.Text = "Nombre:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label10.Location = New System.Drawing.Point(12, 95)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(63, 15)
        Label10.TabIndex = 4
        Label10.Text = "Categoria:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label12.Location = New System.Drawing.Point(12, 120)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(45, 15)
        Label12.TabIndex = 6
        Label12.Text = "Marca:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label13.Location = New System.Drawing.Point(13, 145)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(39, 15)
        Label13.TabIndex = 8
        Label13.Text = "Color:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label14.Location = New System.Drawing.Point(12, 24)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(74, 15)
        Label14.TabIndex = 185
        Label14.Text = "ID Producto:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label18.Location = New System.Drawing.Point(42, 242)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(38, 15)
        Label18.TabIndex = 187
        Label18.Text = "Cant.:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DireccionLabel.Location = New System.Drawing.Point(13, 116)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(62, 15)
        DireccionLabel.TabIndex = 20
        DireccionLabel.Text = "Direccion:"
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnRemove.Location = New System.Drawing.Point(566, 892)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(102, 36)
        Me.btnRemove.TabIndex = 145
        Me.btnRemove.Text = "Cancelar"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.TextBox13)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.ComboBoxMetodoPago)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txtTaxAmt)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtSubTotal)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(24, 861)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 90)
        Me.Panel2.TabIndex = 144
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(313, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 20)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "$"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(344, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 15)
        Me.Label20.TabIndex = 96
        Me.Label20.Text = "TOTAL"
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox13.Location = New System.Drawing.Point(346, 38)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(132, 20)
        Me.TextBox13.TabIndex = 95
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(138, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 20)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "$"
        '
        'ComboBoxMetodoPago
        '
        Me.ComboBoxMetodoPago.DataSource = Me.MetodoPagoBindingSource
        Me.ComboBoxMetodoPago.DisplayMember = "nombre"
        Me.ComboBoxMetodoPago.FormattingEnabled = True
        Me.ComboBoxMetodoPago.Location = New System.Drawing.Point(138, 35)
        Me.ComboBoxMetodoPago.Name = "ComboBoxMetodoPago"
        Me.ComboBoxMetodoPago.Size = New System.Drawing.Size(132, 21)
        Me.ComboBoxMetodoPago.TabIndex = 96
        Me.ComboBoxMetodoPago.ValueMember = "IdMetodoPago"
        '
        'MetodoPagoBindingSource
        '
        Me.MetodoPagoBindingSource.DataMember = "metodoPago"
        Me.MetodoPagoBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(19, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 15)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Metodo de Pago"
        '
        'txtTaxAmt
        '
        Me.txtTaxAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTaxAmt.Location = New System.Drawing.Point(171, 58)
        Me.txtTaxAmt.Name = "txtTaxAmt"
        Me.txtTaxAmt.ReadOnly = True
        Me.txtTaxAmt.Size = New System.Drawing.Size(99, 20)
        Me.txtTaxAmt.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(138, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 20)
        Me.Label24.TabIndex = 92
        Me.Label24.Text = "%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(19, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Recargo"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSubTotal.Location = New System.Drawing.Point(167, 11)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtSubTotal.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(19, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 15)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Sub Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Nueva Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(563, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "No. de Venta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(563, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Fecha de Venta:"
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOrderDate.Location = New System.Drawing.Point(671, 49)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpOrderDate.TabIndex = 130
        Me.dtpOrderDate.Value = New Date(2022, 11, 16, 0, 0, 0, 0)
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Save.Location = New System.Drawing.Point(698, 892)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(102, 36)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Guardar"
        Me.Save.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DNITextBox)
        Me.GroupBox3.Controls.Add(Me.NomYapeTextBox)
        Me.GroupBox3.Controls.Add(Me.NroContactoTextBox)
        Me.GroupBox3.Controls.Add(Me.CorreoElectronicoTextBox)
        Me.GroupBox3.Controls.Add(DireccionLabel)
        Me.GroupBox3.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox3.Controls.Add(Me.btnSeleccionarCliente)
        Me.GroupBox3.Controls.Add(DNILabel)
        Me.GroupBox3.Controls.Add(NombresLabel)
        Me.GroupBox3.Controls.Add(NroContactoLabel)
        Me.GroupBox3.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 195)
        Me.GroupBox3.TabIndex = 180
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de Cliente"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DNI", True))
        Me.DNITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(131, 21)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.ReadOnly = True
        Me.DNITextBox.Size = New System.Drawing.Size(140, 21)
        Me.DNITextBox.TabIndex = 13
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.MelodiasDataSet
        '
        'NomYapeTextBox
        '
        Me.NomYapeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nomYape", True))
        Me.NomYapeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NomYapeTextBox.Location = New System.Drawing.Point(131, 44)
        Me.NomYapeTextBox.Name = "NomYapeTextBox"
        Me.NomYapeTextBox.ReadOnly = True
        Me.NomYapeTextBox.Size = New System.Drawing.Size(140, 21)
        Me.NomYapeTextBox.TabIndex = 15
        '
        'NroContactoTextBox
        '
        Me.NroContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nroContacto", True))
        Me.NroContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NroContactoTextBox.Location = New System.Drawing.Point(131, 67)
        Me.NroContactoTextBox.Name = "NroContactoTextBox"
        Me.NroContactoTextBox.ReadOnly = True
        Me.NroContactoTextBox.Size = New System.Drawing.Size(140, 21)
        Me.NroContactoTextBox.TabIndex = 17
        '
        'CorreoElectronicoTextBox
        '
        Me.CorreoElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "correoElectronico", True))
        Me.CorreoElectronicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CorreoElectronicoTextBox.Location = New System.Drawing.Point(131, 90)
        Me.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox"
        Me.CorreoElectronicoTextBox.ReadOnly = True
        Me.CorreoElectronicoTextBox.Size = New System.Drawing.Size(140, 21)
        Me.CorreoElectronicoTextBox.TabIndex = 19
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DireccionTextBox.Location = New System.Drawing.Point(131, 113)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.ReadOnly = True
        Me.DireccionTextBox.Size = New System.Drawing.Size(140, 21)
        Me.DireccionTextBox.TabIndex = 21
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(3, 165)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(274, 27)
        Me.btnSeleccionarCliente.TabIndex = 12
        Me.btnSeleccionarCliente.Text = "Seleccionar"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox1.Controls.Add(Me.IdProductoTextBox)
        Me.GroupBox1.Controls.Add(Me.IdProveedorComboBox)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.IdCategoriaComboBox)
        Me.GroupBox1.Controls.Add(Me.IdMarcaComboBox)
        Me.GroupBox1.Controls.Add(Me.IdColorComboBox)
        Me.GroupBox1.Controls.Add(Me.PrecioUTextBox)
        Me.GroupBox1.Controls.Add(Me.CantidadProductoSeleccionado)
        Me.GroupBox1.Controls.Add(Label18)
        Me.GroupBox1.Controls.Add(Label14)
        Me.GroupBox1.Controls.Add(Me.btnAgregarProducto)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 359)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(280, 281)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(92, 190)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.ReadOnly = True
        Me.CantidadTextBox.Size = New System.Drawing.Size(163, 21)
        Me.CantidadTextBox.TabIndex = 213
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.MelodiasDataSet
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.IdProductoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdProductoTextBox.Location = New System.Drawing.Point(92, 21)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.ReadOnly = True
        Me.IdProductoTextBox.Size = New System.Drawing.Size(163, 21)
        Me.IdProductoTextBox.TabIndex = 198
        '
        'IdProveedorComboBox
        '
        Me.IdProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProveedor", True))
        Me.IdProveedorComboBox.DataSource = Me.ProveedorBindingSource
        Me.IdProveedorComboBox.DisplayMember = "nombre"
        Me.IdProveedorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdProveedorComboBox.FormattingEnabled = True
        Me.IdProveedorComboBox.Location = New System.Drawing.Point(92, 67)
        Me.IdProveedorComboBox.Name = "IdProveedorComboBox"
        Me.IdProveedorComboBox.Size = New System.Drawing.Size(163, 23)
        Me.IdProveedorComboBox.TabIndex = 200
        Me.IdProveedorComboBox.ValueMember = "idProveedor"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.MelodiasDataSet
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(92, 44)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(163, 21)
        Me.NombreTextBox.TabIndex = 202
        '
        'IdCategoriaComboBox
        '
        Me.IdCategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idCategoria", True))
        Me.IdCategoriaComboBox.DataSource = Me.CategoriaBindingSource
        Me.IdCategoriaComboBox.DisplayMember = "nombre"
        Me.IdCategoriaComboBox.Enabled = False
        Me.IdCategoriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdCategoriaComboBox.FormattingEnabled = True
        Me.IdCategoriaComboBox.Location = New System.Drawing.Point(92, 92)
        Me.IdCategoriaComboBox.Name = "IdCategoriaComboBox"
        Me.IdCategoriaComboBox.Size = New System.Drawing.Size(163, 23)
        Me.IdCategoriaComboBox.TabIndex = 204
        Me.IdCategoriaComboBox.ValueMember = "IdCategoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'IdMarcaComboBox
        '
        Me.IdMarcaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idMarca", True))
        Me.IdMarcaComboBox.DataSource = Me.CategoriaBindingSource1
        Me.IdMarcaComboBox.DisplayMember = "nombre"
        Me.IdMarcaComboBox.Enabled = False
        Me.IdMarcaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdMarcaComboBox.FormattingEnabled = True
        Me.IdMarcaComboBox.Location = New System.Drawing.Point(92, 117)
        Me.IdMarcaComboBox.Name = "IdMarcaComboBox"
        Me.IdMarcaComboBox.Size = New System.Drawing.Size(163, 23)
        Me.IdMarcaComboBox.TabIndex = 206
        Me.IdMarcaComboBox.ValueMember = "IdCategoria"
        '
        'CategoriaBindingSource1
        '
        Me.CategoriaBindingSource1.DataMember = "categoria"
        Me.CategoriaBindingSource1.DataSource = Me.MelodiasDataSet
        '
        'IdColorComboBox
        '
        Me.IdColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idColor", True))
        Me.IdColorComboBox.DataSource = Me.ColorBindingSource
        Me.IdColorComboBox.DisplayMember = "nombre"
        Me.IdColorComboBox.Enabled = False
        Me.IdColorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdColorComboBox.FormattingEnabled = True
        Me.IdColorComboBox.Location = New System.Drawing.Point(92, 142)
        Me.IdColorComboBox.Name = "IdColorComboBox"
        Me.IdColorComboBox.Size = New System.Drawing.Size(163, 23)
        Me.IdColorComboBox.TabIndex = 208
        Me.IdColorComboBox.ValueMember = "IdColor"
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataMember = "color"
        Me.ColorBindingSource.DataSource = Me.MelodiasDataSet
        '
        'PrecioUTextBox
        '
        Me.PrecioUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioU", True))
        Me.PrecioUTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.PrecioUTextBox.Location = New System.Drawing.Point(92, 167)
        Me.PrecioUTextBox.Name = "PrecioUTextBox"
        Me.PrecioUTextBox.ReadOnly = True
        Me.PrecioUTextBox.Size = New System.Drawing.Size(163, 21)
        Me.PrecioUTextBox.TabIndex = 212
        '
        'CantidadProductoSeleccionado
        '
        Me.CantidadProductoSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CantidadProductoSeleccionado.Location = New System.Drawing.Point(86, 242)
        Me.CantidadProductoSeleccionado.Name = "CantidadProductoSeleccionado"
        Me.CantidadProductoSeleccionado.Size = New System.Drawing.Size(46, 20)
        Me.CantidadProductoSeleccionado.TabIndex = 197
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAgregarProducto.Location = New System.Drawing.Point(152, 238)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(78, 25)
        Me.btnAgregarProducto.TabIndex = 182
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnQuitarDetalle
        '
        Me.btnQuitarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnQuitarDetalle.Location = New System.Drawing.Point(671, 830)
        Me.btnQuitarDetalle.Name = "btnQuitarDetalle"
        Me.btnQuitarDetalle.Size = New System.Drawing.Size(97, 25)
        Me.btnQuitarDetalle.TabIndex = 184
        Me.btnQuitarDetalle.Text = "Quitar"
        Me.btnQuitarDetalle.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(24, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 186
        Me.Label11.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(21, 654)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Detalle de Venta"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(253, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 15)
        Me.Label21.TabIndex = 191
        Me.Label21.Text = "Cliente:"
        '
        'TextBoxClienteSeleccionado
        '
        Me.TextBoxClienteSeleccionado.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxClienteSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBoxClienteSeleccionado.Location = New System.Drawing.Point(342, 49)
        Me.TextBoxClienteSeleccionado.Name = "TextBoxClienteSeleccionado"
        Me.TextBoxClienteSeleccionado.ReadOnly = True
        Me.TextBoxClienteSeleccionado.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxClienteSeleccionado.TabIndex = 190
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnLimpiarCliente)
        Me.GroupBox4.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox4.Controls.Add(Me.BuscadorClienteTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(312, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(494, 55)
        Me.GroupBox4.TabIndex = 192
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Cliente Por DNI"
        '
        'btnLimpiarCliente
        '
        Me.btnLimpiarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLimpiarCliente.Location = New System.Drawing.Point(310, 15)
        Me.btnLimpiarCliente.Name = "btnLimpiarCliente"
        Me.btnLimpiarCliente.Size = New System.Drawing.Size(79, 35)
        Me.btnLimpiarCliente.TabIndex = 158
        Me.btnLimpiarCliente.Text = "Limpiar"
        Me.btnLimpiarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCliente.Location = New System.Drawing.Point(395, 15)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(93, 34)
        Me.btnBuscarCliente.TabIndex = 55
        Me.btnBuscarCliente.Text = "&Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'BuscadorClienteTextBox
        '
        Me.BuscadorClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorClienteTextBox.Location = New System.Drawing.Point(30, 20)
        Me.BuscadorClienteTextBox.Name = "BuscadorClienteTextBox"
        Me.BuscadorClienteTextBox.Size = New System.Drawing.Size(264, 21)
        Me.BuscadorClienteTextBox.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(21, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiarProducto)
        Me.GroupBox2.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox2.Controls.Add(Me.BuscadorProductoTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 55)
        Me.GroupBox2.TabIndex = 195
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Producto Por Nombre"
        '
        'btnLimpiarProducto
        '
        Me.btnLimpiarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLimpiarProducto.Location = New System.Drawing.Point(301, 16)
        Me.btnLimpiarProducto.Name = "btnLimpiarProducto"
        Me.btnLimpiarProducto.Size = New System.Drawing.Size(79, 33)
        Me.btnLimpiarProducto.TabIndex = 158
        Me.btnLimpiarProducto.Text = "Limpiar"
        Me.btnLimpiarProducto.UseVisualStyleBackColor = True
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProducto.Location = New System.Drawing.Point(386, 15)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(93, 34)
        Me.btnBuscarProducto.TabIndex = 55
        Me.btnBuscarProducto.Text = "&Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'BuscadorProductoTextBox
        '
        Me.BuscadorProductoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorProductoTextBox.Location = New System.Drawing.Point(21, 20)
        Me.BuscadorProductoTextBox.Name = "BuscadorProductoTextBox"
        Me.BuscadorProductoTextBox.Size = New System.Drawing.Size(264, 21)
        Me.BuscadorProductoTextBox.TabIndex = 53
        '
        'ProductoBindingNavigator
        '
        Me.ProductoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductoBindingNavigator.BindingSource = Me.ProductoBindingSource
        Me.ProductoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductoBindingNavigatorSaveItem})
        Me.ProductoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductoBindingNavigator.Name = "ProductoBindingNavigator"
        Me.ProductoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductoBindingNavigator.Size = New System.Drawing.Size(835, 25)
        Me.ProductoBindingNavigator.TabIndex = 196
        Me.ProductoBindingNavigator.Text = "BindingNavigator1"
        Me.ProductoBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductoBindingNavigatorSaveItem
        '
        Me.ProductoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductoBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductoBindingNavigatorSaveItem.Name = "ProductoBindingNavigatorSaveItem"
        Me.ProductoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(321, 420)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(494, 190)
        Me.ProductoDataGridView.TabIndex = 196
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idProducto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idProveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idProveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idCategoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idCategoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idMarca"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idMarca"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idColor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idColor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "precioU"
        Me.DataGridViewTextBoxColumn8.HeaderText = "precioU"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.colorTableAdapter = Nothing
        Me.TableAdapterManager.detalleVentaTableAdapter = Nothing
        Me.TableAdapterManager.marcaTableAdapter = Nothing
        Me.TableAdapterManager.metodoPagoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.rolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(312, 174)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(494, 101)
        Me.ClienteDataGridView.TabIndex = 196
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "nomYape"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre y Apellido"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nroContacto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nro. Contacto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "correoElectronico"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'MetodoPagoTableAdapter
        '
        Me.MetodoPagoTableAdapter.ClearBeforeFill = True
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'ColorTableAdapter
        '
        Me.ColorTableAdapter.ClearBeforeFill = True
        '
        'btnMostrarClientes
        '
        Me.btnMostrarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnMostrarClientes.Location = New System.Drawing.Point(641, 281)
        Me.btnMostrarClientes.Name = "btnMostrarClientes"
        Me.btnMostrarClientes.Size = New System.Drawing.Size(165, 24)
        Me.btnMostrarClientes.TabIndex = 197
        Me.btnMostrarClientes.Text = "&Mostrar Clientes"
        Me.btnMostrarClientes.UseVisualStyleBackColor = True
        '
        'btnMostrarProductos
        '
        Me.btnMostrarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnMostrarProductos.Location = New System.Drawing.Point(650, 616)
        Me.btnMostrarProductos.Name = "btnMostrarProductos"
        Me.btnMostrarProductos.Size = New System.Drawing.Size(165, 24)
        Me.btnMostrarProductos.TabIndex = 198
        Me.btnMostrarProductos.Text = "&Mostrar Productos"
        Me.btnMostrarProductos.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(253, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 15)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "DNI Cliente:"
        '
        'TextBoxDNIclienteSeleccionado
        '
        Me.TextBoxDNIclienteSeleccionado.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDNIclienteSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBoxDNIclienteSeleccionado.Location = New System.Drawing.Point(342, 19)
        Me.TextBoxDNIclienteSeleccionado.Name = "TextBoxDNIclienteSeleccionado"
        Me.TextBoxDNIclienteSeleccionado.ReadOnly = True
        Me.TextBoxDNIclienteSeleccionado.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxDNIclienteSeleccionado.TabIndex = 199
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'IdVentaTextBox
        '
        Me.IdVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "idVenta", True))
        Me.IdVentaTextBox.Location = New System.Drawing.Point(671, 22)
        Me.IdVentaTextBox.Name = "IdVentaTextBox"
        Me.IdVentaTextBox.ReadOnly = True
        Me.IdVentaTextBox.Size = New System.Drawing.Size(110, 20)
        Me.IdVentaTextBox.TabIndex = 201
        '
        'DetalleVentaBindingSource
        '
        Me.DetalleVentaBindingSource.DataMember = "detalleVenta"
        Me.DetalleVentaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'DetalleVentaTableAdapter
        '
        Me.DetalleVentaTableAdapter.ClearBeforeFill = True
        '
        'DetalleVentaDataGridView
        '
        Me.DetalleVentaDataGridView.AutoGenerateColumns = False
        Me.DetalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleVentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.DetalleVentaDataGridView.DataSource = Me.DetalleVentaBindingSource
        Me.DetalleVentaDataGridView.Location = New System.Drawing.Point(24, 679)
        Me.DetalleVentaDataGridView.Name = "DetalleVentaDataGridView"
        Me.DetalleVentaDataGridView.Size = New System.Drawing.Size(596, 176)
        Me.DetalleVentaDataGridView.TabIndex = 201
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "idDetalleVenta"
        Me.DataGridViewTextBoxColumn14.HeaderText = "idDetalleVenta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "idVenta"
        Me.DataGridViewTextBoxColumn15.HeaderText = "idVenta"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn16.HeaderText = "idProducto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'BtnModificarDetalle
        '
        Me.BtnModificarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BtnModificarDetalle.Location = New System.Drawing.Point(650, 771)
        Me.BtnModificarDetalle.Name = "BtnModificarDetalle"
        Me.BtnModificarDetalle.Size = New System.Drawing.Size(150, 25)
        Me.BtnModificarDetalle.TabIndex = 202
        Me.BtnModificarDetalle.Text = "Modificar"
        Me.BtnModificarDetalle.UseVisualStyleBackColor = True
        '
        'CantidadNumericUpDown
        '
        Me.CantidadNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetalleVentaBindingSource, "cantidad", True))
        Me.CantidadNumericUpDown.Location = New System.Drawing.Point(707, 730)
        Me.CantidadNumericUpDown.Name = "CantidadNumericUpDown"
        Me.CantidadNumericUpDown.Size = New System.Drawing.Size(93, 20)
        Me.CantidadNumericUpDown.TabIndex = 203
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label25.Location = New System.Drawing.Point(663, 730)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(38, 15)
        Label25.TabIndex = 204
        Label25.Text = "Cant.:"
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.Location = New System.Drawing.Point(663, 700)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(67, 13)
        IdProductoLabel.TabIndex = 204
        IdProductoLabel.Text = "ID Producto:"
        '
        'IdProductoTextBox1
        '
        Me.IdProductoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleVentaBindingSource, "idProducto", True))
        Me.IdProductoTextBox1.Location = New System.Drawing.Point(733, 697)
        Me.IdProductoTextBox1.Name = "IdProductoTextBox1"
        Me.IdProductoTextBox1.ReadOnly = True
        Me.IdProductoTextBox1.Size = New System.Drawing.Size(67, 20)
        Me.IdProductoTextBox1.TabIndex = 205
        '
        'AgregarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 995)
        Me.Controls.Add(IdProductoLabel)
        Me.Controls.Add(Me.IdProductoTextBox1)
        Me.Controls.Add(Label25)
        Me.Controls.Add(Me.CantidadNumericUpDown)
        Me.Controls.Add(Me.BtnModificarDetalle)
        Me.Controls.Add(Me.DetalleVentaDataGridView)
        Me.Controls.Add(Me.IdVentaTextBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBoxDNIclienteSeleccionado)
        Me.Controls.Add(Me.btnMostrarProductos)
        Me.Controls.Add(Me.btnMostrarClientes)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnQuitarDetalle)
        Me.Controls.Add(Me.TextBoxClienteSeleccionado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ProductoBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpOrderDate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Venta"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MetodoPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadProductoSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoBindingNavigator.ResumeLayout(False)
        Me.ProductoBindingNavigator.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleVentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTaxAmt As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents Save As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnQuitarDetalle As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBoxClienteSeleccionado As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Private WithEvents btnLimpiarCliente As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents BuscadorClienteTextBox As TextBox
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents btnLimpiarProducto As Button
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents BuscadorProductoTextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBoxMetodoPago As ComboBox
    Friend WithEvents CantidadProductoSeleccionado As NumericUpDown
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As melodiasDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As melodiasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents PrecioUTextBox As TextBox
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As melodiasDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents NomYapeTextBox As TextBox
    Friend WithEvents NroContactoTextBox As TextBox
    Friend WithEvents CorreoElectronicoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents MetodoPagoBindingSource As BindingSource
    Friend WithEvents MetodoPagoTableAdapter As melodiasDataSetTableAdapters.metodoPagoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorComboBox As ComboBox
    Friend WithEvents IdCategoriaComboBox As ComboBox
    Friend WithEvents IdMarcaComboBox As ComboBox
    Friend WithEvents IdColorComboBox As ComboBox
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As melodiasDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As melodiasDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents CategoriaBindingSource1 As BindingSource
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ColorTableAdapter As melodiasDataSetTableAdapters.colorTableAdapter
    Friend WithEvents btnMostrarClientes As Button
    Friend WithEvents btnMostrarProductos As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxDNIclienteSeleccionado As TextBox
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As melodiasDataSetTableAdapters.ventaTableAdapter
    Friend WithEvents IdVentaTextBox As TextBox
    Friend WithEvents DetalleVentaBindingSource As BindingSource
    Friend WithEvents DetalleVentaTableAdapter As melodiasDataSetTableAdapters.detalleVentaTableAdapter
    Friend WithEvents DetalleVentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents BtnModificarDetalle As Button
    Friend WithEvents CantidadNumericUpDown As NumericUpDown
    Friend WithEvents IdProductoTextBox1 As TextBox
End Class
