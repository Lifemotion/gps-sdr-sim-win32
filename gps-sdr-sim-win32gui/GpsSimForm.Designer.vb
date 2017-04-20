<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GpsSimForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GpsSimForm))
        Me.bRun = New System.Windows.Forms.Button()
        Me.cbRinexFile = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFormat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDuration = New System.Windows.Forms.ComboBox()
        Me.tpStaticMode = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbHgt = New System.Windows.Forms.TextBox()
        Me.tbLon = New System.Windows.Forms.TextBox()
        Me.tbLat = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cbOutputFile = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbHackrfIFGain = New System.Windows.Forms.TextBox()
        Me.tbHackrfRate = New System.Windows.Forms.TextBox()
        Me.tbHackrfFreq = New System.Windows.Forms.TextBox()
        Me.bTransmit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbHackrfAmp = New System.Windows.Forms.TextBox()
        Me.pbTransmit = New System.Windows.Forms.ProgressBar()
        Me.tpStaticMode.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bRun
        '
        Me.bRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRun.Location = New System.Drawing.Point(493, 302)
        Me.bRun.Name = "bRun"
        Me.bRun.Size = New System.Drawing.Size(75, 23)
        Me.bRun.TabIndex = 0
        Me.bRun.Text = "Generate"
        Me.bRun.UseVisualStyleBackColor = True
        '
        'cbRinexFile
        '
        Me.cbRinexFile.FormattingEnabled = True
        Me.cbRinexFile.Location = New System.Drawing.Point(166, 10)
        Me.cbRinexFile.Name = "cbRinexFile"
        Me.cbRinexFile.Size = New System.Drawing.Size(121, 21)
        Me.cbRinexFile.TabIndex = 1
        Me.cbRinexFile.Text = "brdc3540.14n"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RINEX navigation file (-e)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "I\Q Data Fromat (-b)"
        '
        'cbFormat
        '
        Me.cbFormat.FormattingEnabled = True
        Me.cbFormat.Items.AddRange(New Object() {"1", "8", "16"})
        Me.cbFormat.Location = New System.Drawing.Point(166, 38)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(121, 21)
        Me.cbFormat.TabIndex = 3
        Me.cbFormat.Text = "8"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Duration, seconds (-d)"
        '
        'cbDuration
        '
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"300"})
        Me.cbDuration.Location = New System.Drawing.Point(166, 65)
        Me.cbDuration.Name = "cbDuration"
        Me.cbDuration.Size = New System.Drawing.Size(121, 21)
        Me.cbDuration.TabIndex = 7
        Me.cbDuration.Text = "300"
        '
        'tpStaticMode
        '
        Me.tpStaticMode.Controls.Add(Me.Label7)
        Me.tpStaticMode.Controls.Add(Me.Label6)
        Me.tpStaticMode.Controls.Add(Me.Label5)
        Me.tpStaticMode.Controls.Add(Me.tbHgt)
        Me.tpStaticMode.Controls.Add(Me.tbLon)
        Me.tpStaticMode.Controls.Add(Me.tbLat)
        Me.tpStaticMode.Location = New System.Drawing.Point(4, 22)
        Me.tpStaticMode.Name = "tpStaticMode"
        Me.tpStaticMode.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStaticMode.Size = New System.Drawing.Size(553, 178)
        Me.tpStaticMode.TabIndex = 0
        Me.tpStaticMode.Text = "Static Mode (-l)"
        Me.tpStaticMode.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Height"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Longitude"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Latitude"
        '
        'tbHgt
        '
        Me.tbHgt.Location = New System.Drawing.Point(254, 30)
        Me.tbHgt.Name = "tbHgt"
        Me.tbHgt.Size = New System.Drawing.Size(100, 20)
        Me.tbHgt.TabIndex = 0
        Me.tbHgt.Text = "100"
        '
        'tbLon
        '
        Me.tbLon.Location = New System.Drawing.Point(135, 30)
        Me.tbLon.Name = "tbLon"
        Me.tbLon.Size = New System.Drawing.Size(100, 20)
        Me.tbLon.TabIndex = 0
        Me.tbLon.Text = "60.000000"
        '
        'tbLat
        '
        Me.tbLat.Location = New System.Drawing.Point(15, 30)
        Me.tbLat.Name = "tbLat"
        Me.tbLat.Size = New System.Drawing.Size(100, 20)
        Me.tbLat.TabIndex = 0
        Me.tbLat.Text = "30.000000"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpStaticMode)
        Me.TabControl1.Location = New System.Drawing.Point(11, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(561, 204)
        Me.TabControl1.TabIndex = 9
        '
        'cbOutputFile
        '
        Me.cbOutputFile.FormattingEnabled = True
        Me.cbOutputFile.Location = New System.Drawing.Point(357, 10)
        Me.cbOutputFile.Name = "cbOutputFile"
        Me.cbOutputFile.Size = New System.Drawing.Size(215, 21)
        Me.cbOutputFile.TabIndex = 1
        Me.cbOutputFile.Text = "gpssim.bin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Output File"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Location = New System.Drawing.Point(11, 331)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(561, 204)
        Me.TabControl2.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.tbHackrfAmp)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.tbHackrfIFGain)
        Me.TabPage1.Controls.Add(Me.tbHackrfRate)
        Me.TabPage1.Controls.Add(Me.tbHackrfFreq)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 178)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HackRF One"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "IF Gain, db"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(132, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Sample Rate, Hz"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Frequency, Hz"
        '
        'tbHackrfIFGain
        '
        Me.tbHackrfIFGain.Enabled = False
        Me.tbHackrfIFGain.Location = New System.Drawing.Point(254, 30)
        Me.tbHackrfIFGain.Name = "tbHackrfIFGain"
        Me.tbHackrfIFGain.Size = New System.Drawing.Size(100, 20)
        Me.tbHackrfIFGain.TabIndex = 0
        Me.tbHackrfIFGain.Text = "0"
        '
        'tbHackrfRate
        '
        Me.tbHackrfRate.Enabled = False
        Me.tbHackrfRate.Location = New System.Drawing.Point(135, 30)
        Me.tbHackrfRate.Name = "tbHackrfRate"
        Me.tbHackrfRate.Size = New System.Drawing.Size(100, 20)
        Me.tbHackrfRate.TabIndex = 0
        Me.tbHackrfRate.Text = "2600000"
        '
        'tbHackrfFreq
        '
        Me.tbHackrfFreq.Enabled = False
        Me.tbHackrfFreq.Location = New System.Drawing.Point(15, 30)
        Me.tbHackrfFreq.Name = "tbHackrfFreq"
        Me.tbHackrfFreq.Size = New System.Drawing.Size(100, 20)
        Me.tbHackrfFreq.TabIndex = 0
        Me.tbHackrfFreq.Text = "1575420000"
        '
        'bTransmit
        '
        Me.bTransmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTransmit.Location = New System.Drawing.Point(492, 541)
        Me.bTransmit.Name = "bTransmit"
        Me.bTransmit.Size = New System.Drawing.Size(75, 23)
        Me.bTransmit.TabIndex = 11
        Me.bTransmit.Text = "Transmit"
        Me.bTransmit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "RX/TX RF Amplifier"
        '
        'tbHackrfAmp
        '
        Me.tbHackrfAmp.Enabled = False
        Me.tbHackrfAmp.Location = New System.Drawing.Point(374, 30)
        Me.tbHackrfAmp.Name = "tbHackrfAmp"
        Me.tbHackrfAmp.Size = New System.Drawing.Size(100, 20)
        Me.tbHackrfAmp.TabIndex = 12
        Me.tbHackrfAmp.Text = "0"
        '
        'pbTransmit
        '
        Me.pbTransmit.Location = New System.Drawing.Point(15, 541)
        Me.pbTransmit.Name = "pbTransmit"
        Me.pbTransmit.Size = New System.Drawing.Size(471, 23)
        Me.pbTransmit.TabIndex = 12
        '
        'GpsSimForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 573)
        Me.Controls.Add(Me.pbTransmit)
        Me.Controls.Add(Me.bTransmit)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbDuration)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbFormat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbOutputFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbRinexFile)
        Me.Controls.Add(Me.bRun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GpsSimForm"
        Me.Text = "gps-sdr-sim-gui"
        Me.tpStaticMode.ResumeLayout(False)
        Me.tpStaticMode.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bRun As Button
    Friend WithEvents cbRinexFile As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFormat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDuration As ComboBox
    Friend WithEvents tpStaticMode As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbHgt As TextBox
    Friend WithEvents tbLon As TextBox
    Friend WithEvents tbLat As TextBox
    Friend WithEvents cbOutputFile As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbHackrfIFGain As TextBox
    Friend WithEvents tbHackrfRate As TextBox
    Friend WithEvents tbHackrfFreq As TextBox
    Friend WithEvents bTransmit As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents tbHackrfAmp As TextBox
    Friend WithEvents pbTransmit As ProgressBar
End Class
