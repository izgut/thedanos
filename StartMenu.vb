Public Class StartMenu

    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        TurnOffPanel.Hide()
        Me.TopMost = True



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Username.Text = My.Settings.Username
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
        AllPrograms.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        TaskManager.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Desktop.Close()
        Users.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\Drivers\Bubbles.scr")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\Drivers\Mystify.scr")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TurnOffPanel.Show()
    End Sub

    Private Sub Button2_DoubleClick(sender As Object, e As EventArgs) Handles Button2.DoubleClick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TurnOffPanel.Hide()
    End Sub

    Private Sub TurnOffButton_Click(sender As Object, e As EventArgs) Handles TurnOffButton.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ControlPanel.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Process.Start("https://youtube.com")
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://facebook.com")
        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Process.Start("explorer.exe")
        Me.Close()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("C:\Dan\SystemDan\DivCalc.exe")
        Me.Close()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Desktop.Close()
        Settings.Close()
        Times.Close()
        AllPrograms.Close()
        Folders.Close()
        Settings.Refresh()
        Me.Hide()
        Users.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Help.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Danmediaplayer.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start("https://www.google.com/")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.apple.com/")
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Symolinbrowsser.Show()
    End Sub
End Class