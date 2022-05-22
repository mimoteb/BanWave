Imports System.IO
Imports System.Xml

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
    End Sub

    Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        data.Width = Me.Width - 35
        data.Height = Me.Height - 100
    End Sub

    Private Sub GetButton_Click(sender As Object, e As EventArgs) Handles TakeSnapButton.Click
        On Error Resume Next
        starttime = Now.ToString("dd.MM.yyyy-HH:mm")
        TakeSnapButton.Enabled = False
        data.Rows.Clear()
        Dim ipages As XmlDocument = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&in_rating=1&limit=100&page_no=1")
        page_total = ipages.ChildNodes(0).ChildNodes(1).ChildNodes(1).InnerText
        For pi As Integer = 1 To page_total + 1

            Dim api As XmlDocument = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&in_rating=1&limit=100&page_no=" & pi)
            Dim i As Integer = 0
            For Each node As XmlNode In api.ChildNodes(0)
                If i > 1 Then

                    rank = node.ChildNodes(0).InnerText
                    award_level = node.ChildNodes(1).InnerText
                    account_id = node.ChildNodes(2).InnerText
                    event_id = node.ChildNodes(3).InnerText
                    rank_delta = node.ChildNodes(4).InnerText
                    fame_points_to_improve_award = node.ChildNodes(5).InnerText
                    updated_at = node.ChildNodes(6).InnerText
                    battles = node.ChildNodes(7).InnerText
                    clan_rank = node.ChildNodes(8).InnerText
                    clan_id = node.ChildNodes(9).InnerText
                    url = node.ChildNodes(10).InnerText
                    battles_to_award = node.ChildNodes(11).InnerText
                    fame_points = node.ChildNodes(12).InnerText
                    front_id = node.ChildNodes(13).InnerText

                    NickName = "" '  GetNickName(account_id)
                    ClanName = "" ' GetClanName(clan_id)
                    ' data.Rows.Add(rank, award_level, account_id, event_id, rank_delta, fame_points_to_improve_award, updated_at, battles, clan_rank, clan_id, url, battles_to_award, fame_points, front_id, NickName, ClanName, apiRealm, Now.ToString("dd.MM.yyyy"))
                    cmd.CommandText = "insert into snapshot values(@rank,@award_level,@account_id,@event_id,@rank_delta,@fame_points_to_improve_award,@updated_at,@battles,@clan_rank,@clan_id,@url,@battles_to_award,@fame_points,@front_id,@page_total,@nickname,@clanname,@server,@date)"
                    cmd.Parameters.AddWithValue("@rank", rank)
                    cmd.Parameters.AddWithValue("@award_level", award_level)
                    cmd.Parameters.AddWithValue("@account_id", account_id)
                    cmd.Parameters.AddWithValue("@event_id", event_id)
                    cmd.Parameters.AddWithValue("@rank_delta", rank_delta)
                    cmd.Parameters.AddWithValue("@fame_points_to_improve_award", fame_points_to_improve_award)
                    cmd.Parameters.AddWithValue("@updated_at", updated_at)
                    cmd.Parameters.AddWithValue("@battles", battles)
                    cmd.Parameters.AddWithValue("@clan_rank", clan_rank)
                    cmd.Parameters.AddWithValue("@clan_id", clan_id)
                    cmd.Parameters.AddWithValue("@url", url)
                    cmd.Parameters.AddWithValue("@battles_to_award", battles_to_award)
                    cmd.Parameters.AddWithValue("@fame_points", fame_points)
                    cmd.Parameters.AddWithValue("@front_id", front_id)
                    cmd.Parameters.AddWithValue("@page_total", page_total)
                    cmd.Parameters.AddWithValue("@nickname", NickName)
                    cmd.Parameters.AddWithValue("@clanname", ClanName)
                    cmd.Parameters.AddWithValue("@server", apiRealm)
                    cmd.Parameters.AddWithValue("@date", Now.ToString("dd.MM.yyyy"))
                    cmd.ExecuteNonQuery()
                    Me.Text = "pages :" & page_total & " current page: " & pi & " total players added: " & data.Rows.Count & " start: " & starttime
                End If
                i += 1
            Next
        Next
        endtime = Now.ToString("dd.MM.yyyy-HH:mm")
        MsgBox("Done!" & vbCrLf & "start: " & starttime & vbCrLf & "end: " & endtime)
        TakeSnapButton.Enabled = True
        TotalRecordsLabel.Text = "Records: " & data.Rows.Count
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles ViewDatabaseButton.Click
        data.Rows.Clear()
        cmd.CommandText = "select * from snapshot where nickname=''"
        Reader = cmd.ExecuteReader
        While Reader.Read
            data.Rows.Add(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4), Reader.GetString(5), Reader.GetString(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(9), Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetString(14), Reader.GetString(15), Reader.GetString(16), Reader.GetString(17), Reader.GetString(18))
        End While
        Reader.Close()
        TotalRecordsLabel.Text = "Records: " & data.Rows.Count
    End Sub

    Private Sub UpdateNamesButton_Click(sender As Object, e As EventArgs) Handles UpdateNamesButton.Click
        Progress.Maximum = data.Rows.Count
        Do While data.Rows.Count > 0
            cmd.CommandText = "update snapshot set nickname=@nickname, clanname=@clanname where account_id=@account_id"
            cmd.Parameters.AddWithValue("nickname", GetNickName(data.Rows(0).Cells(2).Value))
            cmd.Parameters.AddWithValue("@clanname", GetClanName(data.Rows(0).Cells(9).Value))
            cmd.Parameters.AddWithValue("@account_id", data.Rows(0).Cells(2).Value)
            cmd.ExecuteNonQuery()
            data.Rows.RemoveAt(0)
            TotalRecordsLabel.Text = "Records: " & data.Rows.Count
            Me.Refresh()
            Progress.Value = Progress.Maximum - data.Rows.Count
        Loop

    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

        starttime = Now.ToString("dd.MM.yyyy-HH:mm")
        CheckButton.Enabled = False
        data.Rows.Clear()
        Dim ipages As XmlDocument = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&in_rating=1&limit=100&page_no=1")
        page_total = ipages.ChildNodes(0).ChildNodes(1).ChildNodes(1).InnerText
        For pi As Integer = 1 To page_total + 1

            Dim api As XmlDocument = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&in_rating=1&limit=100&page_no=" & pi)
            Dim sw As New StreamWriter("banwave\" & pi & ".xml", False)
            sw.Write(api.OuterXml)
            sw.Close()
        Next
        endtime = Now.ToString("dd.MM.yyyy-HH:mm")
        MsgBox("Done!" & vbCrLf & "start: " & starttime & vbCrLf & "end: " & endtime)
        CheckButton.Enabled = True
        TotalRecordsLabel.Text = "Records: " & data.Rows.Count
    End Sub

    Private Sub CompareButton_Click(sender As Object, e As EventArgs) Handles CompareButton.Click
        On Error Resume Next
        Dim progressCount As Integer = 0
        For Each fil As String In Directory.GetFiles("banwave\")

            Dim api As New XmlDocument
            api.Load(My.Application.Info.DirectoryPath & "\" & fil)
            Dim i As Integer = 0
            For Each node As XmlNode In api.ChildNodes(0)
                If i > 1 Then

                    rank = node.ChildNodes(0).InnerText
                    award_level = node.ChildNodes(1).InnerText
                    account_id = node.ChildNodes(2).InnerText
                    event_id = node.ChildNodes(3).InnerText
                    rank_delta = node.ChildNodes(4).InnerText
                    fame_points_to_improve_award = node.ChildNodes(5).InnerText
                    updated_at = node.ChildNodes(6).InnerText
                    battles = node.ChildNodes(7).InnerText
                    clan_rank = node.ChildNodes(8).InnerText
                    clan_id = node.ChildNodes(9).InnerText
                    url = node.ChildNodes(10).InnerText
                    battles_to_award = node.ChildNodes(11).InnerText
                    fame_points = node.ChildNodes(12).InnerText
                    front_id = node.ChildNodes(13).InnerText

                    NickName = "" '  GetNickName(account_id)
                    ClanName = "" ' GetClanName(clan_id)
                    ' data.Rows.Add(rank, award_level, account_id, event_id, rank_delta, fame_points_to_improve_award, updated_at, battles, clan_rank, clan_id, url, battles_to_award, fame_points, front_id, NickName, ClanName, apiRealm, Now.ToString("dd.MM.yyyy"))
                    cmd.CommandText = "insert into compare values(@rank,@award_level,@account_id,@event_id,@rank_delta,@fame_points_to_improve_award,@updated_at,@battles,@clan_rank,@clan_id,@url,@battles_to_award,@fame_points,@front_id,@page_total,@nickname,@clanname,@server,@date)"
                    cmd.Parameters.AddWithValue("@rank", rank)
                    cmd.Parameters.AddWithValue("@award_level", award_level)
                    cmd.Parameters.AddWithValue("@account_id", account_id)
                    cmd.Parameters.AddWithValue("@event_id", event_id)
                    cmd.Parameters.AddWithValue("@rank_delta", rank_delta)
                    cmd.Parameters.AddWithValue("@fame_points_to_improve_award", fame_points_to_improve_award)
                    cmd.Parameters.AddWithValue("@updated_at", updated_at)
                    cmd.Parameters.AddWithValue("@battles", battles)
                    cmd.Parameters.AddWithValue("@clan_rank", clan_rank)
                    cmd.Parameters.AddWithValue("@clan_id", clan_id)
                    cmd.Parameters.AddWithValue("@url", url)
                    cmd.Parameters.AddWithValue("@battles_to_award", battles_to_award)
                    cmd.Parameters.AddWithValue("@fame_points", fame_points)
                    cmd.Parameters.AddWithValue("@front_id", front_id)
                    cmd.Parameters.AddWithValue("@page_total", page_total)
                    cmd.Parameters.AddWithValue("@nickname", NickName)
                    cmd.Parameters.AddWithValue("@clanname", ClanName)
                    cmd.Parameters.AddWithValue("@server", apiRealm)
                    cmd.Parameters.AddWithValue("@date", Now.ToString("dd.MM.yyyy"))
                    cmd.ExecuteNonQuery()

                    TotalRecordsLabel.Text = "Records: " & progressCount
                    Me.Refresh()
                End If
                i += 1
                progressCount += 1
            Next
        Next


    End Sub
End Class
