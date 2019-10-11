
Public Class registerForm
    Dim i As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        connect()
        'register new account
        rs.Open("Select * From tblResidents where ID ='" & residentNo.Text & "' ", con, 3, 3)

        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs.Fields("ID").Value = residentNo.Text
            rs.Fields("FirstName").Value = fn.Text
            rs.Fields("MiddleName").Value = mn.Text
            rs.Fields("LastName").Value = ln.Text
            rs.Fields("Sex").Value = sex.Text
            rs.Fields("Occupation").Value = occupation.Text
            rs.Fields("Marital Status").Value = status.Text
            rs.Fields("Birthday").Value = bday.Text
            rs.Fields("Purok").Value = purok.Text
            rs.Update()
        ElseIf rs.RecordCount <> 0 Then
            rs.Update()
            rs.Fields("ID").Value = residentNo.Text
            rs.Fields("FirstName").Value = fn.Text
            rs.Fields("MiddleName").Value = mn.Text
            rs.Fields("LastName").Value = ln.Text
            rs.Fields("Sex").Value = sex.Text
            rs.Fields("Occupation").Value = occupation.Text
            rs.Fields("Marital Status").Value = status.Text
            rs.Fields("Birthday").Value = bday.Text
            rs.Fields("Purok").Value = purok.Text
            rs.Update()
        End If

        con.Close()
        Hide()
        Residents.Show()
        Residents.lod()
    End Sub

    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        purok.Items.Add("1")
        purok.Items.Add("2")
        purok.Items.Add("3")
        purok.Items.Add("4")
        purok.Items.Add("5")

        status.Items.Add("Single")
        status.Items.Add("Married")
        sex.Items.Add("Male")
        sex.Items.Add("Female")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        clr()
        Me.Hide()
        Residents.Show()
    End Sub
    Private Sub clr()
        '  If res = 1 Then
        residentNo.Clear()
            fn.Clear()
            mn.Clear()
            ln.Clear()
            sex.Text = ""
            occupation.Clear()
            status.Text = ""
            purok.Text = ""
        '  Else

        ' End If
    End Sub
End Class