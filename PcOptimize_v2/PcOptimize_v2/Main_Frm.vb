Imports System.IO
Imports System.Net
Imports System.Threading
Imports MetroFramework
Imports Microsoft.Win32
Public Class Main_Frm
    Private PerCounter As System.Diagnostics.PerformanceCounter
    Dim strSteamInstallPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32
    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4
    Dim tempclean As Thread
    Dim tempFolderPath As String = System.IO.Path.GetTempPath()
    Dim ekrankarti As String = Application.StartupPath & "/tool/pcoptimizeboost.exe"
    Dim dns As String = Application.StartupPath & "/tool/dnspatch.bat"
    Dim modempatch As String = Application.StartupPath & "/tool/modempatch.bat"
    Dim gereksiz As String = Application.StartupPath & "/tool/gereksiz.bat"
    Private Sub Main_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ChbBestPerformence_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBestPerformence.CheckedChanged
        Try
            If ChbBestPerformence.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", "VisualFXSetting", "2")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", "VisualFXSetting", "1")
                ChbBestPerformence.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DetayliTemizlik_Tick(sender As Object, e As EventArgs) Handles DetayliTemizlik.Tick
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName(tbOutput.Text)
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("TslGame")

                Dim myprocess As Process
                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If

            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("chrome")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("Mozilla")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("Steam")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("Opera")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("csgo")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("h1z1")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("gtav")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
            DetayliTemizlik.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
    Private Sub EmptyRecycleBin()
        Try
            SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION)
            SHUpdateRecycleBinIcon()
        Catch ex As Exception
        End Try
    End Sub
    Sub clean()
        For Each filePath In Directory.GetFiles(tempFolderPath)
            Try
                File.Delete(filePath)
            Catch
            End Try
        Next
    End Sub
    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        Try
            tempclean = New System.Threading.Thread(AddressOf clean)
            tempclean.Start()
            DetayliTemizlik.Enabled = True
            EmptyRecycleBin()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub chbWebtarayıcısı_CheckedChanged(sender As Object, e As EventArgs) Handles chbWebtarayıcısı.CheckedChanged
        If chbWebtarayıcısı.Checked = True Then
            webtariyicioptimize.Enabled = True
        Else
            webtariyicioptimize.Enabled = False
        End If
    End Sub
    Private Sub webtariyicioptimize_Tick(sender As Object, e As EventArgs) Handles webtariyicioptimize.Tick
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("chrome")
                Dim myprocess As Process

                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess

            End If
        Catch ex As Exception
            Try
                GC.Collect()
                GC.WaitForPendingFinalizers()
                If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                    SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                    Dim myprocesses As Process() = Process.GetProcessesByName("opera")
                    Dim myprocess As Process

                    For Each myprocess In myprocesses
                        SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                    Next myprocess

                End If
            Catch ex1 As Exception
                Try
                    GC.Collect()
                    GC.WaitForPendingFinalizers()
                    If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                        Dim myprocesses As Process() = Process.GetProcessesByName("firefox")
                        Dim myprocess As Process

                        For Each myprocess In myprocesses
                            SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                        Next myprocess

                    End If
                Catch ex2 As Exception
                    chbWebtarayıcısı.Enabled = True
                End Try
            End Try
        End Try
    End Sub
    Private Sub oyunekle_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles oyunekle.FileOk
        tbOutput.Text = (System.IO.Path.GetFileNameWithoutExtension(oyunekle.FileName))
    End Sub
    Private Sub BtnOptimize_Click(sender As Object, e As EventArgs) Handles BtnOptimize.Click

        If BtnOptimize.Text = "Eklenini Optimize Et" Then
            DetayliTemizlik.Enabled = True
        Else
            oyunekle.Title = "Eklemek İstediğiniz Oyun/Program Seçiniz:"
            oyunekle.Filter = "Exe Dosyası|*.exe"
            oyunekle.ShowDialog()
            If tbOutput.Text = Nothing Then

            Else
                BtnOptimize.Text = "Eklenini Optimize Et"
                lbGames.Items.Add(tbOutput.Text)

            End If
        End If
    End Sub
    Private Sub lbGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbGames.SelectedIndexChanged

    End Sub
    Private Sub chbKucukEkran_CheckedChanged(sender As Object, e As EventArgs) Handles chbKucukEkran.CheckedChanged
        If chbKucukEkran.Checked = True Then
            EkranPerformans.Show()
        Else
            EkranPerformans.Close()

        End If
    End Sub
    Private Sub chbwebayarlari_CheckedChanged(sender As Object, e As EventArgs) Handles chbwebayarlari.CheckedChanged
        Try
            If chbwebayarlari.Checked = True Then
                Process.Start(modempatch)
                Process.Start(dns)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub chbDnstemizle_CheckedChanged(sender As Object, e As EventArgs) Handles chbDnstemizle.CheckedChanged
        Try
            If chbDnstemizle.Checked = True Then

                Process.Start(dns)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub chbPerformansmod_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerformansmod.CheckedChanged
        Try
            If chbPerformansmod.Checked = True Then
                Process.Start(ekrankarti)
            Else
                For Each islem As Process In Process.GetProcessesByName("pcoptimizeboost")
                    islem.CloseMainWindow()
                    islem.Kill()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub chbgereksizonbellek_CheckedChanged(sender As Object, e As EventArgs) Handles chbgereksizonbellek.CheckedChanged
        Try
            If chbgereksizonbellek.Checked = True Then
                Process.Start(gereksiz)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Async Sub İnternetvericekme_Tick(sender As Object, e As EventArgs) Handles internetvericekme.Tick
        Try

            If My.Computer.Network.IsAvailable = True Then
                Dim indirilen = Await DownloadAsync("https://www.dropbox.com/s/litiewnpc6q8tuw/Haberler.txt?dl=1")
                rtbNews.Text = indirilen
                internetvericekme.Enabled = False
            Else
                internetvericekme.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Async Function DownloadAsync(ByVal url As String) As Task(Of String)
        Dim client As WebClient = New WebClient()
        Dim indirilen = Await client.DownloadStringTaskAsync(New Uri(url))
        Return indirilen
    End Function

    Private Sub btnBaslat_Click(sender As Object, e As EventArgs) Handles btnBaslat.Click
        If lbGames.SelectedIndex = 0 Then
            Dim s As New Process
            s.StartInfo.FileName = "steam://rungameid/730"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
            s.Start()
            s.PriorityClass = ProcessPriorityClass.High
        End If
        If lbGames.SelectedIndex = 1 Then
            Dim s As New Process
            s.StartInfo.FileName = "steam://rungameid/578080"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
            s.Start()
            s.PriorityClass = ProcessPriorityClass.High
        End If
        If lbGames.SelectedIndex = 2 Then

        End If
        If lbGames.SelectedIndex = 3 Then
            Dim s As Process = New Process()
            s.StartInfo.FileName = "steam://rungameid/271590"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
        End If
        If lbGames.SelectedIndex = 4 Then
            Dim s As Process = New Process()
            s.StartInfo.FileName = "steam://rungameid/376870"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
        End If
        If lbGames.SelectedIndex = 5 Then
            Dim s As Process = New Process()
            s.StartInfo.FileName = "steam://rungameid/730"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
        End If
        If lbGames.SelectedIndex = 6 Then
            Dim s As Process = New Process()
            s.StartInfo.FileName = "steam://rungameid/252490"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
        End If
        If lbGames.SelectedIndex = 7 Then
            Dim s As Process = New Process()
            s.StartInfo.FileName = "steam://rungameid/433850"
            s.StartInfo.Arguments = "-malloc=system -USEALLAVAILABLECORES -high"
        End If
    End Sub

    Private Sub btnOptimizeEt_Click(sender As Object, e As EventArgs) Handles btnOptimizeEt.Click
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("TslGame")

                Dim myprocess As Process
                For Each myprocess In myprocesses
                    SetProcessWorkingSetSize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class