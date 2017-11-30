Imports System.Data.SqlClient
Public Class rankingsForm

    'Private Sub btnClearData_Click(sender As Object, e As EventArgs) Handles btnClearData.Click
    '    Dim result As Integer = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
    '    If result = DialogResult.Cancel Then
    '        MessageBox.Show("Aborted")
    '    ElseIf result = DialogResult.No Then
    '        MessageBox.Show("Aborted")
    '    ElseIf result = DialogResult.Yes Then
    '        MainDataDataSet.Tables("Table").Clear()
    '        Me.TableBindingSource.EndEdit()
    '        Me.TableTableAdapter.Update(Me.MainDataDataSet.Table)
    '    End If
    'End Sub

    Private Sub TableBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDataDataSet)

    End Sub

    Private Sub rankingsForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataDataSet1.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.MainDataDataSet.Table)
        Me.TableBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.TableBindingSource.EndEdit()
            Me.TableTableAdapter.Update(Me.MainDataDataSet.Table)
            Me.Visible = False
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDataDataSet)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class