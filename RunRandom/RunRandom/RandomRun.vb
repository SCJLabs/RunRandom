

Public Class RandomRun

    Dim firstRun = True

    Dim countdownSeconds = 30

    Private Label11 As Object

    Private Sub ButtonReRun_Click(sender As Object, e As EventArgs) Handles ButtonReRun.Click
        RunTask()
    End Sub

    Public Sub RunTask()

        My.Settings.Save()

        'First stop the timer so we can restart it later
        TimerMain.Stop()

        'Then run the task immediately
        Try
            If firstRun = False Then                    ' do not run the task immediately after the app starts
                Process.Start(txtCommand.Text)
            Else
                firstRun = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Then determine next time task will be run randomly from the given range
        Dim random As New Random()
        Dim RangeStart = My.Settings.RangeStart
        Dim RangeEnd = My.Settings.RangeEnd
        Dim chosenInt = random.Next(RangeStart, RangeEnd)
        countdownSeconds = chosenInt

        'Update the timer's new interval
        TimerMain.Interval = 1000 * chosenInt

        'Start the timer
        TimerMain.Start()

        'Update labels
        LabelNextRunVal.Text = Now.AddSeconds(chosenInt) & " (+" & chosenInt & " seconds)"
        ButtonReRun.Text = "Re-Run Now"

        'Restart countdown timer
        TimerCountdown.Stop()
        TimerCountdown.Start()
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        RunTask()
    End Sub

    Private Sub TimerCountdown_Tick(sender As Object, e As EventArgs) Handles TimerCountdown.Tick
        countdownSeconds -= 1
        LabelCountdown.Text = countdownSeconds & " seconds"
    End Sub

    Private Sub RandomRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        TimerMain.Start()
        RunTask()
        TimerCountdown.Start()
        updateMins()

    End Sub

    Private Sub TextBoxRangeStart_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRangeStart.TextChanged
        updateMins()
    End Sub

    Private Sub TextBoxRangeEnd_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRangeEnd.TextChanged
        updateMins()
    End Sub

    Public Sub updateMins()
        Try
            LabelMins1.Text = Math.Round(TextBoxRangeStart.Text / 60, 2) & " mins"
            LabelMins2.Text = Math.Round(TextBoxRangeEnd.Text / 60, 2) & " mins"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
        End If
    End Sub
End Class
