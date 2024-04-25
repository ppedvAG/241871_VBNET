Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim url = $"https://www.googleapis.com/books/v1/volumes?q={TextBox1.Text}&orderBy=newest&maxResults=40"

        Dim http = New HttpClient()
        Dim json = Await http.GetStringAsync(url)

        Dim br = JsonConvert.DeserializeObject(Of BooksResult)(json)

        DataGridView1.DataSource = br.items.Select(Function(x) x.volumeInfo).ToList()

    End Sub
End Class
