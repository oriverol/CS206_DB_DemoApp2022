Public Class simpleLogin
    Private Sub EmpTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cs206dbDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cs206dbDataSet.empTable' table. You can move, or remove it, as needed.
        Me.EmpTableTableAdapter.Fill(Me.Cs206dbDataSet.empTable)

    End Sub
End Class