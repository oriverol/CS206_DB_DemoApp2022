<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empForm
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
        Me.components = New System.ComponentModel.Container()
        Dim EmpIdLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim LnameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim DatehiredLabel As System.Windows.Forms.Label
        Dim DatefiredLabel As System.Windows.Forms.Label
        Dim IsadminLabel As System.Windows.Forms.Label
        Dim LastloginLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empForm))
        Dim UsertypeLabel As System.Windows.Forms.Label
        Me.EmpTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.EmpTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.lastlogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.DatehiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DatefiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IsadminCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.efUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.LastloginDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.EmpTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cs206dbDataSet = New CS206_DB_DemoApp2022.cs206dbDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpTableTableAdapter = New CS206_DB_DemoApp2022.cs206dbDataSetTableAdapters.empTableTableAdapter()
        Me.TableAdapterManager = New CS206_DB_DemoApp2022.cs206dbDataSetTableAdapters.TableAdapterManager()
        Me.UsertypeTextBox = New System.Windows.Forms.TextBox()
        EmpIdLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        LnameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        DatehiredLabel = New System.Windows.Forms.Label()
        DatefiredLabel = New System.Windows.Forms.Label()
        IsadminLabel = New System.Windows.Forms.Label()
        LastloginLabel = New System.Windows.Forms.Label()
        UsertypeLabel = New System.Windows.Forms.Label()
        CType(Me.EmpTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpTableBindingNavigator.SuspendLayout()
        CType(Me.EmpTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EmpTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cs206dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpIdLabel
        '
        EmpIdLabel.AutoSize = True
        EmpIdLabel.Location = New System.Drawing.Point(10, 73)
        EmpIdLabel.Name = "EmpIdLabel"
        EmpIdLabel.Size = New System.Drawing.Size(70, 13)
        EmpIdLabel.TabIndex = 2
        EmpIdLabel.Text = "Employee ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(10, 99)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 4
        UsernameLabel.Text = "Username:"
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(10, 125)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(60, 13)
        FnameLabel.TabIndex = 6
        FnameLabel.Text = "First Name:"
        '
        'LnameLabel
        '
        LnameLabel.AutoSize = True
        LnameLabel.Location = New System.Drawing.Point(10, 151)
        LnameLabel.Name = "LnameLabel"
        LnameLabel.Size = New System.Drawing.Size(61, 13)
        LnameLabel.TabIndex = 8
        LnameLabel.Text = "Last Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(10, 177)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 10
        PasswordLabel.Text = "Password:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(207, 73)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 12
        PhoneLabel.Text = "Phone:"
        '
        'DatehiredLabel
        '
        DatehiredLabel.AutoSize = True
        DatehiredLabel.Location = New System.Drawing.Point(207, 126)
        DatehiredLabel.Name = "DatehiredLabel"
        DatehiredLabel.Size = New System.Drawing.Size(61, 13)
        DatehiredLabel.TabIndex = 14
        DatehiredLabel.Text = "Date Hired:"
        '
        'DatefiredLabel
        '
        DatefiredLabel.AutoSize = True
        DatefiredLabel.Location = New System.Drawing.Point(207, 152)
        DatefiredLabel.Name = "DatefiredLabel"
        DatefiredLabel.Size = New System.Drawing.Size(59, 13)
        DatefiredLabel.TabIndex = 16
        DatefiredLabel.Text = "Date Fired:"
        '
        'IsadminLabel
        '
        IsadminLabel.AutoSize = True
        IsadminLabel.Location = New System.Drawing.Point(207, 179)
        IsadminLabel.Name = "IsadminLabel"
        IsadminLabel.Size = New System.Drawing.Size(50, 13)
        IsadminLabel.TabIndex = 18
        IsadminLabel.Text = "Is Admin:"
        '
        'LastloginLabel
        '
        LastloginLabel.AutoSize = True
        LastloginLabel.Location = New System.Drawing.Point(207, 99)
        LastloginLabel.Name = "LastloginLabel"
        LastloginLabel.Size = New System.Drawing.Size(59, 13)
        LastloginLabel.TabIndex = 23
        LastloginLabel.Text = "Last Login:"
        '
        'EmpTableBindingNavigator
        '
        Me.EmpTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpTableBindingNavigator.BindingSource = Me.EmpTableBindingSource
        Me.EmpTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpTableBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.EmpTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpTableBindingNavigator.Name = "EmpTableBindingNavigator"
        Me.EmpTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpTableBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.EmpTableBindingNavigator.TabIndex = 0
        Me.EmpTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmpTableBindingNavigatorSaveItem
        '
        Me.EmpTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpTableBindingNavigatorSaveItem.Name = "EmpTableBindingNavigatorSaveItem"
        Me.EmpTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'EmpTableDataGridView
        '
        Me.EmpTableDataGridView.AllowUserToOrderColumns = True
        Me.EmpTableDataGridView.AutoGenerateColumns = False
        Me.EmpTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpTableDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EmpTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmpTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.lastlogin, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1})
        Me.EmpTableDataGridView.DataSource = Me.EmpTableBindingSource
        Me.EmpTableDataGridView.Location = New System.Drawing.Point(0, 261)
        Me.EmpTableDataGridView.Name = "EmpTableDataGridView"
        Me.EmpTableDataGridView.ReadOnly = True
        Me.EmpTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpTableDataGridView.Size = New System.Drawing.Size(564, 104)
        Me.EmpTableDataGridView.TabIndex = 1
        '
        'lastlogin
        '
        Me.lastlogin.DataPropertyName = "lastlogin"
        Me.lastlogin.HeaderText = "lastlogin"
        Me.lastlogin.Name = "lastlogin"
        Me.lastlogin.ReadOnly = True
        '
        'EmpIdTextBox
        '
        Me.EmpIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "empId", True))
        Me.EmpIdTextBox.Location = New System.Drawing.Point(86, 70)
        Me.EmpIdTextBox.Name = "EmpIdTextBox"
        Me.EmpIdTextBox.ReadOnly = True
        Me.EmpIdTextBox.Size = New System.Drawing.Size(111, 20)
        Me.EmpIdTextBox.TabIndex = 3
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(86, 96)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(111, 20)
        Me.UsernameTextBox.TabIndex = 5
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(86, 122)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(111, 20)
        Me.FnameTextBox.TabIndex = 7
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "lname", True))
        Me.LnameTextBox.Location = New System.Drawing.Point(86, 148)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(111, 20)
        Me.LnameTextBox.TabIndex = 9
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(86, 174)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(111, 20)
        Me.PasswordTextBox.TabIndex = 11
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(269, 70)
        Me.PhoneTextBox.MaxLength = 7
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(125, 20)
        Me.PhoneTextBox.TabIndex = 13
        '
        'DatehiredDateTimePicker
        '
        Me.DatehiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpTableBindingSource, "datehired", True))
        Me.DatehiredDateTimePicker.Location = New System.Drawing.Point(269, 122)
        Me.DatehiredDateTimePicker.Name = "DatehiredDateTimePicker"
        Me.DatehiredDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.DatehiredDateTimePicker.TabIndex = 15
        '
        'DatefiredDateTimePicker
        '
        Me.DatefiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpTableBindingSource, "datefired", True))
        Me.DatefiredDateTimePicker.Location = New System.Drawing.Point(269, 148)
        Me.DatefiredDateTimePicker.Name = "DatefiredDateTimePicker"
        Me.DatefiredDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.DatefiredDateTimePicker.TabIndex = 17
        '
        'IsadminCheckBox
        '
        Me.IsadminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpTableBindingSource, "isadmin", True))
        Me.IsadminCheckBox.Location = New System.Drawing.Point(269, 174)
        Me.IsadminCheckBox.Name = "IsadminCheckBox"
        Me.IsadminCheckBox.Size = New System.Drawing.Size(127, 24)
        Me.IsadminCheckBox.TabIndex = 19
        Me.IsadminCheckBox.Text = "Admin"
        Me.IsadminCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel1.Controls.Add(Me.efUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 31)
        Me.Panel1.TabIndex = 20
        '
        'efUsername
        '
        Me.efUsername.AutoSize = True
        Me.efUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.efUsername.ForeColor = System.Drawing.Color.White
        Me.efUsername.Location = New System.Drawing.Point(454, 6)
        Me.efUsername.Name = "efUsername"
        Me.efUsername.Size = New System.Drawing.Size(88, 20)
        Me.efUsername.TabIndex = 1
        Me.efUsername.Text = "username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Management"
        '
        'closeBtn
        '
        Me.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeBtn.Location = New System.Drawing.Point(240, 372)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(75, 23)
        Me.closeBtn.TabIndex = 21
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.deleteBtn)
        Me.Panel2.Controls.Add(Me.saveBtn)
        Me.Panel2.Controls.Add(Me.addBtn)
        Me.Panel2.Location = New System.Drawing.Point(402, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 200)
        Me.Panel2.TabIndex = 22
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Image = CType(resources.GetObject("deleteBtn.Image"), System.Drawing.Image)
        Me.deleteBtn.Location = New System.Drawing.Point(8, 134)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(147, 51)
        Me.deleteBtn.TabIndex = 29
        Me.deleteBtn.Text = "Delete Employee"
        Me.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.Image = CType(resources.GetObject("saveBtn.Image"), System.Drawing.Image)
        Me.saveBtn.Location = New System.Drawing.Point(8, 72)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(147, 51)
        Me.saveBtn.TabIndex = 28
        Me.saveBtn.Text = "Save Employee"
        Me.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.ForeColor = System.Drawing.Color.White
        Me.addBtn.Image = CType(resources.GetObject("addBtn.Image"), System.Drawing.Image)
        Me.addBtn.Location = New System.Drawing.Point(8, 10)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(147, 51)
        Me.addBtn.TabIndex = 27
        Me.addBtn.Text = "Add Employee"
        Me.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'LastloginDateTimePicker
        '
        Me.LastloginDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpTableBindingSource, "lastlogin", True))
        Me.LastloginDateTimePicker.Location = New System.Drawing.Point(269, 96)
        Me.LastloginDateTimePicker.Name = "LastloginDateTimePicker"
        Me.LastloginDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.LastloginDateTimePicker.TabIndex = 24
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.Image = CType(resources.GetObject("backBtn.Image"), System.Drawing.Image)
        Me.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backBtn.Location = New System.Drawing.Point(13, 205)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(80, 50)
        Me.backBtn.TabIndex = 25
        Me.backBtn.Text = "Back"
        Me.backBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.ForeColor = System.Drawing.Color.White
        Me.nextBtn.Image = CType(resources.GetObject("nextBtn.Image"), System.Drawing.Image)
        Me.nextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nextBtn.Location = New System.Drawing.Point(99, 205)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(80, 50)
        Me.nextBtn.TabIndex = 26
        Me.nextBtn.Text = "Next"
        Me.nextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'EmpTableBindingSource
        '
        Me.EmpTableBindingSource.DataMember = "empTable"
        Me.EmpTableBindingSource.DataSource = Me.Cs206dbDataSet
        '
        'Cs206dbDataSet
        '
        Me.Cs206dbDataSet.DataSetName = "cs206dbDataSet"
        Me.Cs206dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "empId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "empId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "lname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "datehired"
        Me.DataGridViewTextBoxColumn7.HeaderText = "datehired"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "datefired"
        Me.DataGridViewTextBoxColumn8.HeaderText = "datefired"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "isadmin"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "isadmin"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'EmpTableTableAdapter
        '
        Me.EmpTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.empTableTableAdapter = Me.EmpTableTableAdapter
        Me.TableAdapterManager.prodTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CS206_DB_DemoApp2022.cs206dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsertypeLabel
        '
        UsertypeLabel.AutoSize = True
        UsertypeLabel.Location = New System.Drawing.Point(207, 207)
        UsertypeLabel.Name = "UsertypeLabel"
        UsertypeLabel.Size = New System.Drawing.Size(59, 13)
        UsertypeLabel.TabIndex = 27
        UsertypeLabel.Text = "User Type:"
        '
        'UsertypeTextBox
        '
        Me.UsertypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "usertype", True))
        Me.UsertypeTextBox.Location = New System.Drawing.Point(269, 204)
        Me.UsertypeTextBox.Name = "UsertypeTextBox"
        Me.UsertypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsertypeTextBox.TabIndex = 28
        '
        'empForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.closeBtn
        Me.ClientSize = New System.Drawing.Size(584, 415)
        Me.Controls.Add(UsertypeLabel)
        Me.Controls.Add(Me.UsertypeTextBox)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(LastloginLabel)
        Me.Controls.Add(Me.LastloginDateTimePicker)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(EmpIdLabel)
        Me.Controls.Add(Me.EmpIdTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(FnameLabel)
        Me.Controls.Add(Me.FnameTextBox)
        Me.Controls.Add(LnameLabel)
        Me.Controls.Add(Me.LnameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(DatehiredLabel)
        Me.Controls.Add(Me.DatehiredDateTimePicker)
        Me.Controls.Add(DatefiredLabel)
        Me.Controls.Add(Me.DatefiredDateTimePicker)
        Me.Controls.Add(IsadminLabel)
        Me.Controls.Add(Me.IsadminCheckBox)
        Me.Controls.Add(Me.EmpTableDataGridView)
        Me.Controls.Add(Me.EmpTableBindingNavigator)
        Me.Name = "empForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Form"
        CType(Me.EmpTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpTableBindingNavigator.ResumeLayout(False)
        Me.EmpTableBindingNavigator.PerformLayout()
        CType(Me.EmpTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.EmpTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cs206dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cs206dbDataSet As cs206dbDataSet
    Friend WithEvents EmpTableBindingSource As BindingSource
    Friend WithEvents EmpTableTableAdapter As cs206dbDataSetTableAdapters.empTableTableAdapter
    Friend WithEvents TableAdapterManager As cs206dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmpTableDataGridView As DataGridView
    Friend WithEvents EmpIdTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents DatehiredDateTimePicker As DateTimePicker
    Friend WithEvents DatefiredDateTimePicker As DateTimePicker
    Friend WithEvents IsadminCheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LastloginDateTimePicker As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents lastlogin As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents backBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents efUsername As Label
    Friend WithEvents UsertypeTextBox As TextBox
End Class
