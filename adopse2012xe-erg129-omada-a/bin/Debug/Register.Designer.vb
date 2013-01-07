<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container
        Dim Label9 As System.Windows.Forms.Label
        Dim FyloLabel As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
        Me.EmailError = New System.Windows.Forms.Label
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.HmError = New System.Windows.Forms.Label
        Me.EpithetoError = New System.Windows.Forms.Label
        Me.OnomaError = New System.Windows.Forms.Label
        Me.PasswordError = New System.Windows.Forms.Label
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.OnomaTextBox = New System.Windows.Forms.TextBox
        Me.EpithetoTextBox = New System.Windows.Forms.TextBox
        Me.Hm_GennisisTextBox = New System.Windows.Forms.TextBox
        Me.BarosTextBox = New System.Windows.Forms.TextBox
        Me.YpsosTextBox = New System.Windows.Forms.TextBox
        Me.FyloTextBox = New System.Windows.Forms.TextBox
        Me.Xrwma_MatiwnTextBox = New System.Windows.Forms.TextBox
        Me.Xrwma_MalliwnTextBox = New System.Windows.Forms.TextBox
        Me.Hoby1TextBox = New System.Windows.Forms.TextBox
        Me.Hoby2TextBox = New System.Windows.Forms.TextBox
        Me.Hoby3TextBox = New System.Windows.Forms.TextBox
        Me.AnazitaTextBox = New System.Windows.Forms.TextBox
        Me.GlwssaTextBox = New System.Windows.Forms.TextBox
        Me.Glwssa2TextBox = New System.Windows.Forms.TextBox
        Me.TatooTextBox = New System.Windows.Forms.TextBox
        Me.ErgasiaTextBox = New System.Windows.Forms.TextBox
        Me.PerioxhTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.HelpLabel = New System.Windows.Forms.Label
        Me.RgButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Label9 = New System.Windows.Forms.Label
        FyloLabel = New System.Windows.Forms.Label
        Label16 = New System.Windows.Forms.Label
        Label17 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        Label14 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        PasswordLabel = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(174, 98)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(41, 13)
        Label9.TabIndex = 113
        Label9.Text = "E-mail :"
        '
        'FyloLabel
        '
        FyloLabel.AutoSize = True
        FyloLabel.Location = New System.Drawing.Point(442, 287)
        FyloLabel.Name = "FyloLabel"
        FyloLabel.Size = New System.Drawing.Size(40, 13)
        FyloLabel.TabIndex = 107
        FyloLabel.Text = "Φύλο :"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(427, 234)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(55, 13)
        Label16.TabIndex = 105
        Label16.Text = "Εργασία :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(429, 260)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(53, 13)
        Label17.TabIndex = 106
        Label17.Text = "Περιοχή :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(427, 50)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 98
        Label1.Text = "Hobby - 1 :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(427, 76)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(59, 13)
        Label10.TabIndex = 99
        Label10.Text = "Hobby - 2 :"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(427, 103)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(59, 13)
        Label11.TabIndex = 100
        Label11.Text = "Hobby - 3 :"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(428, 129)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(57, 13)
        Label12.TabIndex = 101
        Label12.Text = "Αναζήτα :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(430, 155)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(56, 13)
        Label13.TabIndex = 102
        Label13.Text = "Γλωσσά : "
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(415, 181)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(68, 13)
        Label14.TabIndex = 103
        Label14.Text = "Γλωσσά - 2 :"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(442, 207)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(41, 13)
        Label15.TabIndex = 104
        Label15.Text = "Tatoo :"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(146, 252)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(76, 13)
        Label7.TabIndex = 96
        Label7.Text = "Χρ. Ματιών :  "
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(141, 279)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(74, 13)
        Label8.TabIndex = 97
        Label8.Text = "Χρ. Μαλλιών :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(170, 122)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 91
        Label2.Text = "Όνομα :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(163, 149)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 92
        Label3.Text = "Επίθετο  :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(136, 173)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 13)
        Label4.TabIndex = 93
        Label4.Text = "Ημ. γέννησης :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(173, 201)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 13)
        Label5.TabIndex = 94
        Label5.Text = "Βάρος :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(175, 227)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(42, 13)
        Label6.TabIndex = 95
        Label6.Text = "Ύψος :"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(196, 50)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 70
        IDLabel.Text = "ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(123, 75)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(94, 13)
        PasswordLabel.TabIndex = 89
        PasswordLabel.Text = "Κωδικός Χρήστη :"
        '
        'PeopleDataSet
        '
        Me.PeopleDataSet.DataSetName = "peopleDataSet"
        Me.PeopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PeopleBindingSource
        '
        Me.PeopleBindingSource.DataMember = "People"
        Me.PeopleBindingSource.DataSource = Me.PeopleDataSet
        '
        'PeopleTableAdapter
        '
        Me.PeopleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PeopleTableAdapter = Me.PeopleTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmailError
        '
        Me.EmailError.AutoSize = True
        Me.EmailError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.EmailError.ForeColor = System.Drawing.Color.Red
        Me.EmailError.Location = New System.Drawing.Point(325, 95)
        Me.EmailError.Name = "EmailError"
        Me.EmailError.Size = New System.Drawing.Size(21, 23)
        Me.EmailError.TabIndex = 114
        Me.EmailError.Text = "*"
        Me.EmailError.Visible = False
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(223, 97)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 112
        '
        'HmError
        '
        Me.HmError.AutoSize = True
        Me.HmError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HmError.ForeColor = System.Drawing.Color.Red
        Me.HmError.Location = New System.Drawing.Point(325, 172)
        Me.HmError.Name = "HmError"
        Me.HmError.Size = New System.Drawing.Size(21, 23)
        Me.HmError.TabIndex = 111
        Me.HmError.Text = "*"
        Me.HmError.Visible = False
        '
        'EpithetoError
        '
        Me.EpithetoError.AutoSize = True
        Me.EpithetoError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.EpithetoError.ForeColor = System.Drawing.Color.Red
        Me.EpithetoError.Location = New System.Drawing.Point(325, 145)
        Me.EpithetoError.Name = "EpithetoError"
        Me.EpithetoError.Size = New System.Drawing.Size(21, 23)
        Me.EpithetoError.TabIndex = 110
        Me.EpithetoError.Text = "*"
        Me.EpithetoError.Visible = False
        '
        'OnomaError
        '
        Me.OnomaError.AutoSize = True
        Me.OnomaError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.OnomaError.ForeColor = System.Drawing.Color.Red
        Me.OnomaError.Location = New System.Drawing.Point(325, 119)
        Me.OnomaError.Name = "OnomaError"
        Me.OnomaError.Size = New System.Drawing.Size(21, 23)
        Me.OnomaError.TabIndex = 109
        Me.OnomaError.Text = "*"
        Me.OnomaError.Visible = False
        '
        'PasswordError
        '
        Me.PasswordError.AutoSize = True
        Me.PasswordError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.PasswordError.ForeColor = System.Drawing.Color.Red
        Me.PasswordError.Location = New System.Drawing.Point(325, 71)
        Me.PasswordError.Name = "PasswordError"
        Me.PasswordError.Size = New System.Drawing.Size(21, 23)
        Me.PasswordError.TabIndex = 108
        Me.PasswordError.Text = "*"
        Me.PasswordError.Visible = False
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(223, 47)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 71
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(223, 121)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 72
        '
        'EpithetoTextBox
        '
        Me.EpithetoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.EpithetoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Epitheto", True))
        Me.EpithetoTextBox.Location = New System.Drawing.Point(223, 147)
        Me.EpithetoTextBox.Name = "EpithetoTextBox"
        Me.EpithetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EpithetoTextBox.TabIndex = 73
        '
        'Hm_GennisisTextBox
        '
        Me.Hm_GennisisTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hm_GennisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hm_Gennisis", True))
        Me.Hm_GennisisTextBox.Location = New System.Drawing.Point(223, 173)
        Me.Hm_GennisisTextBox.Name = "Hm_GennisisTextBox"
        Me.Hm_GennisisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hm_GennisisTextBox.TabIndex = 74
        '
        'BarosTextBox
        '
        Me.BarosTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.BarosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Baros", True))
        Me.BarosTextBox.Location = New System.Drawing.Point(223, 199)
        Me.BarosTextBox.Name = "BarosTextBox"
        Me.BarosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarosTextBox.TabIndex = 75
        '
        'YpsosTextBox
        '
        Me.YpsosTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.YpsosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ypsos", True))
        Me.YpsosTextBox.Location = New System.Drawing.Point(223, 225)
        Me.YpsosTextBox.Name = "YpsosTextBox"
        Me.YpsosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YpsosTextBox.TabIndex = 76
        '
        'FyloTextBox
        '
        Me.FyloTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.FyloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Fylo", True))
        Me.FyloTextBox.Location = New System.Drawing.Point(492, 284)
        Me.FyloTextBox.Name = "FyloTextBox"
        Me.FyloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FyloTextBox.TabIndex = 77
        '
        'Xrwma_MatiwnTextBox
        '
        Me.Xrwma_MatiwnTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Xrwma_MatiwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Matiwn", True))
        Me.Xrwma_MatiwnTextBox.Location = New System.Drawing.Point(223, 252)
        Me.Xrwma_MatiwnTextBox.Name = "Xrwma_MatiwnTextBox"
        Me.Xrwma_MatiwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MatiwnTextBox.TabIndex = 78
        '
        'Xrwma_MalliwnTextBox
        '
        Me.Xrwma_MalliwnTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Xrwma_MalliwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Malliwn", True))
        Me.Xrwma_MalliwnTextBox.Location = New System.Drawing.Point(223, 278)
        Me.Xrwma_MalliwnTextBox.Name = "Xrwma_MalliwnTextBox"
        Me.Xrwma_MalliwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MalliwnTextBox.TabIndex = 79
        '
        'Hoby1TextBox
        '
        Me.Hoby1TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby1", True))
        Me.Hoby1TextBox.Location = New System.Drawing.Point(492, 50)
        Me.Hoby1TextBox.Name = "Hoby1TextBox"
        Me.Hoby1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby1TextBox.TabIndex = 80
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(492, 76)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 81
        '
        'Hoby3TextBox
        '
        Me.Hoby3TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby3", True))
        Me.Hoby3TextBox.Location = New System.Drawing.Point(492, 102)
        Me.Hoby3TextBox.Name = "Hoby3TextBox"
        Me.Hoby3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby3TextBox.TabIndex = 82
        '
        'AnazitaTextBox
        '
        Me.AnazitaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.AnazitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Anazita", True))
        Me.AnazitaTextBox.Location = New System.Drawing.Point(492, 128)
        Me.AnazitaTextBox.Name = "AnazitaTextBox"
        Me.AnazitaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnazitaTextBox.TabIndex = 83
        '
        'GlwssaTextBox
        '
        Me.GlwssaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.GlwssaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa", True))
        Me.GlwssaTextBox.Location = New System.Drawing.Point(492, 154)
        Me.GlwssaTextBox.Name = "GlwssaTextBox"
        Me.GlwssaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GlwssaTextBox.TabIndex = 84
        '
        'Glwssa2TextBox
        '
        Me.Glwssa2TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Glwssa2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa2", True))
        Me.Glwssa2TextBox.Location = New System.Drawing.Point(492, 180)
        Me.Glwssa2TextBox.Name = "Glwssa2TextBox"
        Me.Glwssa2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Glwssa2TextBox.TabIndex = 85
        '
        'TatooTextBox
        '
        Me.TatooTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.TatooTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Tatoo", True))
        Me.TatooTextBox.Location = New System.Drawing.Point(492, 206)
        Me.TatooTextBox.Name = "TatooTextBox"
        Me.TatooTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TatooTextBox.TabIndex = 86
        '
        'ErgasiaTextBox
        '
        Me.ErgasiaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.ErgasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ergasia", True))
        Me.ErgasiaTextBox.Location = New System.Drawing.Point(492, 232)
        Me.ErgasiaTextBox.Name = "ErgasiaTextBox"
        Me.ErgasiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErgasiaTextBox.TabIndex = 87
        '
        'PerioxhTextBox
        '
        Me.PerioxhTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.PerioxhTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Perioxh", True))
        Me.PerioxhTextBox.Location = New System.Drawing.Point(492, 258)
        Me.PerioxhTextBox.Name = "PerioxhTextBox"
        Me.PerioxhTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerioxhTextBox.TabIndex = 88
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(223, 73)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 90
        '
        'HelpLabel
        '
        Me.HelpLabel.AutoSize = True
        Me.HelpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.HelpLabel.ForeColor = System.Drawing.Color.Red
        Me.HelpLabel.Location = New System.Drawing.Point(186, 342)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(243, 13)
        Me.HelpLabel.TabIndex = 116
        Me.HelpLabel.Text = "Συμπληρώστε τα υποχρεωτικά πεδία  !!!"
        Me.HelpLabel.Visible = False
        '
        'RgButton
        '
        Me.RgButton.BackgroundImage = CType(resources.GetObject("RgButton.BackgroundImage"), System.Drawing.Image)
        Me.RgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RgButton.ForeColor = System.Drawing.SystemColors.Info
        Me.RgButton.Location = New System.Drawing.Point(506, 332)
        Me.RgButton.Name = "RgButton"
        Me.RgButton.Size = New System.Drawing.Size(86, 34)
        Me.RgButton.TabIndex = 115
        Me.RgButton.Text = "Register"
        Me.RgButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(676, 404)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.RgButton)
        Me.Controls.Add(Me.EmailError)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.HmError)
        Me.Controls.Add(Me.EpithetoError)
        Me.Controls.Add(Me.OnomaError)
        Me.Controls.Add(Me.PasswordError)
        Me.Controls.Add(FyloLabel)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.OnomaTextBox)
        Me.Controls.Add(Me.EpithetoTextBox)
        Me.Controls.Add(Me.Hm_GennisisTextBox)
        Me.Controls.Add(Me.BarosTextBox)
        Me.Controls.Add(Me.YpsosTextBox)
        Me.Controls.Add(Me.FyloTextBox)
        Me.Controls.Add(Me.Xrwma_MatiwnTextBox)
        Me.Controls.Add(Me.Xrwma_MalliwnTextBox)
        Me.Controls.Add(Me.Hoby1TextBox)
        Me.Controls.Add(Me.Hoby2TextBox)
        Me.Controls.Add(Me.Hoby3TextBox)
        Me.Controls.Add(Me.AnazitaTextBox)
        Me.Controls.Add(Me.GlwssaTextBox)
        Me.Controls.Add(Me.Glwssa2TextBox)
        Me.Controls.Add(Me.TatooTextBox)
        Me.Controls.Add(Me.ErgasiaTextBox)
        Me.Controls.Add(Me.PerioxhTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Name = "RegisterForm"
        Me.Text = "Register"
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeopleDataSet As WindowsApplication1.peopleDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmailError As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HmError As System.Windows.Forms.Label
    Friend WithEvents EpithetoError As System.Windows.Forms.Label
    Friend WithEvents OnomaError As System.Windows.Forms.Label
    Friend WithEvents PasswordError As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OnomaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EpithetoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hm_GennisisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BarosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YpsosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FyloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Xrwma_MatiwnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Xrwma_MalliwnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnazitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GlwssaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Glwssa2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TatooTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErgasiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerioxhTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HelpLabel As System.Windows.Forms.Label
    Friend WithEvents RgButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
