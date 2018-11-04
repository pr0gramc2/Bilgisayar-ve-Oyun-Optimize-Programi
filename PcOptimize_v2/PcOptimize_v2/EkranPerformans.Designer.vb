<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EkranPerformans
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ramknk = New System.Windows.Forms.Timer(Me.components)
        Me.ram = New System.Windows.Forms.ProgressBar()
        Me.cpu = New System.Windows.Forms.ProgressBar()
        Me.lblram = New MetroFramework.Controls.MetroLabel()
        Me.lblcpu = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'ramknk
        '
        Me.ramknk.Enabled = True
        Me.ramknk.Interval = 500
        '
        'ram
        '
        Me.ram.Location = New System.Drawing.Point(23, 42)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(300, 15)
        Me.ram.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ram.TabIndex = 0
        '
        'cpu
        '
        Me.cpu.Location = New System.Drawing.Point(23, 92)
        Me.cpu.Name = "cpu"
        Me.cpu.Size = New System.Drawing.Size(300, 15)
        Me.cpu.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cpu.TabIndex = 0
        '
        'lblram
        '
        Me.lblram.AutoSize = True
        Me.lblram.Location = New System.Drawing.Point(23, 16)
        Me.lblram.Name = "lblram"
        Me.lblram.Size = New System.Drawing.Size(0, 0)
        Me.lblram.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblram.TabIndex = 1
        Me.lblram.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblram.UseStyleColors = True
        '
        'lblcpu
        '
        Me.lblcpu.AutoSize = True
        Me.lblcpu.Location = New System.Drawing.Point(23, 66)
        Me.lblcpu.Name = "lblcpu"
        Me.lblcpu.Size = New System.Drawing.Size(0, 0)
        Me.lblcpu.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblcpu.TabIndex = 1
        Me.lblcpu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblcpu.UseStyleColors = True
        '
        'EkranPerformans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 131)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblcpu)
        Me.Controls.Add(Me.lblram)
        Me.Controls.Add(Me.cpu)
        Me.Controls.Add(Me.ram)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DisplayHeader = False
        Me.Name = "EkranPerformans"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Performans Ölçüm"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ramknk As Timer
    Friend WithEvents ram As ProgressBar
    Friend WithEvents cpu As ProgressBar
    Friend WithEvents lblram As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblcpu As MetroFramework.Controls.MetroLabel
End Class
