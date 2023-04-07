Imports System
Imports System.Windows
Imports System.Windows.Controls
Class PageMyVed
    Sub Auto_run() Handles Me.Loaded
        Dim anim As Animation.DoubleAnimation = New Animation.DoubleAnimation
        Dim animOp As Animation.DoubleAnimation = New Animation.DoubleAnimation
        animOp.From = 0
        animOp.To = 1
        animOp.Duration = TimeSpan.FromSeconds(0.5)
        anim.From = 0
        anim.To = 60
        anim.Duration = TimeSpan.FromSeconds(0.5)
        ButtonPanelOc1.BeginAnimation(OpacityProperty, animOp)
        ButtonPanelOc1.BeginAnimation(HeightProperty, anim)
        ButtonPanelOc2.BeginAnimation(OpacityProperty, animOp)
        ButtonPanelOc2.BeginAnimation(HeightProperty, anim)
        ButtonPanelOc3.BeginAnimation(OpacityProperty, animOp)
        ButtonPanelOc3.BeginAnimation(HeightProperty, anim)
        ButtonPanelOc4.BeginAnimation(OpacityProperty, animOp)
        ButtonPanelOc4.BeginAnimation(HeightProperty, anim)
        ButtonPanelOc5.BeginAnimation(OpacityProperty, animOp)
        ButtonPanelOc5.BeginAnimation(HeightProperty, anim)
    End Sub
End Class
