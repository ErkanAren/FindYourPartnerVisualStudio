<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.onoma1 = New System.Windows.Forms.Label
        Me.pr_num_l1 = New System.Windows.Forms.Label
        Me.onoma2 = New System.Windows.Forms.Label
        Me.pr_num_l2 = New System.Windows.Forms.Label
        Me.onoma3 = New System.Windows.Forms.Label
        Me.pr_num_l3 = New System.Windows.Forms.Label
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(57, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'onoma1
        '
        Me.onoma1.AutoSize = True
        Me.onoma1.Location = New System.Drawing.Point(12, 9)
        Me.onoma1.Name = "onoma1"
        Me.onoma1.Size = New System.Drawing.Size(39, 13)
        Me.onoma1.TabIndex = 2
        Me.onoma1.Text = "Label1"
        '
        'pr_num_l1
        '
        Me.pr_num_l1.AutoSize = True
        Me.pr_num_l1.Location = New System.Drawing.Point(163, 9)
        Me.pr_num_l1.Name = "pr_num_l1"
        Me.pr_num_l1.Size = New System.Drawing.Size(39, 13)
        Me.pr_num_l1.TabIndex = 4
        Me.pr_num_l1.Text = "Label2"
        '
        'onoma2
        '
        Me.onoma2.AutoSize = True
        Me.onoma2.Location = New System.Drawing.Point(15, 56)
        Me.onoma2.Name = "onoma2"
        Me.onoma2.Size = New System.Drawing.Size(39, 13)
        Me.onoma2.TabIndex = 5
        Me.onoma2.Text = "Label1"
        '
        'pr_num_l2
        '
        Me.pr_num_l2.AutoSize = True
        Me.pr_num_l2.Location = New System.Drawing.Point(166, 56)
        Me.pr_num_l2.Name = "pr_num_l2"
        Me.pr_num_l2.Size = New System.Drawing.Size(39, 13)
        Me.pr_num_l2.TabIndex = 6
        Me.pr_num_l2.Text = "Label2"
        '
        'onoma3
        '
        Me.onoma3.AutoSize = True
        Me.onoma3.Location = New System.Drawing.Point(18, 110)
        Me.onoma3.Name = "onoma3"
        Me.onoma3.Size = New System.Drawing.Size(39, 13)
        Me.onoma3.TabIndex = 7
        Me.onoma3.Text = "Label3"
        '
        'pr_num_l3
        '
        Me.pr_num_l3.AutoSize = True
        Me.pr_num_l3.Location = New System.Drawing.Point(169, 110)
        Me.pr_num_l3.Name = "pr_num_l3"
        Me.pr_num_l3.Size = New System.Drawing.Size(39, 13)
        Me.pr_num_l3.TabIndex = 8
        Me.pr_num_l3.Text = "Label4"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(61, 56)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 9
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(64, 110)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar3.TabIndex = 10
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.pr_num_l3)
        Me.Controls.Add(Me.onoma3)
        Me.Controls.Add(Me.pr_num_l2)
        Me.Controls.Add(Me.onoma2)
        Me.Controls.Add(Me.pr_num_l1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.onoma1)
        Me.Name = "Results"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents onoma1 As System.Windows.Forms.Label
    Friend WithEvents pr_num_l1 As System.Windows.Forms.Label
    Friend WithEvents onoma2 As System.Windows.Forms.Label
    Friend WithEvents pr_num_l2 As System.Windows.Forms.Label
    Friend WithEvents onoma3 As System.Windows.Forms.Label
    Friend WithEvents pr_num_l3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
End Class
