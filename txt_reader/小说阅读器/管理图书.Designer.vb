<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmManageBook
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtAttr = New System.Windows.Forms.TextBox()
        Me.txtPer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbCity = New System.Windows.Forms.Label()
        Me.lbHis = New System.Windows.Forms.Label()
        Me.lbFantasy = New System.Windows.Forms.Label()
        Me.lbLove = New System.Windows.Forms.Label()
        Me.lbCount = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtCount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtAttr)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbCount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbLove)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbFantasy)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbHis)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbCity)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(751, 764)
        Me.SplitContainer1.SplitterDistance = 308
        Me.SplitContainer1.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(751, 308)
        Me.dgv.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(464, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "删除图书"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(289, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "修改图书信息"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(91, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "新增图书"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtCount.Location = New System.Drawing.Point(470, 269)
        Me.txtCount.Multiline = True
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(138, 29)
        Me.txtCount.TabIndex = 1
        '
        'txtAttr
        '
        Me.txtAttr.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtAttr.Location = New System.Drawing.Point(470, 213)
        Me.txtAttr.Multiline = True
        Me.txtAttr.Name = "txtAttr"
        Me.txtAttr.Size = New System.Drawing.Size(138, 29)
        Me.txtAttr.TabIndex = 1
        '
        'txtPer
        '
        Me.txtPer.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPer.Location = New System.Drawing.Point(470, 155)
        Me.txtPer.Multiline = True
        Me.txtPer.Name = "txtPer"
        Me.txtPer.Size = New System.Drawing.Size(138, 29)
        Me.txtPer.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "浏览次数："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "属性："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "作者："
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPath.Location = New System.Drawing.Point(165, 269)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(138, 29)
        Me.txtPath.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "路径："
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtType.Location = New System.Drawing.Point(165, 213)
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(138, 29)
        Me.txtType.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "类型："
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtName.Location = New System.Drawing.Point(165, 155)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(138, 29)
        Me.txtName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "都市异能"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(108, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "库存图书数量（本）："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "书名："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(357, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "历史军事"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(447, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "玄幻"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(509, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "言情"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(560, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "总数量"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(301, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 20)
        Me.Label13.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(393, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 20)
        Me.Label14.TabIndex = 0
        '
        'lbCity
        '
        Me.lbCity.AutoSize = True
        Me.lbCity.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCity.Location = New System.Drawing.Point(289, 95)
        Me.lbCity.Name = "lbCity"
        Me.lbCity.Size = New System.Drawing.Size(30, 20)
        Me.lbCity.TabIndex = 0
        Me.lbCity.Text = "lab"
        '
        'lbHis
        '
        Me.lbHis.AutoSize = True
        Me.lbHis.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbHis.Location = New System.Drawing.Point(374, 95)
        Me.lbHis.Name = "lbHis"
        Me.lbHis.Size = New System.Drawing.Size(30, 20)
        Me.lbHis.TabIndex = 0
        Me.lbHis.Text = "lab"
        '
        'lbFantasy
        '
        Me.lbFantasy.AutoSize = True
        Me.lbFantasy.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbFantasy.Location = New System.Drawing.Point(453, 95)
        Me.lbFantasy.Name = "lbFantasy"
        Me.lbFantasy.Size = New System.Drawing.Size(30, 20)
        Me.lbFantasy.TabIndex = 0
        Me.lbFantasy.Text = "lab"
        '
        'lbLove
        '
        Me.lbLove.AutoSize = True
        Me.lbLove.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbLove.Location = New System.Drawing.Point(509, 95)
        Me.lbLove.Name = "lbLove"
        Me.lbLove.Size = New System.Drawing.Size(30, 20)
        Me.lbLove.TabIndex = 0
        Me.lbLove.Text = "lab"
        '
        'lbCount
        '
        Me.lbCount.AutoSize = True
        Me.lbCount.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCount.Location = New System.Drawing.Point(570, 95)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(30, 20)
        Me.lbCount.TabIndex = 0
        Me.lbCount.Text = "lab"
        '
        'fmManageBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 764)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "fmManageBook"
        Me.Text = "管理图书"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtAttr As TextBox
    Friend WithEvents txtPer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbCount As Label
    Friend WithEvents lbLove As Label
    Friend WithEvents lbFantasy As Label
    Friend WithEvents lbHis As Label
    Friend WithEvents lbCity As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
