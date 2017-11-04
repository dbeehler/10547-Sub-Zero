Imports Microsoft.Office.Interop

Public Class Form1
    'global variables
    Dim oXL As Excel.Application
    Dim oWB As Excel.Workbook
    Dim oSheet As Excel.Worksheet
    Dim oRng As Excel.Range

    Dim matchNumber As String
    Dim redAllianceScore As Integer
    Dim blueAllianceScore As Integer

    'variables for Red1
    Dim glyphAutoRed1Value As Integer
    Dim jewelRed1Value As Integer
    Dim safeZoneRed1value As Integer
    Dim cryptoKeyRed1Value As Integer
    Dim glyphTeleOpRed1Value As Integer
    Dim rowRed1Value As Integer
    Dim columnRed1Value As Integer
    Dim cypherRed1Value As Integer
    Dim balanceRed1Value As Integer
    Dim relicRed1Value As Integer

    'variables for Red2
    Dim glyphAutoRed2Value As Integer
    Dim jewelRed2Value As Integer
    Dim safeZoneRed2value As Integer
    Dim cryptoKeyRed2Value As Integer
    Dim glyphTeleOpRed2Value As Integer
    Dim rowRed2Value As Integer
    Dim columnRed2Value As Integer
    Dim cypherRed2Value As Integer
    Dim balanceRed2Value As Integer
    Dim relicRed2Value As Integer

    'variables for Blue1
    Dim glyphAutoBlue1Value As Integer
    Dim jewelblue1Value As Integer
    Dim safeZoneBlue1value As Integer
    Dim cryptoKeyBlue1Value As Integer
    Dim glyphTeleOpBlue1Value As Integer
    Dim rowBlue1Value As Integer
    Dim columnBlue1Value As Integer
    Dim cypherBlue1Value As Integer
    Dim balanceBlue1Value As Integer
    Dim relicBlue1Value As Integer

    'variables for Blue2
    Dim glyphAutoBlue2Value As Integer
    Dim jewelBlue2Value As Integer
    Dim safeZoneBlue2value As Integer
    Dim cryptoKeyBlue2Value As Integer
    Dim glyphTeleOpBlue2Value As Integer
    Dim rowBlue2Value As Integer
    Dim columnBlue2Value As Integer
    Dim cypherBlue2Value As Integer
    Dim balanceBlue2Value As Integer
    Dim relicBlue2Value As Integer

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
        zoneRed2Setup()
        zoneBlue1Setup()
        zoneBlue2Setup()
        finalMath()
        moreThingsforbetterness()
        'makes coloums look nicer
        oSheet.Columns("A:Z").AutoFit

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
        'MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
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
        glyphAutoRed1Value = Integer.Parse(txtGlyphAutoRed1.Text)
        glyphTeleOpRed1Value = Integer.Parse(txtGlyphRed1.Text)
        rowRed1Value = Integer.Parse(txtRowRed1.Text)
        columnRed1Value = Integer.Parse(txtColumnsRed1.Text)
        relicRed1Value = Integer.Parse(txtRelicRed1.Text)

        oSheet.Cells(1, 2).value = txtTeamRed1.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelRed1.Checked Then
            oSheet.Cells(3, 2).value = "Yes"
            jewelRed1Value = 1
        Else
            oSheet.Cells(3, 2).value = "No"
            jewelRed1Value = 0
        End If

        'number of glyps put into box during autonomous
        If glyphAutoRed1Value > 0 Then
            oSheet.Cells(4, 2).value = glyphAutoRed1Value
        Else
            oSheet.Cells(4, 2).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyRed1.Checked Then
            oSheet.Cells(5, 2).value = "Yes"
            cryptoKeyRed1Value = 1
        Else
            oSheet.Cells(5, 2).value = "No"
            cryptoKeyRed1Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneRed1.Checked Then
            oSheet.Cells(6, 2).value = "Yes"
            safeZoneRed1value = 1
        Else
            oSheet.Cells(6, 2).value = "No"
            safeZoneRed1value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(8, 2).value = glyphTeleOpRed1Value
        oSheet.Cells(9, 2).value = rowRed1Value
        oSheet.Cells(10, 2).value = columnRed1Value


        'determines if cypher was completed for spread sheet
        If lstPatternRed1.SelectedIndex > 0 Then
            oSheet.Cells(11, 2).value = lstPatternRed1.SelectedItem
            cypherRed1Value = 1
        Else
            oSheet.Cells(11, 2).value = "None"
            cypherRed1Value = 0
        End If

        'if relic is in zone at end game
        If relicRed1Value > 0 Then
            oSheet.Cells(13, 2).value = relicRed1Value
        Else
            oSheet.Cells(13, 2).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightRed1.Checked Then
            oSheet.Cells(14, 2).value = "Yes"
            relicRed1Value = 1
        Else
            oSheet.Cells(14, 2).value = "No"
            relicRed1Value = 0
        End If

        'if robot is balanced
        If chkBalanceRed1.Checked Then
            oSheet.Cells(15, 2).value = "Yes"
            balanceRed1Value = 1
        Else
            oSheet.Cells(15, 2).value = "No"
            balanceRed1Value = 0
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
        glyphAutoRed2Value = Integer.Parse(txtGlyphAutoRed2.Text)
        glyphTeleOpRed2Value = Integer.Parse(txtGlyphRed2.Text)
        rowRed2Value = Integer.Parse(txtRowRed2.Text)
        columnRed2Value = Integer.Parse(txtColumnsRed2.Text)
        relicRed2Value = Integer.Parse(txtRelicRed2.Text)

        'prints team number
        oSheet.Cells(1, 7).value = txtTeamRed2.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelRed2.Checked Then
            oSheet.Cells(3, 7).value = "Yes"
            jewelRed2Value = 1
        Else
            oSheet.Cells(3, 7).value = "No"
            jewelRed2Value = 0
        End If

        'number of glyps put into box during autonomous
        If glyphAutoRed2Value > 0 Then
            oSheet.Cells(4, 7).value = glyphAutoRed2Value
        Else
            oSheet.Cells(4, 7).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyRed2.Checked Then
            oSheet.Cells(5, 7).value = "Yes"
            cryptoKeyRed2Value = 1
        Else
            oSheet.Cells(5, 7).value = "No"
            cryptoKeyRed2Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneRed2.Checked Then
            oSheet.Cells(6, 7).value = "Yes"
            safeZoneRed2value = 1
        Else
            oSheet.Cells(6, 7).value = "No"
            safeZoneRed2value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(8, 7).value = glyphTeleOpRed2Value
        oSheet.Cells(9, 7).value = rowRed2Value
        oSheet.Cells(10, 7).value = columnRed2Value

        'determines if cypher was completed for spread sheet
        If lstPatternRed2.SelectedIndex > 0 Then
            oSheet.Cells(11, 7).value = lstPatternRed2.SelectedItem
            cypherRed2Value = 1
        Else
            oSheet.Cells(11, 7).value = "None"
            cypherRed2Value = 0
        End If

        'if relic is in zone at end game
        If relicRed2Value > 0 Then
            oSheet.Cells(13, 7).value = relicRed2Value
        Else
            oSheet.Cells(13, 7).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightRed2.Checked Then
            oSheet.Cells(14, 7).value = "Yes"
            relicRed2Value = 1
        Else
            oSheet.Cells(14, 7).value = "No"
            relicRed2Value = 0
        End If

        'if robot is balanced
        If chkBalanceRed2.Checked Then
            oSheet.Cells(15, 7).value = "Yes"
            balanceRed2Value = 1
        Else
            oSheet.Cells(15, 7).value = "No"
            balanceRed2Value = 0
        End If
    End Sub

    Private Sub zoneBlue1Setup()
        'sets up Red1 variables
        'these if statements make sure if there is no input then the numbers become zero
        'for the excel sheet
        If txtGlyphAutoBlue1.Text = "" Then
            txtGlyphAutoBlue1.Text = "0"
        End If

        If txtGlyphBlue1.Text = "" Then
            txtGlyphBlue1.Text = "0"
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
        glyphAutoBlue1Value = Integer.Parse(txtGlyphAutoBlue1.Text)
        glyphTeleOpBlue1Value = Integer.Parse(txtGlyphBlue1.Text)
        rowBlue1Value = Integer.Parse(txtRowBlue1.Text)
        columnBlue1Value = Integer.Parse(txtColumnsBlue1.Text)
        relicBlue1Value = Integer.Parse(txtRelicBlue1.Text)

        oSheet.Cells(18, 2).value = txtTeamBlue1.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelBlue1.Checked Then
            oSheet.Cells(20, 2).value = "Yes"
            jewelblue1Value = 1
        Else
            oSheet.Cells(20, 2).value = "No"
            jewelblue1Value = 0
        End If

        'number of glyps put into box during autonomous
        If glyphAutoBlue1Value > 0 Then
            oSheet.Cells(21, 2).value = glyphAutoBlue1Value
        Else
            oSheet.Cells(21, 2).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyBlue1.Checked Then
            oSheet.Cells(22, 2).value = "Yes"
            cryptoKeyBlue1Value = 1
        Else
            oSheet.Cells(22, 2).value = "No"
            cryptoKeyBlue1Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneBlue1.Checked Then
            oSheet.Cells(23, 2).value = "Yes"
            safeZoneBlue1value = 1
        Else
            oSheet.Cells(23, 2).value = "No"
            safeZoneBlue1value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(25, 2).value = glyphTeleOpBlue1Value
        oSheet.Cells(26, 2).value = rowBlue1Value
        oSheet.Cells(27, 2).value = columnBlue1Value


        'determines if cypher was completed for spread sheet
        If lstPatternBlue1.SelectedIndex > 0 Then
            oSheet.Cells(28, 2).value = lstPatternBlue1.SelectedItem
            cypherBlue1Value = 1
        Else
            oSheet.Cells(28, 2).value = "None"
            cypherBlue1Value = 0
        End If

        'if relic is in zone at end game
        If relicBlue1Value > 0 Then
            oSheet.Cells(30, 2).value = relicBlue1Value
        Else
            oSheet.Cells(30, 2).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightBlue1.Checked Then
            oSheet.Cells(31, 2).value = "Yes"
            relicBlue1Value = 1
        Else
            oSheet.Cells(31, 2).value = "No"
            relicBlue1Value = 0
        End If

        'if robot is balanced
        If chkBalanceBlue1.Checked Then
            oSheet.Cells(32, 2).value = "Yes"
            balanceBlue1Value = 1
        Else
            oSheet.Cells(32, 2).value = "No"
            balanceBlue1Value = 0
        End If
    End Sub

    Private Sub zoneBlue2Setup()
        'sets up Red1 variables
        'these if statements make sure if there is no input then the numbers become zero
        'for the excel sheet
        If txtGlyphAutoBlue2.Text = "" Then
            txtGlyphAutoBlue2.Text = "0"
        End If

        If txtGlyphBlue2.Text = "" Then
            txtGlyphBlue2.Text = "0"
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
        glyphAutoBlue2Value = Integer.Parse(txtGlyphAutoBlue2.Text)
        glyphTeleOpBlue2Value = Integer.Parse(txtGlyphBlue2.Text)
        rowBlue2Value = Integer.Parse(txtRowBlue2.Text)
        columnBlue2Value = Integer.Parse(txtColumnsBlue2.Text)
        relicBlue2Value = Integer.Parse(txtRelicBlue2.Text)

        oSheet.Cells(18, 7).value = txtTeamBlue2.Text

        'if statements for math at the end
        'autnomous jewel knockdown
        If chkJewelBlue2.Checked Then
            oSheet.Cells(20, 7).value = "Yes"
            jewelBlue2Value = 1
        Else
            oSheet.Cells(20, 7).value = "No"
            jewelBlue2Value = 0
        End If

        'number of glyps put into box during autonomous
        If glyphAutoBlue2Value > 0 Then
            oSheet.Cells(21, 7).value = glyphAutoBlue2Value
        Else
            oSheet.Cells(21, 7).value = "0"
        End If

        'if crypto key is correct
        If chkCryptoKeyBlue2.Checked Then
            oSheet.Cells(22, 7).value = "Yes"
            cryptoKeyBlue2Value = 1
        Else
            oSheet.Cells(22, 7).value = "No"
            cryptoKeyBlue2Value = 0
        End If

        'if they are parked in safezzone
        If chkSafeZoneBlue2.Checked Then
            oSheet.Cells(23, 7).value = "Yes"
            safeZoneBlue2value = 1
        Else
            oSheet.Cells(23, 7).value = "No"
            safeZoneBlue2value = 0
        End If

        'creates cells dealing with the glyphs.
        oSheet.Cells(25, 7).value = glyphTeleOpBlue2Value
        oSheet.Cells(26, 7).value = rowBlue2Value
        oSheet.Cells(27, 7).value = columnBlue2Value


        'determines if cypher was completed for spread sheet
        If lstPatternBlue2.SelectedIndex > 0 Then
            oSheet.Cells(28, 7).value = lstPatternBlue2.SelectedItem
            cypherBlue2Value = 1
        Else
            oSheet.Cells(28, 7).value = "None"
            cypherBlue2Value = 0
        End If

        'if relic is in zone at end game
        If relicBlue2Value > 0 Then
            oSheet.Cells(30, 7).value = relicBlue2Value
        Else
            oSheet.Cells(30, 7).value = "None"
        End If

        'if relic is upright
        If chkRelicUprightBlue2.Checked Then
            oSheet.Cells(31, 7).value = "Yes"
            relicBlue2Value = 1
        Else
            oSheet.Cells(31, 7).value = "No"
            relicBlue2Value = 0
        End If

        'if robot is balanced
        If chkBalanceBlue2.Checked Then
            oSheet.Cells(32, 7).value = "Yes"
            balanceBlue2Value = 1
        Else
            oSheet.Cells(32, 7).value = "No"
            balanceBlue2Value = 0
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

        Dim redTeam1AutoScore As Integer
        Dim redTeam1TeleScore As Integer
        Dim redTeam1EndScore As Integer
        Dim redTeam1FinalScore As Integer
        Dim relicScoreRed1 As Integer

        Dim redTeam2AutoScore As Integer
        Dim redTeam2TeleScore As Integer
        Dim redTeam2EndScore As Integer
        Dim redTeam2FinalScore As Integer
        Dim relicScoreRed2 As Integer

        Dim blueTeam1AutoScore As Integer
        Dim blueTeam1TeleScore As Integer
        Dim blueTeam1EndScore As Integer
        Dim blueTeam1FinalScore As Integer
        Dim relicScoreBlue1 As Integer

        Dim blueTeam2AutoScore As Integer
        Dim blueTeam2TeleScore As Integer
        Dim blueTeam2EndScore As Integer
        Dim blueTeam2FinalScore As Integer
        Dim relicScoreBlue2 As Integer

        'red 1 auto and tele score
        redTeam1AutoScore = (jewelRed1Value * 30) + (safeZoneRed1value * 10) + (cryptoKeyRed1Value * 30) + (glyphAutoRed1Value * 15)
        oSheet.Cells(2, 4).value = redteam1AutoScore
        redTeam1TeleScore = (glyphTeleOpRed1Value * 2) + (rowRed1Value * 10) + (columnRed1Value * 20) + (cypherRed1Value * 30)
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

        'red 2 auto and tele score
        redteam2AutoScore = (jewelRed2Value * 30) + (safeZoneRed2value * 10) + (cryptoKeyRed2Value * 30) + (glyphAutoRed2Value * 15)
        oSheet.Cells(2, 9).value = redteam2AutoScore
        redTeam2TeleScore = (glyphTeleOpRed2Value * 2) + (rowRed2Value * 10) + (columnRed2Value * 20) + (cypherRed2Value * 30)
        oSheet.Cells(3, 9).value = redTeam2TeleScore
        If relicRed2Value = 1 Then
            relicScoreRed2 = 10
        ElseIf relicRed2Value = 2 Then
            relicScoreRed2 = 20
        ElseIf relicRed2Value = 3 Then
            relicScoreRed2 = 40
        Else
            relicScoreRed2 = 0
        End If

        'blue 1 auto and tele score
        blueTeam1AutoScore = (jewelblue1Value * 30) + (safeZoneBlue1value * 10) + (cryptoKeyBlue1Value * 30) + (glyphAutoBlue1Value * 15)
        oSheet.Cells(19, 4).value = blueTeam1AutoScore
        blueTeam1TeleScore = (glyphTeleOpBlue1Value * 2) + (rowBlue1Value * 10) + (columnBlue1Value * 20) + (cypherBlue1Value * 30)
        oSheet.Cells(20, 4).value = blueTeam1TeleScore
        If relicBlue1Value = 1 Then
            relicScoreBlue1 = 10
        ElseIf relicBlue1Value = 2 Then
            relicScoreBlue1 = 20
        ElseIf relicBlue1Value = 3 Then
            relicScoreBlue1 = 40
        Else
            relicScoreBlue1 = 0
        End If

        'blue 2 auto and tele score
        blueTeam2AutoScore = (jewelBlue2Value * 30) + (safeZoneBlue2value * 10) + (cryptoKeyBlue2Value * 30) + (glyphAutoBlue2Value * 15)
        oSheet.Cells(19, 9).value = blueTeam2AutoScore
        blueTeam2TeleScore = (glyphTeleOpBlue2Value * 2) + (rowBlue2Value * 10) + (columnBlue2Value * 20) + (cypherBlue2Value * 30)
        oSheet.Cells(20, 9).value = blueTeam2TeleScore
        If relicBlue2Value = 1 Then
            relicScoreBlue2 = 10
        ElseIf relicBlue2Value = 2 Then
            relicScoreBlue2 = 20
        ElseIf relicBlue2Value = 3 Then
            relicScoreBlue2 = 40
        Else
            relicScoreBlue2 = 0
        End If

        'red 1 final scores
        redTeam1EndScore = relicScoreRed1 + (balanceRed1Value * 20) + (relicRed1Value * 15)
        oSheet.Cells(4, 4).value = redTeam1EndScore
        redTeam1FinalScore = redteam1AutoScore + redTeam1TeleScore + redTeam1EndScore
        oSheet.Cells(5, 4).value = redTeam1FinalScore

        'red 2 final scores
        redTeam2EndScore = relicScoreRed2 + (balanceRed2Value * 20) + (relicRed2Value * 15)
        oSheet.Cells(4, 9).value = redTeam2EndScore
        redTeam2FinalScore = redteam2AutoScore + redTeam2TeleScore + redTeam2EndScore
        oSheet.Cells(5, 9).value = redTeam2FinalScore

        'blue 1 final scores
        blueTeam1EndScore = relicScoreBlue1 + (balanceBlue1Value * 20) + (relicBlue1Value * 15)
        oSheet.Cells(21, 4).value = blueTeam1EndScore
        blueTeam1FinalScore = blueTeam1AutoScore + blueTeam1TeleScore + blueTeam1EndScore
        oSheet.Cells(22, 4).value = blueTeam1FinalScore

        'blue 2 final scores
        blueTeam2EndScore = relicScoreBlue2 + (balanceBlue2Value * 20) + (relicBlue2Value * 15)
        oSheet.Cells(21, 9).value = blueTeam2EndScore
        blueTeam2FinalScore = blueTeam2AutoScore + blueTeam2TeleScore + blueTeam2EndScore
        oSheet.Cells(22, 9).value = blueTeam2FinalScore

        blueAllianceScore = blueTeam1FinalScore + blueTeam2FinalScore
        redAllianceScore = redTeam1FinalScore + redTeam2FinalScore
    End Sub

    Private Sub moreThingsforbetterness()
        'add aliance score
        'TODO add notes and other things I think of or told to do.
        oSheet.Cells(2, 11).value = "Red Alliance Score"
        oSheet.Cells(2, 12).value = redAllianceScore
        oSheet.Cells(3, 11).value = "Blue Alliance Score"
        oSheet.Cells(3, 12).value = blueAllianceScore
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all typeable input
        txtTeamRed1.Text = ""
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
        txtGlyphBlue1.Text = ""
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
        txtGlyphBlue2.Text = ""
        txtRowBlue2.Text = ""
        txtColumnsBlue2.Text = ""
        lstPatternBlue2.SelectedItem = "None"
        txtRelicBlue2.Text = ""
        chkBalanceBlue2.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changes window size and places it in center of screen
        Me.Size = New Size(925, 885)
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
End Class
