﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUp
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
        Me.SuspendLayout()
        '
        'UserName
        '
        Me.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.UserName.Location = New System.Drawing.Point(200, 83)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(122, 20)
        Me.UserName.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(61, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 12)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nombre de Backup"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(139, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 32)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "&Back up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 227)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BackUp"
        Me.Text = "Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
