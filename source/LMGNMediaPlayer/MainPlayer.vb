
Imports System.Windows.Forms
Imports System.Text
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class MainPlayer

    <DllImport("kernel32.dll", EntryPoint:="GetStdHandle", SetLastError:=True, CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function GetStdHandle(nStdHandle As Integer) As IntPtr
    End Function
    <DllImport("kernel32.dll", EntryPoint:="AllocConsole", SetLastError:=True, CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function AllocConsole() As Integer
    End Function
    Private Const STD_OUTPUT_HANDLE As Integer = -11
    Private Const MY_CODE_PAGE As Integer = 437
    Private Sub MainPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(54, 54, 54)
        AxWindowsMediaPlayer1.uiMode = "none"
        If Environment.GetCommandLineArgs.Contains("--debug") Then
            AllocConsole()
            Dim stdHandle As IntPtr = GetStdHandle(STD_OUTPUT_HANDLE)
            Dim safeFileHandle As New SafeFileHandle(stdHandle, True)
            Dim fileStream As New FileStream(safeFileHandle, FileAccess.Write)
            Dim encoding As Encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE)
            Dim standardOutput As New StreamWriter(fileStream, encoding)
            standardOutput.AutoFlush = True
            Console.SetOut(standardOutput)
        End If

        Timer1.Start()
    End Sub

    Private Sub LogInThemeContainer1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = "LMP - " & AxWindowsMediaPlayer1.status
        LogInGroupBox1.Text = AxWindowsMediaPlayer1.status
        LogInGroupBox1.Refresh()
        If LogInGroupBox1.Text = "Paused" Then
            LogInButtonWithProgress1.Text = "Play"
            LogInButtonWithProgress1.ProgressColour = Color.FromArgb(191, 191, 0)
        End If
        If LogInGroupBox1.Text = "Stopped" Then
            LogInButtonWithProgress1.Text = "Play"
            LogInButtonWithProgress1.ProgressColour = Color.FromArgb(191, 0, 0)
        End If
        If LogInGroupBox1.Text = "Ready" Then
            LogInButtonWithProgress1.Text = "Play"
            LogInButtonWithProgress1.ProgressColour = Color.FromArgb(64, 64, 64)
        End If
        If LogInGroupBox1.Text.Contains("Connecting") Or LogInGroupBox1.Text.Contains("Buffering") Then
            LogInButtonWithProgress1.Text = "Buffering"
            LogInButtonWithProgress1.ProgressColour = Color.FromArgb(191, 191, 191)
            If LogInOnOffSwitch1.Toggled Then
                PictureBox1.Visible = True
            End If
        Else
                PictureBox1.Visible = False
        End If
        If LogInGroupBox1.Text.StartsWith("Playing ") = True Then
            LogInButtonWithProgress1.Text = "Pause"
            LogInButtonWithProgress1.ProgressColour = Color.FromArgb(0, 191, 0)
        End If
        If AxWindowsMediaPlayer1.currentPlaylist.count < 2 Then
            LogInButtonWithProgress3.Enabled = False
            LogInButtonWithProgress4.Enabled = False
            LogInButtonWithProgress4.ProgressColour = Color.FromArgb(191, 0, 0)
            LogInButtonWithProgress3.ProgressColour = Color.FromArgb(191, 0, 0)
        Else
            LogInButtonWithProgress3.Enabled = True
            LogInButtonWithProgress4.Enabled = True
            LogInButtonWithProgress4.ProgressColour = Color.DeepSkyBlue
            LogInButtonWithProgress3.ProgressColour = Color.DeepSkyBlue
        End If
        Try
            LogInLabel1.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString & " \ " & AxWindowsMediaPlayer1.currentMedia.durationString
        Catch
        End Try
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not LogInGroupBox1.Text = "Paused" Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            AxWindowsMediaPlayer1.URL = ""
        End If
    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        If LogInButtonWithProgress1.Text = "Play" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        End If
    End Sub

    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub



    Private Sub LogInButtonWithProgress3_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.previous()
    End Sub

    Private Sub LogInButtonWithProgress4_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.next()
    End Sub
    Private Sub LogInButtonWithProgress10_MouseHover(sender As Object, e As EventArgs) Handles LogInButtonWithProgress10.MouseHover
        ToolTip1.ToolTipTitle = "Add"
        ToolTip1.Show("Adds the specified item to the playlist", LogInButtonWithProgress10)
    End Sub
    Private Sub LogInButtonWithProgress9_MouseHover() Handles LogInButtonWithProgress9.MouseHover
        ToolTip1.ToolTipTitle = "Replace"
        ToolTip1.Show("Removes all items from the playlist and adds the specified item", LogInButtonWithProgress9)
    End Sub

    Private Sub LogInButtonWithProgress11_MouseHover(sender As Object, e As EventArgs) Handles LogInButtonWithProgress11.MouseHover
        ToolTip1.ToolTipTitle = "Browse"
        ToolTip1.Show("Open file browser.", LogInButtonWithProgress11)
    End Sub

    Private Sub LogInButtonWithProgress5_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress5.Click
        If LogInGroupBox2.Visible Then
            LogInGroupBox2.Visible = False
        Else
            LogInGroupBox2.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            'MsgBox(AxWindowsMediaPlayer1.currentMedia.duration & " / " & AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)
            LogInTrackBar1.Maximum = AxWindowsMediaPlayer1.currentMedia.duration * 1000
            LogInTrackBar1.Value = Math.Round(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition * 1000)
            LogInTrackBar1.Refresh()
            Console.WriteLine(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition * 10000000 & " / " & AxWindowsMediaPlayer1.currentMedia.duration * 10000000)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoginTrackbar1_MouseDown(sender As Object, e As MouseEventArgs) Handles LoginTrackbar1.MouseDown
        Timer3.Stop()
    End Sub

    Private Sub LoginTrackbar1_MouseUp(sender As Object, e As MouseEventArgs) Handles LoginTrackbar1.MouseUp
        Timer3.Start()
    End Sub

    Private Sub LogInButtonWithProgress9_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress9.Click
        Try
            AxWindowsMediaPlayer1.URL = LogInNormalTextBox1.Text
            LogInGroupBox2.Visible = False
        Catch
        End Try
    End Sub

    Private Sub LogInButtonWithProgress11_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress11.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        LogInNormalTextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub LogInButtonWithProgress12_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress12.Click
        LogInGroupBox2.Visible = False
    End Sub

    Private Sub LogInButtonWithProgress7_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress7.Click
        LogInGroupBox2.Visible = False
    End Sub

    Private Sub LogInNumeric1_Click(sender As Object, e As EventArgs) Handles LogInNumeric1.Click
        AxWindowsMediaPlayer1.settings.volume = LogInNumeric1.Value
    End Sub
    Dim moveOpenDialog = False
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        moveOpenDialog = True
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        moveOpenDialog = False
    End Sub
    Dim dCursor = New Cursor(Cursor.Current.Handle)
    Dim cursorPos = dCursor.Position - Me.Bounds.Location
    Dim pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If moveOpenDialog = False Then
        Else
            cursorPos = dCursor.Position - Me.Bounds.Location
            dCursor = New Cursor(Cursor.Current.Handle)
            pos = New Point(cursorPos.X - 150, cursorPos.y - 25)
            LogInGroupBox2.Location = pos
            ' LogInGroupBox2.Text = pos.ToString()
            'LogInGroupBox2.Refresh()
        End If
    End Sub

    Private Sub LogInButtonWithProgress10_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress10.Click
        AxWindowsMediaPlayer1.currentPlaylist.appendItem(AxWindowsMediaPlayer1.newMedia(LogInNormalTextBox1.Text))
    End Sub

    Private Sub LogInButtonWithProgress9_MouseHover(sender As Object, e As EventArgs) Handles LogInButtonWithProgress9.MouseHover

    End Sub

    Private Sub LogInHorizontalScrollBar2_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub LogInHorizontalScrollBar2_MouseUp(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub LogInHorizontalScrollBar2_MouseDown_1(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub LogInTrackBar1_MouseDown_1(sender As Object, e As MouseEventArgs) Handles LogInTrackBar1.MouseDown
        Timer3.Stop()
    End Sub

    Private Sub LogInTrackBar1_MouseUp_1(sender As Object, e As MouseEventArgs) Handles LogInTrackBar1.MouseUp
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = LogInTrackBar1.Value / 1000
        Timer3.Start()
    End Sub

    Private Sub LogInButtonWithProgress8_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress8.Click
        LogInNormalTextBox1.Text = "http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        bugReporter.Show()
    End Sub
End Class