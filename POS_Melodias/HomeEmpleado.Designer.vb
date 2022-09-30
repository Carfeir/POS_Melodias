<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeEmpleado))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.RegistrationToolStripMenuItem1, Me.CustomerToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 76)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.OrderToolStripMenuItem.Image = CType(resources.GetObject("OrderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OrderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(62, 72)
        Me.OrderToolStripMenuItem.Text = "Venta"
        Me.OrderToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RegistrationToolStripMenuItem1
        '
        Me.RegistrationToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RegistrationToolStripMenuItem1.Image = CType(resources.GetObject("RegistrationToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RegistrationToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrationToolStripMenuItem1.Name = "RegistrationToolStripMenuItem1"
        Me.RegistrationToolStripMenuItem1.Size = New System.Drawing.Size(145, 72)
        Me.RegistrationToolStripMenuItem1.Text = "Registro de Ventas"
        Me.RegistrationToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CustomerToolStripMenuItem.Image = CType(resources.GetObject("CustomerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(73, 72)
        Me.CustomerToolStripMenuItem.Text = "Clientes"
        Me.CustomerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(62, 72)
        Me.LogoutToolStripMenuItem.Text = "Salir"
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.VendorsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarVentaToolStripMenuItem, Me.RegistroDeVentasToolStripMenuItem})
        Me.UsersToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UsersToolStripMenuItem.Text = "Venta"
        '
        'AgregarVentaToolStripMenuItem
        '
        Me.AgregarVentaToolStripMenuItem.Name = "AgregarVentaToolStripMenuItem"
        Me.AgregarVentaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AgregarVentaToolStripMenuItem.Text = "Agregar Venta"
        '
        'RegistroDeVentasToolStripMenuItem
        '
        Me.RegistroDeVentasToolStripMenuItem.Name = "RegistroDeVentasToolStripMenuItem"
        Me.RegistroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RegistroDeVentasToolStripMenuItem.Text = "Registro de Ventas"
        '
        'VendorsToolStripMenuItem
        '
        Me.VendorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem})
        Me.VendorsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.VendorsToolStripMenuItem.Name = "VendorsToolStripMenuItem"
        Me.VendorsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.VendorsToolStripMenuItem.Text = "Clientes"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem2})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ReportsToolStripMenuItem.Text = "Configuracion"
        '
        'RegistrationToolStripMenuItem2
        '
        Me.RegistrationToolStripMenuItem2.Name = "RegistrationToolStripMenuItem2"
        Me.RegistrationToolStripMenuItem2.Size = New System.Drawing.Size(187, 22)
        Me.RegistrationToolStripMenuItem2.Text = "Cambiar Contraseña"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(23, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 20)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "Stock"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ProductID, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(24, 151)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(764, 245)
        Me.ListView1.TabIndex = 144
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ProductID
        '
        Me.ProductID.Text = "ID Producto"
        Me.ProductID.Width = 65
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Proveedor"
        Me.ColumnHeader8.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 179
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categoria"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Precio U"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Color"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Marca"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cantidad"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 92
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(0, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 30)
        Me.Panel1.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso como: Empleado"
        '
        'HomeEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HomeEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label13 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AgregarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
End Class
