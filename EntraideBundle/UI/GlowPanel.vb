Namespace UI
    Public Class GlowPanel
        Inherits Panel

        Private Const CS_DROPSHADOW As Integer = 131072

        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Return cp
            End Get
        End Property

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim offset As Integer = 0

            e.Graphics.DrawRectangle(Pens.LightBlue, New Rectangle(New Point(offset, offset), New Size(e.ClipRectangle.Width - ((offset * 2) + 1), e.ClipRectangle.Height - ((offset * 2) + 1))))

            offset += 1

            e.Graphics.DrawRectangle(Pens.Blue, New Rectangle(New Point(offset, offset), New Size(e.ClipRectangle.Width - ((offset * 2) + 1), e.ClipRectangle.Height - ((offset * 2) + 1))))

            offset += 1

            e.Graphics.DrawRectangle(Pens.DarkBlue, New Rectangle(New Point(offset, offset), New Size(e.ClipRectangle.Width - ((offset * 2) + 1), e.ClipRectangle.Height - ((offset * 2) + 1))))

        End Sub

    End Class
End Namespace
