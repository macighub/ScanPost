<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ScanPost
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ScanPost))
        Me.gp_Title = New GradientControls.GradientPanel()
        Me.btn_Minimize = New GradientControls.GradientButton()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_ShowHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_TrayMenuSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Quit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_Receiver = New GradientControls.GradientPanel()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.txt_GET = New System.Windows.Forms.TextBox()
        Me.lbl_GET = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.pnl_HttpStatus = New System.Windows.Forms.Panel()
        Me.lbl_HttpReceiver = New System.Windows.Forms.Label()
        Me.pnl_ScannerPorts = New GradientControls.GradientPanel()
        Me.pnl_PortArea = New GradientControls.GradientPanel()
        Me.pnl_Ports = New System.Windows.Forms.Panel()
        Me.scb_Ports = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_AddPort = New GradientControls.GradientButton()
        Me.pnl_ScanStatus = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gp_Visible = New GradientControls.GradientPanel()
        Me.pnl_Visible = New System.Windows.Forms.Panel()
        Me.tmr_Visible = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_ScanPortStatus = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Scroll = New System.Windows.Forms.Timer(Me.components)
        Me.gp_Title.SuspendLayout()
        Me.TrayMenu.SuspendLayout()
        Me.pnl_Receiver.SuspendLayout()
        Me.pnl_ScannerPorts.SuspendLayout()
        Me.pnl_PortArea.SuspendLayout()
        Me.pnl_Ports.SuspendLayout()
        Me.gp_Visible.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_Title
        '
        Me.gp_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Title.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Title.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.gp_Title.Controls.Add(Me.btn_Minimize)
        Me.gp_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.gp_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gp_Title.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.gp_Title.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Title.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Title.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Title.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Title.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Title.InnerBorder.Size = 1
        Me.gp_Title.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Title.Location = New System.Drawing.Point(0, 0)
        Me.gp_Title.Name = "gp_Title"
        Me.gp_Title.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Title.OuterBorder.FlatStyle.Color = System.Drawing.Color.Transparent
        Me.gp_Title.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.Color.Lime
        Me.gp_Title.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.Color.Red
        Me.gp_Title.OuterBorder.Size = 1
        Me.gp_Title.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Title.Size = New System.Drawing.Size(880, 30)
        Me.gp_Title.TabIndex = 0
        Me.gp_Title.Text = "ScanPost - version 0"
        Me.gp_Title.TextHandling = GradientControls.TextHandling.None
        '
        'btn_Minimize
        '
        Me.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.btn_Minimize.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right
        '
        '
        '
        Me.btn_Minimize.Image.TransparentKey = System.Drawing.Color.Empty
        Me.btn_Minimize.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Minimize.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Minimize.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Minimize.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Minimize.InnerBorder.Size = 1
        Me.btn_Minimize.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_Minimize.Location = New System.Drawing.Point(850, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Minimize.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Minimize.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Minimize.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Minimize.OuterBorder.Size = 1
        Me.btn_Minimize.OuterBorder.Type = GradientControls.Border.BorderType.Popup
        Me.btn_Minimize.Size = New System.Drawing.Size(30, 30)
        Me.btn_Minimize.TabIndex = 2
        Me.btn_Minimize.Text = "_"
        Me.btn_Minimize.TextHandling = GradientControls.TextHandling.None
        Me.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_Minimize.UseVisualStyleBackColor = False
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TrayIcon.BalloonTipText = "Duble-click tray icon to see application window!"
        Me.TrayIcon.BalloonTipTitle = "ScanPost"
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Duble-click to unhide ScanPost window"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ShowHide, Me.mnu_ChangePassword, Me.mnu_TrayMenuSeparator, Me.mnu_Quit})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(188, 82)
        Me.TrayMenu.Text = "TrayMenu"
        '
        'mnu_ShowHide
        '
        Me.mnu_ShowHide.Name = "mnu_ShowHide"
        Me.mnu_ShowHide.Size = New System.Drawing.Size(187, 24)
        Me.mnu_ShowHide.Text = "&Show ScanPost"
        '
        'mnu_ChangePassword
        '
        Me.mnu_ChangePassword.Name = "mnu_ChangePassword"
        Me.mnu_ChangePassword.Size = New System.Drawing.Size(187, 24)
        Me.mnu_ChangePassword.Text = "Change &Password"
        '
        'mnu_TrayMenuSeparator
        '
        Me.mnu_TrayMenuSeparator.Name = "mnu_TrayMenuSeparator"
        Me.mnu_TrayMenuSeparator.Size = New System.Drawing.Size(184, 6)
        '
        'mnu_Quit
        '
        Me.mnu_Quit.Name = "mnu_Quit"
        Me.mnu_Quit.Size = New System.Drawing.Size(187, 24)
        Me.mnu_Quit.Text = "&Quit"
        '
        'pnl_Receiver
        '
        Me.pnl_Receiver.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_Receiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_Receiver.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_Receiver.Controls.Add(Me.txt_Log)
        Me.pnl_Receiver.Controls.Add(Me.txt_GET)
        Me.pnl_Receiver.Controls.Add(Me.lbl_GET)
        Me.pnl_Receiver.Controls.Add(Me.txt_Address)
        Me.pnl_Receiver.Controls.Add(Me.lbl_Address)
        Me.pnl_Receiver.Controls.Add(Me.pnl_HttpStatus)
        Me.pnl_Receiver.Controls.Add(Me.lbl_HttpReceiver)
        Me.pnl_Receiver.Dock = System.Windows.Forms.DockStyle.Top
        '
        '
        '
        Me.pnl_Receiver.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_Receiver.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Receiver.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Receiver.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Receiver.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Receiver.InnerBorder.Size = 1
        Me.pnl_Receiver.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Receiver.Location = New System.Drawing.Point(0, 30)
        Me.pnl_Receiver.Name = "pnl_Receiver"
        Me.pnl_Receiver.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Receiver.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Receiver.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Receiver.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Receiver.OuterBorder.Size = 1
        Me.pnl_Receiver.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Receiver.Size = New System.Drawing.Size(880, 105)
        Me.pnl_Receiver.TabIndex = 1
        Me.pnl_Receiver.Text = Nothing
        Me.pnl_Receiver.TextHandling = GradientControls.TextHandling.None
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.BackColor = System.Drawing.Color.DarkGray
        Me.txt_Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Log.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Log.Location = New System.Drawing.Point(308, 5)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.ReadOnly = True
        Me.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Log.Size = New System.Drawing.Size(567, 92)
        Me.txt_Log.TabIndex = 6
        '
        'txt_GET
        '
        Me.txt_GET.BackColor = System.Drawing.Color.DarkGray
        Me.txt_GET.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_GET.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_GET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_GET.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_GET.Location = New System.Drawing.Point(15, 81)
        Me.txt_GET.Name = "txt_GET"
        Me.txt_GET.Size = New System.Drawing.Size(287, 15)
        Me.txt_GET.TabIndex = 5
        Me.txt_GET.Text = "/scan?data={DATA}&from={ID}"
        '
        'lbl_GET
        '
        Me.lbl_GET.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GET.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!)
        Me.lbl_GET.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_GET.Location = New System.Drawing.Point(5, 65)
        Me.lbl_GET.Name = "lbl_GET"
        Me.lbl_GET.Size = New System.Drawing.Size(297, 14)
        Me.lbl_GET.TabIndex = 4
        Me.lbl_GET.Text = "[Path]?<query> (ex. /scan/?data={DATA}):"
        Me.lbl_GET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Address
        '
        Me.txt_Address.BackColor = System.Drawing.Color.DarkGray
        Me.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_Address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Address.Location = New System.Drawing.Point(15, 48)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(287, 15)
        Me.txt_Address.TabIndex = 3
        Me.txt_Address.Text = "www.scanreceiver.com:80"
        '
        'lbl_Address
        '
        Me.lbl_Address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!)
        Me.lbl_Address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Address.Location = New System.Drawing.Point(5, 32)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(297, 14)
        Me.lbl_Address.TabIndex = 2
        Me.lbl_Address.Text = "Host[:Port] (ex. www.scanreceiver.com:80):"
        Me.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_HttpStatus
        '
        Me.pnl_HttpStatus.BackColor = System.Drawing.Color.Silver
        Me.pnl_HttpStatus.Location = New System.Drawing.Point(15, 12)
        Me.pnl_HttpStatus.Name = "pnl_HttpStatus"
        Me.pnl_HttpStatus.Size = New System.Drawing.Size(25, 10)
        Me.pnl_HttpStatus.TabIndex = 1
        '
        'lbl_HttpReceiver
        '
        Me.lbl_HttpReceiver.BackColor = System.Drawing.Color.Gray
        Me.lbl_HttpReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_HttpReceiver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_HttpReceiver.Location = New System.Drawing.Point(5, 5)
        Me.lbl_HttpReceiver.Name = "lbl_HttpReceiver"
        Me.lbl_HttpReceiver.Size = New System.Drawing.Size(297, 23)
        Me.lbl_HttpReceiver.TabIndex = 0
        Me.lbl_HttpReceiver.Text = "Http Data Receiver"
        Me.lbl_HttpReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_ScannerPorts
        '
        Me.pnl_ScannerPorts.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_ScannerPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_ScannerPorts.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_ScannerPorts.Controls.Add(Me.pnl_PortArea)
        Me.pnl_ScannerPorts.Controls.Add(Me.btn_AddPort)
        Me.pnl_ScannerPorts.Controls.Add(Me.pnl_ScanStatus)
        Me.pnl_ScannerPorts.Controls.Add(Me.Label1)
        Me.pnl_ScannerPorts.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.pnl_ScannerPorts.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_ScannerPorts.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_ScannerPorts.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_ScannerPorts.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_ScannerPorts.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_ScannerPorts.InnerBorder.Size = 1
        Me.pnl_ScannerPorts.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_ScannerPorts.Location = New System.Drawing.Point(0, 135)
        Me.pnl_ScannerPorts.Name = "pnl_ScannerPorts"
        Me.pnl_ScannerPorts.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_ScannerPorts.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_ScannerPorts.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_ScannerPorts.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_ScannerPorts.OuterBorder.Size = 1
        Me.pnl_ScannerPorts.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_ScannerPorts.Size = New System.Drawing.Size(880, 195)
        Me.pnl_ScannerPorts.TabIndex = 2
        Me.pnl_ScannerPorts.Text = Nothing
        Me.pnl_ScannerPorts.TextHandling = GradientControls.TextHandling.None
        '
        'pnl_PortArea
        '
        Me.pnl_PortArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_PortArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_PortArea.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.pnl_PortArea.Controls.Add(Me.pnl_Ports)
        Me.pnl_PortArea.Controls.Add(Me.Panel1)
        Me.pnl_PortArea.Controls.Add(Me.scb_Ports)
        '
        '
        '
        Me.pnl_PortArea.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_PortArea.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_PortArea.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_PortArea.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_PortArea.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_PortArea.InnerBorder.Size = 1
        Me.pnl_PortArea.InnerBorder.Type = GradientControls.Border.BorderType.Sunken
        Me.pnl_PortArea.Location = New System.Drawing.Point(5, 33)
        Me.pnl_PortArea.Name = "pnl_PortArea"
        Me.pnl_PortArea.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_PortArea.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_PortArea.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_PortArea.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_PortArea.OuterBorder.Size = 1
        Me.pnl_PortArea.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.pnl_PortArea.Size = New System.Drawing.Size(870, 154)
        Me.pnl_PortArea.TabIndex = 5
        Me.pnl_PortArea.Text = Nothing
        Me.pnl_PortArea.TextHandling = GradientControls.TextHandling.None
        '
        'pnl_Ports
        '
        Me.pnl_Ports.Location = New System.Drawing.Point(2, 2)
        Me.pnl_Ports.Name = "pnl_Ports"
        Me.pnl_Ports.Size = New System.Drawing.Size(850, 149)
        Me.pnl_Ports.TabIndex = 0
        '
        'scb_Ports
        '
        Me.scb_Ports.Dock = System.Windows.Forms.DockStyle.Right
        Me.scb_Ports.Enabled = False
        Me.scb_Ports.LargeChange = 101
        Me.scb_Ports.Location = New System.Drawing.Point(833, 0)
        Me.scb_Ports.Name = "scb_Ports"
        Me.scb_Ports.Size = New System.Drawing.Size(17, 149)
        Me.scb_Ports.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(54, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(30, 9)
        Me.Panel1.TabIndex = 0
        '
        'btn_AddPort
        '
        Me.btn_AddPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.btn_AddPort.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_AddPort.ContentAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_AddPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.854546!, System.Drawing.FontStyle.Bold)
        Me.btn_AddPort.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.btn_AddPort.Image.TransparentKey = System.Drawing.Color.Empty
        Me.btn_AddPort.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.btn_AddPort.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_AddPort.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_AddPort.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_AddPort.InnerBorder.Size = 1
        Me.btn_AddPort.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_AddPort.Location = New System.Drawing.Point(308, 5)
        Me.btn_AddPort.Name = "btn_AddPort"
        Me.btn_AddPort.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_AddPort.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_AddPort.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_AddPort.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_AddPort.OuterBorder.Size = 1
        Me.btn_AddPort.OuterBorder.Type = GradientControls.Border.BorderType.Popup
        Me.btn_AddPort.Size = New System.Drawing.Size(567, 23)
        Me.btn_AddPort.TabIndex = 4
        Me.btn_AddPort.Text = "Add Scanner Port"
        Me.btn_AddPort.TextHandling = GradientControls.TextHandling.None
        Me.btn_AddPort.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_AddPort.UseVisualStyleBackColor = True
        '
        'pnl_ScanStatus
        '
        Me.pnl_ScanStatus.BackColor = System.Drawing.Color.Silver
        Me.pnl_ScanStatus.Location = New System.Drawing.Point(15, 12)
        Me.pnl_ScanStatus.Name = "pnl_ScanStatus"
        Me.pnl_ScanStatus.Size = New System.Drawing.Size(25, 10)
        Me.pnl_ScanStatus.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Scanner Port(s)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gp_Visible
        '
        Me.gp_Visible.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_Visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_Visible.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_Visible.ContentAlignment = System.Drawing.ContentAlignment.BottomLeft
        Me.gp_Visible.Controls.Add(Me.pnl_Visible)
        Me.gp_Visible.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gp_Visible.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!)
        Me.gp_Visible.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.gp_Visible.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_Visible.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Visible.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Visible.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Visible.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Visible.InnerBorder.Size = 1
        Me.gp_Visible.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Visible.Location = New System.Drawing.Point(0, 330)
        Me.gp_Visible.Name = "gp_Visible"
        Me.gp_Visible.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_Visible.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_Visible.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_Visible.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_Visible.OuterBorder.Size = 1
        Me.gp_Visible.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.gp_Visible.Size = New System.Drawing.Size(880, 22)
        Me.gp_Visible.TabIndex = 3
        Me.gp_Visible.Tag = "ScanPoint window will automatically hide in {X} seconds."
        Me.gp_Visible.Text = "ScanPost window will automatically hide in  seconds.     "
        Me.gp_Visible.TextHandling = GradientControls.TextHandling.None
        '
        'pnl_Visible
        '
        Me.pnl_Visible.BackColor = System.Drawing.Color.Lime
        Me.pnl_Visible.ForeColor = System.Drawing.Color.LimeGreen
        Me.pnl_Visible.Location = New System.Drawing.Point(2, 18)
        Me.pnl_Visible.Name = "pnl_Visible"
        Me.pnl_Visible.Size = New System.Drawing.Size(876, 2)
        Me.pnl_Visible.TabIndex = 0
        '
        'tmr_Visible
        '
        Me.tmr_Visible.Interval = 1000
        '
        'tmr_ScanPortStatus
        '
        '
        'tmr_Scroll
        '
        '
        'frm_ScanPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(880, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_ScannerPorts)
        Me.Controls.Add(Me.pnl_Receiver)
        Me.Controls.Add(Me.gp_Title)
        Me.Controls.Add(Me.gp_Visible)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_ScanPost"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.gp_Title.ResumeLayout(False)
        Me.TrayMenu.ResumeLayout(False)
        Me.pnl_Receiver.ResumeLayout(False)
        Me.pnl_Receiver.PerformLayout()
        Me.pnl_ScannerPorts.ResumeLayout(False)
        Me.pnl_PortArea.ResumeLayout(False)
        Me.pnl_Ports.ResumeLayout(False)
        Me.gp_Visible.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gp_Title As GradientControls.GradientPanel
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents TrayMenu As ContextMenuStrip
    Friend WithEvents mnu_ShowHide As ToolStripMenuItem
    Friend WithEvents mnu_ChangePassword As ToolStripMenuItem
    Friend WithEvents mnu_TrayMenuSeparator As ToolStripSeparator
    Friend WithEvents mnu_Quit As ToolStripMenuItem
    Friend WithEvents btn_Minimize As GradientControls.GradientButton
    Friend WithEvents pnl_Receiver As GradientControls.GradientPanel
    Friend WithEvents txt_Log As TextBox
    Friend WithEvents txt_GET As TextBox
    Friend WithEvents lbl_GET As Label
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents lbl_Address As Label
    Friend WithEvents pnl_HttpStatus As Panel
    Friend WithEvents lbl_HttpReceiver As Label
    Friend WithEvents pnl_ScannerPorts As GradientControls.GradientPanel
    Friend WithEvents btn_AddPort As GradientControls.GradientButton
    Friend WithEvents pnl_ScanStatus As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_PortArea As GradientControls.GradientPanel
    Friend WithEvents gp_Visible As GradientControls.GradientPanel
    Friend WithEvents pnl_Visible As Panel
    Friend WithEvents tmr_Visible As Timer
    Friend WithEvents pnl_Ports As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents scb_Ports As VScrollBar
    Friend WithEvents tmr_ScanPortStatus As Timer
    Friend WithEvents tmr_Scroll As Timer
End Class
