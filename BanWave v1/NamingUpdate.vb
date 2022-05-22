Imports System.Threading
Public Class NamingUpdate
    Dim tr As Thread
    Dim _account As String
    Dim _clan As String
    Sub New(ByVal account As String, ByVal clan As String)
        _account = account
        _clan = clan
        start()
    End Sub
    Private Sub start()
        tr = New Thread(AddressOf ThreadCode)
        tr.Start()
    End Sub
    Private Sub ThreadCode()
        Dim nick As String = GetNickName(_account)
        _clan = GetClanName(_clan)


    End Sub

End Class
