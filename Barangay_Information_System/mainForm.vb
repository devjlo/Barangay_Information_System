Public Class mainForm
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        Hide()
        Residents.Show()
    End Sub

    Private Sub btnFiles_Click(sender As Object, e As EventArgs) Handles btnFiles.Click

    End Sub

    Private Sub btnViolation_Click(sender As Object, e As EventArgs) Handles btnViolation.Click
        Hide()
        ViolateRegister.Show()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class