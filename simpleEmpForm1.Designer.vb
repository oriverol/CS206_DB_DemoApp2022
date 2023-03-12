<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class simpleEmpForm1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(simpleEmpForm1))
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
        Me.Cs206dbDataSet = New CS206_DB_DemoApp2022.cs206dbDataSet()
        Me.EmpTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpTableTableAdapter = New CS206_DB_DemoApp2022.cs206dbDataSetTableAdapters.empTableTableAdapter()
        Me.TableAdapterManager = New CS206_DB_DemoApp2022.cs206dbDataSetTableAdapters.TableAdapterManager()
        Me.EmpTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.DatehiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DatefiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IsadminCheckBox = New System.Windows.Forms.CheckBox()
        Me.LastloginDateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        CType(Me.Cs206dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpTableBindingNavigator.SuspendLayout()
        CType(Me.EmpTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cs206dbDataSet
        '
        Me.Cs206dbDataSet.DataSetName = "cs206dbDataSet"
        Me.Cs206dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpTableBindingSource
        '
        Me.EmpTableBindingSource.DataMember = "empTable"
        Me.EmpTableBindingSource.DataSource = Me.Cs206dbDataSet
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
        'EmpTableBindingNavigator
        '
        Me.EmpTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpTableBindingNavigator.BindingSource = Me.EmpTableBindingSource
        Me.EmpTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpTableBindingNavigatorSaveItem})
        Me.EmpTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpTableBindingNavigator.Name = "EmpTableBindingNavigator"
        Me.EmpTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpTableBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EmpTableBindingNavigator.TabIndex = 0
        Me.EmpTableBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'EmpTableBindingNavigatorSaveItem
        '
        Me.EmpTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpTableBindingNavigatorSaveItem.Name = "EmpTableBindingNavigatorSaveItem"
        Me.EmpTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmpTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmpTableDataGridView
        '
        Me.EmpTableDataGridView.AutoGenerateColumns = False
        Me.EmpTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn9})
        Me.EmpTableDataGridView.DataSource = Me.EmpTableBindingSource
        Me.EmpTableDataGridView.Location = New System.Drawing.Point(12, 305)
        Me.EmpTableDataGridView.Name = "EmpTableDataGridView"
        Me.EmpTableDataGridView.Size = New System.Drawing.Size(714, 188)
        Me.EmpTableDataGridView.TabIndex = 1
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
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "lname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "datehired"
        Me.DataGridViewTextBoxColumn7.HeaderText = "datehired"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "datefired"
        Me.DataGridViewTextBoxColumn8.HeaderText = "datefired"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "isadmin"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "isadmin"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "lastlogin"
        Me.DataGridViewTextBoxColumn9.HeaderText = "lastlogin"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'EmpIdLabel
        '
        EmpIdLabel.AutoSize = True
        EmpIdLabel.Location = New System.Drawing.Point(98, 44)
        EmpIdLabel.Name = "EmpIdLabel"
        EmpIdLabel.Size = New System.Drawing.Size(42, 13)
        EmpIdLabel.TabIndex = 2
        EmpIdLabel.Text = "emp Id:"
        '
        'EmpIdTextBox
        '
        Me.EmpIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "empId", True))
        Me.EmpIdTextBox.Location = New System.Drawing.Point(160, 41)
        Me.EmpIdTextBox.Name = "EmpIdTextBox"
        Me.EmpIdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmpIdTextBox.TabIndex = 3
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(98, 70)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 4
        UsernameLabel.Text = "username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(160, 67)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsernameTextBox.TabIndex = 5
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(98, 96)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(39, 13)
        FnameLabel.TabIndex = 6
        FnameLabel.Text = "fname:"
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(160, 93)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FnameTextBox.TabIndex = 7
        '
        'LnameLabel
        '
        LnameLabel.AutoSize = True
        LnameLabel.Location = New System.Drawing.Point(98, 122)
        LnameLabel.Name = "LnameLabel"
        LnameLabel.Size = New System.Drawing.Size(38, 13)
        LnameLabel.TabIndex = 8
        LnameLabel.Text = "lname:"
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "lname", True))
        Me.LnameTextBox.Location = New System.Drawing.Point(160, 119)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LnameTextBox.TabIndex = 9
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(98, 148)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 10
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(160, 145)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 11
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(98, 174)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(40, 13)
        PhoneLabel.TabIndex = 12
        PhoneLabel.Text = "phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpTableBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(160, 171)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 13
        '
        'DatehiredLabel
        '
        DatehiredLabel.AutoSize = True
        DatehiredLabel.Location = New System.Drawing.Point(98, 201)
        DatehiredLabel.Name = "DatehiredLabel"
        DatehiredLabel.Size = New System.Drawing.Size(54, 13)
        DatehiredLabel.TabIndex = 14
        DatehiredLabel.Text = "datehired:"
        '
        'DatehiredDateTimePicker
        '
        Me.DatehiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpTableBindingSource, "datehired", True))
        Me.DatehiredDateTimePicker.Location = New System.Drawing.Point(160, 197)
        Me.DatehiredDateTimePicker.Name = "DatehiredDateTimePicker"
        Me.DatehiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatehiredDateTimePicker.TabIndex = 15
        '
        'DatefiredLabel
        '
        DatefiredLabel.AutoSize = True
        DatefiredLabel.Location = New System.Drawing.Point(98, 227)
        DatefiredLabel.Name = "DatefiredLabel"
        DatefiredLabel.Size = New System.Drawing.Size(51, 13)
        DatefiredLabel.TabIndex = 16
        DatefiredLabel.Text = "datefired:"
        '
        'DatefiredDateTimePicker
        '
        Me.DatefiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpTableBindingSource, "datefired", True))
        Me.DatefiredDateTimePicker.Location = New System.Drawing.Point(160, 223)
        Me.DatefiredDateTimePicker.Name = "DatefiredDateTimePicker"
        Me.DatefiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatefiredDateTimePicker.TabIndex = 17
        '
        'IsadminLabel
        '
        IsadminLabel.AutoSize = True
        IsadminLabel.Location = New System.Drawing.Point(98, 254)
        IsadminLabel.Name = "IsadminLabel"
        IsadminLabel.Size = New System.Drawing.Size(45, 13)
        IsadminLabel.TabIndex = 18
        IsadminLabel.Text = "isadmin:"
        '
        'IsadminCheckBox
        '
        Me.IsadminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpTableBindingSource, "isadmin", True))
        Me.IsadminCheckBox.Location = New System.Drawing.Point(160, 249)
        Me.IsadminCheckBox.Name = "IsadminCheckBox"
        Me.IsadminCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.IsadminCheckBox.TabIndex = 19
        Me.IsadminCheckBox.Text = "CheckBox1"
        Me.IsadminCheckBox.UseVisualStyleBackColor = True
        '
        'LastloginLabel
        '
        LastloginLabel.AutoSize = True
        LastloginLabel.Location = New System.Drawing.Point(98, 283)
        LastloginLabel.Name = "LastloginLabel"
        LastloginLabel.Size = New System.Drawing.Size(48, 13)
        LastloginLabel.TabIndex = 20
        LastloginLabel.Text = "lastlogin:"
        '
        'LastloginDateTimePicker
        '
        Me.LastloginDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpTableBindingSource, "lastlogin", True))
        Me.LastloginDateTimePicker.Location = New System.Drawing.Point(160, 279)
        Me.LastloginDateTimePicker.Name = "LastloginDateTimePicker"
        Me.LastloginDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LastloginDateTimePicker.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 525)
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
        Me.Controls.Add(LastloginLabel)
        Me.Controls.Add(Me.LastloginDateTimePicker)
        Me.Controls.Add(Me.EmpTableDataGridView)
        Me.Controls.Add(Me.EmpTableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Cs206dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpTableBindingNavigator.ResumeLayout(False)
        Me.EmpTableBindingNavigator.PerformLayout()
        CType(Me.EmpTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents EmpIdTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents DatehiredDateTimePicker As DateTimePicker
    Friend WithEvents DatefiredDateTimePicker As DateTimePicker
    Friend WithEvents IsadminCheckBox As CheckBox
    Friend WithEvents LastloginDateTimePicker As DateTimePicker
End Class
