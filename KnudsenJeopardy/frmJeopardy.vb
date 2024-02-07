Public Class frmJeopardy
    'Knudsen Jeopardy

    'Sound (Jeopardy theme): http://www.orangefreesounds.com/jeopardy-theme-song/
    'Icon (Jeopardy Symbol - Also, I used an .ico converter): https://images-na.ssl-images-amazon.com/images/I/31M2GpmH5VL._SY355_.png
    'Background: https://images.squarespace-cdn.com/content/v1/5bc58608348cd9430c0c030d/1545076815317-ZKSB19U6SBJCUC26ZMZ3/ke17ZwdGBToddI8pDm48kNvT88LknE-K9M4pGNO0Iqd7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1UbeDbaZv1s3QfpIA4TYnL5Qao8BosUKjCVjCf8TKewJIH3bqxw7fF48mhrq5Ulr0Hg/New+Background.png

    Public booMode As Boolean
    Public strIndividual As String
    Public intPlayerMoney As Integer
    Public dblPlayerPercent As Double

    Public strPlayers() As String
    Public intMoney() As Integer
    Public dblPercentCorrect() As Double
    Public intNumCorrect As Integer
    Public intNumQuestions As Integer
    Public intPlays As Integer = 0
    Public intHighestScoreIndex(1) As Integer
    Public booFirstPercentRanked As Boolean = False

    'mnuRankings.Tag = "r"
    'mnuRules.Tag = "u"

    Private Sub BUTTON_Clicks(sender As Object, e As EventArgs) Handles btnProceed.Click, mnuProceed.Click
        Static intRandomNames As Integer = 0
        Dim str1stHalfName() As String = {"yeet", "champion", "trivia", "crying", "happy"}
        Dim str2ndHalfName() As String = {"onion", "legend", "smarty", "moose", "deer"}
        strIndividual = InputBox("Enter your player name, RANDOM to get a random name, or CANCEL to.. well.. cancel.", Me.Text)

        'loops while strindividual is greater than 15 characters, has already been used, or has nothing in it
        Do While strIndividual.Length > 15 Or SearchArray(strIndividual, strPlayers) = True Or strIndividual = Nothing Or (strIndividual.ToUpper = "RANDOM" And intRandomNames = 25)
            If strIndividual.Length > 15 Then
                strIndividual = InputBox("Make sure your player name is 15 characters or less. You can also enter RANDOM to get a random name or enter CANCEL to quit.", Me.Text)
            ElseIf SearchArray(strIndividual, strPlayers) = True Then
                strIndividual = InputBox("This name has already been used. Enter a different one, RANDOM to get a random name, or CANCEL to quit.", Me.Text)
            ElseIf strIndividual = Nothing Then
                strIndividual = InputBox("Enter your player name, RANDOM to get a random name, or CANCEL to quit.", Me.Text)
            Else
                strIndividual = InputBox("I'm sorry, but all of the random names have been used. Enter a player name or CANCEL to quit.", Me.Text)
            End If
        Loop

        If strIndividual.ToUpper = "CANCEL" Then
            Exit Sub
        ElseIf strIndividual.ToUpper = "RANDOM" Then
            Do
                strIndividual = str1stHalfName(RandInt(0, 4)) + str2ndHalfName(RandInt(0, 4))
            Loop While SearchArray(strIndividual, strPlayers) = True
            intRandomNames += 1
        End If

        frmPreMadeSets.Show()
    End Sub

    Private Sub mnuRankings_Click(sender As Object, e As EventArgs) Handles mnuRankings.Click, mnuRules.Click
        Dim mnuJeopardy As ToolStripMenuItem = sender
        Select Case mnuJeopardy.Tag
            Case "r"
                frmRankings.Show()
            Case "u"
                frmRules.Show()
        End Select
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    'Pre: takes a string to find in a string array
    'Post: returns true if string found and false if not
    Function SearchArray(ByVal strSearch As String, ByVal strArray() As String) As Boolean
        If strArray Is Nothing Then
            Return False
            Exit Function
        End If
        For intIndex As Integer = 0 To strArray.Length - 1
            If strSearch = strArray(intIndex) Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    'Pre: two numbers that set range for random numbers
    'Post: random number within range of two numbers
    Function RandInt(ByVal intOne, ByVal intTwo) As Integer
        Static objRandom As New Random
        Return objRandom.Next(intOne, intTwo + 1)
    End Function

End Class
