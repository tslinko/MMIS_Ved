Imports System
Imports System.Windows
Imports System.Windows.Controls
Class MainWindow
    Dim statHam As Boolean = False
    Dim MH As Integer = 0
    Dim SaveH As Integer = 0
    Dim SaveW As Integer = 0
    Dim HambStop As Boolean = False
    Sub Drag(sender As Object, e As RoutedEventArgs)
        If Mouse.LeftButton = MouseButtonState.Pressed Then
            W.DragMove()
        End If
    End Sub
    Sub BorderColic(sender As Object, e As MouseButtonEventArgs)
        If e.ClickCount = 2 Then
            ReturnSize()
        End If
    End Sub
    Sub GridHame(sender As Object, e As EventArgs) Handles HamGrid.MouseEnter
        If statHam = False Then
            HamChan(1)
        End If
    End Sub
    Sub ReturnSize()
        If W.WindowState = WindowState.Maximized Then
            W.WindowState = WindowState.Normal
        Else
            W.WindowState = WindowState.Maximized
        End If
    End Sub
    Sub CollapseWindow()
        W.WindowState = WindowState.Minimized
    End Sub
    Sub GridHaml(sender As Object, e As EventArgs) Handles HamGrid.MouseLeave
        If statHam = False Then
            HamChan(0)
        End If
    End Sub
    Sub close_button()
        Me.Close()
    End Sub
    Sub HumChanE()
        statHam = Not statHam
        HamChan()
    End Sub
    Sub StopHamburger()
        HambStop = False
        Text1.Visibility = Visibility.Visible
        Text2.Visibility = Visibility.Visible
        Text3.Visibility = Visibility.Visible
        Text4.Visibility = Visibility.Visible
        Text5.Visibility = Visibility.Visible
        Text6.Visibility = Visibility.Visible
        Text7.Visibility = Visibility.Visible
        Text8.Visibility = Visibility.Visible
        Text9.Visibility = Visibility.Visible
    End Sub
    Dim hamA As Animation.DoubleAnimation = New Animation.DoubleAnimation
    Sub HamChan(Optional MouseUse As Integer = -1)
        If statHam = True Then
            Exit Sub
        End If
        Dim StopH As Integer = 270
        If HambStop = True Then
            StopH = HamGrid.Width
        End If
        Dim b As Boolean
        If MouseUse > -1 Then
            If MouseUse = 0 Then
                b = False
            Else
                b = True
            End If
        Else
            b = statHam
        End If
        If b Then
            hamA.From = 60
            hamA.To = StopH
        Else
            hamA.From = StopH
            hamA.To = 60
        End If
        Text1.Visibility = Visibility.Hidden
        Text2.Visibility = Visibility.Hidden
        Text3.Visibility = Visibility.Hidden
        Text4.Visibility = Visibility.Hidden
        Text5.Visibility = Visibility.Hidden
        Text6.Visibility = Visibility.Hidden
        Text7.Visibility = Visibility.Hidden
        Text8.Visibility = Visibility.Hidden
        Text9.Visibility = Visibility.Hidden
        hamA.Duration = TimeSpan.FromSeconds(0.2)
        Hamburger.BeginAnimation(WidthProperty, hamA)
        HamGrid.BeginAnimation(WidthProperty, hamA)
        HambStop = True
    End Sub
    Sub OpenOption()
        WindowFrame.Content = New PageOption
    End Sub
    Sub Open_PageMyVed()
        WindowFrame.Content = New PageMyVed
    End Sub
    Sub Open_PageMyDiagramm()
        WindowFrame.Content = ""
    End Sub
    Sub Main(sender As Object, e As EventArgs) Handles Me.Loaded
        W.MaxHeight = SystemParameters.PrimaryScreenHeight
        W.MinWidth = 1024
        W.MinHeight = 768
        RenderOptions.ProcessRenderMode = Interop.RenderMode.SoftwareOnly
        RenderOptions.SetBitmapScalingMode(Me, BitmapScalingMode.NearestNeighbor)
        SnapsToDevicePixels = False
        MediaTimeline.DesiredFrameRateProperty.OverrideMetadata(GetType(MediaTimeline), New FrameworkPropertyMetadata(defaultValue:=5))
        W.WindowState = WindowState.Maximized
        AddHandler hamA.Completed, AddressOf StopHamburger

    End Sub
End Class
