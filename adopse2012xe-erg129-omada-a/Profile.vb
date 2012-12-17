Public Class ProfileForm
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        Me.Close()
        Search.ShowDialog()

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Me.Close()
        Edit.ShowDialog()

    End Sub

    
End Class