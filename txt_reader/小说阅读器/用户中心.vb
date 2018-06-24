Public Class fmUserCenter
    Private Sub 用户中心_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fmMain.PictureBox5.Visible = True
        fmMain.PictureBox6.Visible = True
        fmMain.PMN.Visible = False
        fmMain.PMV.Visible = False
        fmMain.PWN.Visible = False
        fmMain.PWV.Visible = False
        fmMain.Refresh()
    End Sub
End Class