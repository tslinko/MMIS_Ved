Class PageOption
    Sub PasC()
        If TB2.Password.Length = 0 Then
            TBP.Visibility = Visibility.Visible
        Else
            TBP.Visibility = Visibility.Collapsed
        End If
    End Sub
    Sub Auto_run() Handles Me.Loaded
        Dim animOp As Animation.DoubleAnimation = New Animation.DoubleAnimation
        animOp.From = 0
        animOp.To = 1
        animOp.Duration = TimeSpan.FromSeconds(0.5)
        MenuLog.BeginAnimation(OpacityProperty, animOp)
        PasC()
    End Sub
End Class
