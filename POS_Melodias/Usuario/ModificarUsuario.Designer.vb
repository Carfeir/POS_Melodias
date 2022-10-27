<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuario
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
        Dim NroContactoLabel As System.Windows.Forms.Label
        Dim CorreoElectronicoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarUsuario))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.NUsuarioTextBox = New System.Windows.Forms.TextBox()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DNILabel.Location = New System.Drawing.Point(18, 24)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(37, 15)
        DNILabel.TabIndex = 0
        DNILabel.Text = "CUIT:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(18, 47)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(110, 15)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre y Apellido:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(18, 70)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(84, 15)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Nro. Contacto:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(18, 114)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(111, 15)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Correo Electronico:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label1.Location = New System.Drawing.Point(18, 92)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 15)
        Label1.TabIndex = 193
        Label1.Text = "Direccion:"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(207, 273)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(104, 21)
        Me.btnModificar.TabIndex = 160
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 21)
        Me.btnCancelar.TabIndex = 163
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(Me.btnCambiarContraseña)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.ComboBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Me.ContactoTextBox)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextBox)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Controls.Add(Me.NUsuarioTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(316, 221)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Usuario"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DireccionTextBox.Location = New System.Drawing.Point(149, 87)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(167, 21)
        Me.DireccionTextBox.TabIndex = 194
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(6, 193)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(143, 21)
        Me.btnCambiarContraseña.TabIndex = 192
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(205, 191)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(93, 25)
        Me.btnLimpiar.TabIndex = 191
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ComboBox
        '
        Me.ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(149, 156)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(167, 23)
        Me.ComboBox.TabIndex = 190
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 15)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Nombre de Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 188
        Me.Label6.Text = "Rol:"
        '
        'DNITextBox
        '
        Me.DNITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(149, 18)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.ReadOnly = True
        Me.DNITextBox.Size = New System.Drawing.Size(167, 21)
        Me.DNITextBox.TabIndex = 1
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombresTextBox.Location = New System.Drawing.Point(149, 41)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NombresTextBox.TabIndex = 3
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ContactoTextBox.Location = New System.Drawing.Point(149, 64)
        Me.ContactoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.ContactoTextBox.TabIndex = 5
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CorreoTextBox.Location = New System.Drawing.Point(149, 109)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.CorreoTextBox.TabIndex = 7
        '
        'NUsuarioTextBox
        '
        Me.NUsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NUsuarioTextBox.Location = New System.Drawing.Point(149, 132)
        Me.NUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NUsuarioTextBox.Name = "NUsuarioTextBox"
        Me.NUsuarioTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NUsuarioTextBox.TabIndex = 9
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 306)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents NUsuarioTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents DireccionTextBox As TextBox
End Class
