Imports System.Data
Imports System.Data.SqlClient

Public Class insertProduct
    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click

        Dim connString As String
        Dim apfprodName As String
        Dim apfprodDesc As String

        apfprodName = prodNameTxt.Text
        apfprodDesc = prodDescTxt.Text

        'MessageBox.Show(apfprodName)

        connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\cs206db.mdf;Integrated Security=True"

        conn = New SqlConnection(connString)
        conn.Open()
        query = "insert into prodTable values ('new product4','new description','','','','')"
        'query = "INSERT INTO prodTable VALUE ('" & apfprodName & "',','','','','','')"
        'query = "Select COUNT(*) from empTable where username ='" & usernameTB.Text & "'"
        cmd = New SqlCommand(query, conn)
        cmd.BeginExecuteNonQuery()

        conn.Close()

    End Sub
End Class