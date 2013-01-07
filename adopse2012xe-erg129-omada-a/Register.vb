
Public Class RegisterForm
    Dim ID As Integer = 1
    Private Sub PeopleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)

    End Sub

    Private Sub RegisterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PeopleDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.PeopleDataSet.People)
        Me.PeopleBindingSource.AddNew()

    End Sub

    Private Sub RgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RgButton.Click

        Dim da As New Data.OleDb.OleDbDataAdapter
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim temprow3 As DataRow
        Dim dsNewRow As DataRow

        For Each temprow3 In PeopleDataSet.Tables("people").Rows
            ID = ID + 1
        Next
        dsNewRow = PeopleDataSet.Tables("people").NewRow()
        dsNewRow.Item("ID") = ID
        dsNewRow.Item("Password") = PasswordTextBox.Text
        dsNewRow.Item("Onoma") = OnomaTextBox.Text
        dsNewRow.Item("Epitheto") = EpithetoTextBox.Text
        dsNewRow.Item("Hm_Gennisis") = Hm_GennisisTextBox.Text
        dsNewRow.Item("Baros") = BarosTextBox.Text
        dsNewRow.Item("Ypsos") = YpsosTextBox.Text
        dsNewRow.Item("Fylo") = FyloTextBox.Text
        dsNewRow.Item("Xrwma_Matiwn") = Xrwma_MatiwnTextBox.Text
        dsNewRow.Item("Xrwma_Malliwn") = Xrwma_MalliwnTextBox.Text
        dsNewRow.Item("Hoby1") = Hoby1TextBox.Text
        dsNewRow.Item("Hoby2") = Hoby2TextBox.Text
        dsNewRow.Item("Hoby3") = Hoby3TextBox.Text
        dsNewRow.Item("Anazita") = AnazitaTextBox.Text
        dsNewRow.Item("email") = EmailTextBox.Text
        dsNewRow.Item("Glwssa") = GlwssaTextBox.Text
        dsNewRow.Item("Glwssa2") = Glwssa2TextBox.Text
        dsNewRow.Item("Tatoo") = TatooTextBox.Text
        dsNewRow.Item("Ergasia") = ErgasiaTextBox.Text
        dsNewRow.Item("Perioxh") = PerioxhTextBox.Text

        PeopleDataSet.Tables("people").Rows.Add(dsNewRow)
        'da.Update(PeopleDataSet, "people")

        ID = ID + 1

        Me.Validate()

        'Me.PeopleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet)
        Me.Close()
    End Sub


    Private Sub PasswordTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = "" Then
            PasswordError.Visible = True
            HelpLabel.Visible = True
        Else
            PasswordError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub


    Private Sub EmailTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTextBox.Leave
        If EmailTextBox.Text = "" Then
            EmailError.Visible = True
            HelpLabel.Visible = True
        Else
            EmailError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub OnomaTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnomaTextBox.Leave
        If OnomaTextBox.Text = "" Then
            OnomaError.Visible = True
            HelpLabel.Visible = True

        Else
            OnomaError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub EpithetoTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EpithetoTextBox.Leave
        If EpithetoTextBox.Text = "" Then
            EpithetoError.Visible = True
            HelpLabel.Visible = True
        Else
            EpithetoError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub

    Private Sub Hm_GennisisTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hm_GennisisTextBox.Leave
        If Hm_GennisisTextBox.Text = "" Then
            HmError.Visible = True
            HelpLabel.Visible = True
        Else
            HmError.Visible = False
            HelpLabel.Visible = False
        End If
    End Sub


End Class