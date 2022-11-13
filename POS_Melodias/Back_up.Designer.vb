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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(42, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 53)
        Me.Button2.TabIndex = 148
        Me.Button2.Text = "&Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Ruta guardar"
        '
        'txtRutaGuardar
        '
        Me.txtRutaGuardar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaGuardar.Location = New System.Drawing.Point(137, 58)
        Me.txtRutaGuardar.Name = "txtRutaGuardar"
        Me.txtRutaGuardar.Size = New System.Drawing.Size(453, 26)
        Me.txtRutaGuardar.TabIndex = 155
        '
        'btnRutaGuardar
        '
        Me.btnRutaGuardar.Image = CType(resources.GetObject("btnRutaGuardar.Image"), System.Drawing.Image)
        Me.btnRutaGuardar.Location = New System.Drawing.Point(596, 58)
        Me.btnRutaGuardar.Name = "btnRutaGuardar"
        Me.btnRutaGuardar.Size = New System.Drawing.Size(103, 26)
        Me.btnRutaGuardar.TabIndex = 154
        Me.btnRutaGuardar.Text = "Ruta"
        Me.btnRutaGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRutaGuardar.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(361, 24)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(132, 28)
        Me.btnConectar.TabIndex = 152
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Base de datos"
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(136, 24)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(219, 28)
        Me.cboBaseDatos.TabIndex = 150
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(596, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 46)
        Me.Button1.TabIndex = 157
        Me.Button1.Text = "&Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Back_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 211)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRutaGuardar)
        Me.Controls.Add(Me.btnRutaGuardar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
