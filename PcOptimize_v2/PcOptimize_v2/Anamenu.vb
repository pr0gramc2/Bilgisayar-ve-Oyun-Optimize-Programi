Imports System.IO
Imports System.Net
Imports System.Threading
Imports Microsoft.Win32
Public Class anamenu
    Private PerCounter As System.Diagnostics.PerformanceCounter
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim strSteamInstallPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
    ' Dim INI_File As New IniFile(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/programbilgi.ini"))
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32
    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4
    Dim tempclean As Thread
    Dim tempFolderPath As String = System.IO.Path.GetTempPath()
    Public IsFormLeft As Boolean
    Private Sub ramolcer_Tick(sender As Object, e As EventArgs) Handles ramolcer.Tick
        Try
            Dim sanalyer As Double
            sanalyer = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / 1048576 / 1048576
            Dim sanalyer1 As Long
            sanalyer1 = My.Computer.Info.AvailablePhysicalMemory * 100
            Dim mrt As Long
            mrt = Val(sanalyer1 / My.Computer.Info.TotalPhysicalMemory)
            ramkullaniliyor.Value = mrt
            'Label2.Text = "RAM: " & sanalyer.ToString("N") & " GB"

            Dim i As Integer = Integer.Parse(Format(PerCounter.NextValue, "##0"))
            cpuaney.Value = i
            'Label1.Text = "CPU: " & i & " %"

        Catch ex As Exception
            ramkullaniliyor.Value = 5
        End Try
    End Sub
    Private Sub anamenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pcoptimize.Close()
        'oyunprofilleri.Close()

        steamyer.Text = strSteamInstallPath
    End Sub
    Private Sub EmptyRecycleBin()
        Try
            SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION)
            SHUpdateRecycleBinIcon()
            'Geri Dönüşüm Kutusunun ne olduğunu açıklıyoruz
        Catch ex As Exception

        End Try
    End Sub
    Private Sub panelduyurukapat_Click(sender As Object, e As EventArgs) Handles panelduyurukapat.Click
        duyurukutusu.Visible = False
    End Sub
    Private Sub Anamenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Anamenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Anamenu_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub menuickapat_Click(sender As Object, e As EventArgs)
        'islemler.kapat()
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        ' islemler.kapat()
    End Sub
    Private Sub GirişYapToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm1Width As Integer = Me.Width

        ' giris.Show()
        'giris.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub
    Private Sub KayıtYapToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm1Width As Integer = Me.Width

        '  kayit.Show()
        'kayit.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub
    Private Sub loloptimizeislemi()
        '

    End Sub
    Private Sub kontrol_Tick(sender As Object, e As EventArgs) Handles kontrol.Tick
        '
    End Sub
    Private Sub oyunekle_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles oyunekle.FileOk
        TextBox1.Text = (System.IO.Path.GetFileNameWithoutExtension(oyunekle.FileName))
    End Sub
    Private Sub detayliramtemizlik_Tick(sender As Object, e As EventArgs) Handles detayliramtemizlik.Tick

    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        oyunekle.ShowDialog()
    End Sub
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub yukleme_Tick(sender As Object, e As EventArgs) Handles yukleme.Tick


    End Sub
    Private Sub uygulamasec_Click(sender As Object, e As EventArgs)
        yukleme.Enabled = True
        detayliramtemizlik.Enabled = True
    End Sub
    Private Sub kutusecim2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        hatakutusu.Visible = False
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        System.Diagnostics.Process.Start("https://www.globalklavye.com/pubg-fps-arttirma/")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://thatsgamebro.com/pubg-fps-arttirma-rehberi/")
    End Sub
    Private Sub listeyeoyunekletus_Click(sender As Object, e As EventArgs)
        oyunekle.ShowDialog()
    End Sub
    Private Sub oyunoptimize_Click(sender As Object, e As EventArgs)
        detayliramtemizlik.Enabled = True
        yukleme.Enabled = True
    End Sub
    Private Sub pubgbaslat_Click(sender As Object, e As EventArgs)
        Dim s As New Process

    End Sub
    Private Sub csgobaslat_Click(sender As Object, e As EventArgs)
        Dim s As New Process
        Me.Hide()
    End Sub
    Private Sub gta5baslat_Click(sender As Object, e As EventArgs)
        Dim s As New Process


        s.PriorityClass = ProcessPriorityClass.High

    End Sub
    Private Sub h1z1baslat_Click(sender As Object, e As EventArgs)
        Dim s As New Process

        s.PriorityClass = ProcessPriorityClass.High

    End Sub
    Private Sub rustbaslattus_Click(sender As Object, e As EventArgs)
        Dim s As New Process
        '
    End Sub
    Private Sub Oyunoptimizetus_Click(sender As Object, e As EventArgs) Handles Oyunoptimizetus.Click


    End Sub
    Private Sub anagiristusu_Click(sender As Object, e As EventArgs) Handles anagiristusu.Click

    End Sub
    Private Sub pubgoptimize_Click(sender As Object, e As EventArgs)
        '  islemler.PubgProfil()
    End Sub
    Private Sub csgooptimize_Click(sender As Object, e As EventArgs)
        ' islemler.CsgoProfil()
    End Sub
    Private Sub loloptimize_Click(sender As Object, e As EventArgs)
        ' islemler.lolprofil()
    End Sub
    Private Sub gta5_Click(sender As Object, e As EventArgs)
        '  islemler.Gta5profil()
    End Sub
    Private Sub h1z1optimize_Click(sender As Object, e As EventArgs)
        '  islemler.H1z1Profil()
    End Sub
    Private Sub rustoptimizetus_Click(sender As Object, e As EventArgs)
        '  islemler.RustProfil()
    End Sub
    Private Sub ayarlartusu_Click(sender As Object, e As EventArgs) Handles ayarlartusu.Click
    End Sub
    Private Sub HızlıOptimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HızlıOptimizeToolStripMenuItem.Click
        ' kucukikon.ShowBalloonTip(10, "Optimize tmm.", "Optimizasyon Tamamlandı. Güvendesin.", ToolTipIcon.Info)

    End Sub
    Private Sub BüyütToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BüyütToolStripMenuItem.Click
        '  Me.Show()
    End Sub
    Private Sub KüçültToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KüçültToolStripMenuItem1.Click
        Me.Hide()
    End Sub
    Private Sub KapatToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem2.Click
        ' islemler.kapat()
    End Sub
    Private Sub UzayadamiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UzayadamiToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/uzayadamicreative/")
    End Sub
    Private Sub OğuzhansunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OğuzhansunToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.twitch.tv/oguzhansun89")
    End Sub
    Private Sub GlobalKlavyeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalKlavyeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.globalklavye.com")
    End Sub
    Private Sub YoutubeKanalınaAboneOlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeKanalınaAboneOlToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.youtube.com/uzayadami")
    End Sub
    Private Sub SteamdekiRehbereYorumYAPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SteamdekiRehbereYorumYAPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://steamcommunity.com/sharedfiles/filedetails/?id=1170516116")
    End Sub
    Private Sub SteamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SteamToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://steamcommunity.com/sharedfiles/filedetails/?id=1170516116")
    End Sub
    Private Sub PingOptimizeHakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingOptimizeHakkındaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/pr0gramc2/pcoptimize/wiki/Ping-Optimize-Nasıl-Yapılır-%3F")
    End Sub
    Private Sub EngineiniHatasıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineiniHatasıToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/pr0gramc2/pcoptimize/wiki/Engine.ini-salt-okunur-hatası-alanlar-!")
    End Sub
    Private Sub WebSitemizToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WebSitemizToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("https://pr0gramc2.github.io/Bilgisayar-ve-Oyun-Optimize-Programi/")
    End Sub
    Private Sub OyunEklemeSorunuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OyunEklemeSorunuToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/pr0gramc2/Bilgisayar-ve-Oyun-Optimize-Programi/wiki/Oyun-Ekleme-Sorunu-!")
    End Sub
    Private Sub DizinBulunamadıSorunuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DizinBulunamadıSorunuToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/pr0gramc2/Bilgisayar-ve-Oyun-Optimize-Programi/wiki/H1Z1-ve-LOL-Optimize-Sorunu")
    End Sub
    Private Sub ÜcretsizDestekOLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://link.tl/1e6Xj")
    End Sub
    Private Sub ThatsitbroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThatsitbroToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://thatsgamebro.com/")
    End Sub
    Private Sub LinkKısaltmaKullanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkKısaltmaKullanToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://link.tl/1e6Xj")
    End Sub
    Private Sub KrediKartındanBağışYapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KrediKartındanBağışYapToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.bynogame.com/uzayadami")
    End Sub
    Private Sub SenindeİsminBurayaEklesinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SenindeİsminBurayaEklesinToolStripMenuItem.Click
        MsgBox("Bağış Yap Bölümünden Bağış yapmalısın şimdiden teşekkürler ^^")
    End Sub
    Private Sub DiscordSunucumuzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordSunucumuzToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://discord.gg/2WVN5Gt ")
    End Sub
    Private Sub ReferansımİleÜyeOlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferansımİleÜyeOlToolStripMenuItem.Click
    End Sub
    Private Sub KayıtOlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KayıtOlToolStripMenuItem.Click
        Dim frm1Width As Integer = Me.Width
        ' kayit.Show()
        ' kayit.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub
    Private Sub GirişYapToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GirişYapToolStripMenuItem1.Click
        Dim frm1Width As Integer = Me.Width
        ' giris.Show()
        ' giris.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim frm1Width As Integer = Me.Width
        ' giris.Show()
        ' giris.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim frm1Width As Integer = Me.Width
        ' kayit.Show()
        ' kayit.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        ' islemler.kapat()
    End Sub

    Private Sub ayarlarpanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pcoptimizetus_Click(sender As Object, e As EventArgs) Handles pcoptimizetus.Click
        pcoptimize.Show()


    End Sub
End Class


