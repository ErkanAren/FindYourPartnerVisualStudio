Public Class Results

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Search.ar_krit
        Dim pr_num As Double
        pr_num = (16 / Search.ar_krit) * 6.25 * Search.pet_krit
        Label1.Text = Search.onoma_xr
        ProgressBar1.Value = pr_num
    End Sub
End Class