<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim EpithetoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Hoby2Label As System.Windows.Forms.Label
        Me.PeopleDataSet = New WindowsApplication1.peopleDataSet
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleTableAdapter = New WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
        Me.PeopleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PeopleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OnomaTextBox = New System.Windows.Forms.TextBox
        Me.Hm_GennisisTextBox = New System.Windows.Forms.TextBox
        Me.EpithetoTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.Hoby2TextBox = New System.Windows.Forms.TextBox
        OnomaLabel = New System.Windows.Forms.Label
        Hm_GennisisLabel = New System.Windows.Forms.Label
        EpithetoLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        Hoby2Label = New System.Windows.Forms.Label
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeopleBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnomaLabel
        '
        OnomaLabel.AutoSize = True
        OnomaLabel.Location = New System.Drawing.Point(362, 155)
        OnomaLabel.Name = "OnomaLabel"
        OnomaLabel.Size = New System.Drawing.Size(44, 13)
        OnomaLabel.TabIndex = 1
        OnomaLabel.Text = "Onoma:"
        '
        'Hm_GennisisLabel
        '
        Hm_GennisisLabel.AutoSize = True
        Hm_GennisisLabel.Location = New System.Drawing.Point(438, 246)
        Hm_GennisisLabel.Name = "Hm_GennisisLabel"
        Hm_GennisisLabel.Size = New System.Drawing.Size(69, 13)
        Hm_GennisisLabel.TabIndex = 3
        Hm_GennisisLabel.Text = "Hm Gennisis:"
        '
        'EpithetoLabel
        '
        EpithetoLabel.AutoSize = True
        EpithetoLabel.Location = New System.Drawing.Point(109, 115)
        EpithetoLabel.Name = "EpithetoLabel"
        EpithetoLabel.Size = New System.Drawing.Size(49, 13)
        EpithetoLabel.TabIndex = 5
        EpithetoLabel.Text = "Epitheto:"
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
        'PeopleBindingNavigator
        '
        Me.PeopleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PeopleBindingNavigator.BindingSource = Me.PeopleBindingSource
        Me.PeopleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PeopleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PeopleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PeopleBindingNavigatorSaveItem})
        Me.PeopleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PeopleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PeopleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PeopleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PeopleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PeopleBindingNavigator.Name = "PeopleBindingNavigator"
        Me.PeopleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PeopleBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.PeopleBindingNavigator.TabIndex = 0
        Me.PeopleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PeopleBindingNavigatorSaveItem
        '
        Me.PeopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PeopleBindingNavigatorSaveItem.Image = CType(resources.GetObject("PeopleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PeopleBindingNavigatorSaveItem.Name = "PeopleBindingNavigatorSaveItem"
        Me.PeopleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PeopleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OnomaTextBox
        '
        Me.OnomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Onoma", True))
        Me.OnomaTextBox.Location = New System.Drawing.Point(412, 152)
        Me.OnomaTextBox.Name = "OnomaTextBox"
        Me.OnomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnomaTextBox.TabIndex = 2
        '
        'Hm_GennisisTextBox
        '
        Me.Hm_GennisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hm_Gennisis", True))
        Me.Hm_GennisisTextBox.Location = New System.Drawing.Point(513, 243)
        Me.Hm_GennisisTextBox.Name = "Hm_GennisisTextBox"
        Me.Hm_GennisisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hm_GennisisTextBox.TabIndex = 4
        '
        'EpithetoTextBox
        '
        Me.EpithetoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Epitheto", True))
        Me.EpithetoTextBox.Location = New System.Drawing.Point(164, 112)
        Me.EpithetoTextBox.Name = "EpithetoTextBox"
        Me.EpithetoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EpithetoTextBox.TabIndex = 6
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(296, 223)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(336, 220)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'Hoby2Label
        '
        Hoby2Label.AutoSize = True
        Hoby2Label.Location = New System.Drawing.Point(153, 199)
        Hoby2Label.Name = "Hoby2Label"
        Hoby2Label.Size = New System.Drawing.Size(41, 13)
        Hoby2Label.TabIndex = 9
        Hoby2Label.Text = "Hoby2:"
        '
        'Hoby2TextBox
        '
        Me.Hoby2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "Hoby2", True))
        Me.Hoby2TextBox.Location = New System.Drawing.Point(200, 196)
        Me.Hoby2TextBox.Name = "Hoby2TextBox"
        Me.Hoby2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Hoby2TextBox.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 338)
        Me.Controls.Add(Hoby2Label)
        Me.Controls.Add(Me.Hoby2TextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(EpithetoLabel)
        Me.Controls.Add(Me.EpithetoTextBox)
        Me.Controls.Add(Hm_GennisisLabel)
        Me.Controls.Add(Me.Hm_GennisisTextBox)
        Me.Controls.Add(OnomaLabel)
        Me.Controls.Add(Me.OnomaTextBox)
        Me.Controls.Add(Me.PeopleBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PeopleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeopleBindingNavigator.ResumeLayout(False)
        Me.PeopleBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeopleDataSet As WindowsApplication1.peopleDataSet
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleTableAdapter As WindowsApplication1.peopleDataSetTableAdapters.PeopleTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.peopleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PeopleBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PeopleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OnomaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hm_GennisisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EpithetoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hoby2TextBox As System.Windows.Forms.TextBox
End Class
