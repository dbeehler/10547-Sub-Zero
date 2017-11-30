Public Class rankingsForm

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDataDataSet)

    End Sub

    Private Sub rankingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.MainDataDataSet.Table)
        'TODO: This line of code loads data into the 'MainDataDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.MainDataDataSet.Table)
        Me.TableBindingSource.AddNew()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Me.TableBindingSource.EndEdit()
            Me.TableTableAdapter.Update(Me.MainDataDataSet.Table)
            Me.Visible = False
            Console.WriteLine(datac)
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDataDataSet)

    End Sub

    Private Sub btnClearData_Click(sender As Object, e As EventArgs) Handles btnClearData.Click
        Dim result As Integer = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Aborted")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Aborted")
        ElseIf result = DialogResult.Yes Then
            MainDataDataSet.Tables("Table").Clear()
            Me.TableBindingSource.EndEdit()
            Me.TableTableAdapter.Update(Me.MainDataDataSet.Table)
        End If
    End Sub
End Class