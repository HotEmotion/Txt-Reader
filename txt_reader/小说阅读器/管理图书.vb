Public Class fmManageBook
    Dim SHelper As SqlHelper = New SqlHelper
    Private Sub 管理图书_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatDgv()
    End Sub

    Private Sub UpdatDgv()
        Dim sql As String = "select BNum, BName 书名, BPer 作者,  BType 类型, BAttr 属性,BPath 路径, BCount 浏览次数 from Book "
        dgv.DataSource = SHelper.ExecuteDataAdapter(sql)
        Dim sql1 As String = "select COUNT(*) from Book "
        lbCount.Text = SHelper.ExecuteScalar(sql1)
        Dim sql2 As String = "select COUNT(*) from Book group by BType having BType='都市异能' "
        lbCity.Text = SHelper.ExecuteScalar(sql2)
        Dim sql3 As String = "select COUNT(*) from Book group by BType having BType='历史军事' "
        lbHis.Text = SHelper.ExecuteScalar(sql3)
        Dim sql4 As String = "select COUNT(*) from Book group by BType having BType='玄幻' "
        lbFantasy.Text = SHelper.ExecuteScalar(sql4)
        Dim sql5 As String = "select COUNT(*) from Book group by BType having BType='言情' "
        lbLove.Text = SHelper.ExecuteScalar(sql5)
        dgv.SelectedRows(0).Selected = False
        dgv.Columns(0).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPath.Text = MoveFileToDebug()
        Dim num As Integer = 0
        Dim sql3 As String = "select BNum from Book where BName= '" & txtName.Text & "'"
        Dim reader1 As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql3)
        If reader1.HasRows Then
            While reader1.Read()
                num = reader1("BNum")
            End While
        End If
        If num = 0 Then
            Dim sql As String = "insert into Book values ('" & txtName.Text & "','" & txtPath.Text & "','" & txtCount.Text & "','" & txtType.Text & "','" & txtAttr.Text & "','" & txtPer.Text & "')"
            Dim flat As Integer = SHelper.ExecuteNonQuery(sql)
            Dim sql1 As String = "select BNum from Book where BName='" & txtName.Text & "'"
            Dim Bnum As Integer = 0
            Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql1)
            If reader.HasRows Then
                While reader.Read()
                    Bnum = reader("BNum")
                End While
            End If
            If flat = 1 Then
                MsgBox("请打开本书简介txt文件并保存")
                Dim Cname As String = txtName.Text
                Dim CParentId As Integer = 0
                Select Case txtType.Text
                    Case "都市异能" : CParentId = 1
                    Case "历史军事" : CParentId = 2
                    Case "玄幻" : CParentId = 3
                    Case "言情" : CParentId = 4
                    Case Else : CParentId = -1
                End Select
                Dim CContent As String = MoveFileToDebug()
                'insert into Category values ('CName','CParentId','CContent')
                Dim sql2 As String = "insert into Category values ('" & Cname & "','" & CParentId & "','" & CContent & "','" & Bnum & "')"
                Dim flag2 As Integer = SHelper.ExecuteNonQuery(sql2)
                If flag2 = 1 Then
                    MsgBox("添加成功！")
                    UpdatDgv()
                Else
                    MsgBox("添加失败！")
                End If
            Else
                MsgBox("添加失败！")
            End If
        Else
            MsgBox("该书已存在，请重录")
        End If
    End Sub

    Private Function MoveFileToDebug() As String
        Dim openFile As OpenFileDialog = New OpenFileDialog
        openFile.InitialDirectory = "D:\\VB\小说"
        openFile.Filter = "文本文件|*.*|所有文件|*.*"
        openFile.RestoreDirectory = True
        openFile.FilterIndex = 1
        Dim fNameWithoutPath As String = ""
        If openFile.ShowDialog = DialogResult.OK Then
            Dim fName As String = openFile.FileName
            fNameWithoutPath = openFile.SafeFileName
            If FileIO.FileSystem.FileExists("D:\\作业\小说阅读器\小说阅读器\bin\Debug\" & fNameWithoutPath) Then
                If (MessageBox.Show("文件已存在，确认覆盖吗？", "提示", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    FileIO.FileSystem.CopyFile(fName, "D:\\作业\小说阅读器\小说阅读器\bin\Debug\" & fNameWithoutPath, True)
                End If
            Else
                FileIO.FileSystem.CopyFile(fName, "D:\\作业\小说阅读器\小说阅读器\bin\Debug\" & fNameWithoutPath)
            End If
        End If
        Return fNameWithoutPath

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MessageBox.Show("确认要修改吗？", "提示", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            'update Book set BName='华娱', BPath='b1.txt', BCount='10', BType='都市异能', BAttr='VIP', BPer='二手男人当自强' where BNum=1
            Dim sql As String = "update Book set BName='" & txtName.Text & "', BPath='" & txtPath.Text & "', BCount='" & txtCount.Text & "', BType='" & txtType.Text & "', BAttr='" & txtAttr.Text & "V', BPer='" & txtPer.Text & "' where BNum=" & BNum
            Dim flat = SHelper.ExecuteNonQuery(sql)
            If flat = 1 Then
                MsgBox("修改成功！")
            Else
                MsgBox("修改失败！")
            End If
            UpdatDgv()
        End If
    End Sub
    Dim BNum As Integer = 0
    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        BNum = dgv.CurrentRow.Cells(0).Value
        txtName.Text = dgv.CurrentRow.Cells(1).Value
        txtPer.Text = dgv.CurrentRow.Cells(2).Value
        txtType.Text = dgv.CurrentRow.Cells(3).Value
        txtAttr.Text = dgv.CurrentRow.Cells(4).Value
        txtPath.Text = dgv.CurrentRow.Cells(5).Value
        txtCount.Text = dgv.CurrentRow.Cells(6).Value
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MessageBox.Show("确认要删除吗？", "提示", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Dim FilePath As String = "D:\作业\小说阅读器\小说阅读器\bin\Debug\" & txtPath.Text
            Dim SHelper1 As SqlHelper = New SqlHelper
            Dim sql1 As String = "select CContent  from Category where CBNum=" & BNum
            Dim content As String = ""
            Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql1)
            If reader.HasRows Then
                While reader.Read()
                    content = reader("CContent")
                End While
            End If
            Dim ContentPath As String = "D:\作业\小说阅读器\小说阅读器\bin\Debug\" & content
            FileIO.FileSystem.DeleteFile(ContentPath)
            FileIO.FileSystem.DeleteFile(FilePath)
            Dim sql2 As String = "delete from Book where BNum=" & BNum
            Dim sql3 As String = "delete from Category where CBNum=" & BNum
            Dim flag1 As Integer = SHelper.ExecuteNonQuery(sql2)
            Dim flag2 As Integer = SHelper.ExecuteNonQuery(sql3)
            If flag1 = 1 And flag2 = 1 Then
                MsgBox("删除成功")
            Else
                MsgBox("删除失败")
            End If
            UpdatDgv()
        End If
    End Sub
End Class
