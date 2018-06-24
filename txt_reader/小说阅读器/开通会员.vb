Public Class fmOpenVIP
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        lb1.ForeColor = Color.Black
        Panel1.BackColor = Color.OrangeRed
        lb2.ForeColor = Color.OrangeRed
        Panel2.BackColor = Color.White
        lb3.ForeColor = Color.OrangeRed
        Panel3.BackColor = Color.White
        lbPrice.Text = lb1.Text
    End Sub

    Private Sub 开通会员_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb3.ForeColor = Color.Black
        Panel3.BackColor = Color.OrangeRed
        lb2.ForeColor = Color.OrangeRed
        Panel2.BackColor = Color.White
        lb1.ForeColor = Color.OrangeRed
        Panel1.BackColor = Color.White
        lbPrice.Text = lb3.Text
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        lb2.ForeColor = Color.Black
        Panel2.BackColor = Color.OrangeRed
        lb1.ForeColor = Color.OrangeRed
        Panel1.BackColor = Color.White
        lb3.ForeColor = Color.OrangeRed
        Panel3.BackColor = Color.White
        lbPrice.Text = lb2.Text
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        lb3.ForeColor = Color.Black
        Panel3.BackColor = Color.OrangeRed
        lb2.ForeColor = Color.OrangeRed
        Panel2.BackColor = Color.White
        lb1.ForeColor = Color.OrangeRed
        Panel1.BackColor = Color.White
        lbPrice.Text = lb3.Text
    End Sub

    Private Sub PWeChat_Click(sender As Object, e As EventArgs) Handles PWeChat.Click
        fmQRcode.Tag = 1
        fmQRcode.Show()
    End Sub

    Private Sub PAliPay_Click(sender As Object, e As EventArgs) Handles PAliPay.Click
        fmQRcode.Tag = 2
        fmQRcode.Show()
    End Sub
End Class