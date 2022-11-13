<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clients
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clients))
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
        Me.CorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.NroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.NomYapeTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BuscadorTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSAgregarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AgregarBtnLimpiar = New System.Windows.Forms.Button()
        Me.AgregarDNITextBox = New System.Windows.Forms.TextBox()
        Me.AgregarNomYapeTextBox = New System.Windows.Forms.TextBox()
        Me.AgregarNroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.AgregarCorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.AgregarDireccionTextBox = New System.Windows.Forms.TextBox()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DNILabel.Location = New System.Drawing.Point(20, 24)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(31, 15)
        DNILabel.TabIndex = 0
        DNILabel.Text = "DNI:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 47)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(110, 15)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre y Apellido:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 70)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(84, 15)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Nro. Contacto:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 93)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(111, 15)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Correo Electronico:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label1.Location = New System.Drawing.Point(20, 116)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 15)
        Label1.TabIndex = 10
        Label1.Text = "Direccion:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label2.Location = New System.Drawing.Point(318, 48)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 15)
        Label2.TabIndex = 10
        Label2.Text = "Direccion:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label3.Location = New System.Drawing.Point(28, 25)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(31, 15)
        Label3.TabIndex = 0
        Label3.Text = "DNI:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label4.Location = New System.Drawing.Point(28, 48)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(110, 15)
        Label4.TabIndex = 2
        Label4.Text = "Nombre y Apellido:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label5.Location = New System.Drawing.Point(28, 71)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(84, 15)
        Label5.TabIndex = 6
        Label5.Text = "Nro. Contacto:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label6.Location = New System.Drawing.Point(318, 25)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(111, 15)
        Label6.TabIndex = 8
        Label6.Text = "Correo Electronico:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(22, 146)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 30)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(228, 149)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 30)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(Me.CorreoElectronicoTextBox)
        Me.GroupBox1.Controls.Add(Me.NroContactoTextBox)
        Me.GroupBox1.Controls.Add(Me.NomYapeTextBox)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 185)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Cliente"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DireccionTextBox.Location = New System.Drawing.Point(159, 113)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(162, 21)
        Me.DireccionTextBox.TabIndex = 15
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CorreoElectronicoTextBox
        '
        Me.CorreoElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "correoElectronico", True))
        Me.CorreoElectronicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CorreoElectronicoTextBox.Location = New System.Drawing.Point(159, 90)
        Me.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox"
        Me.CorreoElectronicoTextBox.Size = New System.Drawing.Size(162, 21)
        Me.CorreoElectronicoTextBox.TabIndex = 14
        '
        'NroContactoTextBox
        '
        Me.NroContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nroContacto", True))
        Me.NroContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NroContactoTextBox.Location = New System.Drawing.Point(159, 67)
        Me.NroContactoTextBox.Name = "NroContactoTextBox"
        Me.NroContactoTextBox.Size = New System.Drawing.Size(162, 21)
        Me.NroContactoTextBox.TabIndex = 13
        '
        'NomYapeTextBox
        '
        Me.NomYapeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nomYape", True))
        Me.NomYapeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NomYapeTextBox.Location = New System.Drawing.Point(159, 44)
        Me.NomYapeTextBox.Name = "NomYapeTextBox"
        Me.NomYapeTextBox.Size = New System.Drawing.Size(162, 21)
        Me.NomYapeTextBox.TabIndex = 12
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DNI", True))
        Me.DNITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(159, 20)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.ReadOnly = True
        Me.DNITextBox.Size = New System.Drawing.Size(162, 21)
        Me.DNITextBox.TabIndex = 11
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.btnVolver.Location = New System.Drawing.Point(827, 428)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 27)
        Me.btnVolver.TabIndex = 155
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 465)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(567, 25)
        Me.ClienteBindingNavigator.TabIndex = 156
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
        Me.ClienteBindingNavigator.Visible = False
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
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnMostrar.Location = New System.Drawing.Point(579, 179)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(327, 30)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "&Mostrar Clientes"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.BuscadorTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 56)
        Me.GroupBox2.TabIndex = 157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador Por DNI"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(321, 17)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 29)
        Me.btnLimpiar.TabIndex = 158
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(406, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 34)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BuscadorTextBox
        '
        Me.BuscadorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorTextBox.Location = New System.Drawing.Point(23, 20)
        Me.BuscadorTextBox.Name = "BuscadorTextBox"
        Me.BuscadorTextBox.Size = New System.Drawing.Size(269, 21)
        Me.BuscadorTextBox.TabIndex = 53
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAgregarCliente})
        Me.MenuStrip1.Location = New System.Drawing.Point(684, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(175, 78)
        Me.MenuStrip1.TabIndex = 165
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSAgregarCliente
        '
        Me.TSAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TSAgregarCliente.Image = CType(resources.GetObject("TSAgregarCliente.Image"), System.Drawing.Image)
        Me.TSAgregarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSAgregarCliente.Name = "TSAgregarCliente"
        Me.TSAgregarCliente.Size = New System.Drawing.Size(167, 74)
        Me.TSAgregarCliente.Text = "&Agregar Nuevo Cliente"
        Me.TSAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.colorTableAdapter = Nothing
        Me.TableAdapterManager.marcaTableAdapter = Nothing
        Me.TableAdapterManager.metodoPagoTableAdapter = Nothing
        Me.TableAdapterManager.rolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(363, 230)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(543, 179)
        Me.ClienteDataGridView.TabIndex = 165
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nomYape"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nomYape"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nroContacto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nroContacto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "correoElectronico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "correoElectronico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.AgregarBtnLimpiar)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.AgregarDNITextBox)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.AgregarNomYapeTextBox)
        Me.GroupBox3.Controls.Add(Me.AgregarNroContactoTextBox)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.AgregarCorreoElectronicoTextBox)
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Me.AgregarDireccionTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(610, 122)
        Me.GroupBox3.TabIndex = 166
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Nuevo Cliente"
        '
        'AgregarBtnLimpiar
        '
        Me.AgregarBtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarBtnLimpiar.Location = New System.Drawing.Point(485, 85)
        Me.AgregarBtnLimpiar.Name = "AgregarBtnLimpiar"
        Me.AgregarBtnLimpiar.Size = New System.Drawing.Size(108, 24)
        Me.AgregarBtnLimpiar.TabIndex = 1
        Me.AgregarBtnLimpiar.Text = "Limpiar"
        Me.AgregarBtnLimpiar.UseVisualStyleBackColor = True
        '
        'AgregarDNITextBox
        '
        Me.AgregarDNITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarDNITextBox.Location = New System.Drawing.Point(145, 22)
        Me.AgregarDNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarDNITextBox.Name = "AgregarDNITextBox"
        Me.AgregarDNITextBox.Size = New System.Drawing.Size(158, 21)
        Me.AgregarDNITextBox.TabIndex = 1
        '
        'AgregarNomYapeTextBox
        '
        Me.AgregarNomYapeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarNomYapeTextBox.Location = New System.Drawing.Point(145, 45)
        Me.AgregarNomYapeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarNomYapeTextBox.Name = "AgregarNomYapeTextBox"
        Me.AgregarNomYapeTextBox.Size = New System.Drawing.Size(158, 21)
        Me.AgregarNomYapeTextBox.TabIndex = 3
        '
        'AgregarNroContactoTextBox
        '
        Me.AgregarNroContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarNroContactoTextBox.Location = New System.Drawing.Point(145, 68)
        Me.AgregarNroContactoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarNroContactoTextBox.Name = "AgregarNroContactoTextBox"
        Me.AgregarNroContactoTextBox.Size = New System.Drawing.Size(158, 21)
        Me.AgregarNroContactoTextBox.TabIndex = 5
        '
        'AgregarCorreoElectronicoTextBox
        '
        Me.AgregarCorreoElectronicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarCorreoElectronicoTextBox.Location = New System.Drawing.Point(435, 22)
        Me.AgregarCorreoElectronicoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarCorreoElectronicoTextBox.Name = "AgregarCorreoElectronicoTextBox"
        Me.AgregarCorreoElectronicoTextBox.Size = New System.Drawing.Size(158, 21)
        Me.AgregarCorreoElectronicoTextBox.TabIndex = 7
        '
        'AgregarDireccionTextBox
        '
        Me.AgregarDireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarDireccionTextBox.Location = New System.Drawing.Point(435, 45)
        Me.AgregarDireccionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarDireccionTextBox.Name = "AgregarDireccionTextBox"
        Me.AgregarDireccionTextBox.Size = New System.Drawing.Size(158, 21)
        Me.AgregarDireccionTextBox.TabIndex = 9
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 466)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnVolver As Button
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As melodiasDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As melodiasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As BindingNavigator
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
    Friend WithEvents ClienteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnMostrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BuscadorTextBox As TextBox
    Private WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSAgregarCliente As ToolStripMenuItem
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents CorreoElectronicoTextBox As TextBox
    Friend WithEvents NroContactoTextBox As TextBox
    Friend WithEvents NomYapeTextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AgregarDNITextBox As TextBox
    Friend WithEvents AgregarNomYapeTextBox As TextBox
    Friend WithEvents AgregarNroContactoTextBox As TextBox
    Friend WithEvents AgregarCorreoElectronicoTextBox As TextBox
    Friend WithEvents AgregarDireccionTextBox As TextBox
    Friend WithEvents AgregarBtnLimpiar As Button
End Class
