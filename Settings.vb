

Public Class Settings

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = OpenFileDialog1.FileName

        End If
        TextBox1.Show()
        Button2.Show()


    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        TextBox1.Hide()
        Button2.Hide()

        Dim CPUName As String
        CPUName = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)
        Processor.Text = CPUName
        Dim Freq As String
        Freq = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "~MHz", Nothing)
        Mhz.Text = Freq & " MHz"
        Me.Text = CPUName & ", " & Freq & " MHz"

        Memor.Text = ("Computer's available physical memory: " & My.Computer.Info.TotalPhysicalMemory)
        Usernameset.Text = My.Settings.Username
        PassPanel.Hide()
        NamePanel.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim BGimage As Object

        'open the image
        Users.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        Desktop.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        Users.TabPage1.BackgroundImage = Desktop.BackgroundImage
        BGimage = OpenFileDialog1.FileName.ToString
        Desktop.Deskicons.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)

        'save it to My.Settings
        My.Settings.BGimage = BGimage
        My.Settings.Save()
        My.Settings.Reload()

        Button2.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub


    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DarkButton_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Function Esbut() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click_2(sender As Object, e As EventArgs)
        My.Settings.Reset()
        My.Settings.Save()
        My.Settings.Reload()
        Me.Close()
        Me.Close()
        Desktop.Close()
        Folders.Close()
        Times.Close()
        TaskManager.Close()
        Help.Close()
        ControlPanel.Close()
        AllPrograms.Close()
        Users.Show()
        Users.PasswordTXT.Clear()
        Users.UsernameTxt.Clear()
        Users.TabPage1.Refresh()
        My.Settings.Reload()
        My.Settings.Reset()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PassPanel.Show()
        NewUSName.Show()
        ChangeUserNameButt.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        NamePanel.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        NamePanel.Hide()
        ChangeUserNameButt.Hide()
        NewUSName.Hide()
        NewUSName.Clear()
    End Sub

    Private Sub OldUsName_TextChanged(sender As Object, e As EventArgs) Handles OldUsName.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PassPanel.Hide()
        NewPass.Hide()
        NewPass.Clear()
        NewPassButt.Hide()

    End Sub

    Private Sub NewPassButt_Click(sender As Object, e As EventArgs) Handles NewPassButt.Click
        If NewPass.Text = ("") Or NewPass.Text = (" ") Or OldPass.Text = My.Settings.Password Then
            MsgBox("Password is missing in ''New Passowrd'' textbox, or bad old password.", MsgBoxStyle.Critical)
        Else
            My.Settings.Password = NewPass.Text
            My.Settings.Save()
            My.Settings.Reload()
            NewPass.Clear()
            MsgBox("Password changed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ChangeUserNameButt_Click(sender As Object, e As EventArgs) Handles ChangeUserNameButt.Click
        If NewUSName.Text = ("") Or NewUSName.Text = (" ") Or OldUsName.Text = My.Settings.Username Then
            MsgBox("Password is missing in ''New Username'' textbox, or bad old username.", MsgBoxStyle.Critical)
        Else
            My.Settings.Username = NewUSName.Text
            My.Settings.Save()
            My.Settings.Reload()
            StartMenu.Username.Text = My.Settings.Username
            NewUSName.Clear()
            MsgBox("Username changed: " & My.Settings.Username, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub LightButton_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        On Error Resume Next
        Dim BGimage As Object
        Desktop.Deskicons.BackgroundImage = My.Resources.coldpark

    End Sub
End Class