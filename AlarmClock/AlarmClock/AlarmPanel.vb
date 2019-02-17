'Created by: Tony Shao

Public Class AlarmPanel
    Event AlarmSwitched(smth As Object)
    Private WithEvents A1 As MainForm

    Public Sub New()
        InitializeComponent()
        SoundListBox.Items.Add("Bird")
        SoundListBox.Items.Add("Boat Horn")
        SoundListBox.Items.Add("Cow")
        SoundListBox.Items.Add("Crickets")
        SoundListBox.Items.Add("Drum Roll")
        SoundListBox.Items.Add("Fanfare")
        SoundListBox.Items.Add("Train")
        PictureBox1.Enabled = False
        SoundListBox.SelectedIndex = 0
    End Sub

    Private Sub AlarmBox_CheckedChanged(sender As Object, e As EventArgs) Handles AlarmBox.Click
        If AlarmBox.Checked = False Then
            AlarmBox.Checked = True
        Else
            AlarmBox.Checked = False
        End If
        RaiseEvent AlarmSwitched(Me)
    End Sub


    Public Sub Update_CheckBox()
        If AlarmBox.Checked = False Then
            AlarmBox.Checked = True
        Else
            AlarmBox.Checked = False
        End If
    End Sub

    Public Function CompareAlarm()
        Return TimePanel1
    End Function

    'Alarm sets off selected sound effect and animation.
    Public Sub AlarmFunction()
        PictureBox1.Enabled = True
        PlaySoundEffect(SoundListBox.SelectedItem.ToString)
    End Sub

    'Pressing animation button turns off sound effect and animation.
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Enabled = False
        StopSoundEffect()
    End Sub

    'Helps to make the PictureBox function like a button.
    Private Sub PictureBox1_Hover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    'Helps to make the PictureBox function like a button.
    Private Sub PictureBox1_Leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BorderStyle = False
    End Sub


End Class
