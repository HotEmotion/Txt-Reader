Imports System.IO
Imports System.Runtime.Serialization.Formatters

Public Class fmRead
    Dim page1 As String = ""
    Dim lastPage As String = ""
    Dim Num As Integer = 0

    Private Sub 阅读器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SHelper As SqlHelper = New SqlHelper
        Dim sql As String = "select BPath,BCount  from Book where BNum=" & Me.Tag
        Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        Dim path As String = ""
        Dim count As Integer = 0
        If reader.HasRows Then
            While reader.Read()
                path = reader("BPath")
                count = reader("BCount")
            End While
        End If
        count = count + 1
        Dim sql1 As String = "update Book set BCount=" & count & " where BNum=" & Me.Tag
        SHelper.ExecuteNonQuery(sql1)
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim f As Object
        Dim str As String = ""

        f = fso.OpenTextFile(path, 1, False) '第二个参数 1 表示只读打开，第三个参数表示目标文件不存在时是否创建  
        str = f.ReadAll() '从当前位置向后读取，直到文件结束，并将当前位置移动到文件的最后 
        f.Close()
        f = Nothing
        fso = Nothing
        Dim internal As Integer = 50000
        Num = (Len(str) - 1) / internal
        Dim Result(Num) As String
        fmProgress.Show()
        fmProgress.pgb.Maximum = Num
        Dim Percent As Integer = 0
        For i = 0 To Num - 1
            fmProgress.pgb.Value = i
            Result(i) = Mid(str, i * internal + 1, internal)
        Next
        txt.Tag = Result
        page1 = Result(0)
        txt.Text = page1
        lastPage = Result(Num - 1)
        lbPageNum.Text = 1
        txt.SelectedText = True
        fmProgress.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        txt.Text = page1
        lbPageNum.Text = 1
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txt.Text = lastPage
        lbPageNum.Text = Num
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim pageNum As Integer = lbPageNum.Text - 1
        If pageNum = 0 Then
            MsgBox("已经是第一页")
            pageNum = 1
            txt.Text = txt.Tag(pageNum - 1)
            lbPageNum.Text = pageNum
        Else
            txt.Text = txt.Tag(pageNum - 1)
            lbPageNum.Text = pageNum
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim pageNum As Integer = lbPageNum.Text + 1
        If pageNum = Num + 1 Then
            MsgBox("已经是最后一页")
            pageNum = Num
            txt.Text = txt.Tag(pageNum - 1)
            lbPageNum.Text = pageNum
        Else
            txt.Text = txt.Tag(pageNum - 1)
            lbPageNum.Text = pageNum
        End If

    End Sub

    Private Sub txtPageNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPageNum.KeyDown
        Dim pageNum As Integer = 0
        If txtPageNum.Text = "" Then
            pageNum = lbPageNum.Text
        Else
            pageNum = txtPageNum.Text
        End If
        If pageNum < 1 Or pageNum > Num Then
            MsgBox("页码非法！")
            txt.Text = txt.Tag(lbPageNum.Text - 1)
        Else
            txt.Text = txt.Tag(pageNum - 1)
            lbPageNum.Text = pageNum
        End If
        txtPageNum.Text = ""
    End Sub

    Private Sub lbFont_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbFont.LinkClicked
        Dim Font As FontDialog = New FontDialog
        Font.Color = txt.ForeColor
        Font.Font = New Font("宋体", 19)
        Font.AllowScriptChange = True
        Font.ShowColor = True
        If Font.ShowDialog() <> DialogResult.Cancel Then
            txt.Font = Font.Font
            txt.ForeColor = Font.Color
        End If
    End Sub

    Private Sub lbColor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbColor.LinkClicked
        Dim ColorD As ColorDialog = New ColorDialog
        ColorD.AllowFullOpen = True
        ColorD.FullOpen = True
        ColorD.ShowHelp = True
        ColorD.Color = Color.Black
        ColorD.ShowDialog()
        txt.BackColor = ColorD.Color
    End Sub
End Class