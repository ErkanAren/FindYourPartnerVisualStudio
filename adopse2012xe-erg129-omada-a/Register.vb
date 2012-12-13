Public Class RegisterForm

    Private Sub PeopleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)

    End Sub

    Private Sub RegisterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PeopleDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.PeopleDataSet.People)
        Me.PeopleBindingSource.AddNew()
    End Sub

    Private Sub RgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RgButton.Click
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)
        Me.Close()
        ProfileForm.Show()
    End Sub
End Class