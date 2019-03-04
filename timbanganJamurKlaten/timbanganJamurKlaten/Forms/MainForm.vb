Public Class MainForm



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputData1.getView()
        InputData1.aturTanggal()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    '' Shourtcut CTRL + S
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            InputData1.getView()
            'Dim sound As New Sound([Assembly].GetExecutingAssembly().GetManifestResourceStream("SoundSample.chimes.wav"))
            'sound.Play()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub InputData1_Load(sender As Object, e As EventArgs) Handles InputData1.Load
        InputData1.PilihPort()
    End Sub

    Private Sub MelihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        InputData1.getView()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pilihPortBtn_Click(sender As Object, e As EventArgs) Handles pilihPortBtn.Click
        Form1.Show()
        Form1.GetSerialPortNames()
        Me.Hide()
    End Sub

    Private Sub kelolaBagBtn_Click(sender As Object, e As EventArgs) Handles kelolaBagBtn.Click
        Hide()
        addBaglog.Show()
        addBaglog.mengulang()
    End Sub

    Private Sub lihatBtn_Click(sender As Object, e As EventArgs) Handles lihatBtn.Click
        Hide()
        readData.mengulang()

        readData.Show()
    End Sub

    Private Sub keluarBtn_Click(sender As Object, e As EventArgs) Handles keluarBtn.Click
        Application.Exit()
    End Sub

    Private Sub lihatBtn_Click_1(sender As Object, e As EventArgs)

    End Sub

    Public Sub SetPortStatus()
        port.Text = Form1.comName
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
    Public Sub mengulang()
        InputData1.getView()
    End Sub
End Class