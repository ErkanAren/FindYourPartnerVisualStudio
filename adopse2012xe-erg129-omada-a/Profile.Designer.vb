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
        Dim OnomaLabel As System.Windows.Forms.Label
        Dim EpithetoLabel As System.Windows.Forms.Label
        Dim Hm_GennisisLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ErgasiaLabel As System.Windows.Forms.Label
        Dim PerioxhLabel As System.Windows.Forms.Label
        Me.EmShow = New System.Windows.Forms.Label
        Me.ErgasiaShow = New System.Windows.Forms.Label
        Me.SearchButton = New System.Windows.Forms.Button
        Me.LogoutButton = New System.Windows.Forms.Button
        Me.EditButton = New System.Windows.Forms.Button
        Me.PerioxhShow = New System.Windows.Forms.Label
        Me.HmShow = New System.Windows.Forms.Label
        Me.EpithetoShow = New System.Windows.Forms.Label
        Me.OnomaShow = New System.Windows.Forms.Label
        OnomaLabel = New System.Windows.Forms.Label
        EpithetoLabel = New System.Windows.Forms.Label
        Hm_GennisisLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        ErgasiaLabel = New System.Windows.Forms.Label
        PerioxhLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'OnomaLabel
        '
        OnomaLabel.AutoSize = True
        OnomaLabel.Location = New System.Drawing.Point(65, 46)
        OnomaLabel.Name = "OnomaLabel"
        OnomaLabel.Size = New System.Drawing.Size(47, 13)
        OnomaLabel.TabIndex = 53
        OnomaLabel.Text = "Όνομα :"
        '
        'EpithetoLabel
        '
        EpithetoLabel.AutoSize = True
        EpithetoLabel.Location = New System.Drawing.Point(58, 73)
        EpithetoLabel.Name = "EpithetoLabel"
        EpithetoLabel.Size = New System.Drawing.Size(54, 13)
        EpithetoLabel.TabIndex = 54
        EpithetoLabel.Text = "Επιθέτω :"
        '
        'Hm_GennisisLabel
        '
        Hm_GennisisLabel.AutoSize = True
        Hm_GennisisLabel.Location = New System.Drawing.Point(31, 101)
        Hm_GennisisLabel.Name = "Hm_GennisisLabel"
        Hm_GennisisLabel.Size = New System.Drawing.Size(81, 13)
        Hm_GennisisLabel.TabIndex = 55
        Hm_GennisisLabel.Text = "Ημ. γέννησης :"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(71, 179)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(41, 13)
        EmailLabel.TabIndex = 56
        EmailLabel.Text = "E-mail :"
        '
        'ErgasiaLabel
        '
        ErgasiaLabel.AutoSize = True
        ErgasiaLabel.Location = New System.Drawing.Point(57, 154)
        ErgasiaLabel.Name = "ErgasiaLabel"
        ErgasiaLabel.Size = New System.Drawing.Size(55, 13)
        ErgasiaLabel.TabIndex = 57
        ErgasiaLabel.Text = "Εργασία :"
        '
        'PerioxhLabel
        '
        PerioxhLabel.AutoSize = True
        PerioxhLabel.Location = New System.Drawing.Point(59, 129)
        PerioxhLabel.Name = "PerioxhLabel"
        PerioxhLabel.Size = New System.Drawing.Size(53, 13)
        PerioxhLabel.TabIndex = 58
        PerioxhLabel.Text = "Περιοχή :"
        '
        'EmShow
        '
        Me.EmShow.AutoSize = True
        Me.EmShow.Location = New System.Drawing.Point(131, 179)
        Me.EmShow.Name = "EmShow"
        Me.EmShow.Size = New System.Drawing.Size(10, 13)
        Me.EmShow.TabIndex = 52
        Me.EmShow.Text = "-"
        '
        'ErgasiaShow
        '
        Me.ErgasiaShow.AutoSize = True
        Me.ErgasiaShow.Location = New System.Drawing.Point(131, 154)
        Me.ErgasiaShow.Name = "ErgasiaShow"
        Me.ErgasiaShow.Size = New System.Drawing.Size(10, 13)
        Me.ErgasiaShow.TabIndex = 51
        Me.ErgasiaShow.Text = "-"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(429, 36)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 50
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(429, 303)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 49
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(43, 300)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 48
        Me.EditButton.Text = "Edit Profile"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'PerioxhShow
        '
        Me.PerioxhShow.AutoSize = True
        Me.PerioxhShow.Location = New System.Drawing.Point(131, 129)
        Me.PerioxhShow.Name = "PerioxhShow"
        Me.PerioxhShow.Size = New System.Drawing.Size(10, 13)
        Me.PerioxhShow.TabIndex = 47
        Me.PerioxhShow.Text = "-"
        '
        'HmShow
        '
        Me.HmShow.AutoSize = True
        Me.HmShow.Location = New System.Drawing.Point(131, 102)
        Me.HmShow.Name = "HmShow"
        Me.HmShow.Size = New System.Drawing.Size(10, 13)
        Me.HmShow.TabIndex = 46
        Me.HmShow.Text = "-"
        '
        'EpithetoShow
        '
        Me.EpithetoShow.AutoSize = True
        Me.EpithetoShow.Location = New System.Drawing.Point(131, 74)
        Me.EpithetoShow.Name = "EpithetoShow"
        Me.EpithetoShow.Size = New System.Drawing.Size(10, 13)
        Me.EpithetoShow.TabIndex = 45
        Me.EpithetoShow.Text = "-"
        '
        'OnomaShow
        '
        Me.OnomaShow.AutoSize = True
        Me.OnomaShow.Location = New System.Drawing.Point(131, 47)
        Me.OnomaShow.Name = "OnomaShow"
        Me.OnomaShow.Size = New System.Drawing.Size(10, 13)
        Me.OnomaShow.TabIndex = 44
        Me.OnomaShow.Text = "-"
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(OnomaLabel)
        Me.Controls.Add(EpithetoLabel)
        Me.Controls.Add(Hm_GennisisLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(ErgasiaLabel)
        Me.Controls.Add(PerioxhLabel)
        Me.Controls.Add(Me.EmShow)
        Me.Controls.Add(Me.ErgasiaShow)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.PerioxhShow)
        Me.Controls.Add(Me.HmShow)
        Me.Controls.Add(Me.EpithetoShow)
        Me.Controls.Add(Me.OnomaShow)
        Me.Name = "ProfileForm"
        Me.Text = "Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmShow As System.Windows.Forms.Label
    Friend WithEvents ErgasiaShow As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents PerioxhShow As System.Windows.Forms.Label
    Friend WithEvents HmShow As System.Windows.Forms.Label
    Friend WithEvents EpithetoShow As System.Windows.Forms.Label
    Friend WithEvents OnomaShow As System.Windows.Forms.Label
End Class
