Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MainPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(35, 35, 35)
        Debug.WriteLine("'Ello!")
    End Sub
End Class
