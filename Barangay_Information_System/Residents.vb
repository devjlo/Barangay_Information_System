Public Class Residents
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        registerForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        mainForm.Show()
    End Sub

    Private Sub Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lod()
    End Sub
    Public Sub lod()
        lvw.Items.Clear()
        connect()
        rs.Open("Select * from tblResidents order by ID", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF
            With lvw
                .Items.Add(rs.Fields("ID").Value)
                .Items(i).SubItems.Add(rs("FirstName").Value)
                .Items(i).SubItems.Add(rs("MiddleName").Value)
                .Items(i).SubItems.Add(rs("LastName").Value)
                .Items(i).SubItems.Add(rs("Sex").Value)
                .Items(i).SubItems.Add(rs("Occupation").Value)
                .Items(i).SubItems.Add(rs("Marital Status").Value)
                .Items(i).SubItems.Add(rs("Purok").Value)
            End With
            i = i + 1
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
    End Sub

    Private Sub lvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvw.SelectedIndexChanged

    End Sub

    Private Sub lvw_DoubleClick(sender As Object, e As EventArgs) Handles lvw.DoubleClick
        With lvw
            registerForm.residentNo.Text = .Items(.SelectedIndices(0)).Text
            registerForm.fn.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
            registerForm.mn.Text = .Items(.SelectedIndices(0)).SubItems(2).Text
            registerForm.ln.Text = .Items(.SelectedIndices(0)).SubItems(3).Text
            registerForm.sex.Text = .Items(.SelectedIndices(0)).SubItems(4).Text
            registerForm.occupation.Text = .Items(.SelectedIndices(0)).SubItems(5).Text
            registerForm.status.Text = .Items(.SelectedIndices(0)).SubItems(6).Text
            registerForm.Show()
        End With
    End Sub

End Class