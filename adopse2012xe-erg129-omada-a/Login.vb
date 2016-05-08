Imports System.Data.OleDb

Public Class Login
    Public Shared ID As String
    Public Shared username1 As String
    Public Shared epitheto1 As String
    Public Shared hmergen1 As Integer
    Public Shared perioxh1 As String
    Public Shared ergasia1 As String
    Public Shared onoma1 As String
    Public Shared baros As Integer
    Public Shared ypsos As Integer
    Public Shared xr_maliwn As String
    Public Shared xr_matiwn As String
    Public Shared hoby1 As String
    Public Shared hoby2 As String
    Public Shared hoby3 As String
    Public Shared fylo As String
    Public Shared anazita As String
    Public Shared glwssa1 As String
    Public Shared glwssa2 As String
    Public Shared tatoo As String



    Private Sub RegisterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterButton.Click
        'Me.Close()
        RegisterForm.ShowDialog()



    End Sub

    Dim errorstr As String 'tha xrisimopoihthei gia emfanisi sfalmatwn

    Public Function Login()
        Dim DBcon As New ADODB.Connection

        Dim User As New ADODB.Recordset

        Dim username As String
        Dim userdb As String
        Dim passdb As String

        Dim userfound As Boolean 'ean vrethei o user ginetai true
        DBcon.Open("Provider=Microsoft.Jet.OLEDB.4.0;" & _
                   "Data source = '" & Application.StartupPath & "\people.mdb'")

        User.Open("people", DBcon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        userfound = False
        Login = False
        username = "email='" & UserNameText.Text & "'" 'to onoma toy pediou sti vasi + UserNameText.Text

        Do
            User.Find(username) 'vres ton user me email= username!!
            If User.BOF = False And User.EOF = False Then ' synthiki egkyrotitas gia to username
                userdb = User.Fields("email").Value.ToString
                passdb = User.Fields("Password").Value.ToString 'kataxwrish timwn toy user poy ekane login apo ti vasi stis public shared metavlites
                username1 = userdb
                ID = User.Fields("ID").Value.ToString
                onoma1 = User.Fields("Onoma").Value.ToString
                epitheto1 = User.Fields("Epitheto").Value.ToString
                ergasia1 = User.Fields("Ergasia").Value.ToString
                perioxh1 = User.Fields("Perioxh").Value.ToString
                hmergen1 = User.Fields("Hm_Gennisis").Value.ToString
                fylo = User.Fields("Fylo").Value.ToString
                baros = User.Fields("Baros").Value.ToString
                ypsos = User.Fields("Ypsos").Value.ToString
                xr_maliwn = User.Fields("Xrwma_Malliwn").Value.ToString
                xr_matiwn = User.Fields("Xrwma_Matiwn").Value.ToString
                hoby1 = User.Fields("Hoby1").Value.ToString
                hoby2 = User.Fields("Hoby2").Value.ToString
                hoby3 = User.Fields("Hoby3").Value.ToString
                anazita = User.Fields("Anazita").Value.ToString
                glwssa1 = User.Fields("Glwssa").Value.ToString
                glwssa2 = User.Fields("Glwssa2").Value.ToString
                tatoo = User.Fields("Tatoo").Value.ToString

                '  If userdb <> UserNameText.Text Then
                'User.MoveNext()

                '  Else
                userfound = True 'o xristis vrethike
                If passdb <> PasswordText.Text Then 'ean to password poy evale o xristis einai diaforo toy password toy xristi
                    User.Close()
                    DBcon.Close()
                    errorstr = "Invalid password"
                    Return False
                Else

                    Return True 'epistrefei true apo tin methodo Login
                End If
                'End If
            Else 'ean den exei vrethei o xristis
                errorstr = "Invalid username"
                User.Close()
                DBcon.Close()
                Return False

            End If 'if eof bof
        Loop Until userfound = True ' ektelesi toy block mexri na vrethei o xristis


        User.Close()
        DBcon.Close()
        Return False

    End Function

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        If Login() = True Then
            ProfileForm.Show()
            Me.Hide()
        Else
            MessageBox.Show(errorstr)
        End If



    End Sub



 
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class