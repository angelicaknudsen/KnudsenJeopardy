<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJeopardy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJeopardy))
        Me.lblJeopardy = New System.Windows.Forms.Label()
        Me.lblMyName = New System.Windows.Forms.Label()
        Me.mnuJeopardy = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRankings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.lblIndividualTitle = New System.Windows.Forms.Label()
        Me.mnuProceed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJeopardy.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJeopardy
        '
        Me.lblJeopardy.AutoSize = True
        Me.lblJeopardy.BackColor = System.Drawing.Color.Transparent
        Me.lblJeopardy.Font = New System.Drawing.Font("Perpetua Titling MT", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJeopardy.Location = New System.Drawing.Point(111, 172)
        Me.lblJeopardy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJeopardy.Name = "lblJeopardy"
        Me.lblJeopardy.Size = New System.Drawing.Size(803, 170)
        Me.lblJeopardy.TabIndex = 0
        Me.lblJeopardy.Text = "JEOPARDY"
        '
        'lblMyName
        '
        Me.lblMyName.AutoSize = True
        Me.lblMyName.BackColor = System.Drawing.Color.Transparent
        Me.lblMyName.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyName.Location = New System.Drawing.Point(381, 326)
        Me.lblMyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(270, 24)
        Me.lblMyName.TabIndex = 1
        Me.lblMyName.Text = "By Angelica Knudsen"
        '
        'mnuJeopardy
        '
        Me.mnuJeopardy.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuJeopardy.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuJeopardy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuRankings, Me.mnuRules, Me.mnuProceed})
        Me.mnuJeopardy.Location = New System.Drawing.Point(0, 0)
        Me.mnuJeopardy.Name = "mnuJeopardy"
        Me.mnuJeopardy.Size = New System.Drawing.Size(1014, 33)
        Me.mnuJeopardy.TabIndex = 1
        Me.mnuJeopardy.Text = "Jeopardy"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.White
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuExit.ForeColor = System.Drawing.Color.White
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(252, 30)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuRankings
        '
        Me.mnuRankings.ForeColor = System.Drawing.Color.White
        Me.mnuRankings.Name = "mnuRankings"
        Me.mnuRankings.Size = New System.Drawing.Size(96, 29)
        Me.mnuRankings.Tag = "r"
        Me.mnuRankings.Text = "&Rankings"
        '
        'mnuRules
        '
        Me.mnuRules.ForeColor = System.Drawing.Color.White
        Me.mnuRules.Name = "mnuRules"
        Me.mnuRules.Size = New System.Drawing.Size(66, 29)
        Me.mnuRules.Tag = "u"
        Me.mnuRules.Text = "R&ules"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnProceed.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(418, 435)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(166, 55)
        Me.btnProceed.TabIndex = 0
        Me.btnProceed.Tag = "pd"
        Me.btnProceed.Text = "&PROCEED"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'lblIndividualTitle
        '
        Me.lblIndividualTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblIndividualTitle.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndividualTitle.Location = New System.Drawing.Point(381, 162)
        Me.lblIndividualTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndividualTitle.Name = "lblIndividualTitle"
        Me.lblIndividualTitle.Size = New System.Drawing.Size(270, 24)
        Me.lblIndividualTitle.TabIndex = 25
        Me.lblIndividualTitle.Text = "(INDIVIDUAL)"
        Me.lblIndividualTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuProceed
        '
        Me.mnuProceed.ForeColor = System.Drawing.Color.White
        Me.mnuProceed.Name = "mnuProceed"
        Me.mnuProceed.Size = New System.Drawing.Size(88, 29)
        Me.mnuProceed.Text = "Procee&d"
        '
        'frmJeopardy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KnudsenJeopardy.My.Resources.Resources.New_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 585)
        Me.Controls.Add(Me.lblIndividualTitle)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.mnuJeopardy)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.lblJeopardy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmJeopardy"
        Me.Text = "Jeopardy"
        Me.mnuJeopardy.ResumeLayout(False)
        Me.mnuJeopardy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJeopardy As Label
    Friend WithEvents lblMyName As Label
    Friend WithEvents mnuJeopardy As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuRules As ToolStripMenuItem
    Friend WithEvents btnProceed As Button
    Friend WithEvents mnuRankings As ToolStripMenuItem
    Friend WithEvents lblIndividualTitle As Label
    Friend WithEvents mnuProceed As ToolStripMenuItem
End Class
