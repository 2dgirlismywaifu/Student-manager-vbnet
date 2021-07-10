Public NotInheritable Class SplashScreen

    Private iProgressBarValue As Integer = 0
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'Application title

        ApplicationTitle.Text = "QUẢN LÝ" & vbNewLine & "Học sinh THPT"

        Version.Text = System.String.Format(Version.Text,
                                            My.Application.Info.Version.Major,
                                            My.Application.Info.Version.Minor)
        Version.Text &= Space(1) & "Loading..."
        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        Copyright.Text &= vbNewLine & "GROUP 4"

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000
        ProgressBar1.Value = 0

        Timer1.Enabled = True
        Timer1.Interval = 600
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        iProgressBarValue += 1
        Select Case iProgressBarValue
            Case 1, 3, 5, 7, 9
                ProgressBar1.ForeColor = Color.White
                ProgressBar1.Value = (iProgressBarValue * 100)
            Case 2, 4, 6, 8, 10
                ProgressBar1.Value = (iProgressBarValue * 100)
            Case 13
                Timer1.Stop()
                Timer1.Enabled = False
                THPT.Show()
                Me.Close()
        End Select

    End Sub
End Class
