Partial Class peopleDataSet
    Partial Class PeopleDataTable

        Private Sub PeopleDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PasswordColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
