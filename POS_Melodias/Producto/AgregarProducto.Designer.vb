<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarProducto
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
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NroContactoLabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarProducto))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelodiasDataSet = New POS_Melodias.melodiasDataSet()
        Me.CantidadNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PrecioUTextBox = New System.Windows.Forms.TextBox()
        Me.ColorComboBox = New System.Windows.Forms.ComboBox()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTableAdapter = New POS_Melodias.melodiasDataSetTableAdapters.categoriaTableAdapter()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DNILabel.Location = New System.Drawing.Point(20, 33)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(66, 15)
        DNILabel.TabIndex = 0
        DNILabel.Text = "Proveedor:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 57)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(55, 15)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        ApellidosLabel.Location = New System.Drawing.Point(20, 81)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(63, 15)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Categoria:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 107)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(45, 15)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Marca:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 133)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(39, 15)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Color:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label1.Location = New System.Drawing.Point(20, 159)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 15)
        Label1.TabIndex = 162
        Label1.Text = "Precio U:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label2.Location = New System.Drawing.Point(20, 182)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 15)
        Label2.TabIndex = 164
        Label2.Text = "Cantidad:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAgregar.Location = New System.Drawing.Point(197, 253)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 24)
        Me.btnAgregar.TabIndex = 156
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 253)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 24)
        Me.btnCancelar.TabIndex = 158
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProveedorComboBox)
        Me.GroupBox1.Controls.Add(Me.CantidadNumericUpDown)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.PrecioUTextBox)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.ColorComboBox)
        Me.GroupBox1.Controls.Add(Me.MarcaComboBox)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(278, 233)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'ProveedorComboBox
        '
        Me.ProveedorComboBox.DataSource = Me.ProveedorBindingSource
        Me.ProveedorComboBox.DisplayMember = "nombre"
        Me.ProveedorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ProveedorComboBox.FormattingEnabled = True
        Me.ProveedorComboBox.Location = New System.Drawing.Point(93, 24)
        Me.ProveedorComboBox.Name = "ProveedorComboBox"
        Me.ProveedorComboBox.Size = New System.Drawing.Size(167, 23)
        Me.ProveedorComboBox.TabIndex = 165
        Me.ProveedorComboBox.Text = "Seleccionar"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MelodiasDataSet
        '
        Me.MelodiasDataSet.DataSetName = "melodiasDataSet"
        Me.MelodiasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CantidadNumericUpDown
        '
        Me.CantidadNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CantidadNumericUpDown.Location = New System.Drawing.Point(93, 177)
        Me.CantidadNumericUpDown.Name = "CantidadNumericUpDown"
        Me.CantidadNumericUpDown.Size = New System.Drawing.Size(167, 21)
        Me.CantidadNumericUpDown.TabIndex = 159
        '
        'PrecioUTextBox
        '
        Me.PrecioUTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.PrecioUTextBox.Location = New System.Drawing.Point(93, 152)
        Me.PrecioUTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrecioUTextBox.Name = "PrecioUTextBox"
        Me.PrecioUTextBox.Size = New System.Drawing.Size(167, 21)
        Me.PrecioUTextBox.TabIndex = 163
        '
        'ColorComboBox
        '
        Me.ColorComboBox.DataSource = Me.ColorBindingSource
        Me.ColorComboBox.DisplayMember = "nombre"
        Me.ColorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ColorComboBox.FormattingEnabled = True
        Me.ColorComboBox.Location = New System.Drawing.Point(93, 126)
        Me.ColorComboBox.Name = "ColorComboBox"
        Me.ColorComboBox.Size = New System.Drawing.Size(167, 23)
        Me.ColorComboBox.TabIndex = 161
        Me.ColorComboBox.Text = "Seleccionar"
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataMember = "color"
        Me.ColorBindingSource.DataSource = Me.MelodiasDataSet
        '
        'MarcaComboBox
        '
        Me.MarcaComboBox.DataSource = Me.MarcaBindingSource
        Me.MarcaComboBox.DisplayMember = "nombre"
        Me.MarcaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.MarcaComboBox.FormattingEnabled = True
        Me.MarcaComboBox.Location = New System.Drawing.Point(93, 100)
        Me.MarcaComboBox.Name = "MarcaComboBox"
        Me.MarcaComboBox.Size = New System.Drawing.Size(167, 23)
        Me.MarcaComboBox.TabIndex = 160
        Me.MarcaComboBox.Text = "Seleccionar"
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "marca"
        Me.MarcaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataSource = Me.CategoriaBindingSource
        Me.CategoriaComboBox.DisplayMember = "nombre"
        Me.CategoriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(93, 74)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(167, 23)
        Me.CategoriaComboBox.TabIndex = 159
        Me.CategoriaComboBox.Text = "Seleccionar"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.MelodiasDataSet
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 205)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(272, 24)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(93, 50)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NombreTextBox.TabIndex = 3
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(302, 289)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MelodiasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents ColorComboBox As ComboBox
    Friend WithEvents MarcaComboBox As ComboBox
    Friend WithEvents PrecioUTextBox As TextBox
    Friend WithEvents CantidadNumericUpDown As NumericUpDown
    Friend WithEvents MelodiasDataSet As melodiasDataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As melodiasDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents MarcaBindingSource As BindingSource
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ProveedorComboBox As ComboBox
    Friend WithEvents ProveedorBindingSource As BindingSource
End Class
