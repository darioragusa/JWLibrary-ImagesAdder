Imports Devart.Data
Imports Devart.Data.SQLite

Module AddImages
    Sub AddImg(ByVal dbDir As String, ByVal docID As Integer, ByVal imgList As List(Of String))
        If Not System.IO.File.Exists(dbDir) Then Return
        Using SQLCon As New SQLiteConnection(String.Format("Data Source = {0}", dbDir))
            Dim insertMultimediaQuery As String = "INSERT INTO Multimedia(DataType, MajorType, MinorType, MimeType, Caption, FilePath, CategoryType) VALUES(@Data, @Major, @Minor, @Mime, @Caption, @File, @Category)"
            Dim insertDocumentMultimediaQuery As String = "INSERT INTO DocumentMultimedia(DocumentId, MultimediaId) VALUES(@Document, @Multimedia)"
            Dim lastID As Integer = GetLastMultimediaID(dbDir)
            If lastID = -1 Then GoTo _End
            SQLCon.Open()
            For Each Image In imgList
                Dim multimediaCMD As New SQLiteCommand(insertMultimediaQuery, SQLCon)
                Dim documentMultimediaCMD As New SQLiteCommand(insertDocumentMultimediaQuery, SQLCon)
                multimediaCMD.Parameters.AddWithValue("@Data", "0")
                multimediaCMD.Parameters.AddWithValue("@Major", "1")
                multimediaCMD.Parameters.AddWithValue("@Minor", "1")
                multimediaCMD.Parameters.AddWithValue("@Mime", "image/" & Image.ToString.Split("\").Last.Split(".").Last.Replace("jpg", "jpeg"))
                multimediaCMD.Parameters.AddWithValue("@Caption", Image.ToString.Split("\").Last)
                multimediaCMD.Parameters.AddWithValue("@Category", "15")
                multimediaCMD.Parameters.AddWithValue("@File", Image.ToString.Split("\").Last)
                lastID += 1
                documentMultimediaCMD.Parameters.AddWithValue("@Document", CStr(docID))
                documentMultimediaCMD.Parameters.AddWithValue("@Multimedia", CStr(lastID))
                multimediaCMD.ExecuteNonQuery()
                documentMultimediaCMD.ExecuteNonQuery()
            Next
_End:
            SQLCon.Dispose() : SQLCon.Close() : GC.Collect() : GC.WaitForPendingFinalizers()
        End Using
    End Sub

    Function GetLastMultimediaID(ByVal dbDir As String) As Integer
        If Not System.IO.File.Exists(dbDir) Then Return -1
        Dim lastID As Integer = -1
        Using sqlCon As New SQLiteConnection(String.Format("Data Source = {0}", dbDir))
            Dim readWeekQuery As String = "SELECT MultimediaId FROM Multimedia"
            sqlCon.Open()
            Using command = sqlCon.CreateCommand()
                command.CommandText = readWeekQuery
                Using reader = command.ExecuteReader()
                    While reader.Read()
                        lastID = reader.GetInt32(0)
                    End While
                End Using
            End Using
            sqlCon.Dispose() : sqlCon.Close() : GC.Collect() : GC.WaitForPendingFinalizers()
        End Using : Return lastID
    End Function
End Module
