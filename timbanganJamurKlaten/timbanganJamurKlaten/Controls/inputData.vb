Imports System.Data.SqlClient
Imports MySql.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Threading

Public Class inputData
    Dim rowCount As Integer
    Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
    Public Sub aturTanggal()
        'Setiap di input maka tanggal akan update, max tanggal
        tanggal.MaxDate = System.DateTime.Now
        tanggal.Value = tanggal.MaxDate

    End Sub

    Private Sub getRowCount()
        Dim Hari As String = tanggal.Value.ToString("dddd, dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim query As String
        query = "select count(*) from tb_timbang where tanggal = '" & Hari & "'"
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        Dim res As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        conn.Close()

        rowCount = res

    End Sub

    Function getRowCount(query As String) As Integer
        'Dim Hari As String = tanggal.Value.ToString("dddd, dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        Dim res As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        conn.Close()

        Return res
    End Function

    Function getArray(query As String) As ArrayList
        Dim conn As New MySqlConnection(connString)
        Dim result As MySqlDataReader
        Dim res As ArrayList = New ArrayList()
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)
        result = cmd.ExecuteReader()
        While result.Read()

            res.Add(result(0))
            ' MessageBox.Show("CCC")
        End While

        cmd = Nothing
        conn.Close()
        Return res

    End Function

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        getRowCount()
        Insert()
        Summary()
    End Sub

    Public Function GetSerialPortNames() As Boolean
        ' Show all available COM ports. 
        Dim portList As Integer = 0
        For Each sp As String In My.Computer.Ports.SerialPortNames
            portList += 1
        Next
        If portList < 1 Then
            MsgBox("Koneksi timbangan terputus! cek kembali kabel timbangan anda.", MsgBoxStyle.Exclamation, "Pesan Peringatan")
            'portList.Enabled = False
            'pilih.Enabled = False
            Return False
        Else
            konekPort()

        End If
        'portList.Sorted = True
        'portList.SelectedIndex = 0
        Return True
    End Function

    Public Sub refreshView()


        Dim dtTimbangan As New DataTable
        'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim Hari As String = tanggal.Value.ToString("dddd, dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim query1 As String = "SET lc_time_names = 'id_ID'"
        MyNonQuery(query1)
        Dim query As String = "Select gelombang As 'Gelombang' ,DATE_FORMAT(tanggal,'%W, %d-%m-%Y') as 'Tanggal',Berat As 'Berat' FROM tb_timbang WHERE '" + Hari + "'= DATE_FORMAT(tanggal,'%W, %d-%m-%Y')"
        Dim queryGetProduksi As String = "Select gelombang from tb_baglog Where tgl_selesai_produksi IS NULL"
        'Dim baglogAktif As ArrayList = getArray(queryGetProduksi)
        'gelombang.DataSource = baglogAktif
        Dim queryUpdateTglProduksi = ""
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        SDA.SelectCommand = cmd
        SDA.Fill(dtTimbangan)
        bSource.DataSource = dtTimbangan
        tabelData.DataSource = bSource
        ' Resize the master DataGridView columns to fit the newly loaded data.
        tabelData.AutoResizeColumns()

        ' Configure the details DataGridView so that its columns automatically
        ' adjust their widths when the data changes.
        tabelData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill
        SDA.Update(dtTimbangan)
        conn.Close()


        Summary()
        '  Using conn As New MySqlConnection(connString)
        ' conn.Open()
        'Using cmd As New MySqlCommand("", conn)

        'End Using
        'conn.Close()
        'End Using

    End Sub

    Public Sub getView()


        Dim dtTimbangan As New DataTable
        'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim Hari As String = tanggal.Value.ToString("dddd, dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim query1 As String = "SET lc_time_names = 'id_ID'"
        MyNonQuery(query1)
        Dim query As String = "Select gelombang As 'Gelombang' ,DATE_FORMAT(tanggal,'%W, %d-%m-%Y') as 'Tanggal',Berat As 'Berat' FROM tb_timbang WHERE '" + Hari + "'= DATE_FORMAT(tanggal,'%W, %d-%m-%Y')"
        Dim queryGetProduksi As String = "Select gelombang from tb_baglog Where tgl_selesai_produksi IS NULL"
        Dim baglogAktif As ArrayList = getArray(queryGetProduksi)
        gelombang.DataSource= baglogAktif
        Dim queryUpdateTglProduksi = ""
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        SDA.SelectCommand = cmd
        SDA.Fill(dtTimbangan)
        bSource.DataSource = dtTimbangan
        tabelData.DataSource = bSource
        ' Resize the master DataGridView columns to fit the newly loaded data.
        tabelData.AutoResizeColumns()

        ' Configure the details DataGridView so that its columns automatically
        ' adjust their widths when the data changes.
        tabelData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill
        SDA.Update(dtTimbangan)
        conn.Close()


        Summary()
        '  Using conn As New MySqlConnection(connString)
        ' conn.Open()
        'Using cmd As New MySqlCommand("", conn)

        'End Using
        'conn.Close()
        'End Using

    End Sub

    Public Sub MyNonQuery(ByVal SQCommand As String)
        Dim conn As New MySqlConnection(connString)

        Dim SQLCMD As New MySqlCommand(SQCommand, conn)

        conn.Open()
        SQLCMD.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelData.CellContentClick

    End Sub

    Private Sub Summary()
        Dim beratKg As Decimal = 0
        Dim beratS As Decimal
        If tabelData.RowCount >= 1 Then
            For index As Integer = 0 To tabelData.RowCount - 1
                'TelurSum += Convert.ToInt32(timbanganDataGridView.Rows(index).Cells(3).Value)
                Decimal.TryParse((tabelData.Rows(index).Cells(2).Value), beratS)
                beratKg += beratS
            Next
        End If
        beratTotal.Text = beratKg.ToString()
    End Sub

    Private Function getData(query As String) As String
        Dim conn As New MySqlConnection(connString)
        Dim result As MySqlDataReader
        Dim res As String = ""
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)
        result = cmd.ExecuteReader()
        If result.Read() Then
            res = result.Item(0).ToString()

        End If
        cmd = Nothing
        conn.Close()
        Return res

    End Function

    Private Function getDoubleValue(query As String) As Decimal
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        Dim res As Decimal = cmd.ExecuteScalar()
        cmd = Nothing
        conn.Close()

        Return res
    End Function

    Private Sub updateTotal(gelombang As String, addedJml As Decimal)
        Dim oldJml As Decimal = getData("Select jml_hasil from tb_baglog where gelombang = '" & gelombang & "'")
        Dim newJml As Decimal

        newJml = oldJml + addedJml

        MyNonQuery("Update tb_baglog set jml_hasil = '" & newJml & "' where gelombang = '" & gelombang & "'")

    End Sub



    Friend Sub Insert()
        If (berat.Text <> "") Then

            'Mengambil nilai jumlah di tabel tb_baglog disimpan di variabel
            'Menjumlah dengan variabel input
            'Menyimpan di tabel baglog 
            'Dim totaltmp As Integer

            Dim Hari As String = tanggal.Value.ToString("dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
            'Dim KondisiTelur As String  = "Utuh"
            ' MessageBox.Show(Hari)
            Try
                ' Jika Gelombang Baglog belum ada maka akan di insert
                ' Jika Gelombang Baglog sudah ada maka akan di ambil nilai beratnya kemudian di tambahkan
                Dim dtTimbangan As New DataTable
                'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
                Dim SDA As New MySqlDataAdapter
                Dim bSource As New BindingSource
                Dim query As String
                Dim query1 As String = "Select count(*) FROM tb_timbang WHERE '" & Hari & "' = DATE_FORMAT(tanggal,'%d-%m-%Y') AND '" & gelombang.SelectedItem.ToString() & "' = gelombang"
                Dim queryCheck As String = "Select tgl_produksi From tb_baglog WHERE gelombang = '" & gelombang.SelectedItem.ToString() & "'"
                Dim conn As New MySqlConnection(connString)
                conn.Open()

                Dim barisGelombang As Integer = getRowCount(query1)
                Dim tanggalProduksi As String = getData(queryCheck)
                Dim inputBerat As String = berat.Text
                inputBerat = inputBerat.Replace(",", ".")

                'MessageBox.Show(queryCheck)
                If (tanggalProduksi = "") Then
                    'Jika tanggal produksi tidak ada maka tanggal ini adalah tanggal produksi
                    '    MessageBox.Show(Hari)

                    Dim querySetTanggalProduksi As String = "Update tb_baglog SET tgl_produksi = STR_TO_DATE('" & Hari & "', '%d-%m-%Y') Where '" & gelombang.SelectedItem.ToString() & "' = gelombang"
                    MyNonQuery(querySetTanggalProduksi)

                End If
                If (barisGelombang < 1) Then
                    'Belum ada
                    query = "Insert into tb_timbang (gelombang,tanggal,Berat) values ('" & gelombang.SelectedItem.ToString() & "',STR_TO_DATE('" & Hari & "', '%d-%m-%Y'),'" & inputBerat & "')"

                    Dim cmd As New MySqlCommand(query, conn)

                    SDA.SelectCommand = cmd
                    SDA.Fill(dtTimbangan)
                    bSource.DataSource = dtTimbangan
                    Dim beratTimbangan As Decimal
                    Decimal.TryParse(inputBerat, beratTimbangan)

                    updateTotal(gelombang.SelectedItem.ToString(), beratTimbangan)
                    MainForm.teksStatus.Text = "Berat Jamur Sukses di tambahkan"

                Else
                    'sudah ada
                    'Get Nilai berat yang ada
                    Dim nilaiBerat As Decimal
                    Dim beratTimbangan As Decimal
                    query = "Select Berat From tb_timbang Where '" + Hari + "' = DATE_FORMAT(tanggal,'%d-%m-%Y') AND '" + gelombang.SelectedItem.ToString() + "' = gelombang"
                    nilaiBerat = getDoubleValue(query)

                    Decimal.TryParse(inputBerat, beratTimbangan)
                    'MessageBox.Show(nilaiBerat)
                    nilaiBerat += beratTimbangan
                    'MessageBox.Show(nilaiBerat)

                    query = "Update tb_timbang SET Berat = '" & nilaiBerat & "' Where '" & Hari & "' = DATE_FORMAT(tanggal,'%d-%m-%Y') AND '" & gelombang.SelectedItem.ToString() & "' = gelombang"
                    'MessageBox.Show(query)

                    Dim cmd As New MySqlCommand(query, conn)

                    SDA.SelectCommand = cmd
                    SDA.Fill(dtTimbangan)
                    bSource.DataSource = dtTimbangan
                    updateTotal(gelombang.SelectedItem.ToString(), beratTimbangan)
                    MainForm.teksStatus.Text = "Berat Jamur Sukses di tambahkan"

                End If
                'tabelData.DataSource = bSource

                refreshView()
                conn.Close()

                'Tb_timbanganTableAdapter.Insert(tanggal.Value, Hari, Waktu, KandangNo.Text,
                'Bruto.Text, TockJenis.SelectedValue, TockJumlah.Text, KondisiTelur,
                'Pakan.Text, AyamMati.Text, AyamAfkir.Text, TelurJumlah.Text, Netto.Text)
                'Loader()
                Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
                MainForm.teksStatus.Text = "Berat Jamur gagal di tambahkan"

            End Try
        Else
            MsgBox("Isi form berat")
            MainForm.teksStatus.Text = "Isi Form berat terlebih dahulu"

        End If



    End Sub

    Private Sub Clear()

        berat.Text = ""
    End Sub


    '' Interfacing Timbangan
    '===== DARI SINI ================================================================================= tambahan deklarasi dan subroutine
    Public mySerialPort As New SerialPort
    Public alamatPort As String = "" 'ganti sesuai alamat COM di komputer !
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Public txt As String
    Dim beratku As Decimal
    Dim koma As String = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

    Public Sub PilihPort()
        'FormPilihPort.Hide()
        '============================================================================================================== tak tambahi iki bos!
        AddHandler mySerialPort.DataReceived, AddressOf mySerialPort_DataReceived               '---> untuk serial
        alamatPort = Form1.comName
        If alamatPort <> "" Then konekPort()
    End Sub

    Public Sub SetPort(ByVal com As String)
        With mySerialPort
            .PortName = com
            .BaudRate = 1200
            .DataBits = 8
            .Parity = Parity.None
            .StopBits = StopBits.One
            .Handshake = Handshake.None
        End With
    End Sub

    Public Sub konekPort()
        SetPort(alamatPort)
        Try
            mySerialPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            MsgBox("Tidak dapat terhubung ke timbangan melalui port " + alamatPort + "." + vbCrLf _
                   + "Pastikan seting alamat port sudah benar.", MsgBoxStyle.Critical, "Pesan Error")

        End Try
    End Sub

    Public Sub mySerialPort_DataReceived(ByVal ByValsender As Object, ByVal ByVale As SerialDataReceivedEventArgs)
        'Handles serial port data received events 
        Dim n As Integer = mySerialPort.BytesToRead
        Dim comBuffer As Byte() = New Byte(n - 1) {}
        mySerialPort.Read(comBuffer, 0, n)

        ''parsing setiap pengukuran
        For x As Integer = 0 To n - 1
            Dim huruf As String
            huruf = Chr(comBuffer(x)).ToString()
            If huruf = "w" Then
                txt = ""
            End If
            txt += huruf
        Next

        'jika data kurang dari 7 digit, maka pembacaan gagal, tidak ditampilkan
        'If txt.Length < 11 Then
        'Return
        'End If

        ''SetText(txt)  ---> untuk debug hasil pembacaan

        ''parsing nilai beratnya saja
        Try
            'MessageBox.Show(txt)

            txt = txt.Substring(2, 7)
            'MessageBox.Show(txt)

        Catch
            Return
        End Try

        'menyamakan pembatas desimal . (US) atau , (ID)
        txt = batasDesimal(txt)
        ' MessageBox.Show(txt)

        'jika data kurang dari 7 digit, maka pembacaan gagal, tidak ditampilkan
        If txt.Length < 7 Then
            Return
        End If

        ''--->hasil konversi ke angka double disimpoan di variabel berat
        Try
            beratku = Convert.ToDecimal(txt)
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())

            Return
            beratku = 0.0
        End Try

        ''menampilkan ke txtbox bruto
        Try
            SetText(beratku.ToString())
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())

            Return
        End Try
    End Sub

    Public Sub SetText(ByVal [text] As String)
        If Me.berat.InvokeRequired Then                                         '---> berat adalah nama textbox untuk menampilkan berat
            Dim d As New SetTextCallback(AddressOf SetText)

            Me.Invoke(d, New Object() {[text]})
        Else
            'MessageBox.Show("dddd")
            Me.berat.Text = [text]                                              '---> berat adalah nama textbox untuk menampilkan berat
        End If
    End Sub

    Function batasDesimal(ByVal txt As String) As String
        ' txt = txt.Replace(",", koma)
        ' txt = txt.Replace(".", koma)
        Return txt
    End Function

    Private Sub inputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getView()

        aturTanggal()

    End Sub

    Private Sub berat_TextChanged(sender As Object, e As EventArgs) Handles berat.TextChanged

    End Sub

    Private Sub gelombang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gelombang.SelectedIndexChanged

    End Sub

    Private Sub tanggal_ValueChanged(sender As Object, e As EventArgs) Handles tanggal.ValueChanged

    End Sub


End Class
