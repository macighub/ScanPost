<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_Password
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_Cancel = New GradientControls.GradientButton()
        Me.btn_OK = New GradientControls.GradientButton()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.tmr_TimeOut = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_TimeOut = New System.Windows.Forms.Panel()
        Me.gp_Background = New GradientControls.GradientPanel()
        Me.kp_Main = New TouchInput.KeyPad()
        Me.gp_TimeOut = New GradientControls.GradientPanel()
        Me.gp_Background.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.btn_Cancel.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_Cancel.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btn_Cancel.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.btn_Cancel.Image.TransparentKey = System.Drawing.Color.Empty
        Me.btn_Cancel.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Cancel.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Cancel.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Cancel.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Cancel.InnerBorder.Size = 1
        Me.btn_Cancel.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_Cancel.Location = New System.Drawing.Point(448, 10)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Cancel.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Cancel.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Cancel.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Cancel.OuterBorder.Size = 1
        Me.btn_Cancel.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.btn_Cancel.Size = New System.Drawing.Size(94, 34)
        Me.btn_Cancel.TabIndex = 7
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.TextHandling = GradientControls.TextHandling.None
        Me.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_OK
        '
        Me.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.btn_OK.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btn_OK.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.btn_OK.Image.TransparentKey = System.Drawing.Color.Empty
        Me.btn_OK.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.btn_OK.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_OK.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_OK.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_OK.InnerBorder.Size = 1
        Me.btn_OK.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_OK.Location = New System.Drawing.Point(548, 10)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_OK.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_OK.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_OK.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_OK.OuterBorder.Size = 1
        Me.btn_OK.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.btn_OK.Size = New System.Drawing.Size(94, 34)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "OK"
        Me.btn_OK.TextHandling = GradientControls.TextHandling.None
        Me.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.Silver
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.txt_Password.Location = New System.Drawing.Point(171, 9)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(270, 36)
        Me.txt_Password.TabIndex = 5
        '
        'lbl_Password
        '
        Me.lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.74545!)
        Me.lbl_Password.ForeColor = System.Drawing.Color.Silver
        Me.lbl_Password.Location = New System.Drawing.Point(5, 17)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(167, 25)
        Me.lbl_Password.TabIndex = 10
        Me.lbl_Password.Text = "Enter password:"
        Me.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmr_TimeOut
        '
        Me.tmr_TimeOut.Interval = 1000
        '
        'pnl_TimeOut
        '
        Me.pnl_TimeOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_TimeOut.BackColor = System.Drawing.Color.Lime
        Me.pnl_TimeOut.Location = New System.Drawing.Point(8, 52)
        Me.pnl_TimeOut.Name = "pnl_TimeOut"
        Me.pnl_TimeOut.Size = New System.Drawing.Size(634, 2)
        Me.pnl_TimeOut.TabIndex = 11
        '
        'gp_Background
        '
        Me.gp_Background.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Background.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Background.Controls.Add(Me.kp_Main)
        Me.gp_Background.Controls.Add(Me.gp_TimeOut)
        Me.gp_Background.Controls.Add(Me.lbl_Password)
        Me.gp_Background.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.gp_Background.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Background.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Background.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Background.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Background.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Background.InnerBorder.Size = 1
        Me.gp_Background.InnerBorder.Type = GradientControls.Border.BorderType.Raised
        Me.gp_Background.Location = New System.Drawing.Point(0, 0)
        Me.gp_Background.Name = "gp_Background"
        Me.gp_Background.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Background.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Background.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Background.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Background.OuterBorder.Size = 1
        Me.gp_Background.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.gp_Background.Size = New System.Drawing.Size(654, 282)
        Me.gp_Background.TabIndex = 12
        Me.gp_Background.Text = Nothing
        Me.gp_Background.TextHandling = GradientControls.TextHandling.None
        '
        'kp_Main
        '
        Me.kp_Main.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kp_Main.EditBox = Nothing
        Me.kp_Main.Location = New System.Drawing.Point(12, 62)
        Me.kp_Main.Name = "kp_Main"
        Me.kp_Main.Size = New System.Drawing.Size(629, 209)
        Me.kp_Main.TabIndex = 0
        '
        'gp_TimeOut
        '
        Me.gp_TimeOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gp_TimeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        '
        '
        '
        Me.gp_TimeOut.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_TimeOut.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_TimeOut.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_TimeOut.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_TimeOut.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_TimeOut.InnerBorder.Size = 1
        Me.gp_TimeOut.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_TimeOut.Location = New System.Drawing.Point(8, 51)
        Me.gp_TimeOut.Name = "gp_TimeOut"
        Me.gp_TimeOut.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_TimeOut.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_TimeOut.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_TimeOut.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_TimeOut.OuterBorder.Size = 1
        Me.gp_TimeOut.OuterBorder.Type = GradientControls.Border.BorderType.Sunken
        Me.gp_TimeOut.Size = New System.Drawing.Size(636, 4)
        Me.gp_TimeOut.TabIndex = 11
        Me.gp_TimeOut.Text = Nothing
        Me.gp_TimeOut.TextHandling = GradientControls.TextHandling.None
        '
        'dlg_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(654, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_TimeOut)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.gp_Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_Password"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gp_Background.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lbl_Password As System.Windows.Forms.Label
    Private WithEvents txt_Password As System.Windows.Forms.TextBox
    Private WithEvents btn_OK As GradientControls.GradientButton
    Private WithEvents btn_Cancel As GradientControls.GradientButton
    Friend WithEvents tmr_TimeOut As System.Windows.Forms.Timer
    Friend WithEvents pnl_TimeOut As System.Windows.Forms.Panel
    Friend WithEvents gp_Background As GradientControls.GradientPanel
    Friend WithEvents gp_TimeOut As GradientControls.GradientPanel
    Friend WithEvents kp_Main As TouchInput.KeyPad
End Class
