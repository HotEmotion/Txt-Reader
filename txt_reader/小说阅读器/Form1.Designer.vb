<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmType
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
        Me.tv = New System.Windows.Forms.TreeView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbAttr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPer = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(902, 614)
        Me.SplitContainer1.SplitterDistance = 275
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'tv
        '
        Me.tv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tv.Location = New System.Drawing.Point(0, 0)
        Me.tv.Margin = New System.Windows.Forms.Padding(2)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(275, 614)
        Me.tv.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbCount)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbName)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbAttr)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbPer)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbType)
        Me.SplitContainer2.Panel1.Controls.Add(Me.label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtContent)
        Me.SplitContainer2.Size = New System.Drawing.Size(624, 614)
        Me.SplitContainer2.SplitterDistance = 165
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(122, 107)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 22)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "属性："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "作者："
        '
        'lbCount
        '
        Me.lbCount.AutoSize = True
        Me.lbCount.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCount.Location = New System.Drawing.Point(411, 71)
        Me.lbCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(57, 20)
        Me.lbCount.TabIndex = 2
        Me.lbCount.Text = "Label2"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbName.Location = New System.Drawing.Point(411, 34)
        Me.lbName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(57, 20)
        Me.lbName.TabIndex = 2
        Me.lbName.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "浏览次数："
        '
        'lbAttr
        '
        Me.lbAttr.AutoSize = True
        Me.lbAttr.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbAttr.Location = New System.Drawing.Point(188, 109)
        Me.lbAttr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAttr.Name = "lbAttr"
        Me.lbAttr.Size = New System.Drawing.Size(57, 20)
        Me.lbAttr.TabIndex = 1
        Me.lbAttr.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "书名："
        '
        'lbPer
        '
        Me.lbPer.AutoSize = True
        Me.lbPer.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbPer.Location = New System.Drawing.Point(188, 71)
        Me.lbPer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPer.Name = "lbPer"
        Me.lbPer.Size = New System.Drawing.Size(57, 20)
        Me.lbPer.TabIndex = 1
        Me.lbPer.Text = "Label2"
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbType.Location = New System.Drawing.Point(188, 32)
        Me.lbType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(57, 20)
        Me.lbType.TabIndex = 1
        Me.lbType.Text = "Label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label1.Location = New System.Drawing.Point(122, 30)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 22)
        Me.label1.TabIndex = 0
        Me.label1.Text = "类别："
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 396)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(624, 50)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "试   读"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtContent
        '
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtContent.Location = New System.Drawing.Point(0, 0)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(624, 446)
        Me.txtContent.TabIndex = 0
        '
        'fmType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 614)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "fmType"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tv As TreeView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lbType As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbAttr As Label
    Friend WithEvents lbPer As Label
    Friend WithEvents Button3 As Button
End Class
