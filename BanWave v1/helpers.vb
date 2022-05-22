Imports System.Data.SQLite
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json

Module helpers
    Public conn As New SQLiteConnection("Data Source=db.db")
    Public cmd As New SQLiteCommand("", conn)
    Public Reader As SQLiteDataReader
    Public apiRealm As String = "eu"

    Public account_id As String
    Public award_level As String
    Public battles As String
    Public battles_to_award As String
    Public clan_id As String
    Public clan_rank As String
    Public event_id As String
    Public fame_points As String
    Public fame_points_to_improve_award As String
    Public front_id As String
    Public rank As String
    Public rank_delta As String
    Public updated_at As String
    Public url As String

    Public NickName As String
    Public ClanName As String
    Public page_total As String
    Public starttime As String
    Public endtime As String

    Public Function DownloadAPI(ByVal Link As String) As XmlDocument
        Dim str As String
        Try

            Using client As New Net.WebClient

                client.Encoding = Encoding.UTF8
                str = client.DownloadString(Link)
            End Using
            DownloadAPI = Json2XML(str)
        Catch ex As Exception
            DownloadAPI = Nothing
            Debug.WriteLine(ex.Message)
        End Try
        Return DownloadAPI
    End Function
    Public Function Json2XML(ByVal json As String) As XmlDocument
        Return JsonConvert.DeserializeXmlNode(json, "Root")
    End Function
    Public Function GetClanName(ByVal clan_id As String) As String
        Try
            Dim api As New XmlDocument
            api = DownloadAPI("https://api.worldoftanks.eu/wot/clans/info/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&language=en&fields=tag&clan_id=" & clan_id)

            GetClanName = api.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(0).InnerText
        Catch ex As Exception
            GetClanName = ""
        End Try
        Return GetClanName
    End Function

    Public Function GetNickName(ByVal account_id As String) As String
        Try
            Dim api As XmlDocument = DownloadAPI("https://api.worldoftanks.eu/wot/account/info/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&fields=nickname&language=en&account_id=" & account_id)
            GetNickName = api.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(0).InnerText
        Catch ex As Exception

        End Try

        Return GetNickName
    End Function
End Module
