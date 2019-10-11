Public Class ViolateRegister
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Hide()
        Violationmain.Show()
    End Sub


    Private Sub ViolationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lod()
    End Sub
    Public Sub lod()
        lvw.Items.Clear()
        connect()
        rs.Open("Select * from Violation order by ID", con, 3, 3)
        Dim i As Integer
        i = 0
        Do Until rs.EOF
            With lvw
                .Items.Add(rs.Fields("ID").Value)
                .Items(i).SubItems.Add(rs("resName").Value)
                .Items(i).SubItems.Add(rs("Description").Value)
                .Items(i).SubItems.Add(rs("vio_Date").Value)
                .Items(i).SubItems.Add(rs("Penalty").Value)
            End With
            i = i + 1
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        With lvw
            Violationmain.recID = .Items(.SelectedIndices(0)).Text
            Violationmain.name.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
            Violationmain.Description.Text = .Items(.SelectedIndices(0)).SubItems(2).Text
            Violationmain.descip = .Items(.SelectedIndices(0)).SubItems(2).Text
            Violationmain.DateTimePicker1.Value = .Items(.SelectedIndices(0)).SubItems(3).Text
            Violationmain.dates = .Items(.SelectedIndices(0)).SubItems(3).Text
            Violationmain.penalty.Text = .Items(.SelectedIndices(0)).SubItems(4).Text
        End With
        Hide()
        Violationmain.UpD = True
        Violationmain.Show()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Hide()
        mainForm.Show()
    End Sub

    Private Sub lvw_MouseClick(sender As Object, e As MouseEventArgs) Handles lvw.MouseClick
        btnup.Enabled = True
    End Sub
End Class