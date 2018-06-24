Public Class fmProgress
    Private Sub 读取txt文件中_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Percent As Integer = pgb.Value / pgb.Maximum * 100
        lb.Text = Percent.ToString() & "%"
    End Sub
End Class