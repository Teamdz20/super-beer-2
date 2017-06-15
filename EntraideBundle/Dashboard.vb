Imports Transitions
Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel

Public Class Dashboard


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.Width -= 200
            Me.Height -= 200
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub


    Dim expanded As Boolean = True

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnToggleSidebar.Click
        Dim toWidth As Integer
        If expanded Then
            toWidth = 70
            expanded = False
        Else
            toWidth = 246
            expanded = True
        End If
        Transition.run(PanelSidebar, "Width", toWidth, New TransitionType_EaseInEaseOut(1000))
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        Dim toHeight As Integer
        If MessagesControl1.Height = 0 Then
            toHeight = 346
        Else
            toHeight = 0
        End If
        Transition.run(MessagesControl1, "Height", toHeight, New TransitionType_EaseInEaseOut(500))
    End Sub



End Class