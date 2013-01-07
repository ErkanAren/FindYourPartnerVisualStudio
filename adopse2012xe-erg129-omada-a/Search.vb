Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.Common
Public Class Search
    Public Shared ar_krit As Integer = 0 'synolikos arithmos kritiriwn
    ' Public Shared pet_krit As Integer = 0 'kritiria poy petyxan
    Public Shared onoma_xr As String
    Public loop_count As Integer = 0
    Public Shared users_krit_baros As String(,)
    Public Shared users_krit_tat As String(,)
    Public Shared users_krit_hmgen As String(,)
    Public Shared users_krit_ypsos As String(,)
    Public Shared users_krit_xr_mat As String(,)
    Public Shared users_krit_xr_mal As String(,)
    Public Shared users_krit_onoma As String(,)
    Public Shared users_krit_hob1 As String(,)
    Public Shared users_krit_hob2 As String(,)
    Public Shared users_krit_hob3 As String(,)
    Public Shared users_krit_glws1 As String(,)
    Public Shared users_krit_glws2 As String(,)
    Public Shared users_krit_ergasia As String(,)
    Public Shared users_krit_perioxh As String(,)
    Public Shared users_krit_fylo As String(,)
    Public Shared users_krit_anazita As String(,)

    Public Shared all_users As String(,)
    Public Shared pedio As String
    Public Shared kritirio_varos_selected As Boolean = False
    Public Shared kritirio_hmgen_selected As Boolean = False
    Public Shared kritirio_tat_selected As Boolean = False
    Public Shared kritirio_ypsos_selected As Boolean = False
    Public Shared kritirio_xrmat_selected As Boolean = False
    Public Shared kritirio_xrmal_selected As Boolean = False
    Public Shared kritirio_onoma_selected As Boolean = False
    Public Shared kritirio_hob1_selected As Boolean = False
    Public Shared kritirio_hob2_selected As Boolean = False
    Public Shared kritirio_hob3_selected As Boolean = False
    Public Shared kritirio_glws1_selected As Boolean = False
    Public Shared kritirio_glws2_selected As Boolean = False
    Public Shared kritirio_ergasia_selected As Boolean = False
    Public Shared kritirio_perioxh_selected As Boolean = False
    Public Shared kritirio_fylo_selected As Boolean = False
    Public Shared kritirio_anazita_selected As Boolean = False


    Public Shared db_count As Integer = 33 'database length (tha allaksei...)


    Private Sub PeopleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)

    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim all_dbusers As String = "SELECT * FROM people"
        ReDim all_users(db_count, 19)
        Dim cmd2 As New OleDbCommand
        Dim cn2 As OleDbConnection = New OleDbConnection
        cn2.ConnectionString = My.Settings.peopleConnectionString
        cn2.Open()
        cmd2.Connection = cn2
        Dim myadapt2 As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())

        Dim temprow2 As DataRow
        Dim ds2 As DataSet = New DataSet
        For k = 0 To db_count
            all_users(k, 0) = ""
            all_users(k, 1) = ""
            all_users(k, 2) = 0
            all_users(k, 3) = ""
            all_users(k, 4) = 0
            all_users(k, 5) = 0
            all_users(k, 6) = 0
            all_users(k, 7) = ""
            all_users(k, 8) = ""
            all_users(k, 9) = ""
            all_users(k, 10) = ""
            all_users(k, 11) = ""
            all_users(k, 12) = ""
            all_users(k, 13) = ""
            all_users(k, 14) = ""
            all_users(k, 15) = ""
            all_users(k, 16) = ""
            all_users(k, 17) = ""
            all_users(k, 18) = ""
        Next
        myadapt2 = New OleDbDataAdapter(all_dbusers, cmd2.Connection.ConnectionString())
        myadapt2.Fill(ds2, "people")
        Dim i As Integer = 0
        For Each temprow2 In ds2.Tables("people").Rows

            all_users(i, 0) = temprow2.Item("Onoma").ToString
            all_users(i, 1) = temprow2.Item("ID").ToString
            all_users(i, 3) = temprow2.Item("Epitheto").ToString
            all_users(i, 4) = temprow2.Item("Hm_Gennisis").ToString
            all_users(i, 5) = temprow2.Item("Baros").ToString
            all_users(i, 6) = temprow2.Item("Ypsos").ToString
            all_users(i, 7) = temprow2.Item("Xrwma_Matiwn").ToString
            all_users(i, 8) = temprow2.Item("Xrwma_Malliwn").ToString
            all_users(i, 9) = temprow2.Item("Hoby1").ToString
            all_users(i, 10) = temprow2.Item("Hoby2").ToString
            all_users(i, 11) = temprow2.Item("Hoby3").ToString
            all_users(i, 12) = temprow2.Item("Anazita").ToString
            all_users(i, 13) = temprow2.Item("email").ToString
            all_users(i, 14) = temprow2.Item("Glwssa").ToString
            all_users(i, 15) = temprow2.Item("Glwssa2").ToString
            all_users(i, 16) = temprow2.Item("Tatoo").ToString
            all_users(i, 17) = temprow2.Item("Ergasia").ToString
            all_users(i, 18) = temprow2.Item("Perioxh").ToString
            i += 1


        Next

    End Sub

    Private Sub SrBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SrBt.Click
        '  Dim con As New SqlConnection("Data Source = '" & Application.StartupPath & "\people.mdb'; prInitial Catalog = people;")
        '  Dim cmd As New SqlCommand("SELECT Onoma FROM people WHERE Baros = 49")
        '  con.Open()

        ReDim users_krit_baros(db_count, 2)
        ReDim users_krit_tat(db_count, 2)
        ReDim users_krit_hmgen(db_count, 2)
        ReDim users_krit_ypsos(db_count, 2)
        ReDim users_krit_xr_mat(db_count, 2)
        ReDim users_krit_xr_mal(db_count, 2)
        ReDim users_krit_onoma(db_count, 2)
        ReDim users_krit_hob1(db_count, 2)
        ReDim users_krit_hob2(db_count, 2)
        ReDim users_krit_hob3(db_count, 2)
        ReDim users_krit_glws1(db_count, 2)
        ReDim users_krit_glws2(db_count, 2)
        ReDim users_krit_perioxh(db_count, 2)
        ReDim users_krit_ergasia(db_count, 2)
        ReDim users_krit_fylo(db_count, 2)
        ReDim users_krit_anazita(db_count, 2)

        For i = 0 To db_count
            users_krit_baros(i, 0) = ""
            users_krit_baros(i, 1) = ""
        Next
        For i = 0 To db_count
            users_krit_tat(i, 0) = ""
            users_krit_tat(i, 1) = ""
        Next
        For i = 0 To db_count
            users_krit_tat(i, 0) = ""
            users_krit_tat(i, 1) = ""
        Next
        '  Dim db_counter As String = "SELECT Count(*) AS usercount FROM people"
        Dim all_dbusers As String = "SELECT * FROM people"
        Dim querybaros1 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Baros<=55"
        Dim querybaros2 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Baros>55 AND Baros<=65"
        Dim querybaros3 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Baros>65 AND Baros<=75"
        Dim querybaros4 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Baros>75 AND Baros<=85"
        Dim querybaros5 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Baros>85 AND Baros<=95"
        Dim querybaros6 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Baros>95"
        Dim querytatyes As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Tatoo='YES'"
        Dim querytatno As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Tatoo='NO'"
        Dim querydaterange As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Hm_Gennisis>=" & HmGenApo.Text & " AND Hm_Gennisis<=" & HmGenEws.Text
        Dim querydate As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Hm_Gennisis=" & HmGenApo.Text
        Dim queryypsosrange As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Ypsos>=" & ypsosApo.Text & " AND Ypsos<=" & YpsosEws.Text
        Dim queryypsos As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Ypsos=" & ypsosApo.Text
        Dim query_xrwma_matiwn As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Xrwma_Matiwn='" & Xrmatbox.Text & "'"
        Dim query_xrwma_maliwn As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Xrwma_Malliwn='" & Xrmalbox.Text & "'"
        Dim query_onoma As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Onoma='" & OnomaTextBox.Text & "'"
        Dim query_hob1 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Hoby1='" & Hoby1TextBox.Text & "' or Hoby2='" & Hoby1TextBox.Text & "' or Hoby3='" & Hoby1TextBox.Text & "'"
        Dim query_hob2 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Hoby1='" & Hoby2TextBox.Text & "' or Hoby2='" & Hoby2TextBox.Text & "' or Hoby3='" & Hoby2TextBox.Text & "'"
        Dim query_hob3 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Hoby1='" & Hoby3TextBox.Text & "' or Hoby2='" & Hoby3TextBox.Text & "' or Hoby3='" & Hoby3TextBox.Text & "'"

        Dim query_glws1 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Glwssa='" & GlwssaTextBox.Text & "' or Glwssa2='" & GlwssaTextBox.Text & "'"
        Dim query_glws2 As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Glwssa='" & Glwssa2TextBox.Text & "' or Glwssa2='" & Glwssa2TextBox.Text & "'"
        Dim query_perioxh As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Perioxh='" & PerioxhTextBox.Text & "'"
        Dim query_ergasia As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Ergasia='" & ErgasiaTextBox.Text & "'"
        Dim query_male As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Fylo='MALE'"
        Dim query_female As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Fylo='FEMALE'"

        Dim query_man As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Anazita='MAN'"
        Dim query_woman As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Anazita='WOMAN'"


        Dim cmd As New OleDbCommand
        Dim cn As OleDbConnection = New OleDbConnection
        cn.ConnectionString = My.Settings.peopleConnectionString
        cn.Open()
        cmd.Connection = cn
        ' Dim query_xrwma_matiwn = (From peop In PeopleBindingSource Order By peop.ID Ascending Where (peop.Xrwma_Matiwn = Xrmatbox.Text) Select Onoma = peop.Onoma, ID = peop.ID)
        Dim myadapt As OleDbDataAdapter 'Xreisimopoiihtai gia to varos = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        Dim myadaptbaros As OleDbDataAdapter
        Dim myadapttat As OleDbDataAdapter
        Dim myadapthmgen As OleDbDataAdapter
        Dim myadaptypsos As OleDbDataAdapter
        Dim myadaptxr_mat As OleDbDataAdapter
        Dim myadaptonoma As OleDbDataAdapter
        Dim myadaptxr_mal As OleDbDataAdapter
        Dim myadapthob1 As OleDbDataAdapter
        Dim myadapthob2 As OleDbDataAdapter
        Dim myadapthob3 As OleDbDataAdapter
        Dim myadaptglws1 As OleDbDataAdapter
        Dim myadaptglws2 As OleDbDataAdapter
        Dim myadaptergasia As OleDbDataAdapter
        Dim myadaptperioxh As OleDbDataAdapter
        Dim myadaptfylo As OleDbDataAdapter
        Dim myadaptanazita As OleDbDataAdapter

        ' Dim myadapttat As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        Dim temprow As DataRow
        Dim ds As DataSet = New DataSet

        Dim temprowxr_mat As DataRow
        Dim dsxr_mat As DataSet = New DataSet

        Dim temprowxr_mal As DataRow
        Dim dsxr_mal As DataSet = New DataSet

        Dim temprowtat As DataRow
        Dim dstat As DataSet = New DataSet

        Dim temprowhm As DataRow
        Dim dshm As DataSet = New DataSet

        Dim temprowonoma As DataRow
        Dim dsonoma As DataSet = New DataSet

        Dim temprowypsos As DataRow
        Dim dsypsos As DataSet = New DataSet

        Dim temprowhob1 As DataRow
        Dim dshob1 As DataSet = New DataSet

        Dim temprowhob2 As DataRow
        Dim dshob2 As DataSet = New DataSet

        Dim temprowhob3 As DataRow
        Dim dshob3 As DataSet = New DataSet

        Dim temprowglws1 As DataRow
        Dim dsglws1 As DataSet = New DataSet

        Dim temprowglws2 As DataRow
        Dim dsglws2 As DataSet = New DataSet

        Dim temprowperioxh As DataRow
        Dim dsperioxh As DataSet = New DataSet

        Dim temprowergasia As DataRow
        Dim dsergasia As DataSet = New DataSet

        Dim temprowfylo As DataRow
        Dim dsfylo As DataSet = New DataSet

        Dim temprowanazita As DataRow
        Dim dsanazita As DataSet = New DataSet




        If OnomaTextBox.Text <> "" Then

            ar_krit = ar_krit + 1

            kritirio_onoma_selected = True
            myadaptonoma = New OleDbDataAdapter(query_onoma, cmd.Connection.ConnectionString())
            myadaptonoma.Fill(dsonoma, "people")

            Dim i As Integer = 0
            For Each temprowonoma In dsonoma.Tables("people").Rows

                If temprowonoma.Item("Onoma").ToString <> "" Then
                    users_krit_onoma(i, 0) = temprowonoma.Item("Onoma").ToString
                    users_krit_onoma(i, 1) = temprowonoma.Item("ID").ToString
                    i += 1
                End If
            Next

        End If
        If HmGenApo.Text <> "" And HmGenEws.Text <> "" Then
            If HmGenApo.Text > HmGenEws.Text Then
                MessageBox.Show("HMgen einai megalytero apo im ews")
            Else
                ar_krit = ar_krit + 1
                kritirio_hmgen_selected = True
                myadapthmgen = New OleDbDataAdapter(querydaterange, cmd.Connection.ConnectionString())
                myadapthmgen.Fill(dshm, "people")
                Dim i As Integer = 0
                For Each temprowhm In dshm.Tables("people").Rows
                    '  MessageBox.Show("Hm_gen - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    ' If i < db_count Then
                    If temprowhm.Item("Onoma").ToString <> "" Then
                        users_krit_hmgen(i, 0) = temprowhm.Item("Onoma").ToString

                        'users_krit_hmgen(i, 1) = users_krit_hmgen(i, 1) + 1
                        users_krit_hmgen(i, 1) = temprowhm.Item("ID").ToString
                        i += 1
                        '  MessageBox.Show("HmGen onoma= " & temprowhm.Item("Onoma").ToString)
                    End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            End If
            '   MessageBox.Show("Hmbox.SelectedItem")
        ElseIf HmGenApo.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_hmgen_selected = True
            myadapthmgen = New OleDbDataAdapter(querydate, cmd.Connection.ConnectionString())
            myadapthmgen.Fill(dshm, "people")
            Dim i As Integer = 0
            For Each temprowhm In dshm.Tables("people").Rows
                '    MessageBox.Show("1 - " & (temprowhm.Item("Onoma").ToString))
                '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                ' If i < db_count Then
                If temprowhm.Item("Onoma").ToString <> "" Then
                    users_krit_hmgen(i, 0) = temprowhm.Item("Onoma").ToString
                    'users_krit_hmgen(i, 1) = users_krit_hmgen(i, 1) + 1
                    users_krit_hmgen(i, 1) = temprowhm.Item("ID").ToString
                    ' MessageBox.Show("1 - " & (temprowhm.Item("Onoma").ToString))
                    i += 1
                End If
                ' If arr(i).Length <> 0 Then
                '  users_krit_baros(i)(1) += 1
                'End If

            Next
        End If


        If Barosbox.SelectedItem <> "" Then ' ean einai epilegmeno to kritirio baros
            '   MessageBox.Show("Barosbox.SelectedItem")
            ar_krit = ar_krit + 1 ' ayksanei twn arithmo twn epilegmenwn kritiriwn kai..
            kritirio_varos_selected = True
            If Barosbox.SelectedIndex = 0 Then 'ean exei epilexthei to prwto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows

                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString

                    users_krit_baros(i, 1) = temprow.Item("ID").ToString

                    i += 1

                Next


            ElseIf Barosbox.SelectedIndex = 1 Then 'ean exei epilexthei to deytero item toy kritiriou baros

                myadapt = New OleDbDataAdapter(querybaros2, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString

                    i += 1


                Next
            ElseIf Barosbox.SelectedIndex = 2 Then 'ean exei epilexthei to trito item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros3, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString

                    i += 1

                Next
            ElseIf Barosbox.SelectedIndex = 3 Then 'ean exei epilexthei to tetarto item toy kritiriou baros
                myadaptbaros = New OleDbDataAdapter(querybaros4, cmd.Connection.ConnectionString())
                myadaptbaros.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows

                    If temprow.Item("Onoma").ToString <> "" Then
                        users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                        users_krit_baros(i, 1) = temprow.Item("ID").ToString
                        i += 1
                    End If


                Next
            ElseIf Barosbox.SelectedIndex = 4 Then 'ean exei epilexthei to pempto item toy kritiriou baros
                myadaptbaros = New OleDbDataAdapter(querybaros5, cmd.Connection.ConnectionString())
                myadaptbaros.Fill(ds, "people")

                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString
                    i += 1
                Next
            ElseIf Barosbox.SelectedIndex = 5 Then 'ean exei epilexthei to ekto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros6, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString

                    i += 1

                Next
            End If


        End If 'telos if toy kritiriou baros

        If ypsosApo.Text <> "" And YpsosEws.Text <> "" Then 'ean to kritirio ypsos exei epilexthei(den einai adeia kai ta dyo text boxs)
            If ypsosApo.Text > YpsosEws.Text Then
                MessageBox.Show("ypsos apo einai megalytero apo ypsos ews")
            Else
                ar_krit = ar_krit + 1
                kritirio_ypsos_selected = True
                myadaptypsos = New OleDbDataAdapter(queryypsosrange, cmd.Connection.ConnectionString())
                myadaptypsos.Fill(dsypsos, "people")
                Dim i As Integer = 0
                For Each temprowypsos In dsypsos.Tables("people").Rows

                    If temprowypsos.Item("Onoma").ToString <> "" Then
                        users_krit_ypsos(i, 0) = temprowypsos.Item("Onoma").ToString
                        users_krit_ypsos(i, 1) = temprowypsos.Item("ID").ToString
                        i += 1

                    End If

                Next
            End If

        ElseIf ypsosApo.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_ypsos_selected = True
            myadaptypsos = New OleDbDataAdapter(queryypsos, cmd.Connection.ConnectionString())
            myadaptypsos.Fill(dsypsos, "people")
            Dim i As Integer = 0
            For Each temprowypsos In dsypsos.Tables("people").Rows

                If temprowypsos.Item("Onoma").ToString <> "" Then
                    users_krit_ypsos(i, 0) = temprowypsos.Item("Onoma").ToString
                    users_krit_ypsos(i, 1) = temprowypsos.Item("ID").ToString
                    i += 1
                End If
            Next
        End If



        If MaleRadioButton.Checked() = True Or FemaleRadioButton.Checked() = True Then
            ar_krit = ar_krit + 1
            If MaleRadioButton.Checked() = True Then


                kritirio_fylo_selected = True
                myadaptfylo = New OleDbDataAdapter(query_male, cmd.Connection.ConnectionString())
                myadaptfylo.Fill(dsfylo, "people")
                Dim i As Integer = 0
                For Each temprowfylo In dsfylo.Tables("people").Rows

                    If temprowfylo.Item("Onoma").ToString <> "" Then
                        users_krit_fylo(i, 0) = temprowfylo.Item("Onoma").ToString

                        users_krit_fylo(i, 1) = temprowfylo.Item("ID").ToString

                        i += 1


                    End If

                Next
            ElseIf FemaleRadioButton.Checked = True Then

                kritirio_fylo_selected = True
                myadaptfylo = New OleDbDataAdapter(query_female, cmd.Connection.ConnectionString())
                myadaptfylo.Fill(dsfylo, "people")
                Dim i As Integer = 0
                For Each temprowfylo In dsfylo.Tables("people").Rows


                    If temprowfylo.Item("Onoma").ToString <> "" Then
                        users_krit_fylo(i, 0) = temprowfylo.Item("Onoma").ToString

                        users_krit_fylo(i, 1) = temprowfylo.Item("ID").ToString
                        i += 1


                    End If

                Next
            End If
        End If




        If Xrmatbox.Text <> "" Then

            ar_krit = ar_krit + 1

            kritirio_xrmat_selected = True
            myadaptxr_mat = New OleDbDataAdapter(query_xrwma_matiwn, cmd.Connection.ConnectionString())
            myadaptxr_mat.Fill(dsxr_mat, "people")

            Dim i As Integer = 0
            For Each temprowxr_mat In dsxr_mat.Tables("people").Rows

                If temprowxr_mat.Item("Onoma").ToString <> "" Then
                    users_krit_xr_mat(i, 0) = temprowxr_mat.Item("Onoma").ToString
                    users_krit_xr_mat(i, 1) = temprowxr_mat.Item("ID").ToString
                    i += 1
                End If
            Next


        End If




        If Xrmalbox.Text <> "" Then

            ar_krit = ar_krit + 1

            kritirio_xrmal_selected = True
            myadaptxr_mal = New OleDbDataAdapter(query_xrwma_maliwn, cmd.Connection.ConnectionString())
            myadaptxr_mal.Fill(dsxr_mal, "people")

            Dim i As Integer = 0
            For Each temprowxr_mal In dsxr_mal.Tables("people").Rows

                If temprowxr_mal.Item("Onoma").ToString <> "" Then
                    users_krit_xr_mal(i, 0) = temprowxr_mal.Item("Onoma").ToString
                    users_krit_xr_mal(i, 1) = temprowxr_mal.Item("ID").ToString
                    i += 1
                End If
            Next

        End If
        If Hoby1TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_hob1_selected = True
            myadapthob1 = New OleDbDataAdapter(query_hob1, cmd.Connection.ConnectionString())
            myadapthob1.Fill(dshob1, "people")

            Dim i As Integer = 0
            For Each temprowhob1 In dshob1.Tables("people").Rows

                If temprowhob1.Item("Onoma").ToString <> "" Then
                    users_krit_hob1(i, 0) = temprowhob1.Item("Onoma").ToString
                    users_krit_hob1(i, 1) = temprowhob1.Item("ID").ToString
                    i += 1
                End If
            Next
        End If
        If Hoby2TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_hob2_selected = True

            myadapthob2 = New OleDbDataAdapter(query_hob2, cmd.Connection.ConnectionString())
            myadapthob2.Fill(dshob2, "people")

            Dim i As Integer = 0
            For Each temprowhob2 In dshob2.Tables("people").Rows

                If temprowhob2.Item("Onoma").ToString <> "" Then

                    users_krit_hob2(i, 0) = temprowhob2.Item("Onoma").ToString
                    users_krit_hob2(i, 1) = temprowhob2.Item("ID").ToString
                    i += 1
                End If
            Next
        End If
        If Hoby3TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_hob3_selected = True
            myadapthob3 = New OleDbDataAdapter(query_hob3, cmd.Connection.ConnectionString())
            myadapthob3.Fill(dshob3, "people")

            Dim i As Integer = 0
            For Each temprowhob3 In dshob3.Tables("people").Rows

                If temprowhob3.Item("Onoma").ToString <> "" Then
                    users_krit_hob3(i, 0) = temprowhob3.Item("Onoma").ToString
                    users_krit_hob3(i, 1) = temprowhob3.Item("ID").ToString
                    i += 1
                End If
            Next
        End If


        If ManRadioButton.Checked() = True Or WomanRadioButton.Checked() = True Then
            ar_krit = ar_krit + 1
            If ManRadioButton.Checked() = True Then


                kritirio_anazita_selected = True
                myadaptanazita = New OleDbDataAdapter(query_man, cmd.Connection.ConnectionString())
                myadaptanazita.Fill(dsanazita, "people")
                Dim i As Integer = 0
                For Each temprowanazita In dsanazita.Tables("people").Rows

                    If temprowanazita.Item("Onoma").ToString <> "" Then
                        users_krit_anazita(i, 0) = temprowanazita.Item("Onoma").ToString

                        users_krit_anazita(i, 1) = temprowanazita.Item("ID").ToString

                        i += 1


                    End If

                Next
            ElseIf WomanRadioButton.Checked = True Then

                kritirio_anazita_selected = True
                myadaptanazita = New OleDbDataAdapter(query_woman, cmd.Connection.ConnectionString())
                myadaptanazita.Fill(dsanazita, "people")
                Dim i As Integer = 0
                For Each temprowanazita In dsanazita.Tables("people").Rows

                    If temprowanazita.Item("Onoma").ToString <> "" Then
                        users_krit_anazita(i, 0) = temprowanazita.Item("Onoma").ToString

                        users_krit_anazita(i, 1) = temprowanazita.Item("ID").ToString

                        i += 1


                    End If

                Next
            End If
        End If


        If GlwssaTextBox.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_glws1_selected = True

            myadaptglws1 = New OleDbDataAdapter(query_glws1, cmd.Connection.ConnectionString())
            myadaptglws1.Fill(dsglws1, "people")

            Dim i As Integer = 0
            For Each temprowglws1 In dsglws1.Tables("people").Rows

                If temprowglws1.Item("Onoma").ToString <> "" Then

                    users_krit_glws1(i, 0) = temprowglws1.Item("Onoma").ToString
                    users_krit_glws1(i, 1) = temprowglws1.Item("ID").ToString
                    i += 1
                End If
            Next
        End If

        If Glwssa2TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_glws2_selected = True

            myadaptglws2 = New OleDbDataAdapter(query_glws2, cmd.Connection.ConnectionString())
            myadaptglws2.Fill(dsglws2, "people")

            Dim i As Integer = 0
            For Each temprowglws2 In dsglws2.Tables("people").Rows

                If temprowglws2.Item("Onoma").ToString <> "" Then

                    users_krit_glws2(i, 0) = temprowglws2.Item("Onoma").ToString
                    users_krit_glws2(i, 1) = temprowglws2.Item("ID").ToString
                    i += 1
                End If
            Next
        End If
        If YesRadioButton.Checked <> False Then

            ar_krit = ar_krit + 1
            kritirio_tat_selected = True
            myadapttat = New OleDbDataAdapter(querytatyes, cmd.Connection.ConnectionString())
            myadapttat.Fill(dstat, "people")
            Dim i As Integer = 0
            For Each temprowtat In dstat.Tables("people").Rows


                If temprowtat.Item("Onoma").ToString <> "" Then
                    users_krit_tat(i, 0) = temprowtat.Item("Onoma").ToString

                    users_krit_tat(i, 1) = temprowtat.Item("ID").ToString
                    i += 1


                End If

            Next
        ElseIf NoRadioButton.Checked <> False Then

            ar_krit = ar_krit + 1
            kritirio_tat_selected = True
            myadapttat = New OleDbDataAdapter(querytatno, cmd.Connection.ConnectionString())
            myadapttat.Fill(dstat, "people")
            Dim i_tat As Integer = 0
            For Each temprowtat In dstat.Tables("people").Rows


                If temprowtat.Item("Onoma").ToString <> "" Then
                    users_krit_tat(i_tat, 0) = temprowtat.Item("Onoma").ToString
                    users_krit_tat(i_tat, 1) = temprowtat.Item("ID").ToString
                    i_tat += 1
                End If


            Next
        End If
        If ErgasiaTextBox.Text <> "" Then
            ar_krit = ar_krit + 1
            kritirio_ergasia_selected = True

            myadaptergasia = New OleDbDataAdapter(query_ergasia, cmd.Connection.ConnectionString())
            myadaptergasia.Fill(dsergasia, "people")

            Dim i As Integer = 0
            For Each temprowergasia In dsergasia.Tables("people").Rows

                If temprowergasia.Item("Onoma").ToString <> "" Then

                    users_krit_ergasia(i, 0) = temprowergasia.Item("Onoma").ToString
                    users_krit_ergasia(i, 1) = temprowergasia.Item("ID").ToString
                    i += 1
                End If
            Next
        End If
        If PerioxhTextBox.Text <> "" Then 'ean exei epilexthei to kritirio perioxh
            ar_krit = ar_krit + 1
            kritirio_perioxh_selected = True

            myadaptperioxh = New OleDbDataAdapter(query_perioxh, cmd.Connection.ConnectionString())
            myadaptperioxh.Fill(dsperioxh, "people")

            Dim i As Integer = 0
            For Each temprowperioxh In dsperioxh.Tables("people").Rows

                If temprowperioxh.Item("Onoma").ToString <> "" Then

                    users_krit_perioxh(i, 0) = temprowperioxh.Item("Onoma").ToString
                    users_krit_perioxh(i, 1) = temprowperioxh.Item("ID").ToString
                    i += 1
                End If
            Next
        End If

        Results.ShowDialog()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ProfileForm.Show()
    End Sub
End Class