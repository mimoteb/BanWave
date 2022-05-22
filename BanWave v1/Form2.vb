
Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form2
    Dim StartTime As String
    Dim EndTime As String
    Dim ApiLink As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DownloadFame_Click(sender As Object, e As EventArgs) Handles DownloadFame.Click
        Out.Text = ""
        TextBox1.Text = ""
        StartTime = Now.ToString("dd.MM.yyyy-HH:mm")
        DownloadFame.Enabled = False
        Dim iPages As XmlDocument
        Try
            iPages = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&fields=account_id&limit=100&page_no=1")
            page_total = iPages.ChildNodes(0).ChildNodes(1).ChildNodes(1).InnerText
        Catch ex As Exception

        End Try


        For pi As Integer = 1 To page_total
            Out.AppendText("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&fields=account_id&limit=100&page_no=" & pi & vbCrLf)
            ' Dim api As XmlDocument = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&fields=account_id&limit=100&page_no=" & pi)
            ' Dim sw As New StreamWriter("banwave\" & pi & ".xml", False)
            ' Out.AppendText(api.OuterXml)
            ' sw.Write(api.OuterXml)
            '  sw.Close()
        Next
        For Each line As String In Out.Lines
            Dim str As String
            Try

                Using client As New Net.WebClient
                    client.Encoding = Encoding.UTF8
                    str = client.DownloadStringAsync(New Uri(line))
                End Using
                TextBox1.AppendText(Json2XML(str).OuterXml & vbCrLf)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        Next
        EndTime = Now.ToString("dd.MM.yyyy-HH:mm")
        MsgBox("Done!" & vbCrLf & "start: " & StartTime & vbCrLf & "end: " & EndTime)
        DownloadFame.Enabled = True
    End Sub
End Class