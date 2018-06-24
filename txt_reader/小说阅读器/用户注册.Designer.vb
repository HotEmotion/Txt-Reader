<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmRegister
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCertain = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cbxEmail = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbMan = New System.Windows.Forms.RadioButton()
        Me.rbWomen = New System.Windows.Forms.RadioButton()
        Me.cbAccept = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbFlatPass = New System.Windows.Forms.Label()
        Me.lbFlatName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "注   册"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "用户名："
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("微软雅黑", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtName.Location = New System.Drawing.Point(151, 116)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(310, 34)
        Me.txtName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "密码："
        '
        'txtPas
        '
        Me.txtPas.Font = New System.Drawing.Font("微软雅黑", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPas.Location = New System.Drawing.Point(151, 178)
        Me.txtPas.Multiline = True
        Me.txtPas.Name = "txtPas"
        Me.txtPas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPas.Size = New System.Drawing.Size(310, 34)
        Me.txtPas.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label2"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("微软雅黑", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(151, 243)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(310, 34)
        Me.TextBox3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "确认密码："
        '
        'txtCertain
        '
        Me.txtCertain.Font = New System.Drawing.Font("微软雅黑", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtCertain.Location = New System.Drawing.Point(151, 243)
        Me.txtCertain.Multiline = True
        Me.txtCertain.Name = "txtCertain"
        Me.txtCertain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCertain.Size = New System.Drawing.Size(310, 34)
        Me.txtCertain.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "邮箱："
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("微软雅黑", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(151, 304)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(205, 34)
        Me.txtEmail.TabIndex = 2
        '
        'cbxEmail
        '
        Me.cbxEmail.AutoCompleteCustomSource.AddRange(New String() {"@163.com", "@126.com", "@qq.com", "@139.com"})
        Me.cbxEmail.DropDownHeight = 120
        Me.cbxEmail.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cbxEmail.FormattingEnabled = True
        Me.cbxEmail.IntegralHeight = False
        Me.cbxEmail.Items.AddRange(New Object() {"@163.com", "@qq.com", "@126.com", "@139.com"})
        Me.cbxEmail.Location = New System.Drawing.Point(300, 304)
        Me.cbxEmail.Name = "cbxEmail"
        Me.cbxEmail.Size = New System.Drawing.Size(161, 35)
        Me.cbxEmail.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "性别："
        '
        'rbMan
        '
        Me.rbMan.AutoSize = True
        Me.rbMan.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rbMan.Location = New System.Drawing.Point(212, 367)
        Me.rbMan.Name = "rbMan"
        Me.rbMan.Size = New System.Drawing.Size(53, 31)
        Me.rbMan.TabIndex = 4
        Me.rbMan.TabStop = True
        Me.rbMan.Text = "男"
        Me.rbMan.UseVisualStyleBackColor = True
        '
        'rbWomen
        '
        Me.rbWomen.AutoSize = True
        Me.rbWomen.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rbWomen.Location = New System.Drawing.Point(315, 367)
        Me.rbWomen.Name = "rbWomen"
        Me.rbWomen.Size = New System.Drawing.Size(53, 31)
        Me.rbWomen.TabIndex = 4
        Me.rbWomen.TabStop = True
        Me.rbWomen.Text = "女"
        Me.rbWomen.UseVisualStyleBackColor = True
        '
        'cbAccept
        '
        Me.cbAccept.AutoSize = True
        Me.cbAccept.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cbAccept.Location = New System.Drawing.Point(217, 425)
        Me.cbAccept.Name = "cbAccept"
        Me.cbAccept.Size = New System.Drawing.Size(66, 27)
        Me.cbAccept.TabIndex = 5
        Me.cbAccept.Text = "接受"
        Me.cbAccept.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(289, 431)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 15)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "软件协议"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(189, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "下一步"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbFlatPass
        '
        Me.lbFlatPass.AutoSize = True
        Me.lbFlatPass.ForeColor = System.Drawing.Color.Red
        Me.lbFlatPass.Location = New System.Drawing.Point(199, 280)
        Me.lbFlatPass.Name = "lbFlatPass"
        Me.lbFlatPass.Size = New System.Drawing.Size(157, 15)
        Me.lbFlatPass.TabIndex = 8
        Me.lbFlatPass.Text = "两次输入的密码不一样"
        '
        'lbFlatName
        '
        Me.lbFlatName.AutoSize = True
        Me.lbFlatName.ForeColor = System.Drawing.Color.Red
        Me.lbFlatName.Location = New System.Drawing.Point(196, 160)
        Me.lbFlatName.Name = "lbFlatName"
        Me.lbFlatName.Size = New System.Drawing.Size(82, 15)
        Me.lbFlatName.TabIndex = 8
        Me.lbFlatName.Text = "用户名重复"
        '
        'fmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 553)
        Me.Controls.Add(Me.lbFlatName)
        Me.Controls.Add(Me.lbFlatPass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cbAccept)
        Me.Controls.Add(Me.rbWomen)
        Me.Controls.Add(Me.rbMan)
        Me.Controls.Add(Me.cbxEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCertain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmRegister"
        Me.Text = "用户注册"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCertain As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cbxEmail As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rbMan As RadioButton
    Friend WithEvents rbWomen As RadioButton
    Friend WithEvents cbAccept As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents lbFlatPass As Label
    Friend WithEvents lbFlatName As Label
End Class
