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

    End Sub


    Private Sub PasswordTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = "" Then
            PasswordError.Visible = True
            HelpLabel.Visible = True
        Else
            PasswordError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub


    Private Sub EmailTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTextBox.Leave
        If EmailTextBox.Text = "" Then
            EmailError.Visible = True
            HelpLabel.Visible = True
        Else
            EmailError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub OnomaTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnomaTextBox.Leave
        If OnomaTextBox.Text = "" Then
            OnomaError.Visible = True
            HelpLabel.Visible = True

        Else
            OnomaError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub EpithetoTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EpithetoTextBox.Leave
        If EpithetoTextBox.Text = "" Then
            EpithetoError.Visible = True
            HelpLabel.Visible = True
        Else
            EpithetoError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub Hm_GennisisTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hm_GennisisTextBox.Leave
        If Hm_GennisisTextBox.Text = "" Then
            HmError.Visible = True
            HelpLabel.Visible = True
        Else
            HmError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub HelpLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpLabel.Click

    End Sub
End Class