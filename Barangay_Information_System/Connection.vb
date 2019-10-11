
Module Connection
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public res As Integer
    Public up As Integer

    Public Sub connect()
        Dim path As String
        path = Application.StartupPath & "\BarangayInformationSystem.mdb"
        con.Open("provider = microsoft.jet.oledb.4.0;data source = " & path)
    End Sub

End Module
