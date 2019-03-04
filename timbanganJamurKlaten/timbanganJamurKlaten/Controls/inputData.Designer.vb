<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inputData
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.berat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.tabelData = New System.Windows.Forms.DataGridView()
        Me.TimbanganDataSet1 = New timbanganJamurKlaten.timbanganDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimbanganDataSet = New timbanganJamurKlaten.timbanganDataSet()
        Me.Tb_timbangTableAdapter1 = New timbanganJamurKlaten.timbanganDataSetTableAdapters.tb_timbangTableAdapter()
        Me.TbtimbangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimbanganDataSet2 = New timbanganJamurKlaten.timbanganDataSet()
        Me.TbtimbangBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.satuan = New System.Windows.Forms.Label()
        Me.beratTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gelombang = New System.Windows.Forms.ComboBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabelData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimbanganDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimbanganDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbtimbangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimbanganDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbtimbangBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'berat
        '
        Me.berat.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berat.Location = New System.Drawing.Point(510, 32)
        Me.berat.Name = "berat"
        Me.berat.Size = New System.Drawing.Size(174, 47)
        Me.berat.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(507, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Berat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(14, 40)
        Me.tanggal.MaxDate = New Date(2017, 7, 25, 13, 19, 7, 0)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(236, 27)
        Me.tanggal.TabIndex = 7
        Me.tanggal.Value = New Date(2017, 7, 25, 0, 0, 0, 0)
        '
        'tabelData
        '
        Me.tabelData.AllowUserToAddRows = False
        Me.tabelData.AllowUserToDeleteRows = False
        Me.tabelData.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.tabelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelData.Location = New System.Drawing.Point(9, 89)
        Me.tabelData.Name = "tabelData"
        Me.tabelData.ReadOnly = True
        Me.tabelData.Size = New System.Drawing.Size(1038, 394)
        Me.tabelData.TabIndex = 14
        '
        'TimbanganDataSet1
        '
        Me.TimbanganDataSet1.DataSetName = "timbanganDataSet"
        Me.TimbanganDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.TimbanganDataSet
        Me.BindingSource1.Position = 0
        '
        'TimbanganDataSet
        '
        Me.TimbanganDataSet.DataSetName = "timbanganDataSet"
        Me.TimbanganDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_timbangTableAdapter1
        '
        Me.Tb_timbangTableAdapter1.ClearBeforeFill = True
        '
        'TbtimbangBindingSource
        '
        Me.TbtimbangBindingSource.DataMember = "tb_timbang"
        Me.TbtimbangBindingSource.DataSource = Me.TimbanganDataSet
        '
        'TimbanganDataSet2
        '
        Me.TimbanganDataSet2.DataSetName = "timbanganDataSet"
        Me.TimbanganDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbtimbangBindingSource1
        '
        Me.TbtimbangBindingSource1.DataMember = "tb_timbang"
        Me.TbtimbangBindingSource1.DataSource = Me.TimbanganDataSet2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.satuan)
        Me.Panel1.Controls.Add(Me.beratTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(9, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 37)
        Me.Panel1.TabIndex = 15
        '
        'satuan
        '
        Me.satuan.AutoSize = True
        Me.satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.satuan.Location = New System.Drawing.Point(58, 4)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(52, 20)
        Me.satuan.TabIndex = 2
        Me.satuan.Text = "(Kg) :"
        '
        'beratTotal
        '
        Me.beratTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.beratTotal.AutoSize = True
        Me.beratTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beratTotal.Location = New System.Drawing.Point(940, 4)
        Me.beratTotal.Name = "beratTotal"
        Me.beratTotal.Size = New System.Drawing.Size(15, 20)
        Me.beratTotal.TabIndex = 1
        Me.beratTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Baglog Gelombang"
        '
        'gelombang
        '
        Me.gelombang.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gelombang.FormattingEnabled = True
        Me.gelombang.Items.AddRange(New Object() {"1", "2"})
        Me.gelombang.Location = New System.Drawing.Point(256, 40)
        Me.gelombang.Name = "gelombang"
        Me.gelombang.Size = New System.Drawing.Size(174, 28)
        Me.gelombang.TabIndex = 18
        '
        'simpan
        '
        Me.simpan.AutoSize = True
        Me.simpan.BackColor = System.Drawing.Color.Transparent
        Me.simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpan.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_simpan1
        Me.simpan.Location = New System.Drawing.Point(822, 16)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(202, 67)
        Me.simpan.TabIndex = 13
        Me.simpan.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'inputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.gelombang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabelData)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.berat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tanggal)
        Me.Name = "inputData"
        Me.Size = New System.Drawing.Size(1050, 525)
        CType(Me.tabelData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimbanganDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimbanganDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbtimbangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimbanganDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbtimbangBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents berat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents tabelData As DataGridView
    Friend WithEvents TimbanganDataSet1 As timbanganDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TimbanganDataSet As timbanganDataSet
    Friend WithEvents TbtimbangBindingSource As BindingSource
    Friend WithEvents Tb_timbangTableAdapter1 As timbanganDataSetTableAdapters.tb_timbangTableAdapter
    Friend WithEvents TbtimbangBindingSource1 As BindingSource
    Friend WithEvents TimbanganDataSet2 As timbanganDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents satuan As Label
    Friend WithEvents beratTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gelombang As ComboBox
    Friend WithEvents simpan As Button
    Friend WithEvents Timer1 As Timer
End Class
