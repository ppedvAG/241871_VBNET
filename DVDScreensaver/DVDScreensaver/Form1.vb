Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Hallo")
        CheckCornerHitLogic()
    End Sub


    Dim speedX As Integer = 2
    Dim speedY As Integer = 2
    Dim cornerHits As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'move
        Button2.Left += speedX
        Button2.Top += speedY

        'MyButton1.Width += 1
        Task.Run(Sub() Console.Beep(ran.Next(70, 600), 200))

        'collision X
        If Button2.Right >= ClientSize.Width Or Button2.Left <= 0 Then
            speedX *= -1
            Button2.BackColor = GetRandomColor()
            Button2.ForeColor = GetRandomColor()
            BackColor = GetRandomColor()
            'Console.Beep(ran.Next(70, 400), 500)
            Button2.Invalidate()
        End If

        'collision Y
        If Button2.Bottom >= ClientSize.Height Or Button2.Top <= 0 Then
            speedY *= -1
            Button2.BackColor = GetRandomColor()
            Button2.ForeColor = GetRandomColor()
            BackColor = GetRandomColor()

            'Console.Beep(ran.Next(70, 400), 500)
            Button2.Invalidate()
        End If

        'Button label
        Button2.Text = GetDirectionArrow()
        Text = GetDirectionArrow()


        'Corner hit logic
        CheckCornerHitLogic()

        Label1.Text = $"Corner Hits: {cornerHits}"

    End Sub

    Dim ran As New Random()
    Function GetRandomColor() As Color

        Dim r = ran.Next(256)
        Dim g = ran.Next(256)
        Dim b = ran.Next(256)


        Return Color.FromArgb(r, g, b)

    End Function

    Function GetDirectionArrow() As String
        If speedX > 0 And speedY < 0 Then
            Return "↗️"
        ElseIf speedX < 0 And speedY < 0 Then
            Return "↖️"
        ElseIf speedX < 0 And speedY > 0 Then
            Return "↙️"
        ElseIf speedX > 0 And speedY > 0 Then
            Return "↘️"
        Else
            Return "❌"
        End If
    End Function

    Sub CheckCornerHitLogic()

        If Button2.Top <= 0 And Button2.Left <= 0 _
           Or Button2.Top <= 0 And Button2.Right >= ClientSize.Width _
           Or Button2.Bottom >= ClientSize.Height And Button2.Right >= ClientSize.Width _
           Or Button2.Bottom >= ClientSize.Height And Button2.Left <= 0 Then
            cornerHits += 1
            Console.Beep()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Timer1.Enabled = CheckBox1.Checked
    End Sub

    Dim ran2 As New Random(7)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        For index = 1 To 10
            ListBox1.Items.Add(ran2.Next(100))
        Next

    End Sub
End Class
