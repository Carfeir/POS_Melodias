<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Back_up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Back_up))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRutaGuardar = New System.Windows.Forms.TextBox()
        Me.btnRutaGuardar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(23, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 22)
        Me.Button2.TabIndex = 148
        Me.Button2.Text = "&Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Ruta guardar:"
        '
        'txtRutaGuardar
        '
        Me.txtRutaGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRutaGuardar.Location = New System.Drawing.Point(119, 119)
        Me.txtRutaGuardar.Name = "txtRutaGuardar"
        Me.txtRutaGuardar.Size = New System.Drawing.Size(252, 26)
        Me.txtRutaGuardar.TabIndex = 155
        '
        'btnRutaGuardar
        '
        Me.btnRutaGuardar.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.btnRutaGuardar.Image = CType(resources.GetObject("btnRutaGuardar.Image"), System.Drawing.Image)
        Me.btnRutaGuardar.Location = New System.Drawing.Point(377, 119)
        Me.btnRutaGuardar.Name = "btnRutaGuardar"
        Me.btnRutaGuardar.Size = New System.Drawing.Size(64, 26)
        Me.btnRutaGuardar.TabIndex = 154
        Me.btnRutaGuardar.Text = "Ruta"
        Me.btnRutaGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRutaGuardar.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Font = New System.Drawing.Font("Miriam", 8.25!)
        Me.btnConectar.Location = New System.Drawing.Point(330, 77)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(111, 28)
        Me.btnConectar.TabIndex = 152
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(119, 77)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(205, 28)
        Me.cboBaseDatos.TabIndex = 150
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Miriam", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(338, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 28)
        Me.Button1.TabIndex = 157
        Me.Button1.Text = "&Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miriam", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 12)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Base de Datos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Backup"
        '
        'Back_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 216)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRutaGuardar)
        Me.Controls.Add(Me.btnRutaGuardar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.cboBaseDatos)
        Me.Controls.Add(Me.Button2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Back_up"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRutaGuardar As TextBox
    Friend WithEvents btnRutaGuardar As Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
