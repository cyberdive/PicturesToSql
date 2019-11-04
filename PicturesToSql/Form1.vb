Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Net


Public Class Form1
    Public Tableau_pictures(200000) As clsPicture
    Dim LstFiles As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists("enregistre.bin") = True Then
            Dim f As FileStream = File.Open("enregistre.bin", FileMode.Open)
            Dim s As New BinaryFormatter
            Tableau_pictures = s.Deserialize(f)
            f.Close()
            Dim cpt As Long
            cpt = 0
            For Each elt In Tableau_pictures
                If Not (elt Is Nothing) Then
                    '   LstFile.Rows.Add(elt.NameOffile, elt.PathOfFile, elt.SizeOfFile.ToString, elt.crc)
                    cpt = cpt + 1
                End If

            Next
            MsgBox(cpt.ToString)

        End If
    End Sub


End Class
