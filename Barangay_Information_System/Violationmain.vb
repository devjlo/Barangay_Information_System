Public Class Violationmain
    Private resID As String
    Public UpD As Boolean
    Public recID As String
    Public resIdent As String
    Public descip As String
    Public dates As String

    Private Sub Violationmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today()
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
                .Items(i).SubItems.Add(rs("FirstName").Value & " " & rs("MiddleName").Value & " " & rs("LastName").Value)
                .Items(i).SubItems.Add(rs("Sex").Value)
                .Items(i).SubItems.Add(rs("Occupation").Value)
                .Items(i).SubItems.Add(rs("Purok").Value)
            End With
            i = i + 1
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Hide()
        ViolateRegister.btnup.Enabled = False
        clr()
        ViolateRegister.Show()
    End Sub
    Public Sub clr()
        name.Clear()
        Description.Clear()
        penalty.Clear()
        search.Clear()
    End Sub

    Private Sub sve_Click(sender As Object, e As EventArgs) Handles sve.Click
        connect()
        If UpD = False Then
            rs.Open("Select * From Violation where residentID ='" & 1001 & "' ", con, 3, 3)
        Else
            rs.Open("Select * From Violation where ID = " & recID & " ", con, 3, 3)
        End If

        If rs.RecordCount() = 0 And UpD = False Then
            rs.AddNew()
            rs.Fields("residentID").Value = resID
            rs.Fields("resName").Value = name.Text
            rs.Fields("Description").Value = Description.Text
            rs.Fields("vio_Date").Value = DateTimePicker1.Text
            rs.Fields("Penalty").Value = penalty.Text
            rs.Update()
        ElseIf rs.RecordCount() = 0 Then
            rs.Update()
            rs.Fields("ID").Value = recID
            rs.Fields("residentID").Value = resID
            rs.Fields("Description").Value = descip
            rs.Fields("vio_Date").Value = dates
            rs.Fields("Penalty").Value = penalty.Text
            rs.Update()
            UpD = False
        End If
        con.Close()
        Hide()
        ViolateRegister.lod()
        ViolateRegister.Show()
    End Sub

    Private Sub lvw_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvw.MouseDoubleClick
        With lvw
            resID = .Items(.SelectedIndices(0)).Text
            name.Text = .Items(.SelectedIndices(0)).SubItems(1).Text
        End With
    End Sub
End Class