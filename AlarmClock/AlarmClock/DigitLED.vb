'Created by: Tony Shao

Public Class DigitLED
    Inherits Label 'Digit inherits Label
    Private num As Integer = 0 'The Min/Max value possible for digit X.
    Public prior As Integer 'The previous value of the previous digit.

    Public Sub digit(digit1 As Integer)
        prior = digit1
    End Sub

    'Has a MinDigit Property where minimum digit is stored.
    Public Property MinDigit As Integer
        Get
            Return num
        End Get
        Set(thisDigit As Integer)
            If thisDigit = 1 Then
                num = 0
            ElseIf thisDigit = 2 Then
                If prior = 0 Then
                    num = 1
                Else
                    num = 0
                End If
            Else
                num = 0
            End If
        End Set
    End Property

    'Has a MaxDigit Property where maximum digit is stored.
    Public Property MaxDigit As Integer
        Get
            Return num
        End Get
        Set(thisDigit As Integer)
            If thisDigit = 1 Then
                num = 1
            ElseIf thisDigit = 2 Then
                If prior = 0 Then
                    num = 9
                Else
                    num = 2
                End If
            ElseIf thisDigit = 3 Then
                num = 5
            ElseIf thisDigit Then
                num = 9
            End If
        End Set
    End Property

    'The font and size are fixed in the control.
    Public Sub SetColour()
        Me.ForeColor = Color.Black
        Me.Font = New Drawing.Font("Comic Sans MS",
                               20,
                               FontStyle.Bold)
    End Sub

    'Set Method for the Digit
    Public Sub SetDigit(digit As String)
        Me.Text = digit
    End Sub

    'Get Method for the Digit
    Public Function GetDigit() As String
        Return Me.Text
    End Function

End Class
