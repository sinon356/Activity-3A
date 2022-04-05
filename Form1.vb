Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        Dim strDays() As String = {"31", "28 or 29", "31", "30", "31", "31", "30", "31", "31", "30", "31", "30", "31"}
        Dim strMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "Novemeber", "December"}

        Dim intMonth As Integer = cbMonth.SelectedIndex
        lblOut.Text = strDays(intMonth) & " days in " & strMonth(intMonth)
    End Sub
End Class
