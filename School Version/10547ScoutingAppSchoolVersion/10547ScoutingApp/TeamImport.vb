Imports System.IO
'Dusty Beehler
'Mortal Combots 10547
'2017-2018 Season
Public Class TeamImport

    'dispalys all teams found in text document
    Private Sub btnShowTeams_Click(sender As Object, e As EventArgs) Handles btnShowTeams.Click
        'creates text file if not present
        If (Not System.IO.Directory.Exists(CurDir() + "\Data\Teams")) Then
            System.IO.Directory.CreateDirectory(CurDir() + "\Data\Teams")
        End If

        'starts a stream reader to input data
        Dim sr As StreamReader = New StreamReader(CurDir() + "\Data\Teams\TeamDirectory.txt")

        '
        While Not sr.EndOfStream
            Dim i As Integer = 0
            variablesGlobal.allTeams = sr.ReadLine.Split(",")
        End While
    End Sub

    'exports new teams added in the form
    Private Sub btnExportTeams_Click(sender As Object, e As EventArgs) Handles btnExportTeams.Click
        variablesGlobal.newTeams = Split(txtNewTeams.Text, ",")

        For i As Integer = 0 To variablesGlobal.newTeams.Length - 1
            File.AppendAllText((CurDir() + "\Data\Teams\TeamDirectory.txt"), variablesGlobal.newTeams(i) + ",")
        Next
    End Sub

    'centers form
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    'closes form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class