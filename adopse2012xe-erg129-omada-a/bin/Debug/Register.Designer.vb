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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
        Me.Label18 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.HelpLabel = New System.Windows.Forms.Label
        Me.EmailError = New System.Windows.Forms.Label
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.HmError = New System.Windows.Forms.Label
        Me.EpithetoError = New System.Windows.Forms.Label
        Me.OnomaError = New System.Windows.Forms.Label
        Me.PasswordError = New System.Windows.Forms.Label
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
        Me.RgButton = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
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
        PasswordLabel = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(157, 76)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(41, 13)
        Label9.TabIndex = 113
        Label9.Text = "E-mail :"
        '
        'FyloLabel
        '
        FyloLabel.AutoSize = True
        FyloLabel.Location = New System.Drawing.Point(156, 284)
        FyloLabel.Name = "FyloLabel"
        FyloLabel.Size = New System.Drawing.Size(40, 13)
        FyloLabel.TabIndex = 107
        FyloLabel.Text = "Φύλο :"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(422, 236)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(55, 13)
        Label16.TabIndex = 105
        Label16.Text = "Εργασία :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(424, 262)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(53, 13)
        Label17.TabIndex = 106
        Label17.Text = "Περιοχή :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(422, 52)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 98
        Label1.Text = "Hobby - 1 :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(422, 78)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(59, 13)
        Label10.TabIndex = 99
        Label10.Text = "Hobby - 2 :"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(422, 105)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(59, 13)
        Label11.TabIndex = 100
        Label11.Text = "Hobby - 3 :"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(423, 131)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(57, 13)
        Label12.TabIndex = 101
        Label12.Text = "Αναζήτα :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(425, 157)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(56, 13)
        Label13.TabIndex = 102
        Label13.Text = "Γλωσσά : "
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(410, 183)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(68, 13)
        Label14.TabIndex = 103
        Label14.Text = "Γλωσσά - 2 :"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(437, 209)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(41, 13)
        Label15.TabIndex = 104
        Label15.Text = "Tatoo :"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(129, 230)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(76, 13)
        Label7.TabIndex = 96
        Label7.Text = "Χρ. Ματιών :  "
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(124, 257)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(74, 13)
        Label8.TabIndex = 97
        Label8.Text = "Χρ. Μαλλιών :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(153, 100)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 91
        Label2.Text = "Όνομα :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(146, 127)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 92
        Label3.Text = "Επίθετο  :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(119, 151)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 13)
        Label4.TabIndex = 93
        Label4.Text = "Ημ. γέννησης :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(156, 179)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 13)
        Label5.TabIndex = 94
        Label5.Text = "Βάρος :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(158, 205)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(42, 13)
        Label6.TabIndex = 95
        Label6.Text = "Ύψος :"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(106, 53)
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.Location = New System.Drawing.Point(592, 213)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 117
        Me.Label18.Text = "YES or NO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'HelpLabel
        '
        Me.HelpLabel.AutoSize = True
        Me.HelpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.HelpLabel.ForeColor = System.Drawing.Color.Red
        Me.HelpLabel.Location = New System.Drawing.Point(167, 343)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(243, 13)
        Me.HelpLabel.TabIndex = 115
        Me.HelpLabel.Text = "Συμπληρώστε τα υποχρεωτικά πεδία  !!!"
        Me.HelpLabel.Visible = False
        '
        'EmailError
        '
        Me.EmailError.AutoSize = True
        Me.EmailError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.EmailError.ForeColor = System.Drawing.Color.Red
        Me.EmailError.Location = New System.Drawing.Point(308, 73)
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
        Me.EmailTextBox.Location = New System.Drawing.Point(206, 74)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 112
        '
        'HmError
        '
        Me.HmError.AutoSize = True
        Me.HmError.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HmError.ForeColor = System.Drawing.Color.Red
        Me.HmError.Location = New System.Drawing.Point(308, 150)
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
        Me.EpithetoError.Location = New System.Drawing.Point(308, 123)
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
        Me.OnomaError.Location = New System.Drawing.Point(308, 97)
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
        Me.PasswordError.Location = New System.Drawing.Point(308, 49)
        Me.PasswordError.Name = "PasswordError"
        Me.PasswordError.Size = New System.Drawing.Size(21, 23)
        Me.PasswordError.TabIndex = 108
        Me.PasswordError.Text = "*"
        Me.PasswordError.Visible = False
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(206, 98)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 72
        '
        'EpithetoTextBox
        '
        Me.EpithetoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.EpithetoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Epitheto", True))
        Me.EpithetoTextBox.Location = New System.Drawing.Point(206, 124)
        Me.EpithetoTextBox.Name = "EpithetoTextBox"
        Me.EpithetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EpithetoTextBox.TabIndex = 73
        '
        'Hm_GennisisTextBox
        '
        Me.Hm_GennisisTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hm_GennisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hm_Gennisis", True))
        Me.Hm_GennisisTextBox.Location = New System.Drawing.Point(206, 150)
        Me.Hm_GennisisTextBox.Name = "Hm_GennisisTextBox"
        Me.Hm_GennisisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hm_GennisisTextBox.TabIndex = 74
        '
        'BarosTextBox
        '
        Me.BarosTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.BarosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Baros", True))
        Me.BarosTextBox.Location = New System.Drawing.Point(206, 176)
        Me.BarosTextBox.Name = "BarosTextBox"
        Me.BarosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarosTextBox.TabIndex = 75
        '
        'YpsosTextBox
        '
        Me.YpsosTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.YpsosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ypsos", True))
        Me.YpsosTextBox.Location = New System.Drawing.Point(206, 202)
        Me.YpsosTextBox.Name = "YpsosTextBox"
        Me.YpsosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YpsosTextBox.TabIndex = 76
        '
        'FyloTextBox
        '
        Me.FyloTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.FyloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Fylo", True))
        Me.FyloTextBox.Location = New System.Drawing.Point(206, 281)
        Me.FyloTextBox.Name = "FyloTextBox"
        Me.FyloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FyloTextBox.TabIndex = 77
        '
        'Xrwma_MatiwnTextBox
        '
        Me.Xrwma_MatiwnTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Xrwma_MatiwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Matiwn", True))
        Me.Xrwma_MatiwnTextBox.Location = New System.Drawing.Point(206, 229)
        Me.Xrwma_MatiwnTextBox.Name = "Xrwma_MatiwnTextBox"
        Me.Xrwma_MatiwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MatiwnTextBox.TabIndex = 78
        '
        'Xrwma_MalliwnTextBox
        '
        Me.Xrwma_MalliwnTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Xrwma_MalliwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Malliwn", True))
        Me.Xrwma_MalliwnTextBox.Location = New System.Drawing.Point(206, 255)
        Me.Xrwma_MalliwnTextBox.Name = "Xrwma_MalliwnTextBox"
        Me.Xrwma_MalliwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MalliwnTextBox.TabIndex = 79
        '
        'Hoby1TextBox
        '
        Me.Hoby1TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby1", True))
        Me.Hoby1TextBox.Location = New System.Drawing.Point(487, 52)
        Me.Hoby1TextBox.Name = "Hoby1TextBox"
        Me.Hoby1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby1TextBox.TabIndex = 80
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(487, 78)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 81
        '
        'Hoby3TextBox
        '
        Me.Hoby3TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby3", True))
        Me.Hoby3TextBox.Location = New System.Drawing.Point(487, 104)
        Me.Hoby3TextBox.Name = "Hoby3TextBox"
        Me.Hoby3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby3TextBox.TabIndex = 82
        '
        'AnazitaTextBox
        '
        Me.AnazitaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.AnazitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Anazita", True))
        Me.AnazitaTextBox.Location = New System.Drawing.Point(487, 130)
        Me.AnazitaTextBox.Name = "AnazitaTextBox"
        Me.AnazitaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnazitaTextBox.TabIndex = 83
        '
        'GlwssaTextBox
        '
        Me.GlwssaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.GlwssaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa", True))
        Me.GlwssaTextBox.Location = New System.Drawing.Point(487, 156)
        Me.GlwssaTextBox.Name = "GlwssaTextBox"
        Me.GlwssaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GlwssaTextBox.TabIndex = 84
        '
        'Glwssa2TextBox
        '
        Me.Glwssa2TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Glwssa2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa2", True))
        Me.Glwssa2TextBox.Location = New System.Drawing.Point(487, 182)
        Me.Glwssa2TextBox.Name = "Glwssa2TextBox"
        Me.Glwssa2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Glwssa2TextBox.TabIndex = 85
        '
        'TatooTextBox
        '
        Me.TatooTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.TatooTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Tatoo", True))
        Me.TatooTextBox.Location = New System.Drawing.Point(487, 208)
        Me.TatooTextBox.Name = "TatooTextBox"
        Me.TatooTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TatooTextBox.TabIndex = 86
        '
        'ErgasiaTextBox
        '
        Me.ErgasiaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.ErgasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ergasia", True))
        Me.ErgasiaTextBox.Location = New System.Drawing.Point(487, 234)
        Me.ErgasiaTextBox.Name = "ErgasiaTextBox"
        Me.ErgasiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErgasiaTextBox.TabIndex = 87
        '
        'PerioxhTextBox
        '
        Me.PerioxhTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.PerioxhTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Perioxh", True))
        Me.PerioxhTextBox.Location = New System.Drawing.Point(487, 260)
        Me.PerioxhTextBox.Name = "PerioxhTextBox"
        Me.PerioxhTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerioxhTextBox.TabIndex = 88
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(206, 50)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 90
        '
        'RgButton
        '
        Me.RgButton.BackgroundImage = CType(resources.GetObject("RgButton.BackgroundImage"), System.Drawing.Image)
        Me.RgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RgButton.ForeColor = System.Drawing.SystemColors.Info
        Me.RgButton.Location = New System.Drawing.Point(565, 332)
        Me.RgButton.Name = "RgButton"
        Me.RgButton.Size = New System.Drawing.Size(86, 34)
        Me.RgButton.TabIndex = 71
        Me.RgButton.Text = "Register"
        Me.RgButton.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Location = New System.Drawing.Point(313, 205)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 13)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "cm"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label20.Location = New System.Drawing.Point(312, 179)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "kg"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label21.Location = New System.Drawing.Point(312, 284)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 13)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "MALE or FEMALE"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label22.Location = New System.Drawing.Point(595, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 13)
        Me.Label22.TabIndex = 121
        Me.Label22.Text = "MAN or WOMAN"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 404)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HelpLabel)
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
        Me.Controls.Add(Me.RgButton)
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HelpLabel As System.Windows.Forms.Label
    Friend WithEvents EmailError As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HmError As System.Windows.Forms.Label
    Friend WithEvents EpithetoError As System.Windows.Forms.Label
    Friend WithEvents OnomaError As System.Windows.Forms.Label
    Friend WithEvents PasswordError As System.Windows.Forms.Label
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
    Friend WithEvents RgButton As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
