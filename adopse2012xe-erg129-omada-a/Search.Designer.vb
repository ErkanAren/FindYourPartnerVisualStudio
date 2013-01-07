<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim FyloLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.NoRadioButton = New System.Windows.Forms.RadioButton
        Me.YesRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.WomanRadioButton = New System.Windows.Forms.RadioButton
        Me.ManRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton
        Me.YpsosEws = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ypsosApo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.HmGenEws = New System.Windows.Forms.TextBox
        Me.HmGenApo = New System.Windows.Forms.TextBox
        Me.Xrmalbox = New System.Windows.Forms.ComboBox
        Me.Xrmatbox = New System.Windows.Forms.ComboBox
        Me.Barosbox = New System.Windows.Forms.ComboBox
        Me.OnomaTextBox = New System.Windows.Forms.TextBox
        Me.Hoby1TextBox = New System.Windows.Forms.TextBox
        Me.Hoby2TextBox = New System.Windows.Forms.TextBox
        Me.Hoby3TextBox = New System.Windows.Forms.TextBox
        Me.GlwssaTextBox = New System.Windows.Forms.TextBox
        Me.Glwssa2TextBox = New System.Windows.Forms.TextBox
        Me.ErgasiaTextBox = New System.Windows.Forms.TextBox
        Me.PerioxhTextBox = New System.Windows.Forms.TextBox
        Me.SrBt = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Label9 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        Label14 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label16 = New System.Windows.Forms.Label
        Label17 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        FyloLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(384, 52)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(59, 13)
        Label9.TabIndex = 139
        Label9.Text = "Hobby - 1 :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(384, 83)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(59, 13)
        Label10.TabIndex = 140
        Label10.Text = "Hobby - 2 :"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(384, 115)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(59, 13)
        Label11.TabIndex = 141
        Label11.Text = "Hobby - 3 :"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(385, 147)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(57, 13)
        Label12.TabIndex = 142
        Label12.Text = "Αναζήτα :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(387, 184)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(56, 13)
        Label13.TabIndex = 143
        Label13.Text = "Γλωσσά : "
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(372, 217)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(68, 13)
        Label14.TabIndex = 144
        Label14.Text = "Γλωσσά - 2 :"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(160, 275)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(41, 13)
        Label15.TabIndex = 145
        Label15.Text = "Tatoo :"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(385, 250)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(55, 13)
        Label16.TabIndex = 146
        Label16.Text = "Εργασία :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(387, 282)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(53, 13)
        Label17.TabIndex = 147
        Label17.Text = "Περιοχή :"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(129, 212)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(76, 13)
        Label7.TabIndex = 137
        Label7.Text = "Χρ. Ματιών :  "
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(128, 243)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(74, 13)
        Label8.TabIndex = 138
        Label8.Text = "Χρ. Μαλλιών :"
        '
        'FyloLabel
        '
        FyloLabel.AutoSize = True
        FyloLabel.Location = New System.Drawing.Point(162, 181)
        FyloLabel.Name = "FyloLabel"
        FyloLabel.Size = New System.Drawing.Size(40, 13)
        FyloLabel.TabIndex = 136
        FyloLabel.Text = "Φύλο :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(157, 56)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 13)
        Label3.TabIndex = 132
        Label3.Text = "Όνομα :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(123, 88)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 13)
        Label4.TabIndex = 133
        Label4.Text = "Ημ. γέννησης :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(160, 115)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 13)
        Label5.TabIndex = 134
        Label5.Text = "Βάρος :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(162, 143)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(42, 13)
        Label6.TabIndex = 135
        Label6.Text = "Ύψος :"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NoRadioButton)
        Me.GroupBox3.Controls.Add(Me.YesRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(209, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(139, 35)
        Me.GroupBox3.TabIndex = 150
        Me.GroupBox3.TabStop = False
        '
        'NoRadioButton
        '
        Me.NoRadioButton.AutoSize = True
        Me.NoRadioButton.Location = New System.Drawing.Point(72, 11)
        Me.NoRadioButton.Name = "NoRadioButton"
        Me.NoRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.NoRadioButton.TabIndex = 1
        Me.NoRadioButton.TabStop = True
        Me.NoRadioButton.Text = "NO"
        Me.NoRadioButton.UseVisualStyleBackColor = True
        '
        'YesRadioButton
        '
        Me.YesRadioButton.AutoSize = True
        Me.YesRadioButton.Location = New System.Drawing.Point(12, 11)
        Me.YesRadioButton.Name = "YesRadioButton"
        Me.YesRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.YesRadioButton.TabIndex = 0
        Me.YesRadioButton.TabStop = True
        Me.YesRadioButton.Text = "YES"
        Me.YesRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WomanRadioButton)
        Me.GroupBox2.Controls.Add(Me.ManRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(448, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 35)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        '
        'WomanRadioButton
        '
        Me.WomanRadioButton.AutoSize = True
        Me.WomanRadioButton.Location = New System.Drawing.Point(71, 12)
        Me.WomanRadioButton.Name = "WomanRadioButton"
        Me.WomanRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.WomanRadioButton.TabIndex = 1
        Me.WomanRadioButton.TabStop = True
        Me.WomanRadioButton.Text = "WOMAN"
        Me.WomanRadioButton.UseVisualStyleBackColor = True
        '
        'ManRadioButton
        '
        Me.ManRadioButton.AutoSize = True
        Me.ManRadioButton.Location = New System.Drawing.Point(16, 12)
        Me.ManRadioButton.Name = "ManRadioButton"
        Me.ManRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.ManRadioButton.TabIndex = 0
        Me.ManRadioButton.TabStop = True
        Me.ManRadioButton.Text = "MAN"
        Me.ManRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FemaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.MaleRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 35)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(73, 12)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.FemaleRadioButton.TabIndex = 3
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "FEMALE"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(13, 11)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.MaleRadioButton.TabIndex = 2
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "MALE"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'YpsosEws
        '
        Me.YpsosEws.BackColor = System.Drawing.SystemColors.Info
        Me.YpsosEws.Location = New System.Drawing.Point(274, 140)
        Me.YpsosEws.Name = "YpsosEws"
        Me.YpsosEws.Size = New System.Drawing.Size(38, 20)
        Me.YpsosEws.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "To:"
        '
        'ypsosApo
        '
        Me.ypsosApo.BackColor = System.Drawing.SystemColors.Info
        Me.ypsosApo.Location = New System.Drawing.Point(211, 140)
        Me.ypsosApo.Name = "ypsosApo"
        Me.ypsosApo.Size = New System.Drawing.Size(38, 20)
        Me.ypsosApo.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "To:"
        '
        'HmGenEws
        '
        Me.HmGenEws.BackColor = System.Drawing.SystemColors.Info
        Me.HmGenEws.Location = New System.Drawing.Point(274, 86)
        Me.HmGenEws.Name = "HmGenEws"
        Me.HmGenEws.Size = New System.Drawing.Size(37, 20)
        Me.HmGenEws.TabIndex = 127
        '
        'HmGenApo
        '
        Me.HmGenApo.BackColor = System.Drawing.SystemColors.Info
        Me.HmGenApo.Location = New System.Drawing.Point(211, 86)
        Me.HmGenApo.Name = "HmGenApo"
        Me.HmGenApo.Size = New System.Drawing.Size(38, 20)
        Me.HmGenApo.TabIndex = 126
        '
        'Xrmalbox
        '
        Me.Xrmalbox.BackColor = System.Drawing.SystemColors.Info
        Me.Xrmalbox.FormattingEnabled = True
        Me.Xrmalbox.Items.AddRange(New Object() {"BLONDE", "BROWN", "BLACK", "RED"})
        Me.Xrmalbox.Location = New System.Drawing.Point(211, 240)
        Me.Xrmalbox.Name = "Xrmalbox"
        Me.Xrmalbox.Size = New System.Drawing.Size(100, 21)
        Me.Xrmalbox.TabIndex = 125
        '
        'Xrmatbox
        '
        Me.Xrmatbox.BackColor = System.Drawing.SystemColors.Info
        Me.Xrmatbox.FormattingEnabled = True
        Me.Xrmatbox.Items.AddRange(New Object() {"BLUE", "BROWN", "BLACK", "GREEN", "HAZEL"})
        Me.Xrmatbox.Location = New System.Drawing.Point(211, 208)
        Me.Xrmatbox.Name = "Xrmatbox"
        Me.Xrmatbox.Size = New System.Drawing.Size(100, 21)
        Me.Xrmatbox.TabIndex = 124
        '
        'Barosbox
        '
        Me.Barosbox.BackColor = System.Drawing.SystemColors.Info
        Me.Barosbox.FormattingEnabled = True
        Me.Barosbox.Items.AddRange(New Object() {"0    έως    55", "56    έως    65", "66    έως    75", "76    έως    85", "86    έως    95", ">=96"})
        Me.Barosbox.Location = New System.Drawing.Point(211, 112)
        Me.Barosbox.Name = "Barosbox"
        Me.Barosbox.Size = New System.Drawing.Size(100, 21)
        Me.Barosbox.TabIndex = 123
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(211, 53)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 115
        '
        'Hoby1TextBox
        '
        Me.Hoby1TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby1", True))
        Me.Hoby1TextBox.Location = New System.Drawing.Point(449, 49)
        Me.Hoby1TextBox.Name = "Hoby1TextBox"
        Me.Hoby1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby1TextBox.TabIndex = 116
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(449, 80)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 117
        '
        'Hoby3TextBox
        '
        Me.Hoby3TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Hoby3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby3", True))
        Me.Hoby3TextBox.Location = New System.Drawing.Point(449, 112)
        Me.Hoby3TextBox.Name = "Hoby3TextBox"
        Me.Hoby3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby3TextBox.TabIndex = 118
        '
        'GlwssaTextBox
        '
        Me.GlwssaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.GlwssaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa", True))
        Me.GlwssaTextBox.Location = New System.Drawing.Point(449, 180)
        Me.GlwssaTextBox.Name = "GlwssaTextBox"
        Me.GlwssaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GlwssaTextBox.TabIndex = 119
        '
        'Glwssa2TextBox
        '
        Me.Glwssa2TextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Glwssa2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa2", True))
        Me.Glwssa2TextBox.Location = New System.Drawing.Point(449, 213)
        Me.Glwssa2TextBox.Name = "Glwssa2TextBox"
        Me.Glwssa2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Glwssa2TextBox.TabIndex = 120
        '
        'ErgasiaTextBox
        '
        Me.ErgasiaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.ErgasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ergasia", True))
        Me.ErgasiaTextBox.Location = New System.Drawing.Point(449, 246)
        Me.ErgasiaTextBox.Name = "ErgasiaTextBox"
        Me.ErgasiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErgasiaTextBox.TabIndex = 121
        '
        'PerioxhTextBox
        '
        Me.PerioxhTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.PerioxhTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Perioxh", True))
        Me.PerioxhTextBox.Location = New System.Drawing.Point(449, 279)
        Me.PerioxhTextBox.Name = "PerioxhTextBox"
        Me.PerioxhTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerioxhTextBox.TabIndex = 122
        '
        'SrBt
        '
        Me.SrBt.BackgroundImage = CType(resources.GetObject("SrBt.BackgroundImage"), System.Drawing.Image)
        Me.SrBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SrBt.ForeColor = System.Drawing.SystemColors.Info
        Me.SrBt.Location = New System.Drawing.Point(502, 340)
        Me.SrBt.Name = "SrBt"
        Me.SrBt.Size = New System.Drawing.Size(85, 33)
        Me.SrBt.TabIndex = 114
        Me.SrBt.Text = "Search"
        Me.SrBt.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(402, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 33)
        Me.Button1.TabIndex = 152
        Me.Button1.Text = "Profile"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(614, 401)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label8)
        Me.Controls.Add(FyloLabel)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.YpsosEws)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ypsosApo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HmGenEws)
        Me.Controls.Add(Me.HmGenApo)
        Me.Controls.Add(Me.Xrmalbox)
        Me.Controls.Add(Me.Xrmatbox)
        Me.Controls.Add(Me.Barosbox)
        Me.Controls.Add(Me.OnomaTextBox)
        Me.Controls.Add(Me.Hoby1TextBox)
        Me.Controls.Add(Me.Hoby2TextBox)
        Me.Controls.Add(Me.Hoby3TextBox)
        Me.Controls.Add(Me.GlwssaTextBox)
        Me.Controls.Add(Me.Glwssa2TextBox)
        Me.Controls.Add(Me.ErgasiaTextBox)
        Me.Controls.Add(Me.PerioxhTextBox)
        Me.Controls.Add(Me.SrBt)
        Me.Name = "Search"
        Me.Text = "Search"
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeopleDataSet As WindowsApplication1.peopleDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents YesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WomanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ManRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FemaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents YpsosEws As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ypsosApo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HmGenEws As System.Windows.Forms.TextBox
    Friend WithEvents HmGenApo As System.Windows.Forms.TextBox
    Friend WithEvents Xrmalbox As System.Windows.Forms.ComboBox
    Friend WithEvents Xrmatbox As System.Windows.Forms.ComboBox
    Friend WithEvents Barosbox As System.Windows.Forms.ComboBox
    Friend WithEvents OnomaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GlwssaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Glwssa2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErgasiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerioxhTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SrBt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
