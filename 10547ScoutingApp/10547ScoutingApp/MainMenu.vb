Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Visible = True
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
    End Sub

    Private Sub BtnText_Click(sender As Object, e As EventArgs) Handles BtnText.Click
        Me.Visible = False
        TextExporter.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        applicationClose()
    End Sub
End Class