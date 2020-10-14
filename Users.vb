Public Class Users

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BGimage.ToString)
        Catch ex As Exception
        End Try

        Try
            TabPage1.BackgroundImage = Image.FromFile(My.Settings.BGimage.ToString)
        Catch ex As Exception
        End Try

        Try
            Userimage1.BackgroundImage = Image.FromFile(My.Settings.Userimage.ToString)
        Catch ex As Exception
        End Try
        My.Settings.Reload()
        UsernameTxt.Text = My.Settings.Username

Try
            Userimage1.BackgroundImage = Image.FromFile(My.Settings.Userimage.ToString)
        Catch ex As Exception
        End Try

        UserLoadName.Text = My.Settings.Username
    End Sub

    Private Sub Folders_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Static lpos As Point
        If e.Button = Windows.Forms.MouseButtons.Left Then     'move form
            Me.Location += New Size(e.X - lpos.X, e.Y - lpos.Y)

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then ' resize form (but no less than 10x10 pixels)
            Dim newWidth As Integer = Math.Max(10, Me.Width + (e.X - lpos.X))
            Dim newHeight As Integer = Math.Max(10, Me.Height + (e.Y - lpos.Y))
            lpos = e.Location
            Me.Size = New Size(newWidth, newHeight)

        Else
            lpos = e.Location
        End If
    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next

        My.Settings.Userimage = Userimage1.ToString
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Userimage1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)

        End If
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Desktop.Show()
        Me.Hide()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTXT.PasswordChar = ("")
        End If

        If CheckBox1.CheckState = False Then
            PasswordTXT.PasswordChar = ("*")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If UsernameTxt.Text = My.Settings.Username Or UsernameTxt.Text = ("") Or UsernameTxt.Text = (" ") Or PasswordTXT.Text = ("") Or PasswordTXT.Text = (" ") Then
            MsgBox("This user is already exists, or invaild username/password.", MsgBoxStyle.Critical)
        Else
            My.Settings.Reset()
            My.Settings.Reload()
            My.Settings.Username = UsernameTxt.Text
            My.Settings.Password = PasswordTXT.Text
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("User registered: " & My.Settings.Username, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If UsernameTxt.Text = My.Settings.Username And PasswordTXT.Text = My.Settings.Password Then
            Desktop.Show()
            Me.Hide()
            My.Settings.Reload()

        Else
            MsgBox("The username and the password are not match.", MsgBoxStyle.Critical, "User Log in Error")
            UserLoadName.Text = ("Guest")
        End If
        If UsernameTxt.Text = ("") Or UsernameTxt.Text = (" ") Then
            Me.Refresh()
            Desktop.Close()
            PasswordTXT.Clear()
            UsernameTxt.Clear()
            Me.Show()
            MsgBox("Log in error: Bad request", MsgBoxStyle.Critical, "Settings Error")

        Else
        End If
    End Sub

    Private Sub PasswordTXT_Enter(sender As Object, e As EventArgs) Handles PasswordTXT.Enter

       
    End Sub

    Private Sub PasswordTXT_TextChanged(sender As Object, e As EventArgs) Handles PasswordTXT.TextChanged

    End Sub

    Private Sub Userimage1_Click(sender As Object, e As EventArgs) Handles Userimage1.Click

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub UsernameTxt_TextChanged(sender As Object, e As EventArgs) Handles UsernameTxt.TextChanged

    End Sub
End Class