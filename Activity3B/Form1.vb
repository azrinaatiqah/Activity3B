Public Class Form1
    Private Sub cbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        Dim strDaysMonths(,) As String = {{"31", "January"},
                                           {"28 or 29", "February"},
                                           {"31", "March"},
                                           {"30", "April"},
                                           {"31", "May"},
                                           {"30", "June"},
                                           {"31", "July"},
                                           {"31", "August"},
                                           {"30", "September"},
                                           {"31", "October"},
                                           {"30", "November"},
                                           {"31", "December"}}
        Dim intMonth As Integer = cbMonth.SelectedIndex
        lblOut.Text = strDaysMonths(intMonth, 0) & " days in " & strDaysMonths(intMonth, 1)
    End Sub
End Class
