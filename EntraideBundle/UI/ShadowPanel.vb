Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D


' A1Panel class
Public Class ShadowPanel
    Inherits Panel

    Private _borderWidth As Integer = 1

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue(1)> _
    Public Property BorderWidth As Integer
        Get
            Return Me._borderWidth
        End Get
        Set(value As Integer)
            Me._borderWidth = value
            Invalidate()
        End Set
    End Property

    Private _shadowOffSet As Integer = 5

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue(5)> _
    Public Property ShadowOffSet As Integer
        Get
            Return Me._shadowOffSet
        End Get
        Set(value As Integer)
            Me._shadowOffSet = Math.Abs(value)
            Invalidate()
        End Set
    End Property

    Private _roundCornerRadius As Integer = 4

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue(4)> _
    Public Property RoundCornerRadius As Integer
        Get
            Return Me._roundCornerRadius
        End Get
        Set(value As Integer)
            Me._roundCornerRadius = Math.Abs(value)
            Invalidate()
        End Set
    End Property

    Private _image As Image

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category)> _
    Public Property Image As Image
        Get
            Return Me._image
        End Get
        Set(value As Image)
            Me._image = value
            Invalidate()
        End Set
    End Property

    Private _imageLocation As Point = New Point(4, 4)

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue("4,4")> _
    Public Property ImageLocation As Point
        Get
            Return Me._imageLocation
        End Get
        Set(value As Point)
            Me._imageLocation = value
            Invalidate()
        End Set
    End Property

    Private _borderColor As Color = Color.Gray

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue("Color.Gray")> _
    Public Property BorderColor As Color
        Get
            Return Me._borderColor
        End Get
        Set(value As Color)
            Me._borderColor = value
            Invalidate()
        End Set
    End Property

    Private _gradientStartColor As Color = Color.White

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue("Color.White")> _
    Public Property GradientStartColor As Color
        Get
            Return Me._gradientStartColor
        End Get
        Set(value As Color)
            Me._gradientStartColor = value
            Invalidate()
        End Set
    End Property

    Private _gradientEndColor As Color = Color.Gray

    <Browsable(True), _
     Category(A1PanelGlobals.A1Category), _
     DefaultValue("Color.Gray")> _
    Public Property GradientEndColor As Color
        Get
            Return Me._gradientEndColor
        End Get
        Set(value As Color)
            Me._gradientEndColor = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'InitializeComponent()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
        Dim tmpShadowOffSet As Integer = Math.Min(Math.Min(Me._shadowOffSet, (Me.Width - 2)), (Me.Height - 2))
        Dim tmpSoundCornerRadius As Integer = Math.Min(Math.Min(Me._roundCornerRadius, (Me.Width - 2)), (Me.Height - 2))
        If ((Me.Width > 1) _
                    AndAlso (Me.Height > 1)) Then
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            Dim rect As Rectangle = New Rectangle(0, 0, (Me.Width _
                            - (tmpShadowOffSet - 1)), (Me.Height _
                            - (tmpShadowOffSet - 1)))
            Dim rectShadow As Rectangle = New Rectangle(tmpShadowOffSet, tmpShadowOffSet, (Me.Width _
                            - (tmpShadowOffSet - 1)), (Me.Height _
                            - (tmpShadowOffSet - 1)))
            Dim graphPathShadow As GraphicsPath = A1PanelGraphics.GetRoundPath(rectShadow, tmpSoundCornerRadius)
            Dim graphPath As GraphicsPath = A1PanelGraphics.GetRoundPath(rect, tmpSoundCornerRadius)
            If (tmpSoundCornerRadius > 0) Then
                Dim gBrush As PathGradientBrush = New PathGradientBrush(graphPathShadow)
                gBrush.WrapMode = WrapMode.Clamp
                Dim colorBlend As ColorBlend = New ColorBlend(3)
                colorBlend.Colors = New Color() {Color.Transparent, Color.FromArgb(180, Color.DimGray), Color.FromArgb(180, Color.DimGray)}
                colorBlend.Positions = New Single() {0.0!, 0.0, 1.0!, 1.0!}
                gBrush.InterpolationColors = colorBlend
                e.Graphics.FillPath(gBrush, graphPathShadow)
            End If

            ' Draw backgroup
            Dim brush As LinearGradientBrush = New LinearGradientBrush(rect, Me._gradientStartColor, Me._gradientEndColor, LinearGradientMode.BackwardDiagonal)
            e.Graphics.FillPath(brush, graphPath)
            e.Graphics.DrawPath(New Pen(Color.FromArgb(180, Me._borderColor), Me._borderWidth), graphPath)
            ' Draw Image
            If (Not (Me._image) Is Nothing) Then
                e.Graphics.DrawImageUnscaled(Me._image, Me._imageLocation)
            End If

        End If

    End Sub
End Class

' A1PanelGraphics class
Class A1PanelGraphics

    Public Shared Function GetRoundPath(ByVal r As Rectangle, ByVal depth As Integer) As GraphicsPath
        Dim graphPath As GraphicsPath = New GraphicsPath
        graphPath.AddArc(r.X, r.Y, depth, depth, 180, 90)
        graphPath.AddArc((r.X _
                        + (r.Width - depth)), r.Y, depth, depth, 270, 90)
        graphPath.AddArc((r.X _
                        + (r.Width - depth)), (r.Y _
                        + (r.Height - depth)), depth, depth, 0, 90)
        graphPath.AddArc(r.X, (r.Y _
                        + (r.Height - depth)), depth, depth, 90, 90)
        graphPath.AddLine(r.X, (r.Y + (r.Height - depth)), r.X, CInt(r.Y + (depth / 2)))
        Return graphPath
    End Function
End Class

' A1PanelGlobals class
Class A1PanelGlobals

    Public Const A1Category As String = "A1"
End Class
