<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreMadeSets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreMadeSets))
        Me.btnMemes = New System.Windows.Forms.Button()
        Me.btnMath = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblPreMadeSets = New System.Windows.Forms.Label()
        Me.mnuJeopardy = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMath = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRankings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPlayerStats = New System.Windows.Forms.Label()
        Me.mnuJeopardy.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMemes
        '
        Me.btnMemes.BackColor = System.Drawing.Color.OrangeRed
        Me.btnMemes.Font = New System.Drawing.Font("Perpetua Titling MT", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemes.ForeColor = System.Drawing.Color.White
        Me.btnMemes.Location = New System.Drawing.Point(584, 320)
        Me.btnMemes.Name = "btnMemes"
        Me.btnMemes.Size = New System.Drawing.Size(133, 50)
        Me.btnMemes.TabIndex = 1
        Me.btnMemes.Tag = "memes1"
        Me.btnMemes.Text = "M&EMES"
        Me.btnMemes.UseVisualStyleBackColor = False
        '
        'btnMath
        '
        Me.btnMath.BackColor = System.Drawing.Color.Sienna
        Me.btnMath.Font = New System.Drawing.Font("Perpetua Titling MT", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMath.ForeColor = System.Drawing.Color.White
        Me.btnMath.Location = New System.Drawing.Point(241, 230)
        Me.btnMath.Name = "btnMath"
        Me.btnMath.Size = New System.Drawing.Size(133, 50)
        Me.btnMath.TabIndex = 0
        Me.btnMath.Tag = "math0"
        Me.btnMath.Text = "&MATH"
        Me.btnMath.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.DarkRed
        Me.btnDone.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(67, 506)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(133, 50)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "&DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'lblPreMadeSets
        '
        Me.lblPreMadeSets.AutoSize = True
        Me.lblPreMadeSets.BackColor = System.Drawing.Color.Transparent
        Me.lblPreMadeSets.Font = New System.Drawing.Font("Perpetua Titling MT", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreMadeSets.ForeColor = System.Drawing.Color.White
        Me.lblPreMadeSets.Location = New System.Drawing.Point(275, 60)
        Me.lblPreMadeSets.Name = "lblPreMadeSets"
        Me.lblPreMadeSets.Size = New System.Drawing.Size(453, 63)
        Me.lblPreMadeSets.TabIndex = 18
        Me.lblPreMadeSets.Text = "PRE MADE SETS"
        '
        'mnuJeopardy
        '
        Me.mnuJeopardy.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuJeopardy.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuJeopardy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuRankings, Me.mnuRules, Me.mnuDone})
        Me.mnuJeopardy.Location = New System.Drawing.Point(0, 0)
        Me.mnuJeopardy.Name = "mnuJeopardy"
        Me.mnuJeopardy.Size = New System.Drawing.Size(1014, 33)
        Me.mnuJeopardy.TabIndex = 3
        Me.mnuJeopardy.Text = "Jeopardy"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSets, Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.White
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "&File"
        '
        'mnuSets
        '
        Me.mnuSets.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuSets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMath, Me.mnuMemes})
        Me.mnuSets.ForeColor = System.Drawing.Color.White
        Me.mnuSets.Name = "mnuSets"
        Me.mnuSets.Size = New System.Drawing.Size(129, 30)
        Me.mnuSets.Text = "Se&ts"
        '
        'mnuMath
        '
        Me.mnuMath.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuMath.ForeColor = System.Drawing.Color.White
        Me.mnuMath.Name = "mnuMath"
        Me.mnuMath.Size = New System.Drawing.Size(154, 30)
        Me.mnuMath.Tag = "math0"
        Me.mnuMath.Text = "M&ath"
        '
        'mnuMemes
        '
        Me.mnuMemes.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuMemes.ForeColor = System.Drawing.Color.White
        Me.mnuMemes.Name = "mnuMemes"
        Me.mnuMemes.Size = New System.Drawing.Size(154, 30)
        Me.mnuMemes.Tag = "memes1"
        Me.mnuMemes.Text = "Meme&s"
        '
        'mnuExit
        '
        Me.mnuExit.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuExit.ForeColor = System.Drawing.Color.White
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(129, 30)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuRankings
        '
        Me.mnuRankings.ForeColor = System.Drawing.Color.White
        Me.mnuRankings.Name = "mnuRankings"
        Me.mnuRankings.Size = New System.Drawing.Size(96, 29)
        Me.mnuRankings.Text = "&Rankings"
        '
        'mnuRules
        '
        Me.mnuRules.ForeColor = System.Drawing.Color.White
        Me.mnuRules.Name = "mnuRules"
        Me.mnuRules.Size = New System.Drawing.Size(66, 29)
        Me.mnuRules.Text = "R&ules"
        '
        'mnuDone
        '
        Me.mnuDone.ForeColor = System.Drawing.Color.White
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(67, 29)
        Me.mnuDone.Text = "D&one"
        '
        'lblPlayerStats
        '
        Me.lblPlayerStats.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerStats.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerStats.ForeColor = System.Drawing.Color.White
        Me.lblPlayerStats.Location = New System.Drawing.Point(330, 457)
        Me.lblPlayerStats.Name = "lblPlayerStats"
        Me.lblPlayerStats.Size = New System.Drawing.Size(368, 109)
        Me.lblPlayerStats.TabIndex = 62
        Me.lblPlayerStats.Text = "STATS"
        Me.lblPlayerStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPreMadeSets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KnudsenJeopardy.My.Resources.Resources._4da8754cfdcf7ab
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 585)
        Me.Controls.Add(Me.lblPlayerStats)
        Me.Controls.Add(Me.lblPreMadeSets)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnMath)
        Me.Controls.Add(Me.btnMemes)
        Me.Controls.Add(Me.mnuJeopardy)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuJeopardy
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPreMadeSets"
        Me.Text = "Jeopardy"
        Me.mnuJeopardy.ResumeLayout(False)
        Me.mnuJeopardy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMemes As Button
    Friend WithEvents btnMath As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lblPreMadeSets As Label
    Friend WithEvents mnuJeopardy As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuRules As ToolStripMenuItem
    Friend WithEvents lblPlayerStats As Label
    Friend WithEvents mnuRankings As ToolStripMenuItem
    Friend WithEvents mnuDone As ToolStripMenuItem
    Friend WithEvents mnuSets As ToolStripMenuItem
    Friend WithEvents mnuMath As ToolStripMenuItem
    Friend WithEvents mnuMemes As ToolStripMenuItem
End Class
