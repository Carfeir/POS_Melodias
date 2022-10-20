<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProducto
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NroContactoLabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(197, 262)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 21)
        Me.btnModificar.TabIndex = 159
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 262)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 21)
        Me.btnCancelar.TabIndex = 161
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(278, 237)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label1.Location = New System.Drawing.Point(20, 160)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 12)
        Label1.TabIndex = 162
        Label1.Text = "Precio U:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(93, 157)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 163
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label2.Location = New System.Drawing.Point(20, 184)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 12)
        Label2.TabIndex = 164
        Label2.Text = "Cantidad:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(93, 181)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(167, 20)
        Me.TextBox2.TabIndex = 165
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(93, 133)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox3.TabIndex = 161
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(93, 110)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox2.TabIndex = 160
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox1.TabIndex = 159
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 212)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(272, 21)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        DNILabel.Location = New System.Drawing.Point(20, 24)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(65, 12)
        DNILabel.TabIndex = 0
        DNILabel.Text = "ID Producto:"
        '
        'DNITextBox
        '
        Me.DNITextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(93, 41)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(167, 20)
        Me.DNITextBox.TabIndex = 1
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 67)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(47, 12)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.NombresTextBox.Location = New System.Drawing.Point(93, 64)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(167, 20)
        Me.NombresTextBox.TabIndex = 3
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        ApellidosLabel.Location = New System.Drawing.Point(20, 89)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(55, 12)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Categoria:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 113)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(38, 12)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Marca:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 136)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(34, 12)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Color:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label3.Location = New System.Drawing.Point(20, 44)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(58, 12)
        Label3.TabIndex = 166
        Label3.Text = "Proveedor:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox3.Location = New System.Drawing.Point(93, 18)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(167, 20)
        Me.TextBox3.TabIndex = 167
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(302, 295)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.Name = "ModificarProducto"
        Me.Text = "Modificar Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
End Class
