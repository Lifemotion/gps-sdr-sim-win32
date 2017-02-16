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
        " -o" + cbOutputFile.text
        prc.Start()
    End Sub
End Class
