Imports System.IO
Imports Devart.Data
Imports Devart.Data.SQLite

Module ManageWatchtower
    Function exsistBackup(ByVal directory As String) As Boolean
        Return IO.Directory.Exists(directory + "_back")
    End Function

    Sub makeBackup(ByVal directory As String)
        If exsistBackup(directory) Then Return
        My.Computer.FileSystem.CopyDirectory(directory, directory + "_back")
    End Sub

    Sub restoreBackup(ByVal directory As String)
        If Not IO.Directory.Exists(directory + "_back") Then Return
        My.Computer.FileSystem.DeleteDirectory(directory, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.MoveDirectory(directory + "_back", directory)
    End Sub
End Module

