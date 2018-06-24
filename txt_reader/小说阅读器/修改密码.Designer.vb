<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmMotifyPsd
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPsd1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPsd2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbFlag = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "修  改  密  码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "新的密码："
        '
        'txtPsd1
        '
        Me.txtPsd1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPsd1.Location = New System.Drawing.Point(155, 96)
        Me.txtPsd1.Multiline = True
        Me.txtPsd1.Name = "txtPsd1"
        Me.txtPsd1.Size = New System.Drawing.Size(205, 34)
        Me.txtPsd1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "确认密码："
        '
        'txtPsd2
        '
        Me.txtPsd2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPsd2.Location = New System.Drawing.Point(155, 150)
        Me.txtPsd2.Multiline = True
        Me.txtPsd2.Name = "txtPsd2"
        Me.txtPsd2.Size = New System.Drawing.Size(205, 34)
        Me.txtPsd2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "确  定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbFlag
        '
        Me.lbFlag.AutoSize = True
        Me.lbFlag.ForeColor = System.Drawing.Color.Red
        Me.lbFlag.Location = New System.Drawing.Point(152, 187)
        Me.lbFlag.Name = "lbFlag"
        Me.lbFlag.Size = New System.Drawing.Size(157, 15)
        Me.lbFlag.TabIndex = 4
        Me.lbFlag.Text = "两次输入的密码不一样"
        '
        'fmMotifyPsd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 313)
        Me.Controls.Add(Me.lbFlag)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPsd2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPsd1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmMotifyPsd"
        Me.Text = "修改密码"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPsd1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPsd2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbFlag As Label
End Class
