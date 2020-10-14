Public Class ControlPanel

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SYSTEM444\Drivers\SPA.exe")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SYSTEM444\Drivers\PFS.exe")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        On Error Resume Next
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\devmgm.exe")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\SystemPropertiesDataExecutionPrevention.exe")
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\SystemPropertiesHardware.exe")
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\SystemPropertiesProtection.exe")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        On Error Resume Next
        Process.Start("C:\Dan\SystemDan\SystemPropertiesRemote.exe")
    End Sub
End Class