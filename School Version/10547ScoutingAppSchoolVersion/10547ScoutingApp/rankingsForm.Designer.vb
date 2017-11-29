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
        Me.MainDataDataSet = New _10547ScoutingApp.mainDataDataSet1()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New _10547ScoutingApp.mainDataDataSet1TableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New _10547ScoutingApp.mainDataDataSet1TableAdapters.TableAdapterManager()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Match_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Team_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Auto_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.TeleOp_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.End_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Total_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.btnClearData = New System.Windows.Forms.Button()
        Match_NumberLabel = New System.Windows.Forms.Label()
        Team_NumberLabel = New System.Windows.Forms.Label()
        Auto_ScoreLabel = New System.Windows.Forms.Label()
        TeleOp_ScoreLabel = New System.Windows.Forms.Label()
        End_ScoreLabel = New System.Windows.Forms.Label()
        Total_ScoreLabel = New System.Windows.Forms.Label()
        CType(Me.MainDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainDataDataSet
        '
        Me.MainDataDataSet.DataSetName = "mainDataDataSet1"
        Me.MainDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.TableAdapterManager.UpdateOrder = _10547ScoutingApp.mainDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(12, 69)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(675, 220)
        Me.TableDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Match Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Match Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Team Number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Team Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Auto Score"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Auto Score"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TeleOp Score"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TeleOp Score"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "End Score"
        Me.DataGridViewTextBoxColumn11.HeaderText = "End Score"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Total Score"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total Score"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Match_NumberLabel
        '
        Match_NumberLabel.AutoSize = True
        Match_NumberLabel.Location = New System.Drawing.Point(120, 347)
        Match_NumberLabel.Name = "Match_NumberLabel"
        Match_NumberLabel.Size = New System.Drawing.Size(80, 13)
        Match_NumberLabel.TabIndex = 14
        Match_NumberLabel.Text = "Match Number:"
        '
        'Match_NumberTextBox
        '
        Me.Match_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Match Number", True))
        Me.Match_NumberTextBox.Location = New System.Drawing.Point(206, 344)
        Me.Match_NumberTextBox.Name = "Match_NumberTextBox"
        Me.Match_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Match_NumberTextBox.TabIndex = 15
        '
        'Team_NumberLabel
        '
        Team_NumberLabel.AutoSize = True
        Team_NumberLabel.Location = New System.Drawing.Point(120, 373)
        Team_NumberLabel.Name = "Team_NumberLabel"
        Team_NumberLabel.Size = New System.Drawing.Size(77, 13)
        Team_NumberLabel.TabIndex = 16
        Team_NumberLabel.Text = "Team Number:"
        '
        'Team_NumberTextBox
        '
        Me.Team_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Team Number", True))
        Me.Team_NumberTextBox.Location = New System.Drawing.Point(206, 370)
        Me.Team_NumberTextBox.Name = "Team_NumberTextBox"
        Me.Team_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Team_NumberTextBox.TabIndex = 17
        '
        'Auto_ScoreLabel
        '
        Auto_ScoreLabel.AutoSize = True
        Auto_ScoreLabel.Location = New System.Drawing.Point(120, 399)
        Auto_ScoreLabel.Name = "Auto_ScoreLabel"
        Auto_ScoreLabel.Size = New System.Drawing.Size(63, 13)
        Auto_ScoreLabel.TabIndex = 18
        Auto_ScoreLabel.Text = "Auto Score:"
        '
        'Auto_ScoreTextBox
        '
        Me.Auto_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Auto Score", True))
        Me.Auto_ScoreTextBox.Location = New System.Drawing.Point(206, 396)
        Me.Auto_ScoreTextBox.Name = "Auto_ScoreTextBox"
        Me.Auto_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Auto_ScoreTextBox.TabIndex = 19
        '
        'TeleOp_ScoreLabel
        '
        TeleOp_ScoreLabel.AutoSize = True
        TeleOp_ScoreLabel.Location = New System.Drawing.Point(120, 425)
        TeleOp_ScoreLabel.Name = "TeleOp_ScoreLabel"
        TeleOp_ScoreLabel.Size = New System.Drawing.Size(79, 13)
        TeleOp_ScoreLabel.TabIndex = 20
        TeleOp_ScoreLabel.Text = "Tele Op Score:"
        '
        'TeleOp_ScoreTextBox
        '
        Me.TeleOp_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "TeleOp Score", True))
        Me.TeleOp_ScoreTextBox.Location = New System.Drawing.Point(206, 422)
        Me.TeleOp_ScoreTextBox.Name = "TeleOp_ScoreTextBox"
        Me.TeleOp_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeleOp_ScoreTextBox.TabIndex = 21
        '
        'End_ScoreLabel
        '
        End_ScoreLabel.AutoSize = True
        End_ScoreLabel.Location = New System.Drawing.Point(120, 451)
        End_ScoreLabel.Name = "End_ScoreLabel"
        End_ScoreLabel.Size = New System.Drawing.Size(60, 13)
        End_ScoreLabel.TabIndex = 22
        End_ScoreLabel.Text = "End Score:"
        '
        'End_ScoreTextBox
        '
        Me.End_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "End Score", True))
        Me.End_ScoreTextBox.Location = New System.Drawing.Point(206, 448)
        Me.End_ScoreTextBox.Name = "End_ScoreTextBox"
        Me.End_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.End_ScoreTextBox.TabIndex = 23
        '
        'Total_ScoreLabel
        '
        Total_ScoreLabel.AutoSize = True
        Total_ScoreLabel.Location = New System.Drawing.Point(120, 477)
        Total_ScoreLabel.Name = "Total_ScoreLabel"
        Total_ScoreLabel.Size = New System.Drawing.Size(65, 13)
        Total_ScoreLabel.TabIndex = 24
        Total_ScoreLabel.Text = "Total Score:"
        '
        'Total_ScoreTextBox
        '
        Me.Total_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Total Score", True))
        Me.Total_ScoreTextBox.Location = New System.Drawing.Point(206, 474)
        Me.Total_ScoreTextBox.Name = "Total_ScoreTextBox"
        Me.Total_ScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_ScoreTextBox.TabIndex = 25
        '
        'btnClearData
        '
        Me.btnClearData.Location = New System.Drawing.Point(612, 295)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(75, 23)
        Me.btnClearData.TabIndex = 26
        Me.btnClearData.Text = "Clear Data?"
        Me.btnClearData.UseVisualStyleBackColor = True
        '
        'rankingsForm
        '
        Me.ClientSize = New System.Drawing.Size(699, 514)
        Me.Controls.Add(Me.btnClearData)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "rankingsForm"
        CType(Me.MainDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainDataDataSet As _10547ScoutingApp.mainDataDataSet1
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableTableAdapter As _10547ScoutingApp.mainDataDataSet1TableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As _10547ScoutingApp.mainDataDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Match_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Team_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Auto_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeleOp_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents End_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_ScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnClearData As System.Windows.Forms.Button
End Class
