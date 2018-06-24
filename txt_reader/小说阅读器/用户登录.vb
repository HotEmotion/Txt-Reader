Public Class fmUserLogin
    Private Sub 用户登录_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = txtName.Text
        Dim Pass As String = txtPass.Text
        Dim SHelper As SqlHelper = New SqlHelper
        Dim sql As String = "select  UPasw,UVip,USex from Users where UName=" & "'" & Name & "'"
        Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        If reader.HasRows Then
            While reader.Read()
                If Pass = (reader("UPasw").ToString()) Then
                    MsgBox("登录成功！")
                    fmMain.PictureBox5.Visible = False
                    fmMain.PictureBox6.Visible = False
                    Dim vip As Boolean = reader("UVip")
                    Dim sex As Boolean = reader("USex")
                    If vip And sex Then
                        Me.Hide()
                        fmMain.PMV.Visible = True
                        fmMain.lbmvv.Text = Name
                        fmMain.Refresh()
                    ElseIf vip = False And sex Then
                        Me.Hide()
                        fmMain.PMN.Visible = True
                        fmMain.lbmnn.Text = Name
                        fmMain.Refresh()
                    ElseIf vip And sex = False Then
                        Me.Hide()
                        fmMain.PWV.Visible = True
                        fmMain.lbwvv.Text = Name
                        fmMain.Refresh()
                    ElseIf vip = False And sex = False Then
                        Me.Hide()
                        fmMain.PWN.Visible = True
                        fmMain.lbwnn.Text = Name
                        fmMain.Refresh()
                    End If
                Else
                    MsgBox("密码错误！")
                End If
            End While
        Else
            MsgBox("用户名不存在！")
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fmRegister.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        fmReturnPass.Show()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtName.Text <> "" And txtPass.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub lbAdminLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbAdminLogin.LinkClicked
        fmAdminLogin.Show()
    End Sub
End Class