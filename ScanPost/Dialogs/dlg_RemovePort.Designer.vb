<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_RemovePort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlg_RemovePort))
        Me.OK_Button = New GradientControls.GradientButton()
        Me.Cancel_Button = New GradientControls.GradientButton()
        Me.GradientPanel1 = New GradientControls.GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradientPanel2 = New GradientControls.GradientPanel()
        Me.GradientPanel3 = New GradientControls.GradientPanel()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.GradientPanel1.SuspendLayout()
        Me.GradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.OK_Button.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.OK_Button.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.OK_Button.Image.TransparentKey = System.Drawing.Color.Empty
        Me.OK_Button.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.OK_Button.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.OK_Button.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.OK_Button.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.OK_Button.InnerBorder.Size = 1
        Me.OK_Button.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.OK_Button.Location = New System.Drawing.Point(131, 133)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.OK_Button.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.OK_Button.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.OK_Button.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.OK_Button.OuterBorder.Size = 1
        Me.OK_Button.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Yes"
        Me.OK_Button.TextHandling = GradientControls.TextHandling.None
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.Cancel_Button.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Cancel_Button.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.Cancel_Button.Image.TransparentKey = System.Drawing.Color.Empty
        Me.Cancel_Button.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.Cancel_Button.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.Cancel_Button.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.Cancel_Button.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.Cancel_Button.InnerBorder.Size = 1
        Me.Cancel_Button.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.Cancel_Button.Location = New System.Drawing.Point(204, 133)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.Cancel_Button.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.Cancel_Button.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.Cancel_Button.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.Cancel_Button.OuterBorder.Size = 1
        Me.Cancel_Button.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "No"
        Me.Cancel_Button.TextHandling = GradientControls.TextHandling.None
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'GradientPanel1
        '
        Me.GradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.GradientPanel1.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.GradientPanel1.Controls.Add(Me.Label2)
        Me.GradientPanel1.Controls.Add(Me.Label1)
        Me.GradientPanel1.Controls.Add(Me.GradientPanel2)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.GradientPanel1.Image.TransparentKey = System.Drawing.Color.Empty
        Me.GradientPanel1.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.GradientPanel1.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.GradientPanel1.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.GradientPanel1.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.GradientPanel1.InnerBorder.Size = 1
        Me.GradientPanel1.InnerBorder.Type = GradientControls.Border.BorderType.Sunken
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 26)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.GradientPanel1.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.GradientPanel1.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.GradientPanel1.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.GradientPanel1.OuterBorder.Size = 1
        Me.GradientPanel1.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.GradientPanel1.Size = New System.Drawing.Size(283, 142)
        Me.GradientPanel1.TabIndex = 2
        Me.GradientPanel1.Text = Nothing
        Me.GradientPanel1.TextHandling = GradientControls.TextHandling.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(126, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "remove port? "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(126, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Do you want to"
        '
        'GradientPanel2
        '
        Me.GradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.GradientPanel2.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        '
        '
        Me.GradientPanel2.Image.BaseImage = CType(resources.GetObject("resource.BaseImage"), System.Drawing.Image)
        Me.GradientPanel2.Image.Scale.Enabled = True
        Me.GradientPanel2.Image.Scale.Height = 80
        Me.GradientPanel2.Image.Scale.Width = 65
        Me.GradientPanel2.Image.TransparentKey = System.Drawing.Color.Transparent
        Me.GradientPanel2.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.GradientPanel2.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.GradientPanel2.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.GradientPanel2.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.GradientPanel2.InnerBorder.Size = 1
        Me.GradientPanel2.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.GradientPanel2.Location = New System.Drawing.Point(8, 13)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.GradientPanel2.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.GradientPanel2.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.GradientPanel2.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.GradientPanel2.OuterBorder.Size = 1
        Me.GradientPanel2.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.GradientPanel2.Size = New System.Drawing.Size(104, 90)
        Me.GradientPanel2.TabIndex = 0
        Me.GradientPanel2.Text = Nothing
        Me.GradientPanel2.TextHandling = GradientControls.TextHandling.None
        '
        'GradientPanel3
        '
        Me.GradientPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.GradientPanel3.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.GradientPanel3.Controls.Add(Me.lbl_Title)
        Me.GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.GradientPanel3.Size = New System.Drawing.Size(283, 26)
        Me.GradientPanel3.TabIndex = 3
        Me.GradientPanel3.Text = Nothing
        Me.GradientPanel3.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.Silver
        Me.lbl_Title.Location = New System.Drawing.Point(3, 4)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(40, 18)
        Me.lbl_Title.TabIndex = 2
        Me.lbl_Title.Text = "Port"
        '
        'dlg_RemovePort
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(283, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.GradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_RemovePort"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        Me.GradientPanel3.ResumeLayout(False)
        Me.GradientPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As GradientControls.GradientButton
    Friend WithEvents Cancel_Button As GradientControls.GradientButton
    Friend WithEvents GradientPanel1 As GradientControls.GradientPanel
    Friend WithEvents GradientPanel2 As GradientControls.GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GradientPanel3 As GradientControls.GradientPanel
    Public WithEvents lbl_Title As Label

End Class
