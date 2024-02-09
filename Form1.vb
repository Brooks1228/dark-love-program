Public Class Form1
    Private lovelevels() As String = {"dysfuntional", "fake", "friendzone", "liking", "crushing", "unconditional commitment", "sacrificial love"}
    Private loveimages() As Image = {My.Resources.dysfunctional, My.Resources.fake, My.Resources.friendzone, My.Resources.liking, My.Resources.crushing, My.Resources.unconditional, My.Resources.sacrificial_love}
    Private Sub btnStrength_Click(sender As Object, e As EventArgs) Handles btnStrength.Click
        Dim strP1 As String = txtPerson1.Text.Trim
        Dim strP2 As String = txtPerson2.Text.Trim
        If strP1 = "" OrElse strP2 = "" Then
            MessageBox.Show("please enter names for both inputs")
            Return
        End If
        lblPeopleMath.Text = strP1 & " + " & strP2
        lblPeopleMath.Visible = True

        Dim loveindex As Integer = calculateLoveIndex(strP1, strP2)
        lblMatchStrength.Text = FindMatchingText(loveindex)
        lblMatchStrength.Visible = True
        picIMage.Image = FindMatchingimage(loveindex)
    End Sub

    Private Function calculateLoveIndex(str1 As String, str2 As String) As Integer
        str1 = str1.ToLower.Trim
        str2 = str2.ToLower.Trim

        'get ascii value for each character and sum up those values
        Dim total As Integer = GetStringAsciiSum(str1) + GetStringAsciiSum(str2)
        Return total
    End Function

    Private Function GetStringAsciiSum(str As String) As Integer
        Dim sum As Integer
        'loop through the string and add each character ascii value to sum
        For Each c As Char In str
            sum += Asc(c) 'the ascii value of c
        Next
        Return sum
    End Function
    Private Function FindMatchingText(num As Integer) As String
        'we will return a value from the lovelevels array
        'we need to put num within range of the values in the array (0 - length - 1)(
        Dim index As Integer = num Mod lovelevels.Length
        Return lovelevels(index)
    End Function
    Private Function FindMatchingimage(num As Integer) As Image
        'we will return a value from the lovelevels array
        'we need to put num within range of the values in the array (0 - length - 1)(
        Dim index As Integer = num Mod lovelevels.Length
        Return loveimages(index)
    End Function
End Class
