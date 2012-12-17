Imports System.Data.OleDb

Public Class Login



    Private Sub RegisterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterButton.Click
        'Me.Close()
        RegisterForm.ShowDialog()


    End Sub

    Dim errorstr As String

    Public Function Login()
        Dim DBcon As New ADODB.Connection

        Dim User As New ADODB.Recordset

        Dim username As String
        Dim userdb As String
        Dim passdb As String

        Dim userfound As Boolean
        DBcon.Open("Provider=Microsoft.Jet.OLEDB.4.0;" & _
                   "Data source = '" & Application.StartupPath & "\people.mdb'")

        User.Open("people", DBcon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        userfound = False
        Login = False
        username = "email='" & UserNameText.Text & "'"

        Do
            User.Find(username)
            If User.BOF = False And User.EOF = False Then
                userdb = User.Fields("email").Value.ToString
                passdb = User.Fields("Password").Value.ToString

                If userdb <> UserNameText.Text Then
                    User.MoveNext()
                Else
                    userfound = True
                    If passdb <> PasswordText.Text Then
                        User.Close()
                        DBcon.Close()
                        errorstr = "Invalid password"
                        Return False
                    Else

                        Return True
                    End If
                End If
            Else
                errorstr = "Invalid username"
                User.Close()
                DBcon.Close()
                Return False

            End If
        Loop Until userfound = True


        User.Close()
        DBcon.Close()
        Return False

    End Function

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        If Login() = True Then
            ProfileForm.Show()
        Else
            MessageBox.Show(errorstr)
        End If


        
    End Sub

    

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class