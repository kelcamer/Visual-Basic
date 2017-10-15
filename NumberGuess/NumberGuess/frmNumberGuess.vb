' Kelsey Cameron
' January 24, 2011
' Purpose: To allow users to guess their lucky number




Public Class frmNumberGuess

    Private Sub btnCheckGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Const cintLuckyNumber As Integer = 3
        Dim strFinalGuess As String
        Dim intFinalGuess As Integer
        strFinalGuess = Me.txtFinalGuess.Text
        intFinalGuess = Convert.ToInt32(strFinalGuess)
        If intFinalGuess = cintLuckyNumber Then
            Me.lblYouGuessedIt.Visible = True
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.txtFinalGuess.Text = ""
        Me.txtFinalGuess.Focus()
        Me.lblYouGuessedIt.Visible = False

    End Sub

    Private Sub frmNumberGuess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtFinalGuess.Text = ""
        Me.txtFinalGuess.Focus()
        Me.lblYouGuessedIt.Visible = False

    End Sub
End Class
