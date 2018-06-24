<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmRead
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
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbColor = New System.Windows.Forms.LinkLabel()
        Me.lbFont = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPageNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbPageNum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbColor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbFont)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPageNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbPageNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1143, 804)
        Me.SplitContainer1.SplitterDistance = 752
        Me.SplitContainer1.TabIndex = 0
        '
        'txt
        '
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt.Size = New System.Drawing.Size(1143, 752)
        Me.txt.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 740)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "."
        '
        'lbColor
        '
        Me.lbColor.AutoSize = True
        Me.lbColor.Location = New System.Drawing.Point(82, 18)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.Size = New System.Drawing.Size(41, 12)
        Me.lbColor.TabIndex = 12
        Me.lbColor.TabStop = True
        Me.lbColor.Text = "背景色"
        '
        'lbFont
        '
        Me.lbFont.AutoSize = True
        Me.lbFont.Location = New System.Drawing.Point(36, 18)
        Me.lbFont.Name = "lbFont"
        Me.lbFont.Size = New System.Drawing.Size(29, 12)
        Me.lbFont.TabIndex = 11
        Me.lbFont.TabStop = True
        Me.lbFont.Text = "字体"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(526, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "页-"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(415, 17)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(41, 12)
        Me.LinkLabel4.TabIndex = 9
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "上一页"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(561, 16)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(41, 12)
        Me.LinkLabel3.TabIndex = 8
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "下一页"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(354, 17)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(41, 12)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "第一页"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(764, 17)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "最后一页"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(724, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "页"
        '
        'txtPageNum
        '
        Me.txtPageNum.Location = New System.Drawing.Point(671, 14)
        Me.txtPageNum.Name = "txtPageNum"
        Me.txtPageNum.Size = New System.Drawing.Size(47, 21)
        Me.txtPageNum.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(624, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "跳转到"
        '
        'lbPageNum
        '
        Me.lbPageNum.AutoSize = True
        Me.lbPageNum.Location = New System.Drawing.Point(498, 18)
        Me.lbPageNum.Name = "lbPageNum"
        Me.lbPageNum.Size = New System.Drawing.Size(41, 12)
        Me.lbPageNum.TabIndex = 1
        Me.lbPageNum.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "-第"
        '
        'fmRead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 804)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "fmRead"
        Me.Text = "阅读器"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPageNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbPageNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbColor As LinkLabel
    Friend WithEvents lbFont As LinkLabel
End Class
