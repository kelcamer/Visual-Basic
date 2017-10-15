' Kelsey Cameron
' Period 1
' February 14, 2011
' Purpose: To have the user guess a secret word that relates to Valentine's day.

Public Class frmLove

    Private Sub btnTellMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTellMe.Click

        Dim strWord As String

        strWord = Me.txtWord.Text

        Select Case strWord
            Case "love"
                Me.picHeart.Visible = True
            Case "Love"
                Me.picHeart.Visible = True
            Case "I love them"
                Me.picHeart.Visible = True
            Case "I love them!"
                Me.picHeart.Visible = True
            Case "I love them."
                Me.picHeart.Visible = True
            Case "I love my parents"
                Me.picHeart.Visible = True
            Case "I love my parents!"
                Me.picHeart.Visible = True
            Case "I love my parents."
                Me.picHeart.Visible = True
            Case Else
                MsgBox("I bet you LOVE your parents a lot!!!", , "Here is a hint to help you out")
        End Select

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.txtWord.Clear()
        Me.picHeart.Visible = False

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtWord.Clear()
        Me.picHeart.Visible = False
    End Sub
End Class
