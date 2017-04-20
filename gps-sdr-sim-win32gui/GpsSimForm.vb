Public Class GpsSimForm
    Private Sub bRun_Click(sender As Object, e As EventArgs) Handles bRun.Click
        Dim prc As New Process()
        prc.StartInfo.WorkingDirectory = Application.StartupPath
        prc.StartInfo.FileName = IO.Path.Combine(Application.StartupPath, "gps-sdr-sim.exe")
        prc.StartInfo.UseShellExecute = False
        prc.StartInfo.Arguments =
                                                "-e " + cbRinexFile.Text +
                                                " -l " + tbLat.Text + "," + tbLon.Text + "," + tbHgt.Text +
                                                " -b" + cbFormat.Text +
                                                " -d" + cbDuration.Text +
                                                " -o" + cbOutputFile.Text
        Dim thr As New Threading.Thread(Sub()
                                            Me.Invoke(Sub() bRun.Enabled = False)

                                            prc.Start()
                                            prc.WaitForExit()
                                            Me.Invoke(Sub() bRun.Enabled = True)
                                        End Sub)
        thr.Start()
    End Sub

    Private Sub bTransmit_Click(sender As Object, e As EventArgs) Handles bTransmit.Click
        If IO.File.Exists(cbOutputFile.Text) Then
            Dim fi = New IO.FileInfo(cbOutputFile.Text)
            Dim secs = fi.Length / Val(tbHackrfRate.Text) / 2 + 1
            Dim prc As New Process()
            prc.StartInfo.WorkingDirectory = Application.StartupPath
            prc.StartInfo.FileName = IO.Path.Combine(Application.StartupPath, "hackrf\hackrf_transfer.exe")
            prc.StartInfo.UseShellExecute = False
            prc.StartInfo.Arguments =
                                                    "-t " + cbOutputFile.Text +
                                                    " -f " + tbHackrfFreq.Text +
                                                    " -s " + tbHackrfRate.Text +
                                                    " -x " + tbHackrfIFGain.Text +
                                                    " -a " + tbHackrfAmp.Text
            Dim thr As New Threading.Thread(Sub()
                                                Me.Invoke(Sub()
                                                              bTransmit.Enabled = False
                                                              pbTransmit.Visible = True
                                                          End Sub)
                                                prc.Start()
                                                prc.WaitForExit()
                                                Me.Invoke(Sub()
                                                              bTransmit.Enabled = True
                                                              pbTransmit.Visible = False
                                                          End Sub)
                                            End Sub)
            thr.Start()
            pbTransmit.Maximum = secs
            pbTransmit.Value = 0
            Dim progress As New Threading.Thread(Sub()
                                                     Dim sec As Integer
                                                     Do
                                                         Threading.Thread.Sleep(1000)
                                                         Me.Invoke(Sub()
                                                                       If pbTransmit.Visible = False Then progress.Abort()
                                                                       If sec <= pbTransmit.Maximum Then pbTransmit.Value = sec
                                                                   End Sub)
                                                         sec += 1
                                                     Loop
                                                 End Sub)
            progress.Start()
        Else
            MsgBox("Signal File not found. You must generate it first.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
