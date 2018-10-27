Public Class Main_Frm
    Private Sub Main_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IO.File.WriteAllBytes(Application.StartupPath, My.Resources.MetroFramework)
        IO.File.WriteAllBytes(Application.StartupPath, My.Resources.MetroFramework_Design)
        IO.File.WriteAllBytes(Application.StartupPath, My.Resources.MetroFramework_Fonts)
    End Sub
End Class