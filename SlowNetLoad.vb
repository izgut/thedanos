Public Class SlowNetLoad

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub StartLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 1 Then
            SlowNet2.Show()
            SlowNet2.Visible = False
            SlowNet2.Refresh()
        End If
        'textek
        If ProgressBar1.Value = 20 Then
            Label1.Text = ("Loading textboxes...")
        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = ("Loading colors...")
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = ("Loading shandows...")
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = ("Loading protection system...")
        End If
        If ProgressBar1.Value = 45 Then
            Label1.Text = ("Loading other forms...")
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = ("Loading saves...")
            If ProgressBar1.Value = 55 Then
                Label1.Text = ("Loading favorites...")
            End If
            If ProgressBar1.Value = 60 Then
                Label1.Text = ("Loading pictures...")
            End If
            If ProgressBar1.Value = 65 Then
                Label1.Text = ("Loading webbrowser...")
            End If
            If ProgressBar1.Value = 67 Then
                Label1.Text = ("Loading webbrowser settings...")
            End If
            If ProgressBar1.Value = 70 Then
                Label1.Text = ("Loading operator...")
            End If
            If ProgressBar1.Value = 72 Then
                Label1.Text = ("Loading codes...")
            End If
            If ProgressBar1.Value = 79 Then
                Label1.Text = ("Loading favicons...")
            End If
            If ProgressBar1.Value = 85 Then
                Label1.Text = ("Loading devices...")
            End If
            If ProgressBar1.Value = 86 Then
                Label1.Text = ("Loading shapes...")
            End If
        End If
        If ProgressBar1.Value = 91.1 Then
            Label1.Text = ("Loading virus.exe...")
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = ("Loading plugins...")
        End If
        If ProgressBar1.Value = 91.2 Then
            Label1.Text = ("Plugins are ready...")
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = ("Loading buttons...")
        End If
        If ProgressBar1.Value = 110 Then
            Label1.Text = ("Loading logos...")
        End If
        If ProgressBar1.Value = 115 Then
            Label1.Text = ("Loading texts...")
        End If
        If ProgressBar1.Value = 120 Then
            Label1.Text = ("Checking version...")
        End If
        If ProgressBar1.Value = 130 Then
            Label1.Text = ("Loading error fixer...")
        End If
        If ProgressBar1.Value = 140 Then
            Label1.Text = ("Loading settings...")
            My.Settings.Reload()
        End If
        If ProgressBar1.Value = 150 Then
            Label1.Text = ("Creating window...")
        End If

        If ProgressBar1.Value = 250 Then
            SlowNet2.Visible = True
            Me.Hide()
            Timer1.Stop()
        End If


    End Sub
End Class