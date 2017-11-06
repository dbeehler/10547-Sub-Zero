Imports Microsoft.Office.Interop
Imports System.IO
'Made my Dusty Beehler
'November 4, 2017
'Mortal Combots FTC #10547 2017 - 2018 Season
'Version 1.0
'Excel Exporter

Public Class Form1
    'global variables
    Dim oXL As Excel.Application
    Dim oWB As Excel.Workbook
    Dim oSheet As Excel.Worksheet
    Dim oRng As Excel.Range

    'variables used
    Dim matchNumber As String
    Dim redAllianceScore As Integer
    Dim blueAllianceScore As Integer

    Private Sub btnFinalSpreadSheet_Click(sender As Object, e As EventArgs) Handles btnFinalSpreadSheet.Click
        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet

        'runs actual program
        formSetup()
        zoneRed1Setup()
        zoneRed2Setup()
        zoneBlue1Setup()
        zoneBlue2Setup()
        finalMath()
        moreThingsforbetterness()

        'makes coloums look nicer
        oSheet.Columns("A:P").AutoFit

        'creates file tree if not present
        If (Not System.IO.Directory.Exists(CurDir() + "\Matches")) Then
            System.IO.Directory.CreateDirectory(CurDir() + "\Matches")
        End If

        'auto saves the excel file after writing it
        matchNumber = txtMatchNumber.Text
        If My.Computer.FileSystem.FileExists(CurDir() + "\Matches\Match" + matchNumber + ".xlsx") Then
            oSheet.SaveAs(CurDir() + "\Matches\Match" + (matchNumber + "Copy") + ".xlsx")
        Else
            oSheet.SaveAs(CurDir() + "\Matches\Match" + matchNumber + ".xlsx")
        End If
        ' Make sure you release object references.
        oXL.Quit()
        oRng = Nothing
        oSheet = Nothing
        oWB = Nothing
        oXL = Nothing
    End Sub

    Private Sub formSetup()
        'sets up cells
        'probably could be better. Dont know how though
        '(row, column)

        'Red1FormSetup
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
        oSheet.Cells(14, 1).Value = "Relic Upright"
        oSheet.Cells(15, 1).Value = "Balanced"
        oSheet.Cells(2, 3).value = "Autonomous Score"
        oSheet.Cells(3, 3).value = "TeleOp Score"
        oSheet.Cells(4, 3).value = "End Game Score"
        oSheet.Cells(5, 3).value = "Final Score"

        'Red2FormSetup
        oSheet.Cells(1, 6).Value = "Team Number"
        oSheet.Cells(2, 6).Value = "--Autonomous--"
        oSheet.Cells(3, 6).Value = "Knock Jewel"
        oSheet.Cells(4, 6).Value = "Number of Glyphs"
        oSheet.Cells(5, 6).Value = "CryptoKey"
        oSheet.Cells(6, 6).Value = "Safe Zone?"
        oSheet.Cells(7, 6).Value = "--TeleOP--"
        oSheet.Cells(8, 6).Value = "Number of Glyphs"
        oSheet.Cells(9, 6).Value = "Number of Rows"
        oSheet.Cells(10, 6).Value = "Number of Columns"
        oSheet.Cells(11, 6).Value = "Cypher Pattern"
        oSheet.Cells(12, 6).Value = "--End Game--"
        oSheet.Cells(13, 6).Value = "Relic Zone"
        oSheet.Cells(14, 6).Value = "Relic Upright"
        oSheet.Cells(15, 6).Value = "Balanced"
        oSheet.Cells(2, 8).value = "Autonomous Score"
        oSheet.Cells(3, 8).value = "TeleOp Score"
        oSheet.Cells(4, 8).value = "End Game Score"
        oSheet.Cells(5, 8).value = "Final Score"

        'Blue1FormSetup
        oSheet.Cells(18, 1).Value = "Team Number"
        oSheet.Cells(19, 1).Value = "--Autonomous--"
        oSheet.Cells(20, 1).Value = "Knock Jewel"
        oSheet.Cells(21, 1).Value = "Number of Glyphs"
        oSheet.Cells(22, 1).Value = "CryptoKey"
        oSheet.Cells(23, 1).Value = "Safe Zone?"
        oSheet.Cells(24, 1).Value = "--TeleOP--"
        oSheet.Cells(25, 1).Value = "Number of Glyphs"
        oSheet.Cells(26, 1).Value = "Number of Rows"
        oSheet.Cells(27, 1).Value = "Number of Columns"
        oSheet.Cells(28, 1).Value = "Cypher Pattern"
        oSheet.Cells(29, 1).Value = "--End Game--"
        oSheet.Cells(30, 1).Value = "Relic Zone"
        oSheet.Cells(31, 1).Value = "Relic Upright"
        oSheet.Cells(32, 1).Value = "Balanced"
        oSheet.Cells(19, 3).value = "Autonomous Score"
        oSheet.Cells(20, 3).value = "TeleOp Score"
        oSheet.Cells(21, 3).value = "End Game Score"
        oSheet.Cells(22, 3).value = "Final Score"

        'Blue2FormSetup
        oSheet.Cells(18, 6).Value = "Team Number"
        oSheet.Cells(19, 6).Value = "--Autonomous--"
        oSheet.Cells(20, 6).Value = "Knock Jewel"
        oSheet.Cells(21, 6).Value = "Number of Glyphs"
        oSheet.Cells(22, 6).Value = "CryptoKey"
        oSheet.Cells(23, 6).Value = "Safe Zone?"
        oSheet.Cells(24, 6).Value = "--TeleOP--"
        oSheet.Cells(25, 6).Value = "Number of Glyphs"
        oSheet.Cells(26, 6).Value = "Number of Rows"
        oSheet.Cells(27, 6).Value = "Number of Columns"
        oSheet.Cells(28, 6).Value = "Cypher Pattern"
        oSheet.Cells(29, 6).Value = "--End Game--"
        oSheet.Cells(30, 6).Value = "Relic Zone"
        oSheet.Cells(31, 6).Value = "Relic Upright"
        oSheet.Cells(32, 6).Value = "Balanced"
        oSheet.Cells(19, 8).value = "Autonomous Score"
        oSheet.Cells(20, 8).value = "TeleOp Score"
        oSheet.Cells(21, 8).value = "End Game Score"
        oSheet.Cells(22, 8).value = "Final Score"
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

        If txtRowRed1.Text = "" Then
            txtRowRed1.Text = "0"
        End If

        If txtColumnsRed1.Text = "" Then
            txtColumnsRed1.Text = "0"
        End If

        If txtRelicRed1.Text = "" Then
            txtRelicRed1.Text = "0"
        End If

        'grabs numbers from the strings
        variablesGlobal.glyphAutoRed1Value = Integer.Parse(txtGlyphAutoRed1.Text)
        variablesGlobal.glyphTeleOpRed1Value = Integer.Parse(txtGlyphRed1.Text)
        variablesGlobal.rowRed1Value = Integer.Parse(txtRowRed1.Text)
        variablesGlobal.columnRed1Value = Integer.Parse(txtColumnsRed1.Text)
        variablesGlobal.relicRed1Value = Integer.Parse(txtRelicRed1.Text)

        oSheet.Cells(1, 2).value = txtTeamRed1.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelRed1.Checked Then
            oSheet.Cells(3, 2).value = "Yes"
            variablesGlobal.jewelRed1Value = 1
        Else
            oSheet.Cells(3, 2).value = "No"
            variablesGlobal.jewelRed1Value = 0
        End If

        'number of glyps put into box during autonomous
        If variablesGlobal.glyphAutoRed1Value > 0 Then
            oSheet.Cells(4, 2).value = variablesGlobal.glyphAutoRed1Value
        Else
            oSheet.Cells(4, 2).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyRed1.Checked Then
            oSheet.Cells(5, 2).value = "Yes"
            variablesGlobal.cryptoKeyRed1Value = 1
        Else
            oSheet.Cells(5, 2).value = "No"
            variablesGlobal.cryptoKeyRed1Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneRed1.Checked Then
            oSheet.Cells(6, 2).value = "Yes"
            variablesGlobal.safeZoneRed1value = 1
        Else
            oSheet.Cells(6, 2).value = "No"
            variablesGlobal.safeZoneRed1value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(8, 2).value = variablesGlobal.glyphTeleOpRed1Value
        oSheet.Cells(9, 2).value = variablesGlobal.rowRed1Value
        oSheet.Cells(10, 2).value = variablesGlobal.columnRed1Value


        'determines if cypher was completed for spread sheet
        If lstPatternRed1.SelectedIndex > 0 Then
            oSheet.Cells(11, 2).value = lstPatternRed1.SelectedItem
            variablesGlobal.cypherRed1Value = 1
        Else
            oSheet.Cells(11, 2).value = "None"
            variablesGlobal.cypherRed1Value = 0
        End If

        'if relic is in zone at end game
        If variablesGlobal.relicRed1Value > 0 Then
            oSheet.Cells(13, 2).value = variablesGlobal.relicRed1Value
        Else
            oSheet.Cells(13, 2).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightRed1.Checked Then
            oSheet.Cells(14, 2).value = "Yes"
            variablesGlobal.relicRed1Value = 1
        Else
            oSheet.Cells(14, 2).value = "No"
            variablesGlobal.relicRed1Value = 0
        End If

        'if robot is balanced
        If chkBalanceRed1.Checked Then
            oSheet.Cells(15, 2).value = "Yes"
            variablesGlobal.balanceRed1Value = 1
        Else
            oSheet.Cells(15, 2).value = "No"
            variablesGlobal.balanceRed1Value = 0
        End If
    End Sub

    Private Sub zoneRed2Setup()
        'sets up Red1 variables
        'these if statements make sure if there is no input then the numbers become zero
        'for the excel sheet
        If txtGlyphAutoRed2.Text = "" Then
            txtGlyphAutoRed2.Text = "0"
        End If

        If txtGlyphRed2.Text = "" Then
            txtGlyphRed2.Text = "0"
        End If

        If txtRowRed2.Text = "" Then
            txtRowRed2.Text = "0"
        End If

        If txtColumnsRed2.Text = "" Then
            txtColumnsRed2.Text = "0"
        End If

        If txtRelicRed2.Text = "" Then
            txtRelicRed2.Text = "0"
        End If

        'grabs numbers from the strings
        variablesGlobal.glyphAutoRed2Value = Integer.Parse(txtGlyphAutoRed2.Text)
        variablesGlobal.glyphTeleOpRed2Value = Integer.Parse(txtGlyphRed2.Text)
        variablesGlobal.rowRed2Value = Integer.Parse(txtRowRed2.Text)
        variablesGlobal.columnRed2Value = Integer.Parse(txtColumnsRed2.Text)
        variablesGlobal.relicRed2Value = Integer.Parse(txtRelicRed2.Text)

        'prints team number
        oSheet.Cells(1, 7).value = txtTeamRed2.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelRed2.Checked Then
            oSheet.Cells(3, 7).value = "Yes"
            variablesGlobal.jewelRed2Value = 1
        Else
            oSheet.Cells(3, 7).value = "No"
            variablesGlobal.jewelRed2Value = 0
        End If

        'number of glyps put into box during autonomous
        If variablesGlobal.glyphAutoRed2Value > 0 Then
            oSheet.Cells(4, 7).value = variablesGlobal.glyphAutoRed2Value
        Else
            oSheet.Cells(4, 7).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyRed2.Checked Then
            oSheet.Cells(5, 7).value = "Yes"
            variablesGlobal.cryptoKeyRed2Value = 1
        Else
            oSheet.Cells(5, 7).value = "No"
            variablesGlobal.cryptoKeyRed2Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneRed2.Checked Then
            oSheet.Cells(6, 7).value = "Yes"
            variablesGlobal.safeZoneRed2value = 1
        Else
            oSheet.Cells(6, 7).value = "No"
            variablesGlobal.safeZoneRed2value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(8, 7).value = variablesGlobal.glyphTeleOpRed2Value
        oSheet.Cells(9, 7).value = variablesGlobal.rowRed2Value
        oSheet.Cells(10, 7).value = variablesGlobal.columnRed2Value

        'determines if cypher was completed for spread sheet
        If lstPatternRed2.SelectedIndex > 0 Then
            oSheet.Cells(11, 7).value = lstPatternRed2.SelectedItem
            variablesGlobal.cypherRed2Value = 1
        Else
            oSheet.Cells(11, 7).value = "None"
            variablesGlobal.cypherRed2Value = 0
        End If

        'if relic is in zone at end game
        If variablesGlobal.relicRed2Value > 0 Then
            oSheet.Cells(13, 7).value = variablesGlobal.relicRed2Value
        Else
            oSheet.Cells(13, 7).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightRed2.Checked Then
            oSheet.Cells(14, 7).value = "Yes"
            variablesGlobal.relicRed2Value = 1
        Else
            oSheet.Cells(14, 7).value = "No"
            variablesGlobal.relicRed2Value = 0
        End If

        'if robot is balanced
        If chkBalanceRed2.Checked Then
            oSheet.Cells(15, 7).value = "Yes"
            variablesGlobal.balanceRed2Value = 1
        Else
            oSheet.Cells(15, 7).value = "No"
            variablesGlobal.balanceRed2Value = 0
        End If
    End Sub

    Private Sub zoneBlue1Setup()
        'sets up Red1 variables
        'these if statements make sure if there is no input then the numbers become zero
        'for the excel sheet
        If txtGlyphAutoBlue1.Text = "" Then
            txtGlyphAutoBlue1.Text = "0"
        End If

        If txtGlyphblue1.Text = "" Then
            txtGlyphblue1.Text = "0"
        End If

        If txtRowBlue1.Text = "" Then
            txtRowBlue1.Text = "0"
        End If

        If txtColumnsBlue1.Text = "" Then
            txtColumnsBlue1.Text = "0"
        End If

        If txtRelicBlue1.Text = "" Then
            txtRelicBlue1.Text = "0"
        End If

        'grabs numbers from the strings
        variablesGlobal.glyphAutoBlue1Value = Integer.Parse(txtGlyphAutoBlue1.Text)
        variablesGlobal.glyphTeleOpBlue1Value = Integer.Parse(txtGlyphblue1.Text)
        variablesGlobal.rowBlue1Value = Integer.Parse(txtRowBlue1.Text)
        variablesGlobal.columnBlue1Value = Integer.Parse(txtColumnsBlue1.Text)
        variablesGlobal.relicBlue1Value = Integer.Parse(txtRelicBlue1.Text)

        oSheet.Cells(18, 2).value = txtTeamBlue1.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelBlue1.Checked Then
            oSheet.Cells(20, 2).value = "Yes"
            variablesGlobal.jewelblue1Value = 1
        Else
            oSheet.Cells(20, 2).value = "No"
            variablesGlobal.jewelblue1Value = 0
        End If

        'number of glyps put into box during autonomous
        If variablesGlobal.glyphAutoBlue1Value > 0 Then
            oSheet.Cells(21, 2).value = variablesGlobal.glyphAutoBlue1Value
        Else
            oSheet.Cells(21, 2).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyBlue1.Checked Then
            oSheet.Cells(22, 2).value = "Yes"
            variablesGlobal.cryptoKeyBlue1Value = 1
        Else
            oSheet.Cells(22, 2).value = "No"
            variablesGlobal.cryptoKeyBlue1Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneBlue1.Checked Then
            oSheet.Cells(23, 2).value = "Yes"
            variablesGlobal.safeZoneBlue1value = 1
        Else
            oSheet.Cells(23, 2).value = "No"
            variablesGlobal.safeZoneBlue1value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(25, 2).value = variablesGlobal.glyphTeleOpBlue1Value
        oSheet.Cells(26, 2).value = variablesGlobal.rowBlue1Value
        oSheet.Cells(27, 2).value = variablesGlobal.columnBlue1Value


        'determines if cypher was completed for spread sheet
        If lstPatternBlue1.SelectedIndex > 0 Then
            oSheet.Cells(28, 2).value = lstPatternBlue1.SelectedItem
            variablesGlobal.cypherBlue1Value = 1
        Else
            oSheet.Cells(28, 2).value = "None"
            variablesGlobal.cypherBlue1Value = 0
        End If

        'if relic is in zone at end game
        If variablesGlobal.relicBlue1Value > 0 Then
            oSheet.Cells(30, 2).value = variablesGlobal.relicBlue1Value
        Else
            oSheet.Cells(30, 2).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightBlue1.Checked Then
            oSheet.Cells(31, 2).value = "Yes"
            variablesGlobal.relicBlue1Value = 1
        Else
            oSheet.Cells(31, 2).value = "No"
            variablesGlobal.relicBlue1Value = 0
        End If

        'if robot is balanced
        If chkBalanceBlue1.Checked Then
            oSheet.Cells(32, 2).value = "Yes"
            variablesGlobal.balanceBlue1Value = 1
        Else
            oSheet.Cells(32, 2).value = "No"
            variablesGlobal.balanceBlue1Value = 0
        End If
    End Sub

    Private Sub zoneBlue2Setup()
        'sets up Red1 variables
        'these if statements make sure if there is no input then the numbers become zero
        'for the excel sheet
        If txtGlyphAutoBlue2.Text = "" Then
            txtGlyphAutoBlue2.Text = "0"
        End If

        If txtGlyphblue2.Text = "" Then
            txtGlyphblue2.Text = "0"
        End If

        If txtRowBlue2.Text = "" Then
            txtRowBlue2.Text = "0"
        End If

        If txtColumnsBlue2.Text = "" Then
            txtColumnsBlue2.Text = "0"
        End If

        If txtRelicBlue2.Text = "" Then
            txtRelicBlue2.Text = "0"
        End If

        'grabs numbers from the strings
        variablesGlobal.glyphAutoBlue2Value = Integer.Parse(txtGlyphAutoBlue2.Text)
        variablesGlobal.glyphTeleOpBlue2Value = Integer.Parse(txtGlyphblue2.Text)
        variablesGlobal.rowBlue2Value = Integer.Parse(txtRowBlue2.Text)
        variablesGlobal.columnBlue2Value = Integer.Parse(txtColumnsBlue2.Text)
        variablesGlobal.relicBlue2Value = Integer.Parse(txtRelicBlue2.Text)

        oSheet.Cells(18, 7).value = txtTeamBlue2.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelBlue2.Checked Then
            oSheet.Cells(20, 7).value = "Yes"
            variablesGlobal.jewelBlue2Value = 1
        Else
            oSheet.Cells(20, 7).value = "No"
            variablesGlobal.jewelBlue2Value = 0
        End If

        'number of glyps put into box during autonomous
        If variablesGlobal.glyphAutoBlue2Value > 0 Then
            oSheet.Cells(21, 7).value = variablesGlobal.glyphAutoBlue2Value
        Else
            oSheet.Cells(21, 7).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyBlue2.Checked Then
            oSheet.Cells(22, 7).value = "Yes"
            variablesGlobal.cryptoKeyBlue2Value = 1
        Else
            oSheet.Cells(22, 7).value = "No"
            variablesGlobal.cryptoKeyBlue2Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneBlue2.Checked Then
            oSheet.Cells(23, 7).value = "Yes"
            variablesGlobal.safeZoneBlue2value = 1
        Else
            oSheet.Cells(23, 7).value = "No"
            variablesGlobal.safeZoneBlue2value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(25, 7).value = variablesGlobal.glyphTeleOpBlue2Value
        oSheet.Cells(26, 7).value = variablesGlobal.rowBlue2Value
        oSheet.Cells(27, 7).value = variablesGlobal.columnBlue2Value


        'determines if cypher was completed for spread sheet
        If lstPatternBlue2.SelectedIndex > 0 Then
            oSheet.Cells(28, 7).value = lstPatternBlue2.SelectedItem
            variablesGlobal.cypherBlue2Value = 1
        Else
            oSheet.Cells(28, 7).value = "None"
            variablesGlobal.cypherBlue2Value = 0
        End If

        'if relic is in zone at end game
        If variablesGlobal.relicBlue2Value > 0 Then
            oSheet.Cells(30, 7).value = variablesGlobal.relicBlue2Value
        Else
            oSheet.Cells(30, 7).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightBlue2.Checked Then
            oSheet.Cells(31, 7).value = "Yes"
            variablesGlobal.relicBlue2Value = 1
        Else
            oSheet.Cells(31, 7).value = "No"
            variablesGlobal.relicBlue2Value = 0
        End If

        'if robot is balanced
        If chkBalanceBlue2.Checked Then
            oSheet.Cells(32, 7).value = "Yes"
            variablesGlobal.balanceBlue2Value = 1
        Else
            oSheet.Cells(32, 7).value = "No"
            variablesGlobal.balanceBlue2Value = 0
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
        '15 points for upright relic
        '20 points balanced

        'red 1 auto and tele score
        variablesGlobal.redTeam1AutoScore = (variablesGlobal.jewelRed1Value * 30) + (variablesGlobal.safeZoneRed1value * 10) + (variablesGlobal.cryptoKeyRed1Value * 30) + (variablesGlobal.glyphAutoRed1Value * 15)
        oSheet.Cells(2, 4).value = variablesGlobal.redTeam1AutoScore
        variablesGlobal.redTeam1TeleScore = (variablesGlobal.glyphTeleOpRed1Value * 2) + (variablesGlobal.rowRed1Value * 10) + (variablesGlobal.columnRed1Value * 20) + (variablesGlobal.cypherRed1Value * 30)
        oSheet.Cells(3, 4).value = variablesGlobal.redTeam1TeleScore
        If variablesGlobal.relicRed1Value = 1 Then
            variablesGlobal.relicScoreRed1 = 10
        ElseIf variablesGlobal.relicRed1Value = 2 Then
            variablesGlobal.relicScoreRed1 = 20
        ElseIf variablesGlobal.relicRed1Value = 3 Then
            variablesGlobal.relicScoreRed1 = 40
        Else
            variablesGlobal.relicScoreRed1 = 0
        End If

        'red 2 auto and tele score
        variablesGlobal.redTeam2AutoScore = (variablesGlobal.jewelRed2Value * 30) + (variablesGlobal.safeZoneRed2value * 10) + (variablesGlobal.cryptoKeyRed2Value * 30) + (variablesGlobal.glyphAutoRed2Value * 15)
        oSheet.Cells(2, 9).value = variablesGlobal.redTeam2AutoScore
        variablesGlobal.redTeam2TeleScore = (variablesGlobal.glyphTeleOpRed2Value * 2) + (variablesGlobal.rowRed2Value * 10) + (variablesGlobal.columnRed2Value * 20) + (variablesGlobal.cypherRed2Value * 30)
        oSheet.Cells(3, 9).value = variablesGlobal.redTeam2TeleScore
        If variablesGlobal.relicRed2Value = 1 Then
            variablesGlobal.relicScoreRed2 = 10
        ElseIf variablesGlobal.relicRed2Value = 2 Then
            variablesGlobal.relicScoreRed2 = 20
        ElseIf variablesGlobal.relicRed2Value = 3 Then
            variablesGlobal.relicScoreRed2 = 40
        Else
            variablesGlobal.relicScoreRed2 = 0
        End If

        'blue 1 auto and tele score
        variablesGlobal.blueTeam1AutoScore = (variablesGlobal.jewelblue1Value * 30) + (variablesGlobal.safeZoneBlue1value * 10) + (variablesGlobal.cryptoKeyBlue1Value * 30) + (variablesGlobal.glyphAutoBlue1Value * 15)
        oSheet.Cells(19, 4).value = variablesGlobal.blueTeam1AutoScore
        variablesGlobal.blueTeam1TeleScore = (variablesGlobal.glyphTeleOpBlue1Value * 2) + (variablesGlobal.rowBlue1Value * 10) + (variablesGlobal.columnBlue1Value * 20) + (variablesGlobal.cypherBlue1Value * 30)
        oSheet.Cells(20, 4).value = variablesGlobal.blueTeam1TeleScore
        If variablesGlobal.relicBlue1Value = 1 Then
            variablesGlobal.relicScoreBlue1 = 10
        ElseIf variablesGlobal.relicBlue1Value = 2 Then
            variablesGlobal.relicScoreBlue1 = 20
        ElseIf variablesGlobal.relicBlue1Value = 3 Then
            variablesGlobal.relicScoreBlue1 = 40
        Else
            variablesGlobal.relicScoreBlue1 = 0
        End If

        'blue 2 auto and tele score
        variablesGlobal.blueTeam2AutoScore = (variablesGlobal.jewelBlue2Value * 30) + (variablesGlobal.safeZoneBlue2value * 10) + (variablesGlobal.cryptoKeyBlue2Value * 30) + (variablesGlobal.glyphAutoBlue2Value * 15)
        oSheet.Cells(19, 9).value = variablesGlobal.blueTeam2AutoScore
        variablesGlobal.blueTeam2TeleScore = (variablesGlobal.glyphTeleOpBlue2Value * 2) + (variablesGlobal.rowBlue2Value * 10) + (variablesGlobal.columnBlue2Value * 20) + (variablesGlobal.cypherBlue2Value * 30)
        oSheet.Cells(20, 9).value = variablesGlobal.blueTeam2TeleScore
        If variablesGlobal.relicBlue2Value = 1 Then
            variablesGlobal.relicScoreBlue2 = 10
        ElseIf variablesGlobal.relicBlue2Value = 2 Then
            variablesGlobal.relicScoreBlue2 = 20
        ElseIf variablesGlobal.relicBlue2Value = 3 Then
            variablesGlobal.relicScoreBlue2 = 40
        Else
            variablesGlobal.relicScoreBlue2 = 0
        End If

        'red 1 final scores
        variablesGlobal.redTeam1EndScore = variablesGlobal.relicScoreRed1 + (variablesGlobal.balanceRed1Value * 20) + (variablesGlobal.relicRed1Value * 15)
        oSheet.Cells(4, 4).value = variablesGlobal.redTeam1EndScore
        variablesGlobal.redTeam1FinalScore = variablesGlobal.redTeam1AutoScore + variablesGlobal.redTeam1TeleScore + variablesGlobal.redTeam1EndScore
        oSheet.Cells(5, 4).value = variablesGlobal.redTeam1FinalScore

        'red 2 final scores
        variablesGlobal.redTeam2EndScore = variablesGlobal.relicScoreRed2 + (variablesGlobal.balanceRed2Value * 20) + (variablesGlobal.relicRed2Value * 15)
        oSheet.Cells(4, 9).value = variablesGlobal.redTeam2EndScore
        variablesGlobal.redTeam2FinalScore = variablesGlobal.redTeam2AutoScore + variablesGlobal.redTeam2TeleScore + variablesGlobal.redTeam2EndScore
        oSheet.Cells(5, 9).value = variablesGlobal.redTeam2FinalScore

        'blue 1 final scores
        variablesGlobal.blueTeam1EndScore = variablesGlobal.relicScoreBlue1 + (variablesGlobal.balanceBlue1Value * 20) + (variablesGlobal.relicBlue1Value * 15)
        oSheet.Cells(21, 4).value = variablesGlobal.blueTeam1EndScore
        variablesGlobal.blueTeam1FinalScore = variablesGlobal.blueTeam1AutoScore + variablesGlobal.blueTeam1TeleScore + variablesGlobal.blueTeam1EndScore
        oSheet.Cells(22, 4).value = variablesGlobal.blueTeam1FinalScore

        'blue 2 final scores
        variablesGlobal.blueTeam2EndScore = variablesGlobal.relicScoreBlue2 + (variablesGlobal.balanceBlue2Value * 20) + (variablesGlobal.relicBlue2Value * 15)
        oSheet.Cells(21, 9).value = variablesGlobal.blueTeam2EndScore
        variablesGlobal.blueTeam2FinalScore = variablesGlobal.blueTeam2AutoScore + variablesGlobal.blueTeam2TeleScore + variablesGlobal.blueTeam2EndScore
        oSheet.Cells(22, 9).value = variablesGlobal.blueTeam2FinalScore

        blueAllianceScore = variablesGlobal.blueTeam1FinalScore + variablesGlobal.blueTeam2FinalScore
        redAllianceScore = variablesGlobal.redTeam1FinalScore + variablesGlobal.redTeam2FinalScore
    End Sub

    Private Sub moreThingsforbetterness()
        'add aliance score
        'TODO add notes and other things I think of or told to do.
        oSheet.Cells(2, 11).value = "Red Alliance Score"
        oSheet.Cells(2, 12).value = redAllianceScore
        oSheet.Cells(3, 11).value = "Blue Alliance Score"
        oSheet.Cells(3, 12).value = blueAllianceScore
        oSheet.Cells(2, 14).value = "Notes"
        oSheet.Cells(3, 14).value = "Red Team 1"
        oSheet.Cells(4, 14).value = "Red Team 2"
        oSheet.Cells(5, 14).value = "Blue Team 1"
        oSheet.Cells(6, 14).value = "Blue Team 2"
        If txtNoteRed1.Text = "" Then
            txtNoteRed1.Text = "Nothing"
        End If
        If txtNoteRed2.Text = "" Then
            txtNoteRed2.Text = "Nothing"
        End If
        If txtNoteBlue1.Text = "" Then
            txtNoteBlue1.Text = "Nothing"
        End If
        If txtNoteBlue2.Text = "" Then
            txtNoteBlue2.Text = "Nothing"
        End If
        oSheet.Cells(3, 15).value = "#" + txtTeamRed1.Text + ": " + txtNoteRed1.Text
        oSheet.Cells(4, 15).value = "#" + txtTeamRed2.Text + ": " + txtNoteRed2.Text
        oSheet.Cells(5, 15).value = "#" + txtTeamBlue1.Text + ": " + txtNoteBlue1.Text
        oSheet.Cells(6, 15).value = "#" + txtTeamBlue2.Text + ": " + txtNoteBlue2.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all typeable input
        chkJewelRed1.Checked = False
        txtGlyphAutoRed1.Text = ""
        chkCryptoKeyRed1.Checked = False
        chkSafeZoneRed1.Checked = False
        txtGlyphRed1.Text = ""
        txtRowRed1.Text = ""
        txtColumnsRed1.Text = ""
        lstPatternRed1.SelectedItem = "None"
        txtRelicRed1.Text = ""
        chkBalanceRed1.Checked = False
        txtTeamRed2.Text = ""
        chkJewelRed2.Checked = False
        txtGlyphAutoRed2.Text = ""
        chkCryptoKeyRed2.Checked = False
        chkSafeZoneRed2.Checked = False
        txtGlyphRed2.Text = ""
        txtRowRed2.Text = ""
        txtColumnsRed2.Text = ""
        lstPatternRed2.SelectedItem = "None"
        txtRelicRed2.Text = ""
        chkBalanceRed2.Checked = False
        txtTeamBlue1.Text = ""
        chkJewelBlue1.Checked = False
        txtGlyphAutoBlue1.Text = ""
        chkCryptoKeyBlue1.Checked = False
        chkSafeZoneBlue1.Checked = False
        txtGlyphblue1.Text = ""
        txtRowBlue1.Text = ""
        txtColumnsBlue1.Text = ""
        lstPatternBlue1.SelectedItem = "None"
        txtRelicBlue1.Text = ""
        chkBalanceBlue1.Checked = False
        txtTeamBlue2.Text = ""
        chkJewelBlue2.Checked = False
        txtGlyphAutoBlue2.Text = ""
        chkCryptoKeyBlue2.Checked = False
        chkSafeZoneBlue2.Checked = False
        txtGlyphblue2.Text = ""
        txtRowBlue2.Text = ""
        txtColumnsBlue2.Text = ""
        lstPatternBlue2.SelectedItem = "None"
        txtRelicBlue2.Text = ""
        chkBalanceBlue2.Checked = False
        txtNoteRed1.Text = ""
        txtNoteRed2.Text = ""
        txtNoteBlue1.Text = ""
        txtNoteBlue2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changes window size and places it in center of screen
        Me.Size = New Size(960, 1080)
        Me.CenterToScreen()

        'makes default choice in list None
        lstPatternRed1.SelectedIndex = 0
        lstPatternRed2.SelectedIndex = 0
        lstPatternBlue1.SelectedIndex = 0
        lstPatternBlue2.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes application
        Me.Close()
    End Sub

    Private Sub btnTextDocumentExport_Click(sender As Object, e As EventArgs) Handles btnTextDocumentExport.Click
        If (Not System.IO.Directory.Exists(CurDir() + "\Matches")) Then
            System.IO.Directory.CreateDirectory(CurDir() + "\Matches")
        End If
        textMakermain()
    End Sub

    Private Sub textMakermain()
        textSetupRed1()
        textSetupRed2()
        textSetupBlue1()
        textSetupBlue2()
        textMath()
        matchNumber = txtMatchNumber.Text
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), "Team Number: " + txtTeamRed1.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextRed1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextRed1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextRed1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternRed1.SelectedItem)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextRed1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextRed1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team Number: " + txtTeamRed2.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextRed2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextRed2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextRed2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternRed2.SelectedItem)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextRed2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextRed2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team Number: " + txtTeamBlue1.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextBlue1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextBlue1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextBlue1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternBlue1.SelectedItem)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextBlue1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextBlue1)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team Number: " + txtTeamBlue2.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextBlue2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextBlue2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextBlue2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternBlue2.SelectedItem)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextBlue2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextBlue2)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Scores--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Red Team 1-- " + txtTeamRed1.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.redTeam1AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.redTeam1TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.redTeam1EndScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.redTeam1FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Red Team 2-- " + txtTeamRed2.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.redTeam2AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.redTeam2TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.redTeam2EndScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.redTeam2FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Blue Team 1-- " + txtTeamBlue1.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.blueTeam1AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.blueTeam1TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.blueTeam1EndScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.blueTeam1FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Blue Team 2-- " + txtTeamBlue2.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.blueTeam2AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.blueTeam2TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.blueTeam2EndScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.blueTeam2FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "RED ALIANCE SCORE:" + redAllianceScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "BLUE ALLIANCE SCORE: " + blueAllianceScore.ToString)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "--Notes--")
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team #" + txtTeamRed1.Text + ": " + txtNoteRed1.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team #" + txtTeamRed2.Text + ": " + txtNoteRed2.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team #" + txtTeamBlue1.Text + ": " + txtNoteBlue1.Text)
        File.AppendAllText((CurDir() + "\Matches\Match" + matchNumber + ".txt"), Environment.NewLine + "Team #" + txtTeamBlue2.Text + ": " + txtNoteBlue2.Text)

    End Sub

    Private Sub textMath()
        'Red1
        variablesGlobal.redTeam1AutoScore = (variablesGlobal.jewelRed1Value * 30) + (variablesGlobal.safeZoneRed1value * 10) + (variablesGlobal.cryptoKeyRed1Value * 30) + (variablesGlobal.glyphAutoRed1Value * 15)
        variablesGlobal.redTeam1TeleScore = (variablesGlobal.glyphTeleOpRed1Value * 2) + (variablesGlobal.rowRed1Value * 10) + (variablesGlobal.columnRed1Value * 20) + (variablesGlobal.cypherRed1Value * 30)
        If variablesGlobal.relicRed1Value = 1 Then
            variablesGlobal.relicScoreRed1 = 10
        ElseIf variablesGlobal.relicRed1Value = 2 Then
            variablesGlobal.relicScoreRed1 = 20
        ElseIf variablesGlobal.relicRed1Value = 3 Then
            variablesGlobal.relicScoreRed1 = 40
        Else
            variablesGlobal.relicScoreRed1 = 0
        End If
        variablesGlobal.redTeam1EndScore = variablesGlobal.relicScoreRed1 + (variablesGlobal.balanceRed1Value * 20) + (variablesGlobal.relicRed1Value * 15)
        variablesGlobal.redTeam1FinalScore = variablesGlobal.redTeam1AutoScore + variablesGlobal.redTeam1TeleScore + variablesGlobal.redTeam1EndScore

        'Red2
        variablesGlobal.redTeam2AutoScore = (variablesGlobal.jewelRed2Value * 30) + (variablesGlobal.safeZoneRed2value * 10) + (variablesGlobal.cryptoKeyRed2Value * 30) + (variablesGlobal.glyphAutoRed2Value * 15)
        variablesGlobal.redTeam2TeleScore = (variablesGlobal.glyphTeleOpRed2Value * 2) + (variablesGlobal.rowRed2Value * 10) + (variablesGlobal.columnRed2Value * 20) + (variablesGlobal.cypherRed2Value * 30)
        If variablesGlobal.relicRed2Value = 1 Then
            variablesGlobal.relicScoreRed2 = 10
        ElseIf variablesGlobal.relicRed2Value = 2 Then
            variablesGlobal.relicScoreRed2 = 20
        ElseIf variablesGlobal.relicRed2Value = 3 Then
            variablesGlobal.relicScoreRed2 = 40
        Else
            variablesGlobal.relicScoreRed2 = 0
        End If
        variablesGlobal.redTeam2EndScore = variablesGlobal.relicScoreRed2 + (variablesGlobal.balanceRed2Value * 20) + (variablesGlobal.relicRed2Value * 15)
        variablesGlobal.redTeam2FinalScore = variablesGlobal.redTeam2AutoScore + variablesGlobal.redTeam2TeleScore + variablesGlobal.redTeam2EndScore

        'Blue1
        variablesGlobal.blueTeam1AutoScore = (variablesGlobal.jewelblue1Value * 30) + (variablesGlobal.safeZoneBlue1value * 10) + (variablesGlobal.cryptoKeyBlue1Value * 30) + (variablesGlobal.glyphAutoBlue1Value * 15)
        variablesGlobal.blueTeam1TeleScore = (variablesGlobal.glyphTeleOpBlue1Value * 2) + (variablesGlobal.rowBlue1Value * 10) + (variablesGlobal.columnBlue1Value * 20) + (variablesGlobal.cypherBlue1Value * 30)
        If variablesGlobal.relicBlue1Value = 1 Then
            variablesGlobal.relicScoreBlue1 = 10
        ElseIf variablesGlobal.relicBlue1Value = 2 Then
            variablesGlobal.relicScoreBlue1 = 20
        ElseIf variablesGlobal.relicBlue1Value = 3 Then
            variablesGlobal.relicScoreBlue1 = 40
        Else
            variablesGlobal.relicScoreBlue1 = 0
        End If
        variablesGlobal.blueTeam1EndScore = variablesGlobal.relicScoreBlue1 + (variablesGlobal.balanceBlue1Value * 20) + (variablesGlobal.relicBlue1Value * 15)
        variablesGlobal.blueTeam1FinalScore = variablesGlobal.blueTeam1AutoScore + variablesGlobal.blueTeam1TeleScore + variablesGlobal.blueTeam1EndScore

        'Bllue2
        variablesGlobal.blueTeam2AutoScore = (variablesGlobal.jewelBlue2Value * 30) + (variablesGlobal.safeZoneBlue2value * 10) + (variablesGlobal.cryptoKeyBlue2Value * 30) + (variablesGlobal.glyphAutoBlue2Value * 15)
        variablesGlobal.blueTeam2TeleScore = (variablesGlobal.glyphTeleOpBlue2Value * 2) + (variablesGlobal.rowBlue2Value * 10) + (variablesGlobal.columnBlue2Value * 20) + (variablesGlobal.cypherBlue2Value * 30)
        If variablesGlobal.relicBlue2Value = 1 Then
            variablesGlobal.relicScoreBlue2 = 10
        ElseIf variablesGlobal.relicBlue2Value = 2 Then
            variablesGlobal.relicScoreBlue2 = 20
        ElseIf variablesGlobal.relicBlue2Value = 3 Then
            variablesGlobal.relicScoreBlue2 = 40
        Else
            variablesGlobal.relicScoreBlue2 = 0
        End If
        variablesGlobal.blueTeam2EndScore = variablesGlobal.relicScoreBlue2 + (variablesGlobal.balanceBlue2Value * 20) + (variablesGlobal.relicBlue2Value * 15)
        variablesGlobal.blueTeam2FinalScore = variablesGlobal.blueTeam2AutoScore + variablesGlobal.blueTeam2TeleScore + variablesGlobal.blueTeam2EndScore

        'Alliance Score
        blueAllianceScore = variablesGlobal.blueTeam1FinalScore + variablesGlobal.blueTeam2FinalScore
        redAllianceScore = variablesGlobal.redTeam1FinalScore + variablesGlobal.redTeam2FinalScore
    End Sub

    Private Sub textSetupRed1()
        variablesGlobal.glyphAutoRed1Value = Integer.Parse(txtGlyphAutoRed1.Text)
        variablesGlobal.glyphTeleOpRed1Value = Integer.Parse(txtGlyphRed1.Text)
        variablesGlobal.rowRed1Value = Integer.Parse(txtRowRed1.Text)
        variablesGlobal.columnRed1Value = Integer.Parse(txtColumnsRed1.Text)
        variablesGlobal.relicRed1Value = Integer.Parse(txtRelicRed1.Text)

        If chkJewelRed1.Checked Then
            variablesGlobal.jewelTextRed1 = "Yes"
            variablesGlobal.jewelRed1Value = 1
        Else
            variablesGlobal.jewelTextRed1 = "No"
            variablesGlobal.jewelRed1Value = 0
        End If

        If chkCryptoKeyRed1.Checked Then
            variablesGlobal.cryptoTextRed1 = "Yes"
            variablesGlobal.cryptoKeyRed1Value = 1
        Else
            variablesGlobal.cryptoTextRed1 = "No"
            variablesGlobal.cryptoKeyRed1Value = 0
        End If

        If chkSafeZoneRed1.Checked Then
            variablesGlobal.safeZoneTextRed1 = "Yes"
            variablesGlobal.safeZoneRed1value = 1
        Else
            variablesGlobal.safeZoneTextRed1 = "No"
            variablesGlobal.safeZoneRed1value = 0
        End If

        If chkRelicUprightRed1.Checked Then
            variablesGlobal.relicUprightTextRed1 = "Yes"
            variablesGlobal.relicRed1Value = 1
        Else
            variablesGlobal.relicUprightTextRed1 = "No"
            variablesGlobal.relicRed1Value = 0
        End If

        If chkBalanceRed1.Checked Then
            variablesGlobal.balancedTextRed1 = "Yes"
            variablesGlobal.balanceRed1Value = 1
        Else
            variablesGlobal.balancedTextRed1 = "No"
            variablesGlobal.balanceRed1Value = 0
        End If
    End Sub

    Private Sub textSetupRed2()
        variablesGlobal.glyphAutoRed2Value = Integer.Parse(txtGlyphAutoRed2.Text)
        variablesGlobal.glyphTeleOpRed2Value = Integer.Parse(txtGlyphRed2.Text)
        variablesGlobal.rowRed2Value = Integer.Parse(txtRowRed2.Text)
        variablesGlobal.columnRed2Value = Integer.Parse(txtColumnsRed2.Text)
        variablesGlobal.relicRed2Value = Integer.Parse(txtRelicRed2.Text)

        If chkJewelRed2.Checked Then
            variablesGlobal.jewelTextRed2 = "Yes"
            variablesGlobal.jewelRed2Value = 1
        Else
            variablesGlobal.jewelTextRed2 = "No"
            variablesGlobal.jewelRed2Value = 0
        End If

        If chkCryptoKeyRed2.Checked Then
            variablesGlobal.cryptoTextRed2 = "Yes"
            variablesGlobal.cryptoKeyRed2Value = 1
        Else
            variablesGlobal.cryptoTextRed2 = "No"
            variablesGlobal.cryptoKeyRed2Value = 0
        End If

        If chkSafeZoneRed2.Checked Then
            variablesGlobal.safeZoneTextRed2 = "Yes"
            variablesGlobal.safeZoneRed2value = 1
        Else
            variablesGlobal.safeZoneTextRed2 = "No"
            variablesGlobal.safeZoneRed2value = 0
        End If

        If chkRelicUprightRed2.Checked Then
            variablesGlobal.relicUprightTextRed2 = "Yes"
            variablesGlobal.relicRed2Value = 1
        Else
            variablesGlobal.relicUprightTextRed2 = "No"
            variablesGlobal.relicRed2Value = 0
        End If

        If chkBalanceRed2.Checked Then
            variablesGlobal.balancedTextRed2 = "Yes"
            variablesGlobal.balanceRed2Value = 1
        Else
            variablesGlobal.balancedTextRed2 = "No"
            variablesGlobal.balanceRed2Value = 0
        End If
    End Sub

    Private Sub textSetupBlue1()
        variablesGlobal.glyphAutoBlue1Value = Integer.Parse(txtGlyphAutoBlue1.Text)
        variablesGlobal.glyphTeleOpBlue1Value = Integer.Parse(txtGlyphblue1.Text)
        variablesGlobal.rowBlue1Value = Integer.Parse(txtRowBlue1.Text)
        variablesGlobal.columnBlue1Value = Integer.Parse(txtColumnsBlue1.Text)
        variablesGlobal.relicBlue1Value = Integer.Parse(txtRelicBlue1.Text)

        If chkJewelBlue1.Checked Then
            variablesGlobal.jewelTextBlue1 = "Yes"
            variablesGlobal.jewelblue1Value = 1
        Else
            variablesGlobal.jewelTextBlue1 = "No"
            variablesGlobal.jewelblue1Value = 0
        End If

        If chkCryptoKeyBlue1.Checked Then
            variablesGlobal.cryptoTextBlue1 = "Yes"
            variablesGlobal.cryptoKeyBlue1Value = 1
        Else
            variablesGlobal.cryptoTextBlue1 = "No"
            variablesGlobal.cryptoKeyBlue1Value = 0
        End If

        If chkSafeZoneBlue1.Checked Then
            variablesGlobal.safeZoneTextBlue1 = "Yes"
            variablesGlobal.safeZoneBlue1value = 1
        Else
            variablesGlobal.safeZoneTextBlue1 = "No"
            variablesGlobal.safeZoneBlue1value = 0
        End If

        If chkRelicUprightBlue1.Checked Then
            variablesGlobal.relicUprightTextBlue1 = "Yes"
            variablesGlobal.relicBlue1Value = 1
        Else
            variablesGlobal.relicUprightTextBlue1 = "No"
            variablesGlobal.relicBlue1Value = 0
        End If

        If chkBalanceBlue1.Checked Then
            variablesGlobal.balancedTextBlue1 = "Yes"
            variablesGlobal.balanceBlue1Value = 1
        Else
            variablesGlobal.balancedTextBlue1 = "No"
            variablesGlobal.balanceBlue1Value = 0
        End If
    End Sub

    Private Sub textSetupBlue2()
        variablesGlobal.glyphAutoBlue2Value = Integer.Parse(txtGlyphAutoBlue2.Text)
        variablesGlobal.glyphTeleOpBlue2Value = Integer.Parse(txtGlyphblue2.Text)
        variablesGlobal.rowBlue2Value = Integer.Parse(txtRowBlue2.Text)
        variablesGlobal.columnBlue2Value = Integer.Parse(txtColumnsBlue2.Text)
        variablesGlobal.relicBlue2Value = Integer.Parse(txtRelicBlue2.Text)

        If chkJewelBlue2.Checked Then
            variablesGlobal.jewelTextBlue2 = "Yes"
            variablesGlobal.jewelBlue2Value = 1
        Else
            variablesGlobal.jewelTextBlue2 = "No"
            variablesGlobal.jewelBlue2Value = 0
        End If

        If chkCryptoKeyBlue2.Checked Then
            variablesGlobal.cryptoTextBlue2 = "Yes"
            variablesGlobal.cryptoKeyBlue2Value = 1
        Else
            variablesGlobal.cryptoTextBlue2 = "No"
            variablesGlobal.cryptoKeyBlue2Value = 0
        End If

        If chkSafeZoneBlue2.Checked Then
            variablesGlobal.safeZoneTextBlue2 = "Yes"
            variablesGlobal.safeZoneBlue2value = 1
        Else
            variablesGlobal.safeZoneTextBlue2 = "No"
            variablesGlobal.safeZoneBlue2value = 0
        End If

        If chkRelicUprightBlue2.Checked Then
            variablesGlobal.relicUprightTextBlue2 = "Yes"
            variablesGlobal.relicBlue2Value = 1
        Else
            variablesGlobal.relicUprightTextBlue2 = "No"
            variablesGlobal.relicBlue2Value = 0
        End If

        If chkBalanceBlue2.Checked Then
            variablesGlobal.balancedTextBlue2 = "Yes"
            variablesGlobal.balanceBlue2Value = 1
        Else
            variablesGlobal.balancedTextBlue2 = "No"
            variablesGlobal.balanceBlue2Value = 0
        End If
    End Sub
End Class
