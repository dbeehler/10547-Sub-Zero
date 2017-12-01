Imports Microsoft.Office.Interop
Imports System.IO
'Made my Dusty Beehler
'November 4, 2017
'Mortal Combots FTC #10547 2017 - 2018 Season
'Version 1.0
'Text Export

Public Class TextExporter

    'updates databse with entries
    Public Sub updateDatabase()
        rankingsForm.Visible = True
        rankingsForm.Match_NumberTextBox.Text = variablesGlobal.matchNumber
        rankingsForm.Team_NumberTextBox.Text = cmboRed1.SelectedItem
        rankingsForm.Auto_ScoreTextBox.Text = variablesGlobal.redTeam1AutoScore
        rankingsForm.TeleOp_ScoreTextBox.Text = variablesGlobal.redTeam1TeleScore
        rankingsForm.End_ScoreTextBox.Text = variablesGlobal.redTeam1EndScore
        rankingsForm.Total_ScoreTextBox.Text = variablesGlobal.redTeam1FinalScore
        Try
            rankingsForm.TableBindingSource.EndEdit()
            rankingsForm.TableTableAdapter.Update(rankingsForm.MainDataDataSet.Table)
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        rankingsForm.TableBindingSource.AddNew()
        rankingsForm.Match_NumberTextBox.Text = variablesGlobal.matchNumber
        rankingsForm.Team_NumberTextBox.Text = cmboRed2.SelectedItem
        rankingsForm.Auto_ScoreTextBox.Text = variablesGlobal.redTeam2AutoScore
        rankingsForm.TeleOp_ScoreTextBox.Text = variablesGlobal.redTeam2TeleScore
        rankingsForm.End_ScoreTextBox.Text = variablesGlobal.redTeam2EndScore
        rankingsForm.Total_ScoreTextBox.Text = variablesGlobal.redTeam2FinalScore
        Try
            rankingsForm.TableBindingSource.EndEdit()
            rankingsForm.TableTableAdapter.Update(rankingsForm.MainDataDataSet.Table)
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        rankingsForm.TableBindingSource.AddNew()
        rankingsForm.Match_NumberTextBox.Text = variablesGlobal.matchNumber
        rankingsForm.Team_NumberTextBox.Text = cmboBlue1.SelectedItem
        rankingsForm.Auto_ScoreTextBox.Text = variablesGlobal.blueTeam1AutoScore
        rankingsForm.TeleOp_ScoreTextBox.Text = variablesGlobal.blueTeam1TeleScore
        rankingsForm.End_ScoreTextBox.Text = variablesGlobal.blueTeam1EndScore
        rankingsForm.Total_ScoreTextBox.Text = variablesGlobal.blueTeam1FinalScore
        Try
            rankingsForm.TableBindingSource.EndEdit()
            rankingsForm.TableTableAdapter.Update(rankingsForm.MainDataDataSet.Table)
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        rankingsForm.TableBindingSource.AddNew()
        rankingsForm.Match_NumberTextBox.Text = variablesGlobal.matchNumber
        rankingsForm.Team_NumberTextBox.Text = cmboBlue2.SelectedItem
        rankingsForm.Auto_ScoreTextBox.Text = variablesGlobal.blueTeam2AutoScore
        rankingsForm.TeleOp_ScoreTextBox.Text = variablesGlobal.blueTeam2TeleScore
        rankingsForm.End_ScoreTextBox.Text = variablesGlobal.blueTeam2EndScore
        rankingsForm.Total_ScoreTextBox.Text = variablesGlobal.blueTeam2FinalScore
        Try
            rankingsForm.TableBindingSource.EndEdit()
            rankingsForm.TableTableAdapter.Update(rankingsForm.MainDataDataSet.Table)
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'runs text exporter and database update
    Private Sub btnTextDocumentExport_Click(sender As Object, e As EventArgs) Handles btnTextDocumentExport.Click
        If (Not System.IO.Directory.Exists(CurDir() + "\Data\Matches")) Then
            System.IO.Directory.CreateDirectory(CurDir() + "\Data")
        End If
        textExport()
        updateDatabase()
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
        variablesGlobal.blueAllianceScore = variablesGlobal.blueTeam1FinalScore + variablesGlobal.blueTeam2FinalScore
        variablesGlobal.redAllianceScore = variablesGlobal.redTeam1FinalScore + variablesGlobal.redTeam2FinalScore
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

    Private Sub textExport()
        textSetupRed1()
        textSetupRed2()
        textSetupBlue1()
        textSetupBlue2()
        textMath()
        'Export red team one
        variablesGlobal.matchNumber = txtMatchNumber.Text
        If (Not System.IO.File.Exists(CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt")) Then
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), "Match Number: " + variablesGlobal.matchNumber)
        Else
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--NEXT GAME!--")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Match Number: " + variablesGlobal.matchNumber)
        End If
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextRed1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextRed1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextRed1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternRed1.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicRed1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextRed1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextRed1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--SCORES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--Red Team 1-- " + cmboRed1.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.redTeam1AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.redTeam1TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.redTeam1EndScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.redTeam1FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "--NOTES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "Match" + variablesGlobal.matchNumber + " Notes:" + txtNoteRed1.Text)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed1.SelectedItem + ".txt"), Environment.NewLine + "")

        'export Red 2
        If (Not System.IO.File.Exists(CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt")) Then
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), "Match Number: " + variablesGlobal.matchNumber)
        Else
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--NEXT GAME!--")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Match Number: " + variablesGlobal.matchNumber)
        End If
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextRed2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextRed2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextRed2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternRed2.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicRed2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextRed2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextRed2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--SCORES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--Red Team 1-- " + cmboRed2.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.redTeam2AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.redTeam2TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.redTeam2EndScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.redTeam2FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "--NOTES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "Match" + variablesGlobal.matchNumber + " Notes:" + txtNoteRed2.Text)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboRed2.SelectedItem + ".txt"), Environment.NewLine + "")

        'export Blue 1
        If (Not System.IO.File.Exists(CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt")) Then
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), "Match Number: " + variablesGlobal.matchNumber)
        Else
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--NEXT GAME!--")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Match Number: " + variablesGlobal.matchNumber)
        End If
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextBlue1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextBlue1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextBlue1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternBlue1.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicBlue1Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextBlue1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextBlue1)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--SCORES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--Red Team 1-- " + cmboBlue1.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.blueTeam1AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.blueTeam1TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.blueTeam1EndScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.blueTeam1FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "--NOTES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "Match" + variablesGlobal.matchNumber + " Notes:" + txtNoteBlue1.Text)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue1.SelectedItem + ".txt"), Environment.NewLine + "")

        'Export Blue 2
        If (Not System.IO.File.Exists(CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt")) Then
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), "Match Number: " + variablesGlobal.matchNumber)
        Else
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--NEXT GAME!--")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "")
            File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Match Number: " + variablesGlobal.matchNumber)
        End If
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--Autonomous--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Knock Jewel: " + variablesGlobal.jewelTextBlue2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphAutoBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "CryptoKey: " + variablesGlobal.cryptoTextBlue2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Safe Zone: " + variablesGlobal.safeZoneTextBlue2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--TeleOp--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Number of Glyphs: " + variablesGlobal.glyphTeleOpBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Number of Rows: " + variablesGlobal.rowBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Number of Columns: " + variablesGlobal.columnBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Cypher Pattern: " + lstPatternBlue2.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--End Game--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Relic Zone: " + variablesGlobal.relicBlue2Value.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Relic Upright: " + variablesGlobal.relicUprightTextBlue2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Balanced: " + variablesGlobal.balancedTextBlue2)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--SCORES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--Red Team 1-- " + cmboBlue2.SelectedItem)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Autonomous Score: " + variablesGlobal.blueTeam2AutoScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Tele Op Score: " + variablesGlobal.blueTeam2TeleScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "EndGame Score: " + variablesGlobal.blueTeam2EndScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Total Score: " + variablesGlobal.blueTeam2FinalScore.ToString)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "--NOTES--")
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "Match" + variablesGlobal.matchNumber + " Notes:" + txtNoteBlue2.Text)
        File.AppendAllText((CurDir() + "\Data\Matches\" + cmboBlue2.SelectedItem + ".txt"), Environment.NewLine + "")

    End Sub

    Private Sub btnTeamInput_Click(sender As Object, e As EventArgs) Handles btnTeamInput.Click
        Me.Visible = False
        TeamImport.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all typeable input
        cmboRed1.SelectedIndex = 0
        chkJewelRed1.Checked = False
        txtGlyphAutoRed1.Text = "0"
        chkCryptoKeyRed1.Checked = False
        chkSafeZoneRed1.Checked = False
        txtGlyphRed1.Text = "0"
        txtRowRed1.Text = "0"
        txtColumnsRed1.Text = "0"
        lstPatternRed1.SelectedItem = "None"
        txtRelicRed1.Text = "0"
        chkBalanceRed1.Checked = False
        cmboRed2.SelectedIndex = 0
        chkJewelRed2.Checked = False
        txtGlyphAutoRed2.Text = "0"
        chkCryptoKeyRed2.Checked = False
        chkSafeZoneRed2.Checked = False
        txtGlyphRed2.Text = "0"
        txtRowRed2.Text = "0"
        txtColumnsRed2.Text = "0"
        lstPatternRed2.SelectedItem = "None"
        txtRelicRed2.Text = "0"
        chkBalanceRed2.Checked = False
        cmboBlue1.SelectedIndex = 0
        chkJewelBlue1.Checked = False
        txtGlyphAutoBlue1.Text = "0"
        chkCryptoKeyBlue1.Checked = False
        chkSafeZoneBlue1.Checked = False
        txtGlyphblue1.Text = "0"
        txtRowBlue1.Text = "0"
        txtColumnsBlue1.Text = "0"
        lstPatternBlue1.SelectedItem = "None"
        txtRelicBlue1.Text = "0"
        chkBalanceBlue1.Checked = False
        cmboBlue2.SelectedIndex = 0
        chkJewelBlue2.Checked = False
        txtGlyphAutoBlue2.Text = "0"
        chkCryptoKeyBlue2.Checked = False
        chkSafeZoneBlue2.Checked = False
        txtGlyphblue2.Text = "0"
        txtRowBlue2.Text = "0"
        txtColumnsBlue2.Text = "0"
        lstPatternBlue2.SelectedItem = "None"
        txtRelicBlue2.Text = "0"
        chkBalanceBlue2.Checked = False
        txtNoteRed1.Text = "0"
        txtNoteRed2.Text = ""
        txtNoteBlue1.Text = ""
        txtNoteBlue2.Text = ""
    End Sub

    Private Sub mainTeamImporter()
        If (Not System.IO.Directory.Exists(CurDir() + "\Data\Teams")) Then
            System.IO.Directory.CreateDirectory(CurDir() + "\Data\Teams")
        End If

        Dim sr As StreamReader = New StreamReader(CurDir() + "\Data\Teams\TeamDirectory.txt")

        While Not sr.EndOfStream
            Dim i As Integer = 0
            variablesGlobal.allTeams = sr.ReadLine.Split(",")
        End While
        For i As Integer = 0 To variablesGlobal.allTeams.Length - 2
            cmboRed1.Items.Add(variablesGlobal.allTeams(i))
            cmboRed2.Items.Add(variablesGlobal.allTeams(i))
            cmboBlue1.Items.Add(variablesGlobal.allTeams(i))
            cmboBlue2.Items.Add(variablesGlobal.allTeams(i))
        Next
    End Sub

    Private Sub btnFinalSpreadSheet_Click(sender As Object, e As EventArgs) Handles btnFinalSpreadSheet.Click
        Me.Visible = False
        MainMenu.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changes window size and places it in center of screen
        Me.Size = New Size(735, 860)
        Me.Visible = False
        mainTeamImporter()

        'makes default choice in list None
        lstPatternRed1.SelectedIndex = 0
        lstPatternRed2.SelectedIndex = 0
        lstPatternBlue1.SelectedIndex = 0
        lstPatternBlue2.SelectedIndex = 0
        cmboRed1.SelectedIndex = 0
        cmboRed2.SelectedIndex = 0
        cmboBlue1.SelectedIndex = 0
        cmboBlue2.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes application
        Me.Close()
    End Sub
End Class
