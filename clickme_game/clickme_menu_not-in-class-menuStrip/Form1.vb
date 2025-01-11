Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()     ' κάνει την Rnd() να παράγει πραγματικά τυχαίους αριθμούς

        If (Timer1.Enabled = False) Then
            Timer1.Enabled = True
        End If

        ' Button1.Text = Button1.Text + 1
        ' Button1.Text = Rnd()


        ' Παραγωγή τυχαίων αριθμών από το 0 έως το 99
        ' Button1.Text = Int(Rnd() * 100)

        ' Παραγωγή τυχαίων αριθμών από το 1 έως το 100
        ' Button1.Text = Int(Rnd() * 100) + 1

        ' Παραγωγή τυχαίων αριθμών από το 0 έως το 2
        ' Button1.Text = Int(Rnd() * 3)

        ' Παραγωγή τυχαίων αριθμών από το 1 έως το 3
        ' Button1.Text = Int(Rnd() * 3) + 1

        Button1.Text = Button1.Text + 1

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer

        a = Int(Rnd() * 100) + 1
        b = Int(Rnd() * 100) + 1
        c = Int(Rnd() * 100) + 1
        d = Int(Rnd() * 100) + 1

        Button1.Left = a
        Button1.Top = b
        Button1.Width = c
        Button1.Height = d

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button2.Text = Button2.Text - 1

        If (Button2.Text = "0") Then
            Timer1.Enabled = False
            Button1.Enabled = False
            MsgBox("To timer σταμάτησε, πέρασαν 5 δευτερόλεπτα")
            Button3.Visible = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.Enabled = True
        Button3.Visible = False

        Button1.Text = 0
        Button2.Text = 5


        Button1.Width = 280
        Button1.Height = 61
        Button1.Left = 12
        Button1.Top = 57

        MsgBox("Το πρόγραμμα μόλις έγινε Reset και μπορείς να παίξεις ξανά")

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        If (Timer1.Enabled = False) Then
            Button1.Enabled = True
            Button3.Visible = False

            Button1.Text = 0
            Button2.Text = 5

            Button1.Width = 280
            Button1.Height = 61
            Button1.Left = 12
            Button1.Top = 57

            MsgBox("Το πρόγραμμα μόλις έγινε Reset και μπορείς να παίξεις ξανά")
        End If

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub
End Class

