<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamImport
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
        Me.btnExportTeams = New System.Windows.Forms.Button()
        Me.btnShowTeams = New System.Windows.Forms.Button()
        Me.txtNewTeams = New System.Windows.Forms.TextBox()
        Me.lblTeamsToBeAdded = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblListTeam = New System.Windows.Forms.Label()
        Me.lstTeams = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExportTeams
        '
        Me.btnExportTeams.Location = New System.Drawing.Point(186, 196)
        Me.btnExportTeams.Name = "btnExportTeams"
        Me.btnExportTeams.Size = New System.Drawing.Size(86, 53)
        Me.btnExportTeams.TabIndex = 0
        Me.btnExportTeams.Text = "Input New Teams"
        Me.btnExportTeams.UseVisualStyleBackColor = True
        '
        'btnShowTeams
        '
        Me.btnShowTeams.Location = New System.Drawing.Point(94, 196)
        Me.btnShowTeams.Name = "btnShowTeams"
        Me.btnShowTeams.Size = New System.Drawing.Size(86, 52)
        Me.btnShowTeams.TabIndex = 1
        Me.btnShowTeams.Text = "Show All Teams"
        Me.btnShowTeams.UseVisualStyleBackColor = True
        '
        'txtNewTeams
        '
        Me.txtNewTeams.Location = New System.Drawing.Point(94, 89)
        Me.txtNewTeams.Name = "txtNewTeams"
        Me.txtNewTeams.Size = New System.Drawing.Size(100, 20)
        Me.txtNewTeams.TabIndex = 2
        '
        'lblTeamsToBeAdded
        '
        Me.lblTeamsToBeAdded.AutoSize = True
        Me.lblTeamsToBeAdded.Location = New System.Drawing.Point(15, 92)
        Me.lblTeamsToBeAdded.Name = "lblTeamsToBeAdded"
        Me.lblTeamsToBeAdded.Size = New System.Drawing.Size(73, 13)
        Me.lblTeamsToBeAdded.TabIndex = 3
        Me.lblTeamsToBeAdded.Text = "Teams Added"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblListTeam
        '
        Me.lblListTeam.AutoSize = True
        Me.lblListTeam.Location = New System.Drawing.Point(15, 132)
        Me.lblListTeam.Name = "lblListTeam"
        Me.lblListTeam.Size = New System.Drawing.Size(52, 13)
        Me.lblListTeam.TabIndex = 6
        Me.lblListTeam.Text = "All teams:"
        '
        'lstTeams
        '
        Me.lstTeams.FormattingEnabled = True
        Me.lstTeams.Location = New System.Drawing.Point(73, 132)
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(120, 56)
        Me.lstTeams.TabIndex = 7
        '
        'TeamImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstTeams)
        Me.Controls.Add(Me.lblListTeam)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTeamsToBeAdded)
        Me.Controls.Add(Me.txtNewTeams)
        Me.Controls.Add(Me.btnShowTeams)
        Me.Controls.Add(Me.btnExportTeams)
        Me.Name = "TeamImport"
        Me.Text = "Team Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExportTeams As Button
    Friend WithEvents btnShowTeams As Button
    Friend WithEvents txtNewTeams As TextBox
    Friend WithEvents lblTeamsToBeAdded As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblListTeam As Label
    Friend WithEvents lstTeams As ListBox
End Class
