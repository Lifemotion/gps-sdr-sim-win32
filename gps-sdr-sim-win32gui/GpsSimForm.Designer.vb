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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbLat = New System.Windows.Forms.TextBox()
        Me.tbLon = New System.Windows.Forms.TextBox()
        Me.tbHgt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbOutputFile = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tpStaticMode.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bRun
        '
        Me.bRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRun.Location = New System.Drawing.Point(497, 310)
        Me.bRun.Name = "bRun"
        Me.bRun.Size = New System.Drawing.Size(75, 23)
        Me.bRun.TabIndex = 0
        Me.bRun.Text = "Run"
        Me.bRun.UseVisualStyleBackColor = True
        '
        'cbRinexFile
        '
        Me.cbRinexFile.FormattingEnabled = True
        Me.cbRinexFile.Location = New System.Drawing.Point(170, 15)
        Me.cbRinexFile.Name = "cbRinexFile"
        Me.cbRinexFile.Size = New System.Drawing.Size(121, 21)
        Me.cbRinexFile.TabIndex = 1
        Me.cbRinexFile.Text = "brdc3540.14n"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RINEX navigation file (-e)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "I\Q Data Fromat (-b)"
        '
        'cbFormat
        '
        Me.cbFormat.FormattingEnabled = True
        Me.cbFormat.Items.AddRange(New Object() {"1", "8", "16"})
        Me.cbFormat.Location = New System.Drawing.Point(170, 43)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(121, 21)
        Me.cbFormat.TabIndex = 3
        Me.cbFormat.Text = "8"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Duration, seconds (-d)"
        '
        'cbDuration
        '
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"300"})
        Me.cbDuration.Location = New System.Drawing.Point(170, 70)
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
        Me.tpStaticMode.Size = New System.Drawing.Size(549, 178)
        Me.tpStaticMode.TabIndex = 0
        Me.tpStaticMode.Text = "Static Mode (-l)"
        Me.tpStaticMode.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpStaticMode)
        Me.TabControl1.Location = New System.Drawing.Point(15, 97)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(557, 204)
        Me.TabControl1.TabIndex = 9
        '
        'tbLat
        '
        Me.tbLat.Location = New System.Drawing.Point(19, 35)
        Me.tbLat.Name = "tbLat"
        Me.tbLat.Size = New System.Drawing.Size(100, 20)
        Me.tbLat.TabIndex = 0
        Me.tbLat.Text = "30.000000"
        '
        'tbLon
        '
        Me.tbLon.Location = New System.Drawing.Point(139, 35)
        Me.tbLon.Name = "tbLon"
        Me.tbLon.Size = New System.Drawing.Size(100, 20)
        Me.tbLon.TabIndex = 0
        Me.tbLon.Text = "60.000000"
        '
        'tbHgt
        '
        Me.tbHgt.Location = New System.Drawing.Point(258, 35)
        Me.tbHgt.Name = "tbHgt"
        Me.tbHgt.Size = New System.Drawing.Size(100, 20)
        Me.tbHgt.TabIndex = 0
        Me.tbHgt.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Latitude"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Longitude"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Height"
        '
        'cbOutputFile
        '
        Me.cbOutputFile.FormattingEnabled = True
        Me.cbOutputFile.Location = New System.Drawing.Point(455, 15)
        Me.cbOutputFile.Name = "cbOutputFile"
        Me.cbOutputFile.Size = New System.Drawing.Size(121, 21)
        Me.cbOutputFile.TabIndex = 1
        Me.cbOutputFile.Text = "gpssim.bin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Output File"
        '
        'GpsSimForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 345)
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
End Class
