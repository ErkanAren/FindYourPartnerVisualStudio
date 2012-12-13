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
        Dim IDLabel As System.Windows.Forms.Label
        Dim OnomaLabel As System.Windows.Forms.Label
        Dim EpithetoLabel As System.Windows.Forms.Label
        Dim Hm_GennisisLabel As System.Windows.Forms.Label
        Dim BarosLabel As System.Windows.Forms.Label
        Dim YpsosLabel As System.Windows.Forms.Label
        Dim FyloLabel As System.Windows.Forms.Label
        Dim Xrwma_MatiwnLabel As System.Windows.Forms.Label
        Dim Xrwma_MalliwnLabel As System.Windows.Forms.Label
        Dim Hoby1Label As System.Windows.Forms.Label
        Dim Hoby2Label As System.Windows.Forms.Label
        Dim Hoby3Label As System.Windows.Forms.Label
        Dim AnazitaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim GlwssaLabel As System.Windows.Forms.Label
        Dim Glwssa2Label As System.Windows.Forms.Label
        Dim TatooLabel As System.Windows.Forms.Label
        Dim ErgasiaLabel As System.Windows.Forms.Label
        Dim PerioxhLabel As System.Windows.Forms.Label
        Me.RgButton = New System.Windows.Forms.Button
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
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
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.GlwssaTextBox = New System.Windows.Forms.TextBox
        Me.Glwssa2TextBox = New System.Windows.Forms.TextBox
        Me.TatooTextBox = New System.Windows.Forms.TextBox
        Me.ErgasiaTextBox = New System.Windows.Forms.TextBox
        Me.PerioxhTextBox = New System.Windows.Forms.TextBox
        IDLabel = New System.Windows.Forms.Label
        OnomaLabel = New System.Windows.Forms.Label
        EpithetoLabel = New System.Windows.Forms.Label
        Hm_GennisisLabel = New System.Windows.Forms.Label
        BarosLabel = New System.Windows.Forms.Label
        YpsosLabel = New System.Windows.Forms.Label
        FyloLabel = New System.Windows.Forms.Label
        Xrwma_MatiwnLabel = New System.Windows.Forms.Label
        Xrwma_MalliwnLabel = New System.Windows.Forms.Label
        Hoby1Label = New System.Windows.Forms.Label
        Hoby2Label = New System.Windows.Forms.Label
        Hoby3Label = New System.Windows.Forms.Label
        AnazitaLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        GlwssaLabel = New System.Windows.Forms.Label
        Glwssa2Label = New System.Windows.Forms.Label
        TatooLabel = New System.Windows.Forms.Label
        ErgasiaLabel = New System.Windows.Forms.Label
        PerioxhLabel = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(16, 42)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'OnomaLabel
        '
        OnomaLabel.AutoSize = True
        OnomaLabel.Location = New System.Drawing.Point(16, 68)
        OnomaLabel.Name = "OnomaLabel"
        OnomaLabel.Size = New System.Drawing.Size(44, 13)
        OnomaLabel.TabIndex = 4
        OnomaLabel.Text = "Onoma:"
        '
        'EpithetoLabel
        '
        EpithetoLabel.AutoSize = True
        EpithetoLabel.Location = New System.Drawing.Point(16, 94)
        EpithetoLabel.Name = "EpithetoLabel"
        EpithetoLabel.Size = New System.Drawing.Size(49, 13)
        EpithetoLabel.TabIndex = 6
        EpithetoLabel.Text = "Epitheto:"
        '
        'Hm_GennisisLabel
        '
        Hm_GennisisLabel.AutoSize = True
        Hm_GennisisLabel.Location = New System.Drawing.Point(16, 120)
        Hm_GennisisLabel.Name = "Hm_GennisisLabel"
        Hm_GennisisLabel.Size = New System.Drawing.Size(69, 13)
        Hm_GennisisLabel.TabIndex = 8
        Hm_GennisisLabel.Text = "Hm Gennisis:"
        '
        'BarosLabel
        '
        BarosLabel.AutoSize = True
        BarosLabel.Location = New System.Drawing.Point(16, 146)
        BarosLabel.Name = "BarosLabel"
        BarosLabel.Size = New System.Drawing.Size(37, 13)
        BarosLabel.TabIndex = 10
        BarosLabel.Text = "Baros:"
        '
        'YpsosLabel
        '
        YpsosLabel.AutoSize = True
        YpsosLabel.Location = New System.Drawing.Point(16, 172)
        YpsosLabel.Name = "YpsosLabel"
        YpsosLabel.Size = New System.Drawing.Size(39, 13)
        YpsosLabel.TabIndex = 12
        YpsosLabel.Text = "Ypsos:"
        '
        'FyloLabel
        '
        FyloLabel.AutoSize = True
        FyloLabel.Location = New System.Drawing.Point(16, 198)
        FyloLabel.Name = "FyloLabel"
        FyloLabel.Size = New System.Drawing.Size(29, 13)
        FyloLabel.TabIndex = 14
        FyloLabel.Text = "Fylo:"
        '
        'Xrwma_MatiwnLabel
        '
        Xrwma_MatiwnLabel.AutoSize = True
        Xrwma_MatiwnLabel.Location = New System.Drawing.Point(16, 224)
        Xrwma_MatiwnLabel.Name = "Xrwma_MatiwnLabel"
        Xrwma_MatiwnLabel.Size = New System.Drawing.Size(79, 13)
        Xrwma_MatiwnLabel.TabIndex = 16
        Xrwma_MatiwnLabel.Text = "Xrwma Matiwn:"
        '
        'Xrwma_MalliwnLabel
        '
        Xrwma_MalliwnLabel.AutoSize = True
        Xrwma_MalliwnLabel.Location = New System.Drawing.Point(16, 250)
        Xrwma_MalliwnLabel.Name = "Xrwma_MalliwnLabel"
        Xrwma_MalliwnLabel.Size = New System.Drawing.Size(80, 13)
        Xrwma_MalliwnLabel.TabIndex = 18
        Xrwma_MalliwnLabel.Text = "Xrwma Malliwn:"
        '
        'Hoby1Label
        '
        Hoby1Label.AutoSize = True
        Hoby1Label.Location = New System.Drawing.Point(222, 42)
        Hoby1Label.Name = "Hoby1Label"
        Hoby1Label.Size = New System.Drawing.Size(41, 13)
        Hoby1Label.TabIndex = 20
        Hoby1Label.Text = "Hoby1:"
        '
        'Hoby2Label
        '
        Hoby2Label.AutoSize = True
        Hoby2Label.Location = New System.Drawing.Point(222, 68)
        Hoby2Label.Name = "Hoby2Label"
        Hoby2Label.Size = New System.Drawing.Size(41, 13)
        Hoby2Label.TabIndex = 22
        Hoby2Label.Text = "Hoby2:"
        '
        'Hoby3Label
        '
        Hoby3Label.AutoSize = True
        Hoby3Label.Location = New System.Drawing.Point(222, 94)
        Hoby3Label.Name = "Hoby3Label"
        Hoby3Label.Size = New System.Drawing.Size(41, 13)
        Hoby3Label.TabIndex = 24
        Hoby3Label.Text = "Hoby3:"
        '
        'AnazitaLabel
        '
        AnazitaLabel.AutoSize = True
        AnazitaLabel.Location = New System.Drawing.Point(222, 120)
        AnazitaLabel.Name = "AnazitaLabel"
        AnazitaLabel.Size = New System.Drawing.Size(45, 13)
        AnazitaLabel.TabIndex = 26
        AnazitaLabel.Text = "Anazita:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(16, 275)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 28
        EmailLabel.Text = "email:"
        '
        'GlwssaLabel
        '
        GlwssaLabel.AutoSize = True
        GlwssaLabel.Location = New System.Drawing.Point(222, 147)
        GlwssaLabel.Name = "GlwssaLabel"
        GlwssaLabel.Size = New System.Drawing.Size(44, 13)
        GlwssaLabel.TabIndex = 30
        GlwssaLabel.Text = "Glwssa:"
        '
        'Glwssa2Label
        '
        Glwssa2Label.AutoSize = True
        Glwssa2Label.Location = New System.Drawing.Point(222, 173)
        Glwssa2Label.Name = "Glwssa2Label"
        Glwssa2Label.Size = New System.Drawing.Size(50, 13)
        Glwssa2Label.TabIndex = 32
        Glwssa2Label.Text = "Glwssa2:"
        '
        'TatooLabel
        '
        TatooLabel.AutoSize = True
        TatooLabel.Location = New System.Drawing.Point(222, 199)
        TatooLabel.Name = "TatooLabel"
        TatooLabel.Size = New System.Drawing.Size(38, 13)
        TatooLabel.TabIndex = 34
        TatooLabel.Text = "Tatoo:"
        '
        'ErgasiaLabel
        '
        ErgasiaLabel.AutoSize = True
        ErgasiaLabel.Location = New System.Drawing.Point(222, 225)
        ErgasiaLabel.Name = "ErgasiaLabel"
        ErgasiaLabel.Size = New System.Drawing.Size(45, 13)
        ErgasiaLabel.TabIndex = 36
        ErgasiaLabel.Text = "Ergasia:"
        '
        'PerioxhLabel
        '
        PerioxhLabel.AutoSize = True
        PerioxhLabel.Location = New System.Drawing.Point(222, 251)
        PerioxhLabel.Name = "PerioxhLabel"
        PerioxhLabel.Size = New System.Drawing.Size(45, 13)
        PerioxhLabel.TabIndex = 38
        PerioxhLabel.Text = "Perioxh:"
        '
        'RgButton
        '
        Me.RgButton.Location = New System.Drawing.Point(411, 314)
        Me.RgButton.Name = "RgButton"
        Me.RgButton.Size = New System.Drawing.Size(75, 23)
        Me.RgButton.TabIndex = 0
        Me.RgButton.Text = "Register"
        Me.RgButton.UseVisualStyleBackColor = True
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(102, 39)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(102, 65)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 5
        '
        'EpithetoTextBox
        '
        Me.EpithetoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Epitheto", True))
        Me.EpithetoTextBox.Location = New System.Drawing.Point(102, 91)
        Me.EpithetoTextBox.Name = "EpithetoTextBox"
        Me.EpithetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EpithetoTextBox.TabIndex = 7
        '
        'Hm_GennisisTextBox
        '
        Me.Hm_GennisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hm_Gennisis", True))
        Me.Hm_GennisisTextBox.Location = New System.Drawing.Point(102, 117)
        Me.Hm_GennisisTextBox.Name = "Hm_GennisisTextBox"
        Me.Hm_GennisisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hm_GennisisTextBox.TabIndex = 9
        '
        'BarosTextBox
        '
        Me.BarosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Baros", True))
        Me.BarosTextBox.Location = New System.Drawing.Point(102, 143)
        Me.BarosTextBox.Name = "BarosTextBox"
        Me.BarosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarosTextBox.TabIndex = 11
        '
        'YpsosTextBox
        '
        Me.YpsosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ypsos", True))
        Me.YpsosTextBox.Location = New System.Drawing.Point(102, 169)
        Me.YpsosTextBox.Name = "YpsosTextBox"
        Me.YpsosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YpsosTextBox.TabIndex = 13
        '
        'FyloTextBox
        '
        Me.FyloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Fylo", True))
        Me.FyloTextBox.Location = New System.Drawing.Point(102, 195)
        Me.FyloTextBox.Name = "FyloTextBox"
        Me.FyloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FyloTextBox.TabIndex = 15
        '
        'Xrwma_MatiwnTextBox
        '
        Me.Xrwma_MatiwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Matiwn", True))
        Me.Xrwma_MatiwnTextBox.Location = New System.Drawing.Point(102, 221)
        Me.Xrwma_MatiwnTextBox.Name = "Xrwma_MatiwnTextBox"
        Me.Xrwma_MatiwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MatiwnTextBox.TabIndex = 17
        '
        'Xrwma_MalliwnTextBox
        '
        Me.Xrwma_MalliwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Malliwn", True))
        Me.Xrwma_MalliwnTextBox.Location = New System.Drawing.Point(102, 247)
        Me.Xrwma_MalliwnTextBox.Name = "Xrwma_MalliwnTextBox"
        Me.Xrwma_MalliwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MalliwnTextBox.TabIndex = 19
        '
        'Hoby1TextBox
        '
        Me.Hoby1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby1", True))
        Me.Hoby1TextBox.Location = New System.Drawing.Point(308, 39)
        Me.Hoby1TextBox.Name = "Hoby1TextBox"
        Me.Hoby1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby1TextBox.TabIndex = 21
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(308, 65)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 23
        '
        'Hoby3TextBox
        '
        Me.Hoby3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby3", True))
        Me.Hoby3TextBox.Location = New System.Drawing.Point(308, 91)
        Me.Hoby3TextBox.Name = "Hoby3TextBox"
        Me.Hoby3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby3TextBox.TabIndex = 25
        '
        'AnazitaTextBox
        '
        Me.AnazitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Anazita", True))
        Me.AnazitaTextBox.Location = New System.Drawing.Point(308, 117)
        Me.AnazitaTextBox.Name = "AnazitaTextBox"
        Me.AnazitaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnazitaTextBox.TabIndex = 27
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(102, 272)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 29
        '
        'GlwssaTextBox
        '
        Me.GlwssaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa", True))
        Me.GlwssaTextBox.Location = New System.Drawing.Point(308, 144)
        Me.GlwssaTextBox.Name = "GlwssaTextBox"
        Me.GlwssaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GlwssaTextBox.TabIndex = 31
        '
        'Glwssa2TextBox
        '
        Me.Glwssa2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa2", True))
        Me.Glwssa2TextBox.Location = New System.Drawing.Point(308, 170)
        Me.Glwssa2TextBox.Name = "Glwssa2TextBox"
        Me.Glwssa2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Glwssa2TextBox.TabIndex = 33
        '
        'TatooTextBox
        '
        Me.TatooTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Tatoo", True))
        Me.TatooTextBox.Location = New System.Drawing.Point(308, 196)
        Me.TatooTextBox.Name = "TatooTextBox"
        Me.TatooTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TatooTextBox.TabIndex = 35
        '
        'ErgasiaTextBox
        '
        Me.ErgasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ergasia", True))
        Me.ErgasiaTextBox.Location = New System.Drawing.Point(308, 222)
        Me.ErgasiaTextBox.Name = "ErgasiaTextBox"
        Me.ErgasiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErgasiaTextBox.TabIndex = 37
        '
        'PerioxhTextBox
        '
        Me.PerioxhTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Perioxh", True))
        Me.PerioxhTextBox.Location = New System.Drawing.Point(308, 248)
        Me.PerioxhTextBox.Name = "PerioxhTextBox"
        Me.PerioxhTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerioxhTextBox.TabIndex = 39
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(OnomaLabel)
        Me.Controls.Add(Me.OnomaTextBox)
        Me.Controls.Add(EpithetoLabel)
        Me.Controls.Add(Me.EpithetoTextBox)
        Me.Controls.Add(Hm_GennisisLabel)
        Me.Controls.Add(Me.Hm_GennisisTextBox)
        Me.Controls.Add(BarosLabel)
        Me.Controls.Add(Me.BarosTextBox)
        Me.Controls.Add(YpsosLabel)
        Me.Controls.Add(Me.YpsosTextBox)
        Me.Controls.Add(FyloLabel)
        Me.Controls.Add(Me.FyloTextBox)
        Me.Controls.Add(Xrwma_MatiwnLabel)
        Me.Controls.Add(Me.Xrwma_MatiwnTextBox)
        Me.Controls.Add(Xrwma_MalliwnLabel)
        Me.Controls.Add(Me.Xrwma_MalliwnTextBox)
        Me.Controls.Add(Hoby1Label)
        Me.Controls.Add(Me.Hoby1TextBox)
        Me.Controls.Add(Hoby2Label)
        Me.Controls.Add(Me.Hoby2TextBox)
        Me.Controls.Add(Hoby3Label)
        Me.Controls.Add(Me.Hoby3TextBox)
        Me.Controls.Add(AnazitaLabel)
        Me.Controls.Add(Me.AnazitaTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(GlwssaLabel)
        Me.Controls.Add(Me.GlwssaTextBox)
        Me.Controls.Add(Glwssa2Label)
        Me.Controls.Add(Me.Glwssa2TextBox)
        Me.Controls.Add(TatooLabel)
        Me.Controls.Add(Me.TatooTextBox)
        Me.Controls.Add(ErgasiaLabel)
        Me.Controls.Add(Me.ErgasiaTextBox)
        Me.Controls.Add(PerioxhLabel)
        Me.Controls.Add(Me.PerioxhTextBox)
        Me.Controls.Add(Me.RgButton)
        Me.Name = "RegisterForm"
        Me.Text = "Register"
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RgButton As System.Windows.Forms.Button
    Friend WithEvents PeopleDataSet As WindowsApplication1.peopleDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GlwssaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Glwssa2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TatooTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErgasiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerioxhTextBox As System.Windows.Forms.TextBox
End Class
