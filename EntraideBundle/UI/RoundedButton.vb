Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Panel




    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim g As Graphics = pevent.Graphics

        Dim grPath As GraphicsPath = New GraphicsPath
        grPath.AddEllipse(0, 0, CInt(ClientSize.Width / 2), CInt(ClientSize.Height / 2))
        Me.Region = New Region(grPath)

        Dim p1 As Pen = Pens.Teal
        Dim p2 As Pen = Pens.Teal

        Dim rectBorder = New RectangleF(1, 1, Me.Width - 2, Me.Height - 2)
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.DrawArc(p1, rectBorder, 180, -180)
        g.DrawArc(p2, rectBorder, 180, 180)

        MyBase.OnPaint(pevent)
    End Sub

End Class
