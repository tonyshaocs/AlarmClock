<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlarmPanel
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
        Me.AlarmBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SoundListBox = New System.Windows.Forms.ListBox()
        Me.TimePanel1 = New AlarmClock.TimePanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlarmBox
        '
        Me.AlarmBox.AutoSize = True
        Me.AlarmBox.Location = New System.Drawing.Point(186, 245)
        Me.AlarmBox.Name = "AlarmBox"
        Me.AlarmBox.Size = New System.Drawing.Size(71, 17)
        Me.AlarmBox.TabIndex = 0
        Me.AlarmBox.Text = "Alarm ON"
        Me.AlarmBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(35, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 92)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SoundListBox
        '
        Me.SoundListBox.FormattingEnabled = True
        Me.SoundListBox.Location = New System.Drawing.Point(173, 157)
        Me.SoundListBox.Name = "SoundListBox"
        Me.SoundListBox.Size = New System.Drawing.Size(110, 82)
        Me.SoundListBox.TabIndex = 3
        '
        'TimePanel1
        '
        Me.TimePanel1.Location = New System.Drawing.Point(20, 0)
        Me.TimePanel1.Name = "TimePanel1"
        Me.TimePanel1.Size = New System.Drawing.Size(263, 150)
        Me.TimePanel1.TabIndex = 1
        '
        'AlarmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SoundListBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TimePanel1)
        Me.Controls.Add(Me.AlarmBox)
        Me.Name = "AlarmPanel"
        Me.Size = New System.Drawing.Size(310, 275)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlarmBox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SoundListBox As ListBox
    Friend WithEvents TimePanel1 As TimePanel
End Class
