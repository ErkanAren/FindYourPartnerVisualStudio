Public Class Results

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim name1 As String = Search.users_krit_baros(1, 0)
        ' For i = 0 To 5
        Dim pr_num As Double
        Dim new_table As String(,)
        ReDim new_table(Search.db_count, 3)
        Dim max As Integer(,)
        ReDim max(5, 2)
        ' For k = 0 To Search.db_count
        'new_table(k, 0) = Search.all_users(k, 0)
        ' new_table(k, 1) = Search.all_users(k, 1)
        ' new_table(k, 2) = Search.all_users(k, 2)
        ' Next

        'SYGXWNEYSI PINAKWN DEMO

        For j = 0 To Search.db_count

            If Search.users_krit_hmgen(j, 0) <> "" Then
                '    MessageBox.Show("Search.users_krit_tat(j, 0)= " & Search.users_krit_hmgen(j, 0))

            End If

            '  If Search.all_users(i, 0) = Search.users_krit_baros(j, 0) Then
            'Search.all_users(i, 1) += 1
            'End If

        Next


        Dim i As Integer = 0
        If (Search.kritirio_varos_selected = True) Then
            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_baros(j, 0) = "" Then
                        ' MessageBox.Show("Search.users_krit_baros(j, 0)= " & Search.users_krit_baros(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                    Else
                        If Search.all_users(i, 1) = Search.users_krit_baros(j, 1) Then
                            Search.all_users(i, 2) += 1
                        End If

                    End If

                Next

                i += 1
            Loop
        End If

        If Search.kritirio_hmgen_selected = True Then
            i = 0
            Do Until Search.all_users(i, 0) = ""

                For j = 0 To Search.db_count
                    If Search.users_krit_hmgen(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_tat(j, 0)= " & Search.users_krit_tat(j, 0) & "- Search.all_users(i, 2)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_hmgen(j, 1) Then
                            Search.all_users(i, 2) += 1
                            MessageBox.Show("kritirio_hmgen_selected me onoma = " & Search.users_krit_hmgen(j, 0))
                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_tat_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_tat(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_tat(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop
          

        End If
        For i = 0 To Search.db_count
            new_table(i, 0) = Search.all_users(i, 0)
            new_table(i, 1) = Search.all_users(i, 1)
            new_table(i, 2) = Search.all_users(i, 2)
        Next
        Dim th As Integer
        For th = 0 To 5
            max(th, 1) = 0
            max(th, 0) = 0
        Next


        For th = 0 To 5
            For k = 0 To Search.db_count

                If max(th, 1) < new_table(k, 2) Then

                    max(th, 0) = k
                    max(th, 1) = new_table(k, 2)
                    new_table(k, 2) = 0
                End If
            Next
        Next




        MessageBox.Show("Ar_krit= " & Search.ar_krit & ", Petiximena krit= " & Search.all_users(2, 2) & ",Onoma= " & Search.all_users(2, 0))



        onoma1.Text = Search.all_users(max(0, 0), 0)
        pr_num_l1.Text = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(0, 0), 2)
        pr_num = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(0, 0), 2)
        ProgressBar1.Value = pr_num

        onoma2.Text = Search.all_users(max(1, 0), 0)
        pr_num_l2.Text = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(1, 0), 2)
        pr_num = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(1, 0), 2)
        ProgressBar2.Value = pr_num

        onoma3.Text = Search.all_users(max(2, 0), 0)
        pr_num_l3.Text = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(2, 0), 2)
        pr_num = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(2, 0), 2)
        ProgressBar3.Value = pr_num

        onoma4.Text = Search.all_users(max(3, 0), 0)
        pr_num_l4.Text = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(3, 0), 2)
        pr_num = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(3, 0), 2)
        ProgressBar4.Value = pr_num

        onoma5.Text = Search.all_users(max(4, 0), 0)
        pr_num_l5.Text = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(4, 0), 2)
        pr_num = (16 / Search.ar_krit) * 6.25 * Search.all_users(max(4, 0), 2)
        ProgressBar5.Value = pr_num

        ' Label1.Text = Search.users_krit_hmgen(0, 0)
        '  ProgressBar1.Value = (16 / Search.ar_krit) * 6.25 * Search.users_krit_hmgen(0, 1)
        ' Label2.Text = (16 / Search.ar_krit) * 6.25 * Search.users_krit_hmgen(0, 1)
        ' Next
        ' Dim pr_num As Double
        ' pr_num = (16 / Search.ar_krit) * 6.25 * Search.pet_krit
        ' Label1.Text = Search.onoma_xr
        ' ProgressBar1.Value = pr_num
    End Sub
   

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Search.ar_krit = 0
        For i = 0 To Search.db_count
            'Search.all_users(i, 0) = ""
            '  Search.all_users(i, 1) = ""
            Search.all_users(i, 2) = 0

        Next
        Me.Close()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Search.ar_krit = 0
            For i = 0 To Search.db_count
                'Search.all_users(i, 0) = ""
                '  Search.all_users(i, 1) = ""
                Search.all_users(i, 2) = 0

            Next
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then

            e.Cancel = True
            Exit Sub
        End If

    End Sub

End Class