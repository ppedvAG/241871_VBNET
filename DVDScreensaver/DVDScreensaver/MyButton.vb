Imports System.Drawing.Drawing2D

Public Class MyButton
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        'MyBase.OnPaint(pevent)
        pevent.Graphics.FillRectangle(New SolidBrush(Parent.BackColor), Me.ClientRectangle)
        pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim rect = Me.ClientRectangle
        rect.Inflate(-3, -3)

        pevent.Graphics.FillEllipse(New LinearGradientBrush(rect, BackColor, Color.DarkRed, 90), rect)

        pevent.Graphics.DrawEllipse(New Pen(Color.DarkBlue, 4), rect)

        Dim sf = New StringFormat()
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center
        pevent.Graphics.DrawString(Text, New Font("Segoe", 22), New SolidBrush(ForeColor), rect, sf)
    End Sub

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)

            If value = Color.Pink Then
                MyBase.BackColor = Color.Yellow
            Else
                MyBase.BackColor = value
            End If

        End Set
    End Property

End Class
