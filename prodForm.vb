Public Class prodForm
    Private Sub ProdTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProdTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProdTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cs206dbDataSet)

    End Sub

    Private Sub prodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cs206dbDataSet.prodTable' table. You can move, or remove it, as needed.
        Me.ProdTableTableAdapter.Fill(Me.Cs206dbDataSet.prodTable)

        ProdTableDataGridView.Columns(0).HeaderText = "Product ID"
        ProdTableDataGridView.Columns(1).HeaderText = "Product Name"
        ProdTableDataGridView.Columns(2).HeaderText = "Description"
        ProdTableDataGridView.Columns(3).HeaderText = "Price"
        ProdTableDataGridView.Columns(4).HeaderText = "Cost"
        ProdTableDataGridView.Columns(5).HeaderText = "Available"
        ProdTableDataGridView.Columns(6).HeaderText = "Image"

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Hide()

    End Sub
End Class