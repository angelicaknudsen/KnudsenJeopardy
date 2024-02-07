<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetDescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetDescription))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblContinue = New System.Windows.Forms.Label()
        Me.lblLOLAreyousure = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Bisque
        Me.lblDescription.Location = New System.Drawing.Point(23, 66)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(418, 241)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Just some random stuff."
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Bisque
        Me.btnProceed.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProceed.Location = New System.Drawing.Point(253, 345)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(126, 41)
        Me.btnProceed.TabIndex = 1
        Me.btnProceed.Text = "&HECK YES"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Bisque
        Me.btnNo.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNo.Location = New System.Drawing.Point(80, 345)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(126, 41)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "&um no"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblContinue
        '
        Me.lblContinue.AutoSize = True
        Me.lblContinue.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinue.ForeColor = System.Drawing.Color.Bisque
        Me.lblContinue.Location = New System.Drawing.Point(150, 307)
        Me.lblContinue.Name = "lblContinue"
        Me.lblContinue.Size = New System.Drawing.Size(159, 21)
        Me.lblContinue.TabIndex = 3
        Me.lblContinue.Text = "Want to continue?"
        '
        'lblLOLAreyousure
        '
        Me.lblLOLAreyousure.AutoSize = True
        Me.lblLOLAreyousure.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLOLAreyousure.ForeColor = System.Drawing.Color.Bisque
        Me.lblLOLAreyousure.Location = New System.Drawing.Point(23, 18)
        Me.lblLOLAreyousure.Name = "lblLOLAreyousure"
        Me.lblLOLAreyousure.Size = New System.Drawing.Size(403, 19)
        Me.lblLOLAreyousure.TabIndex = 4
        Me.lblLOLAreyousure.Text = "Do you know what you're getting yourself into?"
        '
        'frmSetDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(470, 421)
        Me.Controls.Add(Me.lblLOLAreyousure)
        Me.Controls.Add(Me.lblContinue)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.lblDescription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetDescription"
        Me.Text = "Jeopardy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescription As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents lblContinue As Label
    Friend WithEvents lblLOLAreyousure As Label
End Class
