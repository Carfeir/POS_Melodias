<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rols
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rols))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BuscadorTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.AgregarNombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
        Me.IdRolTextBox = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.RolBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RolBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RolDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.rolTableAdapter()
        Me.TableAdapterManager = New POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RolBindingNavigator.SuspendLayout()
        CType(Me.RolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.BuscadorTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 46)
        Me.GroupBox2.TabIndex = 199
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador Por Nombre"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(305, 16)
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
        Me.btnBuscar.Location = New System.Drawing.Point(390, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 27)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BuscadorTextBox
        '
        Me.BuscadorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorTextBox.Location = New System.Drawing.Point(13, 16)
        Me.BuscadorTextBox.Name = "BuscadorTextBox"
        Me.BuscadorTextBox.Size = New System.Drawing.Size(274, 21)
        Me.BuscadorTextBox.TabIndex = 53
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.AgregarNombreTextBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(234, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(279, 69)
        Me.GroupBox3.TabIndex = 198
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Nueva Rol"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(199, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 34)
        Me.btnAgregar.TabIndex = 163
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'AgregarNombreTextBox
        '
        Me.AgregarNombreTextBox.BackColor = System.Drawing.Color.White
        Me.AgregarNombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AgregarNombreTextBox.Location = New System.Drawing.Point(71, 30)
        Me.AgregarNombreTextBox.Name = "AgregarNombreTextBox"
        Me.AgregarNombreTextBox.Size = New System.Drawing.Size(115, 21)
        Me.AgregarNombreTextBox.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.IdRolTextBox)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 111)
        Me.GroupBox1.TabIndex = 197
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Rol"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RolBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(68, 51)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(117, 21)
        Me.NombreTextBox.TabIndex = 204
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "rol"
        Me.RolBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdRolTextBox
        '
        Me.IdRolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RolBindingSource, "IdRol", True))
        Me.IdRolTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.IdRolTextBox.Location = New System.Drawing.Point(68, 25)
        Me.IdRolTextBox.Name = "IdRolTextBox"
        Me.IdRolTextBox.ReadOnly = True
        Me.IdRolTextBox.Size = New System.Drawing.Size(117, 21)
        Me.IdRolTextBox.TabIndex = 203
        '
        'btnEliminar
        '
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(3, 86)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(192, 22)
        Me.btnEliminar.TabIndex = 163
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "ID:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnVolver.Location = New System.Drawing.Point(12, 297)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 28)
        Me.btnVolver.TabIndex = 196
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnMostrar.Location = New System.Drawing.Point(234, 92)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(279, 29)
        Me.btnMostrar.TabIndex = 195
        Me.btnMostrar.Text = "&Mostrar Roles"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'RolBindingNavigator
        '
        Me.RolBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RolBindingNavigator.BindingSource = Me.RolBindingSource
        Me.RolBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RolBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RolBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RolBindingNavigatorSaveItem})
        Me.RolBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RolBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RolBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RolBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RolBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RolBindingNavigator.Name = "RolBindingNavigator"
        Me.RolBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RolBindingNavigator.Size = New System.Drawing.Size(533, 25)
        Me.RolBindingNavigator.TabIndex = 200
        Me.RolBindingNavigator.Text = "BindingNavigator1"
        Me.RolBindingNavigator.Visible = False
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
        'RolBindingNavigatorSaveItem
        '
        Me.RolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RolBindingNavigatorSaveItem.Image = CType(resources.GetObject("RolBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RolBindingNavigatorSaveItem.Name = "RolBindingNavigatorSaveItem"
        Me.RolBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RolBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RolDataGridView
        '
        Me.RolDataGridView.AutoGenerateColumns = False
        Me.RolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RolDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.RolDataGridView.DataSource = Me.RolBindingSource
        Me.RolDataGridView.Location = New System.Drawing.Point(12, 179)
        Me.RolDataGridView.Name = "RolDataGridView"
        Me.RolDataGridView.Size = New System.Drawing.Size(501, 109)
        Me.RolDataGridView.TabIndex = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdRol"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdRol"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.colorTableAdapter = Nothing
        Me.TableAdapterManager.marcaTableAdapter = Nothing
        Me.TableAdapterManager.metodoPagoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.rolTableAdapter = Me.RolTableAdapter
        Me.TableAdapterManager.UpdateOrder = POS_Melodias.melodiasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'Rols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 337)
        Me.Controls.Add(Me.RolDataGridView)
        Me.Controls.Add(Me.RolBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnMostrar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rols"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rol"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RolBindingNavigator.ResumeLayout(False)
        Me.RolBindingNavigator.PerformLayout()
        CType(Me.RolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BuscadorTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents AgregarNombreTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents btnVolver As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As melodiasDataSetTableAdapters.rolTableAdapter
    Friend WithEvents TableAdapterManager As melodiasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RolBindingNavigator As BindingNavigator
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
    Friend WithEvents RolBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdRolTextBox As TextBox
    Friend WithEvents RolDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreTextBox As TextBox
End Class
