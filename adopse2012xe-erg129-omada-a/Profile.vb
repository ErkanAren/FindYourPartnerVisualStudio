Public Class ProfileForm
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        Me.Close()
        Search.ShowDialog()

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Me.Close()
        Edit.ShowDialog()

    End Sub

    
    Private Sub ProfileForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EmShow.Text = Login.username1
        OnomaShow.Text = Login.onoma1
        EpithetoShow.Text = Login.epitheto1
        HmShow.Text = Login.hmergen1
        PerioxhShow.Text = Login.perioxh1
        ErgasiaShow.Text = Login.ergasia1
    End Sub
End Class