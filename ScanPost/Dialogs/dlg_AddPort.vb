Imports System.Windows.Forms

Public Class dlg_AddPort
    Dim l_PortListLoaded As Boolean = False
    Dim l_PortListLoading As Boolean = False

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Trim(PortID.Text) <> vbNullString Then
            Dim IDDoNotExist As Boolean = True
            For PortCnt = 0 To frm_ScanPost.PortsList.Count - 1
                If PortID.Text = frm_ScanPost.PortsList.Item(PortCnt).ID Then
                    IDDoNotExist = False
                    Exit For
                End If
            Next

            If IDDoNotExist Then
                If (IsNumeric(cb_Port.Text) AndAlso (Val(cb_Port.Text) <= 255 And Val(cb_Port.Text) > 0)) Or (UCase(Mid(cb_Port.Text, 1, 3)) = "COM" And (IsNumeric(Mid(cb_Port.Text, 4)) AndAlso (Val(Mid(cb_Port.Text, 4)) <= 255 And Val(Mid(cb_Port.Text, 4)) > 0))) Then
                    If IsNumeric(cb_Port.Text) Then
                        cb_Port.Text = "COM" + cb_Port.Text
                    End If
                    cb_Port.Text = "COM" + Val(Mid(cb_Port.Text, 4)).ToString

                    Dim PortDoNotExist As Boolean = True
                    For PortCnt = 0 To frm_ScanPost.PortsList.Count - 1
                        If cb_Port.Text = frm_ScanPost.PortsList.Item(PortCnt).PortName Then
                            PortDoNotExist = False
                            Exit For
                        End If
                    Next

                    If PortDoNotExist Then
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        cb_Port.BackColor = Color.Yellow
                    End If
                Else
                    cb_Port.BackColor = Color.Red
                End If
            Else
                PortID.BackColor = Color.Yellow
            End If
        Else
            PortID.BackColor = Color.Red
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub Clear()
        PortID.Text = vbNullString
        cb_Port.Text = vbNullString
        Dim loc_PortNo As Integer = 0

        Do While Trim(PortID.Text) = vbNullString
            loc_PortNo += 1

            Dim IDDoNotExist As Boolean = True
            For PortCnt = 0 To frm_ScanPost.PortsList.Count - 1
                If frm_ScanPost.PortsList.Item(PortCnt).ID = "Scanner_" + loc_PortNo.ToString Then
                    IDDoNotExist = False
                    Exit For
                End If
            Next

            If IDDoNotExist Then
                PortID.Text = "Scanner_" + loc_PortNo.ToString
            End If
        Loop
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        cb_BaudRate.SelectedIndex = 6
        cb_Parity.SelectedIndex = 0
        cb_DataBits.SelectedIndex = 3
        cb_StopBits.SelectedIndex = 0

        'Dim tmp_Port As New System.IO.Ports.SerialPort

        'For loccnt = 1 To 256
        '    Try
        '        tmp_Port.PortName = "COM" + Trim(Str(loccnt))
        '        tmp_Port.Open()
        '        tmp_Port.Close()
        '        cb_Port.Items.Add("COM" + Trim(Str(loccnt)))
        '        If cb_Port.SelectedIndex < 0 Then
        '            cb_Port.SelectedIndex = cb_Port.Items.Count - 1
        '        End If
        '    Catch ex As Exception
        '        If ex.Message <> "The port 'COM" + Trim(Str(loccnt)) + "' does not exist." Then
        '            cb_Port.Items.Add("COM" + Trim(Str(loccnt)))
        '            If cb_Port.SelectedIndex < 0 Then
        '                cb_Port.SelectedIndex = cb_Port.Items.Count - 1
        '            End If
        '        End If
        '        'MsgBox(ex.Message)
        '    End Try
        'Next
        'cb_Port.Items.Add("COM99")
        'If cb_Port.SelectedIndex < 0 Then
        '    cb_Port.SelectedIndex = cb_Port.Items.Count - 1
        'End If
    End Sub

    Public Overloads Function ShowDialog(owner As System.Windows.Forms.IWin32Window) As DialogResult
        If Not l_PortListLoaded Then
            l_PortListLoading = True
            bw_Progress.RunWorkerAsync()

            Dim tmp_Port As New System.IO.Ports.SerialPort()
            For loccnt = 1 To 256
                Try
                    tmp_Port.PortName = "COM" + Trim(Str(loccnt))
                    tmp_Port.Open()
                    System.Threading.Thread.Sleep(100)
                    'MsgBox(tmp_Port.PortName)
                    tmp_Port.Close()
                    cb_Port.Items.Add("COM" + Trim(Str(loccnt)))
                    If cb_Port.SelectedIndex < 0 Then
                        cb_Port.SelectedIndex = cb_Port.Items.Count - 1
                    End If
                Catch ex As Exception
                    If ex.Message <> "The port 'COM" + Trim(Str(loccnt)) + "' does not exist." Then
                        cb_Port.Items.Add("COM" + Trim(Str(loccnt)))
                        If cb_Port.SelectedIndex < 0 Then
                            cb_Port.SelectedIndex = cb_Port.Items.Count - 1
                        End If
                    End If
                    'MsgBox(ex.Message)
                End Try
            Next
            l_PortListLoaded = True
        End If
        l_PortListLoading = False

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub dlg_AddPort_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    End Sub

    Private Sub dlg_AddPort_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cb_Port.SelectedIndex = -1

        If cb_Port.Items.Count > 0 Then
            For loccnt = 0 To cb_Port.Items.Count - 1
                Dim PortDoNotExist As Boolean = True
                For PortCnt = 0 To frm_ScanPost.PortsList.Count - 1
                    If cb_Port.Items(loccnt) = frm_ScanPost.PortsList.Item(PortCnt).PortName Then
                        PortDoNotExist = False
                        Exit For
                    End If
                Next
                If PortDoNotExist Then
                    cb_Port.SelectedIndex = loccnt
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub bw_Progress_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Progress.DoWork
        Dim tmp_progress As New dlg_Progress
        tmp_progress.Show()

        Do While l_PortListLoading
            tmp_progress.PerformLayout()
            Application.DoEvents()
        Loop

        tmp_progress.Hide()
        tmp_progress = Nothing
    End Sub

    Private Sub cb_Port_TextChanged(sender As Object, e As EventArgs) Handles cb_Port.TextChanged, PortID.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub
End Class
