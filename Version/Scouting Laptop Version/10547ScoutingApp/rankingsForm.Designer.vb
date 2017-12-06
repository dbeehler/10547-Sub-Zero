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
        Dim Total_ScoreLabel As System.Windows.Forms.Label
        Me.FinalMainDataDataSet = New _10547ScoutingApp.finalMainDataDataSet()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New _10547ScoutingApp.finalMainDataDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New _10547ScoutingApp.finalMainDataDataSetTableAdapters.TableAdapterManager()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Total_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAndCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWithoutSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Match_NumberLabel = New System.Windows.Forms.Label()
        Team_NumberLabel = New System.Windows.Forms.Label()
        Auto_ScoreLabel = New System.Windows.Forms.Label()
        TeleOp_ScoreLabel = New System.Windows.Forms.Label()
        End_ScoreLabel = New System.Windows.Forms.Label()
        Total_ScoreLabel = New System.Windows.Forms.Label()
        CType(Me.FinalMainDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FinalMainDataDataSet
        '
        Me.FinalMainDataDataSet.DataSetName = "finalMainDataDataSet"
        Me.FinalMainDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.FinalMainDataDataSet
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = _10547ScoutingApp.finalMainDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(12, 269)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(650, 220)
        Me.TableDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total Score"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Score"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Match_NumberLabel
        '
        Match_NumberLabel.AutoSize = True
        Match_NumberLabel.Location = New System.Drawing.Point(411, 107)
        Match_NumberLabel.Name = "Match_NumberLabel"
        Match_NumberLabel.Size = New System.Drawing.Size(80, 13)
        Match_NumberLabel.TabIndex = 1
        Match_NumberLabel.Text = "Match Number:"
        '
        'Match_NumberTextBox
        '
        Me.Match_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Match Number", True))
        Me.Match_NumberTextBox.Location = New System.Drawing.Point(497, 104)
        Me.Match_NumberTextBox.Name = "Match_NumberTextBox"
        Me.Match_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Match_NumberTextBox.TabIndex = 2
        '
        'Team_NumberLabel
        '
        Team_NumberLabel.AutoSize = True
        Team_NumberLabel.Location = New System.Drawing.Point(411, 133)
        Team_NumberLabel.Name = "Team_NumberLabel"
        Team_NumberLabel.Size = New System.Drawing.Size(77, 13)
        Team_NumberLabel.TabIndex = 3
        Team_NumberLabel.Text = "Team Number:"
        '
        'Team_NumberTextBox
        '
        Me.Team_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Team Number", True))
        Me.Team_NumberTextBox.Location = New System.Drawing.Point(497, 130)
        Me.Team_NumberTextBox.Name = "Team_NumberTextBox"
        Me.Team_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Team_NumberTextBox.TabIndex = 4
        '
        'Auto_ScoreLabel
        '
        Auto_ScoreLabel.AutoSize = True
        Auto_ScoreLabel.Location = New System.Drawing.Point(411, 159)
        Auto_ScoreLabel.Name = "Auto_ScoreLabel"
        Auto_ScoreLabel.Size = New System.Drawing.Size(63, 13)
        Auto_ScoreLabel.TabIndex = 5
        Auto_ScoreLabel.Text = "Auto Score:"
        '
        'Auto_ScoreTextBox
        '
        Me.Auto_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Auto Score", True))
        Me.Auto_ScoreTextBox.Location = New System.Drawing.Point(497, 156)
        Me.Auto_ScoreTextBox.Name = "Auto_ScoreTextBox"
        Me.Auto_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Auto_ScoreTextBox.TabIndex = 6
        '
        'TeleOp_ScoreLabel
        '
        TeleOp_ScoreLabel.AutoSize = True
        TeleOp_ScoreLabel.Location = New System.Drawing.Point(411, 185)
        TeleOp_ScoreLabel.Name = "TeleOp_ScoreLabel"
        TeleOp_ScoreLabel.Size = New System.Drawing.Size(79, 13)
        TeleOp_ScoreLabel.TabIndex = 7
        TeleOp_ScoreLabel.Text = "Tele Op Score:"
        '
        'TeleOp_ScoreTextBox
        '
        Me.TeleOp_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "TeleOp Score", True))
        Me.TeleOp_ScoreTextBox.Location = New System.Drawing.Point(497, 182)
        Me.TeleOp_ScoreTextBox.Name = "TeleOp_ScoreTextBox"
        Me.TeleOp_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeleOp_ScoreTextBox.TabIndex = 8
        '
        'End_ScoreLabel
        '
        End_ScoreLabel.AutoSize = True
        End_ScoreLabel.Location = New System.Drawing.Point(411, 211)
        End_ScoreLabel.Name = "End_ScoreLabel"
        End_ScoreLabel.Size = New System.Drawing.Size(60, 13)
        End_ScoreLabel.TabIndex = 9
        End_ScoreLabel.Text = "End Score:"
        '
        'End_ScoreTextBox
        '
        Me.End_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "End Score", True))
        Me.End_ScoreTextBox.Location = New System.Drawing.Point(497, 208)
        Me.End_ScoreTextBox.Name = "End_ScoreTextBox"
        Me.End_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.End_ScoreTextBox.TabIndex = 10
        '
        'Total_ScoreLabel
        '
        Total_ScoreLabel.AutoSize = True
        Total_ScoreLabel.Location = New System.Drawing.Point(411, 237)
        Total_ScoreLabel.Name = "Total_ScoreLabel"
        Total_ScoreLabel.Size = New System.Drawing.Size(65, 13)
        Total_ScoreLabel.TabIndex = 11
        Total_ScoreLabel.Text = "Total Score:"
        '
        'Total_ScoreTextBox
        '
        Me.Total_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Total Score", True))
        Me.Total_ScoreTextBox.Location = New System.Drawing.Point(497, 234)
        Me.Total_ScoreTextBox.Name = "Total_ScoreTextBox"
        Me.Total_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_ScoreTextBox.TabIndex = 12
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip.TabIndex = 13
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndCloseToolStripMenuItem, Me.CloseWithoutSaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAndCloseToolStripMenuItem
        '
        Me.SaveAndCloseToolStripMenuItem.Name = "SaveAndCloseToolStripMenuItem"
        Me.SaveAndCloseToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SaveAndCloseToolStripMenuItem.Text = "Save and Close"
        '
        'CloseWithoutSaveToolStripMenuItem
        '
        Me.CloseWithoutSaveToolStripMenuItem.Name = "CloseWithoutSaveToolStripMenuItem"
        Me.CloseWithoutSaveToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CloseWithoutSaveToolStripMenuItem.Text = "Close Without Save"
        '
        'rankingsForm
        '
        Me.ClientSize = New System.Drawing.Size(682, 509)
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
        Me.Controls.Add(Total_ScoreLabel)
        Me.Controls.Add(Me.Total_ScoreTextBox)
        Me.Controls.Add(Me.TableDataGridView)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "rankingsForm"
        CType(Me.FinalMainDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinalMainDataDataSet As finalMainDataDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As finalMainDataDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As finalMainDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Match_NumberTextBox As TextBox
    Friend WithEvents Team_NumberTextBox As TextBox
    Friend WithEvents Auto_ScoreTextBox As TextBox
    Friend WithEvents TeleOp_ScoreTextBox As TextBox
    Friend WithEvents End_ScoreTextBox As TextBox
    Friend WithEvents Total_ScoreTextBox As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAndCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseWithoutSaveToolStripMenuItem As ToolStripMenuItem
End Class
