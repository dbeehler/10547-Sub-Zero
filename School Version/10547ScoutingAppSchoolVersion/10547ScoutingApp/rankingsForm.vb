Public Class rankingsForm

    Private Sub MainMatchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MainMatchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinalRankingsDataSet)

    End Sub

    Private Sub rankingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalRankingsDataSet.mainMatch' table. You can move, or remove it, as needed.
        Me.MainMatchTableAdapter.Fill(Me.FinalRankingsDataSet.mainMatch)
        MainMatchBindingSource.AddNew()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            MainMatchBindingSource.EndEdit()
            MainMatchTableAdapter.Update(FinalRankingsDataSet.mainMatch)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR")
        End Try
    End Sub
End Class