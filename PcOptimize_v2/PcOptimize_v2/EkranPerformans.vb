Imports MetroFramework
Public Class EkranPerformans
    Private PerCounter As System.Diagnostics.PerformanceCounter
    Private Sub EkranPerformans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PerCounter = New System.Diagnostics.PerformanceCounter
            PerCounter.CategoryName = "Processor"
            PerCounter.CounterName = "% Processor Time"
            PerCounter.InstanceName = "_Total"
            Me.Visible = True
            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width
            y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

            Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
                x = x - 1
                Me.Location = New Point(x, y)
            Loop
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ramknk_Tick(sender As Object, e As EventArgs) Handles ramknk.Tick
        Try
            Dim sanalyer As Double
            sanalyer = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / 1048576 / 1024
            Dim sanalyer1 As Long
            sanalyer1 = My.Computer.Info.AvailablePhysicalMemory * 100
            Dim mrt As Long
            mrt = Val(sanalyer1 / My.Computer.Info.TotalPhysicalMemory)
            ram.Value = mrt
            lblram.Text = "RAM: " & sanalyer.ToString("N") & " GB"
            Dim i As Integer = Integer.Parse(Format(PerCounter.NextValue, "##0"))
            cpu.Value = i
            lblcpu.Text = "CPU: " & i & " %"
        Catch ex As Exception
        End Try
    End Sub
End Class