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
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.OldPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserName
        '
        Me.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.UserName.Location = New System.Drawing.Point(195, 35)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(122, 20)
        Me.UserName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(56, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 12)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre de Usuario"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(128, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 38)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Cambiar Contraseña"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(56, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Confirmar Contraseña"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(195, 160)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(122, 20)
        Me.ConfirmPassword.TabIndex = 14
        '
        'NewPassword
        '
        Me.NewPassword.Location = New System.Drawing.Point(195, 117)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.Size = New System.Drawing.Size(122, 20)
        Me.NewPassword.TabIndex = 13
        '
        'OldPassword
        '
        Me.OldPassword.Location = New System.Drawing.Point(195, 75)
        Me.OldPassword.Name = "OldPassword"
        Me.OldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPassword.Size = New System.Drawing.Size(122, 20)
        Me.OldPassword.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(56, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contraseña Nueva"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Contraseña Vieja"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 268)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.OldPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChangePassword"
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfirmPassword As TextBox
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents OldPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
