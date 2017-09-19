Imports System.IO
Imports System.Text
Imports System.Net

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim address As String = "https://icebergcp.com/version.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Dim version As Integer = "0.1"
        Dim update As Integer = reader.ReadToEnd
        If update > version Then
            Form3.Visible = True
            Close()
        End If
        If update < version Then
            Label1.Text = "this is the future"
            Label2.Text = "plz close"
            Button1.Visible = True
        End If
        If update = version Then
            Label1.Text = "You're up to date!"
            Label2.Text = "plz enjoy :)"
            Button1.Visible = True
        End If
    End Sub
End Class