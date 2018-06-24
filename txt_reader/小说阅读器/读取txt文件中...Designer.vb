<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmProgress
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pgb = New System.Windows.Forms.ProgressBar()
        Me.lb = New System.Windows.Forms.Label()
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
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pgb)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lb)
        Me.SplitContainer1.Size = New System.Drawing.Size(476, 85)
        Me.SplitContainer1.SplitterDistance = 362
        Me.SplitContainer1.TabIndex = 0
        '
        'pgb
        '
        Me.pgb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb.Location = New System.Drawing.Point(0, 0)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(362, 85)
        Me.pgb.TabIndex = 0
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lb.Location = New System.Drawing.Point(26, 30)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(72, 25)
        Me.lb.TabIndex = 0
        Me.lb.Text = "Label1"
        '
        'fmProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 85)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "fmProgress"
        Me.Text = "读取txt文件中"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pgb As ProgressBar
    Friend WithEvents lb As Label
End Class
