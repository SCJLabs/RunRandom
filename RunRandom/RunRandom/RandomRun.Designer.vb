<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RandomRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RandomRun))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonReRun = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelNextRunVal = New System.Windows.Forms.Label()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCountdown = New System.Windows.Forms.Label()
        Me.TimerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.LabelMins1 = New System.Windows.Forms.Label()
        Me.LabelMins2 = New System.Windows.Forms.Label()
        Me.TextBoxRangeEnd = New System.Windows.Forms.TextBox()
        Me.TextBoxRangeStart = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Re-run command randomly between ( time in seconds )"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(130, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "and"
        '
        'ButtonReRun
        '
        Me.ButtonReRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.ButtonReRun.Location = New System.Drawing.Point(12, 98)
        Me.ButtonReRun.Name = "ButtonReRun"
        Me.ButtonReRun.Size = New System.Drawing.Size(269, 25)
        Me.ButtonReRun.TabIndex = 6
        Me.ButtonReRun.Text = "Run Now"
        Me.ButtonReRun.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(10, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Next Run:"
        '
        'LabelNextRunVal
        '
        Me.LabelNextRunVal.AutoSize = True
        Me.LabelNextRunVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelNextRunVal.Location = New System.Drawing.Point(69, 130)
        Me.LabelNextRunVal.Name = "LabelNextRunVal"
        Me.LabelNextRunVal.Size = New System.Drawing.Size(25, 13)
        Me.LabelNextRunVal.TabIndex = 8
        Me.LabelNextRunVal.Text = "      "
        '
        'TimerMain
        '
        Me.TimerMain.Interval = 30000
        '
        'LabelCountdown
        '
        Me.LabelCountdown.AutoSize = True
        Me.LabelCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelCountdown.Location = New System.Drawing.Point(69, 149)
        Me.LabelCountdown.Name = "LabelCountdown"
        Me.LabelCountdown.Size = New System.Drawing.Size(19, 13)
        Me.LabelCountdown.TabIndex = 9
        Me.LabelCountdown.Text = "    "
        '
        'TimerCountdown
        '
        Me.TimerCountdown.Interval = 1000
        '
        'txtCommand
        '
        Me.txtCommand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RunRandom.My.MySettings.Default, "command", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCommand.Location = New System.Drawing.Point(12, 33)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(269, 20)
        Me.txtCommand.TabIndex = 10
        Me.txtCommand.Text = Global.RunRandom.My.MySettings.Default.command
        '
        'LabelMins1
        '
        Me.LabelMins1.AutoSize = True
        Me.LabelMins1.Location = New System.Drawing.Point(10, 82)
        Me.LabelMins1.Name = "LabelMins1"
        Me.LabelMins1.Size = New System.Drawing.Size(28, 13)
        Me.LabelMins1.TabIndex = 11
        Me.LabelMins1.Text = "mins"
        '
        'LabelMins2
        '
        Me.LabelMins2.AutoSize = True
        Me.LabelMins2.Location = New System.Drawing.Point(176, 82)
        Me.LabelMins2.Name = "LabelMins2"
        Me.LabelMins2.Size = New System.Drawing.Size(28, 13)
        Me.LabelMins2.TabIndex = 12
        Me.LabelMins2.Text = "mins"
        '
        'TextBoxRangeEnd
        '
        Me.TextBoxRangeEnd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RunRandom.My.MySettings.Default, "RangeEnd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxRangeEnd.Location = New System.Drawing.Point(179, 59)
        Me.TextBoxRangeEnd.Name = "TextBoxRangeEnd"
        Me.TextBoxRangeEnd.Size = New System.Drawing.Size(102, 20)
        Me.TextBoxRangeEnd.TabIndex = 1
        Me.TextBoxRangeEnd.Text = Global.RunRandom.My.MySettings.Default.RangeEnd
        '
        'TextBoxRangeStart
        '
        Me.TextBoxRangeStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RunRandom.My.MySettings.Default, "RangeStart", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxRangeStart.Location = New System.Drawing.Point(13, 59)
        Me.TextBoxRangeStart.Name = "TextBoxRangeStart"
        Me.TextBoxRangeStart.Size = New System.Drawing.Size(102, 20)
        Me.TextBoxRangeStart.TabIndex = 0
        Me.TextBoxRangeStart.Text = Global.RunRandom.My.MySettings.Default.RangeStart
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "RunRandom"
        Me.NotifyIcon1.Visible = True
        '
        'RandomRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 175)
        Me.Controls.Add(Me.LabelMins2)
        Me.Controls.Add(Me.LabelMins1)
        Me.Controls.Add(Me.txtCommand)
        Me.Controls.Add(Me.LabelCountdown)
        Me.Controls.Add(Me.LabelNextRunVal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonReRun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxRangeEnd)
        Me.Controls.Add(Me.TextBoxRangeStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RandomRun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RandomRun"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxRangeStart As TextBox
    Friend WithEvents TextBoxRangeEnd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonReRun As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelNextRunVal As Label
    Friend WithEvents TimerMain As Timer
    Friend WithEvents LabelCountdown As Label
    Friend WithEvents TimerCountdown As Timer
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents LabelMins1 As Label
    Friend WithEvents LabelMins2 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
