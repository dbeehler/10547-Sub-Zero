Public Class Rankings

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAndCloseToolStripMenuItem.Click

        MainMenu.applicationClose()
    End Sub

    Private Sub CloseWithoutSavingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseWithoutSavingToolStripMenuItem.Click

        MainMenu.applicationClose()
    End Sub

    Private Sub Rankings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RankingsDataSet.MainTable' table. You can move, or remove it, as needed.
        Me.MainTableTableAdapter.Fill(Me.RankingsDataSet.MainTable)
        'TODO: This line of code loads data into the 'RankingsDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.RankingsDataSet.Table)

    End Sub

    Public Shared Sub updateDataBase()
        Rankings.MainTableBindingSource.AddNew()
        Rankings.MatchNumberTextBox.Text = variablesGlobal.matchNumber
        Rankings.Team_NumberTextBox1.Text = TextExporter.cmboRed1.SelectedIndex
        Rankings.AutoTextBox.Text = variablesGlobal.redTeam1AutoScore
        Rankings.TeleOpTextBox.Text = variablesGlobal.redTeam1TeleScore
        Rankings.EndGameTextBox.Text = variablesGlobal.redTeam1EndScore
        Rankings.TableTableAdapter.Update(Rankings.RankingsDataSet.Table)
        Rankings.MainTableTableAdapter.Update(Rankings.RankingsDataSet.MainTable)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updateDataBase()
    End Sub
End Class