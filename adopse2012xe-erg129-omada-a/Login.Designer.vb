<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RegisterButton = New System.Windows.Forms.Button
        Me.LoginButton = New System.Windows.Forms.Button
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UserNameLabel = New System.Windows.Forms.Label
        Me.PasswordText = New System.Windows.Forms.TextBox
        Me.UserNameText = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'RegisterButton
        '
        Me.RegisterButton.BackgroundImage = CType(resources.GetObject("RegisterButton.BackgroundImage"), System.Drawing.Image)
        Me.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegisterButton.ForeColor = System.Drawing.SystemColors.Info
        Me.RegisterButton.Location = New System.Drawing.Point(304, 139)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 36)
        Me.RegisterButton.TabIndex = 12
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.MenuBar
        Me.LoginButton.BackgroundImage = CType(resources.GetObject("LoginButton.BackgroundImage"), System.Drawing.Image)
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LoginButton.ForeColor = System.Drawing.SystemColors.Info
        Me.LoginButton.Location = New System.Drawing.Point(223, 139)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 36)
        Me.LoginButton.TabIndex = 11
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(125, 94)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(110, 13)
        Me.PasswordLabel.TabIndex = 10
        Me.PasswordLabel.Text = "Κωδικός Χρήστη :"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.Location = New System.Drawing.Point(133, 49)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(102, 13)
        Me.UserNameLabel.TabIndex = 9
        Me.UserNameLabel.Text = "Όνομα Χρήστη :"
        '
        'PasswordText
        '
        Me.PasswordText.BackColor = System.Drawing.SystemColors.Info
        Me.PasswordText.Location = New System.Drawing.Point(241, 91)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(141, 20)
        Me.PasswordText.TabIndex = 8
        '
        'UserNameText
        '
        Me.UserNameText.BackColor = System.Drawing.SystemColors.Info
        Me.UserNameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.UserNameText.Location = New System.Drawing.Point(241, 46)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(141, 22)
        Me.UserNameText.TabIndex = 7
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(431, 220)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UserNameText)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordText As System.Windows.Forms.TextBox
    Friend WithEvents UserNameText As System.Windows.Forms.TextBox
End Class
