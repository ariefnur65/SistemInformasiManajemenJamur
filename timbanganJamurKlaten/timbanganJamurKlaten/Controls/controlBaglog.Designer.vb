<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlBaglog
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pengadaan = New System.Windows.Forms.TextBox()
        Me.oo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jumlahBaglog = New System.Windows.Forms.TextBox()
        Me.tglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.leb = New System.Windows.Forms.Label()
        Me.tabelData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tgldone = New System.Windows.Forms.DateTimePicker()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.selesai = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        CType(Me.tabelData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pengadaan
        '
        Me.pengadaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pengadaan.Location = New System.Drawing.Point(186, 64)
        Me.pengadaan.Name = "pengadaan"
        Me.pengadaan.Size = New System.Drawing.Size(153, 30)
        Me.pengadaan.TabIndex = 0
        '
        'oo
        '
        Me.oo.AutoSize = True
        Me.oo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oo.Location = New System.Drawing.Point(9, 67)
        Me.oo.Name = "oo"
        Me.oo.Size = New System.Drawing.Size(165, 25)
        Me.oo.TabIndex = 1
        Me.oo.Text = "Kode Pengadaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jumlah Baglog"
        '
        'jumlahBaglog
        '
        Me.jumlahBaglog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlahBaglog.Location = New System.Drawing.Point(186, 98)
        Me.jumlahBaglog.Name = "jumlahBaglog"
        Me.jumlahBaglog.Size = New System.Drawing.Size(154, 30)
        Me.jumlahBaglog.TabIndex = 3
        '
        'tglMasuk
        '
        Me.tglMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglMasuk.Location = New System.Drawing.Point(186, 26)
        Me.tglMasuk.Name = "tglMasuk"
        Me.tglMasuk.Size = New System.Drawing.Size(361, 30)
        Me.tglMasuk.TabIndex = 4
        '
        'leb
        '
        Me.leb.AutoSize = True
        Me.leb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leb.Location = New System.Drawing.Point(9, 26)
        Me.leb.Name = "leb"
        Me.leb.Size = New System.Drawing.Size(148, 25)
        Me.leb.TabIndex = 5
        Me.leb.Text = "Tanggal Masuk"
        '
        'tabelData
        '
        Me.tabelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tabelData.Location = New System.Drawing.Point(7, 139)
        Me.tabelData.Name = "tabelData"
        Me.tabelData.ReadOnly = True
        Me.tabelData.Size = New System.Drawing.Size(1040, 383)
        Me.tabelData.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tanggal Selesai Produksi"
        '
        'tgldone
        '
        Me.tgldone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgldone.Location = New System.Drawing.Point(558, 59)
        Me.tgldone.Name = "tgldone"
        Me.tgldone.Size = New System.Drawing.Size(281, 30)
        Me.tgldone.TabIndex = 9
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 525)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'selesai
        '
        Me.selesai.AutoSize = True
        Me.selesai.BackColor = System.Drawing.Color.Transparent
        Me.selesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selesai.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_selesai3
        Me.selesai.Location = New System.Drawing.Point(848, 7)
        Me.selesai.Name = "selesai"
        Me.selesai.Size = New System.Drawing.Size(202, 67)
        Me.selesai.TabIndex = 8
        Me.selesai.UseVisualStyleBackColor = False
        '
        'insert
        '
        Me.insert.AutoSize = True
        Me.insert.BackColor = System.Drawing.Color.Transparent
        Me.insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_masukkan4
        Me.insert.Location = New System.Drawing.Point(345, 63)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(202, 67)
        Me.insert.TabIndex = 7
        Me.insert.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cancelBtn.FlatAppearance.BorderSize = 20
        Me.cancelBtn.Font = New System.Drawing.Font("Noir", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cancelBtn.Location = New System.Drawing.Point(848, 80)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(199, 57)
        Me.cancelBtn.TabIndex = 12
        Me.cancelBtn.Text = "Batal"
        Me.cancelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'controlBaglog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tgldone)
        Me.Controls.Add(Me.selesai)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.tabelData)
        Me.Controls.Add(Me.leb)
        Me.Controls.Add(Me.tglMasuk)
        Me.Controls.Add(Me.jumlahBaglog)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.oo)
        Me.Controls.Add(Me.pengadaan)
        Me.Name = "controlBaglog"
        Me.Size = New System.Drawing.Size(1050, 525)
        CType(Me.tabelData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pengadaan As TextBox
    Friend WithEvents oo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents jumlahBaglog As TextBox
    Friend WithEvents tglMasuk As DateTimePicker
    Friend WithEvents leb As Label
    Friend WithEvents tabelData As DataGridView
    Friend WithEvents insert As Button
    Friend WithEvents selesai As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tgldone As DateTimePicker
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents cancelBtn As Button
End Class
