<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdRolComboBox = New System.Windows.Forms.ComboBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
        Me.RolBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUITTextBox = New System.Windows.Forms.TextBox()
        Me.NomYApeTextBox = New System.Windows.Forms.TextBox()
        Me.NroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.CorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BuscadorTextBox = New System.Windows.Forms.TextBox()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.rolTableAdapter()
        Me.UsuarioTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.usuarioTableAdapter()
        Me.TableAdapterManager = New POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AgregarTextBoxContra = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmarContra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AgregarComboBoxRol = New System.Windows.Forms.ComboBox()
        Me.RolBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgregarTextBoxCUIT = New System.Windows.Forms.TextBox()
        Me.AgregarTextBoxNomApe = New System.Windows.Forms.TextBox()
        Me.AgregarTextBoxContacto = New System.Windows.Forms.TextBox()
        Me.AgregarBtnLimpiar = New System.Windows.Forms.Button()
        Me.AgregarTextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AgregarTextBoxNomUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RolBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdRolComboBox)
        Me.GroupBox1.Controls.Add(Me.CUITTextBox)
        Me.GroupBox1.Controls.Add(Me.NomYApeTextBox)
        Me.GroupBox1.Controls.Add(Me.NroContactoTextBox)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.CorreoElectronicoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NombreUsuarioTextBox)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 108)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Usuario"
        '
        'IdRolComboBox
        '
        Me.IdRolComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "IdRol", True))
        Me.IdRolComboBox.DataSource = Me.RolBindingSource2
        Me.IdRolComboBox.DisplayMember = "nombre"
        Me.IdRolComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdRolComboBox.FormattingEnabled = True
        Me.IdRolComboBox.Location = New System.Drawing.Point(465, 76)
        Me.IdRolComboBox.Name = "IdRolComboBox"
        Me.IdRolComboBox.Size = New System.Drawing.Size(155, 23)
        Me.IdRolComboBox.TabIndex = 206
        Me.IdRolComboBox.ValueMember = "IdRol"
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "usuario"
        Me.UsuarioBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RolBindingSource2
        '
        Me.RolBindingSource2.DataMember = "rol"
        Me.RolBindingSource2.DataSource = Me.MelodiasDataSet
        '
        'CUITTextBox
        '
        Me.CUITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "CUIT", True))
        Me.CUITTextBox.Location = New System.Drawing.Point(149, 24)
        Me.CUITTextBox.Name = "CUITTextBox"
        Me.CUITTextBox.ReadOnly = True
        Me.CUITTextBox.Size = New System.Drawing.Size(155, 21)
        Me.CUITTextBox.TabIndex = 197
        '
        'NomYApeTextBox
        '
        Me.NomYApeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nomYApe", True))
        Me.NomYApeTextBox.Location = New System.Drawing.Point(149, 50)
        Me.NomYApeTextBox.Name = "NomYApeTextBox"
        Me.NomYApeTextBox.Size = New System.Drawing.Size(155, 21)
        Me.NomYApeTextBox.TabIndex = 199
        '
        'NroContactoTextBox
        '
        Me.NroContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nroContacto", True))
        Me.NroContactoTextBox.Location = New System.Drawing.Point(149, 76)
        Me.NroContactoTextBox.Name = "NroContactoTextBox"
        Me.NroContactoTextBox.Size = New System.Drawing.Size(155, 21)
        Me.NroContactoTextBox.TabIndex = 201
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(651, 71)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 24)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CorreoElectronicoTextBox
        '
        Me.CorreoElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "correoElectronico", True))
        Me.CorreoElectronicoTextBox.Location = New System.Drawing.Point(465, 24)
        Me.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox"
        Me.CorreoElectronicoTextBox.Size = New System.Drawing.Size(155, 21)
        Me.CorreoElectronicoTextBox.TabIndex = 203
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(339, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Nombre de Usuario:"
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombreUsuario", True))
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(465, 50)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(155, 21)
        Me.NombreUsuarioTextBox.TabIndex = 205
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(651, 24)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 32)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(23, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Nombre y Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(339, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Rol:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(23, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "CUIT:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(23, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Nro. Contacto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(339, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 15)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "Correo Electronico:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnMostrar.Location = New System.Drawing.Point(594, 241)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(169, 45)
        Me.btnMostrar.TabIndex = 159
        Me.btnMostrar.Text = "&Mostrar Usuarios"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnVolver.Location = New System.Drawing.Point(14, 636)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 26)
        Me.btnVolver.TabIndex = 162
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.BuscadorTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 56)
        Me.GroupBox2.TabIndex = 196
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador Por CUIT"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(371, 18)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 23)
        Me.btnLimpiar.TabIndex = 158
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(456, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 31)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BuscadorTextBox
        '
        Me.BuscadorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorTextBox.Location = New System.Drawing.Point(26, 20)
        Me.BuscadorTextBox.Name = "BuscadorTextBox"
        Me.BuscadorTextBox.Size = New System.Drawing.Size(328, 21)
        Me.BuscadorTextBox.TabIndex = 53
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "rol"
        Me.RolBindingSource.DataSource = Me.MelodiasDataSet
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.rolTableAdapter = Me.RolTableAdapter
        Me.TableAdapterManager.UpdateOrder = POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'UsuarioDataGridView
        '
        Me.UsuarioDataGridView.AutoGenerateColumns = False
        Me.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UsuarioDataGridView.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGridView.Location = New System.Drawing.Point(14, 408)
        Me.UsuarioDataGridView.Name = "UsuarioDataGridView"
        Me.UsuarioDataGridView.Size = New System.Drawing.Size(762, 222)
        Me.UsuarioDataGridView.TabIndex = 196
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUIT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUIT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nomYApe"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nomYApe"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nroContacto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nroContacto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "correoElectronico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "correoElectronico"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombreUsuario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nombreUsuario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdRol"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdRol"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(598, 111)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(113, 36)
        Me.BtnAgregar.TabIndex = 200
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AgregarTextBoxContra)
        Me.GroupBox3.Controls.Add(Me.TextBoxConfirmarContra)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.AgregarComboBoxRol)
        Me.GroupBox3.Controls.Add(Me.BtnAgregar)
        Me.GroupBox3.Controls.Add(Me.AgregarTextBoxCUIT)
        Me.GroupBox3.Controls.Add(Me.AgregarTextBoxNomApe)
        Me.GroupBox3.Controls.Add(Me.AgregarTextBoxContacto)
        Me.GroupBox3.Controls.Add(Me.AgregarBtnLimpiar)
        Me.GroupBox3.Controls.Add(Me.AgregarTextBoxCorreo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.AgregarTextBoxNomUsuario)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(762, 191)
        Me.GroupBox3.TabIndex = 201
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Nuevo Usuario"
        '
        'AgregarTextBoxContra
        '
        Me.AgregarTextBoxContra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "CUIT", True))
        Me.AgregarTextBoxContra.Location = New System.Drawing.Point(556, 24)
        Me.AgregarTextBoxContra.Name = "AgregarTextBoxContra"
        Me.AgregarTextBoxContra.Size = New System.Drawing.Size(155, 21)
        Me.AgregarTextBoxContra.TabIndex = 209
        '
        'TextBoxConfirmarContra
        '
        Me.TextBoxConfirmarContra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "correoElectronico", True))
        Me.TextBoxConfirmarContra.Location = New System.Drawing.Point(556, 56)
        Me.TextBoxConfirmarContra.Name = "TextBoxConfirmarContra"
        Me.TextBoxConfirmarContra.Size = New System.Drawing.Size(155, 21)
        Me.TextBoxConfirmarContra.TabIndex = 210
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(406, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 15)
        Me.Label12.TabIndex = 207
        Me.Label12.Text = "Contraseña:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(406, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 15)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "Confirmar Contraseña:"
        '
        'AgregarComboBoxRol
        '
        Me.AgregarComboBoxRol.DataSource = Me.RolBindingSource1
        Me.AgregarComboBoxRol.DisplayMember = "nombre"
        Me.AgregarComboBoxRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarComboBoxRol.FormattingEnabled = True
        Me.AgregarComboBoxRol.Location = New System.Drawing.Point(152, 155)
        Me.AgregarComboBoxRol.Name = "AgregarComboBoxRol"
        Me.AgregarComboBoxRol.Size = New System.Drawing.Size(157, 23)
        Me.AgregarComboBoxRol.TabIndex = 206
        Me.AgregarComboBoxRol.ValueMember = "IdRol"
        '
        'RolBindingSource1
        '
        Me.RolBindingSource1.DataMember = "rol"
        Me.RolBindingSource1.DataSource = Me.MelodiasDataSet
        '
        'AgregarTextBoxCUIT
        '
        Me.AgregarTextBoxCUIT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "CUIT", True))
        Me.AgregarTextBoxCUIT.Location = New System.Drawing.Point(152, 24)
        Me.AgregarTextBoxCUIT.MaxLength = 11
        Me.AgregarTextBoxCUIT.Name = "AgregarTextBoxCUIT"
        Me.AgregarTextBoxCUIT.Size = New System.Drawing.Size(157, 21)
        Me.AgregarTextBoxCUIT.TabIndex = 197
        '
        'AgregarTextBoxNomApe
        '
        Me.AgregarTextBoxNomApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nomYApe", True))
        Me.AgregarTextBoxNomApe.Location = New System.Drawing.Point(152, 50)
        Me.AgregarTextBoxNomApe.Name = "AgregarTextBoxNomApe"
        Me.AgregarTextBoxNomApe.Size = New System.Drawing.Size(157, 21)
        Me.AgregarTextBoxNomApe.TabIndex = 199
        '
        'AgregarTextBoxContacto
        '
        Me.AgregarTextBoxContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nroContacto", True))
        Me.AgregarTextBoxContacto.Location = New System.Drawing.Point(152, 76)
        Me.AgregarTextBoxContacto.Name = "AgregarTextBoxContacto"
        Me.AgregarTextBoxContacto.Size = New System.Drawing.Size(157, 21)
        Me.AgregarTextBoxContacto.TabIndex = 201
        '
        'AgregarBtnLimpiar
        '
        Me.AgregarBtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AgregarBtnLimpiar.Location = New System.Drawing.Point(409, 116)
        Me.AgregarBtnLimpiar.Name = "AgregarBtnLimpiar"
        Me.AgregarBtnLimpiar.Size = New System.Drawing.Size(93, 24)
        Me.AgregarBtnLimpiar.TabIndex = 3
        Me.AgregarBtnLimpiar.Text = "Limpiar"
        Me.AgregarBtnLimpiar.UseVisualStyleBackColor = True
        '
        'AgregarTextBoxCorreo
        '
        Me.AgregarTextBoxCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "correoElectronico", True))
        Me.AgregarTextBoxCorreo.Location = New System.Drawing.Point(152, 103)
        Me.AgregarTextBoxCorreo.Name = "AgregarTextBoxCorreo"
        Me.AgregarTextBoxCorreo.Size = New System.Drawing.Size(157, 21)
        Me.AgregarTextBoxCorreo.TabIndex = 203
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 15)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "Nombre de Usuario:"
        '
        'AgregarTextBoxNomUsuario
        '
        Me.AgregarTextBoxNomUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "nombreUsuario", True))
        Me.AgregarTextBoxNomUsuario.Location = New System.Drawing.Point(152, 129)
        Me.AgregarTextBoxNomUsuario.Name = "AgregarTextBoxNomUsuario"
        Me.AgregarTextBoxNomUsuario.Size = New System.Drawing.Size(157, 21)
        Me.AgregarTextBoxNomUsuario.TabIndex = 205
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(23, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 15)
        Me.Label5.TabIndex = 183
        Me.Label5.Text = "Nombre y Apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(23, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Rol:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(23, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "CUIT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(23, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Nro. Contacto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(23, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 15)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "Correo Electronico:"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 669)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.UsuarioDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.RolBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Private WithEvents btnVolver As Button
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BuscadorTextBox As TextBox
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As melodiasDataSetTableAdapters.rolTableAdapter
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As melodiasDataSetTableAdapters.usuarioTableAdapter
    Friend WithEvents TableAdapterManager As melodiasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUITTextBox As TextBox
    Friend WithEvents NomYApeTextBox As TextBox
    Friend WithEvents NroContactoTextBox As TextBox
    Friend WithEvents CorreoElectronicoTextBox As TextBox
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents UsuarioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents IdRolComboBox As ComboBox
    Friend WithEvents RolBindingSource2 As BindingSource
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AgregarComboBoxRol As ComboBox
    Friend WithEvents RolBindingSource1 As BindingSource
    Friend WithEvents AgregarTextBoxCUIT As TextBox
    Friend WithEvents AgregarTextBoxNomApe As TextBox
    Friend WithEvents AgregarTextBoxContacto As TextBox
    Friend WithEvents AgregarBtnLimpiar As Button
    Friend WithEvents AgregarTextBoxCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AgregarTextBoxNomUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents AgregarTextBoxContra As TextBox
    Friend WithEvents TextBoxConfirmarContra As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
End Class
