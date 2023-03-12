Imports System.Data
Imports System.Data.SqlClient

Public Class loginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    'Global Variables

    Public Shared gusername As String
    Public Shared gname As String
    Public Shared gphone As String
    'Public Shared gisAdmin As Boolean
    Public Shared gusertype As String

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        Dim connString As String

        connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\cs206db.mdf;Integrated Security=True"
        '"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\cs206db.mdf;Integrated Security=True"

        'conn = New SqlConnection(connString)
        'conn.Open()
        'query = "Select COUNT(*) from empTable where username ='" & usernameTB.Text & "'"
        'cmd = New SqlCommand(query, conn)
        'reader = cmd.ExecuteReader

        If usernameTB.Text = "" Then

            loginMsg.Text = "Username cannot be blank."
            'MessageBox.Show(loginMsg.Text)
            'ElseIf reader.HasRows Then

            'loginMsg.Text = "Username not found in this system."

        ElseIf passwordTB.Text = "" Then
            loginMsg.Text = "Password cannot be blank."
            'MessageBox.Show(loginMsg.Text)

        Else
            conn = New SqlConnection(connString)
            conn.Open()
            query = "SELECT username, fname, lname, password, phone, usertype from empTable where username ='" & usernameTB.Text & "' and password='" & passwordTB.Text & "'"
            cmd = New SqlCommand(query, conn)
            reader = cmd.ExecuteReader

            If reader.Read = True Then

                gusername = reader.GetValue(0)
                gname = reader.GetValue(1) & " " & reader.GetValue(2)
                gphone = reader.GetValue(4)
                'gisAdmin = reader.GetValue(5)
                gusertype = reader.GetValue(5)

                MessageBox.Show(gusertype)

                Me.Hide()
                mainDashboard.Show()
            Else
                loginMsg.Text = "Password is invalid."

            End If

            conn.Close()

        End If

    End Sub
End Class
