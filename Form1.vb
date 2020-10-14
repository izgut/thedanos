
Imports System.Runtime.InteropServices

Public Class Desktop
    Dim path As String
    Dim nextpath As String



    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True

        End If
    End Sub

    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles Me.Click

        If VolumePanel.Visible = True Then
            VolumePanel.Hide()
        End If

        If StartMenu.Visible Then
            StartMenu.Hide()
        End If
        If InternetPanel.Visible = True Then
            InternetPanel.Hide()
        End If
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Load
        Try
            Deskicons.BackgroundImage = Image.FromFile(My.Settings.BGimage.ToString)
        Catch ex As Exception
        End Try
        Deskicons.BackgroundImageLayout = ImageLayout.Stretch

        'taskbar list
        Dim p As Process
        ProgramsTaskList.Items.Clear()
        For Each p In Process.GetProcesses
            ProgramsTaskList.Items.Add(p.ProcessName)
        Next


        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BGimage.ToString)
        Catch ex As Exception
        End Try
        My.Settings.Reload()

        'Shortcuts
        path = "C:\Users\Public\Desktop"
        For Each i In My.Computer.FileSystem.GetDirectories(path)
            Deskicons.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
        Next
        For Each i In My.Computer.FileSystem.GetFiles(path)
            Deskicons.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        Next
        'color mode


        'Hide
        StartMenu.Visible = False
        Timer1.Start()
        VolumePanel.Hide()
        RunningProgs.Hide()
        InternetPanel.Hide()
        VolumePanel.Hide()
        InternetPanel.Hide()

        'settings
        My.Settings.Reload()

        With Deskicons


            Deskicons.BorderStyle = 0
        End With

        'volume
        TrackBar1.Minimum = 0
        TrackBar1.Maximum = 100
        TrackBar1.TickFrequency = 5
        TrackBar1.Value = GetApplicationVolume()
        Volm.Text = TrackBar1.Value.ToString & "%"


        'Internet
        If My.Computer.Network.IsAvailable Then
            InternetAccess.BackgroundImage = (My.Resources.Internet)
            Internetaccesslab.Text = ("Available")
            Internetaccesslab.ForeColor = Color.Lime
        Else
            InternetAccess.BackgroundImage = (My.Resources.NoInternet)
            Internetaccesslab.Text = ("Unavailable")
            Internetaccesslab.ForeColor = Color.Red
        End If
        InternetPanel.Hide()
        My.Settings.Save()
        My.Settings.Reload()


    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles StartMenuButton.Click
        StartMenu.Visible = True
        InternetPanel.Visible = False
        VolumePanel.Visible = False
        RunningProgs.Visible = False

    End Sub

    Private Sub StartMenuButton_DoubleClick(sender As Object, e As EventArgs) Handles StartMenuButton.DoubleClick
        StartMenu.Visible = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim CurrentDateTime As DateTime
        CurrentDateTime = DateTime.Now
        TimeMin.Text = DateTime.Now.ToString("HH:mm:ss")
        DateNow.Text = DateTime.Now.ToString("yyyy/MM/dd")
     
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Settings.Show()
        Settings.TopMost = True
        StartMenu.Hide()

    End Sub

    Private Sub DateNow_Click(sender As Object, e As EventArgs) Handles DateNow.Click
        Times.Show()
    End Sub

    Private Sub TimeMin_Click(sender As Object, e As EventArgs) Handles TimeMin.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_DoubleClick1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        Dim vol As UInteger = CUInt((UShort.MaxValue / 100) * TrackBar1.Value)
        waveOutSetVolume(IntPtr.Zero, CUInt((vol And &HFFFF) Or (vol << 16)))
        Volm.Text = TrackBar1.Value.ToString & "%"
    End Sub

    Private Function GetApplicationVolume() As Integer
        Dim vol As UInteger = 0
        waveOutGetVolume(IntPtr.Zero, vol)
        Return CInt((vol And &HFFFF) / (UShort.MaxValue / 100))
    End Function



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim v As Integer = GetApplicationVolume()
        If TrackBar1.Value <> v Then
            TrackBar1.Value = v
            Volm.Text = TrackBar1.Value.ToString & "%"
        End If
    End Sub

    <DllImport("winmm.dll")> Private Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As UInteger
    End Function

    <DllImport("winmm.dll")> Private Shared Function waveOutGetVolume(ByVal hwo As IntPtr, ByRef pdwVolume As UInteger) As UInteger
    End Function

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        VolumePanel.Show()
    End Sub

    Private Sub PictureBox7_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox7.DoubleClick
        VolumePanel.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TaskManager.Show()
        TaskManager.TopMost = True
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Folders.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Settings.Show()
        Settings.TopMost = True
        StartMenu.Visible = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        ControlPanel.Show()
        ControlPanel.TopMost = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs)
        Process.Start("https://google.com")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
        Users.Show()
        Me.Refresh()
        My.Settings.Reload()
        Users.TabPage1.Show()
        Users.TabPage1.Refresh()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Process.Start("cmd.exe")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub StartMenu_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles Deskicons.DoubleClick
        If My.Computer.FileSystem.DirectoryExists(nextpath) Then
            On Error Resume Next
            path = nextpath
            Deskicons.Clear()
            For Each i In My.Computer.FileSystem.GetDirectories(path)
                Deskicons.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
            Next
            For Each i In My.Computer.FileSystem.GetFiles(path)
                Deskicons.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
            Next

        Else

            MsgBox("Cannot open this file.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Deskicons_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Deskicons.MouseDoubleClick

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Deskicons.SelectedIndexChanged
        If VolumePanel.Visible = True Then
            VolumePanel.Hide()
        End If

        If StartMenu.Visible Then
            StartMenu.Hide()
        End If
        If InternetPanel.Visible = True Then
            InternetPanel.Hide()
        End If

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox18_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)
        AllPrograms.Show()
    End Sub

    Private Sub TurnButton_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub InternetAccess_Click(sender As Object, e As EventArgs) Handles InternetAccess.Click
        InternetPanel.Show()

    End Sub

    Private Sub InternetAccess_DoubleClick(sender As Object, e As EventArgs) Handles InternetAccess.DoubleClick
        InternetPanel.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If My.Computer.Network.IsAvailable Then
            InternetAccess.BackgroundImage = (My.Resources.Internet)
            Internetaccesslab.Text = ("Available")
            Internetaccesslab.ForeColor = Color.Lime
        Else
            InternetAccess.BackgroundImage = (My.Resources.NoInternet)
            Internetaccesslab.Text = ("Unavailable")
            Internetaccesslab.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Help.Show()
    End Sub

    Private Sub Desktop_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
        On Error Resume Next

        Diagnostics.Process.Start("D:\DanOS scoures\TheDanOS FOLDER\Addons\SlowNet000\092AddoneditedSlowNetBrowser001@{}\SlowNet.exe")
    End Sub

    Private Sub TurnOffButton_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        On Error Resume Next
        Dim p As Process
        ProgramsTaskList.Items.Clear()
        For Each p In Process.GetProcesses
            ProgramsTaskList.Items.Add(p.ProcessName)
        Next

        RunningProgs.Show()

    End Sub

    Private Sub PictureBox21_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox21.DoubleClick
        On Error Resume Next
        RunningProgs.Hide()
        Dim p As Process
        ProgramsTaskList.Items.Clear()
        For Each p In Process.GetProcesses
            ProgramsTaskList.Items.Add(p.ProcessName)
        Next

    End Sub

    Private Sub ProgramsTaskList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgramsTaskList.SelectedIndexChanged
        Diagnostics.Process.Start(ProgramsTaskList.SelectedItem)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Refresh()
        Deskicons.Clear()
        My.Settings.Reload()
        'Form Load
        Try
            Deskicons.BackgroundImage = Image.FromFile(My.Settings.BGimage.ToString)
        Catch ex As Exception
        End Try
        Deskicons.BackgroundImageLayout = ImageLayout.Stretch

        'taskbar list
        Dim p As Process
        ProgramsTaskList.Items.Clear()
        For Each p In Process.GetProcesses
            ProgramsTaskList.Items.Add(p.ProcessName)
        Next


        Try
            Me.BackgroundImage = Image.FromFile(My.Settings.BGimage.ToString)
        Catch ex As Exception
        End Try
        My.Settings.Reload()

        'Shortcuts
        path = "C:\Users\Public\Desktop"
        For Each i In My.Computer.FileSystem.GetDirectories(path)
            Deskicons.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
        Next
        For Each i In My.Computer.FileSystem.GetFiles(path)
            Deskicons.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        Next


        'color mode


        'Hide
        StartMenu.Visible = False
        Timer1.Start()
        VolumePanel.Hide()
        RunningProgs.Hide()
        InternetPanel.Hide()
        VolumePanel.Hide()
        InternetPanel.Hide()

        'settings
        My.Settings.Reload()

        'volume
        TrackBar1.Minimum = 0
        TrackBar1.Maximum = 100
        TrackBar1.TickFrequency = 5
        TrackBar1.Value = GetApplicationVolume()
        Volm.Text = TrackBar1.Value.ToString & "%"


        'Internet
        If My.Computer.Network.IsAvailable Then
            InternetAccess.BackgroundImage = (My.Resources.Internet)
            Internetaccesslab.Text = ("Available")
            Internetaccesslab.ForeColor = Color.Lime
        Else
            InternetAccess.BackgroundImage = (My.Resources.NoInternet)
            Internetaccesslab.Text = ("Unavailable")
            Internetaccesslab.ForeColor = Color.Red
        End If
        InternetPanel.Hide()
        My.Settings.Save()
        My.Settings.Reload()


    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub TaskManagerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem1.Click
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub PersonalizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizeToolStripMenuItem.Click

    End Sub

    Private Sub TrackBar1_Scroll_1(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Volm.Text = TrackBar1.Value
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If My.Computer.Network.IsAvailable Then
            InternetAccess.BackgroundImage = (My.Resources.Internet)
            Internetaccesslab.Text = ("Available")
            Internetaccesslab.ForeColor = Color.Lime
        Else
            InternetAccess.BackgroundImage = (My.Resources.NoInternet)
            Internetaccesslab.Text = ("Unavailable")
            Internetaccesslab.ForeColor = Color.Red
        End If
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        szunetradio.Show()

    End Sub
End Class
