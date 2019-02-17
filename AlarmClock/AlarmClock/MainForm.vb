'Created by: Tony Shao

Public Class MainForm
    Dim digitPos As Integer = 1 'Current Digit Position when setting the clock.
    Dim buttonArray = New Button()
    Dim tp As TimePanel
    Dim ongoing As String 'The stored time, that continues changing even while setting time.
    Dim ongoingM As String 'AM/PM status of Clock
    Dim SetMode As Integer = 0 'If user is setting a time, it is 1. Else it is 0.
    Dim counter As Integer 'Counter for clock time; increases by 1 per second.

    'Application starts with clock panel displayed, key pad hidden, and checkboxes unchecked
    Public Sub New()
        InitializeComponent()
        TimePanel1.SetTime(GetSystemTime()) 'Initial Time in the time display is the computer time.
        ongoing = TimePanel1.GetTime()
        ongoingM = TimePanel1.GetAMPMStatus()
        CloseKeyPad()
        Timer1.Interval = 1000
        Timer1.Start()
        tp = TimePanel1
        okButton.Enabled = False
        SetMode = 0
        'Digit keys are in an array.
        buttonArray = {Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}

        AlarmPanel1.PictureBox1.Image = My.Resources.Bee
        AlarmPanel2.PictureBox1.Image = My.Resources.Earth
        AlarmPanel3.PictureBox1.Image = My.Resources.Present
    End Sub


    'Handles the timer. Clock Time is updated every Minute. Clock keeps time (even when being set)
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        If SetMode = 0 Then
            ongoingM = TimePanel1.GetAMPMStatus()
        End If
        If counter = 60 Then
            TimeMath()
            counter = 0

            If SetMode = 0 Then
                ongoingM = TimePanel1.GetAMPMStatus()
            End If

            CheckAlarm()
            End If

    End Sub


    'Finds out what digit changes after a minute using min/max digitLED properties and current digit position.
    Private Sub TimeMath()
        Dim clockTime As String = ongoing
        Dim cDigit As Integer = 0
        cDigit = Integer.Parse(clockTime.Substring(3, 1))
        If cDigit < TimePanel1.keyPadMaxDigit(4) Then
            cDigit = cDigit + 1
            AddTime(clockTime.Substring(0, 3) & cDigit.ToString)
        ElseIf Integer.Parse(clockTime.Substring(2, 1)) < TimePanel1.keyPadMaxDigit(3) Then
            cDigit = Integer.Parse(clockTime.Substring(2, 1))
            cDigit = cDigit + 1
            AddTime(clockTime.Substring(0, 2) & cDigit.ToString & "0")
        ElseIf clockTime = "1259" Then
            AddTime("0100")
        ElseIf Integer.Parse(clockTime.Substring(1, 1)) < TimePanel1.keyPadMaxDigit(2) Then
            cDigit = Integer.Parse(clockTime.Substring(1, 1))
            cDigit = cDigit + 1
            AddTime(clockTime.Substring(0, 1) & cDigit.ToString & "00")
        ElseIf Integer.Parse(clockTime.Substring(0, 1)) < TimePanel1.keyPadMaxDigit(1) Then
            cDigit = Integer.Parse(clockTime.Substring(0, 1))
            cDigit = cDigit + 1
            AddTime(cDigit.ToString & "000")
        End If
        If TimePanel1.GetTime = "1200" Then
            If SetMode = 0 Then
                If TimePanel1.GetAMPMStatus = "AM" Then
                    TimePanel1.PMButton.Checked = True
                    TimePanel1.SetButtonState("PM")
                Else
                    TimePanel1.AMButton.Checked = True
                    TimePanel1.SetButtonState("AM")
                End If
            End If
        End If

    End Sub

    'Sets the time from minute changing.
    Private Sub AddTime(str As String)
        If SetMode = 0 Then
            TimePanel1.SetTime(str)
        End If
        If str = "1200" Then
            If ongoingM = "AM" Then
                ongoingM = "PM"
                TimePanel1.SetButtonState("PM")
            Else
                ongoingM = "AM"
                TimePanel1.SetButtonState("AM")
            End If
        End If

        ongoing = str
    End Sub

    Public Function GetOngoing()
        Return ongoing
    End Function

    'Checks the alarms for 1) If they are on, 2) If it is the correct time, every minute, 3) If that Alarm is being set at the moment, 4)If the AM/PM Status is Correct.
    'Alarms which are turned On go off at right time.
    Private Sub CheckAlarm()
        Dim Times1 = AlarmPanel1.CompareAlarm()
        Dim Times2 = AlarmPanel2.CompareAlarm()
        Dim Times3 = AlarmPanel3.CompareAlarm()
        If Alarm1CB.Checked = True And Times1.GetTime = ongoing And Times1.GetSetON = True And Times1.GetAMPMStatus = ongoingM Then
            TabControl1.SelectedTab = TabPage1
            AlarmPanel1.AlarmFunction()
        ElseIf Alarm2CB.Checked = True And Times2.GetTime = ongoing And Times2.GetSetON = True And Times2.GetAMPMStatus = ongoingM Then
            TabControl1.SelectedTab = TabPage2
            AlarmPanel2.AlarmFunction()
        ElseIf Alarm3CB.Checked = True And Times3.GetTime = ongoing And Times3.GetSetON = True And Times3.GetAMPMStatus = ongoingM Then
            TabControl1.SelectedTab = TabPage3
            AlarmPanel3.AlarmFunction()
        End If
    End Sub

    'Digit keys are handled by a single handler. OK key selection appropriately enabled. Pressing keys enters new time in correct TimePanel.
    Private Sub DigitButton_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button0.Click
        Dim bPressed As Button = DirectCast(sender, Button)
        tp.RecieveDigit(bPressed.Text, digitPos)
        digitPos += 1
        If digitPos = 5 Then
            okButton.Enabled = True
            DeactivateKeyPad()
        End If
        If digitPos < 5 Then
            DeactivateKeyPad()
            ActivateKeyPad()
        End If
    End Sub

    'Opens keypad.
    Public Sub openKeyPad(ref As Object)
        tp = ref
        If ref Is TimePanel1 Then
            SetMode = 1
        Else
            tp.ThisSetON("No")
        End If
        ongoing = TimePanel1.GetTime()
        DisableTimePanels(ref)
        keyPad.Visible = True
        Me.Height = 700
        tp.SetTime("0000")
        DeactivateKeyPad()
        ActivateKeyPad()
    End Sub

    'Closes KeyPad. OK key selection appropriately disabled. Saves the new time.
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        okButton.Enabled = False
        tp.ThisSetON("Yes")
        digitPos = 1
        CloseKeyPad()
        tp.ButtonsEnabled()
        SetMode = 0
        ongoing = TimePanel1.GetTime
    End Sub

    'Sets the clock time back to computer time, overrides the timepanel reset button.
    Public Sub ResetButton() Handles TimePanel1.ResetPressed
        TimePanel1.SetTime(GetSystemTime())
        counter = 0
        ongoing = GetSystemTime()
    End Sub

    'Closes KeyPad & Tells TimePanel to revert to old time
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        CloseKeyPad()
        tp.ThisSetON("Yes")
        tp.CancelSet()
        TimePanel1.SetTime(ongoing)
        TimePanel1.SetButtonState(ongoingM)
        SetMode = 0
    End Sub

    'Sets the clock time initially to computer time.
    Public Function GetSystemTime()
        Dim ThisMoment As Date
        ThisMoment = Now
        Dim ctime As String
        ctime = DateTime.Now.ToString("hhmmtt")
        If ctime.Substring(4, 2) = "AM" Then
            TimePanel1.AMButton.Checked = True
        ElseIf ctime.Substring(4, 2) = "PM" Then
            TimePanel1.PMButton.Checked = True
        End If
        Return (ctime.Substring(0, 1) + ctime.Substring(1, 1) + ctime.Substring(2, 1) + ctime.Substring(3, 1))
    End Function

    'Closes the keypad. OK key selection appropriately disabled.
    Private Sub CloseKeyPad()
        keyPad.Visible = False
        okButton.Enabled = False
        Me.Height = 350
        digitPos = 1
        ActivateTimePanels()
        Timer1.Start()
    End Sub

    'Checkboxes in clockpanel synchronized with checkboxes in individual alarm panels
    Private Sub UpdateCheckBox(sender As Object) Handles AlarmPanel1.AlarmSwitched, AlarmPanel2.AlarmSwitched, AlarmPanel3.AlarmSwitched
        If sender Is AlarmPanel1 Then
            If Alarm1CB.Checked = False Then
                Alarm1CB.Checked = True
            Else
                Alarm1CB.Checked = False
            End If
        ElseIf sender Is AlarmPanel2 Then
            If Alarm2CB.Checked = False Then
                Alarm2CB.Checked = True
            Else
                Alarm2CB.Checked = False
            End If
        ElseIf sender Is AlarmPanel3 Then
            If Alarm3CB.Checked = False Then
                Alarm3CB.Checked = True
            Else
                Alarm3CB.Checked = False
            End If
        End If
    End Sub


    'Digit keys are appropriately enabled 
    Public Sub ActivateKeyPad()
        For index As Integer = tp.keyPadMinDigit(digitPos) To tp.keyPadMaxDigit(digitPos)
            buttonArray(index).enabled = True
        Next
    End Sub

    'Digit keys are appropriately disabled
    Public Sub DeactivateKeyPad()
        For index As Integer = 0 To buttonArray.length - 1
            buttonArray(index).enabled = False
        Next
    End Sub

    'Activates all timepanels after setting time or cancel.
    Private Sub ActivateTimePanels()
        ClockTab.Enabled = True
        AlarmPanel1.Enabled = True
        AlarmPanel2.Enabled = True
        AlarmPanel3.Enabled = True
    End Sub

    'Disables the other timepanels when either the clockpanel or an alarmpanel is being set.
    Public Sub DisableTimePanels(ref As Object)
        ClockTab.Enabled = False
        AlarmPanel1.Enabled = False
        AlarmPanel2.Enabled = False
        AlarmPanel3.Enabled = False
        If TabControl1.SelectedTab Is ClockTab Then
            ClockTab.Enabled = True
        ElseIf TabControl1.SelectedTab Is TabPage1 Then
            AlarmPanel1.Enabled = True
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            AlarmPanel2.Enabled = True
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            AlarmPanel3.Enabled = True
        End If
    End Sub

    'Checkboxes in alarmpanels synchronized with checkboxes in clockpanel
    Private Sub AlarmCBClicked(sender As Object, e As EventArgs) Handles Alarm1CB.CheckedChanged, Alarm2CB.CheckedChanged, Alarm3CB.CheckedChanged
        If sender Is Alarm1CB Then
            AlarmPanel1.Update_CheckBox()
        ElseIf sender Is Alarm2CB Then
            AlarmPanel2.Update_CheckBox()
        ElseIf sender Is Alarm3CB Then
            AlarmPanel3.Update_CheckBox()
        End If
    End Sub

End Class
