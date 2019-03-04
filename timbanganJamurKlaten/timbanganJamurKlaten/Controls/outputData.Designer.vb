<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outputData
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.penanggalan = New System.Windows.Forms.DateTimePicker()
        Me.tabelData = New System.Windows.Forms.DataGridView()
        Me.TimbanganDataSet1 = New timbanganJamurKlaten.timbanganDataSet()
        Me.satuan = New System.Windows.Forms.Label()
        Me.beratTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cari = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabelData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimbanganDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal Panen"
        '
        'penanggalan
        '
        Me.penanggalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penanggalan.Location = New System.Drawing.Point(172, 18)
        Me.penanggalan.Name = "penanggalan"
        Me.penanggalan.Size = New System.Drawing.Size(336, 30)
        Me.penanggalan.TabIndex = 1
        '
        'tabelData
        '
        Me.tabelData.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tabelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelData.DefaultCellStyle = DataGridViewCellStyle5
        Me.tabelData.Location = New System.Drawing.Point(14, 107)
        Me.tabelData.Name = "tabelData"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelData.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tabelData.Size = New System.Drawing.Size(1033, 362)
        Me.tabelData.TabIndex = 5
        '
        'TimbanganDataSet1
        '
        Me.TimbanganDataSet1.DataSetName = "timbanganDataSet"
        Me.TimbanganDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'satuan
        '
        Me.satuan.AutoSize = True
        Me.satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.satuan.Location = New System.Drawing.Point(65, 4)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(68, 25)
        Me.satuan.TabIndex = 2
        Me.satuan.Text = "(Kg) :"
        '
        'beratTotal
        '
        Me.beratTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.beratTotal.AutoSize = True
        Me.beratTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beratTotal.Location = New System.Drawing.Point(928, 4)
        Me.beratTotal.Name = "beratTotal"
        Me.beratTotal.Size = New System.Drawing.Size(20, 25)
        Me.beratTotal.TabIndex = 1
        Me.beratTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.satuan)
        Me.Panel1.Controls.Add(Me.beratTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(14, 468)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 37)
        Me.Panel1.TabIndex = 16
        '
        'cari
        '
        Me.cari.AutoSize = True
        Me.cari.BackColor = System.Drawing.SystemColors.Control
        Me.cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_cari1
        Me.cari.Location = New System.Drawing.Point(843, 18)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(204, 67)
        Me.cari.TabIndex = 2
        Me.cari.UseVisualStyleBackColor = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "TimbanganDataSet1"
        '
        'Timer1
        '
        '
        'outputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabelData)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.penanggalan)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "outputData"
        Me.Size = New System.Drawing.Size(1050, 525)
        CType(Me.tabelData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimbanganDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents penanggalan As DateTimePicker
    Friend WithEvents cari As Button
    Friend WithEvents tabelData As DataGridView
    Friend WithEvents TimbanganDataSet1 As timbanganDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents satuan As Label
    Friend WithEvents beratTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
End Class
