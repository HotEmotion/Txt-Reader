Public Class fmMotifyPsd
    Private Sub 修改密码_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        lbFlag.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim psd As String = txtPsd1.Text
        Dim SHelper As SqlHelper = New SqlHelper
        Dim t() As String = fmReturnPass.Button1.Tag
        Dim id As Integer = Convert.ToInt32(t(0))
        'update Users set UPasw ='456789' where UId = 1
        Dim sql As String = "update Users set UPasw='" & psd & "' where UId=" & id
        Dim flat As Integer = SHelper.ExecuteNonQuery(sql)
        If flat = 1 Then
            MsgBox("修改成功！")
            Me.Hide()
        Else
            MsgBox("修改失败！")
        End If
    End Sub

    Private Sub txtPsd2_TextChanged(sender As Object, e As EventArgs) Handles txtPsd2.TextChanged
        If txtPsd1.Text = txtPsd2.Text Then
            lbFlag.Visible = False
            Button1.Enabled = True
        Else
            lbFlag.Visible = True
        End If
    End Sub
End Class