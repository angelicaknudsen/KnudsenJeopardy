Public Class frmBoard
    'Knudsen Jeopardy

    'Background graphic: https://wallpaperaccess.com/full/276412.jpg

    Public cat(5) As String
    Public intUsed As Integer
    Public intButtonNum As Integer
    Public btnBoard As Button

    Private Sub frmBoard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim catLabels() = {Me.lblCat1, Me.lblCat2, Me.lblCat3, Me.lblCat4, Me.lblCat5, Me.lblCat6}

        Me.lblBoard.Text = frmPreMadeSets.btnSet.Tag.Substring(0, frmPreMadeSets.btnSet.Tag.Length - 1)
        Call frmQuestion.PlayerStats(Me.lblPlayerStats, frmJeopardy.strIndividual, frmJeopardy.intPlayerMoney, frmJeopardy.dblPlayerPercent)

        Select Case frmPreMadeSets.btnSet.Tag
            Case "math0"
                cat = {"Solve for X", "Trig", "Quadratic", "Perm/Comb", "Prob", "Other"}
            Case "memes1"
                cat = {"SURREAL", "ROBLOX", "CLASSIC", "MUSIC", "MUSIC II", "RANDOM"}
        End Select

        For intIndex As Integer = 0 To 5
            catLabels(intIndex).Text = cat(intIndex)
        Next
    End Sub

    Private Sub BOARDBUTTONS_Clicks(sender As Object, e As EventArgs) Handles btn1000C1.Click, btn1000C2.Click, btn1000C3.Click, btn1000C4.Click, btn1000C5.Click, btn1000C6.Click,
                                                                              btn200C1.Click, btn200C2.Click, btn200C3.Click, btn200C4.Click, btn200C5.Click, btn200C6.Click,
                                                                              btn400C1.Click, btn400C2.Click, btn400C3.Click, btn400C4.Click, btn400C5.Click, btn400C6.Click,
                                                                              btn600C1.Click, btn600C2.Click, btn600C3.Click, btn600C4.Click, btn600C5.Click, btn600C6.Click,
                                                                              btn800C1.Click, btn800C2.Click, btn800C3.Click, btn800C4.Click, btn800C5.Click, btn800C6.Click
        btnBoard = sender
        Call frmQuestion.DisableButton(btnBoard)
        intButtonNum = Val(btnBoard.Tag)    'the tags do have text in them as well, but the Val function only draws out the number (thankfully)
        intUsed += 1
        frmQuestion.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmPreMadeSets.Show()
        frmPreMadeSets.lblPlayerStats.Visible = True
        Call frmQuestion.PlayerStats(frmPreMadeSets.lblPlayerStats, frmJeopardy.strIndividual, frmJeopardy.intPlayerMoney, frmJeopardy.dblPlayerPercent)
        If frmPreMadeSets.intSetsUsed = 2 Then
            Call SetsUsed()
        End If
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click, mnuDone.Click
        Dim mnuSet() As ToolStripMenuItem = {frmPreMadeSets.mnuMath, frmPreMadeSets.mnuMemes}
        Dim colorArray() As Color = {Color.Sienna, Color.OrangeRed}  'I went a bit extra to allow the user to re-enable the button if they choose to end playing the set (and I used the button back colors)
        Dim userOption As DialogResult = MessageBox.Show("Are you sure you want to cancel? 'Yes' will re-enable the button to this set, 'Cancel' will end this set, and 'No' will just close this message box.", Me.Text, MessageBoxButtons.YesNoCancel)
        If userOption = DialogResult.No Then
            Exit Sub
        ElseIf userOption = DialogResult.Yes Then
            frmPreMadeSets.intSetsUsed -= 1
            frmPreMadeSets.btnSet.Enabled = True
            mnuSet(Val(frmPreMadeSets.btnSet.Tag.chars(frmPreMadeSets.btnSet.Tag.length - 1))).Enabled = True
            frmPreMadeSets.btnSet.BackColor = colorArray(Val(frmPreMadeSets.btnSet.Tag.chars(frmPreMadeSets.btnSet.Tag.length - 1)))
        ElseIf userOption = DialogResult.Cancel Then
            If frmPreMadeSets.intSetsUsed = 2 Then
                Call SetsUsed()
                frmJeopardy.btnProceed.Enabled = True
                Me.Close()
                Exit Sub
            End If
        End If

        frmPreMadeSets.Show()
        Call frmQuestion.PlayerStats(frmPreMadeSets.lblPlayerStats, frmJeopardy.strIndividual, frmJeopardy.intPlayerMoney, frmJeopardy.dblPlayerPercent)
        Me.Close()
    End Sub

    'I call this everytime someone leaves playing a set to see if they went through all of them
    Sub SetsUsed()
        Me.Hide()
        Call frmPreMadeSets.AddToRankings()
        Call frmPreMadeSets.HighestScorer(frmJeopardy.intMoney, "Most Money:", 0, frmRankings.lblMostMoney)
        frmJeopardy.intPlayerMoney = 0
        frmJeopardy.dblPlayerPercent = 0
        frmJeopardy.intNumCorrect = 0
        frmJeopardy.intNumQuestions = 0
        frmPreMadeSets.intSetsUsed = 0
        frmJeopardy.intPlays += 1
        MessageBox.Show("You went through all of the sets, so you finished your play. You were put into the rankings.", Me.Text)
        frmPreMadeSets.Close()
    End Sub

    Private Sub mnuRules_Click(sender As Object, e As EventArgs) Handles mnuRules.Click
        frmRules.Show()
    End Sub
End Class