Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Me.PictureBox1.Left -= 25
            Case Keys.Up
                Me.PictureBox1.Top -= 25
            Case Keys.Right
                Me.PictureBox1.Left += 25
            Case Keys.Down
                Me.PictureBox1.Top += 25
        End Select
    End Sub


End Class

