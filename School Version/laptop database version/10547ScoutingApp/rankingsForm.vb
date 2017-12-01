Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class rankingsForm
    Private Sub rankingsForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalMainDataDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.FinalMainDataDataSet.Table)
        'starts the editing
        Me.TableBindingSource.AddNew()
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            'saves entries
            Me.TableBindingSource.EndEdit()
            'updates table
            Me.TableTableAdapter.Update(Me.FinalMainDataDataSet.Table)
            'closes app
            Me.Visible = False
        Catch ex As Exception
            'catches if an error
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'doesnt work D:
    Private Sub ClearDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Aborted")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Aborted")
        ElseIf result = DialogResult.Yes Then
        End If
    End Sub

    Private Sub ExitWithoutSaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'cancels edit
        Me.TableBindingSource.CancelEdit()
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveAndCloseToolStripMenuItem.Click

    End Sub
End Class