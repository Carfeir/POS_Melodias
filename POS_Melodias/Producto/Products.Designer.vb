<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
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
        Dim IdProductoLabel As System.Windows.Forms.Label
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdCategoriaLabel As System.Windows.Forms.Label
        Dim IdMarcaLabel As System.Windows.Forms.Label
        Dim IdColorLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioULabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BuscadorTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CantidadNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IdColorComboBox = New System.Windows.Forms.ComboBox()
        Me.IdMarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager()
        Me.ProductoTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.productoTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AgregarBtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.AgregarProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgregarCategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgregarCantidadNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AgregarColorComboBox = New System.Windows.Forms.ComboBox()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgregarMarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgregarNombreTextBox = New System.Windows.Forms.TextBox()
        Me.AgregarPrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedorTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.proveedorTableAdapter()
        Me.MarcaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.marcaTableAdapter()
        Me.CategoriaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.categoriaTableAdapter()
        Me.ColorTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.colorTableAdapter()
        Me.FKproveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdProductoLabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        IdCategoriaLabel = New System.Windows.Forms.Label()
        IdMarcaLabel = New System.Windows.Forms.Label()
        IdColorLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioULabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoBindingNavigator.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarCantidadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKproveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        IdProductoLabel.Location = New System.Drawing.Point(18, 22)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(72, 15)
        IdProductoLabel.TabIndex = 182
        IdProductoLabel.Text = "Id Producto:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        IdProveedorLabel.Location = New System.Drawing.Point(18, 48)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(66, 15)
        IdProveedorLabel.TabIndex = 184
        IdProveedorLabel.Text = "Proveedor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombreLabel.Location = New System.Drawing.Point(217, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(55, 15)
        NombreLabel.TabIndex = 186
        NombreLabel.Text = "Nombre:"
        '
        'IdCategoriaLabel
        '
        IdCategoriaLabel.AutoSize = True
        IdCategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        IdCategoriaLabel.Location = New System.Drawing.Point(217, 48)
        IdCategoriaLabel.Name = "IdCategoriaLabel"
        IdCategoriaLabel.Size = New System.Drawing.Size(63, 15)
        IdCategoriaLabel.TabIndex = 188
        IdCategoriaLabel.Text = "Categoria:"
        '
        'IdMarcaLabel
        '
        IdMarcaLabel.AutoSize = True
        IdMarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        IdMarcaLabel.Location = New System.Drawing.Point(404, 22)
        IdMarcaLabel.Name = "IdMarcaLabel"
        IdMarcaLabel.Size = New System.Drawing.Size(45, 15)
        IdMarcaLabel.TabIndex = 190
        IdMarcaLabel.Text = "Marca:"
        '
        'IdColorLabel
        '
        IdColorLabel.AutoSize = True
        IdColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        IdColorLabel.Location = New System.Drawing.Point(404, 48)
        IdColorLabel.Name = "IdColorLabel"
        IdColorLabel.Size = New System.Drawing.Size(39, 15)
        IdColorLabel.TabIndex = 192
        IdColorLabel.Text = "Color:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CantidadLabel.Location = New System.Drawing.Point(591, 21)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(59, 15)
        CantidadLabel.TabIndex = 194
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioULabel
        '
        PrecioULabel.AutoSize = True
        PrecioULabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        PrecioULabel.Location = New System.Drawing.Point(591, 47)
        PrecioULabel.Name = "PrecioULabel"
        PrecioULabel.Size = New System.Drawing.Size(57, 15)
        PrecioULabel.TabIndex = 196
        PrecioULabel.Text = "Precio U:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label2.Location = New System.Drawing.Point(18, 47)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 15)
        Label2.TabIndex = 184
        Label2.Text = "Proveedor:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label3.Location = New System.Drawing.Point(18, 21)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 15)
        Label3.TabIndex = 186
        Label3.Text = "Nombre:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label4.Location = New System.Drawing.Point(225, 48)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 15)
        Label4.TabIndex = 188
        Label4.Text = "Categoria:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label5.Location = New System.Drawing.Point(18, 74)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(45, 15)
        Label5.TabIndex = 190
        Label5.Text = "Marca:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label6.Location = New System.Drawing.Point(225, 77)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(39, 15)
        Label6.TabIndex = 192
        Label6.Text = "Color:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label7.Location = New System.Drawing.Point(422, 47)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(59, 15)
        Label7.TabIndex = 194
        Label7.Text = "Cantidad:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label8.Location = New System.Drawing.Point(422, 73)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(57, 15)
        Label8.TabIndex = 196
        Label8.Text = "Precio U:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnVolver.Location = New System.Drawing.Point(12, 460)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 27)
        Me.btnVolver.TabIndex = 172
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnMostrar.Location = New System.Drawing.Point(595, 143)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(176, 50)
        Me.btnMostrar.TabIndex = 173
        Me.btnMostrar.Text = "&Mostrar Productos"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.BuscadorTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 56)
        Me.GroupBox2.TabIndex = 194
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador Por Nombre"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(354, 21)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 21)
        Me.btnLimpiar.TabIndex = 158
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(439, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 27)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BuscadorTextBox
        '
        Me.BuscadorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorTextBox.Location = New System.Drawing.Point(26, 20)
        Me.BuscadorTextBox.Name = "BuscadorTextBox"
        Me.BuscadorTextBox.Size = New System.Drawing.Size(308, 21)
        Me.BuscadorTextBox.TabIndex = 53
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
        Me.ProductoBindingNavigator.Size = New System.Drawing.Size(808, 25)
        Me.ProductoBindingNavigator.TabIndex = 195
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
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
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
        Me.ProductoBindingNavigatorSaveItem.Enabled = False
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
        Me.ProductoDataGridView.Location = New System.Drawing.Point(12, 321)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(777, 133)
        Me.ProductoDataGridView.TabIndex = 195
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
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(646, 81)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(113, 21)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(20, 81)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 21)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdProveedorComboBox)
        Me.GroupBox1.Controls.Add(Me.IdCategoriaComboBox)
        Me.GroupBox1.Controls.Add(Me.CantidadNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.IdColorComboBox)
        Me.GroupBox1.Controls.Add(Me.IdMarcaComboBox)
        Me.GroupBox1.Controls.Add(IdProductoLabel)
        Me.GroupBox1.Controls.Add(Me.IdProductoTextBox)
        Me.GroupBox1.Controls.Add(IdProveedorLabel)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(IdCategoriaLabel)
        Me.GroupBox1.Controls.Add(IdMarcaLabel)
        Me.GroupBox1.Controls.Add(IdColorLabel)
        Me.GroupBox1.Controls.Add(CantidadLabel)
        Me.GroupBox1.Controls.Add(PrecioULabel)
        Me.GroupBox1.Controls.Add(Me.PrecioUTextBox)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(777, 115)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'IdProveedorComboBox
        '
        Me.IdProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProveedor", True))
        Me.IdProveedorComboBox.DataSource = Me.ProveedorBindingSource1
        Me.IdProveedorComboBox.DisplayMember = "nombre"
        Me.IdProveedorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdProveedorComboBox.FormattingEnabled = True
        Me.IdProveedorComboBox.Location = New System.Drawing.Point(89, 44)
        Me.IdProveedorComboBox.Name = "IdProveedorComboBox"
        Me.IdProveedorComboBox.Size = New System.Drawing.Size(106, 23)
        Me.IdProveedorComboBox.TabIndex = 202
        Me.IdProveedorComboBox.ValueMember = "idProveedor"
        '
        'ProveedorBindingSource1
        '
        Me.ProveedorBindingSource1.DataMember = "proveedor"
        Me.ProveedorBindingSource1.DataSource = Me.MelodiasDataSet
        '
        'IdCategoriaComboBox
        '
        Me.IdCategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idCategoria", True))
        Me.IdCategoriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdCategoriaComboBox.FormattingEnabled = True
        Me.IdCategoriaComboBox.Location = New System.Drawing.Point(279, 45)
        Me.IdCategoriaComboBox.Name = "IdCategoriaComboBox"
        Me.IdCategoriaComboBox.Size = New System.Drawing.Size(106, 23)
        Me.IdCategoriaComboBox.TabIndex = 201
        '
        'CantidadNumericUpDown
        '
        Me.CantidadNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductoBindingSource, "cantidad", True))
        Me.CantidadNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CantidadNumericUpDown.Location = New System.Drawing.Point(653, 18)
        Me.CantidadNumericUpDown.Name = "CantidadNumericUpDown"
        Me.CantidadNumericUpDown.Size = New System.Drawing.Size(106, 21)
        Me.CantidadNumericUpDown.TabIndex = 200
        '
        'IdColorComboBox
        '
        Me.IdColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idColor", True))
        Me.IdColorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdColorComboBox.FormattingEnabled = True
        Me.IdColorComboBox.Location = New System.Drawing.Point(452, 44)
        Me.IdColorComboBox.Name = "IdColorComboBox"
        Me.IdColorComboBox.Size = New System.Drawing.Size(106, 23)
        Me.IdColorComboBox.TabIndex = 199
        '
        'IdMarcaComboBox
        '
        Me.IdMarcaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idMarca", True))
        Me.IdMarcaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdMarcaComboBox.FormattingEnabled = True
        Me.IdMarcaComboBox.Location = New System.Drawing.Point(452, 18)
        Me.IdMarcaComboBox.Name = "IdMarcaComboBox"
        Me.IdMarcaComboBox.Size = New System.Drawing.Size(106, 23)
        Me.IdMarcaComboBox.TabIndex = 198
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.IdProductoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdProductoTextBox.Location = New System.Drawing.Point(89, 18)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.ReadOnly = True
        Me.IdProductoTextBox.Size = New System.Drawing.Size(106, 21)
        Me.IdProductoTextBox.TabIndex = 183
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(279, 19)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(106, 21)
        Me.NombreTextBox.TabIndex = 187
        '
        'PrecioUTextBox
        '
        Me.PrecioUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioU", True))
        Me.PrecioUTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.PrecioUTextBox.Location = New System.Drawing.Point(653, 45)
        Me.PrecioUTextBox.Name = "PrecioUTextBox"
        Me.PrecioUTextBox.Size = New System.Drawing.Size(106, 21)
        Me.PrecioUTextBox.TabIndex = 197
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.colorTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.marcaTableAdapter = Nothing
        Me.TableAdapterManager.metodoPagoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.rolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AgregarBtnLimpiar)
        Me.GroupBox3.Controls.Add(Me.BtnAgregar)
        Me.GroupBox3.Controls.Add(Me.AgregarProveedorComboBox)
        Me.GroupBox3.Controls.Add(Me.AgregarCategoriaComboBox)
        Me.GroupBox3.Controls.Add(Me.AgregarCantidadNumericUpDown)
        Me.GroupBox3.Controls.Add(Me.AgregarColorComboBox)
        Me.GroupBox3.Controls.Add(Me.AgregarMarcaComboBox)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.AgregarNombreTextBox)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Label8)
        Me.GroupBox3.Controls.Add(Me.AgregarPrecioTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(777, 106)
        Me.GroupBox3.TabIndex = 196
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Nuevo Producto"
        '
        'AgregarBtnLimpiar
        '
        Me.AgregarBtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarBtnLimpiar.Location = New System.Drawing.Point(631, 71)
        Me.AgregarBtnLimpiar.Name = "AgregarBtnLimpiar"
        Me.AgregarBtnLimpiar.Size = New System.Drawing.Size(113, 21)
        Me.AgregarBtnLimpiar.TabIndex = 203
        Me.AgregarBtnLimpiar.Text = "Limpiar"
        Me.AgregarBtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(631, 18)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(113, 36)
        Me.BtnAgregar.TabIndex = 197
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'AgregarProveedorComboBox
        '
        Me.AgregarProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProveedor", True))
        Me.AgregarProveedorComboBox.DataSource = Me.ProveedorBindingSource
        Me.AgregarProveedorComboBox.DisplayMember = "nombre"
        Me.AgregarProveedorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarProveedorComboBox.FormattingEnabled = True
        Me.AgregarProveedorComboBox.Location = New System.Drawing.Point(85, 44)
        Me.AgregarProveedorComboBox.Name = "AgregarProveedorComboBox"
        Me.AgregarProveedorComboBox.Size = New System.Drawing.Size(106, 23)
        Me.AgregarProveedorComboBox.TabIndex = 202
        Me.AgregarProveedorComboBox.ValueMember = "idProveedor"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.MelodiasDataSet
        '
        'AgregarCategoriaComboBox
        '
        Me.AgregarCategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idCategoria", True))
        Me.AgregarCategoriaComboBox.DataSource = Me.CategoriaBindingSource
        Me.AgregarCategoriaComboBox.DisplayMember = "nombre"
        Me.AgregarCategoriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarCategoriaComboBox.FormattingEnabled = True
        Me.AgregarCategoriaComboBox.Location = New System.Drawing.Point(287, 45)
        Me.AgregarCategoriaComboBox.Name = "AgregarCategoriaComboBox"
        Me.AgregarCategoriaComboBox.Size = New System.Drawing.Size(106, 23)
        Me.AgregarCategoriaComboBox.TabIndex = 201
        Me.AgregarCategoriaComboBox.ValueMember = "IdCategoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'AgregarCantidadNumericUpDown
        '
        Me.AgregarCantidadNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductoBindingSource, "cantidad", True))
        Me.AgregarCantidadNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarCantidadNumericUpDown.Location = New System.Drawing.Point(486, 44)
        Me.AgregarCantidadNumericUpDown.Name = "AgregarCantidadNumericUpDown"
        Me.AgregarCantidadNumericUpDown.Size = New System.Drawing.Size(106, 21)
        Me.AgregarCantidadNumericUpDown.TabIndex = 200
        Me.AgregarCantidadNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AgregarColorComboBox
        '
        Me.AgregarColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idColor", True))
        Me.AgregarColorComboBox.DataSource = Me.ColorBindingSource
        Me.AgregarColorComboBox.DisplayMember = "nombre"
        Me.AgregarColorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarColorComboBox.FormattingEnabled = True
        Me.AgregarColorComboBox.Location = New System.Drawing.Point(287, 74)
        Me.AgregarColorComboBox.Name = "AgregarColorComboBox"
        Me.AgregarColorComboBox.Size = New System.Drawing.Size(106, 23)
        Me.AgregarColorComboBox.TabIndex = 199
        Me.AgregarColorComboBox.Text = "Seleccionar"
        Me.AgregarColorComboBox.ValueMember = "nombre"
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataMember = "color"
        Me.ColorBindingSource.DataSource = Me.MelodiasDataSet
        '
        'AgregarMarcaComboBox
        '
        Me.AgregarMarcaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idMarca", True))
        Me.AgregarMarcaComboBox.DataSource = Me.MarcaBindingSource
        Me.AgregarMarcaComboBox.DisplayMember = "nombre"
        Me.AgregarMarcaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarMarcaComboBox.FormattingEnabled = True
        Me.AgregarMarcaComboBox.Location = New System.Drawing.Point(85, 70)
        Me.AgregarMarcaComboBox.Name = "AgregarMarcaComboBox"
        Me.AgregarMarcaComboBox.Size = New System.Drawing.Size(106, 23)
        Me.AgregarMarcaComboBox.TabIndex = 198
        Me.AgregarMarcaComboBox.Text = "Seleccionar"
        Me.AgregarMarcaComboBox.ValueMember = "IdMarca"
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "marca"
        Me.MarcaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'AgregarNombreTextBox
        '
        Me.AgregarNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.AgregarNombreTextBox.Location = New System.Drawing.Point(85, 18)
        Me.AgregarNombreTextBox.Name = "AgregarNombreTextBox"
        Me.AgregarNombreTextBox.Size = New System.Drawing.Size(507, 21)
        Me.AgregarNombreTextBox.TabIndex = 187
        '
        'AgregarPrecioTextBox
        '
        Me.AgregarPrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioU", True))
        Me.AgregarPrecioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarPrecioTextBox.Location = New System.Drawing.Point(486, 71)
        Me.AgregarPrecioTextBox.Name = "AgregarPrecioTextBox"
        Me.AgregarPrecioTextBox.Size = New System.Drawing.Size(106, 21)
        Me.AgregarPrecioTextBox.TabIndex = 197
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'ColorTableAdapter
        '
        Me.ColorTableAdapter.ClearBeforeFill = True
        '
        'FKproveedorBindingSource
        '
        Me.FKproveedorBindingSource.DataMember = "FK_proveedor"
        Me.FKproveedorBindingSource.DataSource = Me.ProveedorBindingSource
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 493)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.ProductoBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoBindingNavigator.ResumeLayout(False)
        Me.ProductoBindingNavigator.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarCantidadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKproveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnVolver As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BuscadorTextBox As TextBox
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
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
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents PrecioUTextBox As TextBox
    Friend WithEvents IdMarcaComboBox As ComboBox
    Friend WithEvents ProductoTableAdapter As melodiasDataSetTableAdapters.productoTableAdapter
    Friend WithEvents IdProveedorComboBox As ComboBox
    Friend WithEvents IdCategoriaComboBox As ComboBox
    Friend WithEvents CantidadNumericUpDown As NumericUpDown
    Friend WithEvents IdColorComboBox As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AgregarProveedorComboBox As ComboBox
    Friend WithEvents AgregarCategoriaComboBox As ComboBox
    Friend WithEvents AgregarCantidadNumericUpDown As NumericUpDown
    Friend WithEvents AgregarColorComboBox As ComboBox
    Friend WithEvents AgregarMarcaComboBox As ComboBox
    Friend WithEvents AgregarNombreTextBox As TextBox
    Friend WithEvents AgregarPrecioTextBox As TextBox
    Friend WithEvents BtnAgregar As Button
    Private WithEvents AgregarBtnLimpiar As Button
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As melodiasDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents MarcaBindingSource As BindingSource
    Friend WithEvents MarcaTableAdapter As melodiasDataSetTableAdapters.marcaTableAdapter
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As melodiasDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ColorTableAdapter As melodiasDataSetTableAdapters.colorTableAdapter
    Friend WithEvents ProveedorBindingSource1 As BindingSource
    Friend WithEvents FKproveedorBindingSource As BindingSource
End Class
