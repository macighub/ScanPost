<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_AddPort
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
        Me.OK_Button = New GradientControls.GradientButton()
        Me.Cancel_Button = New GradientControls.GradientButton()
        Me.pnl_AddPort = New GradientControls.GradientPanel()
        Me.pnl_StopBits = New System.Windows.Forms.Panel()
        Me.cb_StopBits = New System.Windows.Forms.ComboBox()
        Me.gp_StopBits = New GradientControls.GradientPanel()
        Me.lbl_StopBits = New System.Windows.Forms.Label()
        Me.pnl_DataBits = New System.Windows.Forms.Panel()
        Me.cb_DataBits = New System.Windows.Forms.ComboBox()
        Me.gp_DataBits = New GradientControls.GradientPanel()
        Me.lbl_DataBits = New System.Windows.Forms.Label()
        Me.pnl_Parity = New System.Windows.Forms.Panel()
        Me.cb_Parity = New System.Windows.Forms.ComboBox()
        Me.gp_Parity = New GradientControls.GradientPanel()
        Me.lbl_Parity = New System.Windows.Forms.Label()
        Me.pnl_BaudRate = New System.Windows.Forms.Panel()
        Me.cb_BaudRate = New System.Windows.Forms.ComboBox()
        Me.gp_BaudRate = New GradientControls.GradientPanel()
        Me.lbl_BaudRate = New System.Windows.Forms.Label()
        Me.pnl_Port = New System.Windows.Forms.Panel()
        Me.cb_Port = New System.Windows.Forms.ComboBox()
        Me.gp_Port = New GradientControls.GradientPanel()
        Me.lbl_Port = New System.Windows.Forms.Label()
        Me.pnl_iD = New System.Windows.Forms.Panel()
        Me.PortID = New System.Windows.Forms.TextBox()
        Me.gp_ID = New GradientControls.GradientPanel()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.pnl_Dialog = New GradientControls.GradientPanel()
        Me.bw_Progress = New System.ComponentModel.BackgroundWorker()
        Me.gp_Title = New GradientControls.GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_AddPort.SuspendLayout()
        Me.pnl_StopBits.SuspendLayout()
        Me.gp_StopBits.SuspendLayout()
        Me.pnl_DataBits.SuspendLayout()
        Me.gp_DataBits.SuspendLayout()
        Me.pnl_Parity.SuspendLayout()
        Me.gp_Parity.SuspendLayout()
        Me.pnl_BaudRate.SuspendLayout()
        Me.gp_BaudRate.SuspendLayout()
        Me.pnl_Port.SuspendLayout()
        Me.gp_Port.SuspendLayout()
        Me.pnl_iD.SuspendLayout()
        Me.gp_ID.SuspendLayout()
        Me.pnl_Dialog.SuspendLayout()
        Me.gp_Title.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.OK_Button.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
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
        Me.OK_Button.Location = New System.Drawing.Point(203, 6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.OK_Button.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.OK_Button.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.OK_Button.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.OK_Button.OuterBorder.Size = 1
        Me.OK_Button.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Add"
        Me.OK_Button.TextHandling = GradientControls.TextHandling.None
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.Cancel_Button.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.Cancel_Button.Location = New System.Drawing.Point(276, 6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.Cancel_Button.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.Cancel_Button.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.Cancel_Button.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.Cancel_Button.OuterBorder.Size = 1
        Me.Cancel_Button.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.TextHandling = GradientControls.TextHandling.None
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'pnl_AddPort
        '
        Me.pnl_AddPort.BackColor = System.Drawing.Color.Gray
        Me.pnl_AddPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_AddPort.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_AddPort.Controls.Add(Me.pnl_StopBits)
        Me.pnl_AddPort.Controls.Add(Me.pnl_DataBits)
        Me.pnl_AddPort.Controls.Add(Me.pnl_Parity)
        Me.pnl_AddPort.Controls.Add(Me.pnl_BaudRate)
        Me.pnl_AddPort.Controls.Add(Me.pnl_Port)
        Me.pnl_AddPort.Controls.Add(Me.pnl_iD)
        Me.pnl_AddPort.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.pnl_AddPort.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_AddPort.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_AddPort.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_AddPort.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_AddPort.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_AddPort.InnerBorder.Size = 2
        Me.pnl_AddPort.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_AddPort.Location = New System.Drawing.Point(0, 31)
        Me.pnl_AddPort.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_AddPort.Name = "pnl_AddPort"
        Me.pnl_AddPort.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_AddPort.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_AddPort.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_AddPort.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_AddPort.OuterBorder.Size = 2
        Me.pnl_AddPort.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_AddPort.Size = New System.Drawing.Size(355, 138)
        Me.pnl_AddPort.TabIndex = 1
        Me.pnl_AddPort.Text = Nothing
        Me.pnl_AddPort.TextHandling = GradientControls.TextHandling.None
        '
        'pnl_StopBits
        '
        Me.pnl_StopBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_StopBits.Controls.Add(Me.cb_StopBits)
        Me.pnl_StopBits.Controls.Add(Me.gp_StopBits)
        Me.pnl_StopBits.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_StopBits.Location = New System.Drawing.Point(0, 115)
        Me.pnl_StopBits.Name = "pnl_StopBits"
        Me.pnl_StopBits.Size = New System.Drawing.Size(355, 23)
        Me.pnl_StopBits.TabIndex = 6
        '
        'cb_StopBits
        '
        Me.cb_StopBits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_StopBits.FormattingEnabled = True
        Me.cb_StopBits.Items.AddRange(New Object() {"One", "Two", "OnePointFive"})
        Me.cb_StopBits.Location = New System.Drawing.Point(63, 0)
        Me.cb_StopBits.Name = "cb_StopBits"
        Me.cb_StopBits.Size = New System.Drawing.Size(290, 21)
        Me.cb_StopBits.TabIndex = 2
        '
        'gp_StopBits
        '
        Me.gp_StopBits.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_StopBits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_StopBits.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_StopBits.Controls.Add(Me.lbl_StopBits)
        Me.gp_StopBits.Dock = System.Windows.Forms.DockStyle.Left
        '
        '
        '
        Me.gp_StopBits.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_StopBits.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_StopBits.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_StopBits.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_StopBits.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_StopBits.InnerBorder.Size = 1
        Me.gp_StopBits.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_StopBits.Location = New System.Drawing.Point(0, 0)
        Me.gp_StopBits.Name = "gp_StopBits"
        Me.gp_StopBits.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_StopBits.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_StopBits.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_StopBits.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_StopBits.OuterBorder.Size = 1
        Me.gp_StopBits.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_StopBits.Size = New System.Drawing.Size(63, 21)
        Me.gp_StopBits.TabIndex = 10
        Me.gp_StopBits.Text = Nothing
        Me.gp_StopBits.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_StopBits
        '
        Me.lbl_StopBits.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StopBits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_StopBits.ForeColor = System.Drawing.Color.Silver
        Me.lbl_StopBits.Location = New System.Drawing.Point(0, 0)
        Me.lbl_StopBits.Name = "lbl_StopBits"
        Me.lbl_StopBits.Size = New System.Drawing.Size(63, 21)
        Me.lbl_StopBits.TabIndex = 1
        Me.lbl_StopBits.Text = "Stop Bits:"
        Me.lbl_StopBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_DataBits
        '
        Me.pnl_DataBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_DataBits.Controls.Add(Me.cb_DataBits)
        Me.pnl_DataBits.Controls.Add(Me.gp_DataBits)
        Me.pnl_DataBits.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_DataBits.Location = New System.Drawing.Point(0, 92)
        Me.pnl_DataBits.Name = "pnl_DataBits"
        Me.pnl_DataBits.Size = New System.Drawing.Size(355, 23)
        Me.pnl_DataBits.TabIndex = 5
        '
        'cb_DataBits
        '
        Me.cb_DataBits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_DataBits.FormattingEnabled = True
        Me.cb_DataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cb_DataBits.Location = New System.Drawing.Point(63, 0)
        Me.cb_DataBits.Name = "cb_DataBits"
        Me.cb_DataBits.Size = New System.Drawing.Size(290, 21)
        Me.cb_DataBits.TabIndex = 2
        '
        'gp_DataBits
        '
        Me.gp_DataBits.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_DataBits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_DataBits.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_DataBits.Controls.Add(Me.lbl_DataBits)
        Me.gp_DataBits.Dock = System.Windows.Forms.DockStyle.Left
        '
        '
        '
        Me.gp_DataBits.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_DataBits.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_DataBits.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_DataBits.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_DataBits.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_DataBits.InnerBorder.Size = 1
        Me.gp_DataBits.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_DataBits.Location = New System.Drawing.Point(0, 0)
        Me.gp_DataBits.Name = "gp_DataBits"
        Me.gp_DataBits.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_DataBits.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_DataBits.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_DataBits.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_DataBits.OuterBorder.Size = 1
        Me.gp_DataBits.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_DataBits.Size = New System.Drawing.Size(63, 21)
        Me.gp_DataBits.TabIndex = 10
        Me.gp_DataBits.Text = Nothing
        Me.gp_DataBits.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_DataBits
        '
        Me.lbl_DataBits.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DataBits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_DataBits.ForeColor = System.Drawing.Color.Silver
        Me.lbl_DataBits.Location = New System.Drawing.Point(0, 0)
        Me.lbl_DataBits.Name = "lbl_DataBits"
        Me.lbl_DataBits.Size = New System.Drawing.Size(63, 21)
        Me.lbl_DataBits.TabIndex = 1
        Me.lbl_DataBits.Text = "Data Bits:"
        Me.lbl_DataBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Parity
        '
        Me.pnl_Parity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Parity.Controls.Add(Me.cb_Parity)
        Me.pnl_Parity.Controls.Add(Me.gp_Parity)
        Me.pnl_Parity.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Parity.Location = New System.Drawing.Point(0, 69)
        Me.pnl_Parity.Name = "pnl_Parity"
        Me.pnl_Parity.Size = New System.Drawing.Size(355, 23)
        Me.pnl_Parity.TabIndex = 4
        '
        'cb_Parity
        '
        Me.cb_Parity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Parity.FormattingEnabled = True
        Me.cb_Parity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cb_Parity.Location = New System.Drawing.Point(63, 0)
        Me.cb_Parity.Name = "cb_Parity"
        Me.cb_Parity.Size = New System.Drawing.Size(290, 21)
        Me.cb_Parity.TabIndex = 2
        '
        'gp_Parity
        '
        Me.gp_Parity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Parity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Parity.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Parity.Controls.Add(Me.lbl_Parity)
        Me.gp_Parity.Dock = System.Windows.Forms.DockStyle.Left
        '
        '
        '
        Me.gp_Parity.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Parity.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Parity.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Parity.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Parity.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Parity.InnerBorder.Size = 1
        Me.gp_Parity.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Parity.Location = New System.Drawing.Point(0, 0)
        Me.gp_Parity.Name = "gp_Parity"
        Me.gp_Parity.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Parity.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Parity.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Parity.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Parity.OuterBorder.Size = 1
        Me.gp_Parity.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Parity.Size = New System.Drawing.Size(63, 21)
        Me.gp_Parity.TabIndex = 10
        Me.gp_Parity.Text = Nothing
        Me.gp_Parity.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_Parity
        '
        Me.lbl_Parity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Parity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Parity.ForeColor = System.Drawing.Color.Silver
        Me.lbl_Parity.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Parity.Name = "lbl_Parity"
        Me.lbl_Parity.Size = New System.Drawing.Size(63, 21)
        Me.lbl_Parity.TabIndex = 1
        Me.lbl_Parity.Text = "Parity:"
        Me.lbl_Parity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_BaudRate
        '
        Me.pnl_BaudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_BaudRate.Controls.Add(Me.cb_BaudRate)
        Me.pnl_BaudRate.Controls.Add(Me.gp_BaudRate)
        Me.pnl_BaudRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_BaudRate.Location = New System.Drawing.Point(0, 46)
        Me.pnl_BaudRate.Name = "pnl_BaudRate"
        Me.pnl_BaudRate.Size = New System.Drawing.Size(355, 23)
        Me.pnl_BaudRate.TabIndex = 3
        '
        'cb_BaudRate
        '
        Me.cb_BaudRate.BackColor = System.Drawing.Color.Gray
        Me.cb_BaudRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_BaudRate.FormattingEnabled = True
        Me.cb_BaudRate.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200", "128000", "256000"})
        Me.cb_BaudRate.Location = New System.Drawing.Point(63, 0)
        Me.cb_BaudRate.Name = "cb_BaudRate"
        Me.cb_BaudRate.Size = New System.Drawing.Size(290, 21)
        Me.cb_BaudRate.TabIndex = 2
        '
        'gp_BaudRate
        '
        Me.gp_BaudRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_BaudRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_BaudRate.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_BaudRate.Controls.Add(Me.lbl_BaudRate)
        Me.gp_BaudRate.Dock = System.Windows.Forms.DockStyle.Left
        '
        '
        '
        Me.gp_BaudRate.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_BaudRate.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_BaudRate.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_BaudRate.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_BaudRate.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_BaudRate.InnerBorder.Size = 1
        Me.gp_BaudRate.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_BaudRate.Location = New System.Drawing.Point(0, 0)
        Me.gp_BaudRate.Name = "gp_BaudRate"
        Me.gp_BaudRate.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_BaudRate.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_BaudRate.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_BaudRate.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_BaudRate.OuterBorder.Size = 1
        Me.gp_BaudRate.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_BaudRate.Size = New System.Drawing.Size(63, 21)
        Me.gp_BaudRate.TabIndex = 10
        Me.gp_BaudRate.Text = Nothing
        Me.gp_BaudRate.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_BaudRate
        '
        Me.lbl_BaudRate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BaudRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_BaudRate.ForeColor = System.Drawing.Color.Silver
        Me.lbl_BaudRate.Location = New System.Drawing.Point(0, 0)
        Me.lbl_BaudRate.Name = "lbl_BaudRate"
        Me.lbl_BaudRate.Size = New System.Drawing.Size(63, 21)
        Me.lbl_BaudRate.TabIndex = 1
        Me.lbl_BaudRate.Text = "Baud Rate:"
        Me.lbl_BaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Port
        '
        Me.pnl_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Port.Controls.Add(Me.cb_Port)
        Me.pnl_Port.Controls.Add(Me.gp_Port)
        Me.pnl_Port.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Port.Location = New System.Drawing.Point(0, 23)
        Me.pnl_Port.Name = "pnl_Port"
        Me.pnl_Port.Size = New System.Drawing.Size(355, 23)
        Me.pnl_Port.TabIndex = 7
        '
        'cb_Port
        '
        Me.cb_Port.BackColor = System.Drawing.SystemColors.Window
        Me.cb_Port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Port.FormattingEnabled = True
        Me.cb_Port.Location = New System.Drawing.Point(63, 0)
        Me.cb_Port.Margin = New System.Windows.Forms.Padding(0)
        Me.cb_Port.Name = "cb_Port"
        Me.cb_Port.Size = New System.Drawing.Size(290, 21)
        Me.cb_Port.TabIndex = 2
        '
        'gp_Port
        '
        Me.gp_Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Port.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Port.Controls.Add(Me.lbl_Port)
        Me.gp_Port.Dock = System.Windows.Forms.DockStyle.Left
        '
        '
        '
        Me.gp_Port.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Port.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Port.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Port.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Port.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Port.InnerBorder.Size = 1
        Me.gp_Port.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Port.Location = New System.Drawing.Point(0, 0)
        Me.gp_Port.Name = "gp_Port"
        Me.gp_Port.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Port.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Port.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Port.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Port.OuterBorder.Size = 1
        Me.gp_Port.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Port.Size = New System.Drawing.Size(63, 21)
        Me.gp_Port.TabIndex = 10
        Me.gp_Port.Text = Nothing
        Me.gp_Port.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_Port
        '
        Me.lbl_Port.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Port.ForeColor = System.Drawing.Color.Silver
        Me.lbl_Port.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Port.Name = "lbl_Port"
        Me.lbl_Port.Size = New System.Drawing.Size(63, 21)
        Me.lbl_Port.TabIndex = 1
        Me.lbl_Port.Text = "Port:"
        Me.lbl_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_iD
        '
        Me.pnl_iD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_iD.Controls.Add(Me.PortID)
        Me.pnl_iD.Controls.Add(Me.gp_ID)
        Me.pnl_iD.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_iD.Location = New System.Drawing.Point(0, 0)
        Me.pnl_iD.Name = "pnl_iD"
        Me.pnl_iD.Size = New System.Drawing.Size(355, 23)
        Me.pnl_iD.TabIndex = 8
        '
        'PortID
        '
        Me.PortID.BackColor = System.Drawing.SystemColors.Window
        Me.PortID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PortID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PortID.Location = New System.Drawing.Point(63, 0)
        Me.PortID.Margin = New System.Windows.Forms.Padding(0)
        Me.PortID.Name = "PortID"
        Me.PortID.Size = New System.Drawing.Size(290, 20)
        Me.PortID.TabIndex = 2
        '
        'gp_ID
        '
        Me.gp_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_ID.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_ID.Controls.Add(Me.lbl_ID)
        Me.gp_ID.Dock = System.Windows.Forms.DockStyle.Left
        '
        '
        '
        Me.gp_ID.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_ID.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_ID.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_ID.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_ID.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_ID.InnerBorder.Size = 1
        Me.gp_ID.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_ID.Location = New System.Drawing.Point(0, 0)
        Me.gp_ID.Name = "gp_ID"
        Me.gp_ID.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_ID.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_ID.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_ID.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_ID.OuterBorder.Size = 1
        Me.gp_ID.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_ID.Size = New System.Drawing.Size(63, 21)
        Me.gp_ID.TabIndex = 3
        Me.gp_ID.Text = Nothing
        Me.gp_ID.TextHandling = GradientControls.TextHandling.None
        '
        'lbl_ID
        '
        Me.lbl_ID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_ID.ForeColor = System.Drawing.Color.Silver
        Me.lbl_ID.Location = New System.Drawing.Point(0, 0)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(63, 21)
        Me.lbl_ID.TabIndex = 1
        Me.lbl_ID.Text = "ID:"
        Me.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Dialog
        '
        Me.pnl_Dialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_Dialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_Dialog.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_Dialog.Controls.Add(Me.Cancel_Button)
        Me.pnl_Dialog.Controls.Add(Me.OK_Button)
        Me.pnl_Dialog.Dock = System.Windows.Forms.DockStyle.Bottom
        '
        '
        '
        Me.pnl_Dialog.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_Dialog.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Dialog.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Dialog.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Dialog.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Dialog.InnerBorder.Size = 1
        Me.pnl_Dialog.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Dialog.Location = New System.Drawing.Point(0, 169)
        Me.pnl_Dialog.Name = "pnl_Dialog"
        Me.pnl_Dialog.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Dialog.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Dialog.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Dialog.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Dialog.OuterBorder.Size = 1
        Me.pnl_Dialog.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Dialog.Size = New System.Drawing.Size(355, 37)
        Me.pnl_Dialog.TabIndex = 2
        Me.pnl_Dialog.Text = Nothing
        Me.pnl_Dialog.TextHandling = GradientControls.TextHandling.None
        '
        'bw_Progress
        '
        '
        'gp_Title
        '
        Me.gp_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Title.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Title.Controls.Add(Me.Label1)
        Me.gp_Title.Dock = System.Windows.Forms.DockStyle.Top
        '
        '
        '
        Me.gp_Title.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Title.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Title.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Title.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Title.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Title.InnerBorder.Size = 1
        Me.gp_Title.InnerBorder.Type = GradientControls.Border.BorderType.Raised
        Me.gp_Title.Location = New System.Drawing.Point(0, 0)
        Me.gp_Title.Name = "gp_Title"
        Me.gp_Title.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Title.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Title.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Title.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Title.OuterBorder.Size = 1
        Me.gp_Title.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Title.Size = New System.Drawing.Size(355, 31)
        Me.gp_Title.TabIndex = 3
        Me.gp_Title.Text = Nothing
        Me.gp_Title.TextHandling = GradientControls.TextHandling.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Scanner Port"
        '
        'dlg_AddPort
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(355, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_AddPort)
        Me.Controls.Add(Me.pnl_Dialog)
        Me.Controls.Add(Me.gp_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_AddPort"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.pnl_AddPort.ResumeLayout(False)
        Me.pnl_StopBits.ResumeLayout(False)
        Me.gp_StopBits.ResumeLayout(False)
        Me.pnl_DataBits.ResumeLayout(False)
        Me.gp_DataBits.ResumeLayout(False)
        Me.pnl_Parity.ResumeLayout(False)
        Me.gp_Parity.ResumeLayout(False)
        Me.pnl_BaudRate.ResumeLayout(False)
        Me.gp_BaudRate.ResumeLayout(False)
        Me.pnl_Port.ResumeLayout(False)
        Me.gp_Port.ResumeLayout(False)
        Me.pnl_iD.ResumeLayout(False)
        Me.pnl_iD.PerformLayout()
        Me.gp_ID.ResumeLayout(False)
        Me.pnl_Dialog.ResumeLayout(False)
        Me.gp_Title.ResumeLayout(False)
        Me.gp_Title.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_AddPort As GradientControls.GradientPanel
    Friend WithEvents pnl_StopBits As System.Windows.Forms.Panel
    Friend WithEvents cb_StopBits As System.Windows.Forms.ComboBox
    Friend WithEvents pnl_DataBits As System.Windows.Forms.Panel
    Friend WithEvents cb_DataBits As System.Windows.Forms.ComboBox
    Friend WithEvents pnl_Parity As System.Windows.Forms.Panel
    Friend WithEvents cb_Parity As System.Windows.Forms.ComboBox
    Friend WithEvents pnl_BaudRate As System.Windows.Forms.Panel
    Public WithEvents cb_BaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents pnl_Dialog As GradientControls.GradientPanel
    Friend WithEvents pnl_Port As System.Windows.Forms.Panel
    Public WithEvents cb_Port As System.Windows.Forms.ComboBox
    Friend WithEvents bw_Progress As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnl_iD As System.Windows.Forms.Panel
    Public WithEvents PortID As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents gp_Port As GradientControls.GradientPanel
    Friend WithEvents lbl_Port As Label
    Friend WithEvents gp_ID As GradientControls.GradientPanel
    Friend WithEvents gp_StopBits As GradientControls.GradientPanel
    Friend WithEvents lbl_StopBits As Label
    Friend WithEvents gp_DataBits As GradientControls.GradientPanel
    Friend WithEvents lbl_DataBits As Label
    Friend WithEvents gp_Parity As GradientControls.GradientPanel
    Friend WithEvents lbl_Parity As Label
    Friend WithEvents gp_BaudRate As GradientControls.GradientPanel
    Friend WithEvents lbl_BaudRate As Label
    Friend WithEvents OK_Button As GradientControls.GradientButton
    Friend WithEvents Cancel_Button As GradientControls.GradientButton
    Friend WithEvents gp_Title As GradientControls.GradientPanel
    Friend WithEvents Label1 As Label

End Class
