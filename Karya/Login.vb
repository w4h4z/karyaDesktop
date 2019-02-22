Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim responsebody
        Dim json As JObject
        Using client As New Net.WebClient
            Dim reqparm As New Specialized.NameValueCollection
            reqparm.Add("npm", txtNPM.Text)
            reqparm.Add("password", txtPw.Text)
            Dim responsebytes = client.UploadValues("http://localhost/ci_sihim/index.php/auth/do_login", "POST", reqparm)
            responsebody = (New Text.UTF8Encoding).GetString(responsebytes)
            Dim blah As String = client.DownloadString("http://localhost/ci_sihim/index.php/auth/do_login")
            json = JObject.Parse(responsebody)
        End Using

        If json.SelectToken("status") Then
            Main.Show()
            Me.Hide()
            txtNPM.Text = ""
            txtPw.Text = ""
        Else
            MsgBox("NPM atau Password Salah!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class