Public Class fmRegister
    Private Sub 用户注册_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        lbFlatPass.Visible = False
        lbFlatName.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = txtName.Text
        Dim Pas As String = txtPas.Text
        Dim Certain As String = txtCertain.Text
        Dim em As String = txtEmail.Text & cbxEmail.Text
        Dim sex As Boolean = True
        If rbMan.Checked Then
            sex = True
        Else
            sex = False
        End If
        'insert into Users VALUES ('凯凯','123456','0','0','kaikai@qq.com','1')
        Dim SHelper As SqlHelper = New SqlHelper
        Dim sql As String = "insert into Users VALUES ('" & Name & "','" & Pas & "','0','0','" & em & "','" & sex & "')"
        Dim flag As Integer = SHelper.ExecuteNonQuery(sql)
        If flag = 1 Then
            Dim t(2) As String
            t(0) = Name
            t(1) = em
            Button1.Tag = t
            UserSeurity.Show()
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim txt As String = txtName.Text
        Dim SHelper As SqlHelper = New SqlHelper
        Dim sql As String = "select UId from Users where UName=" & "'" & txt & "'"
        Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        If txtName.Text <> "" Then
            If reader.HasRows Then
                While (reader.Read())
                    If reader("UId") Then
                        lbFlatName.Visible = True
                    Else
                        lbFlatName.Visible = False
                    End If
                End While
            End If
        End If
    End Sub

    Private Sub txtCertain_TextChanged(sender As Object, e As EventArgs) Handles txtCertain.TextChanged
        If txtCertain.Text = txtPas.Text Then
            lbFlatPass.Visible = False
        Else
            lbFlatPass.Visible = True
        End If
    End Sub

    Private Sub cbAccept_CheckedChanged(sender As Object, e As EventArgs) Handles cbAccept.CheckedChanged
        If cbAccept.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_license.Show()
    End Sub
End Class