Public Class Edit
    Public Shared editclicked As Boolean = False
    

    Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PeopleDataSet.People' table. You can move, or remove it, as needed.
        Me.PeopleTableAdapter.Fill(Me.PeopleDataSet.People)

        IDTextBox.Text = Login.ID
        EmailTextBox.Text = Login.username1
        OnomaTextBox.Text = Login.onoma1
        EpithetoTextBox.Text = Login.epitheto1
        Hm_GennisisTextBox.Text = Login.hmergen1
        PerioxhTextBox.Text = Login.perioxh1
        ErgasiaTextBox.Text = Login.ergasia1
        BarosTextBox.Text = Login.baros
        YpsosTextBox.Text = Login.ypsos
        FyloTextBox.Text = Login.fylo
        Xrwma_MalliwnTextBox.Text = Login.xr_maliwn
        Xrwma_MatiwnTextBox.Text = Login.xr_matiwn
        Hoby1TextBox.Text = Login.hoby1
        Hoby2TextBox.Text = Login.hoby2
        Hoby3TextBox.Text = Login.hoby3
        AnazitaTextBox.Text = Login.anazita
        GlwssaTextBox.Text = Login.glwssa1
        Glwssa2TextBox.Text = Login.glwssa2
        TatooTextBox.Text = Login.tatoo



    End Sub

    Private Sub EditBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBt.Click
        Dim peopleRow As Data.DataRow
        peopleRow = PeopleDataSet.People.FindByID(IDTextBox.Text) 'ananewnei tis times toy dataset

        peopleRow(2) = OnomaTextBox.Text
        peopleRow(3) = EpithetoTextBox.Text
        peopleRow(4) = Hm_GennisisTextBox.Text
        peopleRow(5) = BarosTextBox.Text
        peopleRow(6) = YpsosTextBox.Text
        peopleRow(7) = FyloTextBox.Text
        peopleRow(8) = Xrwma_MatiwnTextBox.Text
        peopleRow(9) = Xrwma_MalliwnTextBox.Text
        peopleRow(10) = Hoby1TextBox.Text
        peopleRow(11) = Hoby2TextBox.Text
        peopleRow(12) = Hoby3TextBox.Text
        peopleRow(13) = AnazitaTextBox.Text
        peopleRow(14) = EmailTextBox.Text
        peopleRow(15) = GlwssaTextBox.Text
        peopleRow(16) = Glwssa2TextBox.Text
        peopleRow(17) = TatooTextBox.Text
        peopleRow(18) = ErgasiaTextBox.Text
        peopleRow(19) = PerioxhTextBox.Text

        Me.TableAdapterManager.UpdateAll(Me.PeopleDataSet) 'ananewsi tis vasis apo to dataset

        editclicked = True
        'Me.Close()
        Me.Hide()
        ProfileForm.Show()
    End Sub
End Class