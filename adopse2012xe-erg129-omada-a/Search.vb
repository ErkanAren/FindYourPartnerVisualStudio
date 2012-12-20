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
        Dim arr As String()
        ReDim arr(5)
        Dim query As String = "SELECT Onoma FROM people WHERE Baros<55"
        Dim cmd As New OleDbCommand
        Dim cn As OleDbConnection = New OleDbConnection
        cn.ConnectionString = My.Settings.peopleConnectionString
        cn.Open()
        cmd.Connection = cn
        Dim myadapt As OleDbDataAdapter = New OleDbDataAdapter(query, cmd.Connection.ConnectionString())
        Dim temprow As DataRow
        Dim ds As DataSet = New DataSet
        myadapt.Fill(ds, "people")
        Dim i As Integer = 0
        For Each temprow In ds.Tables("people").Rows

            arr(i) = (temprow.Item("Onoma").ToString)
            i += 1
        Next

        For j = 0 To arr.Length
            MessageBox.Show(arr(j))
        Next j
        onoma_xr = (ds.Tables(0).Rows(0).Item(0))
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


        If Barosbox.SelectedItem <> "" Then
            ar_krit = ar_krit + 1
            pet_krit += 1
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