Partial Public Class dlg_NewPwd
    Private SecurityText As String

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()

        '
        ' TODO : Add constructor code after InitializeComponents
        '
    End Sub

    Sub Dlg_AdminPwd_Load(sender As Object, e As EventArgs) Handles Me.Load
        Keypad.EditBox = txt_OldPwd
        txt_OldPwd.Focus()
    End Sub

    Public ReadOnly Property OldPwd() As String
        Get
            Return txt_OldPwd.Text
        End Get
    End Property

    Public ReadOnly Property NewPwd() As String
        Get
            Return txt_NewPwd.Text
        End Get
    End Property

    Public ReadOnly Property ConfirmPwd() As String
        Get
            Return txt_ConfirmPwd.Text
        End Get
    End Property

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        OK_Result()
    End Sub

    Private Sub txt_OldPwd_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_OldPwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            Keypad.EditBox = txt_NewPwd
            txt_NewPwd.Select()
            txt_NewPwd.Focus()
        End If
    End Sub

    Private Sub txt_NewPwd_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_NewPwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            Keypad.EditBox = txt_ConfirmPwd
            txt_ConfirmPwd.Select()
            txt_ConfirmPwd.Focus()
        End If
    End Sub

    Private Sub txt_ConfirmPwd_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_ConfirmPwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            OK_Result()
        End If
    End Sub

    Private Sub OK_Result()
        If frm_ScanPost.EncPwd(txt_OldPwd.Text) = frm_ScanPost.ReadRegVal("EditPwd") Then
            If txt_NewPwd.Text = txt_ConfirmPwd.Text Then
                Me.DialogResult = DialogResult.OK
            Else
                gp_Message.ForeColor = Color.Yellow
                gp_Message.Text = """New"" and ""Confirm"" passwords do not match!"
            End If
        Else
            gp_Message.ForeColor = Color.Red
            gp_Message.Text = "Incorrect ""Old"" password!"
        End If
    End Sub

    Private Sub dlg_Password_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Activate()
        Me.Focus()
        txt_OldPwd.Select()
        txt_OldPwd.Focus()
    End Sub

    Private Sub txt_Pwd_Enter(sender As Object, e As EventArgs) Handles txt_OldPwd.Enter, txt_NewPwd.Enter, txt_ConfirmPwd.Enter
        sender.backcolor = System.Drawing.Color.Silver
        Keypad.EditBox = sender
    End Sub

    Private Sub txt_Pwd_Leave(sender As Object, e As EventArgs) Handles txt_OldPwd.Leave, txt_NewPwd.Leave, txt_ConfirmPwd.Leave
        sender.backcolor = System.Drawing.Color.DarkGray
    End Sub

    Private Sub txt_NewPwd_TextChanged(sender As Object, e As EventArgs) Handles txt_NewPwd.TextChanged, txt_ConfirmPwd.TextChanged, txt_OldPwd.TextChanged
        'lbl_Message.Text = vbNullString
        gp_Message.Text = vbNullString
    End Sub
End Class
