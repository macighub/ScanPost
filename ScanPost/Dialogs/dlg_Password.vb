Public Class dlg_Password
    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()

        '
        ' TODO : Add constructor code after InitializeComponents
        '
    End Sub

    Public Sub Clear()
        txt_Password.Text = vbNullString
        tmr_TimeOut.Enabled = False
        Me.DialogResult = DialogResult.None
    End Sub

    Sub Dlg_AdminPwd_Load(sender As Object, e As EventArgs) Handles Me.Load
        kp_Main.EditBox = txt_Password
    End Sub

    Public ReadOnly Property PlainPwd() As String
        Get
            Return txt_Password.Text
        End Get
    End Property

    Private Sub btn_OK_Click_1(sender As Object, e As EventArgs) Handles btn_OK.Click
        tmr_TimeOut.Enabled = False
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub textBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Password.KeyUp
        If e.KeyCode = Keys.Enter Then
            tmr_TimeOut.Enabled = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dlg_Password_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not tmr_TimeOut.Enabled Then
            tmr_TimeOut.Enabled = True
            tmr_TimeOut.Tag = 10
            pnl_TimeOut.Width = (Me.ClientSize.Width - 16)
            pnl_TimeOut.BackColor = Color.Green
        End If
        Me.Activate()
        Me.Focus()
        txt_Password.Select()
        txt_Password.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmr_TimeOut.Tick
        tmr_TimeOut.Tag -= 1
        If tmr_TimeOut.Tag = 0 Then
            tmr_TimeOut.Enabled = False
            Me.DialogResult = Windows.Forms.DialogResult.No
        Else
            pnl_TimeOut.Width = ((Me.ClientSize.Width - 16) / 10) * tmr_TimeOut.Tag
            If tmr_TimeOut.Tag <= 2 Then
                pnl_TimeOut.BackColor = Color.Red
            ElseIf tmr_TimeOut.Tag <= 5 Then
                pnl_TimeOut.BackColor = Color.Yellow
            Else
                pnl_TimeOut.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged
        tmr_TimeOut.Enabled = False
        tmr_TimeOut.Tag = 10
        pnl_TimeOut.BackColor = Color.Green
        pnl_TimeOut.Width = Me.ClientSize.Width - 16
        tmr_TimeOut.Enabled = True
    End Sub
End Class
