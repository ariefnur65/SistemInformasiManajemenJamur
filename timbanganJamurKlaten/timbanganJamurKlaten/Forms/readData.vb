Public Class readData
    Public Sub SetPortStatus()
        port.Text = Form1.comName
    End Sub

    Private Sub MemasukanDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Hide()
        MainForm.Show()

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub MelihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Hide()
        MainForm.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Hide()
        addBaglog.Show()
    End Sub

    Private Sub OutputData1_Load(sender As Object, e As EventArgs) Handles OutputData1.Load

    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            OutputData1.getView()
            'Dim sound As New Sound([Assembly].GetExecutingAssembly().GetManifestResourceStream("SoundSample.chimes.wav"))
            'sound.Play()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub lihatBtn_Click(sender As Object, e As EventArgs) Handles lihatBtn.Click

    End Sub

    Private Sub inputBtn_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        MainForm.Show()
        MainForm.mengulang()

    End Sub

    Private Sub kelolaBagBtn_Click(sender As Object, e As EventArgs) Handles kelolaBagBtn.Click
        addBaglog.Show()
        addBaglog.mengulang()
        Me.Hide()
    End Sub

    Private Sub pilihPortBtn_Click(sender As Object, e As EventArgs) Handles pilihPortBtn.Click
        Form1.Show()
        Form1.GetSerialPortNames()
        Me.Hide()
    End Sub

    Private Sub keluarBtn_Click(sender As Object, e As EventArgs) Handles keluarBtn.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub kelolaBtn_Click(sender As Object, e As EventArgs)
        addBaglog.Show()
        Me.Hide()
    End Sub

    Private Sub kelolaBagBtn_Click_1(sender As Object, e As EventArgs)
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub pilihPortBtn_Click_1(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub keluarBtn_Click_1(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Sub mengulang()
        OutputData1.getView()
    End Sub
End Class