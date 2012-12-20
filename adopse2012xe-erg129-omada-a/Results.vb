Public Class Results

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim name1 As String = Search.users_krit_baros(1, 0)
        ' For i = 0 To 5
        Label1.Text = Search.users_krit_baros(2, 0)
        ProgressBar1.Value = (16 / Search.ar_krit) * 6.25 * Search.users_krit_baros(0, 1)
        Label2.Text = (16 / Search.ar_krit) * 6.25 * Search.users_krit_baros(0, 1)
        ' Next
        ' Dim pr_num As Double
        ' pr_num = (16 / Search.ar_krit) * 6.25 * Search.pet_krit
        ' Label1.Text = Search.onoma_xr
        ' ProgressBar1.Value = pr_num
    End Sub
End Class