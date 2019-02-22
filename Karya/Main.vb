Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim result As Integer = MessageBox.Show("Apakah anda yakin mendaftar Puasa?", "Daftar Puasa", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("Yes pressed")
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim result As Integer = MessageBox.Show("Apakah anda yakin mendaftar Izin Bermalam?", "Daftar Izin Bermalam", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("Yes pressed")
        End If
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://localhost/ci_sihim/index.php/senat/getib")

        'Dim jsonString As JArray = JArray.Parse(result)

        'Dim json As JObject = JObject.Parse(result)
        'MsgBox(json.SelectToken("nama").ToString)
        'MsgBox(jsonString.ToString)

        'Dim json As String = rawresp
        Dim jsonObject As JArray = JArray.Parse(result)
        MsgBox(jsonObject.ToString)
        'Dim jsonArray As JArray = jsonObject("result")

        'For Each item As JObject In jsonArray
        'TextBox1.Text = item.SelectToken("nama").ToString
        'Next
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs)
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub

    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.Close()
        Login.Show()
    End Sub
End Class
