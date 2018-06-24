Public Class fmSelect
    Dim SHelper As SqlHelper = New SqlHelper
    Private Sub 搜索界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book "
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
        dgv.SelectedCells(0).Selected = False
        dgv.Columns(0).Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BName='" & txtName.Text & "'"
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub
    Private Sub lbCity_Click(sender As Object, e As EventArgs) Handles lbCity.Click
        lbAll.Visible = False
        lbRCity.Visible = True
        lbRFantasy.Visible = False
        lbRHistory.Visible = False
        lbRLove.Visible = False
        lbCity.BackColor = Color.Red
        lbHistory.BackColor = Color.Transparent
        lbFantasy.BackColor = Color.Transparent
        lbLove.BackColor = Color.Transparent
        Dim sql As String = ""
        If lbRFree.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='都市异能' and BAttr='免费'"
        ElseIf lbRVIP.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='都市异能' and BAttr='VIP'"
        Else
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='都市异能'"
        End If
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub

    Private Sub lbHistory_Click(sender As Object, e As EventArgs) Handles lbHistory.Click

        lbAll.Visible = False
        lbRCity.Visible = False
        lbRFantasy.Visible = False
        lbRHistory.Visible = True
        lbRLove.Visible = False
        lbHistory.BackColor = Color.Red
        lbCity.BackColor = Color.Transparent
        lbFantasy.BackColor = Color.Transparent
        lbLove.BackColor = Color.Transparent
        Dim sql As String = ""
        If lbRFree.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='历史军事' and BAttr='免费'"
        ElseIf lbRVIP.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='历史军事' and BAttr='VIP'"
        Else
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='历史军事'"
        End If
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub

    Private Sub lbFantasy_Click(sender As Object, e As EventArgs) Handles lbFantasy.Click
        lbAll.Visible = False
        lbRCity.Visible = False
        lbRFantasy.Visible = True
        lbRHistory.Visible = False
        lbRLove.Visible = False
        lbFantasy.BackColor = Color.Red
        lbHistory.BackColor = Color.Transparent
        lbCity.BackColor = Color.Transparent
        lbLove.BackColor = Color.Transparent
        Dim sql As String = ""
        If lbRFree.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='玄幻' and BAttr='免费'"
        ElseIf lbRVIP.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='玄幻' and BAttr='VIP'"
        Else
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='玄幻'"
        End If
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub

    Private Sub lbLove_Click(sender As Object, e As EventArgs) Handles lbLove.Click
        lbAll.Visible = False
        lbRCity.Visible = False
        lbRFantasy.Visible = False
        lbRHistory.Visible = False
        lbRLove.Visible = True
        lbLove.BackColor = Color.Red
        lbHistory.BackColor = Color.Transparent
        lbCity.BackColor = Color.Transparent
        lbFantasy.BackColor = Color.Transparent
        Dim sql As String = ""
        If lbRFree.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='言情' and BAttr='免费'"
        ElseIf lbRVIP.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='言情' and BAttr='VIP'"
        Else
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BType='言情'"
        End If
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub

    Private Sub lbFree_Click(sender As Object, e As EventArgs) Handles lbFree.Click
        lbAll.Visible = False
        lbRVIP.Visible = False
        lbRFree.Visible = True
        lbFree.BackColor = Color.Red
        lbVIP.BackColor = Color.Transparent
        Dim sql As String = ""
        If lbRHistory.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='免费' and BType='历史军事'"
        ElseIf lbRLove.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='免费' and BType='言情'"
        ElseIf lbRFantasy.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='免费' and BType='玄幻'"
        ElseIf lbRCity.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='免费' and BType='都市异能'"
        Else
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='免费'"
        End If
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub

    Private Sub lbVIP_Click(sender As Object, e As EventArgs) Handles lbVIP.Click
        lbAll.Visible = False
        lbRVIP.Visible = True
        lbRFree.Visible = False
        lbFree.BackColor = Color.Transparent
        lbVIP.BackColor = Color.Red
        Dim sql As String = ""
        If lbRHistory.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='VIP' and BType=历史军事''"
        ElseIf lbRLove.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='VIP' and BType='言情'"
        ElseIf lbRFantasy.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='VIP' and BType='玄幻'"
        ElseIf lbRCity.Visible = True Then
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='VIP' and BType='都市异能'"
        Else
            sql = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性, BCount 浏览次数 from Book where BAttr='VIP'"
        End If
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
    End Sub

    Private Sub dgv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv.MouseDoubleClick
        If fmMain.PictureBox5.Visible = False Then
            fmRead.Tag = dgv.CurrentRow.Cells(0).Value
            If dgv.CurrentRow.Cells(4).Value = "VIP" Then
                If fmMain.PWV.Visible = True Or fmMain.PMV.Visible = True Then
                    fmRead.Show()
                Else
                    MsgBox("请开通VIP")
                    fmOpenVIP.Show()
                End If
            Else
                fmRead.Show()
            End If
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If

    End Sub
End Class