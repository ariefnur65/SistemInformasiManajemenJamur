<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.port = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.teksStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lihatBtn = New System.Windows.Forms.Button()
        Me.keluarBtn = New System.Windows.Forms.Button()
        Me.pilihPortBtn = New System.Windows.Forms.Button()
        Me.kelolaBagBtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.InputData1 = New timbanganJamurKlaten.inputData()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.port, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.teksStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 746)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1366, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel1.Text = "Timbangan Jamur"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel3.Text = "Port:"
        '
        'port
        '
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(12, 17)
        Me.port.Text = "-"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel5.Text = "Status:"
        '
        'teksStatus
        '
        Me.teksStatus.Name = "teksStatus"
        Me.teksStatus.Size = New System.Drawing.Size(12, 17)
        Me.teksStatus.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.timbanganJamurKlaten.My.Resources.Resources.header1
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 195)
        Me.Panel1.TabIndex = 11
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackgroundImage = Global.timbanganJamurKlaten.My.Resources.Resources.panel_kanan
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 201)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.SplitContainer1.Panel1.BackgroundImage = Global.timbanganJamurKlaten.My.Resources.Resources.panel_menu1
        Me.SplitContainer1.Panel1.Controls.Add(Me.lihatBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.keluarBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pilihPortBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.kelolaBagBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.InputData1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1366, 546)
        Me.SplitContainer1.SplitterDistance = 305
        Me.SplitContainer1.TabIndex = 4
        '
        'lihatBtn
        '
        Me.lihatBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lihatBtn.BackColor = System.Drawing.Color.Transparent
        Me.lihatBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lihatBtn.FlatAppearance.BorderSize = 0
        Me.lihatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.lihatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lihatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lihatBtn.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_lihat1
        Me.lihatBtn.Location = New System.Drawing.Point(22, 86)
        Me.lihatBtn.Name = "lihatBtn"
        Me.lihatBtn.Size = New System.Drawing.Size(266, 75)
        Me.lihatBtn.TabIndex = 14
        Me.lihatBtn.UseVisualStyleBackColor = False
        '
        'keluarBtn
        '
        Me.keluarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keluarBtn.BackColor = System.Drawing.Color.Transparent
        Me.keluarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keluarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.keluarBtn.FlatAppearance.BorderSize = 0
        Me.keluarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.keluarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.keluarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keluarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.keluarBtn.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_keluar
        Me.keluarBtn.Location = New System.Drawing.Point(21, 451)
        Me.keluarBtn.Name = "keluarBtn"
        Me.keluarBtn.Size = New System.Drawing.Size(266, 75)
        Me.keluarBtn.TabIndex = 13
        Me.keluarBtn.UseVisualStyleBackColor = False
        '
        'pilihPortBtn
        '
        Me.pilihPortBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pilihPortBtn.BackColor = System.Drawing.Color.Transparent
        Me.pilihPortBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pilihPortBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.pilihPortBtn.FlatAppearance.BorderSize = 0
        Me.pilihPortBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.pilihPortBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.pilihPortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pilihPortBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pilihPortBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pilihPortBtn.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_pilihport
        Me.pilihPortBtn.Location = New System.Drawing.Point(21, 371)
        Me.pilihPortBtn.Name = "pilihPortBtn"
        Me.pilihPortBtn.Size = New System.Drawing.Size(266, 75)
        Me.pilihPortBtn.TabIndex = 12
        Me.pilihPortBtn.UseVisualStyleBackColor = False
        '
        'kelolaBagBtn
        '
        Me.kelolaBagBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kelolaBagBtn.BackColor = System.Drawing.Color.Transparent
        Me.kelolaBagBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kelolaBagBtn.FlatAppearance.BorderSize = 0
        Me.kelolaBagBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.kelolaBagBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.kelolaBagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kelolaBagBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaBagBtn.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_tambahbaglog1
        Me.kelolaBagBtn.Location = New System.Drawing.Point(21, 248)
        Me.kelolaBagBtn.Name = "kelolaBagBtn"
        Me.kelolaBagBtn.Size = New System.Drawing.Size(266, 75)
        Me.kelolaBagBtn.TabIndex = 11
        Me.kelolaBagBtn.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.timbanganJamurKlaten.My.Resources.Resources.btn_tambahdata1
        Me.Button5.Location = New System.Drawing.Point(22, 167)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(266, 75)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = False
        '
        'InputData1
        '
        Me.InputData1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputData1.AutoScroll = True
        Me.InputData1.BackColor = System.Drawing.Color.Transparent
        Me.InputData1.BackgroundImage = Global.timbanganJamurKlaten.My.Resources.Resources.panel_kanan1
        Me.InputData1.Location = New System.Drawing.Point(3, 0)
        Me.InputData1.Name = "InputData1"
        Me.InputData1.Size = New System.Drawing.Size(1051, 546)
        Me.InputData1.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents port As ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lihatBtn As Button
    Friend WithEvents keluarBtn As Button
    Friend WithEvents pilihPortBtn As Button
    Friend WithEvents kelolaBagBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents teksStatus As ToolStripStatusLabel
    Public WithEvents InputData1 As inputData
End Class
