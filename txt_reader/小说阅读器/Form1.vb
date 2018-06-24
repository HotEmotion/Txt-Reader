Imports System.IO
Imports 小说阅读器

Public Class fmType
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As List(Of Category) = LoadListByParentId(-1)
        LoadCategoryBylist(list, tv.Nodes)
    End Sub
    Private Function LoadListByParentId(v As Integer) As List(Of Category)
        Dim list As List(Of Category) = New List(Of Category)
        Dim sql As String = "select CId,CName,CBNum from Category where CParentId = " & v
        Dim Csql As SqlHelper = New SqlHelper
        Dim dt As DataTable = Csql.ExecuteDataAdapter(sql)
        If dt.Rows.Count > 0 Then
            For Each row In dt.Rows
                Dim cg As Category = RowToCategory(row)
                list.Add(cg)
            Next
        End If
        Return list
    End Function

    Private Function RowToCategory(row As Object) As Category
        Dim cg As Category = New Category
        cg.CId = Convert.ToInt32(row("CId"))
        cg.CBNum = Convert.ToInt32(row("CBNum"))
        cg.CName = Convert.ToString(row("CName"))
        Return cg
    End Function
    Private Sub LoadCategoryBylist(list As List(Of Category), nodes As TreeNodeCollection)
        Dim count As Int16 = list.Count - 1
        For i = 0 To count Step 1
            Dim tn As TreeNode = nodes.Add(list(i).CName)
            tn.Tag = list(i).CBNum
            LoadCategoryBylist(LoadListByParentId(list(i).CId), tn.Nodes)
        Next
    End Sub
    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        Dim SHelper As SqlHelper = New SqlHelper
        Dim tn As TreeNode = tv.SelectedNode
        Dim id As Integer = Convert.ToInt32(tn.Tag.ToString())
        Button3.Tag = id
        If id > 4 Then
            Dim ssql As String = "select  BName, BCount, BType, BAttr, BPer from Book where BNum =" & id
            Dim rd As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(ssql)
            If rd.HasRows Then
                While rd.Read()
                    lbName.Text = rd("BName").ToString()
                    lbCount.Text = Convert.ToInt32(rd("BCount"))
                    lbPer.Text = rd("BPer").ToString()
                    lbAttr.Text = rd("BAttr")
                    lbType.Text = rd("BType")
                End While
            End If
        Else
            lbAttr.Text = ""
            lbName.Text = ""
            lbPer.Text = ""
            lbType.Text = ""
            lbCount.Text = ""
        End If
        Dim sql As String = "select CContent from Category where CId =" & id
        Dim reader As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        If reader.HasRows Then
            While reader.Read()
                Dim txt As String = reader(0)
                Dim sr As StreamReader = New StreamReader(txt, System.Text.Encoding.Default)
                Dim lines As String = ""
                Do While sr.Peek() > 0
                    txtContent.Text = ""
                    lines += sr.ReadLine() & vbCrLf
                Loop
                txtContent.Text = lines
                sr.Close()
                sr = Nothing
            End While
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If fmMain.PictureBox5.Visible = False Then
            fmRead.Tag = Button3.Tag
            If lbAttr.Text = "VIP" Then
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