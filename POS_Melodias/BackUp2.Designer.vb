<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUp2
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDirectorio = New System.Windows.Forms.TextBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExaminarRecuperar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.TextBoxDirectorioRecuperar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(12, 227)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(83, 22)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExaminar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBackup)
        Me.GroupBox1.Controls.Add(Me.TextBoxDirectorio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 96)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Backup"
        '
        'btnExaminar
        '
        Me.btnExaminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExaminar.Location = New System.Drawing.Point(517, 31)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(58, 23)
        Me.btnExaminar.TabIndex = 21
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Directorio:"
        '
        'TextBoxDirectorio
        '
        Me.TextBoxDirectorio.Enabled = False
        Me.TextBoxDirectorio.Location = New System.Drawing.Point(105, 34)
        Me.TextBoxDirectorio.Name = "TextBoxDirectorio"
        Me.TextBoxDirectorio.Size = New System.Drawing.Size(406, 20)
        Me.TextBoxDirectorio.TabIndex = 25
        '
        'btnBackup
        '
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackup.Location = New System.Drawing.Point(517, 59)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(83, 22)
        Me.btnBackup.TabIndex = 32
        Me.btnBackup.Text = "Crear Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExaminarRecuperar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnRecuperar)
        Me.GroupBox2.Controls.Add(Me.TextBoxDirectorioRecuperar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(614, 96)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recuperar Backup"
        '
        'btnExaminarRecuperar
        '
        Me.btnExaminarRecuperar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExaminarRecuperar.Location = New System.Drawing.Point(517, 31)
        Me.btnExaminarRecuperar.Name = "btnExaminarRecuperar"
        Me.btnExaminarRecuperar.Size = New System.Drawing.Size(58, 23)
        Me.btnExaminarRecuperar.TabIndex = 21
        Me.btnExaminarRecuperar.Text = "Examinar"
        Me.btnExaminarRecuperar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Directorio:"
        '
        'btnRecuperar
        '
        Me.btnRecuperar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRecuperar.Location = New System.Drawing.Point(517, 59)
        Me.btnRecuperar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(83, 22)
        Me.btnRecuperar.TabIndex = 32
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'TextBoxDirectorioRecuperar
        '
        Me.TextBoxDirectorioRecuperar.Enabled = False
        Me.TextBoxDirectorioRecuperar.Location = New System.Drawing.Point(105, 34)
        Me.TextBoxDirectorioRecuperar.Name = "TextBoxDirectorioRecuperar"
        Me.TextBoxDirectorioRecuperar.Size = New System.Drawing.Size(406, 20)
        Me.TextBoxDirectorioRecuperar.TabIndex = 25
        '
        'BackUp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 258)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BackUp2"
        Me.Text = "BackUp2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDirectorio As TextBox
    Friend WithEvents btnBackup As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExaminarRecuperar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRecuperar As Button
    Friend WithEvents TextBoxDirectorioRecuperar As TextBox
End Class
