Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'Me.BackColor = Color.FromArgb(0, 0, 0)
        'Button1.BackColor = Color.DarkRed

        'Button1.Text = "Eleni"

        ' Button1.ForeColor = Color.Yellow



        'Button1.Width = 200
        'Button1.Height = 100




        'Button1.Location = New Point(300, 150)


        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            Button1.Text += 1
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Button2.Text = CInt(Button2.Text) + 1
        ' Button2.Text += 1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Text = CInt(Button2.Text) + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button2.Text = CInt(Button2.Text) - 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button2.Text = CInt(Button2.Text) - 1


        If CInt(Button2.Text) = 0 Then
            Timer1.Enabled = False
            MsgBox("The timer has stopped")

            Button5.Visible = True



            Button1.Enabled = False
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Button2.Text = 5

        ' Timer1.Enabled = True


        Button5.Visible = False


        Button1.Enabled = True
        Button1.Text = 0

    End Sub

End Class
