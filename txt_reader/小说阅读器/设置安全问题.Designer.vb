<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSeurity
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbQ1 = New System.Windows.Forms.ComboBox()
        Me.txtA1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbQ2 = New System.Windows.Forms.ComboBox()
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbQ3 = New System.Windows.Forms.ComboBox()
        Me.txtA3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "安全问题设置"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "问题一："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "答 案："
        '
        'cmbQ1
        '
        Me.cmbQ1.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbQ1.FormattingEnabled = True
        Me.cmbQ1.Items.AddRange(New Object() {"您母亲的姓名是？", "您父亲的姓名是？", "您配偶的姓名是？", "您的出生地是？", "您高中班主任的名字是？", "您初中班主任的名字是？", "您小学班主任的名字是？", "您父亲的生日是？", "您母亲的生日是？"})
        Me.cmbQ1.Location = New System.Drawing.Point(169, 97)
        Me.cmbQ1.Name = "cmbQ1"
        Me.cmbQ1.Size = New System.Drawing.Size(244, 27)
        Me.cmbQ1.TabIndex = 3
        '
        'txtA1
        '
        Me.txtA1.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtA1.Location = New System.Drawing.Point(169, 145)
        Me.txtA1.Multiline = True
        Me.txtA1.Name = "txtA1"
        Me.txtA1.Size = New System.Drawing.Size(244, 34)
        Me.txtA1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "问题二："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "答 案："
        '
        'cmbQ2
        '
        Me.cmbQ2.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbQ2.FormattingEnabled = True
        Me.cmbQ2.Items.AddRange(New Object() {"您母亲的姓名是？", "您父亲的姓名是？", "您配偶的姓名是？", "您的出生地是？", "您高中班主任的名字是？", "您初中班主任的名字是？", "您小学班主任的名字是？", "您父亲的生日是？", "您母亲的生日是？"})
        Me.cmbQ2.Location = New System.Drawing.Point(169, 201)
        Me.cmbQ2.Name = "cmbQ2"
        Me.cmbQ2.Size = New System.Drawing.Size(244, 27)
        Me.cmbQ2.TabIndex = 3
        '
        'txtA2
        '
        Me.txtA2.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtA2.Location = New System.Drawing.Point(169, 249)
        Me.txtA2.Multiline = True
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(244, 34)
        Me.txtA2.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "问题三："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "答 案："
        '
        'cmbQ3
        '
        Me.cmbQ3.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbQ3.FormattingEnabled = True
        Me.cmbQ3.Items.AddRange(New Object() {"您母亲的姓名是？", "您父亲的姓名是？", "您配偶的姓名是？", "您的出生地是？", "您高中班主任的名字是？", "您初中班主任的名字是？", "您小学班主任的名字是？", "您父亲的生日是？", "您母亲的生日是？"})
        Me.cmbQ3.Location = New System.Drawing.Point(169, 303)
        Me.cmbQ3.Name = "cmbQ3"
        Me.cmbQ3.Size = New System.Drawing.Size(244, 27)
        Me.cmbQ3.TabIndex = 3
        '
        'txtA3
        '
        Me.txtA3.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtA3.Location = New System.Drawing.Point(169, 351)
        Me.txtA3.Multiline = True
        Me.txtA3.Name = "txtA3"
        Me.txtA3.Size = New System.Drawing.Size(244, 34)
        Me.txtA3.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(181, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "设置完成"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserSeurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 499)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtA3)
        Me.Controls.Add(Me.cmbQ3)
        Me.Controls.Add(Me.txtA2)
        Me.Controls.Add(Me.cmbQ2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtA1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbQ1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserSeurity"
        Me.Text = "设置安全问题"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbQ1 As ComboBox
    Friend WithEvents txtA1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbQ2 As ComboBox
    Friend WithEvents txtA2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbQ3 As ComboBox
    Friend WithEvents txtA3 As TextBox
    Friend WithEvents Button1 As Button
End Class
