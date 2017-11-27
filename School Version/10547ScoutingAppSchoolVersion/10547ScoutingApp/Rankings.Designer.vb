<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rankings
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
        Dim Team_NumberLabel As System.Windows.Forms.Label
        Dim Average_AutoLabel As System.Windows.Forms.Label
        Dim Average_TeleOpLabel As System.Windows.Forms.Label
        Dim Average_End_ScoreLabel As System.Windows.Forms.Label
        Dim RPLabel As System.Windows.Forms.Label
        Dim QPLabel As System.Windows.Forms.Label
        Dim MatchNumberLabel As System.Windows.Forms.Label
        Dim Team_NumberLabel1 As System.Windows.Forms.Label
        Dim AutoLabel As System.Windows.Forms.Label
        Dim TeleOpLabel As System.Windows.Forms.Label
        Dim EndGameLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAndCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWithoutSavingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TeamNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageAutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageTeleOpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageEndScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankingsDataSet = New _10547ScoutingApp.RankingsDataSet()
        Me.Team_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Average_AutoTextBox = New System.Windows.Forms.TextBox()
        Me.Average_TeleOpTextBox = New System.Windows.Forms.TextBox()
        Me.Average_End_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.RPTextBox = New System.Windows.Forms.TextBox()
        Me.QPTextBox = New System.Windows.Forms.TextBox()
        Me.TableTableAdapter = New _10547ScoutingApp.RankingsDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New _10547ScoutingApp.RankingsDataSetTableAdapters.TableAdapterManager()
        Me.MainTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainTableTableAdapter = New _10547ScoutingApp.RankingsDataSetTableAdapters.MainTableTableAdapter()
        Me.MatchNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Team_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.AutoTextBox = New System.Windows.Forms.TextBox()
        Me.TeleOpTextBox = New System.Windows.Forms.TextBox()
        Me.EndGameTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MatchNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleOpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndGameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Team_NumberLabel = New System.Windows.Forms.Label()
        Average_AutoLabel = New System.Windows.Forms.Label()
        Average_TeleOpLabel = New System.Windows.Forms.Label()
        Average_End_ScoreLabel = New System.Windows.Forms.Label()
        RPLabel = New System.Windows.Forms.Label()
        QPLabel = New System.Windows.Forms.Label()
        MatchNumberLabel = New System.Windows.Forms.Label()
        Team_NumberLabel1 = New System.Windows.Forms.Label()
        AutoLabel = New System.Windows.Forms.Label()
        TeleOpLabel = New System.Windows.Forms.Label()
        EndGameLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankingsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Team_NumberLabel
        '
        Team_NumberLabel.AutoSize = True
        Team_NumberLabel.Location = New System.Drawing.Point(31, 125)
        Team_NumberLabel.Name = "Team_NumberLabel"
        Team_NumberLabel.Size = New System.Drawing.Size(77, 13)
        Team_NumberLabel.TabIndex = 2
        Team_NumberLabel.Text = "Team Number:"
        '
        'Average_AutoLabel
        '
        Average_AutoLabel.AutoSize = True
        Average_AutoLabel.Location = New System.Drawing.Point(31, 151)
        Average_AutoLabel.Name = "Average_AutoLabel"
        Average_AutoLabel.Size = New System.Drawing.Size(75, 13)
        Average_AutoLabel.TabIndex = 4
        Average_AutoLabel.Text = "Average Auto:"
        '
        'Average_TeleOpLabel
        '
        Average_TeleOpLabel.AutoSize = True
        Average_TeleOpLabel.Location = New System.Drawing.Point(31, 177)
        Average_TeleOpLabel.Name = "Average_TeleOpLabel"
        Average_TeleOpLabel.Size = New System.Drawing.Size(91, 13)
        Average_TeleOpLabel.TabIndex = 6
        Average_TeleOpLabel.Text = "Average Tele Op:"
        '
        'Average_End_ScoreLabel
        '
        Average_End_ScoreLabel.AutoSize = True
        Average_End_ScoreLabel.Location = New System.Drawing.Point(31, 203)
        Average_End_ScoreLabel.Name = "Average_End_ScoreLabel"
        Average_End_ScoreLabel.Size = New System.Drawing.Size(103, 13)
        Average_End_ScoreLabel.TabIndex = 8
        Average_End_ScoreLabel.Text = "Average End Score:"
        '
        'RPLabel
        '
        RPLabel.AutoSize = True
        RPLabel.Location = New System.Drawing.Point(31, 229)
        RPLabel.Name = "RPLabel"
        RPLabel.Size = New System.Drawing.Size(25, 13)
        RPLabel.TabIndex = 10
        RPLabel.Text = "RP:"
        '
        'QPLabel
        '
        QPLabel.AutoSize = True
        QPLabel.Location = New System.Drawing.Point(31, 255)
        QPLabel.Name = "QPLabel"
        QPLabel.Size = New System.Drawing.Size(25, 13)
        QPLabel.TabIndex = 12
        QPLabel.Text = "QP:"
        '
        'MatchNumberLabel
        '
        MatchNumberLabel.AutoSize = True
        MatchNumberLabel.Location = New System.Drawing.Point(266, 125)
        MatchNumberLabel.Name = "MatchNumberLabel"
        MatchNumberLabel.Size = New System.Drawing.Size(80, 13)
        MatchNumberLabel.TabIndex = 14
        MatchNumberLabel.Text = "Match Number:"
        MatchNumberLabel.Visible = False
        '
        'Team_NumberLabel1
        '
        Team_NumberLabel1.AutoSize = True
        Team_NumberLabel1.Location = New System.Drawing.Point(266, 151)
        Team_NumberLabel1.Name = "Team_NumberLabel1"
        Team_NumberLabel1.Size = New System.Drawing.Size(77, 13)
        Team_NumberLabel1.TabIndex = 16
        Team_NumberLabel1.Text = "Team Number:"
        Team_NumberLabel1.Visible = False
        '
        'AutoLabel
        '
        AutoLabel.AutoSize = True
        AutoLabel.Location = New System.Drawing.Point(266, 177)
        AutoLabel.Name = "AutoLabel"
        AutoLabel.Size = New System.Drawing.Size(32, 13)
        AutoLabel.TabIndex = 18
        AutoLabel.Text = "Auto:"
        AutoLabel.Visible = False
        '
        'TeleOpLabel
        '
        TeleOpLabel.AutoSize = True
        TeleOpLabel.Location = New System.Drawing.Point(266, 203)
        TeleOpLabel.Name = "TeleOpLabel"
        TeleOpLabel.Size = New System.Drawing.Size(48, 13)
        TeleOpLabel.TabIndex = 20
        TeleOpLabel.Text = "Tele Op:"
        TeleOpLabel.Visible = False
        '
        'EndGameLabel
        '
        EndGameLabel.AutoSize = True
        EndGameLabel.Location = New System.Drawing.Point(266, 229)
        EndGameLabel.Name = "EndGameLabel"
        EndGameLabel.Size = New System.Drawing.Size(60, 13)
        EndGameLabel.TabIndex = 22
        EndGameLabel.Text = "End Game:"
        EndGameLabel.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndCloseToolStripMenuItem, Me.CloseWithoutSavingToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAndCloseToolStripMenuItem
        '
        Me.SaveAndCloseToolStripMenuItem.Name = "SaveAndCloseToolStripMenuItem"
        Me.SaveAndCloseToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SaveAndCloseToolStripMenuItem.Text = "Save and Close"
        '
        'CloseWithoutSavingToolStripMenuItem
        '
        Me.CloseWithoutSavingToolStripMenuItem.Name = "CloseWithoutSavingToolStripMenuItem"
        Me.CloseWithoutSavingToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CloseWithoutSavingToolStripMenuItem.Text = "Close Without Saving"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeamNumberDataGridViewTextBoxColumn, Me.AverageAutoDataGridViewTextBoxColumn, Me.AverageTeleOpDataGridViewTextBoxColumn, Me.AverageEndScoreDataGridViewTextBoxColumn, Me.RPDataGridViewTextBoxColumn, Me.QPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 89)
        Me.DataGridView1.TabIndex = 1
        '
        'TeamNumberDataGridViewTextBoxColumn
        '
        Me.TeamNumberDataGridViewTextBoxColumn.DataPropertyName = "Team Number"
        Me.TeamNumberDataGridViewTextBoxColumn.HeaderText = "Team Number"
        Me.TeamNumberDataGridViewTextBoxColumn.Name = "TeamNumberDataGridViewTextBoxColumn"
        '
        'AverageAutoDataGridViewTextBoxColumn
        '
        Me.AverageAutoDataGridViewTextBoxColumn.DataPropertyName = "Average Auto"
        Me.AverageAutoDataGridViewTextBoxColumn.HeaderText = "Average Auto"
        Me.AverageAutoDataGridViewTextBoxColumn.Name = "AverageAutoDataGridViewTextBoxColumn"
        '
        'AverageTeleOpDataGridViewTextBoxColumn
        '
        Me.AverageTeleOpDataGridViewTextBoxColumn.DataPropertyName = "Average TeleOp"
        Me.AverageTeleOpDataGridViewTextBoxColumn.HeaderText = "Average TeleOp"
        Me.AverageTeleOpDataGridViewTextBoxColumn.Name = "AverageTeleOpDataGridViewTextBoxColumn"
        '
        'AverageEndScoreDataGridViewTextBoxColumn
        '
        Me.AverageEndScoreDataGridViewTextBoxColumn.DataPropertyName = "Average End Score"
        Me.AverageEndScoreDataGridViewTextBoxColumn.HeaderText = "Average End Score"
        Me.AverageEndScoreDataGridViewTextBoxColumn.Name = "AverageEndScoreDataGridViewTextBoxColumn"
        '
        'RPDataGridViewTextBoxColumn
        '
        Me.RPDataGridViewTextBoxColumn.DataPropertyName = "RP"
        Me.RPDataGridViewTextBoxColumn.HeaderText = "RP"
        Me.RPDataGridViewTextBoxColumn.Name = "RPDataGridViewTextBoxColumn"
        '
        'QPDataGridViewTextBoxColumn
        '
        Me.QPDataGridViewTextBoxColumn.DataPropertyName = "QP"
        Me.QPDataGridViewTextBoxColumn.HeaderText = "QP"
        Me.QPDataGridViewTextBoxColumn.Name = "QPDataGridViewTextBoxColumn"
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.RankingsDataSet
        '
        'RankingsDataSet
        '
        Me.RankingsDataSet.DataSetName = "RankingsDataSet"
        Me.RankingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Team_NumberTextBox
        '
        Me.Team_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Team Number", True))
        Me.Team_NumberTextBox.Location = New System.Drawing.Point(140, 122)
        Me.Team_NumberTextBox.Name = "Team_NumberTextBox"
        Me.Team_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Team_NumberTextBox.TabIndex = 3
        '
        'Average_AutoTextBox
        '
        Me.Average_AutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Average Auto", True))
        Me.Average_AutoTextBox.Location = New System.Drawing.Point(140, 148)
        Me.Average_AutoTextBox.Name = "Average_AutoTextBox"
        Me.Average_AutoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Average_AutoTextBox.TabIndex = 5
        '
        'Average_TeleOpTextBox
        '
        Me.Average_TeleOpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Average TeleOp", True))
        Me.Average_TeleOpTextBox.Location = New System.Drawing.Point(140, 174)
        Me.Average_TeleOpTextBox.Name = "Average_TeleOpTextBox"
        Me.Average_TeleOpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Average_TeleOpTextBox.TabIndex = 7
        '
        'Average_End_ScoreTextBox
        '
        Me.Average_End_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Average End Score", True))
        Me.Average_End_ScoreTextBox.Location = New System.Drawing.Point(140, 200)
        Me.Average_End_ScoreTextBox.Name = "Average_End_ScoreTextBox"
        Me.Average_End_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Average_End_ScoreTextBox.TabIndex = 9
        '
        'RPTextBox
        '
        Me.RPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "RP", True))
        Me.RPTextBox.Location = New System.Drawing.Point(140, 226)
        Me.RPTextBox.Name = "RPTextBox"
        Me.RPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RPTextBox.TabIndex = 11
        '
        'QPTextBox
        '
        Me.QPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "QP", True))
        Me.QPTextBox.Location = New System.Drawing.Point(140, 252)
        Me.QPTextBox.Name = "QPTextBox"
        Me.QPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QPTextBox.TabIndex = 13
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MainTableTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = _10547ScoutingApp.RankingsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainTableBindingSource
        '
        Me.MainTableBindingSource.DataMember = "MainTable"
        Me.MainTableBindingSource.DataSource = Me.RankingsDataSet
        '
        'MainTableTableAdapter
        '
        Me.MainTableTableAdapter.ClearBeforeFill = True
        '
        'MatchNumberTextBox
        '
        Me.MatchNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "MatchNumber", True))
        Me.MatchNumberTextBox.Location = New System.Drawing.Point(352, 122)
        Me.MatchNumberTextBox.Name = "MatchNumberTextBox"
        Me.MatchNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MatchNumberTextBox.TabIndex = 15
        Me.MatchNumberTextBox.Visible = False
        '
        'Team_NumberTextBox1
        '
        Me.Team_NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "Team Number", True))
        Me.Team_NumberTextBox1.Location = New System.Drawing.Point(352, 148)
        Me.Team_NumberTextBox1.Name = "Team_NumberTextBox1"
        Me.Team_NumberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Team_NumberTextBox1.TabIndex = 17
        Me.Team_NumberTextBox1.Visible = False
        '
        'AutoTextBox
        '
        Me.AutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "Auto", True))
        Me.AutoTextBox.Location = New System.Drawing.Point(352, 174)
        Me.AutoTextBox.Name = "AutoTextBox"
        Me.AutoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AutoTextBox.TabIndex = 19
        Me.AutoTextBox.Visible = False
        '
        'TeleOpTextBox
        '
        Me.TeleOpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "TeleOp", True))
        Me.TeleOpTextBox.Location = New System.Drawing.Point(352, 200)
        Me.TeleOpTextBox.Name = "TeleOpTextBox"
        Me.TeleOpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeleOpTextBox.TabIndex = 21
        Me.TeleOpTextBox.Visible = False
        '
        'EndGameTextBox
        '
        Me.EndGameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTableBindingSource, "EndGame", True))
        Me.EndGameTextBox.Location = New System.Drawing.Point(352, 226)
        Me.EndGameTextBox.Name = "EndGameTextBox"
        Me.EndGameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndGameTextBox.TabIndex = 23
        Me.EndGameTextBox.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchNumberDataGridViewTextBoxColumn, Me.TeamNumberDataGridViewTextBoxColumn1, Me.AutoDataGridViewTextBoxColumn, Me.TeleOpDataGridViewTextBoxColumn, Me.EndGameDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MainTableBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(382, 229)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(292, 150)
        Me.DataGridView2.TabIndex = 24
        '
        'MatchNumberDataGridViewTextBoxColumn
        '
        Me.MatchNumberDataGridViewTextBoxColumn.DataPropertyName = "MatchNumber"
        Me.MatchNumberDataGridViewTextBoxColumn.HeaderText = "MatchNumber"
        Me.MatchNumberDataGridViewTextBoxColumn.Name = "MatchNumberDataGridViewTextBoxColumn"
        '
        'TeamNumberDataGridViewTextBoxColumn1
        '
        Me.TeamNumberDataGridViewTextBoxColumn1.DataPropertyName = "Team Number"
        Me.TeamNumberDataGridViewTextBoxColumn1.HeaderText = "Team Number"
        Me.TeamNumberDataGridViewTextBoxColumn1.Name = "TeamNumberDataGridViewTextBoxColumn1"
        '
        'AutoDataGridViewTextBoxColumn
        '
        Me.AutoDataGridViewTextBoxColumn.DataPropertyName = "Auto"
        Me.AutoDataGridViewTextBoxColumn.HeaderText = "Auto"
        Me.AutoDataGridViewTextBoxColumn.Name = "AutoDataGridViewTextBoxColumn"
        '
        'TeleOpDataGridViewTextBoxColumn
        '
        Me.TeleOpDataGridViewTextBoxColumn.DataPropertyName = "TeleOp"
        Me.TeleOpDataGridViewTextBoxColumn.HeaderText = "TeleOp"
        Me.TeleOpDataGridViewTextBoxColumn.Name = "TeleOpDataGridViewTextBoxColumn"
        '
        'EndGameDataGridViewTextBoxColumn
        '
        Me.EndGameDataGridViewTextBoxColumn.DataPropertyName = "EndGame"
        Me.EndGameDataGridViewTextBoxColumn.HeaderText = "EndGame"
        Me.EndGameDataGridViewTextBoxColumn.Name = "EndGameDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(593, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rankings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(MatchNumberLabel)
        Me.Controls.Add(Me.MatchNumberTextBox)
        Me.Controls.Add(Team_NumberLabel1)
        Me.Controls.Add(Me.Team_NumberTextBox1)
        Me.Controls.Add(AutoLabel)
        Me.Controls.Add(Me.AutoTextBox)
        Me.Controls.Add(TeleOpLabel)
        Me.Controls.Add(Me.TeleOpTextBox)
        Me.Controls.Add(EndGameLabel)
        Me.Controls.Add(Me.EndGameTextBox)
        Me.Controls.Add(Team_NumberLabel)
        Me.Controls.Add(Me.Team_NumberTextBox)
        Me.Controls.Add(Average_AutoLabel)
        Me.Controls.Add(Me.Average_AutoTextBox)
        Me.Controls.Add(Average_TeleOpLabel)
        Me.Controls.Add(Me.Average_TeleOpTextBox)
        Me.Controls.Add(Average_End_ScoreLabel)
        Me.Controls.Add(Me.Average_End_ScoreTextBox)
        Me.Controls.Add(RPLabel)
        Me.Controls.Add(Me.RPTextBox)
        Me.Controls.Add(QPLabel)
        Me.Controls.Add(Me.QPTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Rankings"
        Me.Text = "Rankings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankingsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAndCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseWithoutSavingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RankingsDataSet As _10547ScoutingApp.RankingsDataSet
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableTableAdapter As _10547ScoutingApp.RankingsDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TeamNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageAutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageTeleOpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageEndScoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As _10547ScoutingApp.RankingsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Team_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_AutoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_TeleOpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_End_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MainTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainTableTableAdapter As _10547ScoutingApp.RankingsDataSetTableAdapters.MainTableTableAdapter
    Friend WithEvents MatchNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Team_NumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AutoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeleOpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndGameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents MatchNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeamNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleOpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndGameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
