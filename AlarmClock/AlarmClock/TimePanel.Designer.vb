<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AMButton = New System.Windows.Forms.RadioButton()
        Me.PMButton = New System.Windows.Forms.RadioButton()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DigitLED4 = New AlarmClock.DigitLED()
        Me.DigitLED3 = New AlarmClock.DigitLED()
        Me.DigitLED2 = New AlarmClock.DigitLED()
        Me.DigitLED1 = New AlarmClock.DigitLED()
        Me.SuspendLayout()
        '
        'AMButton
        '
        Me.AMButton.AutoSize = True
        Me.AMButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMButton.Location = New System.Drawing.Point(213, 23)
        Me.AMButton.Name = "AMButton"
        Me.AMButton.Size = New System.Drawing.Size(46, 20)
        Me.AMButton.TabIndex = 1
        Me.AMButton.TabStop = True
        Me.AMButton.Text = "AM"
        Me.AMButton.UseVisualStyleBackColor = True
        '
        'PMButton
        '
        Me.PMButton.AutoSize = True
        Me.PMButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PMButton.Location = New System.Drawing.Point(213, 59)
        Me.PMButton.Name = "PMButton"
        Me.PMButton.Size = New System.Drawing.Size(46, 20)
        Me.PMButton.TabIndex = 2
        Me.PMButton.TabStop = True
        Me.PMButton.Text = "PM"
        Me.PMButton.UseVisualStyleBackColor = True
        '
        'SetButton
        '
        Me.SetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetButton.Location = New System.Drawing.Point(23, 94)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(87, 41)
        Me.SetButton.TabIndex = 7
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(155, 94)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(87, 41)
        Me.ResetButton.TabIndex = 12
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = ":"
        '
        'DigitLED4
        '
        Me.DigitLED4.AutoSize = True
        Me.DigitLED4.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED4.ForeColor = System.Drawing.Color.Green
        Me.DigitLED4.Location = New System.Drawing.Point(148, 27)
        Me.DigitLED4.MaxDigit = 0
        Me.DigitLED4.MinDigit = 0
        Me.DigitLED4.Name = "DigitLED4"
        Me.DigitLED4.Size = New System.Drawing.Size(33, 38)
        Me.DigitLED4.TabIndex = 21
        Me.DigitLED4.Text = "4"
        '
        'DigitLED3
        '
        Me.DigitLED3.AutoSize = True
        Me.DigitLED3.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED3.ForeColor = System.Drawing.Color.Green
        Me.DigitLED3.Location = New System.Drawing.Point(106, 27)
        Me.DigitLED3.MaxDigit = 0
        Me.DigitLED3.MinDigit = 0
        Me.DigitLED3.Name = "DigitLED3"
        Me.DigitLED3.Size = New System.Drawing.Size(33, 38)
        Me.DigitLED3.TabIndex = 20
        Me.DigitLED3.Text = "3"
        '
        'DigitLED2
        '
        Me.DigitLED2.AutoSize = True
        Me.DigitLED2.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED2.ForeColor = System.Drawing.Color.Green
        Me.DigitLED2.Location = New System.Drawing.Point(45, 27)
        Me.DigitLED2.MaxDigit = 0
        Me.DigitLED2.MinDigit = 0
        Me.DigitLED2.Name = "DigitLED2"
        Me.DigitLED2.Size = New System.Drawing.Size(33, 38)
        Me.DigitLED2.TabIndex = 19
        Me.DigitLED2.Text = "2"
        '
        'DigitLED1
        '
        Me.DigitLED1.AutoSize = True
        Me.DigitLED1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.DigitLED1.ForeColor = System.Drawing.Color.Green
        Me.DigitLED1.Location = New System.Drawing.Point(3, 27)
        Me.DigitLED1.MaxDigit = 0
        Me.DigitLED1.MinDigit = 0
        Me.DigitLED1.Name = "DigitLED1"
        Me.DigitLED1.Size = New System.Drawing.Size(33, 38)
        Me.DigitLED1.TabIndex = 18
        Me.DigitLED1.Text = "1"
        '
        'TimePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DigitLED4)
        Me.Controls.Add(Me.DigitLED3)
        Me.Controls.Add(Me.DigitLED2)
        Me.Controls.Add(Me.DigitLED1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.PMButton)
        Me.Controls.Add(Me.AMButton)
        Me.Name = "TimePanel"
        Me.Size = New System.Drawing.Size(265, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AMButton As RadioButton
    Friend WithEvents PMButton As RadioButton
    Friend WithEvents SetButton As Button
    Friend WithEvents ResetButton As Button

    Friend WithEvents Label1 As Label
    Friend WithEvents DigitLED1 As DigitLED
    Friend WithEvents DigitLED2 As DigitLED
    Friend WithEvents DigitLED3 As DigitLED
    Friend WithEvents DigitLED4 As DigitLED
End Class
