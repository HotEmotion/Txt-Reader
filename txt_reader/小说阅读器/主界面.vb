Imports 小说阅读器

Public Class fmMain
    Private Sub 主界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gb.Visible = False
        PWN.Visible = False
        PWV.Visible = False
        PMN.Visible = False
        PMV.Visible = False
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        gb.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        fmType.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim list As List(Of Book) = New List(Of Book)
        Dim SHelper As SqlHelper = New SqlHelper
        Dim sql As String = "select top 10 BNum,BName,BPer,BAttr from Book order by  BCount DESC"
        Dim redaer As SqlClient.SqlDataReader = SHelper.ExecuteSqlReader(sql)
        If redaer.HasRows Then
            While redaer.Read()
                Dim book As Book = New Book
                book.BName = redaer("BName").ToString()
                book.BPer = redaer("BPer").ToString()
                book.BNum = Convert.ToUInt32(redaer("BNum"))
                book.BAttr = redaer("BAttr").ToString()
                list.Add(book)
            End While
        End If
        lb1.Text = list(0).BName
        lb2.Text = list(1).BName
        lb3.Text = list(2).BName
        lb4.Text = list(3).BName
        lb5.Text = list(4).BName
        lb6.Text = list(5).BName
        lb7.Text = list(6).BName
        lb8.Text = list(7).BName
        lb9.Text = list(8).BName
        lb10.Text = list(9).BName
        p1.Text = list(0).BPer
        p2.Text = list(1).BPer
        p3.Text = list(2).BPer
        p4.Text = list(3).BPer
        p5.Text = list(4).BPer
        p6.Text = list(5).BPer
        p7.Text = list(6).BPer
        p8.Text = list(7).BPer
        p9.Text = list(8).BPer
        p10.Text = list(9).BPer
        lb1.Tag = list(0)
        lb2.Tag = list(1)
        lb3.Tag = list(2)
        lb4.Tag = list(3)
        lb5.Tag = list(4)
        lb6.Tag = list(5)
        lb7.Tag = list(6)
        lb8.Tag = list(7)
        lb9.Tag = list(8)
        lb10.Tag = list(9)
        gb.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        fmUserLogin.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        fmRegister.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        fmSelect.Show()
    End Sub


    Private Sub JudgeVIP(book As Book)
        fmRead.Tag = book.BNum
        If book.BAttr = "VIP" Then
            If PWV.Visible = True Or PMV.Visible = True Then
                fmRead.Show()
            Else
                MsgBox("请开通VIP")
                fmOpenVIP.Show()
            End If
        Else
            fmRead.Show()
        End If
    End Sub
    Private Sub lb1_Click(sender As Object, e As EventArgs) Handles lb1.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb1.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub


    Private Sub lb2_Click(sender As Object, e As EventArgs) Handles lb2.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb2.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb3_Click(sender As Object, e As EventArgs) Handles lb3.Click

        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb1.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb4_Click(sender As Object, e As EventArgs) Handles lb4.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb4.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb5_Click(sender As Object, e As EventArgs) Handles lb5.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb5.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb6_Click(sender As Object, e As EventArgs) Handles lb6.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb6.Tag
            fmRead.Tag = book.BNum
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb7_Click(sender As Object, e As EventArgs) Handles lb7.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb7.Tag
            fmRead.Tag = book.BNum
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb8_Click(sender As Object, e As EventArgs) Handles lb8.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb8.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb9_Click(sender As Object, e As EventArgs) Handles lb9.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb9.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub

    Private Sub lb10_Click(sender As Object, e As EventArgs) Handles lb10.Click
        If PictureBox5.Visible = False Then
            Dim book As Book = New Book
            book = lb10.Tag
            JudgeVIP(book)
        Else
            MsgBox("请先登录！")
            fmUserLogin.Show()
        End If
    End Sub
    Private Sub lbwvv_Click(sender As Object, e As EventArgs) Handles lbwvv.Click
        fmUserCenter.Show()
    End Sub

    Private Sub lbmvv_Click(sender As Object, e As EventArgs) Handles lbmvv.Click
        fmUserCenter.Show()
    End Sub

    Private Sub lbwnn_Click(sender As Object, e As EventArgs) Handles lbwnn.Click
        fmUserCenter.Show()
    End Sub

    Private Sub lbmnn_Click(sender As Object, e As EventArgs) Handles lbmnn.Click
        fmUserCenter.Show()
    End Sub
End Class