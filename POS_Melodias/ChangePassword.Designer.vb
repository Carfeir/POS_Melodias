<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.TextBoxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCambiarContraseña = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxNombreUsuario
        '
        Me.TextBoxNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBoxNombreUsuario.Location = New System.Drawing.Point(155, 67)
        Me.TextBoxNombreUsuario.Name = "TextBoxNombreUsuario"
        Me.TextBoxNombreUsuario.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxNombreUsuario.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(17, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 12)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre de Usuario:"
        '
        'BtnCambiarContraseña
        '
        Me.BtnCambiarContraseña.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCambiarContraseña.Location = New System.Drawing.Point(135, 212)
        Me.BtnCambiarContraseña.Name = "BtnCambiarContraseña"
        Me.BtnCambiarContraseña.Size = New System.Drawing.Size(142, 32)
        Me.BtnCambiarContraseña.TabIndex = 15
        Me.BtnCambiarContraseña.Text = "&Cambiar Contraseña"
        Me.BtnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Confirmar Contraseña:"
        '
        'TextBoxConfirmarContraseña
        '
        Me.TextBoxConfirmarContraseña.Location = New System.Drawing.Point(155, 164)
        Me.TextBoxConfirmarContraseña.Name = "TextBoxConfirmarContraseña"
        Me.TextBoxConfirmarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmarContraseña.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxConfirmarContraseña.TabIndex = 14
        '
        'TextBoxNuevaContraseña
        '
        Me.TextBoxNuevaContraseña.Location = New System.Drawing.Point(155, 138)
        Me.TextBoxNuevaContraseña.Name = "TextBoxNuevaContraseña"
        Me.TextBoxNuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNuevaContraseña.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxNuevaContraseña.TabIndex = 13
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Location = New System.Drawing.Point(155, 92)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContraseña.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxContraseña.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contraseña Nueva:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(17, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Contraseña:"
        '
        'BtnVolver
        '
        Me.BtnVolver.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.BtnVolver.Location = New System.Drawing.Point(19, 218)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(79, 26)
        Me.BtnVolver.TabIndex = 148
        Me.BtnVolver.Text = "&Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Miriam", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 21)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Cambiar Contraseña"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(303, 256)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.TextBoxNombreUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCambiarContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxConfirmarContraseña)
        Me.Controls.Add(Me.TextBoxNuevaContraseña)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNombreUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCambiarContraseña As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxConfirmarContraseña As TextBox
    Friend WithEvents TextBoxNuevaContraseña As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents BtnVolver As Button
    Friend WithEvents Label5 As Label
End Class
