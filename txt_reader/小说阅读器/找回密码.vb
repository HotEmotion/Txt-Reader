Public Class fmReturnPass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim name As String = txtName.Text
        Dim em As String = txtEmail.Text
        Dim SHelper As SqlHelper = New SqlHelper
        ' select UId from Users where UName='孙宇' and UEmail='sunyu@163.com'
        Dim sql As String = " select UId from Users where UName='" & name & "' and UEmail='" & em & "'"
        Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        If reader.HasRows Then
            While reader.Read()
                If reader("UId") Then
                    Dim t(3) As String
                    Dim id As Integer = reader("UId")
                    t(0) = id
                    t(1) = name
                    t(2) = em
                    Button1.Tag = t
                    Me.Hide()
                    fmUserVerify.Show()
                Else
                    MsgBox("用户名不存在或信息不一致")
                End If
            End While
        End If
    End Sub

    Private Sub 找回密码_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If txtName.Text <> "" And txtEmail.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub
End Class