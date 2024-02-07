<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRules))
        Me.mnuJeopardy = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChooseOne = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOverview = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPreMadeSets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBoard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinishedPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRulesTitle = New System.Windows.Forms.Label()
        Me.radOverview = New System.Windows.Forms.RadioButton()
        Me.grpRules = New System.Windows.Forms.GroupBox()
        Me.radFinishedPlay = New System.Windows.Forms.RadioButton()
        Me.radQuestion = New System.Windows.Forms.RadioButton()
        Me.radBoard = New System.Windows.Forms.RadioButton()
        Me.radMainMenu = New System.Windows.Forms.RadioButton()
        Me.radPreMadeSets = New System.Windows.Forms.RadioButton()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.mnuJeopardy.SuspendLayout()
        Me.grpRules.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuJeopardy
        '
        Me.mnuJeopardy.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuJeopardy.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuJeopardy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuChooseOne})
        Me.mnuJeopardy.Location = New System.Drawing.Point(0, 0)
        Me.mnuJeopardy.Name = "mnuJeopardy"
        Me.mnuJeopardy.Size = New System.Drawing.Size(695, 33)
        Me.mnuJeopardy.TabIndex = 0
        Me.mnuJeopardy.Text = "Jeopardy"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack})
        Me.mnuFile.ForeColor = System.Drawing.Color.White
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "&File"
        '
        'mnuBack
        '
        Me.mnuBack.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(252, 30)
        Me.mnuBack.Text = "Bac&k"
        '
        'mnuChooseOne
        '
        Me.mnuChooseOne.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOverview, Me.mnuMainMenu, Me.mnuPreMadeSets, Me.mnuBoard, Me.mnuQuestion, Me.mnuFinishedPlay})
        Me.mnuChooseOne.ForeColor = System.Drawing.Color.White
        Me.mnuChooseOne.Name = "mnuChooseOne"
        Me.mnuChooseOne.Size = New System.Drawing.Size(122, 29)
        Me.mnuChooseOne.Text = "C&hoose One"
        '
        'mnuOverview
        '
        Me.mnuOverview.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuOverview.ForeColor = System.Drawing.Color.White
        Me.mnuOverview.Name = "mnuOverview"
        Me.mnuOverview.Size = New System.Drawing.Size(209, 30)
        Me.mnuOverview.Tag = "0"
        Me.mnuOverview.Text = "O&verview"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuMainMenu.ForeColor = System.Drawing.Color.White
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(209, 30)
        Me.mnuMainMenu.Tag = "1"
        Me.mnuMainMenu.Text = "M&ain Menu"
        '
        'mnuPreMadeSets
        '
        Me.mnuPreMadeSets.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuPreMadeSets.ForeColor = System.Drawing.Color.White
        Me.mnuPreMadeSets.Name = "mnuPreMadeSets"
        Me.mnuPreMadeSets.Size = New System.Drawing.Size(209, 30)
        Me.mnuPreMadeSets.Tag = "2"
        Me.mnuPreMadeSets.Text = "P&re Made Sets"
        '
        'mnuBoard
        '
        Me.mnuBoard.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuBoard.ForeColor = System.Drawing.Color.White
        Me.mnuBoard.Name = "mnuBoard"
        Me.mnuBoard.Size = New System.Drawing.Size(209, 30)
        Me.mnuBoard.Tag = "3"
        Me.mnuBoard.Text = "Boar&d"
        '
        'mnuQuestion
        '
        Me.mnuQuestion.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuQuestion.ForeColor = System.Drawing.Color.White
        Me.mnuQuestion.Name = "mnuQuestion"
        Me.mnuQuestion.Size = New System.Drawing.Size(209, 30)
        Me.mnuQuestion.Tag = "4"
        Me.mnuQuestion.Text = "Q&uestion"
        '
        'mnuFinishedPlay
        '
        Me.mnuFinishedPlay.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuFinishedPlay.ForeColor = System.Drawing.Color.White
        Me.mnuFinishedPlay.Name = "mnuFinishedPlay"
        Me.mnuFinishedPlay.Size = New System.Drawing.Size(209, 30)
        Me.mnuFinishedPlay.Tag = "5"
        Me.mnuFinishedPlay.Text = "Fi&nished Play"
        '
        'lblRulesTitle
        '
        Me.lblRulesTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblRulesTitle.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRulesTitle.ForeColor = System.Drawing.Color.Black
        Me.lblRulesTitle.Location = New System.Drawing.Point(168, 52)
        Me.lblRulesTitle.Name = "lblRulesTitle"
        Me.lblRulesTitle.Size = New System.Drawing.Size(393, 58)
        Me.lblRulesTitle.TabIndex = 31
        Me.lblRulesTitle.Text = "RULES/DIRECTIONS"
        Me.lblRulesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radOverview
        '
        Me.radOverview.AutoSize = True
        Me.radOverview.Checked = True
        Me.radOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOverview.Location = New System.Drawing.Point(6, 25)
        Me.radOverview.Name = "radOverview"
        Me.radOverview.Size = New System.Drawing.Size(97, 24)
        Me.radOverview.TabIndex = 0
        Me.radOverview.TabStop = True
        Me.radOverview.Tag = "0"
        Me.radOverview.Text = "&Overview"
        Me.radOverview.UseVisualStyleBackColor = True
        '
        'grpRules
        '
        Me.grpRules.Controls.Add(Me.radFinishedPlay)
        Me.grpRules.Controls.Add(Me.radQuestion)
        Me.grpRules.Controls.Add(Me.radOverview)
        Me.grpRules.Controls.Add(Me.radBoard)
        Me.grpRules.Controls.Add(Me.radMainMenu)
        Me.grpRules.Controls.Add(Me.radPreMadeSets)
        Me.grpRules.Location = New System.Drawing.Point(30, 148)
        Me.grpRules.Name = "grpRules"
        Me.grpRules.Size = New System.Drawing.Size(154, 203)
        Me.grpRules.TabIndex = 33
        Me.grpRules.TabStop = False
        Me.grpRules.Text = "Choose one"
        '
        'radFinishedPlay
        '
        Me.radFinishedPlay.AutoSize = True
        Me.radFinishedPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFinishedPlay.Location = New System.Drawing.Point(6, 163)
        Me.radFinishedPlay.Name = "radFinishedPlay"
        Me.radFinishedPlay.Size = New System.Drawing.Size(127, 24)
        Me.radFinishedPlay.TabIndex = 5
        Me.radFinishedPlay.Tag = "5"
        Me.radFinishedPlay.Text = "F&inished Play"
        Me.radFinishedPlay.UseVisualStyleBackColor = True
        '
        'radQuestion
        '
        Me.radQuestion.AutoSize = True
        Me.radQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radQuestion.Location = New System.Drawing.Point(6, 133)
        Me.radQuestion.Name = "radQuestion"
        Me.radQuestion.Size = New System.Drawing.Size(98, 24)
        Me.radQuestion.TabIndex = 4
        Me.radQuestion.Tag = "4"
        Me.radQuestion.Text = "&Question"
        Me.radQuestion.UseVisualStyleBackColor = True
        '
        'radBoard
        '
        Me.radBoard.AutoSize = True
        Me.radBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBoard.Location = New System.Drawing.Point(6, 106)
        Me.radBoard.Name = "radBoard"
        Me.radBoard.Size = New System.Drawing.Size(77, 24)
        Me.radBoard.TabIndex = 3
        Me.radBoard.Tag = "3"
        Me.radBoard.Text = "&Board"
        Me.radBoard.UseVisualStyleBackColor = True
        '
        'radMainMenu
        '
        Me.radMainMenu.AutoSize = True
        Me.radMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMainMenu.Location = New System.Drawing.Point(6, 52)
        Me.radMainMenu.Name = "radMainMenu"
        Me.radMainMenu.Size = New System.Drawing.Size(112, 24)
        Me.radMainMenu.TabIndex = 1
        Me.radMainMenu.Tag = "1"
        Me.radMainMenu.Text = "&Main Menu"
        Me.radMainMenu.UseVisualStyleBackColor = True
        '
        'radPreMadeSets
        '
        Me.radPreMadeSets.AutoSize = True
        Me.radPreMadeSets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPreMadeSets.Location = New System.Drawing.Point(6, 79)
        Me.radPreMadeSets.Name = "radPreMadeSets"
        Me.radPreMadeSets.Size = New System.Drawing.Size(139, 24)
        Me.radPreMadeSets.TabIndex = 2
        Me.radPreMadeSets.Tag = "2"
        Me.radPreMadeSets.Text = "&Pre Made Sets"
        Me.radPreMadeSets.UseVisualStyleBackColor = True
        '
        'lblRules
        '
        Me.lblRules.BackColor = System.Drawing.Color.Transparent
        Me.lblRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRules.ForeColor = System.Drawing.Color.Black
        Me.lblRules.Location = New System.Drawing.Point(208, 121)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(475, 288)
        Me.lblRules.TabIndex = 34
        Me.lblRules.Text = resources.GetString("lblRules.Text")
        Me.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(695, 418)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.grpRules)
        Me.Controls.Add(Me.lblRulesTitle)
        Me.Controls.Add(Me.mnuJeopardy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRules"
        Me.Text = "Jeopardy"
        Me.mnuJeopardy.ResumeLayout(False)
        Me.mnuJeopardy.PerformLayout()
        Me.grpRules.ResumeLayout(False)
        Me.grpRules.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuJeopardy As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents lblRulesTitle As Label
    Friend WithEvents radOverview As RadioButton
    Friend WithEvents grpRules As GroupBox
    Friend WithEvents radQuestion As RadioButton
    Friend WithEvents radBoard As RadioButton
    Friend WithEvents radMainMenu As RadioButton
    Friend WithEvents radPreMadeSets As RadioButton
    Friend WithEvents lblRules As Label
    Friend WithEvents mnuChooseOne As ToolStripMenuItem
    Friend WithEvents mnuOverview As ToolStripMenuItem
    Friend WithEvents mnuMainMenu As ToolStripMenuItem
    Friend WithEvents mnuPreMadeSets As ToolStripMenuItem
    Friend WithEvents mnuBoard As ToolStripMenuItem
    Friend WithEvents mnuQuestion As ToolStripMenuItem
    Friend WithEvents mnuFinishedPlay As ToolStripMenuItem
    Friend WithEvents radFinishedPlay As RadioButton
End Class
