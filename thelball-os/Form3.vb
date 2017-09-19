Imports System.IO
Imports System.Text
Imports System.Net

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim address As String = "https://icebergcp.com/version.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label2.Text = reader.ReadToEnd()
    End Sub
End Class