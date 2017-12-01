Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        rankingsForm.Visible = False
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Me.Visible = False
        ExcelExporter.Visible = True
    End Sub

    Public Shared Sub applicationClose()
        TeamImport.Close()
        TextExporter.Close()
        MainMenu.Close()
        ExcelExporter.Close()
        rankingsForm.Close()
    End Sub

    Private Sub BtnText_Click(sender As Object, e As EventArgs) Handles BtnText.Click
        Dim frmTextExporter As New TextExporter
        frmTextExporter.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        applicationClose()
    End Sub

    Private Sub btnViewRankings_Click(sender As Object, e As EventArgs) Handles btnViewRankings.Click
        rankingsForm.Visible = True
    End Sub
End Class