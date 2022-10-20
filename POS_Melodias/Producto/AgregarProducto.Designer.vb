<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Dim DNILabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NroContactoLabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnAgregar.Location = New System.Drawing.Point(197, 248)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 21)
        Me.btnAgregar.TabIndex = 156
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 248)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 21)
        Me.btnCancelar.TabIndex = 158
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(278, 219)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Producto"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 194)
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
        DNILabel.Size = New System.Drawing.Size(58, 12)
        DNILabel.TabIndex = 0
        DNILabel.Text = "Proveedor:"
        '
        'DNITextBox
        '
        Me.DNITextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(93, 21)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(167, 20)
        Me.DNITextBox.TabIndex = 1
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 47)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(47, 12)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.NombresTextBox.Location = New System.Drawing.Point(93, 44)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(167, 20)
        Me.NombresTextBox.TabIndex = 3
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        ApellidosLabel.Location = New System.Drawing.Point(20, 69)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(55, 12)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Categoria:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 93)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(38, 12)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Marca:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 116)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(34, 12)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Color:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox1.TabIndex = 159
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(93, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox2.TabIndex = 160
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(93, 113)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox3.TabIndex = 161
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label1.Location = New System.Drawing.Point(20, 140)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 12)
        Label1.TabIndex = 162
        Label1.Text = "Precio U:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(93, 137)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 163
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label2.Location = New System.Drawing.Point(20, 164)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 12)
        Label2.TabIndex = 164
        Label2.Text = "Cantidad:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(93, 161)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(167, 20)
        Me.TextBox2.TabIndex = 165
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(302, 281)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.Name = "AgregarProducto"
        Me.Text = "Agregar Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
