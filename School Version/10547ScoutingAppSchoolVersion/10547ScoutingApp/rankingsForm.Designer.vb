<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rankingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Match_NumberLabel As System.Windows.Forms.Label
        Dim Team_NumberLabel As System.Windows.Forms.Label
        Dim Auto_ScoreLabel As System.Windows.Forms.Label
        Dim TeleOp_ScoreLabel As System.Windows.Forms.Label
        Dim End_ScoreLabel As System.Windows.Forms.Label
        Dim Final_ScoreLabel As System.Windows.Forms.Label
        Me.FinalRankingsDataSet = New _10547ScoutingApp.finalRankingsDataSet()
        Me.MainMatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainMatchTableAdapter = New _10547ScoutingApp.finalRankingsDataSetTableAdapters.mainMatchTableAdapter()
        Me.TableAdapterManager = New _10547ScoutingApp.finalRankingsDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMatchDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Match_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Team_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Auto_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.TeleOp_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.End_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Final_ScoreTextBox = New System.Windows.Forms.TextBox()
        Match_NumberLabel = New System.Windows.Forms.Label()
        Team_NumberLabel = New System.Windows.Forms.Label()
        Auto_ScoreLabel = New System.Windows.Forms.Label()
        TeleOp_ScoreLabel = New System.Windows.Forms.Label()
        End_ScoreLabel = New System.Windows.Forms.Label()
        Final_ScoreLabel = New System.Windows.Forms.Label()
        CType(Me.FinalRankingsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MainMatchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FinalRankingsDataSet
        '
        Me.FinalRankingsDataSet.DataSetName = "finalRankingsDataSet"
        Me.FinalRankingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainMatchBindingSource
        '
        Me.MainMatchBindingSource.DataMember = "mainMatch"
        Me.MainMatchBindingSource.DataSource = Me.FinalRankingsDataSet
        '
        'MainMatchTableAdapter
        '
        Me.MainMatchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mainMatchTableAdapter = Me.MainMatchTableAdapter
        Me.TableAdapterManager.UpdateOrder = _10547ScoutingApp.finalRankingsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'MainMatchDataGridView
        '
        Me.MainMatchDataGridView.AutoGenerateColumns = False
        Me.MainMatchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainMatchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MainMatchDataGridView.DataSource = Me.MainMatchBindingSource
        Me.MainMatchDataGridView.Location = New System.Drawing.Point(12, 193)
        Me.MainMatchDataGridView.Name = "MainMatchDataGridView"
        Me.MainMatchDataGridView.Size = New System.Drawing.Size(651, 92)
        Me.MainMatchDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Match Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Match Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Team Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Team Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Auto Score"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Auto Score"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TeleOp Score"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TeleOp Score"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "End Score"
        Me.DataGridViewTextBoxColumn5.HeaderText = "End Score"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Final Score"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Final Score"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Match_NumberLabel
        '
        Match_NumberLabel.AutoSize = True
        Match_NumberLabel.Location = New System.Drawing.Point(318, 38)
        Match_NumberLabel.Name = "Match_NumberLabel"
        Match_NumberLabel.Size = New System.Drawing.Size(80, 13)
        Match_NumberLabel.TabIndex = 13
        Match_NumberLabel.Text = "Match Number:"
        '
        'Match_NumberTextBox
        '
        Me.Match_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainMatchBindingSource, "Match Number", True))
        Me.Match_NumberTextBox.Location = New System.Drawing.Point(404, 35)
        Me.Match_NumberTextBox.Name = "Match_NumberTextBox"
        Me.Match_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Match_NumberTextBox.TabIndex = 14
        '
        'Team_NumberLabel
        '
        Team_NumberLabel.AutoSize = True
        Team_NumberLabel.Location = New System.Drawing.Point(318, 64)
        Team_NumberLabel.Name = "Team_NumberLabel"
        Team_NumberLabel.Size = New System.Drawing.Size(77, 13)
        Team_NumberLabel.TabIndex = 15
        Team_NumberLabel.Text = "Team Number:"
        '
        'Team_NumberTextBox
        '
        Me.Team_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainMatchBindingSource, "Team Number", True))
        Me.Team_NumberTextBox.Location = New System.Drawing.Point(404, 61)
        Me.Team_NumberTextBox.Name = "Team_NumberTextBox"
        Me.Team_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Team_NumberTextBox.TabIndex = 16
        '
        'Auto_ScoreLabel
        '
        Auto_ScoreLabel.AutoSize = True
        Auto_ScoreLabel.Location = New System.Drawing.Point(318, 90)
        Auto_ScoreLabel.Name = "Auto_ScoreLabel"
        Auto_ScoreLabel.Size = New System.Drawing.Size(63, 13)
        Auto_ScoreLabel.TabIndex = 17
        Auto_ScoreLabel.Text = "Auto Score:"
        '
        'Auto_ScoreTextBox
        '
        Me.Auto_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainMatchBindingSource, "Auto Score", True))
        Me.Auto_ScoreTextBox.Location = New System.Drawing.Point(404, 87)
        Me.Auto_ScoreTextBox.Name = "Auto_ScoreTextBox"
        Me.Auto_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Auto_ScoreTextBox.TabIndex = 18
        '
        'TeleOp_ScoreLabel
        '
        TeleOp_ScoreLabel.AutoSize = True
        TeleOp_ScoreLabel.Location = New System.Drawing.Point(318, 116)
        TeleOp_ScoreLabel.Name = "TeleOp_ScoreLabel"
        TeleOp_ScoreLabel.Size = New System.Drawing.Size(79, 13)
        TeleOp_ScoreLabel.TabIndex = 19
        TeleOp_ScoreLabel.Text = "Tele Op Score:"
        '
        'TeleOp_ScoreTextBox
        '
        Me.TeleOp_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainMatchBindingSource, "TeleOp Score", True))
        Me.TeleOp_ScoreTextBox.Location = New System.Drawing.Point(404, 113)
        Me.TeleOp_ScoreTextBox.Name = "TeleOp_ScoreTextBox"
        Me.TeleOp_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeleOp_ScoreTextBox.TabIndex = 20
        '
        'End_ScoreLabel
        '
        End_ScoreLabel.AutoSize = True
        End_ScoreLabel.Location = New System.Drawing.Point(318, 142)
        End_ScoreLabel.Name = "End_ScoreLabel"
        End_ScoreLabel.Size = New System.Drawing.Size(60, 13)
        End_ScoreLabel.TabIndex = 21
        End_ScoreLabel.Text = "End Score:"
        '
        'End_ScoreTextBox
        '
        Me.End_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainMatchBindingSource, "End Score", True))
        Me.End_ScoreTextBox.Location = New System.Drawing.Point(404, 139)
        Me.End_ScoreTextBox.Name = "End_ScoreTextBox"
        Me.End_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.End_ScoreTextBox.TabIndex = 22
        '
        'Final_ScoreLabel
        '
        Final_ScoreLabel.AutoSize = True
        Final_ScoreLabel.Location = New System.Drawing.Point(318, 168)
        Final_ScoreLabel.Name = "Final_ScoreLabel"
        Final_ScoreLabel.Size = New System.Drawing.Size(63, 13)
        Final_ScoreLabel.TabIndex = 23
        Final_ScoreLabel.Text = "Final Score:"
        '
        'Final_ScoreTextBox
        '
        Me.Final_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainMatchBindingSource, "Final Score", True))
        Me.Final_ScoreTextBox.Location = New System.Drawing.Point(404, 165)
        Me.Final_ScoreTextBox.Name = "Final_ScoreTextBox"
        Me.Final_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Final_ScoreTextBox.TabIndex = 24
        '
        'rankingsForm
        '
        Me.ClientSize = New System.Drawing.Size(675, 330)
        Me.Controls.Add(Match_NumberLabel)
        Me.Controls.Add(Me.Match_NumberTextBox)
        Me.Controls.Add(Team_NumberLabel)
        Me.Controls.Add(Me.Team_NumberTextBox)
        Me.Controls.Add(Auto_ScoreLabel)
        Me.Controls.Add(Me.Auto_ScoreTextBox)
        Me.Controls.Add(TeleOp_ScoreLabel)
        Me.Controls.Add(Me.TeleOp_ScoreTextBox)
        Me.Controls.Add(End_ScoreLabel)
        Me.Controls.Add(Me.End_ScoreTextBox)
        Me.Controls.Add(Final_ScoreLabel)
        Me.Controls.Add(Me.Final_ScoreTextBox)
        Me.Controls.Add(Me.MainMatchDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "rankingsForm"
        CType(Me.FinalRankingsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MainMatchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinalRankingsDataSet As _10547ScoutingApp.finalRankingsDataSet
    Friend WithEvents MainMatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainMatchTableAdapter As _10547ScoutingApp.finalRankingsDataSetTableAdapters.mainMatchTableAdapter
    Friend WithEvents TableAdapterManager As _10547ScoutingApp.finalRankingsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMatchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Match_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Team_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Auto_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeleOp_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents End_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Final_ScoreTextBox As System.Windows.Forms.TextBox
End Class
