Public Class addBaglog
    Private Sub MelihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Hide()
        readData.Show()
    End Sub
    Public Sub mengulang()
        ControlBaglog1.getView()
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Hide()
        MainForm.Show()
    End Sub

    Private Sub pilihPort_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub
    Public Sub SetPortStatus()
        port.Text = Form1.comName
    End Sub
    Private Sub addBaglog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ControlBaglog1.getView()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            ControlBaglog1.getView()
            'Dim sound As New Sound([Assembly].GetExecutingAssembly().GetManifestResourceStream("SoundSample.chimes.wav"))
            'sound.Play()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub inputBtn_Click(sender As Object, e As EventArgs) Handles inputBtn.Click
        Hide()
        MainForm.Show()
        MainForm.mengulang()
    End Sub

    Private Sub kelolaBagBtn_Click(sender As Object, e As EventArgs) Handles kelolaBagBtn.Click

    End Sub

    Private Sub kelolaBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pilihPortBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub keluarBtn_Click(sender As Object, e As EventArgs) Handles keluarBtn.Click
        Application.Exit()
    End Sub

    Private Sub lihatBtn_Click(sender As Object, e As EventArgs) Handles lihatBtn.Click
        readData.Show()
        readData.mengulang()
        Hide()
    End Sub

    Private Sub pilihPortBtn_Click_1(sender As Object, e As EventArgs) Handles pilihPortBtn.Click
        Form1.Show()
        Form1.GetSerialPortNames()

        Hide()
    End Sub

    Private Sub ControlBaglog1_Load(sender As Object, e As EventArgs) Handles ControlBaglog1.Load

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class