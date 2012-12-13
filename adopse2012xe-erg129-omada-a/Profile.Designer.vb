<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        Me.NameLb = New System.Windows.Forms.Label
        Me.EpihetoLb = New System.Windows.Forms.Label
        Me.HmLb = New System.Windows.Forms.Label
        Me.PerioxhLb = New System.Windows.Forms.Label
        Me.OnomaShow = New System.Windows.Forms.Label
        Me.EpithetoShow = New System.Windows.Forms.Label
        Me.HmShow = New System.Windows.Forms.Label
        Me.PerioxhShow = New System.Windows.Forms.Label
        Me.EditButton = New System.Windows.Forms.Button
        Me.LogoutButton = New System.Windows.Forms.Button
        Me.SearchButton = New System.Windows.Forms.Button
        Me.ErgasiaLb = New System.Windows.Forms.Label
        Me.ErgasiaShow = New System.Windows.Forms.Label
        Me.EmLb = New System.Windows.Forms.Label
        Me.EmShow = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'NameLb
        '
        Me.NameLb.AutoSize = True
        Me.NameLb.Location = New System.Drawing.Point(40, 58)
        Me.NameLb.Name = "NameLb"
        Me.NameLb.Size = New System.Drawing.Size(50, 13)
        Me.NameLb.TabIndex = 0
        Me.NameLb.Text = "Onoma : "
        '
        'EpihetoLb
        '
        Me.EpihetoLb.AutoSize = True
        Me.EpihetoLb.Location = New System.Drawing.Point(40, 85)
        Me.EpihetoLb.Name = "EpihetoLb"
        Me.EpihetoLb.Size = New System.Drawing.Size(52, 13)
        Me.EpihetoLb.TabIndex = 1
        Me.EpihetoLb.Text = "Epitheto :"
        '
        'HmLb
        '
        Me.HmLb.AutoSize = True
        Me.HmLb.Location = New System.Drawing.Point(40, 113)
        Me.HmLb.Name = "HmLb"
        Me.HmLb.Size = New System.Drawing.Size(72, 13)
        Me.HmLb.TabIndex = 2
        Me.HmLb.Text = "Hm Gennisis :"
        '
        'PerioxhLb
        '
        Me.PerioxhLb.AutoSize = True
        Me.PerioxhLb.Location = New System.Drawing.Point(40, 141)
        Me.PerioxhLb.Name = "PerioxhLb"
        Me.PerioxhLb.Size = New System.Drawing.Size(48, 13)
        Me.PerioxhLb.TabIndex = 3
        Me.PerioxhLb.Text = "Perioxh :"
        '
        'OnomaShow
        '
        Me.OnomaShow.AutoSize = True
        Me.OnomaShow.Location = New System.Drawing.Point(118, 58)
        Me.OnomaShow.Name = "OnomaShow"
        Me.OnomaShow.Size = New System.Drawing.Size(10, 13)
        Me.OnomaShow.TabIndex = 4
        Me.OnomaShow.Text = "-"
        '
        'EpithetoShow
        '
        Me.EpithetoShow.AutoSize = True
        Me.EpithetoShow.Location = New System.Drawing.Point(118, 85)
        Me.EpithetoShow.Name = "EpithetoShow"
        Me.EpithetoShow.Size = New System.Drawing.Size(10, 13)
        Me.EpithetoShow.TabIndex = 5
        Me.EpithetoShow.Text = "-"
        '
        'HmShow
        '
        Me.HmShow.AutoSize = True
        Me.HmShow.Location = New System.Drawing.Point(118, 113)
        Me.HmShow.Name = "HmShow"
        Me.HmShow.Size = New System.Drawing.Size(10, 13)
        Me.HmShow.TabIndex = 6
        Me.HmShow.Text = "-"
        '
        'PerioxhShow
        '
        Me.PerioxhShow.AutoSize = True
        Me.PerioxhShow.Location = New System.Drawing.Point(118, 141)
        Me.PerioxhShow.Name = "PerioxhShow"
        Me.PerioxhShow.Size = New System.Drawing.Size(10, 13)
        Me.PerioxhShow.TabIndex = 7
        Me.PerioxhShow.Text = "-"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(43, 315)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 8
        Me.EditButton.Text = "Edit Profile"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(429, 315)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 9
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(429, 48)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 10
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ErgasiaLb
        '
        Me.ErgasiaLb.AutoSize = True
        Me.ErgasiaLb.Location = New System.Drawing.Point(40, 166)
        Me.ErgasiaLb.Name = "ErgasiaLb"
        Me.ErgasiaLb.Size = New System.Drawing.Size(48, 13)
        Me.ErgasiaLb.TabIndex = 11
        Me.ErgasiaLb.Text = "Ergasia :"
        '
        'ErgasiaShow
        '
        Me.ErgasiaShow.AutoSize = True
        Me.ErgasiaShow.Location = New System.Drawing.Point(121, 166)
        Me.ErgasiaShow.Name = "ErgasiaShow"
        Me.ErgasiaShow.Size = New System.Drawing.Size(10, 13)
        Me.ErgasiaShow.TabIndex = 12
        Me.ErgasiaShow.Text = "-"
        '
        'EmLb
        '
        Me.EmLb.AutoSize = True
        Me.EmLb.Location = New System.Drawing.Point(40, 191)
        Me.EmLb.Name = "EmLb"
        Me.EmLb.Size = New System.Drawing.Size(41, 13)
        Me.EmLb.TabIndex = 13
        Me.EmLb.Text = "E-mail :"
        '
        'EmShow
        '
        Me.EmShow.AutoSize = True
        Me.EmShow.Location = New System.Drawing.Point(118, 191)
        Me.EmShow.Name = "EmShow"
        Me.EmShow.Size = New System.Drawing.Size(10, 13)
        Me.EmShow.TabIndex = 14
        Me.EmShow.Text = "-"
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(Me.EmShow)
        Me.Controls.Add(Me.EmLb)
        Me.Controls.Add(Me.ErgasiaShow)
        Me.Controls.Add(Me.ErgasiaLb)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.PerioxhShow)
        Me.Controls.Add(Me.HmShow)
        Me.Controls.Add(Me.EpithetoShow)
        Me.Controls.Add(Me.OnomaShow)
        Me.Controls.Add(Me.PerioxhLb)
        Me.Controls.Add(Me.HmLb)
        Me.Controls.Add(Me.EpihetoLb)
        Me.Controls.Add(Me.NameLb)
        Me.Name = "ProfileForm"
        Me.Text = "Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLb As System.Windows.Forms.Label
    Friend WithEvents EpihetoLb As System.Windows.Forms.Label
    Friend WithEvents HmLb As System.Windows.Forms.Label
    Friend WithEvents PerioxhLb As System.Windows.Forms.Label
    Friend WithEvents OnomaShow As System.Windows.Forms.Label
    Friend WithEvents EpithetoShow As System.Windows.Forms.Label
    Friend WithEvents HmShow As System.Windows.Forms.Label
    Friend WithEvents PerioxhShow As System.Windows.Forms.Label
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents ErgasiaLb As System.Windows.Forms.Label
    Friend WithEvents ErgasiaShow As System.Windows.Forms.Label
    Friend WithEvents EmLb As System.Windows.Forms.Label
    Friend WithEvents EmShow As System.Windows.Forms.Label
End Class
