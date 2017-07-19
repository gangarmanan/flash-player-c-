Public Class Form1

    Private Sub OpenByFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenByFileToolStripMenuItem.Click
        Try
            OpenFileDialog1.Title = "Open SWF File"
            OpenFileDialog1.FileName = ".swf"
            OpenFileDialog1.Filter = "Shockwave Flash Object|*.swf*"
            OpenFileDialog1.ShowDialog()
            AxShockwaveFlash1.Movie = OpenFileDialog1.FileName
        Catch ex As Exception
            'Do Nothing
        End Try
    End Sub

    Private Sub OpenByUrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenByUrlToolStripMenuItem.Click
        Openbyurl.ShowDialog()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("created by manan")
    End Sub
End Class
