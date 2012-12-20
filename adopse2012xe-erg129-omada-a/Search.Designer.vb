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
        Dim OnomaLabel As System.Windows.Forms.Label
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
        Dim GlwssaLabel As System.Windows.Forms.Label
        Dim Glwssa2Label As System.Windows.Forms.Label
        Dim TatooLabel As System.Windows.Forms.Label
        Dim ErgasiaLabel As System.Windows.Forms.Label
        Dim PerioxhLabel As System.Windows.Forms.Label
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
        Me.SrBt = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MaleCheck = New System.Windows.Forms.CheckBox
        Me.FemaleCheck = New System.Windows.Forms.CheckBox
        Me.TatooCheck = New System.Windows.Forms.CheckBox
        Me.WomanCheck = New System.Windows.Forms.CheckBox
        Me.ManCheck = New System.Windows.Forms.CheckBox
        Me.Xrmalbox = New System.Windows.Forms.ComboBox
        Me.Xrmatbox = New System.Windows.Forms.ComboBox
        Me.Ypsosbox = New System.Windows.Forms.ComboBox
        Me.Barosbox = New System.Windows.Forms.ComboBox
        Me.Hmbox = New System.Windows.Forms.ComboBox
        Me.OnomaTextBox = New System.Windows.Forms.TextBox
        Me.Hoby1TextBox = New System.Windows.Forms.TextBox
        Me.Hoby2TextBox = New System.Windows.Forms.TextBox
        Me.Hoby3TextBox = New System.Windows.Forms.TextBox
        Me.GlwssaTextBox = New System.Windows.Forms.TextBox
        Me.Glwssa2TextBox = New System.Windows.Forms.TextBox
        Me.ErgasiaTextBox = New System.Windows.Forms.TextBox
        Me.PerioxhTextBox = New System.Windows.Forms.TextBox
        OnomaLabel = New System.Windows.Forms.Label
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
        GlwssaLabel = New System.Windows.Forms.Label
        Glwssa2Label = New System.Windows.Forms.Label
        TatooLabel = New System.Windows.Forms.Label
        ErgasiaLabel = New System.Windows.Forms.Label
        PerioxhLabel = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnomaLabel
        '
        OnomaLabel.AutoSize = True
        OnomaLabel.Location = New System.Drawing.Point(39, 40)
        OnomaLabel.Name = "OnomaLabel"
        OnomaLabel.Size = New System.Drawing.Size(44, 13)
        OnomaLabel.TabIndex = 51
        OnomaLabel.Text = "Onoma:"
        '
        'Hm_GennisisLabel
        '
        Hm_GennisisLabel.AutoSize = True
        Hm_GennisisLabel.Location = New System.Drawing.Point(39, 72)
        Hm_GennisisLabel.Name = "Hm_GennisisLabel"
        Hm_GennisisLabel.Size = New System.Drawing.Size(69, 13)
        Hm_GennisisLabel.TabIndex = 53
        Hm_GennisisLabel.Text = "Hm Gennisis:"
        '
        'BarosLabel
        '
        BarosLabel.AutoSize = True
        BarosLabel.Location = New System.Drawing.Point(39, 98)
        BarosLabel.Name = "BarosLabel"
        BarosLabel.Size = New System.Drawing.Size(37, 13)
        BarosLabel.TabIndex = 54
        BarosLabel.Text = "Baros:"
        '
        'YpsosLabel
        '
        YpsosLabel.AutoSize = True
        YpsosLabel.Location = New System.Drawing.Point(39, 124)
        YpsosLabel.Name = "YpsosLabel"
        YpsosLabel.Size = New System.Drawing.Size(39, 13)
        YpsosLabel.TabIndex = 55
        YpsosLabel.Text = "Ypsos:"
        '
        'FyloLabel
        '
        FyloLabel.AutoSize = True
        FyloLabel.Location = New System.Drawing.Point(39, 155)
        FyloLabel.Name = "FyloLabel"
        FyloLabel.Size = New System.Drawing.Size(29, 13)
        FyloLabel.TabIndex = 56
        FyloLabel.Text = "Fylo:"
        '
        'Xrwma_MatiwnLabel
        '
        Xrwma_MatiwnLabel.AutoSize = True
        Xrwma_MatiwnLabel.Location = New System.Drawing.Point(39, 187)
        Xrwma_MatiwnLabel.Name = "Xrwma_MatiwnLabel"
        Xrwma_MatiwnLabel.Size = New System.Drawing.Size(79, 13)
        Xrwma_MatiwnLabel.TabIndex = 57
        Xrwma_MatiwnLabel.Text = "Xrwma Matiwn:"
        '
        'Xrwma_MalliwnLabel
        '
        Xrwma_MalliwnLabel.AutoSize = True
        Xrwma_MalliwnLabel.Location = New System.Drawing.Point(39, 218)
        Xrwma_MalliwnLabel.Name = "Xrwma_MalliwnLabel"
        Xrwma_MalliwnLabel.Size = New System.Drawing.Size(80, 13)
        Xrwma_MalliwnLabel.TabIndex = 58
        Xrwma_MalliwnLabel.Text = "Xrwma Malliwn:"
        '
        'Hoby1Label
        '
        Hoby1Label.AutoSize = True
        Hoby1Label.Location = New System.Drawing.Point(260, 37)
        Hoby1Label.Name = "Hoby1Label"
        Hoby1Label.Size = New System.Drawing.Size(41, 13)
        Hoby1Label.TabIndex = 59
        Hoby1Label.Text = "Hoby1:"
        '
        'Hoby2Label
        '
        Hoby2Label.AutoSize = True
        Hoby2Label.Location = New System.Drawing.Point(260, 63)
        Hoby2Label.Name = "Hoby2Label"
        Hoby2Label.Size = New System.Drawing.Size(41, 13)
        Hoby2Label.TabIndex = 61
        Hoby2Label.Text = "Hoby2:"
        '
        'Hoby3Label
        '
        Hoby3Label.AutoSize = True
        Hoby3Label.Location = New System.Drawing.Point(260, 89)
        Hoby3Label.Name = "Hoby3Label"
        Hoby3Label.Size = New System.Drawing.Size(41, 13)
        Hoby3Label.TabIndex = 63
        Hoby3Label.Text = "Hoby3:"
        '
        'AnazitaLabel
        '
        AnazitaLabel.AutoSize = True
        AnazitaLabel.Location = New System.Drawing.Point(260, 115)
        AnazitaLabel.Name = "AnazitaLabel"
        AnazitaLabel.Size = New System.Drawing.Size(45, 13)
        AnazitaLabel.TabIndex = 65
        AnazitaLabel.Text = "Anazita:"
        '
        'GlwssaLabel
        '
        GlwssaLabel.AutoSize = True
        GlwssaLabel.Location = New System.Drawing.Point(260, 141)
        GlwssaLabel.Name = "GlwssaLabel"
        GlwssaLabel.Size = New System.Drawing.Size(44, 13)
        GlwssaLabel.TabIndex = 66
        GlwssaLabel.Text = "Glwssa:"
        '
        'Glwssa2Label
        '
        Glwssa2Label.AutoSize = True
        Glwssa2Label.Location = New System.Drawing.Point(260, 167)
        Glwssa2Label.Name = "Glwssa2Label"
        Glwssa2Label.Size = New System.Drawing.Size(50, 13)
        Glwssa2Label.TabIndex = 68
        Glwssa2Label.Text = "Glwssa2:"
        '
        'TatooLabel
        '
        TatooLabel.AutoSize = True
        TatooLabel.Location = New System.Drawing.Point(260, 193)
        TatooLabel.Name = "TatooLabel"
        TatooLabel.Size = New System.Drawing.Size(38, 13)
        TatooLabel.TabIndex = 70
        TatooLabel.Text = "Tatoo:"
        '
        'ErgasiaLabel
        '
        ErgasiaLabel.AutoSize = True
        ErgasiaLabel.Location = New System.Drawing.Point(260, 219)
        ErgasiaLabel.Name = "ErgasiaLabel"
        ErgasiaLabel.Size = New System.Drawing.Size(45, 13)
        ErgasiaLabel.TabIndex = 71
        ErgasiaLabel.Text = "Ergasia:"
        '
        'PerioxhLabel
        '
        PerioxhLabel.AutoSize = True
        PerioxhLabel.Location = New System.Drawing.Point(260, 245)
        PerioxhLabel.Name = "PerioxhLabel"
        PerioxhLabel.Size = New System.Drawing.Size(45, 13)
        PerioxhLabel.TabIndex = 73
        PerioxhLabel.Text = "Perioxh:"
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
        'SrBt
        '
        Me.SrBt.Location = New System.Drawing.Point(404, 316)
        Me.SrBt.Name = "SrBt"
        Me.SrBt.Size = New System.Drawing.Size(75, 23)
        Me.SrBt.TabIndex = 39
        Me.SrBt.Text = "Search"
        Me.SrBt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaleCheck)
        Me.GroupBox1.Controls.Add(Me.FemaleCheck)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 34)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'MaleCheck
        '
        Me.MaleCheck.AutoSize = True
        Me.MaleCheck.Location = New System.Drawing.Point(6, 19)
        Me.MaleCheck.Name = "MaleCheck"
        Me.MaleCheck.Size = New System.Drawing.Size(55, 17)
        Me.MaleCheck.TabIndex = 43
        Me.MaleCheck.Text = "MALE"
        Me.MaleCheck.UseVisualStyleBackColor = True
        '
        'FemaleCheck
        '
        Me.FemaleCheck.AutoSize = True
        Me.FemaleCheck.Location = New System.Drawing.Point(67, 19)
        Me.FemaleCheck.Name = "FemaleCheck"
        Me.FemaleCheck.Size = New System.Drawing.Size(68, 17)
        Me.FemaleCheck.TabIndex = 44
        Me.FemaleCheck.Text = "FEMALE"
        Me.FemaleCheck.UseVisualStyleBackColor = True
        '
        'TatooCheck
        '
        Me.TatooCheck.AutoSize = True
        Me.TatooCheck.Location = New System.Drawing.Point(387, 193)
        Me.TatooCheck.Name = "TatooCheck"
        Me.TatooCheck.Size = New System.Drawing.Size(15, 14)
        Me.TatooCheck.TabIndex = 82
        Me.TatooCheck.UseVisualStyleBackColor = True
        '
        'WomanCheck
        '
        Me.WomanCheck.AutoSize = True
        Me.WomanCheck.Location = New System.Drawing.Point(402, 115)
        Me.WomanCheck.Name = "WomanCheck"
        Me.WomanCheck.Size = New System.Drawing.Size(69, 17)
        Me.WomanCheck.TabIndex = 81
        Me.WomanCheck.Text = "WOMAN"
        Me.WomanCheck.UseVisualStyleBackColor = True
        '
        'ManCheck
        '
        Me.ManCheck.AutoSize = True
        Me.ManCheck.Location = New System.Drawing.Point(346, 115)
        Me.ManCheck.Name = "ManCheck"
        Me.ManCheck.Size = New System.Drawing.Size(50, 17)
        Me.ManCheck.TabIndex = 80
        Me.ManCheck.Text = "MAN"
        Me.ManCheck.UseVisualStyleBackColor = True
        '
        'Xrmalbox
        '
        Me.Xrmalbox.FormattingEnabled = True
        Me.Xrmalbox.Items.AddRange(New Object() {"BLONDE", "BROWN", "BLACK"})
        Me.Xrmalbox.Location = New System.Drawing.Point(125, 216)
        Me.Xrmalbox.Name = "Xrmalbox"
        Me.Xrmalbox.Size = New System.Drawing.Size(100, 21)
        Me.Xrmalbox.TabIndex = 79
        '
        'Xrmatbox
        '
        Me.Xrmatbox.FormattingEnabled = True
        Me.Xrmatbox.Items.AddRange(New Object() {"BLUE", "BROWN", "BLACK", "GREEN"})
        Me.Xrmatbox.Location = New System.Drawing.Point(125, 184)
        Me.Xrmatbox.Name = "Xrmatbox"
        Me.Xrmatbox.Size = New System.Drawing.Size(100, 21)
        Me.Xrmatbox.TabIndex = 78
        '
        'Ypsosbox
        '
        Me.Ypsosbox.FormattingEnabled = True
        Me.Ypsosbox.Items.AddRange(New Object() {"150   έως   155", "160   έως   165", "170   έως   175", "180   έως   185", "190   έως   195", "200   έως   210", " "})
        Me.Ypsosbox.Location = New System.Drawing.Point(125, 123)
        Me.Ypsosbox.Name = "Ypsosbox"
        Me.Ypsosbox.Size = New System.Drawing.Size(100, 21)
        Me.Ypsosbox.TabIndex = 77
        '
        'Barosbox
        '
        Me.Barosbox.FormattingEnabled = True
        Me.Barosbox.Items.AddRange(New Object() {"0    έως    55", "60    έως    65", "70    έως    75", "80    έως    85", "90    έως    95", "100  έως    105"})
        Me.Barosbox.Location = New System.Drawing.Point(125, 96)
        Me.Barosbox.Name = "Barosbox"
        Me.Barosbox.Size = New System.Drawing.Size(100, 21)
        Me.Barosbox.TabIndex = 76
        '
        'Hmbox
        '
        Me.Hmbox.FormattingEnabled = True
        Me.Hmbox.Items.AddRange(New Object() {"1940  έως   1945", "1950  έως   1955", "1960  έως   1965", "1970  έως   1975", "1980  έως   1985", "1990  έως   1995"})
        Me.Hmbox.Location = New System.Drawing.Point(125, 67)
        Me.Hmbox.Name = "Hmbox"
        Me.Hmbox.Size = New System.Drawing.Size(100, 21)
        Me.Hmbox.TabIndex = 75
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(125, 37)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 52
        '
        'Hoby1TextBox
        '
        Me.Hoby1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby1", True))
        Me.Hoby1TextBox.Location = New System.Drawing.Point(346, 34)
        Me.Hoby1TextBox.Name = "Hoby1TextBox"
        Me.Hoby1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby1TextBox.TabIndex = 60
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(346, 60)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 62
        '
        'Hoby3TextBox
        '
        Me.Hoby3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby3", True))
        Me.Hoby3TextBox.Location = New System.Drawing.Point(346, 86)
        Me.Hoby3TextBox.Name = "Hoby3TextBox"
        Me.Hoby3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby3TextBox.TabIndex = 64
        '
        'GlwssaTextBox
        '
        Me.GlwssaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa", True))
        Me.GlwssaTextBox.Location = New System.Drawing.Point(346, 138)
        Me.GlwssaTextBox.Name = "GlwssaTextBox"
        Me.GlwssaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GlwssaTextBox.TabIndex = 67
        '
        'Glwssa2TextBox
        '
        Me.Glwssa2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Glwssa2", True))
        Me.Glwssa2TextBox.Location = New System.Drawing.Point(346, 164)
        Me.Glwssa2TextBox.Name = "Glwssa2TextBox"
        Me.Glwssa2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Glwssa2TextBox.TabIndex = 69
        '
        'ErgasiaTextBox
        '
        Me.ErgasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Ergasia", True))
        Me.ErgasiaTextBox.Location = New System.Drawing.Point(346, 216)
        Me.ErgasiaTextBox.Name = "ErgasiaTextBox"
        Me.ErgasiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErgasiaTextBox.TabIndex = 72
        '
        'PerioxhTextBox
        '
        Me.PerioxhTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Perioxh", True))
        Me.PerioxhTextBox.Location = New System.Drawing.Point(346, 242)
        Me.PerioxhTextBox.Name = "PerioxhTextBox"
        Me.PerioxhTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerioxhTextBox.TabIndex = 74
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TatooCheck)
        Me.Controls.Add(Me.WomanCheck)
        Me.Controls.Add(Me.ManCheck)
        Me.Controls.Add(Me.Xrmalbox)
        Me.Controls.Add(Me.Xrmatbox)
        Me.Controls.Add(Me.Ypsosbox)
        Me.Controls.Add(Me.Barosbox)
        Me.Controls.Add(Me.Hmbox)
        Me.Controls.Add(OnomaLabel)
        Me.Controls.Add(Me.OnomaTextBox)
        Me.Controls.Add(Hm_GennisisLabel)
        Me.Controls.Add(BarosLabel)
        Me.Controls.Add(YpsosLabel)
        Me.Controls.Add(FyloLabel)
        Me.Controls.Add(Xrwma_MatiwnLabel)
        Me.Controls.Add(Xrwma_MalliwnLabel)
        Me.Controls.Add(Hoby1Label)
        Me.Controls.Add(Me.Hoby1TextBox)
        Me.Controls.Add(Hoby2Label)
        Me.Controls.Add(Me.Hoby2TextBox)
        Me.Controls.Add(Hoby3Label)
        Me.Controls.Add(Me.Hoby3TextBox)
        Me.Controls.Add(AnazitaLabel)
        Me.Controls.Add(GlwssaLabel)
        Me.Controls.Add(Me.GlwssaTextBox)
        Me.Controls.Add(Glwssa2Label)
        Me.Controls.Add(Me.Glwssa2TextBox)
        Me.Controls.Add(TatooLabel)
        Me.Controls.Add(ErgasiaLabel)
        Me.Controls.Add(Me.ErgasiaTextBox)
        Me.Controls.Add(PerioxhLabel)
        Me.Controls.Add(Me.PerioxhTextBox)
        Me.Controls.Add(Me.SrBt)
        Me.Name = "Search"
        Me.Text = "Search"
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeopleDataSet As WindowsApplication1.peopleDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SrBt As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MaleCheck As System.Windows.Forms.CheckBox
    Friend WithEvents FemaleCheck As System.Windows.Forms.CheckBox
    Friend WithEvents TatooCheck As System.Windows.Forms.CheckBox
    Friend WithEvents WomanCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ManCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Xrmalbox As System.Windows.Forms.ComboBox
    Friend WithEvents Xrmatbox As System.Windows.Forms.ComboBox
    Friend WithEvents Ypsosbox As System.Windows.Forms.ComboBox
    Friend WithEvents Barosbox As System.Windows.Forms.ComboBox
    Friend WithEvents Hmbox As System.Windows.Forms.ComboBox
    Friend WithEvents OnomaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GlwssaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Glwssa2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErgasiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerioxhTextBox As System.Windows.Forms.TextBox
End Class
