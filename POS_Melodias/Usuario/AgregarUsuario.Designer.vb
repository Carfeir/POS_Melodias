<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuario
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
        Dim NombresLabel As System.Windows.Forms.Label
        Dim NroContactoLabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        NombresLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 47)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(95, 12)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre y Apellido:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 93)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(52, 12)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Direccion:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 117)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(97, 12)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Correo Electronico:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label1.Location = New System.Drawing.Point(20, 70)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 12)
        Label1.TabIndex = 185
        Label1.Text = "Nro. Contacto:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label4.Location = New System.Drawing.Point(20, 222)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(115, 12)
        Label4.TabIndex = 196
        Label4.Text = "Confirmar Contraseña:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Miriam", 9.0!)
        Label6.Location = New System.Drawing.Point(20, 199)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(64, 12)
        Label6.TabIndex = 193
        Label6.Text = "Contraseña:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(Me.NroContactoTextBox)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoElectronicoTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(350, 277)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Usuario"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 252)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(344, 21)
        Me.btnLimpiar.TabIndex = 157
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(154, 196)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(167, 20)
        Me.TextBox2.TabIndex = 194
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox3.Location = New System.Drawing.Point(154, 219)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(167, 20)
        Me.TextBox3.TabIndex = 195
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(154, 160)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox2.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 12)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Rol:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 12)
        Me.Label5.TabIndex = 190
        Me.Label5.Text = "Nombre de usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(154, 137)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 187
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 12)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "CUIT:"
        '
        'DNITextBox
        '
        Me.DNITextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(154, 21)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(167, 20)
        Me.DNITextBox.TabIndex = 1
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.NombresTextBox.Location = New System.Drawing.Point(154, 44)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(167, 20)
        Me.NombresTextBox.TabIndex = 3
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.ApellidosTextBox.Location = New System.Drawing.Point(154, 67)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(167, 20)
        Me.ApellidosTextBox.TabIndex = 5
        '
        'NroContactoTextBox
        '
        Me.NroContactoTextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.NroContactoTextBox.Location = New System.Drawing.Point(154, 90)
        Me.NroContactoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NroContactoTextBox.Name = "NroContactoTextBox"
        Me.NroContactoTextBox.Size = New System.Drawing.Size(167, 20)
        Me.NroContactoTextBox.TabIndex = 7
        '
        'CorreoElectronicoTextBox
        '
        Me.CorreoElectronicoTextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.CorreoElectronicoTextBox.Location = New System.Drawing.Point(154, 113)
        Me.CorreoElectronicoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox"
        Me.CorreoElectronicoTextBox.Size = New System.Drawing.Size(167, 20)
        Me.CorreoElectronicoTextBox.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnAgregar.Location = New System.Drawing.Point(269, 303)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 21)
        Me.btnAgregar.TabIndex = 156
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 303)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 21)
        Me.btnCancelar.TabIndex = 158
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 336)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "AgregarUsuario"
        Me.Text = "Agregar Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NroContactoTextBox As TextBox
    Friend WithEvents CorreoElectronicoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
