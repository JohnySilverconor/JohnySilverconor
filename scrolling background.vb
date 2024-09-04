Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Enabled = True
                TmrLeft.Enabled = False
                collision()
            Case Keys.Left
                TmrLeft.Enabled = True
                TmrRight.Enabled = False
        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
         Select e.KeyCode
            Case Keys.Right
                TmrRight.Enabled = False

            Case Keys.Left
                TmrLeft.Enabled = False
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = False
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        Dim Objects() As PictureBox = {Pic1, Pic2, Pic3, Pic4, Pic5}
        For x = 0 To Objects.Length - 1
            Objects(x).Left -= 5
        Next
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        Dim Objects() As PictureBox = {Pic1, Pic2, Pic3, Pic4, Pic5}
        For x = 0 To Objects.Length - 1
            Objects(x).Left += 5
        Next
    End Sub
    Private Sub collision()

        Dim GOAL As Boolean = False
        If GOAL = False Then
            If Pic5.Location.X - pbPlayer.Location.X <= 0 Then
                MessageBox.Show("Goal achieved")
                GOAL = True
            Else

            End If
        End If
    End Sub
End Class