Public Class ProfileForm
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        Me.Close()
        Search.ShowDialog()

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Me.Close()
        Edit.Show()


    End Sub


    Private Sub ProfileForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Edit.editclicked = False Then 'ean den exoume kanei click sto button edit pare times gia emfanisi apo to login
            EmShow.Text = Login.username1
            OnomaShow.Text = Login.onoma1
            EpithetoShow.Text = Login.epitheto1
            HmShow.Text = Login.hmergen1
            PerioxhShow.Text = Login.perioxh1
            ErgasiaShow.Text = Login.ergasia1
        Else 'ean exoume kanei click sto button edit pare times gia emfanisi apo ta textboxes toy edit
            EmShow.Text = Edit.EmailTextBox.Text
            OnomaShow.Text = Edit.OnomaTextBox.Text
            EpithetoShow.Text = Edit.EpithetoTextBox.Text
            HmShow.Text = Edit.Hm_GennisisTextBox.Text
            PerioxhShow.Text = Edit.PerioxhTextBox.Text
            ErgasiaShow.Text = Edit.ErgasiaTextBox.Text
        End If
    End Sub

    Private Sub LogoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        Me.Close()
        Login.Show()
        Login.UserNameText.Text = ""
        Login.PasswordText.Text = ""


    End Sub
End Class