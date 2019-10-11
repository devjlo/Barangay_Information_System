Public Class loginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        connect()
        rs.Open("SELECT * FROM tblLogin where Username= '" & Me.txtUsername.Text & "' and Password = '" & Me.txtPassword.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            Hide()
            mainForm.Show()

        End If
        con.Close()

    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLoginType.Items.Add("ADMIN")
        cboLoginType.Items.Add("Clerk")
    End Sub

    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        txtUsername.Text = " "
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
