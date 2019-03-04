Imports MySql.Data.MySqlClient

Public Class controlBaglog
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles oo.Click

    End Sub
    Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
    Dim pengadaanBag As String
    Dim tanggalMasuk As Date
    Dim kodePengadaan As String

    Private Sub setKodePengadaan()
        tanggalMasuk = tglMasuk.Value
        Dim bulan As String = tglMasuk.Value.Month.ToString()
        Dim tanggalan As String = tglMasuk.Value.Day.ToString()
        Dim Tahun As String = tglMasuk.Value.Year.ToString()
        kodePengadaan = tanggalan & "H" & bulan & "B" & Tahun.Substring(2, 2) & "T"
        'MessageBox.Show(kodePengadaan)
        pengadaan.Text = kodePengadaan

    End Sub
    Function getCount(query As String) As Integer
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

    Function getCountS(query As String) As Object
        'Dim Hari As String = tanggal.Value.ToString("dddd, dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)

        Dim res As Object = cmd.ExecuteScalar()
        cmd = Nothing
        conn.Close()

        Return res
    End Function

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click

        If (jumlahBaglog.Text.ToString() = "" Or pengadaan.Text.ToString() = "") Then
            MessageBox.Show("Isi jumlah Baglog dan Kode Pengadaan!")
        Else

            setKodePengadaan()
            pengadaanBag = pengadaan.Text.ToString()
            tanggalMasuk = tglMasuk.Value
            Try
                ' Jika Gelombang Baglog belum ada maka akan di insert 
                ' Jika Gelombang Baglog sudah ada maka akan di ambil nilai beratnya kemudian di tambahkan

                Dim tanggalIn As String = tanggalMasuk.ToString("dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
                Dim dtTimbangan As New DataTable
                'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
                Dim SDA As New MySqlDataAdapter
                Dim bSource As New BindingSource
                Dim query As String = "Insert into tb_baglog (gelombang, tgl_masuk, jml_baglog) value ('" & kodePengadaan & "', STR_TO_DATE('" & tanggalIn & "', '%d-%m-%Y'), " & jumlahBaglog.Text & ") "
                Dim queryCheck As String = "Select count(*) from tb_baglog where gelombang = '" & kodePengadaan & "'"
                Dim conn As New MySqlConnection(connString)
                conn.Open()
                If (getCount(queryCheck) = 0) Then
                    If (jumlahBaglog.Text <> "") Then
                        Dim cmd As New MySqlCommand(query, conn)

                        SDA.SelectCommand = cmd
                        SDA.Fill(dtTimbangan)
                        bSource.DataSource = dtTimbangan
                        addBaglog.teksStatus.Text = "Baglog sukses di tambahkan"

                    Else
                        MessageBox.Show("Isi Jumlah Baglog terlebih dahulu")
                        addBaglog.teksStatus.Text = "Isi Jumlah Baglog"


                    End If

                Else
                    MessageBox.Show("Kode pengadaan sudah pernah di masukan")
                    addBaglog.teksStatus.Text = "Kode Baglog sudah pernah di tambahkan"

                End If
                'tabelData.DataSource = bSource
                getView()
                conn.Close()

                'Tb_timbanganTableAdapter.Insert(tanggal.Value, Hari, Waktu, KandangNo.Text,
                'Bruto.Text, TockJenis.SelectedValue, TockJumlah.Text, KondisiTelur,
                'Pakan.Text, AyamMati.Text, AyamAfkir.Text, TelurJumlah.Text, Netto.Text)
                'Loader()
                'Clear()

            Catch ex As Exception
                MsgBox(ex.ToString)
                addBaglog.teksStatus.Text = "Baglog Gagal di tambahkan"


            End Try
        End If


    End Sub

    Private Sub selesai_Click(sender As Object, e As EventArgs) Handles selesai.Click
        Dim kdPengadaan As String = pengadaan.Text.ToString()

        'pengadaanBag = pengadaan.Text.ToString()
        'tanggalMasuk = tglMasuk.Value
        Try
            ' Jika Gelombang Baglog belum ada maka akan di insert 
            ' Jika Gelombang Baglog sudah ada maka akan di ambil nilai beratnya kemudian di tambahkan

            Dim tanggalDn As String = tgldone.Value.ToString("dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))

            Dim dtTimbangan As New DataTable
            'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
            Dim SDA As New MySqlDataAdapter
            Dim bSource As New BindingSource
            Dim query As String = "Update tb_baglog SET tgl_selesai_produksi = STR_TO_DATE('" & tanggalDn & "', '%d-%m-%Y') WHERE gelombang = '" & kdPengadaan & "'"
            Dim queryCheck As String = "Select tgl_selesai_produksi from tb_baglog where gelombang = '" & kodePengadaan & "'"
            Dim conn As New MySqlConnection(connString)
            Dim i As Integer = tabelData.CurrentRow.Index
            Dim tanggalSelesai As String = tabelData.Item(3, i).Value.ToString()
            'MessageBox.Show(tanggalSelesai)
            If (tanggalSelesai <> "") Then
                MessageBox.Show("Tanggal Selesai Sudah di tetapkan")
                addBaglog.teksStatus.Text = "Masa Produksi Baglog sudah Selesai"

            Else
                conn.Open()

                Dim cmd As New MySqlCommand(query, conn)
                SDA.SelectCommand = cmd
                SDA.Fill(dtTimbangan)
                bSource.DataSource = dtTimbangan
                addBaglog.teksStatus.Text = "Masa produksi Baglog Sukses di Ganti"

                conn.Close()
                'tabelData.DataSource = bSource


            End If
            getView()
            conn.Close()
            selesai.Enabled = False
            insert.Enabled = True
            tglMasuk.Enabled = True
            jumlahBaglog.Enabled = True
            pengadaan.Enabled = True
            jumlahBaglog.Text = ""
            pengadaan.Text = ""
            cancelBtn.Enabled = False

            'Tb_timbanganTableAdapter.Insert(tanggal.Value, Hari, Waktu, KandangNo.Text,
            'Bruto.Text, TockJenis.SelectedValue, TockJumlah.Text, KondisiTelur,
            'Pakan.Text, AyamMati.Text, AyamAfkir.Text, TelurJumlah.Text, Netto.Text)
            'Loader()
            'Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
            getView()
            selesai.Enabled = False
            insert.Enabled = True
            tglMasuk.Enabled = True
            jumlahBaglog.Enabled = True
            pengadaan.Enabled = True
            jumlahBaglog.Text = ""
            pengadaan.Text = ""
            addBaglog.teksStatus.Text = "Masa produksi Baglog Gagal di Ganti"
            cancelBtn.Enabled = False

        End Try
    End Sub

    Public Sub getView()


        Dim dtTimbangan As New DataTable
        'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim Tahun As String = tglMasuk.Value.ToString("yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim query1 As String = "SET lc_time_names = 'id_ID'"
        MyNonQuery(query1)
        Dim query As String = "Select gelombang As 'Kode Pengadaan' ,DATE_FORMAT(tgl_masuk,'%W, %d-%m-%Y') as 'Tanggal Masuk',DATE_FORMAT(tgl_produksi,'%W, %d-%m-%Y') as 'Tanggal Mulai Produksi',DATE_FORMAT(tgl_selesai_Produksi,'%W, %d-%m-%Y') as 'Tanggal Selesai Produksi', jml_baglog as 'Jumlah Baglog',jml_hasil As 'Jumlah Hasil' FROM tb_baglog ORDER BY tgl_masuk DESC"
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


        'Summary()
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
    Private Sub controlBaglog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selesai.Enabled = False
        cancelBtn.Enabled = False
        getView()
        setKodePengadaan()

    End Sub

    Private Sub tglMasuk_ValueChanged(sender As Object, e As EventArgs) Handles tglMasuk.ValueChanged
        setKodePengadaan()

    End Sub

    Private Sub tabelData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelData.CellDoubleClick
        clickedCell()
    End Sub

    Public Sub clickedCell()
        Dim i As Integer = tabelData.CurrentRow.Index
        insert.Enabled = False
        pengadaan.Text = tabelData.Item(0, i).Value
        jumlahBaglog.Text = tabelData.Item(4, i).Value
        selesai.Enabled = True
        insert.Enabled = False
        tglMasuk.Enabled = False
        jumlahBaglog.Enabled = False
        pengadaan.Enabled = False
        cancelBtn.Enabled = True

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        selesai.Enabled = False
        insert.Enabled = True
        tglMasuk.Enabled = True
        jumlahBaglog.Enabled = True
        pengadaan.Enabled = True
        cancelBtn.Enabled = False
        jumlahBaglog.Text = ""
        pengadaan.Text = ""
    End Sub
End Class
