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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnModificar.Location = New System.Drawing.Point(252, 235)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(104, 21)
        Me.btnModificar.TabIndex = 160
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(13, 235)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 21)
        Me.btnCancelar.TabIndex = 163
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCambiarContraseña)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(Me.NroContactoTextBox)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoElectronicoTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(343, 204)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Usuario"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        DNILabel.Location = New System.Drawing.Point(18, 24)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(34, 12)
        DNILabel.TabIndex = 0
        DNILabel.Text = "CUIT:"
        '
        'DNITextBox
        '
        Me.DNITextBox.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(154, 21)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.ReadOnly = True
        Me.DNITextBox.Size = New System.Drawing.Size(167, 20)
        Me.DNITextBox.TabIndex = 1
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(18, 47)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(95, 12)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre y Apellido:"
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
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(18, 70)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(75, 12)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Nro. Contacto:"
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
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Miriam", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(18, 93)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(97, 12)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Correo Electronico:"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 12)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Nombre de Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 12)
        Me.Label6.TabIndex = 188
        Me.Label6.Text = "Rol:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 20)
        Me.ComboBox1.TabIndex = 190
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(13, 172)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(143, 21)
        Me.btnCambiarContraseña.TabIndex = 192
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Miriam", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(228, 172)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(93, 21)
        Me.btnLimpiar.TabIndex = 191
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(368, 268)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.Name = "ModificarUsuario"
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
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NroContactoTextBox As TextBox
    Friend WithEvents CorreoElectronicoTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
