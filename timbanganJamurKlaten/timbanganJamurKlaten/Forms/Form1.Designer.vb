<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pilih = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.portlist = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'pilih
        '
        Me.pilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pilih.BackgroundImage = Global.timbanganJamurKlaten.My.Resources.Resources.btn_pilih
        Me.pilih.Location = New System.Drawing.Point(171, 180)
        Me.pilih.Name = "pilih"
        Me.pilih.Size = New System.Drawing.Size(101, 29)
        Me.pilih.TabIndex = 0
        Me.pilih.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Noir", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Port:"
        '
        'portlist
        '
        Me.portlist.FormattingEnabled = True
        Me.portlist.Location = New System.Drawing.Point(6, 38)
        Me.portlist.Name = "portlist"
        Me.portlist.Size = New System.Drawing.Size(129, 21)
        Me.portlist.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.timbanganJamurKlaten.My.Resources.Resources.bg_port
        Me.ClientSize = New System.Drawing.Size(284, 221)
        Me.Controls.Add(Me.portlist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pilih)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pilih As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents portlist As ComboBox
End Class
