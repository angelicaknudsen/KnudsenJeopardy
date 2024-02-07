Public Class frmRules
    'Knudsen Jeopardy

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Me.Hide()
    End Sub

    Private Sub mnuRules_Click(sender As Object, e As EventArgs) Handles mnuOverview.Click, mnuMainMenu.Click, mnuPreMadeSets.Click, mnuBoard.Click, mnuQuestion.Click, mnuFinishedPlay.Click
        Static radRules() As RadioButton = {Me.radOverview, Me.radMainMenu, Me.radPreMadeSets, Me.radBoard, Me.radQuestion, Me.radFinishedPlay}
        radRules(Val(sender.Tag)).Checked = True    'putting all the radiobuttons in an array and putting their index positions in the tags of the menu items makes for shorter code
    End Sub

    Private Sub radRules_CheckedChanged(sender As Object, e As EventArgs) Handles radOverview.CheckedChanged, radMainMenu.CheckedChanged, radPreMadeSets.CheckedChanged, radBoard.CheckedChanged, radQuestion.CheckedChanged, radFinishedPlay.CheckedChanged
        Dim radRules As RadioButton = sender

        Select Case radRules.Tag
            Case "0"
                Me.lblRules.Text = "Just like the Jeopardy game show we all know and love, this is a trivia game. Each play is intended to be individual, unless you find a way to track points differently for a team mode. There are two sets to play from, and once you go through both, you will be automatically added to the rankings. If you obtain the most points and/or the highest percent correct, you will be featured in the rankings."
            Case "1"
                Me.lblRules.Text = "Click PROCEED and type in your own name, RANDOM to get a random name(they’re limited, so you may be forced to enter your own), or CANCEL to.. well.. cancel the input box."
            Case "2"
                Me.lblRules.Text = "You will see two buttons labeled MATH and MEMES appearing to float around in a sea. After clicking either, a messagebox will pop up and give you an idea of what the set will be like, so you can make an informed decision."
            Case "3"
                Me.lblRules.Text = "Just like Jeopardy, the higher the money value displayed on the button, the more difficult the question will be. If you want to finish the set early, click DONE and follow the directions provided on the shown messagebox."
            Case "4"
                Me.lblRules.Text = "You will get 30 seconds for each question accompanied by the iconic Jeopardy tune. Enter your answer without any extra spaces, only add one space between each word in an answer, and never include punctuation (it’s not case-sensitive, but spelling is crucial). For numbers, just enter the integer as is. Like the board, you can click CANCEL if for some reason you may have accidentally clicked the wrong button or want to leave early (however, if you have submitted an answer to the question, it will count toward your play)."
            Case "5"
                Me.lblRules.Text = "Once you’ve gone through both sets or left early, feel free to see how you did compared to others in the rankings. However, if you did not answer at least 30 questions, you will not be considered for the highest percent correct. Beware, DO NOT PRESS THE CLOSE BUTTON IN THE TOP RIGHT CORNER. If you do so, you will have to go through another play to view the rankings again."
        End Select
    End Sub

End Class