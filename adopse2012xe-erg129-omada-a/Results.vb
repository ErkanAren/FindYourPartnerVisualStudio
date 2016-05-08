Public Class Results
    Dim max As Integer(,) 'o pinakas poy tha xrhsimopoiithei gia na kataxorhthoyn oi theseis twn xristwn sto all_users me ti megalyteri symbatotita
    Dim analytic1click As Boolean = False 'tha xrhsimopoiithoyn gia tin emfanisi analytikwn apotelesmatwn
    Dim analytic2click As Boolean = False
    Dim analytic3click As Boolean = False
    Dim analytic4click As Boolean = False
    Dim analytic5click As Boolean = False

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim name1 As String = Search.users_krit_baros(1, 0)
        ' For i = 0 To 5
        Dim pr_num As Double 'metavliti ypologismoy twn apotelesmatwn epi tis ekato
        Dim new_table As String(,) 'temp pinakas poy tha xrhsimopoihthei sto max,(gia na min xathoyn ta epitiximena kritiria)
        ReDim new_table(Search.db_count, 4)

        ReDim max(5, 2) 'h prwti stili toy pinaka tha periexei ti thesi kai i deyteri stili twn arithmo twn kritiriwn poy tairiasan



        Dim i As Integer = 0
        If (Search.kritirio_varos_selected = True) Then
            Do Until Search.all_users(i, 0) = "" ' kane mexri na min yparxei onoma xristi
                For j = 0 To Search.db_count
                    If Search.users_krit_baros(j, 0) = "" Then 'Search.users_krit_baros(j, 0) periexei toys xristes poy tairiaksan sto zitoymeno kritirio
                        ' MessageBox.Show("Search.users_krit_baros(j, 0)= " & Search.users_krit_baros(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                    Else
                        If Search.all_users(i, 1) = Search.users_krit_baros(j, 1) Then ' ean to ID toy all_users(i) = users_krit_baros(j).ID
                            Search.all_users(i, 2) += 1 ' ayksise to pedio toy xristi poy apothikeyetai o arithmos twn petiximenwn kritiriwn
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
                            ' MessageBox.Show("kritirio_hmgen_selected me onoma = " & Search.users_krit_hmgen(j, 0))
                            ' MessageBox.Show("all users me onoma = " & Search.all_users(i, 0))
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


        If Search.kritirio_ypsos_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_ypsos(j, 0) = "" Then

                    Else

                        If Search.all_users(i, 1) = Search.users_krit_ypsos(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_xrmat_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_xr_mat(j, 0) = "" Then

                    Else

                        If Search.all_users(i, 1) = Search.users_krit_xr_mat(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_xrmal_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_xr_mal(j, 0) = "" Then

                    Else

                        If Search.all_users(i, 1) = Search.users_krit_xr_mal(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If


        If Search.kritirio_onoma_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_onoma(j, 0) = "" Then

                    Else

                        If Search.all_users(i, 1) = Search.users_krit_onoma(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If


        If Search.kritirio_hob1_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_hob1(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_hob1(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_hob2_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_hob2(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_hob2(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_hob3_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_hob3(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_hob3(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_glws1_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_glws1(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_glws1(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_glws2_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_glws2(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_glws2(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If


        If Search.kritirio_ergasia_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_ergasia(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_ergasia(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_perioxh_selected = True Then
            i = 0

            Do Until Search.all_users(i, 0) = ""
                For j = 0 To Search.db_count
                    If Search.users_krit_perioxh(j, 0) = "" Then

                    Else
                        'MessageBox.Show("Search.users_krit_hmgen(j, 0)= " & Search.users_krit_hmgen(j, 0) & "- Search.all_users(i, 0)= " & Search.all_users(i, 0))
                        If Search.all_users(i, 1) = Search.users_krit_perioxh(j, 1) Then
                            Search.all_users(i, 2) += 1

                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_fylo_selected = True Then 'ean exei epilexthei to kritirio fylo
            i = 0 'arxikopoihei to i
            Dim selected_fylo As Boolean = False 'h metavlitis boolean poy tha xrhsimopoithei gia ton orismo toy fyloy
            Do Until Search.all_users(i, 0) = ""
                selected_fylo = False
                For j = 0 To Search.db_count
                    If Search.users_krit_fylo(j, 0) = "" Then 'ean o pinakas den periexei alla stoixeia
                        If selected_fylo <> True Then 'ean o users den einai mes to pinaka Search.users_krit_fylo
                            Search.all_users(i, 2) = -1 'kataxwrisi -1 sto pedio synolikos arithmos pet. kritiriwn gia xristes poy den tairiazoyn

                        End If
                    Else 'Search.users_krit_fylo(j, 0) <> "" 
                        If Search.all_users(i, 1) = Search.users_krit_fylo(j, 1) Then
                            Search.all_users(i, 2) += 1
                            selected_fylo = True
                        End If
                    End If
                Next
                i += 1
            Loop

        End If

        If Search.kritirio_anazita_selected = True Then
            i = 0
            Dim selected_anazita As Boolean = False
            Do Until Search.all_users(i, 0) = ""
                selected_anazita = False
                For j = 0 To Search.db_count
                    If Search.users_krit_anazita(j, 0) = "" Then
                        If selected_anazita <> True Then
                            Search.all_users(i, 2) = 0

                        End If
                    Else
                        If Search.all_users(i, 1) = Search.users_krit_anazita(j, 1) Then
                            Search.all_users(i, 2) += 1
                            selected_anazita = True
                        End If
                    End If
                Next
                i += 1
            Loop

        End If


        Dim tempresults As Integer()
        ReDim tempresults(Search.db_count)
        For i = 0 To Search.db_count ' ekxwrish pediwn tou pinaka all_users sto temp pinaka new table gia xrisi parakatw
            new_table(i, 0) = Search.all_users(i, 0)
            new_table(i, 1) = Search.all_users(i, 1)
            new_table(i, 2) = Search.all_users(i, 2)
            new_table(i, 3) = Search.all_users(i, 3)

            tempresults(i) = Search.all_users(i, 2) 'kataxwroyme twn arithmo twn petiximenwn kritiriwn gia kathe xristi ston temp results

        Next
        Dim th As Integer
        For th = 0 To 5 'arxikopoiisi toy pinaka max
            max(th, 1) = 0
            max(th, 0) = 0
        Next
        Array.Sort(tempresults) 'taksinomei to pinaka
        Array.Reverse(tempresults) ' antistrefei to taksinomimeno pinaka
        Dim n As Integer = 0
        For th = 0 To 5
            For k = 0 To Search.db_count

                If max(th, 1) < new_table(k, 2) Then 'new_table(k, 2)= arithmos pet. kritiriwn toy xristi

                    max(th, 0) = k ' kataxwrei ti thesi toy xristi sti prwti thesi toy pinaka max
                    max(th, 1) = new_table(k, 2) 'kataxwrei twn arithmo twn pet. krit sti deyteri thesi toy pinaka max

                    If tempresults(n) = max(th, 1) Then
                        new_table(k, 2) = 0
                        n += 1 ' ean einai o max(th) pane ston epomeno tempresults
                    End If

                End If
            Next
        Next



        '   MessageBox.Show("Ar_krit= " & Search.ar_krit & ", Petiximena krit= " & Search.all_users(2, 2) & ",Onoma= " & Search.all_users(2, 0))

        If Search.all_users(max(0, 0), 2) <> 0 Then 'ean i timi toy megalyteroy arithmoy twn petyximenwn kritiriwn einai diaforo toy mhdenos
            analytic1.Visible = True
            onoma1.Visible = True
            pr_num_l1.Visible = True
            ProgressBar1.Visible = True
            Label1.Visible = True
            onoma1.Text = Search.all_users(max(0, 0), 0) & " " & Search.all_users(max(0, 0), 3) 'emfanisi onomatos = Search.all_users(max(0, 0), 0) kai epitheto = Search.all_users(max(0, 0), 3)
            pr_num = CInt((16 / Search.ar_krit) * 6.25 * Search.all_users(max(0, 0), 2)) ' pr_num= (16 / ar. epilegmenwn krit.) * 6.25 * ar. petiximenwn krit. xristi .....6.25 = (100/synolikos arithmos kritiriwn)
            pr_num_l1.Text = pr_num
            ProgressBar1.Value = pr_num
        Else
            dontmatch.Visible = True 'ean den yparxoyn pet. krit. (epeidi einai o prwtos elegxos emfanise to mnm donmatch)
        End If

        If Search.all_users(max(1, 0), 2) <> 0 Then
            analytic2.Visible = True
            onoma2.Visible = True
            pr_num_l2.Visible = True
            ProgressBar2.Visible = True
            Label2.Visible = True
            onoma2.Text = Search.all_users(max(1, 0), 0) & " " & Search.all_users(max(1, 0), 3)
            pr_num = CInt((16 / Search.ar_krit) * 6.25 * Search.all_users(max(1, 0), 2))
            pr_num_l2.Text = pr_num
            ProgressBar2.Value = pr_num
        End If

        If Search.all_users(max(2, 0), 2) <> 0 Then
            analytic3.Visible = True
            onoma3.Visible = True
            pr_num_l3.Visible = True
            ProgressBar3.Visible = True
            Label3.Visible = True
            onoma3.Text = Search.all_users(max(2, 0), 0) & " " & Search.all_users(max(2, 0), 3)
            pr_num = CInt((16 / Search.ar_krit) * 6.25 * Search.all_users(max(2, 0), 2))
            pr_num_l3.Text = pr_num
            ProgressBar3.Value = pr_num
        End If


        If Search.all_users(max(3, 0), 2) <> 0 Then
            analytic4.Visible = True
            onoma4.Visible = True
            pr_num_l4.Visible = True
            ProgressBar4.Visible = True
            Label4.Visible = True
            onoma4.Text = Search.all_users(max(3, 0), 0) & " " & Search.all_users(max(3, 0), 3)
            pr_num = CInt((16 / Search.ar_krit) * 6.25 * Search.all_users(max(3, 0), 2))
            pr_num_l4.Text = pr_num
            ProgressBar4.Value = pr_num
        End If

        If Search.all_users(max(4, 0), 2) <> 0 Then
            analytic5.Visible = True
            onoma5.Visible = True
            pr_num_l5.Visible = True
            ProgressBar5.Visible = True
            Label5.Visible = True
            onoma5.Text = Search.all_users(max(4, 0), 0) & " " & Search.all_users(max(4, 0), 3)
            pr_num = CInt((16 / Search.ar_krit) * 6.25 * Search.all_users(max(4, 0), 2))
            pr_num_l5.Text = pr_num
            ProgressBar5.Value = pr_num
        End If


        For i = 0 To Search.db_count 'clear the new table
            new_table(i, 0) = ""
            new_table(i, 1) = ""
            new_table(i, 2) = 0
        Next
       
    End Sub


    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Search.ar_krit = 0
        For i = 0 To Search.db_count
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
                Search.all_users(i, 2) = 0
            Next
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If

    End Sub





    Private Sub analytic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analytic1.Click


        If analytic1click = False Then
            analytic1click = True
            Panel1.Visible = True
            handpic1.Visible = True
            handpic2.Visible = False
            handpic3.Visible = False
            handpic4.Visible = False
            handpic5.Visible = False
            analytic2click = False
            analytic3click = False
            analytic4click = False
            analytic5click = False
        Else
            analytic1click = False
            Panel1.Visible = False
            handpic1.Visible = False
        End If

        aonoma.Text = Search.all_users(max(0, 0), 0)
        aepitheto.Text = Search.all_users(max(0, 0), 3)
        ahmgen.Text = Search.all_users(max(0, 0), 4)
        abaros.Text = Search.all_users(max(0, 0), 5)
        aypsos.Text = Search.all_users(max(0, 0), 6)
        axrmat.Text = Search.all_users(max(0, 0), 7)
        axrmal.Text = Search.all_users(max(0, 0), 8)
        ahob1.Text = Search.all_users(max(0, 0), 9)
        ahob2.Text = Search.all_users(max(0, 0), 10)
        ahob3.Text = Search.all_users(max(0, 0), 11)
        aanazita.Text = Search.all_users(max(0, 0), 12)
        aemail.Text = Search.all_users(max(0, 0), 13)
        aglwssa.Text = Search.all_users(max(0, 0), 14)
        aglwssa2.Text = Search.all_users(max(0, 0), 15)
        atatoo.Text = Search.all_users(max(0, 0), 16)
        aergasia.Text = Search.all_users(max(0, 0), 17)
        aperioxh.Text = Search.all_users(max(0, 0), 18)
        afylo.Text = Search.all_users(max(0, 0), 19)
    End Sub

    Private Sub analytic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analytic2.Click
        If analytic2click = False Then
            analytic2click = True
            Panel1.Visible = True
            handpic2.Visible = True
            handpic1.Visible = False
            handpic3.Visible = False
            handpic4.Visible = False
            handpic5.Visible = False
            analytic1click = False
            analytic3click = False
            analytic4click = False
            analytic5click = False
        Else
            analytic2click = False
            Panel1.Visible = False
            handpic2.Visible = False
        End If

        aonoma.Text = Search.all_users(max(1, 0), 0)
        aepitheto.Text = Search.all_users(max(1, 0), 3)
        ahmgen.Text = Search.all_users(max(1, 0), 4)
        abaros.Text = Search.all_users(max(1, 0), 5)
        aypsos.Text = Search.all_users(max(1, 0), 6)
        axrmat.Text = Search.all_users(max(1, 0), 7)
        axrmal.Text = Search.all_users(max(1, 0), 8)
        ahob1.Text = Search.all_users(max(1, 0), 9)
        ahob2.Text = Search.all_users(max(1, 0), 10)
        ahob3.Text = Search.all_users(max(1, 0), 11)
        aanazita.Text = Search.all_users(max(1, 0), 12)
        aemail.Text = Search.all_users(max(1, 0), 13)
        aglwssa.Text = Search.all_users(max(1, 0), 14)
        aglwssa2.Text = Search.all_users(max(1, 0), 15)
        atatoo.Text = Search.all_users(max(1, 0), 16)
        aergasia.Text = Search.all_users(max(1, 0), 17)
        aperioxh.Text = Search.all_users(max(1, 0), 18)
        afylo.Text = Search.all_users(max(1, 0), 19)
    End Sub

    Private Sub analytic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analytic3.Click
        If analytic3click = False Then
            analytic3click = True
            Panel1.Visible = True
            handpic3.Visible = True
            handpic1.Visible = False
            handpic2.Visible = False
            handpic4.Visible = False
            handpic5.Visible = False
            analytic1click = False
            analytic2click = False
            analytic4click = False
            analytic5click = False
        Else
            analytic3click = False
            Panel1.Visible = False
            handpic3.Visible = False
        End If

        aonoma.Text = Search.all_users(max(2, 0), 0)
        aepitheto.Text = Search.all_users(max(2, 0), 3)
        ahmgen.Text = Search.all_users(max(2, 0), 4)
        abaros.Text = Search.all_users(max(2, 0), 5)
        aypsos.Text = Search.all_users(max(2, 0), 6)
        axrmat.Text = Search.all_users(max(2, 0), 7)
        axrmal.Text = Search.all_users(max(2, 0), 8)
        ahob1.Text = Search.all_users(max(2, 0), 9)
        ahob2.Text = Search.all_users(max(2, 0), 10)
        ahob3.Text = Search.all_users(max(2, 0), 11)
        aanazita.Text = Search.all_users(max(2, 0), 12)
        aemail.Text = Search.all_users(max(2, 0), 13)
        aglwssa.Text = Search.all_users(max(2, 0), 14)
        aglwssa2.Text = Search.all_users(max(2, 0), 15)
        atatoo.Text = Search.all_users(max(2, 0), 16)
        aergasia.Text = Search.all_users(max(2, 0), 17)
        aperioxh.Text = Search.all_users(max(2, 0), 18)
        afylo.Text = Search.all_users(max(2, 0), 19)
    End Sub

    Private Sub analytic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analytic4.Click
        If analytic4click = False Then
            analytic4click = True
            Panel1.Visible = True
            handpic4.Visible = True
            handpic1.Visible = False
            handpic2.Visible = False
            handpic3.Visible = False
            handpic5.Visible = False
            analytic1click = False
            analytic2click = False
            analytic3click = False
            analytic5click = False
        Else
            analytic4click = False
            Panel1.Visible = False
            handpic4.Visible = False
        End If

        aonoma.Text = Search.all_users(max(3, 0), 0)
        aepitheto.Text = Search.all_users(max(3, 0), 3)
        ahmgen.Text = Search.all_users(max(3, 0), 4)
        abaros.Text = Search.all_users(max(3, 0), 5)
        aypsos.Text = Search.all_users(max(3, 0), 6)
        axrmat.Text = Search.all_users(max(3, 0), 7)
        axrmal.Text = Search.all_users(max(3, 0), 8)
        ahob1.Text = Search.all_users(max(3, 0), 9)
        ahob2.Text = Search.all_users(max(3, 0), 10)
        ahob3.Text = Search.all_users(max(3, 0), 11)
        aanazita.Text = Search.all_users(max(3, 0), 12)
        aemail.Text = Search.all_users(max(3, 0), 13)
        aglwssa.Text = Search.all_users(max(3, 0), 14)
        aglwssa2.Text = Search.all_users(max(3, 0), 15)
        atatoo.Text = Search.all_users(max(3, 0), 16)
        aergasia.Text = Search.all_users(max(3, 0), 17)
        aperioxh.Text = Search.all_users(max(3, 0), 18)
        afylo.Text = Search.all_users(max(3, 0), 19)
    End Sub

    Private Sub analytic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analytic5.Click
        If analytic5click = False Then
            analytic5click = True
            Panel1.Visible = True
            handpic5.Visible = True
            handpic1.Visible = False
            handpic2.Visible = False
            handpic3.Visible = False
            handpic4.Visible = False
            analytic1click = False
            analytic2click = False
            analytic3click = False
            analytic4click = False
        Else
            analytic5click = False
            Panel1.Visible = False
            handpic5.Visible = False
        End If

        aonoma.Text = Search.all_users(max(4, 0), 0)
        aepitheto.Text = Search.all_users(max(4, 0), 3)
        ahmgen.Text = Search.all_users(max(4, 0), 4)
        abaros.Text = Search.all_users(max(4, 0), 5)
        aypsos.Text = Search.all_users(max(4, 0), 6)
        axrmat.Text = Search.all_users(max(4, 0), 7)
        axrmal.Text = Search.all_users(max(4, 0), 8)
        ahob1.Text = Search.all_users(max(4, 0), 9)
        ahob2.Text = Search.all_users(max(4, 0), 10)
        ahob3.Text = Search.all_users(max(4, 0), 11)
        aanazita.Text = Search.all_users(max(4, 0), 12)
        aemail.Text = Search.all_users(max(4, 0), 13)
        aglwssa.Text = Search.all_users(max(4, 0), 14)
        aglwssa2.Text = Search.all_users(max(4, 0), 15)
        atatoo.Text = Search.all_users(max(4, 0), 16)
        aergasia.Text = Search.all_users(max(4, 0), 17)
        aperioxh.Text = Search.all_users(max(4, 0), 18)
        afylo.Text = Search.all_users(max(4, 0), 19)
    End Sub
End Class