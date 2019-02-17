'Created by: Tony Shao

Public Class TimePanel
    Event ResetPressed()
    Dim ok As String = "Yes" 'Alarm Status. If its not being Set at the moment, then it can go off at the right time ("Yes") Else it cannot.("No") 
    Dim SavedTime As String 'Saved Time when setting the time. Used to return the time if user cancels.
    Dim SavedButtonState As String 'Same as above but for AM/PM.

    Public Sub New()
        InitializeComponent()
        SetTime("0000") 'Alarms are initially set to 00:00 AM. 
        AMButton.Checked = True
        DigitLED1.SetColour()
        DigitLED2.SetColour()
        DigitLED3.SetColour()
        DigitLED4.SetColour()
        Label1.Font = New Font("Comic Sans MS", 20, FontStyle.Bold)
    End Sub

    'Set a new AM/PM State.
    Public Sub SetButtonState(str As String)
        SavedButtonState = str
    End Sub

    'Gets the Status of the alarm
    Public Sub ThisSetON(str As String)
        ok = str
    End Sub

    'Sets Alarm Status.
    Public Function GetSetOn()
        If ok = "Yes" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Set Method for the Time
    Public Sub SetTime(str As String)
        DigitLED1.SetDigit(str.Substring(0, 1))
        DigitLED2.SetDigit(str.Substring(1, 1))
        DigitLED3.SetDigit(str.Substring(2, 1))
        DigitLED4.SetDigit(str.Substring(3, 1))
    End Sub

    'Get Method for the time
    Public Function GetTime()
        Dim str As String
        str = DigitLED1.GetDigit()
        str = str & DigitLED2.GetDigit()
        str = str & DigitLED3.GetDigit()
        str = str & DigitLED4.GetDigit()
        Return str
    End Function

    'Sets Digits individually.
    Public Sub RecieveDigit(digit As String, digitPos As String)
        Dim digit1 = Integer.Parse(digit)
        If digitPos = 1 Then
            DigitLED1.SetDigit(digit)
            DigitLED2.digit(digit1)
        ElseIf digitPos = 2 Then
            DigitLED2.SetDigit(digit)
        ElseIf digitPos = 3 Then
            DigitLED3.SetDigit(digit)
        ElseIf digitPos = 4 Then
            DigitLED4.SetDigit(digit)
        End If
    End Sub

    'SetButtons open keypad. 
    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        SavedTime = GetTime()
        SavedButtonState = GetAMPMStatus()
        AMButton.Checked = True
        MainForm.openKeyPad(Me)
        SetButton.Enabled = False
        ResetButton.Enabled = False
    End Sub

    'Returns in a string whether the AM or PM button is checked.
    Public Function GetAMPMStatus()
        If AMButton.Checked = True Then
            Return "AM"
        Else
            Return "PM"
        End If
    End Function

    'Reset button resets the alarm panels to 00:00AM.
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Me.SetTime("0000")
        AMButton.Checked = True
        RaiseEvent ResetPressed()
    End Sub

    'Based on the last position of the digit set, the function returns the minimum digit possible.
    Public Function keyPadMinDigit(thisDigit As Integer)
        If thisDigit = 1 Then
            DigitLED1.MinDigit = thisDigit
            Return DigitLED1.MinDigit
        ElseIf thisDigit = 2 Then
            DigitLED2.MinDigit = thisDigit
            Return DigitLED2.MinDigit
        ElseIf thisDigit = 3 Then
            DigitLED3.MinDigit = thisDigit
            Return DigitLED3.MinDigit
        ElseIf thisDigit = 4 Then
            DigitLED4.MinDigit = thisDigit
            Return DigitLED4.MinDigit
        End If
        Return 0
    End Function

    'Based on the position of the digit set, the function returns the maximum digit possible.
    Public Function keyPadMaxDigit(thisDigit As Integer)
        If thisDigit = 1 Then
            DigitLED1.MaxDigit = thisDigit
            Return DigitLED1.MaxDigit
        ElseIf thisDigit = 2 Then
            DigitLED2.MaxDigit = thisDigit
            Return DigitLED2.MaxDigit
        ElseIf thisDigit = 3 Then
            DigitLED3.MaxDigit = thisDigit
            Return DigitLED3.MaxDigit
        ElseIf thisDigit = 4 Then
            DigitLED4.MaxDigit = thisDigit
            Return DigitLED4.MaxDigit
        End If
        Return 0
    End Function

    'Cancel reverts to old time.
    Public Sub CancelSet()
        SetTime(SavedTime)
        If SavedButtonState = "AM" Then
            AMButton.Checked = True
        Else
            PMButton.Checked = True
        End If
        ButtonsEnabled()
    End Sub


    'Enables the Set & Reset Buttons.
    Public Sub ButtonsEnabled()
        SetButton.Enabled = True
        ResetButton.Enabled = True
        DigitLED2.digit(0)
    End Sub


End Class