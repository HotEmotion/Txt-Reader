<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmSelect
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAll = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbRLove = New System.Windows.Forms.Label()
        Me.lbLove = New System.Windows.Forms.Label()
        Me.lbRFantasy = New System.Windows.Forms.Label()
        Me.lbFantasy = New System.Windows.Forms.Label()
        Me.lbRHistory = New System.Windows.Forms.Label()
        Me.lbHistory = New System.Windows.Forms.Label()
        Me.lbRVIP = New System.Windows.Forms.Label()
        Me.lbVIP = New System.Windows.Forms.Label()
        Me.lbRFree = New System.Windows.Forms.Label()
        Me.lbFree = New System.Windows.Forms.Label()
        Me.lbRCity = New System.Windows.Forms.Label()
        Me.lbCity = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbAll)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lbRLove)
        Me.GroupBox1.Controls.Add(Me.lbLove)
        Me.GroupBox1.Controls.Add(Me.lbRFantasy)
        Me.GroupBox1.Controls.Add(Me.lbFantasy)
        Me.GroupBox1.Controls.Add(Me.lbRHistory)
        Me.GroupBox1.Controls.Add(Me.lbHistory)
        Me.GroupBox1.Controls.Add(Me.lbRVIP)
        Me.GroupBox1.Controls.Add(Me.lbVIP)
        Me.GroupBox1.Controls.Add(Me.lbRFree)
        Me.GroupBox1.Controls.Add(Me.lbFree)
        Me.GroupBox1.Controls.Add(Me.lbRCity)
        Me.GroupBox1.Controls.Add(Me.lbCity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lbAll
        '
        Me.lbAll.AutoSize = True
        Me.lbAll.BackColor = System.Drawing.Color.Red
        Me.lbAll.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbAll.Location = New System.Drawing.Point(113, 82)
        Me.lbAll.Name = "lbAll"
        Me.lbAll.Size = New System.Drawing.Size(32, 17)
        Me.lbAll.TabIndex = 4
        Me.lbAll.Text = "全部"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(290, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "搜  索"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtName.Location = New System.Drawing.Point(91, 31)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(193, 32)
        Me.txtName.TabIndex = 2
        '
        'lbRLove
        '
        Me.lbRLove.AutoSize = True
        Me.lbRLove.BackColor = System.Drawing.Color.Red
        Me.lbRLove.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRLove.Location = New System.Drawing.Point(113, 82)
        Me.lbRLove.Name = "lbRLove"
        Me.lbRLove.Size = New System.Drawing.Size(32, 17)
        Me.lbRLove.TabIndex = 1
        Me.lbRLove.Text = "言情"
        '
        'lbLove
        '
        Me.lbLove.AutoSize = True
        Me.lbLove.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbLove.Location = New System.Drawing.Point(318, 123)
        Me.lbLove.Name = "lbLove"
        Me.lbLove.Size = New System.Drawing.Size(32, 17)
        Me.lbLove.TabIndex = 1
        Me.lbLove.Text = "言情"
        '
        'lbRFantasy
        '
        Me.lbRFantasy.AutoSize = True
        Me.lbRFantasy.BackColor = System.Drawing.Color.Red
        Me.lbRFantasy.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRFantasy.Location = New System.Drawing.Point(113, 82)
        Me.lbRFantasy.Name = "lbRFantasy"
        Me.lbRFantasy.Size = New System.Drawing.Size(32, 17)
        Me.lbRFantasy.TabIndex = 1
        Me.lbRFantasy.Text = "玄幻"
        Me.lbRFantasy.Visible = False
        '
        'lbFantasy
        '
        Me.lbFantasy.AutoSize = True
        Me.lbFantasy.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbFantasy.Location = New System.Drawing.Point(268, 123)
        Me.lbFantasy.Name = "lbFantasy"
        Me.lbFantasy.Size = New System.Drawing.Size(32, 17)
        Me.lbFantasy.TabIndex = 1
        Me.lbFantasy.Text = "玄幻"
        '
        'lbRHistory
        '
        Me.lbRHistory.AutoSize = True
        Me.lbRHistory.BackColor = System.Drawing.Color.Red
        Me.lbRHistory.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRHistory.Location = New System.Drawing.Point(113, 82)
        Me.lbRHistory.Name = "lbRHistory"
        Me.lbRHistory.Size = New System.Drawing.Size(56, 17)
        Me.lbRHistory.TabIndex = 1
        Me.lbRHistory.Text = "历史军事"
        Me.lbRHistory.Visible = False
        '
        'lbHistory
        '
        Me.lbHistory.AutoSize = True
        Me.lbHistory.BackColor = System.Drawing.SystemColors.Control
        Me.lbHistory.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbHistory.Location = New System.Drawing.Point(190, 123)
        Me.lbHistory.Name = "lbHistory"
        Me.lbHistory.Size = New System.Drawing.Size(56, 17)
        Me.lbHistory.TabIndex = 1
        Me.lbHistory.Text = "历史军事"
        '
        'lbRVIP
        '
        Me.lbRVIP.AutoSize = True
        Me.lbRVIP.BackColor = System.Drawing.Color.Red
        Me.lbRVIP.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRVIP.Location = New System.Drawing.Point(202, 82)
        Me.lbRVIP.Name = "lbRVIP"
        Me.lbRVIP.Size = New System.Drawing.Size(27, 17)
        Me.lbRVIP.TabIndex = 1
        Me.lbRVIP.Text = "VIP"
        Me.lbRVIP.Visible = False
        '
        'lbVIP
        '
        Me.lbVIP.AutoSize = True
        Me.lbVIP.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbVIP.Location = New System.Drawing.Point(164, 161)
        Me.lbVIP.Name = "lbVIP"
        Me.lbVIP.Size = New System.Drawing.Size(27, 17)
        Me.lbVIP.TabIndex = 1
        Me.lbVIP.Text = "VIP"
        '
        'lbRFree
        '
        Me.lbRFree.AutoSize = True
        Me.lbRFree.BackColor = System.Drawing.Color.Red
        Me.lbRFree.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRFree.Location = New System.Drawing.Point(197, 82)
        Me.lbRFree.Name = "lbRFree"
        Me.lbRFree.Size = New System.Drawing.Size(32, 17)
        Me.lbRFree.TabIndex = 1
        Me.lbRFree.Text = "免费"
        Me.lbRFree.Visible = False
        '
        'lbFree
        '
        Me.lbFree.AutoSize = True
        Me.lbFree.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbFree.Location = New System.Drawing.Point(113, 159)
        Me.lbFree.Name = "lbFree"
        Me.lbFree.Size = New System.Drawing.Size(32, 17)
        Me.lbFree.TabIndex = 1
        Me.lbFree.Text = "免费"
        '
        'lbRCity
        '
        Me.lbRCity.AutoSize = True
        Me.lbRCity.BackColor = System.Drawing.Color.Red
        Me.lbRCity.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbRCity.Location = New System.Drawing.Point(113, 82)
        Me.lbRCity.Name = "lbRCity"
        Me.lbRCity.Size = New System.Drawing.Size(56, 17)
        Me.lbRCity.TabIndex = 1
        Me.lbRCity.Text = "都市异能"
        Me.lbRCity.Visible = False
        '
        'lbCity
        '
        Me.lbCity.AutoSize = True
        Me.lbCity.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCity.Location = New System.Drawing.Point(113, 123)
        Me.lbCity.Name = "lbCity"
        Me.lbCity.Size = New System.Drawing.Size(56, 17)
        Me.lbCity.TabIndex = 1
        Me.lbCity.Text = "都市异能"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "属性"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "分类"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "已选"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 269)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 17)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(505, 249)
        Me.dgv.TabIndex = 0
        '
        'fmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.小说阅读器.My.Resources.backimage.背景
        Me.ClientSize = New System.Drawing.Size(634, 606)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fmSelect"
        Me.Text = "搜索界面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbLove As Label
    Friend WithEvents lbFantasy As Label
    Friend WithEvents lbHistory As Label
    Friend WithEvents lbVIP As Label
    Friend WithEvents lbFree As Label
    Friend WithEvents lbCity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lbAll As Label
    Friend WithEvents lbRLove As Label
    Friend WithEvents lbRFantasy As Label
    Friend WithEvents lbRHistory As Label
    Friend WithEvents lbRVIP As Label
    Friend WithEvents lbRFree As Label
    Friend WithEvents lbRCity As Label
End Class
