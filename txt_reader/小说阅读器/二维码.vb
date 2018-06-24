Public Class fmQRcode
    Private Sub fmQRcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim im1 As Bitmap = New Bitmap("支付宝支付.jpg")
        Dim im2 As Bitmap = New Bitmap("微信支付.png")
        If Me.Tag = 1 Then
            PictureBox1.Image = im2
        ElseIf Me.Tag = 2 Then
            PictureBox1.Image = im1
        End If
    End Sub
End Class