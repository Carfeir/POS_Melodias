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
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BuscadorTextBox = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.TSAgregarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label2.Location = New System.Drawing.Point(24, 23)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 12)
        Label2.TabIndex = 54
        Label2.Text = "Nombre:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ProductID, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 256)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 124)
        Me.ListView1.TabIndex = 145
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ProductID
        '
        Me.ProductID.Text = "ID"
        Me.ProductID.Width = 38
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Proveedor"
        Me.ColumnHeader8.Width = 102
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 212
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categoria"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Precio U"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Color"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 88
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Marca"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 65
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cantidad"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 64
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 178)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox5.Location = New System.Drawing.Point(99, 91)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(139, 20)
        Me.TextBox5.TabIndex = 182
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(26, 150)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 21)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(414, 150)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 21)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox4.Location = New System.Drawing.Point(369, 91)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(138, 20)
        Me.TextBox4.TabIndex = 181
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox3.Location = New System.Drawing.Point(99, 65)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(139, 20)
        Me.TextBox3.TabIndex = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(296, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "ID Producto:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(369, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 178
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalAmount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalAmount.Location = New System.Drawing.Point(99, 117)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(139, 20)
        Me.txtTotalAmount.TabIndex = 174
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(296, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 12)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Marca:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(24, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 12)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Proveedor:"
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProductCode.Location = New System.Drawing.Point(99, 17)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(139, 20)
        Me.txtProductCode.TabIndex = 160
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(24, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "Nombre:"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.SystemColors.Control
        Me.txtProductName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProductName.Location = New System.Drawing.Point(99, 41)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(408, 20)
        Me.txtProductName.TabIndex = 161
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(24, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 12)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Categoria:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(296, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 12)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Precio U:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(24, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 12)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "Color:"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrice.Location = New System.Drawing.Point(369, 65)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(138, 20)
        Me.txtPrice.TabIndex = 163
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(24, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 12)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Cantidad:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.BuscadorTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 47)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(577, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 19)
        Me.btnLimpiar.TabIndex = 158
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(662, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 29)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BuscadorTextBox
        '
        Me.BuscadorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BuscadorTextBox.Location = New System.Drawing.Point(77, 17)
        Me.BuscadorTextBox.Name = "BuscadorTextBox"
        Me.BuscadorTextBox.Size = New System.Drawing.Size(467, 21)
        Me.BuscadorTextBox.TabIndex = 53
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.btnVolver.Location = New System.Drawing.Point(12, 392)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 19)
        Me.btnVolver.TabIndex = 172
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'TSAgregarCliente
        '
        Me.TSAgregarCliente.Font = New System.Drawing.Font("Miriam", 11.25!)
        Me.TSAgregarCliente.Image = CType(resources.GetObject("TSAgregarCliente.Image"), System.Drawing.Image)
        Me.TSAgregarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSAgregarCliente.Name = "TSAgregarCliente"
        Me.TSAgregarCliente.Size = New System.Drawing.Size(173, 71)
        Me.TSAgregarCliente.Text = "&Agregar Nuevo Producto"
        Me.TSAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAgregarCliente})
        Me.MenuStrip1.Location = New System.Drawing.Point(589, 74)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(181, 75)
        Me.MenuStrip1.TabIndex = 174
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnMostrar.Location = New System.Drawing.Point(589, 162)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(181, 25)
        Me.btnMostrar.TabIndex = 173
        Me.btnMostrar.Text = "&Mostrar Productos"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BuscadorTextBox As TextBox
    Private WithEvents btnVolver As Button
    Friend WithEvents TSAgregarCliente As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnMostrar As Button
End Class
