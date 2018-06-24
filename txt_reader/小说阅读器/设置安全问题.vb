Public Class UserSeurity
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim q1 As String = cmbQ1.Text
        Dim q2 As String = cmbQ2.Text
        Dim q3 As String = cmbQ3.Text
        Dim a1 As String = txtA1.Text
        Dim a2 As String = txtA2.Text
        Dim a3 As String = txtA3.Text
        Dim t(2) As String
        t = fmRegister.Button1.Tag
        Dim name As String = t(0)
        Dim em As String = t(1)
        Dim SHelper As SqlHelper = New SqlHelper
        'insert into UserSecurity values ('孙宇','sunyu@qq.com','你的初中班主任的名字？','你的高中班主任名字？','你的家乡是?','劲松','蔡澜','山西')
        Dim sql As String = "insert into UserSecurity values ('" & name & "','" & em & "','" & q1 & "','" & q2 & "','" & q3 & "','" & a1 & "','" & a2 & "','" & a3 & "')"
        Dim flat As Integer = 0
        flat = SHelper.ExecuteNonQuery(sql)
        If flat = 1 Then
            Me.Hide()
            MsgBox("注册成功！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub UserSeurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub txtA3_TextChanged(sender As Object, e As EventArgs) Handles txtA3.TextChanged
        If cmbQ1.Text <> "" And cmbQ2.Text <> "" And cmbQ2.Text <> "" And txtA1.Text <> "" And txtA2.Text <> "" And txtA3.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub
End Class