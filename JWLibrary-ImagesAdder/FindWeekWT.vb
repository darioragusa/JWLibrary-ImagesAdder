Imports Devart.Data
Imports Devart.Data.SQLite

Module FindWeekWT
    Function GetWeekN(ByVal dbDir As String) As Integer
        If Not System.IO.File.Exists(dbDir) Then Return -1
        Dim returnID As Integer = -1
        Using sqlCon As New SQLiteConnection(String.Format("Data Source = {0}", dbDir))
            Dim readWeekQuery As String = "SELECT DatedTextId, FirstDateOffset, LastDateOffset FROM DatedText"
            sqlCon.Open()
            Using command = sqlCon.CreateCommand()
                command.CommandText = readWeekQuery
                Using reader = command.ExecuteReader()
                    While reader.Read()
                        Dim id = reader.GetInt32(0)
                        Dim firstDate = reader.GetString(1)
                        Dim lastDate = reader.GetString(2)
                        If CheckWTWeek(firstDate, lastDate) Then returnID = id
                    End While
                End Using
            End Using
            sqlCon.Dispose() : sqlCon.Close() : GC.Collect() : GC.WaitForPendingFinalizers()
        End Using : Return returnID
    End Function

    Function CheckWTWeek(ByVal firstDate As String, ByVal lastDate As String) As Boolean
        Dim startDate As Date = DateTime.ParseExact(firstDate, "yyyyMMdd", Nothing)
        Dim endDate As Date = DateTime.ParseExact(lastDate, "yyyyMMdd", Nothing)
        If Now.Date >= startDate And Now.Date <= endDate Then Return True Else Return False
    End Function

    Function GetDocumentID(ByVal dbDir As String, ByVal weekN As Integer) As Integer
        If Not System.IO.File.Exists(dbDir) Then Return -1
        Dim returnID As Integer = -1
        Using sqlCon As New SQLiteConnection(String.Format("Data Source = {0}", dbDir))
            Dim readWeekQuery As String = "SELECT DocumentId, Class FROM Document"
            sqlCon.Open()
            Using command = sqlCon.CreateCommand()
                command.CommandText = readWeekQuery
                Dim actWeekN As Integer = 1
                Using reader = command.ExecuteReader()
                    While reader.Read()
                        Dim id = reader.GetInt32(0)
                        Dim class_ = reader.GetInt32(1)
                        If class_ = 40 Then
                            If weekN = actWeekN Then returnID = id
                            actWeekN += 1
                        End If
                    End While
                End Using
            End Using
            sqlCon.Dispose() : sqlCon.Close() : GC.Collect() : GC.WaitForPendingFinalizers()
        End Using : Return returnID
    End Function
End Module
