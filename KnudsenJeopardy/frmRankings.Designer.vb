<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRankings))
        Me.mnuJeopardy = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRankings = New System.Windows.Forms.Label()
        Me.lblRankingsTitle = New System.Windows.Forms.Label()
        Me.lblMostMoney = New System.Windows.Forms.Label()
        Me.lblHighestPercentCorrect = New System.Windows.Forms.Label()
        Me.lblBeware = New System.Windows.Forms.Label()
        Me.mnuJeopardy.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuJeopardy
        '
        Me.mnuJeopardy.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuJeopardy.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuJeopardy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuJeopardy.Location = New System.Drawing.Point(0, 0)
        Me.mnuJeopardy.Name = "mnuJeopardy"
        Me.mnuJeopardy.Size = New System.Drawing.Size(669, 33)
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
        Me.mnuBack.Size = New System.Drawing.Size(132, 30)
        Me.mnuBack.Text = "&Back"
        '
        'lblRankings
        '
        Me.lblRankings.AutoSize = True
        Me.lblRankings.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblRankings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRankings.Location = New System.Drawing.Point(57, 148)
        Me.lblRankings.Name = "lblRankings"
        Me.lblRankings.Size = New System.Drawing.Size(23, 22)
        Me.lblRankings.TabIndex = 21
        Me.lblRankings.Text = "..."
        '
        'lblRankingsTitle
        '
        Me.lblRankingsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblRankingsTitle.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankingsTitle.ForeColor = System.Drawing.Color.Black
        Me.lblRankingsTitle.Location = New System.Drawing.Point(185, 47)
        Me.lblRankingsTitle.Name = "lblRankingsTitle"
        Me.lblRankingsTitle.Size = New System.Drawing.Size(261, 58)
        Me.lblRankingsTitle.TabIndex = 30
        Me.lblRankingsTitle.Text = "RANKINGS"
        Me.lblRankingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMostMoney
        '
        Me.lblMostMoney.AutoSize = True
        Me.lblMostMoney.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblMostMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMostMoney.Location = New System.Drawing.Point(345, 148)
        Me.lblMostMoney.Name = "lblMostMoney"
        Me.lblMostMoney.Size = New System.Drawing.Size(101, 42)
        Me.lblMostMoney.TabIndex = 34
        Me.lblMostMoney.Text = "Most Money:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "..."
        '
        'lblHighestPercentCorrect
        '
        Me.lblHighestPercentCorrect.AutoSize = True
        Me.lblHighestPercentCorrect.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblHighestPercentCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighestPercentCorrect.Location = New System.Drawing.Point(345, 198)
        Me.lblHighestPercentCorrect.Name = "lblHighestPercentCorrect"
        Me.lblHighestPercentCorrect.Size = New System.Drawing.Size(185, 42)
        Me.lblHighestPercentCorrect.TabIndex = 35
        Me.lblHighestPercentCorrect.Text = "Highest Percent Correct:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "..."
        '
        'lblBeware
        '
        Me.lblBeware.BackColor = System.Drawing.Color.Transparent
        Me.lblBeware.Font = New System.Drawing.Font("Perpetua Titling MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblBeware.ForeColor = System.Drawing.Color.Black
        Me.lblBeware.Location = New System.Drawing.Point(12, 42)
        Me.lblBeware.Name = "lblBeware"
        Me.lblBeware.Size = New System.Drawing.Size(148, 63)
        Me.lblBeware.TabIndex = 36
        Me.lblBeware.Text = "Don't exit to return" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do: FILE > BACK"
        Me.lblBeware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRankings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(669, 450)
        Me.Controls.Add(Me.lblBeware)
        Me.Controls.Add(Me.lblHighestPercentCorrect)
        Me.Controls.Add(Me.lblMostMoney)
        Me.Controls.Add(Me.lblRankingsTitle)
        Me.Controls.Add(Me.lblRankings)
        Me.Controls.Add(Me.mnuJeopardy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRankings"
        Me.Text = "Jeopardy"
        Me.mnuJeopardy.ResumeLayout(False)
        Me.mnuJeopardy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuJeopardy As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents lblRankings As Label
    Friend WithEvents lblRankingsTitle As Label
    Friend WithEvents lblMostMoney As Label
    Friend WithEvents lblHighestPercentCorrect As Label
    Friend WithEvents lblBeware As Label
End Class
