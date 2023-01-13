'
' Created by SharpDevelop.
' User: benkel
' Date: 22.06.2016
' Time: 4:42 
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class dlg_NewPwd
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_Cancel = New GradientControls.GradientButton()
        Me.btn_OK = New GradientControls.GradientButton()
        Me.txt_NewPwd = New System.Windows.Forms.TextBox()
        Me.lbl_NewPwd = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Keypad = New TouchInput.KeyPad()
        Me.gp_Background = New GradientControls.GradientPanel()
        Me.txt_ConfirmPwd = New System.Windows.Forms.TextBox()
        Me.txt_OldPwd = New System.Windows.Forms.TextBox()
        Me.lbl_ConfirmPwd = New System.Windows.Forms.Label()
        Me.lbl_CurrentPwd = New System.Windows.Forms.Label()
        Me.gp_Message = New GradientControls.GradientPanel()
        Me.lbl_Message = New System.Windows.Forms.Label()
        Me.GradientPanel3 = New GradientControls.GradientPanel()
        Me.gp_Background.SuspendLayout()
        Me.gp_Message.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.btn_Cancel.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_Cancel.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_Cancel.Location = New System.Drawing.Point(536, 97)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Cancel.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Cancel.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Cancel.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Cancel.OuterBorder.Size = 1
        Me.btn_Cancel.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.btn_Cancel.Size = New System.Drawing.Size(113, 55)
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
        Me.btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_OK.Location = New System.Drawing.Point(536, 32)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_OK.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_OK.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_OK.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_OK.OuterBorder.Size = 1
        Me.btn_OK.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.btn_OK.Size = New System.Drawing.Size(113, 55)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "OK"
        Me.btn_OK.TextHandling = GradientControls.TextHandling.None
        Me.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'txt_NewPwd
        '
        Me.txt_NewPwd.BackColor = System.Drawing.Color.DarkGray
        Me.txt_NewPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_NewPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewPwd.Location = New System.Drawing.Point(196, 78)
        Me.txt_NewPwd.Name = "txt_NewPwd"
        Me.txt_NewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_NewPwd.Size = New System.Drawing.Size(332, 36)
        Me.txt_NewPwd.TabIndex = 5
        '
        'lbl_NewPwd
        '
        Me.lbl_NewPwd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NewPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_NewPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.74545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewPwd.ForeColor = System.Drawing.Color.Silver
        Me.lbl_NewPwd.Location = New System.Drawing.Point(5, 67)
        Me.lbl_NewPwd.Name = "lbl_NewPwd"
        Me.lbl_NewPwd.Size = New System.Drawing.Size(193, 50)
        Me.lbl_NewPwd.TabIndex = 10
        Me.lbl_NewPwd.Text = "New password:"
        Me.lbl_NewPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Keypad
        '
        Me.Keypad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Keypad.EditBox = Nothing
        Me.Keypad.Location = New System.Drawing.Point(15, 182)
        Me.Keypad.Name = "Keypad"
        Me.Keypad.Size = New System.Drawing.Size(629, 210)
        Me.Keypad.TabIndex = 9
        '
        'gp_Background
        '
        Me.gp_Background.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Background.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Background.Controls.Add(Me.txt_ConfirmPwd)
        Me.gp_Background.Controls.Add(Me.txt_OldPwd)
        Me.gp_Background.Controls.Add(Me.btn_OK)
        Me.gp_Background.Controls.Add(Me.btn_Cancel)
        Me.gp_Background.Controls.Add(Me.lbl_ConfirmPwd)
        Me.gp_Background.Controls.Add(Me.lbl_CurrentPwd)
        Me.gp_Background.Controls.Add(Me.gp_Message)
        Me.gp_Background.Controls.Add(Me.lbl_NewPwd)
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
        Me.gp_Background.Size = New System.Drawing.Size(660, 408)
        Me.gp_Background.TabIndex = 12
        Me.gp_Background.Text = Nothing
        Me.gp_Background.TextHandling = GradientControls.TextHandling.None
        '
        'txt_ConfirmPwd
        '
        Me.txt_ConfirmPwd.BackColor = System.Drawing.Color.DarkGray
        Me.txt_ConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ConfirmPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConfirmPwd.Location = New System.Drawing.Point(196, 115)
        Me.txt_ConfirmPwd.Name = "txt_ConfirmPwd"
        Me.txt_ConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ConfirmPwd.Size = New System.Drawing.Size(332, 36)
        Me.txt_ConfirmPwd.TabIndex = 14
        '
        'txt_OldPwd
        '
        Me.txt_OldPwd.BackColor = System.Drawing.Color.DarkGray
        Me.txt_OldPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_OldPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OldPwd.Location = New System.Drawing.Point(196, 32)
        Me.txt_OldPwd.Name = "txt_OldPwd"
        Me.txt_OldPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_OldPwd.Size = New System.Drawing.Size(333, 36)
        Me.txt_OldPwd.TabIndex = 12
        '
        'lbl_ConfirmPwd
        '
        Me.lbl_ConfirmPwd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ConfirmPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ConfirmPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.74545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConfirmPwd.ForeColor = System.Drawing.Color.Silver
        Me.lbl_ConfirmPwd.Location = New System.Drawing.Point(5, 111)
        Me.lbl_ConfirmPwd.Name = "lbl_ConfirmPwd"
        Me.lbl_ConfirmPwd.Size = New System.Drawing.Size(193, 37)
        Me.lbl_ConfirmPwd.TabIndex = 15
        Me.lbl_ConfirmPwd.Text = "Confirm password:"
        Me.lbl_ConfirmPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_CurrentPwd
        '
        Me.lbl_CurrentPwd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CurrentPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_CurrentPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.74545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CurrentPwd.ForeColor = System.Drawing.Color.Silver
        Me.lbl_CurrentPwd.Location = New System.Drawing.Point(6, 22)
        Me.lbl_CurrentPwd.Name = "lbl_CurrentPwd"
        Me.lbl_CurrentPwd.Size = New System.Drawing.Size(192, 50)
        Me.lbl_CurrentPwd.TabIndex = 13
        Me.lbl_CurrentPwd.Text = "Current password:"
        Me.lbl_CurrentPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gp_Message
        '
        Me.gp_Message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gp_Message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Message.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.gp_Message.Controls.Add(Me.lbl_Message)
        '
        '
        '
        Me.gp_Message.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Message.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Message.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Message.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Message.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Message.InnerBorder.Size = 1
        Me.gp_Message.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Message.Location = New System.Drawing.Point(8, 161)
        Me.gp_Message.Name = "gp_Message"
        Me.gp_Message.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Message.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Message.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Message.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Message.OuterBorder.Size = 1
        Me.gp_Message.OuterBorder.Type = GradientControls.Border.BorderType.Sunken
        Me.gp_Message.Size = New System.Drawing.Size(640, 16)
        Me.gp_Message.TabIndex = 11
        Me.gp_Message.Text = Nothing
        Me.gp_Message.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_Message
        '
        Me.lbl_Message.AutoSize = True
        Me.lbl_Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Message.ForeColor = System.Drawing.Color.Red
        Me.lbl_Message.Location = New System.Drawing.Point(1, 1)
        Me.lbl_Message.Name = "lbl_Message"
        Me.lbl_Message.Size = New System.Drawing.Size(0, 16)
        Me.lbl_Message.TabIndex = 0
        Me.lbl_Message.Visible = False
        '
        'GradientPanel3
        '
        Me.GradientPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.GradientPanel3.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.GradientPanel3.ContentAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradientPanel3.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.GradientPanel3.Image.TransparentKey = System.Drawing.Color.Empty
        Me.GradientPanel3.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.GradientPanel3.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.GradientPanel3.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.GradientPanel3.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.GradientPanel3.InnerBorder.Size = 1
        Me.GradientPanel3.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.GradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel3.Name = "GradientPanel3"
        Me.GradientPanel3.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.GradientPanel3.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.GradientPanel3.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.GradientPanel3.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.GradientPanel3.OuterBorder.Size = 1
        Me.GradientPanel3.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.GradientPanel3.Size = New System.Drawing.Size(660, 26)
        Me.GradientPanel3.TabIndex = 13
        Me.GradientPanel3.Text = "Change Password"
        Me.GradientPanel3.TextHandling = GradientControls.TextHandling.None
        '
        'dlg_NewPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(660, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.GradientPanel3)
        Me.Controls.Add(Me.txt_NewPwd)
        Me.Controls.Add(Me.Keypad)
        Me.Controls.Add(Me.gp_Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_NewPwd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gp_Background.ResumeLayout(False)
        Me.gp_Background.PerformLayout()
        Me.gp_Message.ResumeLayout(False)
        Me.gp_Message.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lbl_NewPwd As System.Windows.Forms.Label
    Private Keypad As TouchInput.KeyPad
    Private WithEvents txt_NewPwd As System.Windows.Forms.TextBox
    Private WithEvents btn_OK As GradientControls.GradientButton
    Private btn_Cancel As GradientControls.GradientButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gp_Background As GradientControls.GradientPanel
    Friend WithEvents gp_Message As GradientControls.GradientPanel
    Private WithEvents lbl_ConfirmPwd As Label
    Private WithEvents txt_ConfirmPwd As TextBox
    Private WithEvents lbl_CurrentPwd As Label
    Private WithEvents txt_OldPwd As TextBox
    Friend WithEvents lbl_Message As Label
    Friend WithEvents GradientPanel3 As GradientControls.GradientPanel
End Class
