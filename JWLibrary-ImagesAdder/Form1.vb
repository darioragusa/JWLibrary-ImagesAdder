Public Class Form1
    Dim imgList As New List(Of String)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeLanguage()
        Me.Icon = My.Resources.Ico
        If Not existWhatchtowerDirectory() Then
            ButtonDelete.Enabled = False
            ButtonSelect.Enabled = False
            MsgBox(Strings.Error1Text, MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

    Private Sub ButtonSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelect.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = Strings.Text1 + "| *.jpg; *.jpeg; *.png; *.JPG; *.JPEG; *.PNG"

        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Multiselect = True
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each imgFile In OpenFileDialog1.FileNames
                imgList.Add(imgFile)
            Next
        End If
        ListBoxImg.DataSource = Nothing
        ListBoxImg.Items.Clear()
        ListBoxImg.DataSource = imgList
        If imgList.Count = 0 Then ButtonAdd.Enabled = False Else ButtonAdd.Enabled = True
        If imgList.Count = 0 Then ButtonDelete.Enabled = False Else ButtonDelete.Enabled = True
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If ListBoxImg.SelectedIndex = -1 Then imgList.Clear() Else imgList.RemoveAt(ListBoxImg.SelectedIndex)
        ListBoxImg.DataSource = Nothing
        ListBoxImg.Items.Clear()
        ListBoxImg.DataSource = imgList
        If imgList.Count = 0 Then ButtonAdd.Enabled = False Else ButtonAdd.Enabled = True
        If imgList.Count = 0 Then ButtonDelete.Enabled = False Else ButtonDelete.Enabled = True
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim wtDir = findCurrentWatchtowers()
        If wtDir.Count = 0 Then
            MsgBox(Strings.Error2Text, MsgBoxStyle.Critical, Me.Text)
            Return
        End If
        For Each directory In wtDir
            makeBackup(directory)
            For Each imgDir In imgList
                System.IO.File.Copy(imgDir, directory & "\" & imgDir.ToString.Split("\").Last.Replace("PNG", "png").Replace("JPEG", "jpg").Replace("jpeg", "jpg").Replace("JPG", "jpg"), True)
            Next
            Dim dbDir As String = directory & "\" & directory.Split("\").Last & ".db"
            Dim weekN As Integer = GetWeekN(dbDir)
            If weekN = -1 Then
                MsgBox(Strings.Error3Text, MsgBoxStyle.Exclamation, Me.Text) : Exit Sub
            End If
            Dim docID As Integer = GetDocumentID(dbDir, weekN)
            AddImg(dbDir, docID, imgList)
            MsgBox(Strings.Text2, MsgBoxStyle.OkOnly, Me.Text)
            Me.Close()
            'I have to close otherwise it gives error
            'for some reason the database is not closed and trying to reopen it does not work
        Next
    End Sub

    Sub ChangeLanguage()
        Dim UserCulture = System.Globalization.CultureInfo.CurrentCulture
        If LCase(UserCulture.ToString).Contains("it") Then
            Strings.Error1Text = "Cartella di JW Library non trovata"
            Strings.Error2Text = "Torre di Guardia attuale non trovata"
            Strings.Error3Text = "Settimana non trovata"
            Strings.Error4Text = "Chiudi JW Library per continuare"
            Strings.Text1 = "Immagini"
            Strings.Text2 = "Il mio lavoro qui è finito"
            ButtonSelect.Text = "Seleziona le immagini da aggiungere"
            ButtonDelete.Text = "Elimina"
            ButtonAdd.Text = "Aggiungi le immagini"
            ButtonRestoreAll.Text = "Ripristina pubblicazioni originali"
        End If
    End Sub

    Structure Strings
        Shared Error1Text As String = "JW Library folder not found"
        Shared Error2Text As String = "Current Watchtower not found"
        Shared Error3Text As String = "Week not found"
        Shared Error4Text As String = "Close JW Library to continue"
        Shared Text1 As String = "Images"
        Shared Text2 As String = "My job here is done"
    End Structure

    Private Sub ButtonRestoreAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRestoreAll.Click
        If Not ChecKJW() Then Return
        For Each directory In findCurrentWatchtowers()
            If Not directory.ToString.EndsWith("_back") Then
                restoreBackup(directory)
            End If
        Next
_endRestore:
    End Sub

    Function ChecKJW() As Boolean
_check:
        Dim proc() As Process
        proc = Process.GetProcessesByName("JWLibrary")
        If proc.Count > 0 Then
            Dim result = MsgBox(Strings.Error4Text, MsgBoxStyle.RetryCancel, Me.Text)
            If result = MsgBoxResult.Cancel Then
                Return False
            Else
                GoTo _check
            End If

        End If
        Return True
    End Function
End Class
