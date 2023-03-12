Public Class mainDashboard

    Private Sub mainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mdUsername As String
        Dim mdIsAdmin As Boolean
        Dim mdName As String
        Dim mdphone As String
        Dim mdusertype As String

        mdUsername = loginForm.gusername
        mdNameLbl.Text = loginForm.gname
        'mdIsAdmin = loginForm.gisAdmin
        mdphone = loginForm.gphone
        mdusertype = loginForm.gusertype

        'If mdIsAdmin = True Then
        'AdminToolStripMenuItem.Visible = True
        'Else
        'AdminToolStripMenuItem.Visible = False
        'End If

        If mdusertype = "admin" Then
            AdminToolStripMenuItem.Visible = True

        ElseIf mdusertype = "manager" Then
            AdminToolStripMenuItem.Visible = False

        Else
            AdminToolStripMenuItem.Visible = False
            ManagerToolStripMenuItem.Visible = False
        End If

        usernameLbl.Text = mdUsername
        mdphoneLbl.Text = mdphone

    End Sub
    Private Sub AboutVBDbAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutVBDbAppToolStripMenuItem.Click
        aboutProgram.Show()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        empForm.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        loginForm.Show()

    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        prodForm.Show()

    End Sub

    Private Sub ViewDataSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDataSetToolStripMenuItem.Click
        simpleEmpForm1.Show()

    End Sub

    Private Sub OpenForm4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenForm4ToolStripMenuItem.Click
        simpleEmpForm.Show()
    End Sub
End Class
