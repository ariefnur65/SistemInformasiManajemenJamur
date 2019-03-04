Imports MySql.Data.MySqlClient

Public Class outputData
    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        getView()
    End Sub

    Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"

    Public Sub MyNonQuery(ByVal SQCommand As String)
        Dim conn As New MySqlConnection(connString)

        Dim SQLCMD As New MySqlCommand(SQCommand, conn)

        conn.Open()
        SQLCMD.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub getView()
        Dim dtTimbangan As New DataTable
        'Dim connString As String = "server=localhost;uid=root;password=arief;persistsecurityinfo=True;database=timbangan"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim Hari As String = penanggalan.Value.ToString("dddd, dd-MM-yyyy", New Globalization.CultureInfo("id-ID"))
        'MessageBox.Show(Hari)
        Dim query1 As String = "SET lc_time_names = 'id_ID'"
        MyNonQuery(query1)
        Dim query As String = "Select gelombang As 'Gelombang' ,DATE_FORMAT(tanggal,'%W, %d-%m-%Y') as 'Tanggal',Berat As 'Berat' FROM tb_timbang WHERE '" + Hari + "'= DATE_FORMAT(tanggal,'%W, %d-%m-%Y')"
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim cmd As New MySqlCommand(query, conn)
        Try
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
            readData.teksStatus.Text = "Data Jamur berhasil di tampilkan"

        Catch ex As Exception
            readData.teksStatus.Text = "Data Jamur gagal di tampilkan"

        End Try

        conn.Close()


        Summary()
        '  Using conn As New MySqlConnection(connString)
        ' conn.Open()
        'Using cmd As New MySqlCommand("", conn)

        'End Using
        'conn.Close()
        'End Using

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
        beratTotal.Text = beratKg

    End Sub

    Private Sub outputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        penanggalan.MaxDate = System.DateTime.Now
        getView()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
