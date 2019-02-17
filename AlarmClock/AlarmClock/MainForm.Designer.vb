<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.keyPad = New System.Windows.Forms.Panel()
        Me.okButton = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AlarmPanel3 = New AlarmClock.AlarmPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AlarmPanel2 = New AlarmClock.AlarmPanel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AlarmPanel1 = New AlarmClock.AlarmPanel()
        Me.ClockTab = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimePanel1 = New AlarmClock.TimePanel()
        Me.Alarm3CB = New System.Windows.Forms.CheckBox()
        Me.Alarm2CB = New System.Windows.Forms.CheckBox()
        Me.Alarm1CB = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.keyPad.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ClockTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'keyPad
        '
        Me.keyPad.Controls.Add(Me.okButton)
        Me.keyPad.Controls.Add(Me.Button0)
        Me.keyPad.Controls.Add(Me.cancelButton)
        Me.keyPad.Controls.Add(Me.Button9)
        Me.keyPad.Controls.Add(Me.Button8)
        Me.keyPad.Controls.Add(Me.Button7)
        Me.keyPad.Controls.Add(Me.Button6)
        Me.keyPad.Controls.Add(Me.Button5)
        Me.keyPad.Controls.Add(Me.Button4)
        Me.keyPad.Controls.Add(Me.Button3)
        Me.keyPad.Controls.Add(Me.Button2)
        Me.keyPad.Controls.Add(Me.Button1)
        Me.keyPad.Location = New System.Drawing.Point(22, 320)
        Me.keyPad.Name = "keyPad"
        Me.keyPad.Size = New System.Drawing.Size(300, 325)
        Me.keyPad.TabIndex = 8
        '
        'okButton
        '
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(205, 231)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(83, 70)
        Me.okButton.TabIndex = 12
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(103, 231)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(83, 70)
        Me.Button0.TabIndex = 11
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(3, 231)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(83, 70)
        Me.cancelButton.TabIndex = 10
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(205, 155)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(83, 70)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(103, 155)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 70)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 155)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(83, 70)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(205, 79)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 70)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(103, 79)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 70)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 70)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(205, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 70)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(103, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AlarmPanel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(317, 274)
        Me.TabPage3.TabIndex = 11
        Me.TabPage3.Text = "Alarm 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AlarmPanel3
        '
        Me.AlarmPanel3.Location = New System.Drawing.Point(8, 0)
        Me.AlarmPanel3.Name = "AlarmPanel3"
        Me.AlarmPanel3.Size = New System.Drawing.Size(310, 275)
        Me.AlarmPanel3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AlarmPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(317, 274)
        Me.TabPage2.TabIndex = 10
        Me.TabPage2.Text = "Alarm 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AlarmPanel2
        '
        Me.AlarmPanel2.Location = New System.Drawing.Point(8, 0)
        Me.AlarmPanel2.Name = "AlarmPanel2"
        Me.AlarmPanel2.Size = New System.Drawing.Size(310, 275)
        Me.AlarmPanel2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AlarmPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(317, 274)
        Me.TabPage1.TabIndex = 9
        Me.TabPage1.Text = "Alarm 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AlarmPanel1
        '
        Me.AlarmPanel1.Location = New System.Drawing.Point(8, 0)
        Me.AlarmPanel1.Name = "AlarmPanel1"
        Me.AlarmPanel1.Size = New System.Drawing.Size(325, 300)
        Me.AlarmPanel1.TabIndex = 0
        '
        'ClockTab
        '
        Me.ClockTab.Controls.Add(Me.PictureBox1)
        Me.ClockTab.Controls.Add(Me.TimePanel1)
        Me.ClockTab.Controls.Add(Me.Alarm3CB)
        Me.ClockTab.Controls.Add(Me.Alarm2CB)
        Me.ClockTab.Controls.Add(Me.Alarm1CB)
        Me.ClockTab.Location = New System.Drawing.Point(4, 22)
        Me.ClockTab.Name = "ClockTab"
        Me.ClockTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ClockTab.Size = New System.Drawing.Size(317, 274)
        Me.ClockTab.TabIndex = 5
        Me.ClockTab.Text = "Clock"
        Me.ClockTab.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 85)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TimePanel1
        '
        Me.TimePanel1.Location = New System.Drawing.Point(28, 0)
        Me.TimePanel1.Name = "TimePanel1"
        Me.TimePanel1.Size = New System.Drawing.Size(303, 150)
        Me.TimePanel1.TabIndex = 5
        '
        'Alarm3CB
        '
        Me.Alarm3CB.AutoSize = True
        Me.Alarm3CB.Location = New System.Drawing.Point(218, 232)
        Me.Alarm3CB.Name = "Alarm3CB"
        Me.Alarm3CB.Size = New System.Drawing.Size(61, 17)
        Me.Alarm3CB.TabIndex = 4
        Me.Alarm3CB.Text = "Alarm 3"
        Me.Alarm3CB.UseVisualStyleBackColor = True
        '
        'Alarm2CB
        '
        Me.Alarm2CB.AutoSize = True
        Me.Alarm2CB.Location = New System.Drawing.Point(218, 200)
        Me.Alarm2CB.Name = "Alarm2CB"
        Me.Alarm2CB.Size = New System.Drawing.Size(61, 17)
        Me.Alarm2CB.TabIndex = 3
        Me.Alarm2CB.Text = "Alarm 2"
        Me.Alarm2CB.UseVisualStyleBackColor = True
        '
        'Alarm1CB
        '
        Me.Alarm1CB.AutoSize = True
        Me.Alarm1CB.Location = New System.Drawing.Point(218, 168)
        Me.Alarm1CB.Name = "Alarm1CB"
        Me.Alarm1CB.Size = New System.Drawing.Size(61, 17)
        Me.Alarm1CB.TabIndex = 2
        Me.Alarm1CB.Text = "Alarm 1"
        Me.Alarm1CB.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ClockTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(325, 300)
        Me.TabControl1.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 662)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.keyPad)
        Me.Name = "MainForm"
        Me.Text = "Tony Shao's Alarm Clock"
        Me.keyPad.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ClockTab.ResumeLayout(False)
        Me.ClockTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents keyPad As Panel
    Friend WithEvents okButton As Button
    Friend WithEvents Button0 As Button
    Shadows WithEvents cancelButton As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents AlarmPanel3 As AlarmPanel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AlarmPanel2 As AlarmPanel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AlarmPanel1 As AlarmPanel
    Friend WithEvents ClockTab As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Alarm3CB As CheckBox
    Friend WithEvents Alarm2CB As CheckBox
    Friend WithEvents Alarm1CB As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TimePanel1 As TimePanel
End Class
