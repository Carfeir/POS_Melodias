<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NroContactoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NroContactoLabel = New System.Windows.Forms.Label()
        CorreoElectronicoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DNILabel.Location = New System.Drawing.Point(20, 24)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(31, 15)
        DNILabel.TabIndex = 0
        DNILabel.Text = "DNI:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 47)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(61, 15)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        ApellidosLabel.Location = New System.Drawing.Point(20, 70)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(60, 15)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Apellidos:"
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 93)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(84, 15)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Nro. Contacto:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 116)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(111, 15)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Correo Electronico:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(Me.DNITextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(Me.NroContactoTextBox)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoElectronicoTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 171)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Cliente"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 137)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(301, 30)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'DNITextBox
        '
        Me.DNITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DNITextBox.Location = New System.Drawing.Point(128, 17)
        Me.DNITextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(167, 21)
        Me.DNITextBox.TabIndex = 1
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombresTextBox.Location = New System.Drawing.Point(128, 40)
        Me.NombresTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NombresTextBox.TabIndex = 3
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ApellidosTextBox.Location = New System.Drawing.Point(128, 63)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(167, 21)
        Me.ApellidosTextBox.TabIndex = 5
        '
        'NroContactoTextBox
        '
        Me.NroContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NroContactoTextBox.Location = New System.Drawing.Point(128, 86)
        Me.NroContactoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NroContactoTextBox.Name = "NroContactoTextBox"
        Me.NroContactoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NroContactoTextBox.TabIndex = 7
        '
        'CorreoElectronicoTextBox
        '
        Me.CorreoElectronicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CorreoElectronicoTextBox.Location = New System.Drawing.Point(128, 109)
        Me.CorreoElectronicoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CorreoElectronicoTextBox.Name = "CorreoElectronicoTextBox"
        Me.CorreoElectronicoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.CorreoElectronicoTextBox.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 200)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 21)
        Me.btnCancelar.TabIndex = 155
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAgregar.Location = New System.Drawing.Point(226, 200)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 31)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 233)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cliente"
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
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
End Class
