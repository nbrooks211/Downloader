Public Class Form1
    Private Sub Downloadbutton_Click(sender As Object, e As EventArgs) Handles Downloadbutton.Click
        If TextBox1.Text() = "" Then
            MessageBox.Show("You have to put a URL in the textbox", "Error")
        Else
            SaveFileDialog1.ShowDialog()
            My.Computer.Network.DownloadFile(TextBox1.Text, SaveFileDialog1.FileName)
        End If
    End Sub
End Class
