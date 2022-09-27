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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ProductID, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 302)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 146)
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
        Me.ColumnHeader5.Width = 69
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cantidad"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 64
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 55)
        Me.GroupBox2.TabIndex = 146
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(443, 20)
        Me.TextBox1.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 199)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 12)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "ID Producto"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(155, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(185, 20)
        Me.TextBox2.TabIndex = 178
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(381, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 18)
        Me.Button4.TabIndex = 180
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(411, 131)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(89, 20)
        Me.ComboBox3.TabIndex = 177
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(155, 131)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(94, 20)
        Me.ComboBox2.TabIndex = 176
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 20)
        Me.ComboBox1.TabIndex = 175
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalAmount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalAmount.Location = New System.Drawing.Point(155, 164)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(94, 20)
        Me.txtTotalAmount.TabIndex = 174
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(295, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Marca"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(23, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 12)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "ID Proveedor"
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProductCode.Location = New System.Drawing.Point(154, 22)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(185, 20)
        Me.txtProductCode.TabIndex = 160
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(22, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 12)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "Nombre"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProductName.Location = New System.Drawing.Point(155, 74)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(366, 20)
        Me.txtProductName.TabIndex = 161
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 18)
        Me.Button1.TabIndex = 170
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(22, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 12)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Categoria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(295, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 12)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Precio Unitario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(22, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 12)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "Color"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrice.Location = New System.Drawing.Point(411, 101)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(89, 20)
        Me.txtPrice.TabIndex = 163
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(22, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 12)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Cantidad"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(534, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 55)
        Me.GroupBox3.TabIndex = 149
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(18, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 26)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "&Obtener Datos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(136, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 26)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "&Reiniciar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NewRecord)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Save)
        Me.Panel1.Controls.Add(Me.Update_Record)
        Me.Panel1.Location = New System.Drawing.Point(622, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 159)
        Me.Panel1.TabIndex = 154
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.NewRecord.Location = New System.Drawing.Point(14, 14)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(93, 25)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&Nuevo"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.Delete.Location = New System.Drawing.Point(14, 112)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(93, 25)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "&Eliminar"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Miriam", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Save.Location = New System.Drawing.Point(14, 48)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(93, 25)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Guardar"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Update_Record
        '
        Me.Update_Record.Enabled = False
        Me.Update_Record.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.Update_Record.Location = New System.Drawing.Point(14, 80)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(93, 25)
        Me.Update_Record.TabIndex = 2
        Me.Update_Record.Text = "&Actualizar"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Proveedor"
        Me.ColumnHeader8.Width = 102
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.Name = "Products"
        Me.Text = "Producto"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NewRecord As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Save As Button
    Friend WithEvents Update_Record As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
