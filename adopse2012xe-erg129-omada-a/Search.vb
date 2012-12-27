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
    Public Shared users_krit_onoma As String(,)
    Public Shared all_users As String(,)
    Public Shadows pedio As String
    Public Shadows kritirio_varos_selected As Boolean = False
    Public Shadows kritirio_hmgen_selected As Boolean = False
    Public Shadows kritirio_tat_selected As Boolean = False
    Public Shared kritirio_ypsos_selected As Boolean = False
    Public Shared kritirio_xrmat_selected As Boolean = False
    Public Shared kritirio_onoma_selected As Boolean = False

    Public Shared db_count As Integer = 33 'database length (tha allaksei...)


    Private Sub PeopleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)

    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PeopleDataSet.People' table. You can move, or remove it, as needed.
        ' Me.PeopleTableAdapter.Fill(Me.PeopleDataSet.People)
        Dim all_dbusers As String = "SELECT Onoma,ID FROM people"
        ReDim all_users(db_count, 3)
        Dim cmd2 As New OleDbCommand
        Dim cn2 As OleDbConnection = New OleDbConnection
        cn2.ConnectionString = My.Settings.peopleConnectionString
        cn2.Open()
        cmd2.Connection = cn2
        Dim myadapt2 As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        ' Dim myadapttat As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        Dim temprow2 As DataRow
        Dim ds2 As DataSet = New DataSet
        For k = 0 To db_count
            all_users(k, 0) = ""
            all_users(k, 1) = ""
            all_users(k, 2) = 0
        Next
        myadapt2 = New OleDbDataAdapter(all_dbusers, cmd2.Connection.ConnectionString())
        myadapt2.Fill(ds2, "people")
        Dim i As Integer = 0
        For Each temprow2 In ds2.Tables("people").Rows
            ' MessageBox.Show("1 - " & (temprow2.Item("Onoma").ToString) & " - " & (temprow2.Item("Epitheto").ToString))
            '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
            ' If i < db_count Then
            all_users(i, 0) = temprow2.Item("Onoma").ToString
            all_users(i, 1) = temprow2.Item("ID").ToString

            '  all_users(i, 2) = temprow2.Item("ID").ToString
            i += 1
            '  End If
            ' If arr(i).Length <> 0 Then
            '  users_krit_baros(i)(1) += 1
            'End If

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
        ReDim users_krit_onoma(db_count, 2)

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
        Dim query_onoma As String = "SELECT Onoma,Epitheto,ID FROM people WHERE Onoma='" & OnomaTextBox.Text & "'"


        Dim cmd As New OleDbCommand
        Dim cn As OleDbConnection = New OleDbConnection
        cn.ConnectionString = My.Settings.peopleConnectionString
        cn.Open()
        cmd.Connection = cn
        Dim myadapt As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        Dim myadaptbaros As OleDbDataAdapter
        Dim myadapttat As OleDbDataAdapter
        Dim myadapthmgen As OleDbDataAdapter
        Dim myadaptypsos As OleDbDataAdapter
        Dim myadaptxr_mat As OleDbDataAdapter
        Dim myadaptonoma As OleDbDataAdapter


        ' Dim myadapttat As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        Dim temprow As DataRow
        Dim ds As DataSet = New DataSet

        Dim temprowtat As DataRow
        Dim dstat As DataSet = New DataSet

        Dim temprowhm As DataRow
        Dim dshm As DataSet = New DataSet

        Dim temprowxr_mat As DataRow
        Dim dsxr_mat As DataSet = New DataSet

        Dim temprowonoma As DataRow
        Dim dsonoma As DataSet = New DataSet

        Dim temprowypsos As DataRow
        Dim dsypsos As DataSet = New DataSet
        '  Dim dstat As DataSet = New DataSet
        ' myadapt.Fill(ds, "people")



        ' For j = 0 To arr.Length
        'MessageBox.Show(arr(j))
        '  Next j
        '  onoma_xr = (ds.Tables(0).Rows(0).Item(0))
        'Catch ex As Exception
        'MessageBox.Show("haiii")
        ' End Try

        '  MessageBox.Show(cmd.ToString.ToString)
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
                        'MessageBox.Show("HmGen onoma= " & temprowhm.Item("Onoma").ToString)
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
                '  MessageBox.Show("1 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                ' If i < db_count Then
                If temprowhm.Item("Onoma").ToString <> "" Then
                    users_krit_hmgen(i, 0) = temprowhm.Item("Onoma").ToString
                    'users_krit_hmgen(i, 1) = users_krit_hmgen(i, 1) + 1
                    users_krit_hmgen(i, 1) = temprowhm.Item("ID").ToString
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
                    ' MessageBox.Show("1 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    '  If i < 5 Then
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    '  users_krit_baros(i, 1) = users_krit_baros(i, 1) + 1
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString
                    '   users_krit_baros(i, 2) = temprow.Item("ID").ToString
                    i += 1
                    '  End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
                '  For i = 0 To 5

                '  Next

            ElseIf Barosbox.SelectedIndex = 1 Then 'ean exei epilexthei to deytero item toy kritiriou baros

                myadapt = New OleDbDataAdapter(querybaros2, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    ' MessageBox.Show("2 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '  users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    '  If i < 5 Then
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    '  users_krit_baros(i, 1) = users_krit_baros(i, 1) + 1
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString
                    '      users_krit_baros(i, 2) = temprow.Item("ID").ToString
                    i += 1
                    '  End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 2 Then 'ean exei epilexthei to trito item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros3, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    '    MessageBox.Show("3 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    '  If i < 5 Then
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    'users_krit_baros(i, 1) = users_krit_baros(i, 1) + 1
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString
                    '   users_krit_baros(i, 2) = temprow.Item("ID").ToString
                    i += 1
                    '  End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 3 Then 'ean exei epilexthei to tetarto item toy kritiriou baros
                myadaptbaros = New OleDbDataAdapter(querybaros4, cmd.Connection.ConnectionString())
                myadaptbaros.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    '  MessageBox.Show("4 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    '  If i < 5 Then
                    If temprow.Item("Onoma").ToString <> "" Then
                        users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                        ' users_krit_baros(i, 1) = users_krit_baros(i, 1) + 1
                        ' MessageBox.Show("4 - " & (temprow.Item("Onoma").ToString) & "-" & temprow.Item("Onoma").ToString & "-" & users_krit_baros(i, 1))
                        users_krit_baros(i, 1) = temprow.Item("ID").ToString
                        i += 1
                    End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 4 Then 'ean exei epilexthei to pempto item toy kritiriou baros
                myadaptbaros = New OleDbDataAdapter(querybaros5, cmd.Connection.ConnectionString())
                myadaptbaros.Fill(ds, "people")

                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    '  MessageBox.Show("5 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   MessageBox.Show("5 - " & ((temprow.Item("Onoma").ToString)) & " - " & (temprow.Item("Epitheto").ToString) & ((temprow.Item("Ypsos")).ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    ' If i < 5 Then
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    ' users_krit_baros(i, 1) = users_krit_baros(i, 1) + 1
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString
                    '     users_krit_baros(i, 2) = temprow.Item("ID").ToString
                    i += 1
                    '   End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 5 Then 'ean exei epilexthei to ekto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros6, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    '  MessageBox.Show("6 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                    '  If i < 5 Then
                    users_krit_baros(i, 0) = temprow.Item("Onoma").ToString
                    ' users_krit_baros(i, 1) = users_krit_baros(i, 1) + 1
                    users_krit_baros(i, 1) = temprow.Item("ID").ToString
                    '      users_krit_baros(i, 2) = temprow.Item("ID").ToString
                    i += 1
                    ' End If
                    ' If arr(i).Length <> 0 Then
                    ' users_krit_baros(i)(1) += 1
                    'End If

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


        If MaleCheck.Checked() = True Then
            MessageBox.Show("MaleCheck.Checked()")
            ar_krit = ar_krit + 1
        ElseIf FemaleCheck.Checked() = True Then
            MessageBox.Show("FemaleCheck.Checked()")
            ar_krit = ar_krit + 1
        End If
        If Xrmatbox.Text <> "" Then 'ean exei epilexthei to kritirio xrwmA matiwn
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
            MessageBox.Show("Xrmalbox.Text")
            ar_krit = ar_krit + 1
        End If
        If Hoby1TextBox.Text <> "" Then
            MessageBox.Show("Hoby1TextBox.Text")
            ar_krit = ar_krit + 1
        End If
        If Hoby2TextBox.Text <> "" Then
            MessageBox.Show("Hoby2TextBox.Text")
            ar_krit = ar_krit + 1
        End If
        If Hoby3TextBox.Text <> "" Then
            MessageBox.Show("Hoby3TextBox.Text")
            ar_krit = ar_krit + 1
        End If
        If ManCheck.Checked = True Then
            MessageBox.Show("ManCheck.Checked")
            ar_krit = ar_krit + 1
        ElseIf WomanCheck.Checked = True Then
            MessageBox.Show("WomanCheck.Checked")
            ar_krit = ar_krit + 1
        End If
        If GlwssaTextBox.Text <> "" Then
            MessageBox.Show("GlwssaTextBox.Text")
            ar_krit = ar_krit + 1
        End If
        If Glwssa2TextBox.Text <> "" Then
            MessageBox.Show("Glwssa2TextBox.Text")
            ar_krit = ar_krit + 1
        End If
        If TatooCheckYes.Checked <> False Then
            MessageBox.Show("TatooCheck.Checked")
            ar_krit = ar_krit + 1
            kritirio_tat_selected = True
            myadapttat = New OleDbDataAdapter(querytatyes, cmd.Connection.ConnectionString())
            myadapttat.Fill(dstat, "people")
            Dim i As Integer = 0
            For Each temprowtat In dstat.Tables("people").Rows
                '  MessageBox.Show("5 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                '   MessageBox.Show("5 - " & ((temprow.Item("Onoma").ToString)) & " - " & (temprow.Item("Epitheto").ToString) & ((temprow.Item("Ypsos")).ToString))
                '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                If i < 5 Then
                    If temprowtat.Item("Onoma").ToString <> "" Then
                        users_krit_tat(i, 0) = temprowtat.Item("Onoma").ToString
                        ' users_krit_tat(i, 1) = users_krit_tat(i, 1) + 1
                        users_krit_tat(i, 1) = temprowtat.Item("ID").ToString
                        i += 1
                    End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                End If

            Next
        ElseIf TatooCheckNo.Checked <> False Then
            'MessageBox.Show("TatooCheck.Checked")
            ar_krit = ar_krit + 1
            kritirio_tat_selected = True
            myadapttat = New OleDbDataAdapter(querytatno, cmd.Connection.ConnectionString())
            myadapttat.Fill(dstat, "people")
            Dim i_tat As Integer = 0
            For Each temprowtat In dstat.Tables("people").Rows
                '  MessageBox.Show("5 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                '   MessageBox.Show("5 - " & ((temprow.Item("Onoma").ToString)) & " - " & (temprow.Item("Epitheto").ToString) & ((temprow.Item("Ypsos")).ToString))
                '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)
                If i_tat < 5 Then
                    If temprowtat.Item("Onoma").ToString <> "" Then
                        users_krit_tat(i_tat, 0) = temprowtat.Item("Onoma").ToString
                        '  users_krit_tat(i_tat, 1) = users_krit_tat(i_tat, 1) + 1
                        users_krit_tat(i_tat, 1) = temprowtat.Item("ID").ToString
                        i_tat += 1
                    End If
                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                End If

            Next
        End If
        If ErgasiaTextBox.Text <> "" Then
            MessageBox.Show("ErgasiaTextBox.Text")
            ar_krit = ar_krit + 1
        End If
        If PerioxhTextBox.Text <> "" Then
            MessageBox.Show("PerioxhTextBox.Text")
            ar_krit = ar_krit + 1
        End If

        Results.ShowDialog()
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ManCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManCheck.CheckedChanged

    End Sub
End Class