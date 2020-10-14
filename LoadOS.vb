Public Class LoadOS

    Private Sub LoadOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.Startup1, AudioPlayMode.Background)


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
      
        ProgressBar1.Increment(2.3)
        If ProgressBar1.Value = 1 Then
            Label1.Text = ("Starting OS...")
        End If
        If ProgressBar1.Value = 86 Then
            Label1.Text = ("TheDanOS is loading...")
            Users.Show()
            Users.Hide()
        End If
        If ProgressBar1.Value = 10 Then
            Label1.Text = ("Loading Icons...")
        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = ("Loading Desktop...")
            Desktop.Deskicons.Refresh()
        End If
        If ProgressBar1.Value = 32 Then
            Label1.Text = ("Loading Pictures...")
        End If
        If ProgressBar1.Value = 36 Then
            Label1.Text = ("Loading Settings...")
            My.Settings.Reload()
        End If
        If ProgressBar1.Value = 41 Then
            Label1.Text = ("Loading Programs...")
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = ("Loading Panels...")
        End If
        If ProgressBar1.Value = 69 Then
            Label1.Text = ("Loading Forms...")
        End If
        If ProgressBar1.Value = 81 Then
            Label1.Text = ("Searching errors...")
        End If
        If ProgressBar1.Value = 85 Then
            Label1.Text = ("Loading Settings...")
        End If
        If ProgressBar1.Value = 86 Then
            Label1.Text = ("Program errors: 0 result...")
        End If
        If ProgressBar1.Value = 87 Then
            Label1.Text = ("Settings errors: 0 result...")
        End If
        If ProgressBar1.Value = 88 Then
            Label1.Text = ("Program errors: 0 result...")
        End If
        If ProgressBar1.Value = 89 Then
            Label1.Text = ("Picture errors: 1 result...")
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = ("Fixing errors: 0%")
        End If
        If ProgressBar1.Value = 90.1 Then
            Label1.Text = ("Fixing errors: 2%")
        End If
        If ProgressBar1.Value = 90.2 Then
            Label1.Text = ("Fixing errors: 15%")
        End If
        If ProgressBar1.Value = 90.3 Then
            Label1.Text = ("Fixing errors: 20%")
        End If
        If ProgressBar1.Value = 90.4 Then
            Label1.Text = ("Fixing errors: 21%")
        End If
        If ProgressBar1.Value = 90.5 Then
            Label1.Text = ("Fixing errors: 51%")
        End If
        If ProgressBar1.Value = 90.6 Then
            Label1.Text = ("Fixing errors: 83%")
        End If
        If ProgressBar1.Value = 90.7 Then
            Label1.Text = ("Fixing errors: 86%")
        End If
        If ProgressBar1.Value = 90.8 Then
            Label1.Text = ("Fixing errors: 92%")
        End If
        If ProgressBar1.Value = 90.9 Then
            Label1.Text = ("Fixing errors: 99%")
        End If
        If ProgressBar1.Value = 91 Then
            Label1.Text = ("Program errors: 100%")
        End If
        If ProgressBar1.Value = 92 Then
            Label1.Text = ("Starting...")
            Users.Show()
        End If
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Stop()
            ProgressBar1.Value = -1

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class