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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileForm))
        Dim OnomaLabel As System.Windows.Forms.Label
        Dim EpithetoLabel As System.Windows.Forms.Label
        Dim Hm_GennisisLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ErgasiaLabel As System.Windows.Forms.Label
        Dim PerioxhLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'OnomaLabel
        '
        OnomaLabel.AutoSize = True
        OnomaLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        OnomaLabel.Location = New System.Drawing.Point(112, 91)
        OnomaLabel.Name = "OnomaLabel"
        OnomaLabel.Size = New System.Drawing.Size(64, 18)
        OnomaLabel.TabIndex = 54
        OnomaLabel.Text = "Όνομα :"
        '
        'EpithetoLabel
        '
        EpithetoLabel.AutoSize = True
        EpithetoLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        EpithetoLabel.Location = New System.Drawing.Point(105, 117)
        EpithetoLabel.Name = "EpithetoLabel"
        EpithetoLabel.Size = New System.Drawing.Size(71, 18)
        EpithetoLabel.TabIndex = 55
        EpithetoLabel.Text = "Επίθετο :"
        '
        'Hm_GennisisLabel
        '
        Hm_GennisisLabel.AutoSize = True
        Hm_GennisisLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Hm_GennisisLabel.Location = New System.Drawing.Point(63, 146)
        Hm_GennisisLabel.Name = "Hm_GennisisLabel"
        Hm_GennisisLabel.Size = New System.Drawing.Size(113, 18)
        Hm_GennisisLabel.TabIndex = 56
        Hm_GennisisLabel.Text = "Ημ. γέννησης :"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        EmailLabel.Location = New System.Drawing.Point(118, 223)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(59, 18)
        EmailLabel.TabIndex = 57
        EmailLabel.Text = "E-mail :"
        '
        'ErgasiaLabel
        '
        ErgasiaLabel.AutoSize = True
        ErgasiaLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ErgasiaLabel.Location = New System.Drawing.Point(104, 198)
        ErgasiaLabel.Name = "ErgasiaLabel"
        ErgasiaLabel.Size = New System.Drawing.Size(75, 18)
        ErgasiaLabel.TabIndex = 58
        ErgasiaLabel.Text = "Εργασία :"
        '
        'PerioxhLabel
        '
        PerioxhLabel.AutoSize = True
        PerioxhLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        PerioxhLabel.Location = New System.Drawing.Point(106, 173)
        PerioxhLabel.Name = "PerioxhLabel"
        PerioxhLabel.Size = New System.Drawing.Size(73, 18)
        PerioxhLabel.TabIndex = 59
        PerioxhLabel.Text = "Περιοχή :"
        '
        'EmShow
        '
        Me.EmShow.AutoSize = True
        Me.EmShow.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EmShow.Location = New System.Drawing.Point(178, 223)
        Me.EmShow.Name = "EmShow"
        Me.EmShow.Size = New System.Drawing.Size(12, 16)
        Me.EmShow.TabIndex = 53
        Me.EmShow.Text = "-"
        '
        'ErgasiaShow
        '
        Me.ErgasiaShow.AutoSize = True
        Me.ErgasiaShow.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ErgasiaShow.Location = New System.Drawing.Point(178, 198)
        Me.ErgasiaShow.Name = "ErgasiaShow"
        Me.ErgasiaShow.Size = New System.Drawing.Size(12, 16)
        Me.ErgasiaShow.TabIndex = 52
        Me.ErgasiaShow.Text = "-"
        '
        'SearchButton
        '
        Me.SearchButton.BackgroundImage = CType(resources.GetObject("SearchButton.BackgroundImage"), System.Drawing.Image)
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchButton.ForeColor = System.Drawing.SystemColors.Info
        Me.SearchButton.Location = New System.Drawing.Point(438, 46)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(84, 36)
        Me.SearchButton.TabIndex = 51
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.BackgroundImage = CType(resources.GetObject("LogoutButton.BackgroundImage"), System.Drawing.Image)
        Me.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutButton.ForeColor = System.Drawing.SystemColors.Info
        Me.LogoutButton.Location = New System.Drawing.Point(428, 310)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(84, 36)
        Me.LogoutButton.TabIndex = 50
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.BackgroundImage = CType(resources.GetObject("EditButton.BackgroundImage"), System.Drawing.Image)
        Me.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditButton.ForeColor = System.Drawing.SystemColors.Info
        Me.EditButton.Location = New System.Drawing.Point(339, 46)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(84, 36)
        Me.EditButton.TabIndex = 49
        Me.EditButton.Text = "Edit Profile"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'PerioxhShow
        '
        Me.PerioxhShow.AutoSize = True
        Me.PerioxhShow.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.PerioxhShow.Location = New System.Drawing.Point(178, 173)
        Me.PerioxhShow.Name = "PerioxhShow"
        Me.PerioxhShow.Size = New System.Drawing.Size(12, 16)
        Me.PerioxhShow.TabIndex = 48
        Me.PerioxhShow.Text = "-"
        '
        'HmShow
        '
        Me.HmShow.AutoSize = True
        Me.HmShow.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.HmShow.Location = New System.Drawing.Point(178, 146)
        Me.HmShow.Name = "HmShow"
        Me.HmShow.Size = New System.Drawing.Size(12, 16)
        Me.HmShow.TabIndex = 47
        Me.HmShow.Text = "-"
        '
        'EpithetoShow
        '
        Me.EpithetoShow.AutoSize = True
        Me.EpithetoShow.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EpithetoShow.Location = New System.Drawing.Point(178, 118)
        Me.EpithetoShow.Name = "EpithetoShow"
        Me.EpithetoShow.Size = New System.Drawing.Size(12, 16)
        Me.EpithetoShow.TabIndex = 46
        Me.EpithetoShow.Text = "-"
        '
        'OnomaShow
        '
        Me.OnomaShow.AutoSize = True
        Me.OnomaShow.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OnomaShow.Location = New System.Drawing.Point(178, 91)
        Me.OnomaShow.Name = "OnomaShow"
        Me.OnomaShow.Size = New System.Drawing.Size(12, 16)
        Me.OnomaShow.TabIndex = 45
        Me.OnomaShow.Text = "-"
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 369)
        Me.Controls.Add(Me.PictureBox1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
