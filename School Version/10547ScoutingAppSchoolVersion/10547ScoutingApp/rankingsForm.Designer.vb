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
        Me.MainDataDataSet = New _10547ScoutingApp.mainDataDataSet()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New _10547ScoutingApp.mainDataDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New _10547ScoutingApp.mainDataDataSetTableAdapters.TableAdapterManager()
        Me.Match_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Team_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Auto_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.TeleOp_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.End_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Total_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.TableDataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAndCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitWithoutSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Match_NumberLabel = New System.Windows.Forms.Label()
        Team_NumberLabel = New System.Windows.Forms.Label()
        Auto_ScoreLabel = New System.Windows.Forms.Label()
        TeleOp_ScoreLabel = New System.Windows.Forms.Label()
        End_ScoreLabel = New System.Windows.Forms.Label()
        Total_ScoreLabel = New System.Windows.Forms.Label()
        CType(Me.MainDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Match_NumberLabel
        '
        Match_NumberLabel.AutoSize = True
        Match_NumberLabel.Location = New System.Drawing.Point(8, 22)
        Match_NumberLabel.Name = "Match_NumberLabel"
        Match_NumberLabel.Size = New System.Drawing.Size(80, 13)
        Match_NumberLabel.TabIndex = 1
        Match_NumberLabel.Text = "Match Number:"
        '
        'Team_NumberLabel
        '
        Team_NumberLabel.AutoSize = True
        Team_NumberLabel.Location = New System.Drawing.Point(8, 48)
        Team_NumberLabel.Name = "Team_NumberLabel"
        Team_NumberLabel.Size = New System.Drawing.Size(77, 13)
        Team_NumberLabel.TabIndex = 3
        Team_NumberLabel.Text = "Team Number:"
        '
        'Auto_ScoreLabel
        '
        Auto_ScoreLabel.AutoSize = True
        Auto_ScoreLabel.Location = New System.Drawing.Point(8, 74)
        Auto_ScoreLabel.Name = "Auto_ScoreLabel"
        Auto_ScoreLabel.Size = New System.Drawing.Size(63, 13)
        Auto_ScoreLabel.TabIndex = 5
        Auto_ScoreLabel.Text = "Auto Score:"
        '
        'TeleOp_ScoreLabel
        '
        TeleOp_ScoreLabel.AutoSize = True
        TeleOp_ScoreLabel.Location = New System.Drawing.Point(8, 100)
        TeleOp_ScoreLabel.Name = "TeleOp_ScoreLabel"
        TeleOp_ScoreLabel.Size = New System.Drawing.Size(79, 13)
        TeleOp_ScoreLabel.TabIndex = 7
        TeleOp_ScoreLabel.Text = "Tele Op Score:"
        '
        'End_ScoreLabel
        '
        End_ScoreLabel.AutoSize = True
        End_ScoreLabel.Location = New System.Drawing.Point(8, 126)
        End_ScoreLabel.Name = "End_ScoreLabel"
        End_ScoreLabel.Size = New System.Drawing.Size(60, 13)
        End_ScoreLabel.TabIndex = 9
        End_ScoreLabel.Text = "End Score:"
        '
        'Total_ScoreLabel
        '
        Total_ScoreLabel.AutoSize = True
        Total_ScoreLabel.Location = New System.Drawing.Point(8, 152)
        Total_ScoreLabel.Name = "Total_ScoreLabel"
        Total_ScoreLabel.Size = New System.Drawing.Size(65, 13)
        Total_ScoreLabel.TabIndex = 11
        Total_ScoreLabel.Text = "Total Score:"
        '
        'MainDataDataSet
        '
        Me.MainDataDataSet.DataSetName = "mainDataDataSet"
        Me.MainDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.MainDataDataSet
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = _10547ScoutingApp.mainDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Match_NumberTextBox
        '
        Me.Match_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Match Number", True))
        Me.Match_NumberTextBox.Location = New System.Drawing.Point(94, 19)
        Me.Match_NumberTextBox.Name = "Match_NumberTextBox"
        Me.Match_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Match_NumberTextBox.TabIndex = 2
        '
        'Team_NumberTextBox
        '
        Me.Team_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Team Number", True))
        Me.Team_NumberTextBox.Location = New System.Drawing.Point(94, 45)
        Me.Team_NumberTextBox.Name = "Team_NumberTextBox"
        Me.Team_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Team_NumberTextBox.TabIndex = 4
        '
        'Auto_ScoreTextBox
        '
        Me.Auto_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Auto Score", True))
        Me.Auto_ScoreTextBox.Location = New System.Drawing.Point(94, 71)
        Me.Auto_ScoreTextBox.Name = "Auto_ScoreTextBox"
        Me.Auto_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Auto_ScoreTextBox.TabIndex = 6
        '
        'TeleOp_ScoreTextBox
        '
        Me.TeleOp_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "TeleOp Score", True))
        Me.TeleOp_ScoreTextBox.Location = New System.Drawing.Point(94, 97)
        Me.TeleOp_ScoreTextBox.Name = "TeleOp_ScoreTextBox"
        Me.TeleOp_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeleOp_ScoreTextBox.TabIndex = 8
        '
        'End_ScoreTextBox
        '
        Me.End_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "End Score", True))
        Me.End_ScoreTextBox.Location = New System.Drawing.Point(94, 123)
        Me.End_ScoreTextBox.Name = "End_ScoreTextBox"
        Me.End_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.End_ScoreTextBox.TabIndex = 10
        '
        'Total_ScoreTextBox
        '
        Me.Total_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Total Score", True))
        Me.Total_ScoreTextBox.Location = New System.Drawing.Point(94, 149)
        Me.Total_ScoreTextBox.Name = "Total_ScoreTextBox"
        Me.Total_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_ScoreTextBox.TabIndex = 12
        '
        'TableDataGridViewMain
        '
        Me.TableDataGridViewMain.AutoGenerateColumns = False
        Me.TableDataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridViewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TableDataGridViewMain.DataSource = Me.TableBindingSource
        Me.TableDataGridViewMain.Location = New System.Drawing.Point(12, 215)
        Me.TableDataGridViewMain.Name = "TableDataGridViewMain"
        Me.TableDataGridViewMain.Size = New System.Drawing.Size(653, 220)
        Me.TableDataGridViewMain.TabIndex = 12
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndCloseToolStripMenuItem, Me.ExitWithoutSaveToolStripMenuItem, Me.ClearDataToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAndCloseToolStripMenuItem
        '
        Me.SaveAndCloseToolStripMenuItem.Name = "SaveAndCloseToolStripMenuItem"
        Me.SaveAndCloseToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SaveAndCloseToolStripMenuItem.Text = "Save and Close"
        '
        'ExitWithoutSaveToolStripMenuItem
        '
        Me.ExitWithoutSaveToolStripMenuItem.Name = "ExitWithoutSaveToolStripMenuItem"
        Me.ExitWithoutSaveToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExitWithoutSaveToolStripMenuItem.Text = "Exit Without Save"
        '
        'ClearDataToolStripMenuItem
        '
        Me.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem"
        Me.ClearDataToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ClearDataToolStripMenuItem.Text = "Clear Data"
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.Match_NumberTextBox)
        Me.grpMain.Controls.Add(Me.Total_ScoreTextBox)
        Me.grpMain.Controls.Add(Match_NumberLabel)
        Me.grpMain.Controls.Add(Total_ScoreLabel)
        Me.grpMain.Controls.Add(Me.End_ScoreTextBox)
        Me.grpMain.Controls.Add(Team_NumberLabel)
        Me.grpMain.Controls.Add(End_ScoreLabel)
        Me.grpMain.Controls.Add(Me.Team_NumberTextBox)
        Me.grpMain.Controls.Add(Me.TeleOp_ScoreTextBox)
        Me.grpMain.Controls.Add(Auto_ScoreLabel)
        Me.grpMain.Controls.Add(TeleOp_ScoreLabel)
        Me.grpMain.Controls.Add(Me.Auto_ScoreTextBox)
        Me.grpMain.Location = New System.Drawing.Point(462, 27)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(200, 182)
        Me.grpMain.TabIndex = 14
        Me.grpMain.TabStop = False
        '
        'rankingsForm
        '
        Me.ClientSize = New System.Drawing.Size(674, 447)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.TableDataGridViewMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "rankingsForm"
        CType(Me.MainDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainDataDataSet As _10547ScoutingApp.mainDataDataSet
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableTableAdapter As _10547ScoutingApp.mainDataDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As _10547ScoutingApp.mainDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Match_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Team_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Auto_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeleOp_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents End_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableDataGridViewMain As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAndCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitWithoutSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
End Class
