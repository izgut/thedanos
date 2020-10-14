Public Class WebbrowserFunction
    Inherits WebBrowser

    Private Sub webbrowserDocCompl() Handles Me.DocumentCompleted
        Dim tabpage As TabPage = Me.Tag
        Dim SlowNet2 As SlowNet2
        tabpage.Text = Me.DocumentTitle


    End Sub
End Class
