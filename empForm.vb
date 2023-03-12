Public Class empForm

    Private Sub empForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cs206dbDataSet.empTable' table. You can move, or remove it, as needed.
        Me.EmpTableTableAdapter.Fill(Me.Cs206dbDataSet.empTable)

        efUsername.Text = loginForm.gusername

        EmpTableDataGridView.Columns(0).HeaderText = "Employee ID"
        EmpTableDataGridView.Columns(1).HeaderText = "Username"
        EmpTableDataGridView.Columns(2).HeaderText = "First Name"
        EmpTableDataGridView.Columns(3).HeaderText = "Last Name"
        EmpTableDataGridView.Columns(5).HeaderText = "Phone No."
        EmpTableDataGridView.Columns(6).HeaderText = "Last Login"
        EmpTableDataGridView.Columns(7).HeaderText = "Date Hired"
        EmpTableDataGridView.Columns(8).HeaderText = "Date Fired"
        EmpTableDataGridView.Columns(9).HeaderText = "Is Admin"

    End Sub
    Private Sub EmpTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cs206dbDataSet)

    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        BindingNavigatorMovePreviousItem.PerformClick()

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        BindingNavigatorMoveNextItem.PerformClick()

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        EmpTableBindingNavigatorSaveItem.PerformClick()

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        BindingNavigatorDeleteItem.PerformClick()
    End Sub
End Class