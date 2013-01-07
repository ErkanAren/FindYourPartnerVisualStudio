<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Dim Hoby1Label As System.Windows.Forms.Label
        Dim Hoby2Label As System.Windows.Forms.Label
        Dim Hoby3Label As System.Windows.Forms.Label
        Dim AnazitaLabel As System.Windows.Forms.Label
        Dim GlwssaLabel As System.Windows.Forms.Label
        Dim Glwssa2Label As System.Windows.Forms.Label
        Dim TatooLabel As System.Windows.Forms.Label
        Dim ErgasiaLabel As System.Windows.Forms.Label
        Dim PerioxhLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
        Me.EditBt = New System.Windows.Forms.Button
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
        Hoby1Label = New System.Windows.Forms.Label
        Hoby2Label = New System.Windows.Forms.Label
        Hoby3Label = New System.Windows.Forms.Label
        AnazitaLabel = New System.Windows.Forms.Label
        GlwssaLabel = New System.Windows.Forms.Label
        Glwssa2Label = New System.Windows.Forms.Label
        TatooLabel = New System.Windows.Forms.Label
        ErgasiaLabel = New System.Windows.Forms.Label
        PerioxhLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Hoby1Label
        '
        Hoby1Label.AutoSize = True
        Hoby1Label.Location = New System.Drawing.Point(286, 37)
        Hoby1Label.Name = "Hoby1Label"
        Hoby1Label.Size = New System.Drawing.Size(59, 13)
        Hoby1Label.TabIndex = 89
        Hoby1Label.Text = "Hobby - 1 :"
        '
        'Hoby2Label
        '
        Hoby2Label.AutoSize = True
        Hoby2Label.Location = New System.Drawing.Point(286, 63)
        Hoby2Label.Name = "Hoby2Label"
        Hoby2Label.Size = New System.Drawing.Size(59, 13)
        Hoby2Label.TabIndex = 90
        Hoby2Label.Text = "Hobby - 2 :"
        '
        'Hoby3Label
        '
        Hoby3Label.AutoSize = True
        Hoby3Label.Location = New System.Drawing.Point(286, 90)
        Hoby3Label.Name = "Hoby3Label"
        Hoby3Label.Size = New System.Drawing.Size(59, 13)
        Hoby3Label.TabIndex = 91
        Hoby3Label.Text = "Hobby - 3 :"
        '
        'AnazitaLabel
        '
        AnazitaLabel.AutoSize = True
        AnazitaLabel.Location = New System.Drawing.Point(287, 116)
        AnazitaLabel.Name = "AnazitaLabel"
        AnazitaLabel.Size = New System.Drawing.Size(57, 13)
        AnazitaLabel.TabIndex = 92
        AnazitaLabel.Text = "Αναζήτα :"
        '
        'GlwssaLabel
        '
        GlwssaLabel.AutoSize = True
        GlwssaLabel.Location = New System.Drawing.Point(289, 142)
        GlwssaLabel.Name = "GlwssaLabel"
        GlwssaLabel.Size = New System.Drawing.Size(56, 13)
        GlwssaLabel.TabIndex = 93
        GlwssaLabel.Text = "Γλωσσά : "
        '
        'Glwssa2Label
        '
        Glwssa2Label.AutoSize = True
        Glwssa2Label.Location = New System.Drawing.Point(274, 168)
        Glwssa2Label.Name = "Glwssa2Label"
        Glwssa2Label.Size = New System.Drawing.Size(68, 13)
        Glwssa2Label.TabIndex = 94
        Glwssa2Label.Text = "Γλωσσά - 2 :"
        '
        'TatooLabel
        '
        TatooLabel.AutoSize = True
        TatooLabel.Location = New System.Drawing.Point(301, 194)
        TatooLabel.Name = "TatooLabel"
        TatooLabel.Size = New System.Drawing.Size(41, 13)
        TatooLabel.TabIndex = 95
        TatooLabel.Text = "Tatoo :"
        '
        'ErgasiaLabel
        '
        ErgasiaLabel.AutoSize = True
        ErgasiaLabel.Location = New System.Drawing.Point(287, 219)
        ErgasiaLabel.Name = "ErgasiaLabel"
        ErgasiaLabel.Size = New System.Drawing.Size(55, 13)
        ErgasiaLabel.TabIndex = 96
        ErgasiaLabel.Text = "Εργασία :"
        '
        'PerioxhLabel
        '
        PerioxhLabel.AutoSize = True
        PerioxhLabel.Location = New System.Drawing.Point(289, 245)
        PerioxhLabel.Name = "PerioxhLabel"
        PerioxhLabel.Size = New System.Drawing.Size(53, 13)
        PerioxhLabel.TabIndex = 97
        PerioxhLabel.Text = "Περιοχή :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(92, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(24, 13)
        Label1.TabIndex = 79
        Label1.Text = "ID :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(69, 59)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 80
        Label2.Text = "Όνομα :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(62, 82)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 81
        Label3.Text = "Επίθετο  :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(35, 111)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 13)
        Label4.TabIndex = 82
        Label4.Text = "Ημ. γέννησης :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(72, 141)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 13)
        Label5.TabIndex = 83
        Label5.Text = "Βάρος :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(74, 163)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(42, 13)
        Label6.TabIndex = 84
        Label6.Text = "Ύψος :"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(76, 189)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(40, 13)
        Label7.TabIndex = 85
        Label7.Text = "Φύλο :"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(45, 215)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(76, 13)
        Label8.TabIndex = 86
        Label8.Text = "Χρ. Ματιών :  "
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(40, 241)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(74, 13)
        Label9.TabIndex = 87
        Label9.Text = "Χρ. Μαλλιών :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(73, 267)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(41, 13)
        Label10.TabIndex = 88
        Label10.Text = "E-mail :"
        '
        'EditBt
        '
        Me.EditBt.Location = New System.Drawing.Point(424, 309)
        Me.EditBt.Name = "EditBt"
        Me.EditBt.Size = New System.Drawing.Size(75, 23)
        Me.EditBt.TabIndex = 78
        Me.EditBt.Text = "Edit"
        Me.EditBt.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(119, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 59
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(119, 57)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 60
        '
        'EpithetoTextBox
        '
        Me.EpithetoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Epitheto", True))
        Me.EpithetoTextBox.Location = New System.Drawing.Point(119, 83)
        Me.EpithetoTextBox.Name = "EpithetoTextBox"
        Me.EpithetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EpithetoTextBox.TabIndex = 61
        '
        'Hm_GennisisTextBox
        '
        Me.Hm_GennisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hm_Gennisis", True))
        Me.Hm_GennisisTextBox.Location = New System.Drawing.Point(119, 109)
        Me.Hm_GennisisTextBox.Name = "Hm_GennisisTextBox"
        Me.Hm_GennisisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hm_GennisisTextBox.TabIndex = 62
        '
        'BarosTextBox
        '
        Me.BarosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Baros", True))
        Me.BarosTextBox.Location = New System.Drawing.Point(119, 135)
        Me.BarosTextBox.Name = "BarosTextBox"
        Me.BarosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarosTextBox.TabIndex = 63
        '
        'YpsosTextBox
        '
        Me.YpsosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ypsos", True))
        Me.YpsosTextBox.Location = New System.Drawing.Point(119, 161)
        Me.YpsosTextBox.Name = "YpsosTextBox"
        Me.YpsosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YpsosTextBox.TabIndex = 64
        '
        'FyloTextBox
        '
        Me.FyloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Fylo", True))
        Me.FyloTextBox.Location = New System.Drawing.Point(119, 187)
        Me.FyloTextBox.Name = "FyloTextBox"
        Me.FyloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FyloTextBox.TabIndex = 65
        '
        'Xrwma_MatiwnTextBox
        '
        Me.Xrwma_MatiwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Matiwn", True))
        Me.Xrwma_MatiwnTextBox.Location = New System.Drawing.Point(119, 213)
        Me.Xrwma_MatiwnTextBox.Name = "Xrwma_MatiwnTextBox"
        Me.Xrwma_MatiwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MatiwnTextBox.TabIndex = 66
        '
        'Xrwma_MalliwnTextBox
        '
        Me.Xrwma_MalliwnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Xrwma_Malliwn", True))
        Me.Xrwma_MalliwnTextBox.Location = New System.Drawing.Point(119, 239)
        Me.Xrwma_MalliwnTextBox.Name = "Xrwma_MalliwnTextBox"
        Me.Xrwma_MalliwnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Xrwma_MalliwnTextBox.TabIndex = 67
        '
        'Hoby1TextBox
        '
        Me.Hoby1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby1", True))
        Me.Hoby1TextBox.Location = New System.Drawing.Point(351, 34)
        Me.Hoby1TextBox.Name = "Hoby1TextBox"
        Me.Hoby1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby1TextBox.TabIndex = 68
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(351, 60)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 69
        '
        'Hoby3TextBox
        '
        Me.Hoby3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby3", True))
        Me.Hoby3TextBox.Location = New System.Drawing.Point(351, 86)
        Me.Hoby3TextBox.Name = "Hoby3TextBox"
        Me.Hoby3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby3TextBox.TabIndex = 70
        '
        'AnazitaTextBox
        '
        Me.AnazitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Anazita", True))
        Me.AnazitaTextBox.Location = New System.Drawing.Point(351, 112)
        Me.AnazitaTextBox.Name = "AnazitaTextBox"
        Me.AnazitaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnazitaTextBox.TabIndex = 71
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(119, 265)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 72
        '
        'GlwssaTextBox
        '
        Me.GlwssaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa", True))
        Me.GlwssaTextBox.Location = New System.Drawing.Point(351, 139)
        Me.GlwssaTextBox.Name = "GlwssaTextBox"
        Me.GlwssaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GlwssaTextBox.TabIndex = 73
        '
        'Glwssa2TextBox
        '
        Me.Glwssa2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa2", True))
        Me.Glwssa2TextBox.Location = New System.Drawing.Point(351, 165)
        Me.Glwssa2TextBox.Name = "Glwssa2TextBox"
        Me.Glwssa2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Glwssa2TextBox.TabIndex = 74
        '
        'TatooTextBox
        '
        Me.TatooTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Tatoo", True))
        Me.TatooTextBox.Location = New System.Drawing.Point(351, 191)
        Me.TatooTextBox.Name = "TatooTextBox"
        Me.TatooTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TatooTextBox.TabIndex = 75
        '
        'ErgasiaTextBox
        '
        Me.ErgasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ergasia", True))
        Me.ErgasiaTextBox.Location = New System.Drawing.Point(351, 217)
        Me.ErgasiaTextBox.Name = "ErgasiaTextBox"
        Me.ErgasiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErgasiaTextBox.TabIndex = 76
        '
        'PerioxhTextBox
        '
        Me.PerioxhTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Perioxh", True))
        Me.PerioxhTextBox.Location = New System.Drawing.Point(351, 243)
        Me.PerioxhTextBox.Name = "PerioxhTextBox"
        Me.PerioxhTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerioxhTextBox.TabIndex = 77
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(Hoby1Label)
        Me.Controls.Add(Hoby2Label)
        Me.Controls.Add(Hoby3Label)
        Me.Controls.Add(AnazitaLabel)
        Me.Controls.Add(GlwssaLabel)
        Me.Controls.Add(Glwssa2Label)
        Me.Controls.Add(TatooLabel)
        Me.Controls.Add(ErgasiaLabel)
        Me.Controls.Add(PerioxhLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.EditBt)
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
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.GlwssaTextBox)
        Me.Controls.Add(Me.Glwssa2TextBox)
        Me.Controls.Add(Me.TatooTextBox)
        Me.Controls.Add(Me.ErgasiaTextBox)
        Me.Controls.Add(Me.PerioxhTextBox)
        Me.Name = "Edit"
        Me.Text = "Edit"
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeopleDataSet As WindowsApplication1.peopleDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EditBt As System.Windows.Forms.Button
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
