<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categories))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CategoriaID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnGetDetails = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(544, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(126, 89)
        Me.GroupBox3.TabIndex = 162
        Me.GroupBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(6, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 26)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "&Obtener Datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button4.Location = New System.Drawing.Point(6, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 26)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "&Reiniciar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.CategoriaID, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 208)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(501, 153)
        Me.ListView1.TabIndex = 161
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'CategoriaID
        '
        Me.CategoriaID.Text = "ID"
        Me.CategoriaID.Width = 104
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 391
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 46)
        Me.GroupBox2.TabIndex = 160
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscador"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(443, 21)
        Me.TextBox1.TabIndex = 53
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(567, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 26)
        Me.Button2.TabIndex = 159
        Me.Button2.Text = "&Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCategoryName)
        Me.GroupBox1.Controls.Add(Me.txtCategoryID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 106)
        Me.GroupBox1.TabIndex = 158
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Categoria"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 18)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nombre"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Location = New System.Drawing.Point(141, 65)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(252, 21)
        Me.txtCategoryName.TabIndex = 53
        '
        'txtCategoryID
        '
        Me.txtCategoryID.BackColor = System.Drawing.Color.White
        Me.txtCategoryID.Location = New System.Drawing.Point(141, 26)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.ReadOnly = True
        Me.txtCategoryID.Size = New System.Drawing.Size(108, 21)
        Me.txtCategoryID.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "ID"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnGetDetails)
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Location = New System.Drawing.Point(567, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(103, 176)
        Me.panel1.TabIndex = 157
        '
        'btnGetDetails
        '
        Me.btnGetDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnGetDetails.Location = New System.Drawing.Point(11, 135)
        Me.btnGetDetails.Name = "btnGetDetails"
        Me.btnGetDetails.Size = New System.Drawing.Size(79, 26)
        Me.btnGetDetails.TabIndex = 24
        Me.btnGetDetails.Text = "&Obtener"
        Me.btnGetDetails.UseVisualStyleBackColor = True
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Enabled = False
        Me.btnUpdate_record.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnUpdate_record.Location = New System.Drawing.Point(11, 104)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(79, 26)
        Me.btnUpdate_record.TabIndex = 23
        Me.btnUpdate_record.Text = "&Actualizar"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnNewRecord.Location = New System.Drawing.Point(11, 10)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(79, 26)
        Me.btnNewRecord.TabIndex = 20
        Me.btnNewRecord.Text = "&Nuevo"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDelete.Location = New System.Drawing.Point(11, 73)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 26)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "&Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(11, 41)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 26)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "&Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "."
        '
        'Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 373)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoria"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents CategoriaID As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents panel1 As Panel
    Private WithEvents btnGetDetails As Button
    Public WithEvents btnUpdate_record As Button
    Private WithEvents btnNewRecord As Button
    Public WithEvents btnDelete As Button
    Private WithEvents btnSave As Button
    Public WithEvents Label1 As Label
End Class
