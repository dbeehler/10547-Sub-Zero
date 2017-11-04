Imports Microsoft.Office.Interop

Public Class Form1
    'global variables
    Dim oXL As Excel.Application
    Dim oWB As Excel.Workbook
    Dim oSheet As Excel.Worksheet
    Dim oRng As Excel.Range

    Dim matchNumber As String

    Dim glyphAutoRed1Value As Integer
    Dim jewelRed1Value As Integer
    Dim safeZoneRed1value As Integer
    Dim cryptoKeyRed1Value As Integer
    Dim glyphTeleOpRed1Value As Integer
    Dim rowRed1Value As Integer
    Dim columnRed1Value As Integer
    Dim cipherRed1value As Integer
    Dim balanceRed1Value As Integer
    Dim relicRed1Value As Integer

    Private Sub btnFinalSpreadSheet_Click(sender As Object, e As EventArgs) Handles btnFinalSpreadSheet.Click
        'On Error GoTo Err_Handler

        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")
        ' oXL.Visible = True

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet

        'runs actual program
        formSetup()
        zoneRed1Setup()
        finalMath()
        'makes coloums look nicer
        oSheet.Columns("A:I").AutoFit

        'auto saves the excel file after writing it
        matchNumber = txtMatchNumber.Text
        If My.Computer.FileSystem.FileExists("C:\Users\dbeeh\Desktop\Match" + matchNumber + ".xls") Then
            oSheet.SaveAs("C:\Users\dbeeh\Desktop\Match" + (matchNumber + "1") + ".xls")
        Else
            oSheet.SaveAs("C:\Users\dbeeh\Desktop\Match" + matchNumber + ".xls")
        End If
        ' Make sure you release object references.
        oXL.Quit()
        oRng = Nothing
        oSheet = Nothing
        oWB = Nothing
        oXL = Nothing
        'MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
    End Sub

    Private Sub formSetup()
        'sets up cells
        'probably could be better. Dont know how though
        oSheet.Cells(1, 1).Value = "Team Number"
        oSheet.Cells(2, 1).Value = "--Autonomous--"
        oSheet.Cells(3, 1).Value = "Knock Jewel"
        oSheet.Cells(4, 1).Value = "Number of Glyphs"
        oSheet.Cells(5, 1).Value = "CryptoKey"
        oSheet.Cells(6, 1).Value = "Safe Zone?"
        oSheet.Cells(7, 1).Value = "--TeleOP--"
        oSheet.Cells(8, 1).Value = "Number of Glyphs"
        oSheet.Cells(9, 1).Value = "Number of Rows"
        oSheet.Cells(10, 1).Value = "Number of Columns"
        oSheet.Cells(11, 1).Value = "Cypher Pattern"
        oSheet.Cells(12, 1).Value = "--End Game--"
        oSheet.Cells(13, 1).Value = "Relic Zone"
        oSheet.Cells(14, 1).Value = "Balanced"
        oSheet.Cells(15, 1).Value = ""
        oSheet.Cells(2, 2).interior.color = Color.Black
        oSheet.Cells(7, 2).interior.color = Color.Black
        oSheet.Cells(12, 2).interior.color = Color.Black
        oSheet.Cells(15, 2).interior.color = Color.Black
        oSheet.Cells(2, 3).value = "Autonomous Score"
        oSheet.Cells(3, 3).value = "TeleOp Score"
        oSheet.Cells(4, 3).value = "End Game Score"
        oSheet.Cells(5, 3).value = "Final Score"
    End Sub

    Private Sub zoneRed1Setup()
        'sets up Red1 variables
        'these if statements make sure if there is no input then the numbers become zero
        'for the excel sheet
        If txtGlyphAutoRed1.Text = "" Then
            txtGlyphAutoRed1.Text = "0"
        End If

        If txtGlyphRed1.Text = "" Then
            txtGlyphRed1.Text = "0"
        End If

        If TxtRowRed1.Text = "" Then
            TxtRowRed1.Text = "0"
        End If

        If txtColumnsRed1.Text = "" Then
            txtColumnsRed1.Text = "0"
        End If

        If txtRelicRed1.Text = "" Then
            txtRelicRed1.Text = "0"
        End If

        'grabs numbers from the strings
        glyphAutoRed1Value = Integer.Parse(txtGlyphAutoRed1.Text)
        glyphTeleOpRed1Value = Integer.Parse(txtGlyphRed1.Text)
        rowRed1Value = Integer.Parse(TxtRowRed1.Text)
        columnRed1Value = Integer.Parse(txtColumnsRed1.Text)
        relicRed1Value = Integer.Parse(txtRelicRed1.Text)

        lstPatternRed1.SelectedItem = "None"
        oSheet.Cells(1, 2).value = txtTeamRed1.Text

        'if statements for math at the end
        If chkJewelRed1.Checked Then
            oSheet.Cells(3, 2).value = "Yes"
            jewelRed1Value = 1
        Else
            oSheet.Cells(3, 2).value = "No"
            jewelRed1Value = 0
        End If

        If glyphAutoRed1Value > 0 Then
            oSheet.Cells(4, 2).value = glyphAutoRed1Value
        Else
            oSheet.Cells(4, 2).value = "0"
        End If

        If chkCryptoKeyRed1.Checked Then
            oSheet.Cells(5, 2).value = "Yes"
            cryptoKeyRed1Value = 1
        Else
            oSheet.Cells(5, 2).value = "No"
            cryptoKeyRed1Value = 0
        End If

        If chkBalanceRed1.Checked Then
            oSheet.Cells(6, 2).value = "Yes"
            balanceRed1Value = 1
        Else
            oSheet.Cells(6, 2).value = "No"
            balanceRed1Value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(8, 2).value = glyphTeleOpRed1Value
        oSheet.Cells(9, 2).value = rowRed1Value
        oSheet.Cells(10, 2).value = columnRed1Value
        oSheet.Cells(11, 2).value = lstPatternRed1.SelectedItem
        Dim cipherChecker = lstPatternRed1.SelectedItem
        If cipherChecker.Contains("1") Or cipherChecker.Contains("2") Then
            cipherRed1value = 1
        Else
            cipherRed1value = 0
        End If

        If glyphAutoRed1Value > 0 Then
            oSheet.Cells(13, 2).value = relicRed1Value
        Else
            oSheet.Cells(13, 2).value = "None"
        End If

        If chkSafeZoneRed1.Checked Then
            oSheet.Cells(14, 2).value = "Yes"
            safeZoneRed1value = 1
        Else
            oSheet.Cells(14, 2).value = "No"
            safeZoneRed1value = 0
        End If
    End Sub

    Private Sub finalMath()
        'This is all the math for the scores
        'again, probably could be better, but it works!
        '**AUTONOMOUS**
        '30 point for jewel
        '15 points for glyph in cryptobox
        '30 points for correct cryptokey, ontop of glyph points
        '10 points safezone parked
        '**TELEOP**
        '2 points for each glyph
        '10 points for completed row
        '20 points for completed column
        '30 points for completed cipher
        '154 max points per cryptobox
        '**ENDGAME**
        '10 points zone 1
        '20 points zone 2
        '40 points zone 3
        '20 points balanced

        Dim redteam1AutoScore As Integer
        Dim redTeam1TeleScore As Integer
        Dim redTeam1EndScore As Integer
        Dim redTeam1FinalScore As Integer
        Dim relicScoreRed1 As Integer

        redteam1AutoScore = (jewelRed1Value * 30) + (safeZoneRed1value * 10) + (cryptoKeyRed1Value * 30) + (glyphAutoRed1Value * 15)
        oSheet.Cells(2, 4).value = redteam1AutoScore
        redTeam1TeleScore = (glyphTeleOpRed1Value * 2) + (rowRed1Value * 10) + (columnRed1Value * 20) + (cipherRed1value * 30)
        oSheet.Cells(3, 4).value = redTeam1TeleScore
        If relicRed1Value = 1 Then
            relicScoreRed1 = 10
        ElseIf relicRed1Value = 2 Then
            relicScoreRed1 = 20
        ElseIf relicRed1Value = 3 Then
            relicScoreRed1 = 40
        Else
            relicScoreRed1 = 0
        End If

        redTeam1EndScore = relicScoreRed1 + (balanceRed1Value * 20)
        oSheet.Cells(4, 4).value = redTeam1EndScore
        redTeam1FinalScore = redteam1AutoScore + redTeam1TeleScore + redTeam1EndScore
        oSheet.Cells(5, 4).value = redTeam1FinalScore
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all typeable input
        txtTeamRed1.Text = ""
        chkJewelRed1.Checked = False
        txtGlyphAutoRed1.Text = ""
        chkCryptoKeyRed1.Checked = False
        chkSafeZoneRed1.Checked = False
        txtGlyphRed1.Text = ""
        TxtRowRed1.Text = ""
        txtColumnsRed1.Text = ""
        lstPatternRed1.SelectedItem = "None"
        txtRelicRed1.Text = ""
        chkBalanceRed1.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changes window size and places it in center of screen
        Me.Size = New Size(1280, 720)
        Me.CenterToScreen()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes application
        Me.Close()
    End Sub
End Class
