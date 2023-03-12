<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainDashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDataSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutORTechToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutVBDbAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usernameLbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mdNameLbl = New System.Windows.Forms.Label()
        Me.mdphoneLbl = New System.Windows.Forms.Label()
        Me.OpenForm4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataRecordsToolStripMenuItem, Me.AdminToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ManagerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip2"
        '
        'DataRecordsToolStripMenuItem
        '
        Me.DataRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem, Me.UpdateRecordToolStripMenuItem, Me.ViewRecordToolStripMenuItem, Me.DeleteRecordToolStripMenuItem, Me.ViewDataSetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.DataRecordsToolStripMenuItem.Image = CType(resources.GetObject("DataRecordsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataRecordsToolStripMenuItem.Name = "DataRecordsToolStripMenuItem"
        Me.DataRecordsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.DataRecordsToolStripMenuItem.Text = "Program"
        '
        'NewRecordToolStripMenuItem
        '
        Me.NewRecordToolStripMenuItem.Image = CType(resources.GetObject("NewRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewRecordToolStripMenuItem.Name = "NewRecordToolStripMenuItem"
        Me.NewRecordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewRecordToolStripMenuItem.Text = "New Sale"
        '
        'UpdateRecordToolStripMenuItem
        '
        Me.UpdateRecordToolStripMenuItem.Image = CType(resources.GetObject("UpdateRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateRecordToolStripMenuItem.Name = "UpdateRecordToolStripMenuItem"
        Me.UpdateRecordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateRecordToolStripMenuItem.Text = "Clear Sale"
        '
        'ViewRecordToolStripMenuItem
        '
        Me.ViewRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenForm4ToolStripMenuItem})
        Me.ViewRecordToolStripMenuItem.Image = CType(resources.GetObject("ViewRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewRecordToolStripMenuItem.Name = "ViewRecordToolStripMenuItem"
        Me.ViewRecordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewRecordToolStripMenuItem.Text = "View Sale"
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Image = CType(resources.GetObject("DeleteRecordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteRecordToolStripMenuItem.Text = "Tender Sale"
        '
        'ViewDataSetToolStripMenuItem
        '
        Me.ViewDataSetToolStripMenuItem.Image = CType(resources.GetObject("ViewDataSetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewDataSetToolStripMenuItem.Name = "ViewDataSetToolStripMenuItem"
        Me.ViewDataSetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewDataSetToolStripMenuItem.Text = "View Data Set"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.ProductsToolStripMenuItem})
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Image = CType(resources.GetObject("EmployeesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.EmployeesToolStripMenuItem.Text = "Employee Management"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Image = CType(resources.GetObject("ProductsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ProductsToolStripMenuItem.Text = "Product Management"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutORTechToolStripMenuItem, Me.AboutVBDbAppToolStripMenuItem})
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutORTechToolStripMenuItem
        '
        Me.AboutORTechToolStripMenuItem.Image = CType(resources.GetObject("AboutORTechToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutORTechToolStripMenuItem.Name = "AboutORTechToolStripMenuItem"
        Me.AboutORTechToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AboutORTechToolStripMenuItem.Text = "About ORTech"
        '
        'AboutVBDbAppToolStripMenuItem
        '
        Me.AboutVBDbAppToolStripMenuItem.Image = CType(resources.GetObject("AboutVBDbAppToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutVBDbAppToolStripMenuItem.Name = "AboutVBDbAppToolStripMenuItem"
        Me.AboutVBDbAppToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AboutVBDbAppToolStripMenuItem.Text = "About VB Db App"
        '
        'ManagerToolStripMenuItem
        '
        Me.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem"
        Me.ManagerToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ManagerToolStripMenuItem.Text = "Manager"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Dashboard"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 50)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'usernameLbl
        '
        Me.usernameLbl.AutoSize = True
        Me.usernameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLbl.ForeColor = System.Drawing.Color.White
        Me.usernameLbl.Location = New System.Drawing.Point(51, 15)
        Me.usernameLbl.Name = "usernameLbl"
        Me.usernameLbl.Size = New System.Drawing.Size(88, 20)
        Me.usernameLbl.TabIndex = 22
        Me.usernameLbl.Text = "username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.usernameLbl)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(590, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 50)
        Me.Panel2.TabIndex = 23
        '
        'mdNameLbl
        '
        Me.mdNameLbl.AutoSize = True
        Me.mdNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdNameLbl.Location = New System.Drawing.Point(32, 102)
        Me.mdNameLbl.Name = "mdNameLbl"
        Me.mdNameLbl.Size = New System.Drawing.Size(304, 108)
        Me.mdNameLbl.TabIndex = 24
        Me.mdNameLbl.Text = "Name"
        '
        'mdphoneLbl
        '
        Me.mdphoneLbl.AutoSize = True
        Me.mdphoneLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdphoneLbl.Location = New System.Drawing.Point(32, 234)
        Me.mdphoneLbl.Name = "mdphoneLbl"
        Me.mdphoneLbl.Size = New System.Drawing.Size(326, 108)
        Me.mdphoneLbl.TabIndex = 25
        Me.mdphoneLbl.Text = "Phone"
        '
        'OpenForm4ToolStripMenuItem
        '
        Me.OpenForm4ToolStripMenuItem.Name = "OpenForm4ToolStripMenuItem"
        Me.OpenForm4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenForm4ToolStripMenuItem.Text = "Open Form4"
        '
        'mainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.mdphoneLbl)
        Me.Controls.Add(Me.mdNameLbl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDataSetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutORTechToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutVBDbAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernameLbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mdNameLbl As Label
    Friend WithEvents mdphoneLbl As Label
    Friend WithEvents ManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenForm4ToolStripMenuItem As ToolStripMenuItem
End Class
