<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPlayer))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInGroupBox2 = New LMGNMediaPlayer.LogInGroupBox()
        Me.LogInButtonWithProgress8 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogInButtonWithProgress12 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInNormalTextBox1 = New LMGNMediaPlayer.LogInNormalTextBox()
        Me.LogInButtonWithProgress11 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInButtonWithProgress10 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInButtonWithProgress9 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInSeperator1 = New LMGNMediaPlayer.LogInSeperator()
        Me.LogInButtonWithProgress7 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInGroupBox1 = New LMGNMediaPlayer.LogInGroupBox()
        Me.LogInTrackBar1 = New LMGNMediaPlayer.LogInTrackBar()
        Me.LogInNumeric1 = New LMGNMediaPlayer.LogInNumeric()
        Me.LogInLabel1 = New LMGNMediaPlayer.LogInLabel()
        Me.LogInButtonWithProgress5 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInButtonWithProgress4 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInButtonWithProgress3 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInButtonWithProgress2 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInButtonWithProgress1 = New LMGNMediaPlayer.LogInButtonWithProgress()
        Me.LogInThemeContainer1 = New LMGNMediaPlayer.LogInThemeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogInOnOffSwitch1 = New LMGNMediaPlayer.LogInOnOffSwitch()
        Me.LogInButton1 = New LMGNMediaPlayer.LogInButton()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogInGroupBox2.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 36)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(978, 564)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox1.Image = Global.LMGNMediaPlayer.My.Resources.Resources.loading
        Me.PictureBox1.Location = New System.Drawing.Point(0, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(978, 561)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'LogInGroupBox2
        '
        Me.LogInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox2.Controls.Add(Me.LogInButtonWithProgress8)
        Me.LogInGroupBox2.Controls.Add(Me.Panel1)
        Me.LogInGroupBox2.Controls.Add(Me.LogInButtonWithProgress12)
        Me.LogInGroupBox2.Controls.Add(Me.LogInNormalTextBox1)
        Me.LogInGroupBox2.Controls.Add(Me.LogInButtonWithProgress11)
        Me.LogInGroupBox2.Controls.Add(Me.LogInButtonWithProgress10)
        Me.LogInGroupBox2.Controls.Add(Me.LogInButtonWithProgress9)
        Me.LogInGroupBox2.Controls.Add(Me.LogInSeperator1)
        Me.LogInGroupBox2.Controls.Add(Me.LogInButtonWithProgress7)
        Me.LogInGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox2.Location = New System.Drawing.Point(227, 255)
        Me.LogInGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox2.Name = "LogInGroupBox2"
        Me.LogInGroupBox2.Size = New System.Drawing.Size(508, 128)
        Me.LogInGroupBox2.TabIndex = 5
        Me.LogInGroupBox2.Text = "Open File"
        Me.LogInGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInGroupBox2.Visible = False
        '
        'LogInButtonWithProgress8
        '
        Me.LogInButtonWithProgress8.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress8.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress8.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress8.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress8.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress8.Location = New System.Drawing.Point(6, 88)
        Me.LogInButtonWithProgress8.Maximum = 100
        Me.LogInButtonWithProgress8.Name = "LogInButtonWithProgress8"
        Me.LogInButtonWithProgress8.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress8.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress8.Size = New System.Drawing.Size(305, 30)
        Me.LogInButtonWithProgress8.TabIndex = 10
        Me.LogInButtonWithProgress8.Text = "Test Video (Big Buck Bunny, 480p, Netherlands mirror)"
        Me.LogInButtonWithProgress8.Value = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(76, -48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 75)
        Me.Panel1.TabIndex = 9
        '
        'LogInButtonWithProgress12
        '
        Me.LogInButtonWithProgress12.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress12.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress12.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress12.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress12.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress12.Location = New System.Drawing.Point(419, 89)
        Me.LogInButtonWithProgress12.Maximum = 100
        Me.LogInButtonWithProgress12.Name = "LogInButtonWithProgress12"
        Me.LogInButtonWithProgress12.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress12.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInButtonWithProgress12.Size = New System.Drawing.Size(75, 30)
        Me.LogInButtonWithProgress12.TabIndex = 8
        Me.LogInButtonWithProgress12.Text = "Ok"
        Me.LogInButtonWithProgress12.Value = 100
        '
        'LogInNormalTextBox1
        '
        Me.LogInNormalTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox1.Location = New System.Drawing.Point(13, 33)
        Me.LogInNormalTextBox1.MaxLength = 32767
        Me.LogInNormalTextBox1.Multiline = False
        Me.LogInNormalTextBox1.Name = "LogInNormalTextBox1"
        Me.LogInNormalTextBox1.ReadOnly = False
        Me.LogInNormalTextBox1.Size = New System.Drawing.Size(373, 29)
        Me.LogInNormalTextBox1.Style = LMGNMediaPlayer.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox1.TabIndex = 7
        Me.LogInNormalTextBox1.Text = "URL (http://example.com/file.mp4) or path (F:\video.mp4)"
        Me.LogInNormalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox1.UseSystemPasswordChar = False
        '
        'LogInButtonWithProgress11
        '
        Me.LogInButtonWithProgress11.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress11.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress11.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress11.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress11.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress11.Location = New System.Drawing.Point(392, 33)
        Me.LogInButtonWithProgress11.Maximum = 100
        Me.LogInButtonWithProgress11.Name = "LogInButtonWithProgress11"
        Me.LogInButtonWithProgress11.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress11.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LogInButtonWithProgress11.Size = New System.Drawing.Size(30, 30)
        Me.LogInButtonWithProgress11.TabIndex = 6
        Me.LogInButtonWithProgress11.Text = "\"
        Me.LogInButtonWithProgress11.Value = 100
        '
        'LogInButtonWithProgress10
        '
        Me.LogInButtonWithProgress10.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress10.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress10.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress10.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress10.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress10.Location = New System.Drawing.Point(464, 33)
        Me.LogInButtonWithProgress10.Maximum = 100
        Me.LogInButtonWithProgress10.Name = "LogInButtonWithProgress10"
        Me.LogInButtonWithProgress10.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress10.ProgressColour = System.Drawing.Color.DeepSkyBlue
        Me.LogInButtonWithProgress10.Size = New System.Drawing.Size(30, 30)
        Me.LogInButtonWithProgress10.TabIndex = 5
        Me.LogInButtonWithProgress10.Text = "+"
        Me.LogInButtonWithProgress10.Value = 100
        '
        'LogInButtonWithProgress9
        '
        Me.LogInButtonWithProgress9.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress9.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress9.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress9.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress9.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress9.Location = New System.Drawing.Point(428, 33)
        Me.LogInButtonWithProgress9.Maximum = 100
        Me.LogInButtonWithProgress9.Name = "LogInButtonWithProgress9"
        Me.LogInButtonWithProgress9.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress9.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInButtonWithProgress9.Size = New System.Drawing.Size(30, 30)
        Me.LogInButtonWithProgress9.TabIndex = 4
        Me.LogInButtonWithProgress9.Text = "="
        Me.LogInButtonWithProgress9.Value = 100
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = LMGNMediaPlayer.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(0, 68)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(508, 20)
        Me.LogInSeperator1.TabIndex = 1
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'LogInButtonWithProgress7
        '
        Me.LogInButtonWithProgress7.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress7.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress7.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress7.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress7.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress7.Location = New System.Drawing.Point(476, 1)
        Me.LogInButtonWithProgress7.Maximum = 100
        Me.LogInButtonWithProgress7.Name = "LogInButtonWithProgress7"
        Me.LogInButtonWithProgress7.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress7.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInButtonWithProgress7.Size = New System.Drawing.Size(31, 25)
        Me.LogInButtonWithProgress7.TabIndex = 0
        Me.LogInButtonWithProgress7.Text = "X"
        Me.LogInButtonWithProgress7.Value = 100
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.LogInTrackBar1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInNumeric1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInLabel1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInButtonWithProgress5)
        Me.LogInGroupBox1.Controls.Add(Me.LogInButtonWithProgress4)
        Me.LogInGroupBox1.Controls.Add(Me.LogInButtonWithProgress3)
        Me.LogInGroupBox1.Controls.Add(Me.LogInButtonWithProgress2)
        Me.LogInGroupBox1.Controls.Add(Me.LogInButtonWithProgress1)
        Me.LogInGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(0, 600)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(978, 64)
        Me.LogInGroupBox1.TabIndex = 2
        Me.LogInGroupBox1.Text = "Player Controls"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInTrackBar1
        '
        Me.LogInTrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTrackBar1.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTrackBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTrackBar1.Location = New System.Drawing.Point(233, 41)
        Me.LogInTrackBar1.Maximum = 10
        Me.LogInTrackBar1.Name = "LogInTrackBar1"
        Me.LogInTrackBar1.Size = New System.Drawing.Size(539, 23)
        Me.LogInTrackBar1.StripAmountColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInTrackBar1.StripColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInTrackBar1.TabIndex = 11
        Me.LogInTrackBar1.Text = "LogInTrackBar1"
        Me.LogInTrackBar1.TextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInTrackBar1.Value = 0
        '
        'LogInNumeric1
        '
        Me.LogInNumeric1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNumeric1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNumeric1.ButtonColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInNumeric1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInNumeric1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNumeric1.Location = New System.Drawing.Point(778, 35)
        Me.LogInNumeric1.Maximum = CType(100, Long)
        Me.LogInNumeric1.Minimum = CType(0, Long)
        Me.LogInNumeric1.Name = "LogInNumeric1"
        Me.LogInNumeric1.SecondBorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNumeric1.Size = New System.Drawing.Size(200, 24)
        Me.LogInNumeric1.TabIndex = 9
        Me.LogInNumeric1.Text = "LogInNumeric1"
        Me.LogInNumeric1.Value = CType(100, Long)
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(230, 28)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(60, 15)
        Me.LogInLabel1.TabIndex = 8
        Me.LogInLabel1.Text = "0:00 / 0:00"
        '
        'LogInButtonWithProgress5
        '
        Me.LogInButtonWithProgress5.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress5.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress5.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress5.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress5.Location = New System.Drawing.Point(180, 28)
        Me.LogInButtonWithProgress5.Maximum = 1
        Me.LogInButtonWithProgress5.Name = "LogInButtonWithProgress5"
        Me.LogInButtonWithProgress5.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress5.ProgressColour = System.Drawing.Color.DeepSkyBlue
        Me.LogInButtonWithProgress5.Size = New System.Drawing.Size(44, 36)
        Me.LogInButtonWithProgress5.TabIndex = 5
        Me.LogInButtonWithProgress5.Text = "Open"
        Me.LogInButtonWithProgress5.Value = 1
        '
        'LogInButtonWithProgress4
        '
        Me.LogInButtonWithProgress4.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress4.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress4.Location = New System.Drawing.Point(156, 28)
        Me.LogInButtonWithProgress4.Maximum = 1
        Me.LogInButtonWithProgress4.Name = "LogInButtonWithProgress4"
        Me.LogInButtonWithProgress4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress4.ProgressColour = System.Drawing.Color.DeepSkyBlue
        Me.LogInButtonWithProgress4.Size = New System.Drawing.Size(24, 36)
        Me.LogInButtonWithProgress4.TabIndex = 3
        Me.LogInButtonWithProgress4.Text = ">"
        Me.LogInButtonWithProgress4.Value = 1
        '
        'LogInButtonWithProgress3
        '
        Me.LogInButtonWithProgress3.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress3.Location = New System.Drawing.Point(132, 28)
        Me.LogInButtonWithProgress3.Maximum = 1
        Me.LogInButtonWithProgress3.Name = "LogInButtonWithProgress3"
        Me.LogInButtonWithProgress3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress3.ProgressColour = System.Drawing.Color.DeepSkyBlue
        Me.LogInButtonWithProgress3.Size = New System.Drawing.Size(24, 36)
        Me.LogInButtonWithProgress3.TabIndex = 2
        Me.LogInButtonWithProgress3.Text = "<"
        Me.LogInButtonWithProgress3.Value = 1
        '
        'LogInButtonWithProgress2
        '
        Me.LogInButtonWithProgress2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress2.Location = New System.Drawing.Point(66, 28)
        Me.LogInButtonWithProgress2.Maximum = 1
        Me.LogInButtonWithProgress2.Name = "LogInButtonWithProgress2"
        Me.LogInButtonWithProgress2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress2.ProgressColour = System.Drawing.Color.DeepSkyBlue
        Me.LogInButtonWithProgress2.Size = New System.Drawing.Size(66, 36)
        Me.LogInButtonWithProgress2.TabIndex = 1
        Me.LogInButtonWithProgress2.Text = "Stop"
        Me.LogInButtonWithProgress2.Value = 1
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(0, 29)
        Me.LogInButtonWithProgress1.Maximum = 1
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(66, 34)
        Me.LogInButtonWithProgress1.TabIndex = 0
        Me.LogInButtonWithProgress1.Text = "Play"
        Me.LogInButtonWithProgress1.Value = 1
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
        Me.LogInThemeContainer1.Controls.Add(Me.LogInButton1)
        Me.LogInThemeContainer1.Controls.Add(Me.Label1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInOnOffSwitch1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Movable = True
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Sizable = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(978, 36)
        Me.LogInThemeContainer1.SmartBounds = True
        Me.LogInThemeContainer1.TabIndex = 1
        Me.LogInThemeContainer1.Text = "LMGNMediaPlayer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(671, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Loading animation"
        '
        'LogInOnOffSwitch1
        '
        Me.LogInOnOffSwitch1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInOnOffSwitch1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInOnOffSwitch1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInOnOffSwitch1.Location = New System.Drawing.Point(800, 6)
        Me.LogInOnOffSwitch1.Name = "LogInOnOffSwitch1"
        Me.LogInOnOffSwitch1.NonToggledTextColourderColour = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.LogInOnOffSwitch1.Size = New System.Drawing.Size(75, 23)
        Me.LogInOnOffSwitch1.TabIndex = 11
        Me.LogInOnOffSwitch1.Text = "LogInOnOffSwitch1"
        Me.LogInOnOffSwitch1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInOnOffSwitch1.Toggled = LMGNMediaPlayer.LogInOnOffSwitch.Toggles.Toggled
        Me.LogInOnOffSwitch1.ToggledColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(26, Byte), Integer))
        '
        'LogInButton1
        '
        Me.LogInButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton1.Location = New System.Drawing.Point(575, 3)
        Me.LogInButton1.Name = "LogInButton1"
        Me.LogInButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.Size = New System.Drawing.Size(90, 30)
        Me.LogInButton1.TabIndex = 6
        Me.LogInButton1.Text = "Report Bug"
        '
        'MainPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 664)
        Me.Controls.Add(Me.LogInGroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.LogInGroupBox1)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(978, 133)
        Me.Name = "MainPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LMGNMediaPlayer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogInGroupBox2.ResumeLayout(False)
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.LogInGroupBox1.PerformLayout()
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents LogInButtonWithProgress1 As LogInButtonWithProgress
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LogInButtonWithProgress2 As LogInButtonWithProgress
    Friend WithEvents LogInButtonWithProgress4 As LogInButtonWithProgress
    Friend WithEvents LogInButtonWithProgress3 As LogInButtonWithProgress
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents LogInButtonWithProgress6 As LogInButtonWithProgress
    Friend WithEvents LogInButtonWithProgress5 As LogInButtonWithProgress
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogInGroupBox2 As LogInGroupBox
    Friend WithEvents LogInButtonWithProgress10 As LogInButtonWithProgress
    Friend WithEvents LogInButtonWithProgress9 As LogInButtonWithProgress
    Friend WithEvents LogInSeperator1 As LogInSeperator
    Friend WithEvents LogInButtonWithProgress7 As LogInButtonWithProgress
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LogInButtonWithProgress11 As LogInButtonWithProgress
    Friend WithEvents LogInButtonWithProgress12 As LogInButtonWithProgress
    Friend WithEvents LogInNormalTextBox1 As LogInNormalTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer3 As Timer
    Friend WithEvents LogInNumeric1 As LogInNumeric
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogInTrackBar1 As LogInTrackBar
    Friend WithEvents LogInButtonWithProgress8 As LogInButtonWithProgress
    Friend WithEvents Label1 As Label
    Friend WithEvents LogInOnOffSwitch1 As LogInOnOffSwitch
    Friend WithEvents LogInButton1 As LogInButton
End Class
