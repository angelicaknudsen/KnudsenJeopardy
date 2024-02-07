Public Class frmSetDescription
    'Knudsen Jeopardy
    'This is just a message box form.

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim mnuSet() As ToolStripMenuItem = {frmPreMadeSets.mnuMath, frmPreMadeSets.mnuMemes}
        Call frmQuestion.DisableButton(frmPreMadeSets.btnSet)
        mnuSet(Val(frmPreMadeSets.btnSet.Tag.chars(frmPreMadeSets.btnSet.Tag.length - 1))).Enabled = False
        frmPreMadeSets.intSetsUsed += 1
        frmBoard.Show()
        frmPreMadeSets.Hide()
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

End Class