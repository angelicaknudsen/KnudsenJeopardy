<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoard))
        Me.btnDone = New System.Windows.Forms.Button()
        Me.mnuJeopardy = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRankings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn200C1 = New System.Windows.Forms.Button()
        Me.btn200C5 = New System.Windows.Forms.Button()
        Me.btn200C4 = New System.Windows.Forms.Button()
        Me.btn200C3 = New System.Windows.Forms.Button()
        Me.btn200C2 = New System.Windows.Forms.Button()
        Me.btn200C6 = New System.Windows.Forms.Button()
        Me.btn1000C6 = New System.Windows.Forms.Button()
        Me.btn1000C2 = New System.Windows.Forms.Button()
        Me.btn1000C3 = New System.Windows.Forms.Button()
        Me.btn1000C4 = New System.Windows.Forms.Button()
        Me.btn1000C5 = New System.Windows.Forms.Button()
        Me.btn1000C1 = New System.Windows.Forms.Button()
        Me.btn800C6 = New System.Windows.Forms.Button()
        Me.btn800C2 = New System.Windows.Forms.Button()
        Me.btn800C3 = New System.Windows.Forms.Button()
        Me.btn800C4 = New System.Windows.Forms.Button()
        Me.btn800C5 = New System.Windows.Forms.Button()
        Me.btn800C1 = New System.Windows.Forms.Button()
        Me.btn600C6 = New System.Windows.Forms.Button()
        Me.btn600C2 = New System.Windows.Forms.Button()
        Me.btn600C3 = New System.Windows.Forms.Button()
        Me.btn600C4 = New System.Windows.Forms.Button()
        Me.btn600C5 = New System.Windows.Forms.Button()
        Me.btn600C1 = New System.Windows.Forms.Button()
        Me.btn400C6 = New System.Windows.Forms.Button()
        Me.btn400C2 = New System.Windows.Forms.Button()
        Me.btn400C3 = New System.Windows.Forms.Button()
        Me.btn400C4 = New System.Windows.Forms.Button()
        Me.btn400C5 = New System.Windows.Forms.Button()
        Me.btn400C1 = New System.Windows.Forms.Button()
        Me.lblBoard = New System.Windows.Forms.Label()
        Me.lblCat1 = New System.Windows.Forms.Label()
        Me.lblCat2 = New System.Windows.Forms.Label()
        Me.lblCat4 = New System.Windows.Forms.Label()
        Me.lblCat3 = New System.Windows.Forms.Label()
        Me.lblCat5 = New System.Windows.Forms.Label()
        Me.lblCat6 = New System.Windows.Forms.Label()
        Me.lblPlayerStats = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.mnuJeopardy.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.DarkBlue
        Me.btnDone.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(67, 527)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(133, 50)
        Me.btnDone.TabIndex = 30
        Me.btnDone.Text = "&DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'mnuJeopardy
        '
        Me.mnuJeopardy.BackColor = System.Drawing.Color.DarkBlue
        Me.mnuJeopardy.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuJeopardy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuRankings, Me.mnuRules, Me.mnuDone})
        Me.mnuJeopardy.Location = New System.Drawing.Point(0, 0)
        Me.mnuJeopardy.Name = "mnuJeopardy"
        Me.mnuJeopardy.Size = New System.Drawing.Size(1014, 33)
        Me.mnuJeopardy.TabIndex = 31
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
        Me.mnuExit.Size = New System.Drawing.Size(123, 30)
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
        'mnuDone
        '
        Me.mnuDone.ForeColor = System.Drawing.Color.White
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(67, 29)
        Me.mnuDone.Text = "D&one"
        '
        'btn200C1
        '
        Me.btn200C1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn200C1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200C1.ForeColor = System.Drawing.Color.White
        Me.btn200C1.Location = New System.Drawing.Point(90, 176)
        Me.btn200C1.Name = "btn200C1"
        Me.btn200C1.Size = New System.Drawing.Size(133, 50)
        Me.btn200C1.TabIndex = 0
        Me.btn200C1.Tag = "0"
        Me.btn200C1.Text = "$200"
        Me.btn200C1.UseVisualStyleBackColor = False
        '
        'btn200C5
        '
        Me.btn200C5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn200C5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200C5.ForeColor = System.Drawing.Color.White
        Me.btn200C5.Location = New System.Drawing.Point(646, 176)
        Me.btn200C5.Name = "btn200C5"
        Me.btn200C5.Size = New System.Drawing.Size(133, 50)
        Me.btn200C5.TabIndex = 4
        Me.btn200C5.Tag = "4"
        Me.btn200C5.Text = "$200"
        Me.btn200C5.UseVisualStyleBackColor = False
        '
        'btn200C4
        '
        Me.btn200C4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn200C4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200C4.ForeColor = System.Drawing.Color.White
        Me.btn200C4.Location = New System.Drawing.Point(507, 176)
        Me.btn200C4.Name = "btn200C4"
        Me.btn200C4.Size = New System.Drawing.Size(133, 50)
        Me.btn200C4.TabIndex = 3
        Me.btn200C4.Tag = "3"
        Me.btn200C4.Text = "$200"
        Me.btn200C4.UseVisualStyleBackColor = False
        '
        'btn200C3
        '
        Me.btn200C3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn200C3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200C3.ForeColor = System.Drawing.Color.White
        Me.btn200C3.Location = New System.Drawing.Point(368, 176)
        Me.btn200C3.Name = "btn200C3"
        Me.btn200C3.Size = New System.Drawing.Size(133, 50)
        Me.btn200C3.TabIndex = 2
        Me.btn200C3.Tag = "2"
        Me.btn200C3.Text = "$200"
        Me.btn200C3.UseVisualStyleBackColor = False
        '
        'btn200C2
        '
        Me.btn200C2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn200C2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200C2.ForeColor = System.Drawing.Color.White
        Me.btn200C2.Location = New System.Drawing.Point(229, 176)
        Me.btn200C2.Name = "btn200C2"
        Me.btn200C2.Size = New System.Drawing.Size(133, 50)
        Me.btn200C2.TabIndex = 1
        Me.btn200C2.Tag = "1"
        Me.btn200C2.Text = "$200"
        Me.btn200C2.UseVisualStyleBackColor = False
        '
        'btn200C6
        '
        Me.btn200C6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn200C6.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200C6.ForeColor = System.Drawing.Color.White
        Me.btn200C6.Location = New System.Drawing.Point(785, 176)
        Me.btn200C6.Name = "btn200C6"
        Me.btn200C6.Size = New System.Drawing.Size(133, 50)
        Me.btn200C6.TabIndex = 5
        Me.btn200C6.Tag = "5"
        Me.btn200C6.Text = "$200"
        Me.btn200C6.UseVisualStyleBackColor = False
        '
        'btn1000C6
        '
        Me.btn1000C6.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn1000C6.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000C6.ForeColor = System.Drawing.Color.White
        Me.btn1000C6.Location = New System.Drawing.Point(785, 403)
        Me.btn1000C6.Name = "btn1000C6"
        Me.btn1000C6.Size = New System.Drawing.Size(133, 50)
        Me.btn1000C6.TabIndex = 29
        Me.btn1000C6.Tag = "29"
        Me.btn1000C6.Text = "$1000"
        Me.btn1000C6.UseVisualStyleBackColor = False
        '
        'btn1000C2
        '
        Me.btn1000C2.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn1000C2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000C2.ForeColor = System.Drawing.Color.White
        Me.btn1000C2.Location = New System.Drawing.Point(229, 403)
        Me.btn1000C2.Name = "btn1000C2"
        Me.btn1000C2.Size = New System.Drawing.Size(133, 50)
        Me.btn1000C2.TabIndex = 25
        Me.btn1000C2.Tag = "25"
        Me.btn1000C2.Text = "$1000"
        Me.btn1000C2.UseVisualStyleBackColor = False
        '
        'btn1000C3
        '
        Me.btn1000C3.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn1000C3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000C3.ForeColor = System.Drawing.Color.White
        Me.btn1000C3.Location = New System.Drawing.Point(368, 403)
        Me.btn1000C3.Name = "btn1000C3"
        Me.btn1000C3.Size = New System.Drawing.Size(133, 50)
        Me.btn1000C3.TabIndex = 26
        Me.btn1000C3.Tag = "26"
        Me.btn1000C3.Text = "$1000"
        Me.btn1000C3.UseVisualStyleBackColor = False
        '
        'btn1000C4
        '
        Me.btn1000C4.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn1000C4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000C4.ForeColor = System.Drawing.Color.White
        Me.btn1000C4.Location = New System.Drawing.Point(507, 403)
        Me.btn1000C4.Name = "btn1000C4"
        Me.btn1000C4.Size = New System.Drawing.Size(133, 50)
        Me.btn1000C4.TabIndex = 27
        Me.btn1000C4.Tag = "27"
        Me.btn1000C4.Text = "$1000"
        Me.btn1000C4.UseVisualStyleBackColor = False
        '
        'btn1000C5
        '
        Me.btn1000C5.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn1000C5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000C5.ForeColor = System.Drawing.Color.White
        Me.btn1000C5.Location = New System.Drawing.Point(646, 403)
        Me.btn1000C5.Name = "btn1000C5"
        Me.btn1000C5.Size = New System.Drawing.Size(133, 50)
        Me.btn1000C5.TabIndex = 28
        Me.btn1000C5.Tag = "28"
        Me.btn1000C5.Text = "$1000"
        Me.btn1000C5.UseVisualStyleBackColor = False
        '
        'btn1000C1
        '
        Me.btn1000C1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn1000C1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000C1.ForeColor = System.Drawing.Color.White
        Me.btn1000C1.Location = New System.Drawing.Point(90, 403)
        Me.btn1000C1.Name = "btn1000C1"
        Me.btn1000C1.Size = New System.Drawing.Size(133, 50)
        Me.btn1000C1.TabIndex = 24
        Me.btn1000C1.Tag = "24"
        Me.btn1000C1.Text = "$1000"
        Me.btn1000C1.UseVisualStyleBackColor = False
        '
        'btn800C6
        '
        Me.btn800C6.BackColor = System.Drawing.Color.Purple
        Me.btn800C6.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn800C6.ForeColor = System.Drawing.Color.White
        Me.btn800C6.Location = New System.Drawing.Point(785, 347)
        Me.btn800C6.Name = "btn800C6"
        Me.btn800C6.Size = New System.Drawing.Size(133, 50)
        Me.btn800C6.TabIndex = 23
        Me.btn800C6.Tag = "23"
        Me.btn800C6.Text = "$800"
        Me.btn800C6.UseVisualStyleBackColor = False
        '
        'btn800C2
        '
        Me.btn800C2.BackColor = System.Drawing.Color.Purple
        Me.btn800C2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn800C2.ForeColor = System.Drawing.Color.White
        Me.btn800C2.Location = New System.Drawing.Point(229, 347)
        Me.btn800C2.Name = "btn800C2"
        Me.btn800C2.Size = New System.Drawing.Size(133, 50)
        Me.btn800C2.TabIndex = 19
        Me.btn800C2.Tag = "19"
        Me.btn800C2.Text = "$800"
        Me.btn800C2.UseVisualStyleBackColor = False
        '
        'btn800C3
        '
        Me.btn800C3.BackColor = System.Drawing.Color.Purple
        Me.btn800C3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn800C3.ForeColor = System.Drawing.Color.White
        Me.btn800C3.Location = New System.Drawing.Point(368, 347)
        Me.btn800C3.Name = "btn800C3"
        Me.btn800C3.Size = New System.Drawing.Size(133, 50)
        Me.btn800C3.TabIndex = 20
        Me.btn800C3.Tag = "20"
        Me.btn800C3.Text = "$800"
        Me.btn800C3.UseVisualStyleBackColor = False
        '
        'btn800C4
        '
        Me.btn800C4.BackColor = System.Drawing.Color.Purple
        Me.btn800C4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn800C4.ForeColor = System.Drawing.Color.White
        Me.btn800C4.Location = New System.Drawing.Point(507, 347)
        Me.btn800C4.Name = "btn800C4"
        Me.btn800C4.Size = New System.Drawing.Size(133, 50)
        Me.btn800C4.TabIndex = 21
        Me.btn800C4.Tag = "21"
        Me.btn800C4.Text = "$800"
        Me.btn800C4.UseVisualStyleBackColor = False
        '
        'btn800C5
        '
        Me.btn800C5.BackColor = System.Drawing.Color.Purple
        Me.btn800C5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn800C5.ForeColor = System.Drawing.Color.White
        Me.btn800C5.Location = New System.Drawing.Point(646, 347)
        Me.btn800C5.Name = "btn800C5"
        Me.btn800C5.Size = New System.Drawing.Size(133, 50)
        Me.btn800C5.TabIndex = 22
        Me.btn800C5.Tag = "22"
        Me.btn800C5.Text = "$800"
        Me.btn800C5.UseVisualStyleBackColor = False
        '
        'btn800C1
        '
        Me.btn800C1.BackColor = System.Drawing.Color.Purple
        Me.btn800C1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn800C1.ForeColor = System.Drawing.Color.White
        Me.btn800C1.Location = New System.Drawing.Point(90, 347)
        Me.btn800C1.Name = "btn800C1"
        Me.btn800C1.Size = New System.Drawing.Size(133, 50)
        Me.btn800C1.TabIndex = 18
        Me.btn800C1.Tag = "18"
        Me.btn800C1.Text = "$800"
        Me.btn800C1.UseVisualStyleBackColor = False
        '
        'btn600C6
        '
        Me.btn600C6.BackColor = System.Drawing.Color.Indigo
        Me.btn600C6.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn600C6.ForeColor = System.Drawing.Color.White
        Me.btn600C6.Location = New System.Drawing.Point(785, 291)
        Me.btn600C6.Name = "btn600C6"
        Me.btn600C6.Size = New System.Drawing.Size(133, 50)
        Me.btn600C6.TabIndex = 17
        Me.btn600C6.Tag = "17"
        Me.btn600C6.Text = "$600"
        Me.btn600C6.UseVisualStyleBackColor = False
        '
        'btn600C2
        '
        Me.btn600C2.BackColor = System.Drawing.Color.Indigo
        Me.btn600C2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn600C2.ForeColor = System.Drawing.Color.White
        Me.btn600C2.Location = New System.Drawing.Point(229, 291)
        Me.btn600C2.Name = "btn600C2"
        Me.btn600C2.Size = New System.Drawing.Size(133, 50)
        Me.btn600C2.TabIndex = 13
        Me.btn600C2.Tag = "13"
        Me.btn600C2.Text = "$600"
        Me.btn600C2.UseVisualStyleBackColor = False
        '
        'btn600C3
        '
        Me.btn600C3.BackColor = System.Drawing.Color.Indigo
        Me.btn600C3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn600C3.ForeColor = System.Drawing.Color.White
        Me.btn600C3.Location = New System.Drawing.Point(368, 291)
        Me.btn600C3.Name = "btn600C3"
        Me.btn600C3.Size = New System.Drawing.Size(133, 50)
        Me.btn600C3.TabIndex = 14
        Me.btn600C3.Tag = "14"
        Me.btn600C3.Text = "$600"
        Me.btn600C3.UseVisualStyleBackColor = False
        '
        'btn600C4
        '
        Me.btn600C4.BackColor = System.Drawing.Color.Indigo
        Me.btn600C4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn600C4.ForeColor = System.Drawing.Color.White
        Me.btn600C4.Location = New System.Drawing.Point(507, 291)
        Me.btn600C4.Name = "btn600C4"
        Me.btn600C4.Size = New System.Drawing.Size(133, 50)
        Me.btn600C4.TabIndex = 15
        Me.btn600C4.Tag = "15"
        Me.btn600C4.Text = "$600"
        Me.btn600C4.UseVisualStyleBackColor = False
        '
        'btn600C5
        '
        Me.btn600C5.BackColor = System.Drawing.Color.Indigo
        Me.btn600C5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn600C5.ForeColor = System.Drawing.Color.White
        Me.btn600C5.Location = New System.Drawing.Point(646, 291)
        Me.btn600C5.Name = "btn600C5"
        Me.btn600C5.Size = New System.Drawing.Size(133, 50)
        Me.btn600C5.TabIndex = 16
        Me.btn600C5.Tag = "16"
        Me.btn600C5.Text = "$600"
        Me.btn600C5.UseVisualStyleBackColor = False
        '
        'btn600C1
        '
        Me.btn600C1.BackColor = System.Drawing.Color.Indigo
        Me.btn600C1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn600C1.ForeColor = System.Drawing.Color.White
        Me.btn600C1.Location = New System.Drawing.Point(90, 291)
        Me.btn600C1.Name = "btn600C1"
        Me.btn600C1.Size = New System.Drawing.Size(133, 50)
        Me.btn600C1.TabIndex = 12
        Me.btn600C1.Tag = "12"
        Me.btn600C1.Text = "$600"
        Me.btn600C1.UseVisualStyleBackColor = False
        '
        'btn400C6
        '
        Me.btn400C6.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn400C6.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400C6.ForeColor = System.Drawing.Color.White
        Me.btn400C6.Location = New System.Drawing.Point(785, 235)
        Me.btn400C6.Name = "btn400C6"
        Me.btn400C6.Size = New System.Drawing.Size(133, 50)
        Me.btn400C6.TabIndex = 11
        Me.btn400C6.Tag = "11"
        Me.btn400C6.Text = "$400"
        Me.btn400C6.UseVisualStyleBackColor = False
        '
        'btn400C2
        '
        Me.btn400C2.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn400C2.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400C2.ForeColor = System.Drawing.Color.White
        Me.btn400C2.Location = New System.Drawing.Point(229, 235)
        Me.btn400C2.Name = "btn400C2"
        Me.btn400C2.Size = New System.Drawing.Size(133, 50)
        Me.btn400C2.TabIndex = 7
        Me.btn400C2.Tag = "7"
        Me.btn400C2.Text = "$400"
        Me.btn400C2.UseVisualStyleBackColor = False
        '
        'btn400C3
        '
        Me.btn400C3.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn400C3.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400C3.ForeColor = System.Drawing.Color.White
        Me.btn400C3.Location = New System.Drawing.Point(368, 235)
        Me.btn400C3.Name = "btn400C3"
        Me.btn400C3.Size = New System.Drawing.Size(133, 50)
        Me.btn400C3.TabIndex = 8
        Me.btn400C3.Tag = "8"
        Me.btn400C3.Text = "$400"
        Me.btn400C3.UseVisualStyleBackColor = False
        '
        'btn400C4
        '
        Me.btn400C4.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn400C4.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400C4.ForeColor = System.Drawing.Color.White
        Me.btn400C4.Location = New System.Drawing.Point(507, 235)
        Me.btn400C4.Name = "btn400C4"
        Me.btn400C4.Size = New System.Drawing.Size(133, 50)
        Me.btn400C4.TabIndex = 9
        Me.btn400C4.Tag = "9"
        Me.btn400C4.Text = "$400"
        Me.btn400C4.UseVisualStyleBackColor = False
        '
        'btn400C5
        '
        Me.btn400C5.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn400C5.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400C5.ForeColor = System.Drawing.Color.White
        Me.btn400C5.Location = New System.Drawing.Point(646, 235)
        Me.btn400C5.Name = "btn400C5"
        Me.btn400C5.Size = New System.Drawing.Size(133, 50)
        Me.btn400C5.TabIndex = 10
        Me.btn400C5.Tag = "10"
        Me.btn400C5.Text = "$400"
        Me.btn400C5.UseVisualStyleBackColor = False
        '
        'btn400C1
        '
        Me.btn400C1.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn400C1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn400C1.ForeColor = System.Drawing.Color.White
        Me.btn400C1.Location = New System.Drawing.Point(90, 235)
        Me.btn400C1.Name = "btn400C1"
        Me.btn400C1.Size = New System.Drawing.Size(133, 50)
        Me.btn400C1.TabIndex = 6
        Me.btn400C1.Tag = "6"
        Me.btn400C1.Text = "$400"
        Me.btn400C1.UseVisualStyleBackColor = False
        '
        'lblBoard
        '
        Me.lblBoard.BackColor = System.Drawing.Color.Transparent
        Me.lblBoard.Font = New System.Drawing.Font("Perpetua Titling MT", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoard.ForeColor = System.Drawing.Color.White
        Me.lblBoard.Location = New System.Drawing.Point(94, 48)
        Me.lblBoard.Name = "lblBoard"
        Me.lblBoard.Size = New System.Drawing.Size(828, 63)
        Me.lblBoard.TabIndex = 54
        Me.lblBoard.Text = "BOARD"
        Me.lblBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCat1
        '
        Me.lblCat1.BackColor = System.Drawing.Color.Transparent
        Me.lblCat1.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat1.ForeColor = System.Drawing.Color.White
        Me.lblCat1.Location = New System.Drawing.Point(90, 122)
        Me.lblCat1.Name = "lblCat1"
        Me.lblCat1.Size = New System.Drawing.Size(133, 51)
        Me.lblCat1.TabIndex = 55
        Me.lblCat1.Text = "Cat 1"
        Me.lblCat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCat2
        '
        Me.lblCat2.BackColor = System.Drawing.Color.Transparent
        Me.lblCat2.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat2.ForeColor = System.Drawing.Color.White
        Me.lblCat2.Location = New System.Drawing.Point(229, 122)
        Me.lblCat2.Name = "lblCat2"
        Me.lblCat2.Size = New System.Drawing.Size(133, 51)
        Me.lblCat2.TabIndex = 56
        Me.lblCat2.Text = "Cat 2"
        Me.lblCat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCat4
        '
        Me.lblCat4.BackColor = System.Drawing.Color.Transparent
        Me.lblCat4.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat4.ForeColor = System.Drawing.Color.White
        Me.lblCat4.Location = New System.Drawing.Point(503, 122)
        Me.lblCat4.Name = "lblCat4"
        Me.lblCat4.Size = New System.Drawing.Size(133, 51)
        Me.lblCat4.TabIndex = 57
        Me.lblCat4.Text = "Cat 4"
        Me.lblCat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCat3
        '
        Me.lblCat3.BackColor = System.Drawing.Color.Transparent
        Me.lblCat3.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat3.ForeColor = System.Drawing.Color.White
        Me.lblCat3.Location = New System.Drawing.Point(368, 122)
        Me.lblCat3.Name = "lblCat3"
        Me.lblCat3.Size = New System.Drawing.Size(133, 51)
        Me.lblCat3.TabIndex = 58
        Me.lblCat3.Text = "Cat 3"
        Me.lblCat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCat5
        '
        Me.lblCat5.BackColor = System.Drawing.Color.Transparent
        Me.lblCat5.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat5.ForeColor = System.Drawing.Color.White
        Me.lblCat5.Location = New System.Drawing.Point(646, 122)
        Me.lblCat5.Name = "lblCat5"
        Me.lblCat5.Size = New System.Drawing.Size(133, 51)
        Me.lblCat5.TabIndex = 59
        Me.lblCat5.Text = "Cat 5"
        Me.lblCat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCat6
        '
        Me.lblCat6.BackColor = System.Drawing.Color.Transparent
        Me.lblCat6.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat6.ForeColor = System.Drawing.Color.White
        Me.lblCat6.Location = New System.Drawing.Point(785, 122)
        Me.lblCat6.Name = "lblCat6"
        Me.lblCat6.Size = New System.Drawing.Size(133, 51)
        Me.lblCat6.TabIndex = 60
        Me.lblCat6.Text = "Cat 6"
        Me.lblCat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerStats
        '
        Me.lblPlayerStats.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerStats.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerStats.ForeColor = System.Drawing.Color.White
        Me.lblPlayerStats.Location = New System.Drawing.Point(279, 470)
        Me.lblPlayerStats.Name = "lblPlayerStats"
        Me.lblPlayerStats.Size = New System.Drawing.Size(455, 92)
        Me.lblPlayerStats.TabIndex = 61
        Me.lblPlayerStats.Text = "Stats"
        Me.lblPlayerStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.DarkBlue
        Me.btnContinue.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(793, 527)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(152, 50)
        Me.btnContinue.TabIndex = 32
        Me.btnContinue.Text = "&CONTINUE"
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.Visible = False
        '
        'frmBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KnudsenJeopardy.My.Resources.Resources.bluegalaxy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 585)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblPlayerStats)
        Me.Controls.Add(Me.lblCat6)
        Me.Controls.Add(Me.lblCat5)
        Me.Controls.Add(Me.lblCat3)
        Me.Controls.Add(Me.lblCat4)
        Me.Controls.Add(Me.lblCat2)
        Me.Controls.Add(Me.lblCat1)
        Me.Controls.Add(Me.lblBoard)
        Me.Controls.Add(Me.btn400C6)
        Me.Controls.Add(Me.btn400C2)
        Me.Controls.Add(Me.btn400C3)
        Me.Controls.Add(Me.btn400C4)
        Me.Controls.Add(Me.btn400C5)
        Me.Controls.Add(Me.btn400C1)
        Me.Controls.Add(Me.btn600C6)
        Me.Controls.Add(Me.btn600C2)
        Me.Controls.Add(Me.btn600C3)
        Me.Controls.Add(Me.btn600C4)
        Me.Controls.Add(Me.btn600C5)
        Me.Controls.Add(Me.btn600C1)
        Me.Controls.Add(Me.btn800C6)
        Me.Controls.Add(Me.btn800C2)
        Me.Controls.Add(Me.btn800C3)
        Me.Controls.Add(Me.btn800C4)
        Me.Controls.Add(Me.btn800C5)
        Me.Controls.Add(Me.btn800C1)
        Me.Controls.Add(Me.btn1000C6)
        Me.Controls.Add(Me.btn1000C2)
        Me.Controls.Add(Me.btn1000C3)
        Me.Controls.Add(Me.btn1000C4)
        Me.Controls.Add(Me.btn1000C5)
        Me.Controls.Add(Me.btn1000C1)
        Me.Controls.Add(Me.btn200C6)
        Me.Controls.Add(Me.btn200C2)
        Me.Controls.Add(Me.btn200C3)
        Me.Controls.Add(Me.btn200C4)
        Me.Controls.Add(Me.btn200C5)
        Me.Controls.Add(Me.btn200C1)
        Me.Controls.Add(Me.mnuJeopardy)
        Me.Controls.Add(Me.btnDone)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBoard"
        Me.Text = "Jeopardy"
        Me.mnuJeopardy.ResumeLayout(False)
        Me.mnuJeopardy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDone As Button
    Friend WithEvents mnuJeopardy As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuRules As ToolStripMenuItem
    Friend WithEvents btn200C1 As Button
    Friend WithEvents btn200C5 As Button
    Friend WithEvents btn200C4 As Button
    Friend WithEvents btn200C3 As Button
    Friend WithEvents btn200C2 As Button
    Friend WithEvents btn200C6 As Button
    Friend WithEvents btn1000C6 As Button
    Friend WithEvents btn1000C2 As Button
    Friend WithEvents btn1000C3 As Button
    Friend WithEvents btn1000C4 As Button
    Friend WithEvents btn1000C5 As Button
    Friend WithEvents btn1000C1 As Button
    Friend WithEvents btn800C6 As Button
    Friend WithEvents btn800C2 As Button
    Friend WithEvents btn800C3 As Button
    Friend WithEvents btn800C4 As Button
    Friend WithEvents btn800C5 As Button
    Friend WithEvents btn800C1 As Button
    Friend WithEvents btn600C6 As Button
    Friend WithEvents btn600C2 As Button
    Friend WithEvents btn600C3 As Button
    Friend WithEvents btn600C4 As Button
    Friend WithEvents btn600C5 As Button
    Friend WithEvents btn600C1 As Button
    Friend WithEvents btn400C6 As Button
    Friend WithEvents btn400C2 As Button
    Friend WithEvents btn400C3 As Button
    Friend WithEvents btn400C4 As Button
    Friend WithEvents btn400C5 As Button
    Friend WithEvents btn400C1 As Button
    Friend WithEvents lblBoard As Label
    Friend WithEvents lblCat1 As Label
    Friend WithEvents lblCat2 As Label
    Friend WithEvents lblCat4 As Label
    Friend WithEvents lblCat3 As Label
    Friend WithEvents lblCat5 As Label
    Friend WithEvents lblCat6 As Label
    Friend WithEvents lblPlayerStats As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents mnuDone As ToolStripMenuItem
    Friend WithEvents mnuRankings As ToolStripMenuItem
End Class
