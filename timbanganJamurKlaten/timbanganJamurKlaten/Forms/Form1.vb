Imports MySql.Data.MySqlClient

Public Class Form1
    Public comName As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles pilih.Click
        comName = portlist.SelectedItem
        MainForm.Show()
        MainForm.SetPortStatus()
        MainForm.mengulang()
        Me.Hide()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        portlist.Enabled = True
        GetSerialPortNames()
    End Sub
    Public Function GetSerialPortNames() As Boolean
        ' Show all available COM ports. 
        For Each sp As String In My.Computer.Ports.SerialPortNames
            portlist.Items.Add(sp)
        Next
        If portlist.Items.Count < 1 Then
            MsgBox("Komputer ini tidak mempunyai koneksi port serial untuk dihubungkan ke timbangan.", MsgBoxStyle.Exclamation, "Pesan Peringatan")
            portlist.Enabled = False
            'pilih.Enabled = False
            Return False
        End If
        portlist.Sorted = True
        portlist.SelectedIndex = 0
        Return True
    End Function
End Class
