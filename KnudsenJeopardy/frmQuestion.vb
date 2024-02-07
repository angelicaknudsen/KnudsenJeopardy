Public Class frmQuestion
    'Knudsen Jeopardy

    Private Sub frmQuestion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strQuestion As String = ""
        Dim strMoney() As String = {"$200", "$400", "$600", "$800", "$1000"}

        Me.tmrQuestion.Enabled = True
        My.Computer.Audio.Play(My.Resources.Jeopardy_theme_song, AudioPlayMode.Background)

        Select Case frmPreMadeSets.btnSet.Tag
            Case "math0"
                Call Math(frmBoard.intButtonNum, strQuestion, Nothing)
            Case "memes1"
                Call Memes(frmBoard.intButtonNum, strQuestion, Nothing)
        End Select

        Me.lblQuestion.Text = strQuestion
        Me.lblCatnMoney.Text = frmBoard.cat(frmBoard.intButtonNum Mod 6) & " - " & strMoney(MoneyIndex(frmBoard.intButtonNum))
        Call PlayerStats(lblPlayerStats, frmJeopardy.strIndividual, frmJeopardy.intPlayerMoney, frmJeopardy.dblPlayerPercent)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click, mnuSubmit.Click
        If Me.txtAnswer.Text = Nothing Then
            MessageBox.Show("Make sure to enter an answer.", Me.Text)
            Exit Sub
        End If
        Call Submit()
    End Sub

    'I put this in a sub procedure so that it can be called in multiple types of events if needed
    Sub Submit()
        Dim strAnswer As String = ""
        Dim intMoney() As Integer = {200, 400, 600, 800, 1000}
        Dim strUserAnswer As String = Me.txtAnswer.Text

        frmJeopardy.intNumQuestions += 1

        Me.tmrQuestion.Enabled = False
        My.Computer.Audio.Stop()
        Call DisableButton(Me.btnSubmit)

        Select Case frmPreMadeSets.btnSet.Tag
            Case "math0"
                Call Math(frmBoard.intButtonNum, Nothing, strAnswer)
            Case "memes1"
                Call Memes(frmBoard.intButtonNum, Nothing, strAnswer)
        End Select

        If strUserAnswer.ToUpper = strAnswer.ToUpper Then
            frmJeopardy.intNumCorrect += 1
            Me.lblCorrectOrNot.Text = "Correct! The answer is " & strAnswer & "."
            frmJeopardy.intPlayerMoney += intMoney(MoneyIndex(frmBoard.intButtonNum))
        ElseIf strUserAnswer.ToUpper <> strAnswer.ToUpper And (frmBoard.intButtonNum <= 29 And frmBoard.intButtonNum >= 24) Then
            Me.lblCorrectOrNot.Text = "Incorrect, you failure of a human. The answer is " & strAnswer.ToUpper & "." 'take this as a JOKE
        Else
            Me.lblCorrectOrNot.Text = "Incorrect! The answer is " & strAnswer & "."
        End If

        frmJeopardy.dblPlayerPercent = frmPreMadeSets.PercentCorrect(frmJeopardy.intNumCorrect, frmJeopardy.intNumQuestions)

        Call PlayerStats(lblPlayerStats, frmJeopardy.strIndividual, frmJeopardy.intPlayerMoney, frmJeopardy.dblPlayerPercent)
        Call PlayerStats(frmBoard.lblPlayerStats, frmJeopardy.strIndividual, frmJeopardy.intPlayerMoney, frmJeopardy.dblPlayerPercent)

        Me.btnNext.Enabled = True
        Me.mnuNext.Enabled = True
    End Sub

    Private Sub tmrQuestion_Tick(sender As Object, e As EventArgs) Handles tmrQuestion.Tick
        Static intSecLeft As Integer = 30
        If intSecLeft = 0 Then
            Call Submit()
        Else
            intSecLeft -= 1
            Me.lblTimeLeft.Text = "Time Left: " & intSecLeft & " s"
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click, mnuNext.Click
        frmBoard.Show()
        Call NextSet()
        Me.Close()
    End Sub

    'when you cancel, your percent will go down if you didn't answer correctly since I don't erase the automatically added 1 to the number of questions you viewed
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, mnuCancel.Click
        Dim colorArray() As Color = {Color.FromArgb(0, 10, 75), Color.MidnightBlue, Color.Indigo, Color.Purple, Color.MediumVioletRed}  'just in case someone wants to re-enable a question
        Dim userOption As DialogResult = MessageBox.Show("Are you sure you want to cancel? 'Yes' will re-enable the button to this question, 'Cancel' will end the question, and 'No' will just close this message box.", Me.Text, MessageBoxButtons.YesNoCancel)

        If userOption = DialogResult.No Then
            Exit Sub
        ElseIf userOption = DialogResult.Yes Then
            frmBoard.intUsed -= 1
            frmBoard.btnBoard.Enabled = True
            frmBoard.btnBoard.BackColor = colorArray(MoneyIndex(Val(frmBoard.btnBoard.Tag)))
        ElseIf userOption = DialogResult.Cancel Then
            Call NextSet()
        End If

        My.Computer.Audio.Stop()
        frmBoard.Show()
        frmJeopardy.dblPlayerPercent = frmPreMadeSets.PercentCorrect(frmJeopardy.intNumCorrect, frmJeopardy.intNumQuestions)
        Me.Close()
    End Sub

    Private Sub mnuRankings_Click(sender As Object, e As EventArgs) Handles mnuRankings.Click
        frmRankings.Show()
    End Sub

    'Pre: takes in a number
    'Post: returns a number (0 through 5) depending on the range of that number
    Function MoneyIndex(ByVal intNum As Integer) As Integer
        Select Case intNum
            Case 0 To 5
                Return 0
            Case 6 To 11
                Return 1
            Case 12 To 17
                Return 2
            Case 18 To 23
                Return 3
            Case 24 To 29
                Return 4
            Case Else   'it's not possible for there to be any other number, but the squiggly line occurs without this
                Return Nothing
        End Select
    End Function

    'This is just to make displaying the player's stats easy.
    'This will be used publicly as well
    Sub PlayerStats(ByVal lblStats As Label, ByVal strUser As String, ByVal intMoney As Integer, ByVal dblPercent As Double)
        lblStats.Text = "Player: " & strUser & vbCrLf & "Money Amount: $" & intMoney & vbCrLf & "Percent Correct: " & dblPercent & "%"
    End Sub

    'Disables button and turns back color gray
    'actually used this on other forms too
    Sub DisableButton(ByVal btnButton As Button)
        btnButton.BackColor = Color.Gray
        btnButton.Enabled = False
    End Sub

    'when all of the buttons on the board are disabled
    Sub NextSet()
        If frmBoard.intUsed >= 30 Then
            frmBoard.btnContinue.Visible = True
            MessageBox.Show("You have used all the questions in this set. Click continue to choose another set.", Me.Text)
        End If
    End Sub

    Sub Math(ByVal intNum As Integer, ByRef strQue As String, ByRef strAns As String)
        'questions and answers are ordered like so:
        '1-5 easiest, and last 26-30 are the hardest
        Dim mathArrayQuestions() As String = {"5x + 3 = 8", "tan(45) = ? (angle in degrees)", "f(x) = x^2 + x; what is this function's degree?", "I have two shirts and two pants. How many ways can I wear them?", "There are three blue marbles in a bag. What is the probability of drawing a red one? (not in percent)", "5 + 5 = ?",
                                    "41x + 4 = 37x + 76", "sin(a) = 1/2, a = ? (angle in degrees)", "f(x) = -1(x+2)^2 - 4; what is the x-coordinate of the vertex of this function?", "Three kids can choose from three prizes. How many ways can they choose the prizes?", "A pouch contains three red marbles. What is the probability of drawing a red marble? (not in percent)", "i^4 = ?",
                                    "5x + 6y = 23" & vbCrLf & "4x + 3y = 22", "cos(pi) = ? (angle in radians)", "f(x) = (x-5)(x-20); what is the square root of the product of the roots of this function (positive answer)?", "A four character password can have either a number or letter for each spot with repetition. How many passwords can there be?", "A paper bag contains 20 black marbles and 1 red marble. How many red marbles must I add to make the probability of drawing a red marble 1/5?", "An arithmetic starts at 6 and goes up by 3. For the first 5 terms, what is the difference between the mean and median?",
                                    "2^(4x/13) = log(65536)/log(2)", "-1 * csc(330) = ?", "f(x) = x^2 + 170x + 7225; what is the root of this function?", "Five kids are chosen as finalists for a competition, but there can only be three winners. How many combos of winners can there be?", "Two crickets dine on small sand particles. If the probability of drawing one of six tan sand particles is 7.7%, then how many sand particles are there in total? (nearest whole number)", "What is the units digit of the sum (2!)^2 + (3!)^2 + (4!)^2 + ... + (25!)^2?",
                                    "4^(x/y + y/x) = 32" & vbCrLf & "log(x-y)/log(3) + log(x+y)/log(3) = 1" & vbCrLf & "(only positive integer)", "A triangle as side lengths 2, 3, and 3. What is its area squared?", "y = (x^2+6x-72)/(x-6); what is the only y-value that cannot exist?", "If 10586800 permutations come from taking three distinct objects from a sample of also distinct objects, what is the number of the total objects?", "Spongebob's dimensions are 3x2x5 in. Throughout the surface of his body, he has 16 holes with a diameter of 1/16 in. If he were to stab himself, what is the probability that the area he stabs is dry? (not in percent)", "Here is the sequence 0,1,1,2,3,5,8,13,a... what is a?"}
        Dim mathArrayAnswers() As String = {"1", "1", "2", "4", "0", "10",
                                    "18", "30", "-2", "6", "1", "1",
                                    "7", "-1", "10", "1679616", "4", "0",
                                    "13", "2", "-85", "10", "78", "6",
                                    "2", "8", "18", "400", "0", "21"}
        strQue = mathArrayQuestions(intNum)
        strAns = mathArrayAnswers(intNum)
    End Sub

    'I know many memes off the top of my head, so there may not be a link for every one.
    'Surreal memes: https://i.pinimg.com/originals/4c/3f/4c/4c3f4c12bfc07fa7298b7df2cecf7364.png, https://i.pinimg.com/originals/3b/f5/31/3bf5314806736653c6f0f500eb6d4aa3.png, https://66.media.tumblr.com/14b3a12b4898c67e7733f591ebdeed57/tumblr_oz0huwKbGf1wvuif9o1_1280.png
    'Roblox memes: https://t3.rbxcdn.com/e70d9b6f117dee0e8ef84e334b3be878, https://i.pinimg.com/736x/12/f6/3f/12f63fb63e2ab561db87036da4da2fdf.jpg, https://66.media.tumblr.com/e40e1d080fff939793eb297e4c700f4b/b93db2f826d95328-03/s500x750/2f449aa91141497a6c126bf27fde49486f86829e.png, https://i.redd.it/66u3lrnygfu21.jpg
    'Classic memes: https://pics.me.me/had-a-pet-rock-it-ran-away-ugly-guy-49032702.png, https://i.chzbgr.com/full/9277894912/hC3CC2E71/people-student-exists-exams-ck-im-about-to-end-this-mans-whole-career, https://pics.me.me/me-realizing-i-can-just-repost-classic-memes-and-people-57721175.png, https://i.redd.it/cqvd714anvz31.jpg, https://cdn.pocket-lint.com/r/s/320x/assets/images/140427-apps-news-the-best-stupidest-and-most-famous-internet-memes-around-image12-7e6lqoy9lj-jpg.webp?v1
    'Music memes: https://www.youtube.com/watch?v=s8MDNFaGfT4
    'Random memes: https://i.kym-cdn.com/photos/images/facebook/001/534/991/18e.jpg
    Sub Memes(ByVal intNum As Integer, ByRef strQue As String, ByRef strAns As String)
        Dim memeArrayQuestions() As String = {"Ah yes, enslaved _____", "Spanish or _____", "Had a pet ____; it ran away", "Never gonna ___ you up.", "The name of the song that is played in videos where some moving thing is looped on a galaxy background", "'I used the stones to destroy the stones.' Who said this quote?",
                                    "You may consume 3 ____ but no more. They will know if you consume more.", "Do you are have _____?", "I'm about to end this man's whole _____", "Darude - _______", "Do the peanut butter jelly, peanut butter jelly, peanut butter jelly with a ____ ____", "What is the name of the ship that sank in the movie Titanic?",
                                    "*Egg head in a suit cross-armed with arrow pointing diagonally up and numbers behind the being* What word accompanies this image?", "hey kid wanna buy some _____?", "One does not _____ ...", "Bill ___ the Science Guy", "Somebody once told me the world is gonna ___ me.", "What is Obama's last name?",
                                    "you fool; i do not 'succ'. i... ____!", "'i dont speak ____' 'hello'", "It's Free Real _____", "For the Damaged ____", "You ____ in the wrong neighborhood", "Yeetus the ____.",
                                    "Mmm, nothing like a bowl of _____ polygons in the morning", "'Help me im drowning' 'eat the ____'", "Shut up and take my ____!", "Vitas - the 7th _____", "What is the name of the meme with the frog on the unicycle?", "Now that's what I call high ____ H2O."}
        Dim memeArrayAnswers() As String = {"moisture", "vanish", "rock", "give", "Shooting Stars", "Thanos",
                                    "beans", "stupid", "career", "Sandstorm", "baseball bat", "Titanic",
                                    "stonks", "lettuce", "simply", "Nye", "roll", "Obama",
                                    "sook", "taco", "Estate", "Coda", "reposted", "fetus",
                                    "convex", "water", "money", "Element", "Dat Boi", "quality"}
        strQue = memeArrayQuestions(intNum)
        strAns = memeArrayAnswers(intNum)
    End Sub

    Private Sub mnuRules_Click(sender As Object, e As EventArgs) Handles mnuRules.Click
        frmRules.Show()
    End Sub
End Class