Public Class fmUserVerify
    Dim a1 As String = ""
    Dim a2 As String = ""
    Dim a3 As String = ""
    Private Sub fmUserVerify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Dim t() As String = fmReturnPass.Button1.Tag
        Dim name As String = t(1)
        Dim em As String = t(2)
        Dim SHelper As SqlHelper = New SqlHelper
        'select Q1,Q2, Q3, A1, A2, A3 from UserSecurity where Name='孙宇' and Email='sunyu@qq.com'
        Dim sql As String = "select Q1,Q2, Q3, A1, A2, A3 from UserSecurity where Name='" & name & "' and Email='" & em & "'"
        Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        If reader.HasRows Then
            While reader.Read()
                lbQ1.Text = reader("Q1")
                lbQ2.Text = reader("Q2")
                lbQ3.Text = reader("Q3")
                a1 = reader("A1")
                a2 = reader("A2")
                a3 = reader("A3")
            End While
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a1 = txtA1.Text And a2 = txtA2.Text And a3 = txtA3.Text Then
            Me.Hide()
            fmMotifyPsd.Show()
        Else
            MsgBox("答案错误，验证失败，请重试！")
        End If
    End Sub

    Private Sub txtA3_TextChanged(sender As Object, e As EventArgs) Handles txtA3.TextChanged
        If txtA1.Text <> "" And txtA2.Text <> "" And txtA3.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub
End Class