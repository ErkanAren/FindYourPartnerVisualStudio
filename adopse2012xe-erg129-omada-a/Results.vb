Public Class Results

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim name1 As String = Search.users_krit_baros(1, 0)
        ' For i = 0 To 5
        Dim pr_num As Double
        Dim new_table As String(,)
        ReDim new_table(Search.db_count, 3)
        ' For k = 0 To Search.db_count
        'new_table(k, 0) = Search.all_users(k, 0)
        ' new_table(k, 1) = Search.all_users(k, 1)
        ' new_table(k, 2) = Search.all_users(k, 2)
        ' Next

        'SYGXWNEYSI PINAKWN DEMO
        Dim i As Integer = 0
        Do
            For Each j In Search.users_krit_baros
                If Search.all_users(i, 2) = Search.users_krit_baros(j, 2) Then
                    Search.all_users(i, 1) += 1
                End If
            Next
            For Each j In Search.users_krit_tat
                If Search.all_users(i, 2) = Search.users_krit_tat(j, 2) Then
                    Search.all_users(i, 1) += 1
                End If
            Next
            For Each j In Search.users_krit_hmgen
                If Search.all_users(i, 2) = Search.users_krit_hmgen(j, 2) Then
                    Search.all_users(i, 1) += 1
                End If
            Next
            i += 1
        Loop Until new_table(i, 2) = ""

        onoma1.Text = new_table(i, 0)
        pr_num_l1.Text = (16 / Search.ar_krit) * 6.25 * new_table(i, 1)
        pr_num = (16 / Search.ar_krit) * 6.25 * new_table(i, 1)
        ProgressBar1.Value = pr_num

        onoma2.Text = new_table(i, 0)
        pr_num_l2.Text = (16 / Search.ar_krit) * 6.25 * new_table(i, 1)
        pr_num = (16 / Search.ar_krit) * 6.25 * new_table(i, 1)
        ProgressBar2.Value = pr_num

        onoma3.Text = new_table(i, 0)
        pr_num_l3.Text = (16 / Search.ar_krit) * 6.25 * new_table(i, 1)
        pr_num = (16 / Search.ar_krit) * 6.25 * new_table(i, 1)
        ProgressBar3.Value = pr_num
        ' Label1.Text = Search.users_krit_hmgen(0, 0)
        '  ProgressBar1.Value = (16 / Search.ar_krit) * 6.25 * Search.users_krit_hmgen(0, 1)
        ' Label2.Text = (16 / Search.ar_krit) * 6.25 * Search.users_krit_hmgen(0, 1)
        ' Next
        ' Dim pr_num As Double
        ' pr_num = (16 / Search.ar_krit) * 6.25 * Search.pet_krit
        ' Label1.Text = Search.onoma_xr
        ' ProgressBar1.Value = pr_num
    End Sub
End Class