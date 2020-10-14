Public Class Times

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Times_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Time.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
End Class