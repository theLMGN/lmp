Imports System.Net.Mail
Public Class bugReporter
    Private Sub bugReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogInUserTextBox1_TextChanged(sender As Object, e As EventArgs) Handles LogInUserTextBox1.TextChanged
        LogInRadialProgressBar1.Value = LogInUserTextBox1.Text.Length
        LogInButtonWithProgress1.Value = LogInPassTextBox1.Text.Length + LogInUserTextBox1.Text.Length
    End Sub

    Private Sub LogInPassTextBox1_TextChanged(sender As Object, e As EventArgs) Handles LogInPassTextBox1.TextChanged
        LogInRadialProgressBar2.Value = LogInPassTextBox1.Text.Length
        LogInButtonWithProgress1.Value = LogInPassTextBox1.Text.Length + LogInUserTextBox1.Text.Length
    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential("lmpbugs@thelmgn.com", "lmgnmediaplayerbuggies")
            SmtpServer.Port = 465
            SmtpServer.Host = "mail.thelmgn.com"
            mail = New MailMessage()
            mail.From = New MailAddress("lmpbugs@thelmgn.com")
            mail.To.Add("contact@thelmgn.com")
            mail.Subject = LogInUserTextBox1.Text
            mail.Body = LogInPassTextBox1.Text
            MsgBox("Sending now!")
            SmtpServer.Send(mail)

            Panel3.Visible = True
        Catch ex As Exception
            Panel2.Visible = True
            LogInRichTextBox1.Text = ex.ToString
        End Try
    End Sub

    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        Panel2.Visible = False
    End Sub

    Private Sub LogInButtonWithProgress3_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress3.Click
        Panel3.Visible = False
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        While True
            Console.WriteLine(LogInProgressBar1.Value)
        End While
    End Sub
End Class