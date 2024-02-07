Public Class frmPreMadeSets
    'Knudsen Jeopardy

    'Background: https://art.pixilart.com/4da8754cfdcf7ab.png

    Public btnSet As Button
    Public intSetsUsed As Integer
    Public strRankings As String

    Private Sub frmPreMadeSets_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmJeopardy.btnProceed.Enabled = False
        Me.lblPlayerStats.Text = "Player: " & frmJeopardy.strIndividual
    End Sub

    Private Sub BUTTONS_Clicks(sender As Object, e As EventArgs) Handles btnMath.Click, btnMemes.Click, mnuMemes.Click, mnuMath.Click
        Select Case sender.tag      'I want to have the corresponding button be used instead of the menu item
            Case "math0"
                btnSet = Me.btnMath
            Case Else
                btnSet = Me.btnMemes
        End Select

        'I added periods after the single digit numbers since I use the val function, and this draws out only the number
        'I used these as titles by cutting off the last three characters off the btnSet.Tag string (you can see in the frmBoard code)
        Dim strSetDescription As String = ""
        Select Case btnSet.Tag
            Case "math0"
                strSetDescription = "This math set has a wide range of difficult problems. You are permitted to use paper, a writing utensil, and a calculator. All answers should be integers and not decimals, fractions, or percentages(unless specified). Good luck!"
            Case "memes1"
                strSetDescription = "With this set, you must be knowledgable in gen-z humor. There will be a wide range of topics, including dank memes, Roblox, and classic memes. Unlike the math set, for this board all you need is your brain and the ability to type. All the answers should be words. Good luck!"
        End Select

        frmSetDescription.lblDescription.Text = strSetDescription
        frmSetDescription.Show()
    End Sub

    Private Sub Done_Clicks(sender As Object, e As EventArgs) Handles btnDone.Click, mnuDone.Click
        Call Done()
    End Sub

    'asks whether player wants to finish their play (used in multiple forms)
    Sub Done()
        Dim dlgBack As DialogResult = MessageBox.Show("Are you sure you want to leave? This will end your play, and you will be placed in the rankings.", Me.Text, MessageBoxButtons.YesNo)

        If dlgBack = DialogResult.Yes Then
            Call AddToRankings()
            frmJeopardy.intPlayerMoney = 0
            frmJeopardy.dblPlayerPercent = 0
            frmJeopardy.intNumCorrect = 0
            frmJeopardy.intNumQuestions = 0
            frmJeopardy.intPlays += 1
            Me.intSetsUsed = 0
            frmJeopardy.btnProceed.Enabled = True
            Me.Close()
        End If
    End Sub

    'This will put the contents of a list into a string variable (vertically)
    'I will use this to display the rankings, like this:   strPlayer - M: intPlayermoney, %C: dblPercentCorrect
    Sub ArrayToString(ByVal strArray1() As String, ByVal intArray2() As Integer, ByVal dblArray3() As Double, ByRef strString As String)
        strString = "All Plays:" & vbCrLf
        For intIndex As Integer = 0 To strArray1.Length - 1
            If intIndex = 0 Then
                strString &= strArray1(0) & " - M: " & intArray2(0) & " %C: " & dblArray3(0)
            Else
                strString &= vbCrLf & strArray1(intIndex) & " - M: " & intArray2(intIndex) & " %C: " & dblArray3(intIndex)
            End If
        Next
    End Sub

    'Takes in a newly added number in a list and sees if it is higher than the highest in the same list
    'If it is, it will be put into the lblHighScorer
    Sub HighestScorer(ByVal numArray As Array, ByVal strIndicator As String, ByVal intIndex As Integer, ByRef lblHighScore As Label)
        If numArray(frmJeopardy.intPlays) > numArray(frmJeopardy.intHighestScoreIndex(intIndex)) Or frmJeopardy.intPlays = 0 Then
            lblHighScore.Text = strIndicator & vbCrLf & frmJeopardy.strIndividual & " - M: " & frmJeopardy.intMoney(frmJeopardy.intPlays) & " %C: " & frmJeopardy.dblPercentCorrect(frmJeopardy.intPlays)
            frmJeopardy.intHighestScoreIndex(intIndex) = frmJeopardy.intPlays
        Else
            lblHighScore.Text = strIndicator & vbCrLf & frmJeopardy.strPlayers(frmJeopardy.intHighestScoreIndex(intIndex)) & " - M: " & frmJeopardy.intMoney(frmJeopardy.intHighestScoreIndex(intIndex)) & " %C: " & frmJeopardy.dblPercentCorrect(frmJeopardy.intHighestScoreIndex(intIndex))
        End If
    End Sub

    'I keep three arrays: one with the player names, the second with their amount of money, and the third with the percent they got correct
    Sub AddToRankings()
        strRankings = ""
        ReDim Preserve frmJeopardy.strPlayers(frmJeopardy.intPlays) 'these will expand for every new player
        ReDim Preserve frmJeopardy.intMoney(frmJeopardy.intPlays)
        ReDim Preserve frmJeopardy.dblPercentCorrect(frmJeopardy.intPlays)

        'enters the player's stats and name into three separate lists
        frmJeopardy.strPlayers(frmJeopardy.intPlays) = frmJeopardy.strIndividual
        frmJeopardy.intMoney(frmJeopardy.intPlays) = frmJeopardy.intPlayerMoney
        frmJeopardy.dblPercentCorrect(frmJeopardy.intPlays) = PercentCorrect(frmJeopardy.intNumCorrect, frmJeopardy.intNumQuestions)

        Call ArrayToString(frmJeopardy.strPlayers, frmJeopardy.intMoney, frmJeopardy.dblPercentCorrect, strRankings)
        Call HighestScorer(frmJeopardy.intMoney, "Most Money:", 0, frmRankings.lblMostMoney)

        'A player can only be placed as having the highest percent if they went through 30 or more questions
        If frmJeopardy.intNumQuestions >= 30 Then
            'makes sure that when the first player qualifies to be put on the percent ranking board, they are put on it regardless of their other stats
            If frmJeopardy.booFirstPercentRanked = False Then
                frmJeopardy.booFirstPercentRanked = True
                frmJeopardy.intHighestScoreIndex(1) = frmJeopardy.intPlays
            End If

            Call HighestScorer(frmJeopardy.dblPercentCorrect, "Highest Percent Correct:", 1, frmRankings.lblHighestPercentCorrect)
        End If

        frmRankings.lblRankings.Text = strRankings  'this is a multi-line string
    End Sub

    'Pre: number correct and total number
    'Post: percent correct
    Function PercentCorrect(ByVal intCorrect As Integer, ByVal intTotal As Integer) As Double
        Return Math.Round(intCorrect / intTotal, 3, MidpointRounding.AwayFromZero) * 100
    End Function

    Private Sub mnuRankings_Click(sender As Object, e As EventArgs) Handles mnuRankings.Click
        frmRankings.Show()
    End Sub

    Private Sub mnuRules_Click(sender As Object, e As EventArgs) Handles mnuRules.Click
        frmRules.Show()
    End Sub
End Class