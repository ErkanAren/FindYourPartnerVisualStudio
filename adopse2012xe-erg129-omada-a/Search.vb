Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.Common
Public Class Search
    Public Shared ar_krit As Integer = 0 'synolikos arithmos kritiriwn
    Public Shared pet_krit As Integer = 0 'kritiria poy petyxan
    Public Shared onoma_xr As String
    Public loop_count As Integer = 0
    Private Sub PeopleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)

    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PeopleDataSet.People' table. You can move, or remove it, as needed.
        ' Me.PeopleTableAdapter.Fill(Me.PeopleDataSet.People)

    End Sub

    Private Sub SrBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SrBt.Click
        '  Dim con As New SqlConnection("Data Source = '" & Application.StartupPath & "\people.mdb'; prInitial Catalog = people;")
        '  Dim cmd As New SqlCommand("SELECT Onoma FROM people WHERE Baros = 49")
        '  con.Open()

        ' Dim users_krit_baros As String()()
        ' ReDim users_krit_baros(5)(2)
        '  For i = 0 To 5
        '   users_krit_baros(i)(1) = 0
        ' Next
        Dim querybaros1 As String = "SELECT Onoma,Epitheto,Ypsos FROM people WHERE Baros<=55"
        Dim querybaros2 As String = "SELECT Onoma,Epitheto,Ypsos FROM people WHERE Baros>55 AND Baros<=65"
        Dim querybaros3 As String = "SELECT Onoma,Epitheto,Ypsos FROM people WHERE Baros>65 AND Baros<=75"
        Dim querybaros4 As String = "SELECT Onoma,Epitheto,Ypsos FROM people WHERE Baros>75 AND Baros<=85"
        Dim querybaros5 As String = "SELECT Onoma,Epitheto,Ypsos FROM people WHERE Baros>85 AND Baros<=95"
        Dim querybaros6 As String = "SELECT Onoma,Epitheto,Ypsos FROM people WHERE Baros>95"
        Dim cmd As New OleDbCommand
        Dim cn As OleDbConnection = New OleDbConnection
        cn.ConnectionString = My.Settings.peopleConnectionString
        cn.Open()
        cmd.Connection = cn
        Dim myadapt As OleDbDataAdapter ' = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
        Dim temprow As DataRow
        Dim ds As DataSet = New DataSet
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



        End If
        If Hmbox.SelectedItem <> False Then
            ar_krit = ar_krit + 1
        End If


        If Barosbox.SelectedItem <> "" Then ' ean einai epilegmeno to kritirio baros
            ar_krit = ar_krit + 1 ' ayksanei twn arithmo twn epilegmenwn kritiriwn kai..
            If Barosbox.SelectedIndex = 0 Then 'ean exei epilexthei to prwto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros1, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    MessageBox.Show("1 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)

                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next

            ElseIf Barosbox.SelectedIndex = 1 Then 'ean exei epilexthei to deytero item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros2, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    MessageBox.Show("2 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '  users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)

                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 2 Then 'ean exei epilexthei to trito item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros3, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    MessageBox.Show("3 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)

                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 3 Then 'ean exei epilexthei to tetarto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros4, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    MessageBox.Show("4 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)

                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 4 Then 'ean exei epilexthei to pempto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros5, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    MessageBox.Show("5 - " & ((temprow.Item("Onoma").ToString)) & " - " & (temprow.Item("Epitheto").ToString) & ((temprow.Item("Ypsos")).ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)

                    ' If arr(i).Length <> 0 Then
                    '  users_krit_baros(i)(1) += 1
                    'End If

                Next
            ElseIf Barosbox.SelectedIndex = 5 Then 'ean exei epilexthei to ekto item toy kritiriou baros
                myadapt = New OleDbDataAdapter(querybaros6, cmd.Connection.ConnectionString())
                myadapt.Fill(ds, "people")
                Dim i As Integer = 0
                For Each temprow In ds.Tables("people").Rows
                    MessageBox.Show("6 - " & (temprow.Item("Onoma").ToString) & " - " & (temprow.Item("Epitheto").ToString))
                    '   users_krit_baros(i)(0) = (temprow.Item("Onoma").ToString)

                    ' If arr(i).Length <> 0 Then
                    ' users_krit_baros(i)(1) += 1
                    'End If

                Next
            End If


        End If
        If Ypsosbox.SelectedText <> "" Then
            ar_krit = ar_krit + 1
        End If
        If MaleCheck.Checked() <> True Then
            ar_krit = ar_krit + 1
        Else
            ar_krit = ar_krit + 1
        End If
        If Xrmatbox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If Xrmalbox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If Hoby1TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If Hoby2TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If Hoby3TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If ManCheck.Checked <> True Then
            ar_krit = ar_krit + 1
        Else
            ar_krit = ar_krit + 1
        End If
        If GlwssaTextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If Glwssa2TextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If TatooCheck.Checked <> False Then
            ar_krit = ar_krit + 1
        End If
        If ErgasiaTextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If
        If PerioxhTextBox.Text <> "" Then
            ar_krit = ar_krit + 1
        End If

        Results.ShowDialog()
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ManCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManCheck.CheckedChanged

    End Sub
End Class