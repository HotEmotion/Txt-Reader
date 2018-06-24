Public Class fmAdminLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNum.Text = "admin001" And txtPas.Text = "123456" Then
            fmManageBook.Show()
        End If
    End Sub

    Private Sub fmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class