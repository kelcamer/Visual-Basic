' Program:   Digital Downloads
' Author:    Kelsey Cameron
' Date:      October 27, 2010
' Purpose:   This application calculates and displays
'            the total cost of music downloads

Option Strict On

Public Class DownloadMusic

    ' Cost per download - used in multiple procedures
    Const _cdecPricePerDownload As Decimal = 0.99D

    Private Sub btnCalculatecost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculatecost.Click
        ' This event is executed when the user clicks the
        ' calculate cost button. It calculates and displays the cost
        ' of music downloads (number of downloads times the cost per download).
        Dim strNumberOfSongs As String
        Dim intNumberOfSongs As Integer
        Dim decTotalCostofDownloads As Decimal

        strNumberOfSongs = Me.txtNumberOfDownloads.Text
        intNumberOfSongs = Convert.ToInt32(strNumberOfSongs)
        decTotalCostofDownloads = intNumberOfSongs * _cdecPricePerDownload
        Me.lbltotalcostofdownloads.Text = decTotalCostofDownloads.ToString("C")

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of downloads text box
        ' and the Text property of the Total Cost of Downloads label.
        ' Then, it sets the focus on the txtNumberOfDownloads TextBox object.

        Me.txtNumberOfDownloads.Clear()
        Me.lbltotalcostofdownloads.Text = ""
        Me.txtNumberOfDownloads.Focus()

    End Sub

    Private Sub DownloadMusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost of Downloads label, and sets the focus on
        ' the txtnumberofdownloads TextBox object.

        Me.lblCostHeading.Text = _cdecPricePerDownload.ToString("C") _
            & " Per Download"
        Me.lbltotalcostofdownloads.Text = ""
        Me.txtNumberOfDownloads.Focus()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        ' Close the window and terminate the application.

        Me.Close()

    End Sub
End Class
