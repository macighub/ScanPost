Public Class ctl_ScanPort
    Dim tt_PortName As New ToolTip
    Dim PortIsOpen As Boolean = False
    Dim p_ChangeEnabled As Boolean = False
    Dim p_OutPutPort As String = "None"

    Const SpecialChars = "NUL,SOH,STX,ETX,EOT,ENQ,ACK,BEL,BS,TAB,LF,VT,FF,CR,SO,SI,DLE,DC1,DC2,DC3,DC4,NAK,SYN,ETB,CAN,EM,SUB,ESC,FS,GS,RS,US,SP"

    Public Delegate Sub MakeLog_Delegate(ByVal LogText As String)

    Private locdlg_RemovePort As dlg_RemovePort

    Public Event LogEvent(ByRef sender As ctl_ScanPort, ByVal LogText As String)
    Public Event RemoveEvent(ByRef sender As ctl_ScanPort)
    Public Event PortSettingsChanged(ByRef sender As ctl_ScanPort)
    Public Event DataReceived(ByRef sender As ctl_ScanPort, ByVal [Data] As String)

    Public Property ChangeEnabled() As Boolean
        Get
            Return p_ChangeEnabled
        End Get
        Set(value As Boolean)
            p_ChangeEnabled = value
        End Set
    End Property

    Public ReadOnly Property Status As TriState
        Get
            Select Case btn_PortID.BackColor
                Case Color.Red
                    Return TriState.False
                Case Color.Green
                    Return TriState.True
                Case Else
                    Return TriState.UseDefault
            End Select
        End Get
    End Property

    Public Property ID() As String
        Get
            Return btn_PortID.Text
        End Get
        Set(value As String)
            btn_PortID.Text = value
        End Set
    End Property

    Public Property PortName() As String
        Get
            Return sp_PortLogger.PortName
        End Get
        Set(value As String)
            sp_PortLogger.PortName = value
            txt_PortName.Text = value
        End Set
    End Property

    Public Property BaudRate() As Integer
        Get
            Return sp_PortLogger.BaudRate
        End Get
        Set(value As Integer)
            sp_PortLogger.BaudRate = value
            cb_BaudRate.Text = value.ToString
        End Set
    End Property

    Public Property Parity() As System.IO.Ports.Parity
        Get
            Return sp_PortLogger.Parity
        End Get
        Set(value As System.IO.Ports.Parity)
            sp_PortLogger.Parity = value
            cb_Parity.Text = value.ToString
        End Set
    End Property

    Public Property DataBits() As Integer
        Get
            Return sp_PortLogger.DataBits
        End Get
        Set(value As Integer)
            sp_PortLogger.DataBits = value
            cb_DataBits.Text = value.ToString
        End Set
    End Property

    Public Property StopBits() As System.IO.Ports.StopBits
        Get
            Return sp_PortLogger.StopBits
        End Get
        Set(value As System.IO.Ports.StopBits)
            sp_PortLogger.StopBits = value
            cb_StopBits.Text = value.ToString
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        tt_PortName.SetToolTip(btn_PortID, "Port closed")
        locdlg_RemovePort = New dlg_RemovePort
    End Sub

    Public Sub New([ID] As String, [PortName] As String, [BaudRate] As Integer, [Parity] As System.IO.Ports.Parity, [DataBits] As Integer, [StopBits] As System.IO.Ports.StopBits)
        Me.New()

        With sp_PortLogger
            .PortName = [PortName]
            .BaudRate = [BaudRate]
            .Parity = [Parity]
            .DataBits = [DataBits]
            .StopBits = [StopBits]
        End With
        btn_PortID.Text = [ID]
        txt_PortName.Text = [PortName]
        cb_BaudRate.Text = [BaudRate].ToString
        cb_Parity.Text = [Parity].ToString
        cb_DataBits.Text = [DataBits].ToString
        cb_StopBits.Text = [StopBits].ToString
    End Sub

    Public Sub OpenPort()
        Dim tmp_MakeLog As Boolean = False
        If Not PortIsOpen Then
            tmp_MakeLog = True
        End If
        PortIsOpen = True
        If Not sp_PortLogger.IsOpen Then
            Try
                sp_PortLogger.Open()
                tmr_PortOpen.Enabled = False
                btn_PortID.BackColor = Color.Green
                tt_PortName.SetToolTip(btn_PortID, "Port opened")
                MakeLog("Port successfully opened.")
            Catch ex As Exception
                If ex.Message = "The port '" + sp_PortLogger.PortName + "' does not exist." Then
                    btn_PortID.BackColor = Color.Red
                    If tt_PortName.GetToolTip(btn_PortID) <> ex.Message Then tt_PortName.SetToolTip(btn_PortID, ex.Message)
                Else
                    btn_PortID.BackColor = Color.Yellow
                    If tt_PortName.GetToolTip(btn_PortID) <> ex.Message Then tt_PortName.SetToolTip(btn_PortID, ex.Message)
                End If
                tmr_PortOpen.Enabled = True
                If tmp_MakeLog Then
                    MakeLog(ex.Message)
                End If
            End Try
        End If
        cb_BaudRate.Enabled = False
        cb_DataBits.Enabled = False
        cb_Parity.Enabled = False
        cb_StopBits.Enabled = False
    End Sub

    Public Sub ClosePort()
        Dim tmp_MakeLog As Boolean = False

        If PortIsOpen Then
            tmp_MakeLog = True
            tmr_PortOpen.Enabled = False
            PortIsOpen = False
            If sp_PortLogger.IsOpen Then
                sp_PortLogger.Close()
            End If
        End If
        If Not sp_PortLogger.IsOpen Then
            If tmp_MakeLog Then
                MakeLog("Port closed.")
            End If
            btn_PortID.BackColor = Color.DimGray
            tt_PortName.SetToolTip(btn_PortID, "Port closed")
            cb_BaudRate.Enabled = True
            cb_DataBits.Enabled = True
            cb_Parity.Enabled = True
            cb_StopBits.Enabled = True
        End If
    End Sub

    Private Sub btn_PortID_Click(sender As Object, e As EventArgs) Handles btn_PortID.Click
        If PortIsOpen Then
            ClosePort()
        Else
            OpenPort()
        End If
    End Sub

    Private Sub tmr_PortOpen_Tick(sender As Object, e As EventArgs) Handles tmr_PortOpen.Tick
        If Not sp_PortLogger.IsOpen Then
            OpenPort()
        End If
    End Sub

    Private Sub MakeLog(LogText As String)
        If txt_Log.InvokeRequired Then
            txt_Log.BeginInvoke(New MakeLog_Delegate(AddressOf MakeLog), LogText)
        Else
            txt_Log.Text += Now.ToLocalTime.ToString + " - " +
                            LogText + vbCrLf
            txt_Log.SelectionStart = Len(txt_Log.Text)
            txt_Log.ScrollToCaret()

            RaiseEvent LogEvent(Me, LogText)
        End If
    End Sub

    Private Sub sp_PortLogger_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs)
        If e.EventType = IO.Ports.SerialData.Chars Then
            DataRead()
        End If
    End Sub

    Private Sub DataRead()
        Dim ReceivedData As String = sp_PortLogger.ReadExisting

        System.Threading.Thread.Sleep(100)

        ReceivedData = Replace(ReceivedData, Chr(127), "<DEL>")
        ReceivedData = Replace(ReceivedData, vbNullChar, "<NUL>")
        For loccnt = 1 To UBound(Split(SpecialChars, ","))
            ReceivedData = Replace(ReceivedData, Chr(loccnt), "<" + Split(SpecialChars, ",").ElementAt(loccnt) + ">")
        Next

        MakeLog("Data received: " + ReceivedData)

        RaiseEvent DataReceived(Me, ReceivedData)
    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        If Not dlg_RemovePort.Visible Then
            Dim tmp_RemoveConfirm As DialogResult

            dlg_RemovePort.lbl_Title.Text = btn_PortID.Text
            tmp_RemoveConfirm = dlg_RemovePort.ShowDialog

            If tmp_RemoveConfirm = DialogResult.Yes Then
                ClosePort()
                RaiseEvent RemoveEvent(Me)
            End If
        End If
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

    Private Sub cb_BaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_BaudRate.SelectedIndexChanged
        If p_ChangeEnabled Then
            sp_PortLogger.BaudRate = CInt(cb_BaudRate.Text)
            RaiseEvent PortSettingsChanged(Me)
        Else
            For loccnt = 0 To cb_BaudRate.Items.Count - 1
                If cb_BaudRate.Items(loccnt) = sp_PortLogger.BaudRate.ToString Then
                    cb_BaudRate.SelectedIndex = loccnt
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cb_Parity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Parity.SelectedIndexChanged
        If p_ChangeEnabled Then
            sp_PortLogger.Parity = CParity(cb_Parity.Text)
            RaiseEvent PortSettingsChanged(Me)
        Else
            For loccnt = 0 To cb_Parity.Items.Count - 1
                If cb_Parity.Items(loccnt) = sp_PortLogger.Parity.ToString Then
                    cb_Parity.SelectedIndex = loccnt
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cb_DataBits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_DataBits.SelectedIndexChanged
        If p_ChangeEnabled Then
            sp_PortLogger.DataBits = CInt(cb_DataBits.Text)
            RaiseEvent PortSettingsChanged(Me)
        Else
            For loccnt = 0 To cb_DataBits.Items.Count - 1
                If cb_DataBits.Items(loccnt) = sp_PortLogger.DataBits.ToString Then
                    cb_DataBits.SelectedIndex = loccnt
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cb_StopBits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_StopBits.SelectedIndexChanged
        If p_ChangeEnabled Then
            sp_PortLogger.StopBits = CStopBits(cb_StopBits.Text)
            RaiseEvent PortSettingsChanged(Me)
        Else
            For loccnt = 0 To cb_StopBits.Items.Count - 1
                If cb_StopBits.Items(loccnt) = sp_PortLogger.StopBits.ToString Then
                    cb_StopBits.SelectedIndex = loccnt
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub tmr_PortRead_Tick(sender As Object, e As EventArgs) Handles tmr_PortRead.Tick
        If sp_PortLogger.IsOpen AndAlso sp_PortLogger.BytesToRead > 0 Then
            DataRead()
        End If
    End Sub
End Class