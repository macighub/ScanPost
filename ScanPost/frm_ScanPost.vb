Imports System.Net
Imports Microsoft.Win32

Public Class frm_ScanPost
    Private Delegate Sub UploadData_Delegate(ByRef sender As ctl_ScanPort, ByVal vars As String)

    Private MoveByTitle As Boolean = False
    Private MouseX As Integer, MouseY As Integer

    Public Shared PortsList As New List(Of ctl_ScanPort)
    Private locdlg_Pwd As New dlg_Password
    Private locdlg_AddPort As New dlg_AddPort
    Private locdlg_NewPwd As New dlg_NewPwd

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.DoubleBuffered = True
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        gp_Title.Text = Replace(gp_Title.Text, "version 0", "Version " + Application.ProductVersion)

        'Load Config
        LoadHttpReceiver()
        LoadScanPorts()

        CheckHTTPHost()

        TrayIcon.ShowBalloonTip(1500)
    End Sub

    Private Sub LoadHttpReceiver()
        Dim HttpReceiver As String
        Dim HttpReceiverData() As String

        HttpReceiver = ReadRegVal("HTTP_Receiver")

        If InStr(HttpReceiver, "|") > 0 Then
            HttpReceiverData = Split(HttpReceiver, "|")
            If UBound(HttpReceiverData) = 1 AndAlso Trim(HttpReceiverData(0)) <> vbNullString Then
                txt_Address.Text = HttpReceiverData(0)
                txt_GET.Text = HttpReceiverData(1)
            Else
                txt_Address.Text = vbNullString
                txt_GET.Text = vbNullString
                HTTPReceiver_AddLog("ScanPoint", "Invalid Http Data Receiver config! (" + HttpReceiver + ")")
                pnl_HttpStatus.BackColor = Color.Red
            End If
        Else
            txt_Address.Text = vbNullString
            txt_GET.Text = vbNullString
            If Trim(HttpReceiver) = vbNullString Then
                HTTPReceiver_AddLog("ScanPoint", "Http Data Receiver not configured")
                pnl_HttpStatus.BackColor = Color.Silver
            Else
                HTTPReceiver_AddLog("ScanPoint", "Invalid Http Data Receiver config! (" + HttpReceiver + ")")
                pnl_HttpStatus.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub LoadScanPorts()
        Dim AllPortData As String
        Dim PortData() As String
        Dim PortDataFields() As String

        AllPortData = ReadRegVal("Scan_Ports")
        PortData = Split(AllPortData, vbCrLf)

        For loccnt = 0 To UBound(PortData)
            PortDataFields = Split(PortData(loccnt), "|")
            If UBound(PortDataFields) = 5 Then
                AddPort(PortDataFields(0), PortDataFields(1), CInt(PortDataFields(2)), CParity(PortDataFields(3)), CInt(PortDataFields(4)), CStopBits(PortDataFields(5)))
                PortsList.Item(PortsList.Count - 1).OpenPort()
            End If
        Next
    End Sub

    Private Sub HTTPReceiver_AddLog(ByVal [Sender] As String, ByVal [Text] As String, Optional ByVal [NewLine] As Boolean = True)
        If txt_Log.Text = vbNullString OrElse Mid(txt_Log.Text, Len(txt_Log.Text), 1) = vbLf Then
            txt_Log.Text += Now.ToLocalTime.ToString + "  - "

            txt_Log.Text += "[" + [Sender] + "]: "
        End If

        txt_Log.Text += [Text]

        If [NewLine] Then
            txt_Log.Text += vbCrLf
        End If

        txt_Log.SelectionStart = Len(txt_Log.Text)
        txt_Log.ScrollToCaret()
    End Sub

    Private Sub CheckHTTPHost()
        If Trim(txt_Address.Text) = vbNullString Then
            HTTPReceiver_AddLog("ScanPoint", "No Addres configured for HTTP Data Receiver!")
            Exit Sub
        Else
            txt_Address.Text = Trim(txt_Address.Text)
        End If
        Try
            HTTPReceiver_AddLog("ScanPoint", "Checking for availability of HTTP Data Receiver's host: ", False)
            Dim WbRQ As HttpWebRequest
            Dim WbRP As HttpWebResponse
            Dim WbUri As New Uri("http://" + txt_Address.Text)

            WbRQ = DirectCast(HttpWebRequest.Create(WbUri), HttpWebRequest)
            WbRP = WbRQ.GetResponse()
            If WbRQ.HaveResponse Then
                If WbRP.StatusCode = HttpStatusCode.OK Then
                    HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Response status: OK")
                    pnl_HttpStatus.BackColor = Color.Lime
                    'Dim Wbs As New System.IO.StreamReader(WbRQ.GetResponse().GetResponseStream())
                    'txt_Log.Text += Wbs.ReadToEnd() + vbCrLf
                    'Wbs.Close()
                Else
                    HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Warning: Wrong response received (" + WbRP.StatusCode.ToString + ").")
                    pnl_HttpStatus.BackColor = Color.Cyan
                End If
            Else
                HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Warning: No response received!")
                pnl_HttpStatus.BackColor = Color.Yellow
            End If
        Catch ex As Exception
            HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Error: " + ex.Message)
            pnl_HttpStatus.BackColor = Color.Red
        End Try
    End Sub

    Private Sub Title_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gp_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveByTitle = True
            MouseX = MousePosition.X - Me.Left
            MouseY = MousePosition.Y - Me.Top
        End If
    End Sub

    Private Sub Title_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gp_Title.MouseMove
        If MoveByTitle = True Then
            Me.Left = MousePosition.X - MouseX
            Me.Top = MousePosition.Y - MouseY
        End If
    End Sub

    Private Sub mnu_ShowHide_Click(sender As Object, e As EventArgs) Handles mnu_ShowHide.Click, TrayIcon.DoubleClick, btn_Minimize.Click
        If mnu_ShowHide.Text = "&Show ScanPost" Then
            locdlg_Pwd.Clear()
            If Not locdlg_Pwd.Visible Then
                If ReadRegVal("EditPwd") <> vbNullString Then
                    locdlg_Pwd.ShowDialog()
                End If

                If (locdlg_Pwd.DialogResult = DialogResult.OK And EncPwd(locdlg_Pwd.PlainPwd) = ReadRegVal("EditPwd")) Or ReadRegVal("EditPwd") = vbNullString Then
                    Me.SuspendLayout()
                    Me.WindowState = FormWindowState.Normal
                    Me.ShowInTaskbar = True
                    mnu_ShowHide.Text = "&Hide ScanPost"
                    TrayIcon.Text = "Double-click to hide ScanPost window"
                    If ReadRegVal("EditPwd") = vbNullString Then
                        pnl_Visible.Visible = True
                        tmr_Visible.Tag = 61
                        tmr_Visible.Enabled = True
                    Else
                        pnl_Visible.Visible = False
                    End If
                    Me.ResumeLayout()
                    Me.Visible = True
                    SetHeight()
                End If
            End If
        Else
            locdlg_Pwd.Clear()
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            mnu_ShowHide.Text = "&Show ScanPost"
            TrayIcon.Text = "Double-click to unhide ScanPost window"
            Me.Visible = False
            tmr_Visible.Tag = 0
            tmr_Visible.Enabled = False
        End If
    End Sub

    Private Sub mnu_Quit_Click(sender As Object, e As EventArgs) Handles mnu_Quit.Click
        If ReadRegVal("EditPwd") <> vbNullString Then
            locdlg_Pwd.Clear()
            locdlg_Pwd.DialogResult = DialogResult.None
            locdlg_Pwd.ShowDialog()
        End If

        If (locdlg_Pwd.DialogResult = Windows.Forms.DialogResult.OK And EncPwd(locdlg_Pwd.PlainPwd) = ReadRegVal("EditPwd")) Or ReadRegVal("EditPwd") = vbNullString Then
            TrayIcon.Visible = False
            End
        End If

        tmr_Visible.Tag = 61
    End Sub

    Private Sub btn_AddPort_Click(sender As Object, e As EventArgs) Handles btn_AddPort.Click
        tmr_Visible.Tag = 61

        locdlg_AddPort.Clear()

        If locdlg_AddPort.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            AddPort(locdlg_AddPort.PortID.Text, locdlg_AddPort.cb_Port.Text, CInt(locdlg_AddPort.cb_BaudRate.Text), CParity(locdlg_AddPort.cb_Parity.Text), CInt(locdlg_AddPort.cb_DataBits.Text), CStopBits(locdlg_AddPort.cb_StopBits.Text))
            SavePortsConfig()
        End If

        tmr_Visible.Tag = 61
    End Sub

    Private Sub Upload_Data(ByRef sender As ctl_ScanPort, vars As String)
        If Me.InvokeRequired Then
            txt_Log.BeginInvoke(New UploadData_Delegate(AddressOf Upload_Data), {sender, vars})
        Else
            Dim VarList() As String
            Dim VarName As String
            Dim VarValue As String
            Dim loc_GetFormat As String = txt_GET.Text

            VarList = Split(vars, "|")

            HTTPReceiver_AddLog(sender.ID + ":" + sender.PortName, "Data received:", False)

            For loccnt = 0 To UBound(VarList)
                If InStr(VarList(loccnt), "=") > 0 Then
                    VarName = Mid(VarList(loccnt), 1, InStr(VarList(loccnt), "=") - 1)
                    VarValue = Mid(VarList(loccnt), InStr(VarList(loccnt), "=") + 1)
                Else
                    VarName = VarList(loccnt)
                    VarValue = vbNullString
                End If
                HTTPReceiver_AddLog(sender.ID + ":" + sender.PortName, vbCrLf + StrDup(59, " ") + "{" + VarName + "} = " + VarValue, False)
                loc_GetFormat = Replace(loc_GetFormat, "{" + VarName + "}", VarValue)
            Next

            HTTPReceiver_AddLog(sender.ID + ":" + sender.PortName, vbNullString)

            Try
                HTTPReceiver_AddLog("HTTPReceiver", "Sending GET request: ", False)
                HTTPReceiver_AddLog("HTTPReceiver", vbCrLf + StrDup(59, " ") + txt_Address.Text + loc_GetFormat, False)
                Dim WbRQ As HttpWebRequest
                Dim WbRP As HttpWebResponse
                Dim WbUri As New Uri("http://" + txt_Address.Text + loc_GetFormat)

                WbRQ = DirectCast(HttpWebRequest.Create(WbUri), HttpWebRequest)
                WbRP = WbRQ.GetResponse()
                If WbRQ.HaveResponse Then
                    If WbRP.StatusCode = HttpStatusCode.OK Then
                        HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Response status: OK")
                        pnl_HttpStatus.BackColor = Color.Lime
                        'Dim Wbs As New System.IO.StreamReader(WbRQ.GetResponse().GetResponseStream())
                        'txt_Log.Text += Wbs.ReadToEnd() + vbCrLf
                        'Wbs.Close()
                    Else
                        HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Warning: Wrong response received (" + WbRP.StatusCode.ToString + ").")
                        pnl_HttpStatus.BackColor = Color.Cyan
                    End If
                Else
                    HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Warning: No response received!")
                    pnl_HttpStatus.BackColor = Color.Yellow
                End If

                'Dim URL As String = "http://whatever.you.want"
                '' Get HTML data
                'Dim client As System.Net.WebClient = New System.Net.WebClient()
                'Dim data As System.IO.Stream = client.OpenRead(URL)
                'Dim reader As System.IO.StreamReader = New System.IO.StreamReader(data)
                'Dim str As String = ""
                'str = reader.ReadToEnd
                'Do While str.Length > 0
                '    Console.WriteLine(str)
                '    str = reader.ReadLine()
                'Loop
            Catch ex As Exception
                HTTPReceiver_AddLog("ScanPoint", vbCrLf + StrDup(59, " ") + "Error: " + ex.Message)
                pnl_HttpStatus.BackColor = Color.Red
            End Try

            tmr_Visible.Tag = 61
        End If
    End Sub

    Private Sub AddPort(PortID As String, PortName As String, BaudRate As Integer, Parity As System.IO.Ports.Parity, DataBits As Integer, StopBits As System.IO.Ports.StopBits)
        Me.SuspendLayout()
        PortsList.Add(New ctl_ScanPort(PortID, PortName, BaudRate, Parity, DataBits, StopBits))
        PortsList.Item(PortsList.Count - 1).Parent = pnl_Ports
        AddHandler PortsList.Item(PortsList.Count - 1).RemoveEvent, AddressOf RemovePort
        AddHandler PortsList.Item(PortsList.Count - 1).PortSettingsChanged, AddressOf PortSettingsChanged
        AddHandler PortsList.Item(PortsList.Count - 1).DataReceived, AddressOf DataReceived
        PortsList.Item(PortsList.Count - 1).ChangeEnabled = True
        For loccnt = PortsList.Count - 1 To 0 Step -1
            PortsList.Item(loccnt).Top = loccnt * 150
            PortsList.Item(loccnt).Width = pnl_Ports.Width
        Next
        Me.ResumeLayout()
        SetHeight()
    End Sub

    Public Sub RemovePort(ByRef sender As ctl_ScanPort)
        For loccnt = 0 To PortsList.Count - 1
            If loccnt < PortsList.Count Then
                If PortsList.Item(loccnt).ID = sender.ID Then
                    PortsList.Item(loccnt).Parent = Nothing
                    PortsList.Item(loccnt) = Nothing
                    PortsList.RemoveAt(loccnt)
                    loccnt -= 1
                Else
                    PortsList.Item(loccnt).Top = loccnt * 150
                End If
            End If
        Next
        SetHeight()
        SavePortsConfig()

        tmr_Visible.Tag = 61
    End Sub

    Private Sub SavePortsConfig()
        Dim tmp_Config As String = vbNullString

        For loccnt = 0 To PortsList.Count - 1
            If tmp_Config <> vbNullString Then
                tmp_Config += vbCrLf
            End If

            tmp_Config += PortsList.Item(loccnt).ID + "|" +
                          PortsList.Item(loccnt).PortName + "|" +
                          PortsList.Item(loccnt).BaudRate.ToString + "|" +
                          PortsList.Item(loccnt).Parity.ToString + "|" +
                          PortsList.Item(loccnt).DataBits.ToString + "|" +
                          PortsList.Item(loccnt).StopBits.ToString
        Next

        SaveRegVal("Scan_Ports", tmp_Config)
    End Sub

    Private Function CParity(value As String) As System.IO.Ports.Parity
        Select Case UCase(value)
            Case "EVEN"
                Return System.IO.Ports.Parity.Even
            Case "MARK"
                Return System.IO.Ports.Parity.Mark
            Case "ODD"
                Return System.IO.Ports.Parity.Odd
            Case "SPACE"
                Return System.IO.Ports.Parity.Space
            Case Else
                Return System.IO.Ports.Parity.None
        End Select
    End Function

    Private Function CStopBits(value As String) As System.IO.Ports.StopBits
        Select Case UCase(value)
            Case "ONEPOINTFIVE"
                Return IO.Ports.StopBits.OnePointFive
            Case "TWO"
                Return IO.Ports.StopBits.Two
            Case Else
                Return IO.Ports.StopBits.One
        End Select
    End Function

    Private Sub Title_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gp_Title.MouseUp
        MoveByTitle = False
        tmr_Visible.Tag = 61
        tmr_Visible.Enabled = True
    End Sub

    Public Sub PortSettingsChanged(ByRef sender As ctl_ScanPort)
        SavePortsConfig()

        tmr_Visible.Tag = 61
    End Sub

    Public Sub DataReceived(ByRef sender As ctl_ScanPort, ByVal [Data] As String)
        Dim tmp_Vars As String = vbNullString

        tmp_Vars += "ID=" + sender.ID + "|" +
                    "PORT=" + sender.PortName + "|" +
                    "BAUDRATE=" + sender.BaudRate.ToString + "|" +
                    "PARITY=" + sender.Parity.ToString + "|" +
                    "DATABITS=" + sender.DataBits.ToString + "|" +
                    "STOPBITS=" + sender.StopBits.ToString + "|" +
                    "DATA=" + [Data]

        Upload_Data(sender, tmp_Vars)

        tmr_Visible.Tag = 61
    End Sub

    Private Sub SetHeight()
        Dim OrigCenter As Integer
        Dim OtherHeight As Integer

        OrigCenter = Me.Top + (Me.Height / 2)
        If pnl_Visible.Visible Then
            OtherHeight = 202
        Else
            OtherHeight = 180
        End If

        pnl_Ports.Height = PortsList.Count * 150
        If pnl_Ports.Height + OtherHeight > Screen.GetWorkingArea(New Point((Me.Right - Me.Left) / 2, (Me.Bottom - Me.Top) / 2)).Height Then
            Me.Height = Screen.GetWorkingArea(Me.Location).Height
            Me.Top = 0
            scb_Ports.Maximum = pnl_Ports.Height - pnl_PortArea.Height
            scb_Ports.Maximum += scb_Ports.LargeChange - 1
            scb_Ports.Enabled = True
        Else
            Me.Height = pnl_Ports.Height + OtherHeight
            scb_Ports.Value = 0
            scb_Ports.Maximum = 0
            scb_Ports.Enabled = False
            If OrigCenter - (Me.Height / 2) < 0 Then
                Me.Top = 0
            Else
                Me.Top = OrigCenter - (Me.Height / 2)
            End If
            If Me.Bottom > Screen.GetWorkingArea(Me.Location).Bottom Then
                Me.Top = Me.Top - (Me.Bottom - Screen.GetWorkingArea(Me.Location).Bottom)
            End If
        End If
        pnl_ScannerPorts.Invalidate()
        Me.ResumeLayout()
    End Sub

    Public Function EncPwd(ByVal Password As String) As String
        Dim PwdChars As String = " _0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim XOrChar As String = "0"
        Dim PwdResult As String = vbNullString

        For loccnt = 1 To Len(Password)
            If InStr(PwdChars, Mid(Password, loccnt, 1)) > 0 Then
                PwdResult += Mid(PwdChars, ((InStr(PwdChars, Mid(Password, loccnt, 1)) - 1) Xor (InStr(PwdChars, XOrChar) - 1)) + 1, 1)
            Else
                PwdResult += Mid(Password, loccnt, 1)
            End If
            XOrChar = Mid(PwdResult, loccnt, 1)
        Next

        Return PwdResult
    End Function

    Public Function ReadRegVal(ValueName As String) As String
        Dim regKey As RegistryKey
        Dim retval As String = vbNullString

        regKey = Registry.CurrentUser.OpenSubKey("Software\ScanPoint", True)
        If regKey IsNot Nothing Then
            retval = regKey.GetValue(ValueName)
            regKey.Close()
        End If

        Return retval
    End Function

    Public Sub SaveRegVal(ValueName As String, Value As String)
        Dim regKey As RegistryKey

        If Value Is Nothing Then Value = ""

        regKey = Registry.CurrentUser.OpenSubKey("Software", True)
        regKey.CreateSubKey("ScanPoint")
        regKey = Registry.CurrentUser.OpenSubKey("Software\ScanPoint", True)
        regKey.SetValue(ValueName, Value)
        regKey.Close()

        tmr_Visible.Tag = 61
    End Sub

    Private Sub txt_Address_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Address.KeyUp
        If e.KeyCode = Keys.Enter Then
            If EncPwd(locdlg_Pwd.PlainPwd) <> ReadRegVal("EditPwd") Or locdlg_Pwd.DialogResult <> DialogResult.OK Then
                locdlg_Pwd.Clear()
                locdlg_Pwd.ShowDialog()
            End If

            If locdlg_Pwd.DialogResult = DialogResult.OK And EncPwd(locdlg_Pwd.PlainPwd) = ReadRegVal("EditPwd") Then
                HTTPReceiver_AddLog("ScanPoint", "New address for HTTP Data Receiver configured: ", False)
                SaveRegVal("HTTP_Receiver", txt_Address.Text + "|" + txt_GET.Text)
                HTTPReceiver_AddLog("ScanPoint", "Address saved.")
                CheckHTTPHost()
            End If
        End If
    End Sub

    Private Sub txt_GET_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_GET.KeyUp
        If e.KeyCode = Keys.Enter Then
            If EncPwd(locdlg_Pwd.PlainPwd) <> ReadRegVal("EditPwd") Or locdlg_Pwd.DialogResult <> DialogResult.OK Then
                locdlg_Pwd.Clear()
                locdlg_Pwd.ShowDialog()
            End If

            If locdlg_Pwd.DialogResult = DialogResult.OK And EncPwd(locdlg_Pwd.PlainPwd) = ReadRegVal("EditPwd") Then
                HTTPReceiver_AddLog("ScanPoint", "New GET Format for HTTP Data Receiver configured: ", False)
                SaveRegVal("HTTP_Receiver", txt_Address.Text + "|" + txt_GET.Text)
                HTTPReceiver_AddLog("ScanPoint", "Format saved.")
            End If
        End If
        tmr_Visible.Tag = 61
    End Sub

    Private Sub mnu_ChangePassword_Click(sender As Object, e As EventArgs) Handles mnu_ChangePassword.Click
        Dim tmpdlg_NewPwd As New dlg_NewPwd

        tmpdlg_NewPwd.ShowDialog()

        If tmpdlg_NewPwd.DialogResult = DialogResult.OK Then
            SaveRegVal("EditPwd", EncPwd(tmpdlg_NewPwd.NewPwd))
        End If

        tmr_Visible.Tag = 61
    End Sub

    Private Sub txt_Enter(sender As Object, e As EventArgs) Handles txt_GET.Enter, txt_Address.Enter
        sender.backcolor = Color.Silver
        tmr_Visible.Tag = 61
    End Sub

    Private Sub txt_GET_Leave(sender As Object, e As EventArgs) Handles txt_GET.Leave
        sender.backcolor = Color.DarkGray
        tmr_Visible.Tag = 61
    End Sub

    Private Sub tmr_Visible_Tick(sender As Object, e As EventArgs) Handles tmr_Visible.Tick
        tmr_Visible.Tag -= 1
        pnl_Visible.Width = ((gp_Visible.Width - 4) / 60) * tmr_Visible.Tag

        If tmr_Visible.Tag <= 30 Then
            pnl_Visible.BackColor = Color.Yellow
        ElseIf tmr_Visible.Tag <= 10 Then
            pnl_Visible.BackColor = Color.Red
        Else
            pnl_Visible.BackColor = Color.Lime
        End If

        gp_Visible.Text = Replace(gp_Visible.Tag.ToString, "{X}", tmr_Visible.Tag.ToString)

        If tmr_Visible.Tag = 0 Then
            tmr_Visible.Enabled = False
            tmr_Visible.Tag = 61
            mnu_ShowHide_Click(tmr_Visible, New EventArgs())
        End If
    End Sub

    Private Sub tmr_ScanPortStatus_Tick(sender As Object, e As EventArgs) Handles tmr_ScanPortStatus.Tick
        Dim tmp_Status As TriState = TriState.True

        If PortsList.Count = 0 Then
            tmp_Status = TriState.UseDefault
        Else
            For loccnt = 0 To PortsList.Count - 1
                If PortsList.Item(loccnt).Status = TriState.False Then
                    tmp_Status = TriState.False
                ElseIf PortsList.Item(loccnt).Status = TriState.UseDefault And tmp_Status = TriState.True Then
                    tmp_Status = TriState.UseDefault
                End If
            Next

            Select Case tmp_Status
                Case TriState.True
                    pnl_ScanStatus.BackColor = Color.LimeGreen
                Case TriState.False
                    pnl_ScanStatus.BackColor = Color.Red
                Case Else
                    pnl_ScanStatus.BackColor = Color.Silver
            End Select
        End If
    End Sub

    Private Sub scb_Ports_ValueChanged(sender As Object, e As EventArgs) Handles scb_Ports.ValueChanged
        tmr_Scroll.Enabled = False
        pnl_Ports.SuspendLayout()

        pnl_Ports.Top = 0 - scb_Ports.Value

        tmr_Scroll.Enabled = True
    End Sub

    Private Sub tmr_Scroll_Tick(sender As Object, e As EventArgs) Handles tmr_Scroll.Tick
        tmr_Scroll.Enabled = False
        pnl_Ports.ResumeLayout()
    End Sub
End Class
