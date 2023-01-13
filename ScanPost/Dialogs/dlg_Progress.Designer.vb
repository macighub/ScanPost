<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_Progress
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New GradientControls.GradientPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressMessage = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.ProgressMessage)
        Me.Panel1.Image.TransparentKey = System.Drawing.Color.Empty
        Me.Panel1.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.Panel1.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.Panel1.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.InnerBorder.Size = 1
        Me.Panel1.InnerBorder.Type = GradientControls.Border.BorderType.Sunken
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.Panel1.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.Panel1.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.OuterBorder.Size = 1
        Me.Panel1.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.Panel1.Size = New System.Drawing.Size(200, 50)
        Me.Panel1.TabIndex = 5
        Me.Panel1.TextHandling = GradientControls.TextHandling.None
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 26)
        Me.ProgressBar1.MarqueeAnimationSpeed = 25
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(180, 15)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        '
        'ProgressMessage
        '
        Me.ProgressMessage.AutoSize = True
        Me.ProgressMessage.BackColor = System.Drawing.Color.Transparent
        Me.ProgressMessage.ForeColor = System.Drawing.Color.Silver
        Me.ProgressMessage.Location = New System.Drawing.Point(12, 7)
        Me.ProgressMessage.Name = "ProgressMessage"
        Me.ProgressMessage.Size = New System.Drawing.Size(150, 13)
        Me.ProgressMessage.TabIndex = 0
        Me.ProgressMessage.Text = "Checking for available ports ..."
        '
        'dlg_Progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 50)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_Progress"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As GradientControls.GradientPanel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents ProgressMessage As System.Windows.Forms.Label

End Class
