'Dusty Beehler
'November 4, 2017
'Mortal Combots FTC #10547 2017 - 2018 Season
Public Class MainMenu
    'when the application loads it centers to screen
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        rankingsForm.Visible = False
    End Sub

    'opens the excel form
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim frmExcel As New ExcelExporter
        frmExcel.ShowDialog()
    End Sub

    'opens text form
    Private Sub BtnText_Click(sender As Object, e As EventArgs) Handles BtnText.Click
        Dim frmTextExporter As New TextExporter
        frmTextExporter.ShowDialog()
    End Sub

    'closes application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'opens databse form
    Private Sub btnViewRankings_Click(sender As Object, e As EventArgs) Handles btnViewRankings.Click
        rankingsForm.Visible = True
    End Sub
End Class