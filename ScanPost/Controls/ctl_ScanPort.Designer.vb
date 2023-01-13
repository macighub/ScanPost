<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctl_ScanPort
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnl_Port = New GradientControls.GradientPanel()
        Me.pnl_StopBits = New GradientControls.GradientPanel()
        Me.cb_StopBits = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnl_DataBits = New GradientControls.GradientPanel()
        Me.cb_DataBits = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_Parity = New GradientControls.GradientPanel()
        Me.cb_Parity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Remove = New GradientControls.GradientButton()
        Me.pnl_BaudRate = New GradientControls.GradientPanel()
        Me.cb_BaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_PortName = New GradientControls.GradientPanel()
        Me.txt_PortName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_PortID = New GradientControls.GradientButton()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.tmr_PortOpen = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_PortRead = New System.Windows.Forms.Timer(Me.components)
        Me.mns_RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.gp_ScanPort = New GradientControls.GradientPanel()
        Me.sp_PortLogger = New System.IO.Ports.SerialPort(Me.components)
        Me.pnl_Port.SuspendLayout()
        Me.pnl_StopBits.SuspendLayout()
        Me.pnl_DataBits.SuspendLayout()
        Me.pnl_Parity.SuspendLayout()
        Me.pnl_BaudRate.SuspendLayout()
        Me.pnl_PortName.SuspendLayout()
        Me.mns_RightClick.SuspendLayout()
        Me.gp_ScanPort.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_Port
        '
        Me.pnl_Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_Port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_Port.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_Port.Controls.Add(Me.pnl_StopBits)
        Me.pnl_Port.Controls.Add(Me.pnl_DataBits)
        Me.pnl_Port.Controls.Add(Me.pnl_Parity)
        Me.pnl_Port.Controls.Add(Me.btn_Remove)
        Me.pnl_Port.Controls.Add(Me.pnl_BaudRate)
        Me.pnl_Port.Controls.Add(Me.pnl_PortName)
        Me.pnl_Port.Controls.Add(Me.btn_PortID)
        Me.pnl_Port.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_Port.ForeColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.pnl_Port.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_Port.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Port.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Port.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Port.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Port.InnerBorder.Size = 1
        Me.pnl_Port.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Port.Location = New System.Drawing.Point(2, 2)
        Me.pnl_Port.Name = "pnl_Port"
        Me.pnl_Port.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Port.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Port.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Port.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Port.OuterBorder.Size = 1
        Me.pnl_Port.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Port.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.pnl_Port.Size = New System.Drawing.Size(179, 146)
        Me.pnl_Port.TabIndex = 0
        Me.pnl_Port.Text = Nothing
        Me.pnl_Port.TextHandling = GradientControls.TextHandling.None
        '
        'pnl_StopBits
        '
        Me.pnl_StopBits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_StopBits.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_StopBits.Controls.Add(Me.cb_StopBits)
        Me.pnl_StopBits.Controls.Add(Me.Label4)
        Me.pnl_StopBits.Dock = System.Windows.Forms.DockStyle.Top
        '
        '
        '
        Me.pnl_StopBits.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_StopBits.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_StopBits.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_StopBits.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_StopBits.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_StopBits.InnerBorder.Size = 1
        Me.pnl_StopBits.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_StopBits.Location = New System.Drawing.Point(0, 122)
        Me.pnl_StopBits.Name = "pnl_StopBits"
        Me.pnl_StopBits.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_StopBits.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_StopBits.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_StopBits.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_StopBits.OuterBorder.Size = 1
        Me.pnl_StopBits.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_StopBits.Size = New System.Drawing.Size(178, 23)
        Me.pnl_StopBits.TabIndex = 6
        Me.pnl_StopBits.Text = Nothing
        Me.pnl_StopBits.TextHandling = GradientControls.TextHandling.None
        '
        'cb_StopBits
        '
        Me.cb_StopBits.BackColor = System.Drawing.Color.DimGray
        Me.cb_StopBits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_StopBits.ForeColor = System.Drawing.Color.Silver
        Me.cb_StopBits.FormattingEnabled = True
        Me.cb_StopBits.Items.AddRange(New Object() {"One", "Two", "OnePointFive"})
        Me.cb_StopBits.Location = New System.Drawing.Point(63, 0)
        Me.cb_StopBits.Name = "cb_StopBits"
        Me.cb_StopBits.Size = New System.Drawing.Size(115, 21)
        Me.cb_StopBits.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Stop Bits:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_DataBits
        '
        Me.pnl_DataBits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_DataBits.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_DataBits.Controls.Add(Me.cb_DataBits)
        Me.pnl_DataBits.Controls.Add(Me.Label3)
        Me.pnl_DataBits.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_DataBits.ForeColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.pnl_DataBits.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_DataBits.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_DataBits.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_DataBits.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_DataBits.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_DataBits.InnerBorder.Size = 1
        Me.pnl_DataBits.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_DataBits.Location = New System.Drawing.Point(0, 99)
        Me.pnl_DataBits.Margin = New System.Windows.Forms.Padding(0)
        Me.pnl_DataBits.Name = "pnl_DataBits"
        Me.pnl_DataBits.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_DataBits.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_DataBits.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_DataBits.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_DataBits.OuterBorder.Size = 1
        Me.pnl_DataBits.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_DataBits.Size = New System.Drawing.Size(178, 23)
        Me.pnl_DataBits.TabIndex = 5
        Me.pnl_DataBits.Text = Nothing
        Me.pnl_DataBits.TextHandling = GradientControls.TextHandling.None
        '
        'cb_DataBits
        '
        Me.cb_DataBits.BackColor = System.Drawing.Color.DimGray
        Me.cb_DataBits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_DataBits.ForeColor = System.Drawing.Color.Silver
        Me.cb_DataBits.FormattingEnabled = True
        Me.cb_DataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cb_DataBits.Location = New System.Drawing.Point(63, 0)
        Me.cb_DataBits.Name = "cb_DataBits"
        Me.cb_DataBits.Size = New System.Drawing.Size(115, 21)
        Me.cb_DataBits.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Data Bits:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Parity
        '
        Me.pnl_Parity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_Parity.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_Parity.Controls.Add(Me.cb_Parity)
        Me.pnl_Parity.Controls.Add(Me.Label2)
        Me.pnl_Parity.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Parity.ForeColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.pnl_Parity.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_Parity.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Parity.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Parity.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Parity.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Parity.InnerBorder.Size = 1
        Me.pnl_Parity.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Parity.Location = New System.Drawing.Point(0, 76)
        Me.pnl_Parity.Name = "pnl_Parity"
        Me.pnl_Parity.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_Parity.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_Parity.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_Parity.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_Parity.OuterBorder.Size = 1
        Me.pnl_Parity.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_Parity.Size = New System.Drawing.Size(178, 23)
        Me.pnl_Parity.TabIndex = 4
        Me.pnl_Parity.Text = Nothing
        Me.pnl_Parity.TextHandling = GradientControls.TextHandling.None
        '
        'cb_Parity
        '
        Me.cb_Parity.BackColor = System.Drawing.Color.DimGray
        Me.cb_Parity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Parity.ForeColor = System.Drawing.Color.Silver
        Me.cb_Parity.FormattingEnabled = True
        Me.cb_Parity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cb_Parity.Location = New System.Drawing.Point(63, 0)
        Me.cb_Parity.Name = "cb_Parity"
        Me.cb_Parity.Size = New System.Drawing.Size(115, 21)
        Me.cb_Parity.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Parity:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Remove
        '
        Me.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.btn_Remove.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_Remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold)
        '
        '
        '
        Me.btn_Remove.Image.TransparentKey = System.Drawing.Color.Empty
        Me.btn_Remove.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Remove.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Remove.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Remove.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Remove.InnerBorder.Size = 1
        Me.btn_Remove.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_Remove.Location = New System.Drawing.Point(151, 7)
        Me.btn_Remove.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.btn_Remove.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_Remove.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Remove.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Remove.OuterBorder.Size = 1
        Me.btn_Remove.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_Remove.Size = New System.Drawing.Size(17, 17)
        Me.btn_Remove.TabIndex = 2
        Me.btn_Remove.Text = "X"
        Me.btn_Remove.TextHandling = GradientControls.TextHandling.None
        Me.btn_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btn_Remove.UseVisualStyleBackColor = False
        '
        'pnl_BaudRate
        '
        Me.pnl_BaudRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_BaudRate.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_BaudRate.Controls.Add(Me.cb_BaudRate)
        Me.pnl_BaudRate.Controls.Add(Me.Label1)
        Me.pnl_BaudRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_BaudRate.ForeColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.pnl_BaudRate.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_BaudRate.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_BaudRate.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_BaudRate.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_BaudRate.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_BaudRate.InnerBorder.Size = 1
        Me.pnl_BaudRate.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_BaudRate.Location = New System.Drawing.Point(0, 53)
        Me.pnl_BaudRate.Name = "pnl_BaudRate"
        Me.pnl_BaudRate.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_BaudRate.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_BaudRate.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_BaudRate.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_BaudRate.OuterBorder.Size = 1
        Me.pnl_BaudRate.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_BaudRate.Size = New System.Drawing.Size(178, 23)
        Me.pnl_BaudRate.TabIndex = 3
        Me.pnl_BaudRate.Text = Nothing
        Me.pnl_BaudRate.TextHandling = GradientControls.TextHandling.None
        '
        'cb_BaudRate
        '
        Me.cb_BaudRate.BackColor = System.Drawing.Color.DimGray
        Me.cb_BaudRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_BaudRate.ForeColor = System.Drawing.Color.Silver
        Me.cb_BaudRate.FormattingEnabled = True
        Me.cb_BaudRate.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200", "128000", "256000"})
        Me.cb_BaudRate.Location = New System.Drawing.Point(63, 0)
        Me.cb_BaudRate.Name = "cb_BaudRate"
        Me.cb_BaudRate.Size = New System.Drawing.Size(115, 21)
        Me.cb_BaudRate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Baud Rate:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_PortName
        '
        Me.pnl_PortName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.pnl_PortName.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.pnl_PortName.Controls.Add(Me.txt_PortName)
        Me.pnl_PortName.Controls.Add(Me.Label6)
        Me.pnl_PortName.Dock = System.Windows.Forms.DockStyle.Top
        '
        '
        '
        Me.pnl_PortName.Image.TransparentKey = System.Drawing.Color.Empty
        Me.pnl_PortName.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_PortName.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_PortName.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_PortName.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_PortName.InnerBorder.Size = 1
        Me.pnl_PortName.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_PortName.Location = New System.Drawing.Point(0, 30)
        Me.pnl_PortName.Name = "pnl_PortName"
        Me.pnl_PortName.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.pnl_PortName.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.pnl_PortName.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_PortName.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_PortName.OuterBorder.Size = 1
        Me.pnl_PortName.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.pnl_PortName.Size = New System.Drawing.Size(178, 23)
        Me.pnl_PortName.TabIndex = 8
        Me.pnl_PortName.Text = Nothing
        Me.pnl_PortName.TextHandling = GradientControls.TextHandling.None
        '
        'txt_PortName
        '
        Me.txt_PortName.BackColor = System.Drawing.Color.Gray
        Me.txt_PortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PortName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PortName.ForeColor = System.Drawing.Color.Silver
        Me.txt_PortName.Location = New System.Drawing.Point(63, 0)
        Me.txt_PortName.Name = "txt_PortName"
        Me.txt_PortName.ReadOnly = True
        Me.txt_PortName.Size = New System.Drawing.Size(115, 20)
        Me.txt_PortName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Port Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_PortID
        '
        Me.btn_PortID.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_PortID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_PortID.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.btn_PortID.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_PortID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_PortID.ForeColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.btn_PortID.Image.TransparentKey = System.Drawing.Color.Empty
        Me.btn_PortID.InnerBorder.Color = System.Drawing.Color.Black
        Me.btn_PortID.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_PortID.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_PortID.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_PortID.InnerBorder.Size = 1
        Me.btn_PortID.InnerBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_PortID.Location = New System.Drawing.Point(0, 0)
        Me.btn_PortID.Name = "btn_PortID"
        Me.btn_PortID.OuterBorder.Color = System.Drawing.Color.Black
        Me.btn_PortID.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.btn_PortID.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.btn_PortID.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.btn_PortID.OuterBorder.Size = 1
        Me.btn_PortID.OuterBorder.Type = GradientControls.Border.BorderType.None
        Me.btn_PortID.Size = New System.Drawing.Size(178, 30)
        Me.btn_PortID.TabIndex = 0
        Me.btn_PortID.Text = "Scanner_?"
        Me.btn_PortID.TextHandling = GradientControls.TextHandling.None
        Me.btn_PortID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PortID.UseVisualStyleBackColor = False
        '
        'txt_Log
        '
        Me.txt_Log.BackColor = System.Drawing.Color.DarkGray
        Me.txt_Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Log.Location = New System.Drawing.Point(181, 2)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Log.Size = New System.Drawing.Size(563, 146)
        Me.txt_Log.TabIndex = 1
        '
        'tmr_PortOpen
        '
        '
        'tmr_PortRead
        '
        Me.tmr_PortRead.Enabled = True
        Me.tmr_PortRead.Interval = 200
        '
        'mns_RightClick
        '
        Me.mns_RightClick.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.mns_RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Remove})
        Me.mns_RightClick.Name = "mns_RightClick"
        Me.mns_RightClick.Size = New System.Drawing.Size(157, 28)
        '
        'mnu_Remove
        '
        Me.mnu_Remove.Name = "mnu_Remove"
        Me.mnu_Remove.Size = New System.Drawing.Size(156, 24)
        Me.mnu_Remove.Text = "Remove Port"
        '
        'gp_ScanPort
        '
        Me.gp_ScanPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gp_ScanPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile
        Me.gp_ScanPort.BackgroundStyle = GradientControls.BackgroundStyle.Gradient
        Me.gp_ScanPort.Controls.Add(Me.txt_Log)
        Me.gp_ScanPort.Controls.Add(Me.pnl_Port)
        Me.gp_ScanPort.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.gp_ScanPort.Image.TransparentKey = System.Drawing.Color.Empty
        Me.gp_ScanPort.InnerBorder.Color = System.Drawing.Color.Transparent
        Me.gp_ScanPort.InnerBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_ScanPort.InnerBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_ScanPort.InnerBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_ScanPort.InnerBorder.Size = 1
        Me.gp_ScanPort.InnerBorder.Type = GradientControls.Border.BorderType.Sunken
        Me.gp_ScanPort.Location = New System.Drawing.Point(0, 0)
        Me.gp_ScanPort.Name = "gp_ScanPort"
        Me.gp_ScanPort.OuterBorder.Color = System.Drawing.Color.Transparent
        Me.gp_ScanPort.OuterBorder.FlatStyle.Color = System.Drawing.SystemColors.Control
        Me.gp_ScanPort.OuterBorder.FlatStyle.MouseDownColor = System.Drawing.SystemColors.ControlDark
        Me.gp_ScanPort.OuterBorder.FlatStyle.MouseOverColor = System.Drawing.SystemColors.ControlLight
        Me.gp_ScanPort.OuterBorder.Size = 1
        Me.gp_ScanPort.OuterBorder.Type = GradientControls.Border.BorderType.Raised
        Me.gp_ScanPort.Padding = New System.Windows.Forms.Padding(2)
        Me.gp_ScanPort.Size = New System.Drawing.Size(746, 150)
        Me.gp_ScanPort.TabIndex = 2
        Me.gp_ScanPort.Text = Nothing
        Me.gp_ScanPort.TextHandling = GradientControls.TextHandling.None
        '
        'ctl_ScanPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gp_ScanPort)
        Me.Name = "ctl_ScanPort"
        Me.Size = New System.Drawing.Size(746, 150)
        Me.pnl_Port.ResumeLayout(False)
        Me.pnl_StopBits.ResumeLayout(False)
        Me.pnl_DataBits.ResumeLayout(False)
        Me.pnl_Parity.ResumeLayout(False)
        Me.pnl_BaudRate.ResumeLayout(False)
        Me.pnl_PortName.ResumeLayout(False)
        Me.pnl_PortName.PerformLayout()
        Me.mns_RightClick.ResumeLayout(False)
        Me.gp_ScanPort.ResumeLayout(False)
        Me.gp_ScanPort.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_Port As GradientControls.GradientPanel
    Friend WithEvents btn_PortID As GradientControls.GradientButton
    Friend WithEvents pnl_StopBits As GradientControls.GradientPanel
    Friend WithEvents cb_StopBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnl_DataBits As GradientControls.GradientPanel
    Friend WithEvents cb_DataBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnl_Parity As GradientControls.GradientPanel
    Friend WithEvents cb_Parity As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl_BaudRate As GradientControls.GradientPanel
    Friend WithEvents cb_BaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Log As System.Windows.Forms.TextBox
    Friend WithEvents tmr_PortOpen As System.Windows.Forms.Timer
    Friend WithEvents tmr_PortRead As System.Windows.Forms.Timer
    Friend WithEvents mns_RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnu_Remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Remove As GradientControls.GradientButton
    Friend WithEvents pnl_PortName As GradientControls.GradientPanel
    Friend WithEvents txt_PortName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gp_ScanPort As GradientControls.GradientPanel
    Friend WithEvents sp_PortLogger As System.IO.Ports.SerialPort
End Class
