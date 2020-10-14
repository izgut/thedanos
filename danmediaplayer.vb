Imports System.DirectoryServices

Public Class Danmediaplayer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName



    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog2.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class