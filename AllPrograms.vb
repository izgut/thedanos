Public Class AllPrograms

    Private Sub AllPrograms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LSB.Hide()
        Me.TopMost = True
    End Sub

    Private Sub AllPrograms_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        With ListBox1
            .SelectedIndex = -1 '// -1 Index ='s No.Item.Selected.
            If Not TextBox1.Text = "" Then
                For Each itm As String In .Items '// loop thru items.
                    If itm.ToLower = TextBox1.Text.ToLower Then '// Case inSensitive search.
                        .SelectedItem = itm '// select item.
                        Exit For '// exit loop since item located. 
                    End If
                Next
                Exit Sub '// just.because the next 2 lines are not worth reading. :)
            End If
        End With
    End Sub
End Class