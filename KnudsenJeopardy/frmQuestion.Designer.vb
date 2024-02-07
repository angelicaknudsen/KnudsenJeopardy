<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion))
        Me.mnuJeopardy = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubmit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRankings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblCorrectOrNot = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCatnMoney = New System.Windows.Forms.Label()
        Me.lblPlayerStats = New System.Windows.Forms.Label()
        Me.tmrQuestion = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.mnuJeopardy.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuJeopardy
        '
        Me.mnuJeopardy.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuJeopardy.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuJeopardy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuRankings, Me.mnuRules})
        Me.mnuJeopardy.Location = New System.Drawing.Point(0, 0)
        Me.mnuJeopardy.Name = "mnuJeopardy"
        Me.mnuJeopardy.Size = New System.Drawing.Size(800, 33)
        Me.mnuJeopardy.TabIndex = 4
        Me.mnuJeopardy.Text = "Jeopardy"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSubmit, Me.mnuNext, Me.mnuCancel, Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.White
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "&File"
        '
        'mnuSubmit
        '
        Me.mnuSubmit.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuSubmit.ForeColor = System.Drawing.Color.White
        Me.mnuSubmit.Name = "mnuSubmit"
        Me.mnuSubmit.Size = New System.Drawing.Size(153, 30)
        Me.mnuSubmit.Text = "Su&bmit"
        '
        'mnuNext
        '
        Me.mnuNext.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuNext.Enabled = False
        Me.mnuNext.ForeColor = System.Drawing.Color.White
        Me.mnuNext.Name = "mnuNext"
        Me.mnuNext.Size = New System.Drawing.Size(153, 30)
        Me.mnuNext.Text = "N&ext"
        '
        'mnuCancel
        '
        Me.mnuCancel.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuCancel.ForeColor = System.Drawing.Color.White
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(153, 30)
        Me.mnuCancel.Text = "C&ancel"
        '
        'mnuExit
        '
        Me.mnuExit.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuExit.ForeColor = System.Drawing.Color.White
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(153, 30)
        Me.mnuExit.Text = "&Exit"
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
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.DarkBlue
        Me.lblQuestion.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(124, 95)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(555, 146)
        Me.lblQuestion.TabIndex = 22
        Me.lblQuestion.Text = "QUESTION"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(126, 282)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(550, 26)
        Me.txtAnswer.TabIndex = 0
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Perpetua Titling MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblAnswer.Location = New System.Drawing.Point(292, 248)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(206, 29)
        Me.lblAnswer.TabIndex = 24
        Me.lblAnswer.Text = "ANSWER"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Perpetua Titling MT", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(338, 320)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 34)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Tag = "submit"
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblCorrectOrNot
        '
        Me.lblCorrectOrNot.BackColor = System.Drawing.Color.Transparent
        Me.lblCorrectOrNot.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectOrNot.ForeColor = System.Drawing.Color.Black
        Me.lblCorrectOrNot.Location = New System.Drawing.Point(124, 361)
        Me.lblCorrectOrNot.Name = "lblCorrectOrNot"
        Me.lblCorrectOrNot.Size = New System.Drawing.Size(555, 30)
        Me.lblCorrectOrNot.TabIndex = 26
        Me.lblCorrectOrNot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DarkBlue
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Perpetua Titling MT", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(696, 444)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 34)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Perpetua Titling MT", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 444)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCatnMoney
        '
        Me.lblCatnMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblCatnMoney.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatnMoney.ForeColor = System.Drawing.Color.Black
        Me.lblCatnMoney.Location = New System.Drawing.Point(279, 37)
        Me.lblCatnMoney.Name = "lblCatnMoney"
        Me.lblCatnMoney.Size = New System.Drawing.Size(261, 58)
        Me.lblCatnMoney.TabIndex = 29
        Me.lblCatnMoney.Text = "CatNMoney"
        Me.lblCatnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerStats
        '
        Me.lblPlayerStats.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerStats.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerStats.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerStats.Location = New System.Drawing.Point(129, 392)
        Me.lblPlayerStats.Name = "lblPlayerStats"
        Me.lblPlayerStats.Size = New System.Drawing.Size(419, 89)
        Me.lblPlayerStats.TabIndex = 30
        Me.lblPlayerStats.Text = "Stats"
        Me.lblPlayerStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrQuestion
        '
        Me.tmrQuestion.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLeft.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.lblTimeLeft.ForeColor = System.Drawing.Color.Black
        Me.lblTimeLeft.Location = New System.Drawing.Point(554, 429)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(136, 49)
        Me.lblTimeLeft.TabIndex = 31
        Me.lblTimeLeft.Text = "Time Left: 30 s"
        Me.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblPlayerStats)
        Me.Controls.Add(Me.lblCatnMoney)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblCorrectOrNot)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.mnuJeopardy)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestion"
        Me.Text = "Jeopardy"
        Me.mnuJeopardy.ResumeLayout(False)
        Me.mnuJeopardy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuJeopardy As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuRules As ToolStripMenuItem
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblCorrectOrNot As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCatnMoney As Label
    Friend WithEvents lblPlayerStats As Label
    Friend WithEvents tmrQuestion As Timer
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents mnuRankings As ToolStripMenuItem
    Friend WithEvents mnuSubmit As ToolStripMenuItem
    Friend WithEvents mnuNext As ToolStripMenuItem
    Friend WithEvents mnuCancel As ToolStripMenuItem
End Class
