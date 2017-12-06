Imports System.IO

Public Class TeamImport

    Private Sub btnShowTeams_Click(sender As Object, e As EventArgs) Handles btnShowTeams.Click
        If (Not System.IO.Directory.Exists(CurDir() + "\Data\Teams")) Then
            System.IO.Directory.CreateDirectory(CurDir() + "\Data\Teams")
        End If

        Dim sr As StreamReader = New StreamReader(CurDir() + "\Data\Teams\TeamDirectory.txt")

        While Not sr.EndOfStream
            Dim i As Integer = 0
            variablesGlobal.allTeams = sr.ReadLine.Split(",")
        End While
        For i As Integer = 0 To variablesGlobal.allTeams.Length - 2
            lstTeams.Items.Add(variablesGlobal.allTeams(i))
        Next
    End Sub

    Private Sub btnExportTeams_Click(sender As Object, e As EventArgs) Handles btnExportTeams.Click
        variablesGlobal.newTeams = Split(txtNewTeams.Text, ",")

        For i As Integer = 0 To variablesGlobal.newTeams.Length - 1
            File.AppendAllText((CurDir() + "\Data\Teams\TeamDirectory.txt"), variablesGlobal.newTeams(i) + ",")
        Next
    End Sub

    Private Sub btnGoMainMenu_Click(sender As Object, e As EventArgs) Handles btnGoMainMenu.Click
        Me.Visible = False
        MainMenu.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MainMenu.applicationClose()
    End Sub
End Class