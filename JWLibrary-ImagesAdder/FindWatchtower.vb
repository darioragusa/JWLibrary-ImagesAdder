Imports System.IO
Imports Devart.Data
Imports Devart.Data.SQLite

Module FindWatchtower
    Function findWatchtowerDirectory() As String
        Dim direcrory As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Packages"
        If IO.Directory.Exists(direcrory) Then
            For Each Dir As String In Directory.GetDirectories(direcrory)
                If LCase(Dir).Contains("watchtower") Then
                    direcrory = Dir & "\LocalState\Publications"
                    Exit For
                End If
            Next
        End If
        If IO.Directory.Exists(direcrory) Then Return direcrory Else Return ""
    End Function

    Function existWhatchtowerDirectory() As Boolean
        If findWatchtowerDirectory() <> "" Then Return True Else Return False
    End Function

    Function findCurrentWatchtowers() As List(Of String) 'I used an array in case there were multiple languages
        Dim wtPath As String = findWatchtowerDirectory()
        Dim collectionPath As String = wtPath.Replace("\Publications", "\Data\pub_collections.db")
        Dim pubArray As New List(Of publication)
        If System.IO.File.Exists(collectionPath) Then
            Using sqlCon As New SQLiteConnection(String.Format("Data Source = {0}", collectionPath))
                Dim query As String = "SELECT IssueTagNumber, FirstDatedTextDateOffset, LastDatedTextDateOffset, KeySymbol FROM Publication"
                sqlCon.Open()
                Using command = sqlCon.CreateCommand()
                    command.CommandText = query
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            Dim pub As publication = New publication
                            pub.tagNumber = reader.GetString(0)
                            pub.firstDate = reader.GetString(1)
                            pub.lastDate = reader.GetString(2)
                            pub.keySymbol = reader.GetString(3)
                            pubArray.Add(pub) 'Getting all publications
                        End While
                    End Using
                End Using
                sqlCon.Dispose() : sqlCon.Close() : GC.Collect() : GC.WaitForPendingFinalizers()
            End Using
        End If

        Dim wtArray As New List(Of publication)
        For Each pub In pubArray
            If pub.keySymbol = "w" Then wtArray.Add(pub) 'Keeping only watchtowers
        Next

        Dim currentTagN As String = ""
        For Each pub In wtArray
            Dim firstDate As Date = DateTime.ParseExact(pub.firstDate, "yyyyMMdd", Nothing)
            Dim lastDate As Date = DateTime.ParseExact(pub.lastDate, "yyyyMMdd", Nothing)
            Dim todayDate As Date = Now.Date
            If firstDate <= todayDate And todayDate <= lastDate Then 'Period checking
                currentTagN = pub.tagNumber
                Exit For
            End If
        Next

        Dim wtDirArray As New List(Of String)
        For Each pubDirectory In IO.Directory.EnumerateDirectories(wtPath)
            Dim pubName As String = pubDirectory.ToString.Split("\").Last
            If pubName.StartsWith("w_") And pubName.EndsWith(currentTagN.Substring(0, 6)) Then 'Getting watchtower directories
                wtDirArray.Add(pubDirectory)
            End If
        Next

        Return wtDirArray
    End Function
End Module

Structure publication
    Dim keySymbol As String
    Dim tagNumber As String
    Dim firstDate As String
    Dim lastDate As String
End Structure
