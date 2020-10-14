Public Class Slownett

    Private Property Cancel As Boolean

    Private Property ppDisp As Object

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        WebBrowser1.Navigate("https://google.com")
        Panel2.Hide()
        Button4.Hide()
        Button5.Hide()
        Label3.Hide()
        For Each item As String In My.Settings.Bookmarks
            ListBox1.Items.Add(item)
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox2.Text = WebBrowser1.Url.ToString


        'Denied sites
        If TextBox2.Text = ("http://comingsoon.vevo.com/") Or TextBox2.Text = ("http://vevo.com/") Then
            TextBox2.Text = ("Sorry, but you're out of region.")
            MsgBox("Sorry, but you're out of region. (Vevo.com)", MsgBoxStyle.Critical, "Error Code: HitNetRegion13")
            TextBox1.Clear()
            WebBrowser1.Navigate("https://google.com")
            TextBox1.Clear()
            TextBox2.Select()
        End If

        If TextBox2.Text = ("https://illuminati.am/") Or TextBox2.Text = ("illuminati.am") Then
            TextBox2.Text = ("You will be scammed if you enter this site.")
            MsgBox("YOU DON'T HAVE ACCES TO ENTER THIS SITE. IT'S A DANGER SITE. (Illuminati.am)", MsgBoxStyle.Critical, "Error Codes: ScamF5, ProtectSystem9/11, ProtectSystemUnknown")
            TextBox1.Clear()
            WebBrowser1.Navigate("https://google.com")
            TextBox1.Clear()
            TextBox2.Select()
        End If

        If TextBox2.Text = ("https://www.otpercpiheno.hu/") Or TextBox2.Text = ("https://otpercpiheno.blogspot.com/") Then
            TextBox2.Text = ("You will be scammed if you enter this site.")
            MsgBox("Fake news site, sorry.", MsgBoxStyle.Critical, "Error Codes: KILLNEWS, FIDESZ")
            TextBox1.Clear()
            WebBrowser1.Navigate("https://google.com")
            TextBox1.Clear()
            TextBox2.Select()
        End If


    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Enter

    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        WebBrowser1.Navigate("https://google.com")
    End Sub

    Private Sub GooglecomToolStripMenuItem_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("https://google.ru")
    End Sub

    Private Sub GoogleUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleUSToolStripMenuItem.Click
        WebBrowser1.Navigate("https://google.com")
    End Sub

    Private Sub GoogleHUNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleHUNToolStripMenuItem.Click
        WebBrowser1.Navigate("https://google.hu")
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        WebBrowser1.Navigate("https://youtube.com")
    End Sub

    Private Sub YouTubeRUToolStripMenuItem_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("https://youtube.ru")
    End Sub

    Private Sub YouTubeUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeUSToolStripMenuItem.Click
        WebBrowser1.Navigate("https://youtube.com")
    End Sub

    Private Sub YouTubeHUNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeHUNToolStripMenuItem.Click
        WebBrowser1.Navigate("https://youtube.hu")
    End Sub

    Private Sub YahooToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YahooToolStripMenuItem.Click
        WebBrowser1.Navigate("https://yahoo.com")
    End Sub

    Private Sub MicrosoftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftToolStripMenuItem.Click
        WebBrowser1.Navigate("https://microsoft.com")
    End Sub

    Private Sub BingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BingToolStripMenuItem1.Click
        WebBrowser1.Navigate("https://bing.com")
    End Sub

    Private Sub MicrosoftcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftcomToolStripMenuItem.Click
        WebBrowser1.Navigate("https://microsoft.com")
    End Sub

    Private Sub SkypecomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkypecomToolStripMenuItem.Click
        WebBrowser1.Navigate("https://skype.com")
    End Sub

    Private Sub FreemailcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreemailcomToolStripMenuItem.Click
        WebBrowser1.Navigate("https://freemail.hu")
    End Sub

    Private Sub GmailcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GmailcomToolStripMenuItem.Click
        WebBrowser1.Navigate("https://gmail.com")
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click
        WebBrowser1.Navigate("https://facebook.com")
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwitterToolStripMenuItem.Click
        WebBrowser1.Navigate("https://twitter.com")
    End Sub

    Private Sub DiscordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordToolStripMenuItem.Click
        WebBrowser1.Navigate("https://discord.gg")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub CourrentVersionNumbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourrentVersionNumbToolStripMenuItem.Click
        MsgBox("Current version numb.: 1.0.0v", MsgBoxStyle.Information, "SLOWNET VERSION")
    End Sub

    Private Sub CNNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNNToolStripMenuItem.Click
        WebBrowser1.Navigate("https://cnn.com")
    End Sub

    Private Sub LightModeToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenBrowserPluginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenBrowserPluginToolStripMenuItem.Click

    End Sub

    Private Sub ErrorFixerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorFixerToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuStrip1.Show()
    End Sub

    Private Sub HIDEBARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HIDEBARToolStripMenuItem.Click
        Button5.Show()
        MenuStrip1.Hide()

        WebBrowser1.Height = 611
        WebBrowser1.Width = 1264

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MenuStrip1.Show()
        Button5.Hide()

        WebBrowser1.Height = 587
        WebBrowser1.Width = 1264
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateInYourDefaultBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInYourDefaultBrowserToolStripMenuItem.Click
        Process.Start("https://airboeing.wixsite.com/slownet/new-update-id-001")
    End Sub

    Private Sub SlowNetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlowNetToolStripMenuItem.Click
        Process.Start("https://airboeing.wixsite.com/slownet")
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        WebBrowser1.Navigate("https://airboeing.wixsite.com/slownet/new-update-id-001")
    End Sub

    Private Sub PluginManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PluginManagerToolStripMenuItem.Click

    End Sub

    Private Sub AndroidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndroidToolStripMenuItem.Click
        MsgBox("Coming soon...", MsgBoxStyle.Information, "SlowNet Browser Android")
    End Sub

    Private Sub IOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IOSToolStripMenuItem1.Click
        MsgBox("Coming soon...", MsgBoxStyle.Information, "SlowNet Browser IOS")
    End Sub

    Private Sub LinuxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinuxToolStripMenuItem.Click
        MsgBox("Coming soon...", MsgBoxStyle.Information, "SlowNet Browser Linux")
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub HistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UseForDarkThingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UseForDarkThingsToolStripMenuItem.Click
        Me.BackColor = Color.Black
        PictureBox1.Hide()
        Panel1.BackColor = Color.Black
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.Show()
        Me.Text = ("SlowNet - ANONYMOUSE MODE (FOR VERY VERY VERY VERY VERY DARK THINGS)")
    End Sub

    Private Sub NormalModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalModeToolStripMenuItem.Click
        If Me.Text = ("SlowNet: HIGH PROTECTION") Then
            MsgBox("HIGH PROTECTION: OFF", MsgBoxStyle.Information, "SlowBrowser Support")
        Else

        End If


        Me.BackColor = Color.White
        PictureBox1.Show()
        Panel1.BackColor = Color.White
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.Hide()
        Me.Text = ("SlowNet")
    End Sub

    Private Sub RecoveryToNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryToNormalToolStripMenuItem.Click
        Me.BackColor = Color.White
        PictureBox1.Show()
        Panel1.BackColor = Color.White
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.Hide()
        Me.Text = ("SlowNet")
    End Sub

    Private Sub IJustWannaProtectMyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IJustWannaProtectMyDataToolStripMenuItem.Click
        Me.Text = ("SlowNet: HIGH PROTECTION")
        MsgBox("HIGH PROTECTION: ON", MsgBoxStyle.Information, "SlowBrowser Support")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddToFavotireToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.Bookmarks.Add(WebBrowser1.Url.ToString)
        ListBox1.Items.Clear()
        For Each item As String In My.Settings.Bookmarks
            ListBox1.Items.Add(item)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case MsgBox("Are you sure to delete?", MsgBoxStyle.YesNoCancel, "WARNING")
            Case MsgBoxResult.Yes
                ListBox1.Items.Clear()
                My.Settings.Bookmarks.Clear()
                My.Settings.Save()
                My.Settings.Reload()
                ListBox1.Refresh()
            Case MsgBoxResult.No
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel2.Hide()
        My.Settings.Save()
    End Sub

    Private Sub FavoritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoritesToolStripMenuItem.Click
        Panel2.Show()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        WebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        ListBox1.SelectedItem.Remove(My.Settings.Bookmarks)
        My.Settings.Save()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Settings.Bookmarks.Add(TextBox3.Text)
        ListBox1.Items.Add(TextBox3.Text)
        My.Settings.Save()

        'others
        TextBox3.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ReloadBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadBrowserToolStripMenuItem.Click
        SlowNetLoad.Show()
        Application.Exit()
        Me.Refresh()
        Process.Start("SlowNet Browser.exe")
    End Sub

    Private Sub OpenErrorFixerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenErrorFixerToolStripMenuItem.Click
        Errorfixer.Show()
    End Sub

    Private Sub TryOutOurNewBrowserThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TryOutOurNewBrowserThemeToolStripMenuItem.Click
        SlowNet2.Show()
        Me.Hide()
    End Sub

    Private Sub WebBrowser1_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
        WebBrowser1.Navigate(WebBrowser1.StatusText)
    End Sub

End Class


