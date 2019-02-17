'Created by: Tony Shao

Module SoundEffects
    Sub PlaySoundEffect(Sound As String)
        If Sound = "Bird" Then
            My.Computer.Audio.Play(My.Resources.bird,
                AudioPlayMode.Background)
        ElseIf Sound = "Boat Horn" Then
            My.Computer.Audio.Play(My.Resources.boat_horn,
               AudioPlayMode.Background)
        ElseIf Sound = "Cow" Then
            My.Computer.Audio.Play(My.Resources.cow,
               AudioPlayMode.Background)
        ElseIf Sound = "Crickets" Then
            My.Computer.Audio.Play(My.Resources.crickets,
               AudioPlayMode.Background)
        ElseIf Sound = "Drum Roll" Then
            My.Computer.Audio.Play(My.Resources.drum_roll,
               AudioPlayMode.Background)
        ElseIf Sound = "Fanfare" Then
            My.Computer.Audio.Play(My.Resources.fanfare,
               AudioPlayMode.Background)
        ElseIf Sound = "Train" Then
            My.Computer.Audio.Play(My.Resources.train,
               AudioPlayMode.Background)
        End If

    End Sub

    Sub StopSoundEffect()
        My.Computer.Audio.Stop()
    End Sub
End Module
