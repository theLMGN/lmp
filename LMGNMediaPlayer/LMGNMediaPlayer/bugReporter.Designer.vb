<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bugReporter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New LMGNMediaPlayer.LogInThemeContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogInPassTextBox2 = New LMGNMediaPlayer.LogInPassTextBox()
        Me.LogInRadialProgressBar2 = New LMGNMediaPlayer.LogInRadialProgressBar()
        Me.LogInPassTextBox1 = New LMGNMediaPlayer.LogInPassTextBox()
        Me.LogInRadialProgressBar1 = New LMGNMediaPlayer.LogInRadialProgressBar()
        Me.LogInUserTextBox1 = New LMGNMediaPlayer.LogInUserTextBox()
        Me.LogInButtonWithProgress1 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LogInProgressBar1 = New LMGNMediaPlayer.LogInProgressBar()
        Me.LogInButtonWithProgress2 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInRichTextBox1 = New LMGNMediaPlayer.LogInRichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LogInButtonWithProgress3 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = True
        Me.LogInThemeContainer1.AllowMaximize = True
        Me.LogInThemeContainer1.AllowMinimize = True
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.CloseChoice = LMGNMediaPlayer.LogInThemeContainer.__CloseChoice.Form
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.Panel1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Movable = True
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Sizable = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(866, 256)
        Me.LogInThemeContainer1.SmartBounds = True
        Me.LogInThemeContainer1.TabIndex = 0
        Me.LogInThemeContainer1.Text = "Bug Reporter"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LogInPassTextBox2)
        Me.Panel1.Controls.Add(Me.LogInRadialProgressBar2)
        Me.Panel1.Controls.Add(Me.LogInPassTextBox1)
        Me.Panel1.Controls.Add(Me.LogInRadialProgressBar1)
        Me.Panel1.Controls.Add(Me.LogInUserTextBox1)
        Me.Panel1.Controls.Add(Me.LogInButtonWithProgress1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 224)
        Me.Panel1.TabIndex = 6
        '
        'LogInPassTextBox2
        '
        Me.LogInPassTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.LogInPassTextBox2.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInPassTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LogInPassTextBox2.Location = New System.Drawing.Point(65, 56)
        Me.LogInPassTextBox2.MaxLength = 32767
        Me.LogInPassTextBox2.Multiline = False
        Me.LogInPassTextBox2.Name = "LogInPassTextBox2"
        Me.LogInPassTextBox2.ReadOnly = False
        Me.LogInPassTextBox2.Size = New System.Drawing.Size(786, 29)
        Me.LogInPassTextBox2.TabIndex = 11
        Me.LogInPassTextBox2.Text = "youremail@you.com"
        Me.LogInPassTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInPassTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LogInPassTextBox2.UseSystemPasswordChar = False
        '
        'LogInRadialProgressBar2
        '
        Me.LogInRadialProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInRadialProgressBar2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadialProgressBar2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadialProgressBar2.Location = New System.Drawing.Point(9, 91)
        Me.LogInRadialProgressBar2.Maximum = 100
        Me.LogInRadialProgressBar2.Name = "LogInRadialProgressBar2"
        Me.LogInRadialProgressBar2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInRadialProgressBar2.RotationAngle = 255
        Me.LogInRadialProgressBar2.Size = New System.Drawing.Size(50, 50)
        Me.LogInRadialProgressBar2.StartingAngle = 90
        Me.LogInRadialProgressBar2.TabIndex = 10
        Me.LogInRadialProgressBar2.Text = "LogInRadialProgressBar2"
        Me.LogInRadialProgressBar2.Value = 0
        '
        'LogInPassTextBox1
        '
        Me.LogInPassTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInPassTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInPassTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LogInPassTextBox1.Location = New System.Drawing.Point(65, 91)
        Me.LogInPassTextBox1.MaxLength = 32767
        Me.LogInPassTextBox1.Multiline = True
        Me.LogInPassTextBox1.Name = "LogInPassTextBox1"
        Me.LogInPassTextBox1.ReadOnly = False
        Me.LogInPassTextBox1.Size = New System.Drawing.Size(786, 87)
        Me.LogInPassTextBox1.TabIndex = 9
        Me.LogInPassTextBox1.Text = "Body (at least 100 chars)"
        Me.LogInPassTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInPassTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LogInPassTextBox1.UseSystemPasswordChar = False
        '
        'LogInRadialProgressBar1
        '
        Me.LogInRadialProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInRadialProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadialProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadialProgressBar1.Location = New System.Drawing.Point(9, 14)
        Me.LogInRadialProgressBar1.Maximum = 50
        Me.LogInRadialProgressBar1.Name = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInRadialProgressBar1.RotationAngle = 255
        Me.LogInRadialProgressBar1.Size = New System.Drawing.Size(50, 51)
        Me.LogInRadialProgressBar1.StartingAngle = 110
        Me.LogInRadialProgressBar1.TabIndex = 8
        Me.LogInRadialProgressBar1.Text = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.Value = 0
        '
        'LogInUserTextBox1
        '
        Me.LogInUserTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInUserTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInUserTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInUserTextBox1.Location = New System.Drawing.Point(65, 21)
        Me.LogInUserTextBox1.MaxLength = 32767
        Me.LogInUserTextBox1.Multiline = False
        Me.LogInUserTextBox1.Name = "LogInUserTextBox1"
        Me.LogInUserTextBox1.ReadOnly = False
        Me.LogInUserTextBox1.Size = New System.Drawing.Size(786, 29)
        Me.LogInUserTextBox1.TabIndex = 7
        Me.LogInUserTextBox1.Text = "Title (at least 50 chars)"
        Me.LogInUserTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInUserTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInUserTextBox1.UseSystemPasswordChar = False
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(746, 184)
        Me.LogInButtonWithProgress1.Maximum = 150
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(105, 30)
        Me.LogInButtonWithProgress1.TabIndex = 6
        Me.LogInButtonWithProgress1.Text = "Submit "
        Me.LogInButtonWithProgress1.Value = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LogInProgressBar1)
        Me.Panel2.Controls.Add(Me.LogInButtonWithProgress2)
        Me.Panel2.Controls.Add(Me.LogInRichTextBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(860, 207)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'LogInProgressBar1
        '
        Me.LogInProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LogInProgressBar1.Location = New System.Drawing.Point(9, 173)
        Me.LogInProgressBar1.Maximum = 13
        Me.LogInProgressBar1.Name = "LogInProgressBar1"
        Me.LogInProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.LogInProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LogInProgressBar1.Size = New System.Drawing.Size(731, 25)
        Me.LogInProgressBar1.TabIndex = 14
        Me.LogInProgressBar1.Text = "LogInProgressBar1"
        Me.LogInProgressBar1.TwoColour = True
        Me.LogInProgressBar1.Value = 0
        '
        'LogInButtonWithProgress2
        '
        Me.LogInButtonWithProgress2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress2.Location = New System.Drawing.Point(758, 170)
        Me.LogInButtonWithProgress2.Maximum = 100
        Me.LogInButtonWithProgress2.Name = "LogInButtonWithProgress2"
        Me.LogInButtonWithProgress2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInButtonWithProgress2.Size = New System.Drawing.Size(82, 30)
        Me.LogInButtonWithProgress2.TabIndex = 3
        Me.LogInButtonWithProgress2.Text = "Try again"
        Me.LogInButtonWithProgress2.Value = 100
        '
        'LogInRichTextBox1
        '
        Me.LogInRichTextBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRichTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRichTextBox1.Enabled = False
        Me.LogInRichTextBox1.Location = New System.Drawing.Point(116, 36)
        Me.LogInRichTextBox1.Name = "LogInRichTextBox1"
        Me.LogInRichTextBox1.Size = New System.Drawing.Size(724, 128)
        Me.LogInRichTextBox1.TabIndex = 2
        Me.LogInRichTextBox1.Text = "LogInRichTextBox1"
        Me.LogInRichTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(111, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(574, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Uh, oh. We've encountered an error: Error information down below"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 72.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 128)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":("
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.LogInButtonWithProgress3)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(1, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 207)
        Me.Panel3.TabIndex = 13
        Me.Panel3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 72.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 128)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = ":)"
        '
        'LogInButtonWithProgress3
        '
        Me.LogInButtonWithProgress3.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress3.Location = New System.Drawing.Point(759, 170)
        Me.LogInButtonWithProgress3.Maximum = 100
        Me.LogInButtonWithProgress3.Name = "LogInButtonWithProgress3"
        Me.LogInButtonWithProgress3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInButtonWithProgress3.Size = New System.Drawing.Size(82, 30)
        Me.LogInButtonWithProgress3.TabIndex = 3
        Me.LogInButtonWithProgress3.Text = "Exit"
        Me.LogInButtonWithProgress3.Value = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(111, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(396, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "We've sent it, thank you for reporting this bug"
        '
        'bugReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 256)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(866, 256)
        Me.MinimumSize = New System.Drawing.Size(866, 256)
        Me.Name = "bugReporter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bugReporter"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogInPassTextBox2 As LogInPassTextBox
    Friend WithEvents LogInRadialProgressBar2 As LogInRadialProgressBar
    Friend WithEvents LogInPassTextBox1 As LogInPassTextBox
    Friend WithEvents LogInRadialProgressBar1 As LogInRadialProgressBar
    Friend WithEvents LogInUserTextBox1 As LogInUserTextBox
    Friend WithEvents LogInButtonWithProgress1 As LogInButtonWithProgress
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LogInButtonWithProgress2 As LogInButtonWithProgress
    Friend WithEvents LogInRichTextBox1 As LogInRichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LogInButtonWithProgress3 As LogInButtonWithProgress
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LogInProgressBar1 As LogInProgressBar
    Friend WithEvents Timer1 As Timer
End Class
