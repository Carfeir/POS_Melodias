<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarProveedor))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DescripTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        DNILabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
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
        DNILabel.Location = New System.Drawing.Point(20, 95)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(84, 15)
        DNILabel.TabIndex = 0
        DNILabel.Text = "Nro. Contacto:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NombresLabel.Location = New System.Drawing.Point(20, 49)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(55, 15)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        ApellidosLabel.Location = New System.Drawing.Point(20, 68)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(111, 15)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Correo Electronico:"
        AddHandler ApellidosLabel.Click, AddressOf Me.ApellidosLabel_Click
        '
        'NroContactoLabel
        '
        NroContactoLabel.AutoSize = True
        NroContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NroContactoLabel.Location = New System.Drawing.Point(20, 118)
        NroContactoLabel.Name = "NroContactoLabel"
        NroContactoLabel.Size = New System.Drawing.Size(62, 15)
        NroContactoLabel.TabIndex = 6
        NroContactoLabel.Text = "Direccion:"
        '
        'CorreoElectronicoLabel
        '
        CorreoElectronicoLabel.AutoSize = True
        CorreoElectronicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        CorreoElectronicoLabel.Location = New System.Drawing.Point(20, 141)
        CorreoElectronicoLabel.Name = "CorreoElectronicoLabel"
        CorreoElectronicoLabel.Size = New System.Drawing.Size(75, 15)
        CorreoElectronicoLabel.TabIndex = 8
        CorreoElectronicoLabel.Text = "Descripcion:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Label1.Location = New System.Drawing.Point(20, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 15)
        Label1.TabIndex = 170
        Label1.Text = "ID Proveedor:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAgregar.Location = New System.Drawing.Point(224, 264)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 31)
        Me.btnAgregar.TabIndex = 162
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(11, 269)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 26)
        Me.btnCancelar.TabIndex = 164
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.DescripTextBox)
        Me.GroupBox1.Controls.Add(Me.ContactoTextBox)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(DNILabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.CorreoTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(NroContactoLabel)
        Me.GroupBox1.Controls.Add(CorreoElectronicoLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(308, 239)
        Me.GroupBox1.TabIndex = 163
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Proveedor"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(129, 21)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(167, 21)
        Me.TextBox1.TabIndex = 169
        '
        'DescripTextBox
        '
        Me.DescripTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DescripTextBox.Location = New System.Drawing.Point(129, 136)
        Me.DescripTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescripTextBox.Multiline = True
        Me.DescripTextBox.Name = "DescripTextBox"
        Me.DescripTextBox.Size = New System.Drawing.Size(167, 65)
        Me.DescripTextBox.TabIndex = 168
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ContactoTextBox.Location = New System.Drawing.Point(129, 90)
        Me.ContactoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.ContactoTextBox.TabIndex = 167
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DireccionTextBox.Location = New System.Drawing.Point(129, 113)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(167, 21)
        Me.DireccionTextBox.TabIndex = 166
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 208)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(302, 27)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(129, 44)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NombreTextBox.TabIndex = 1
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CorreoTextBox.Location = New System.Drawing.Point(129, 68)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.CorreoTextBox.TabIndex = 3
        '
        'ModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(333, 298)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DescripTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
End Class
