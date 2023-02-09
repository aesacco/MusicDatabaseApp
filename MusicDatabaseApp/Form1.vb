Imports System.IO

Public Class Form1
    ' ID variable used in Updating And Deleting Record  
    Dim intID As Integer = 0

    ' global filename variable
    Dim stFileName As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim artist As String = txtArtist.Text
        Dim songName As String = txtSongName.Text
        Dim albumName As String = txtAlbumName.Text
        Dim year As String = txtYear.Text
        Dim genre As String = lstGenre.SelectedItem


        Dim row As String = artist & "," & songName & "," & albumName & "," & year & "," & genre & Environment.NewLine

        If IsNothing(stFileName) Then
            Dim stDialogTitle As String = "Please Select a CSV File"
            Dim stInitDirectory As String = "C:\Users\Public\Documents"
            Dim fd As OpenFileDialog = New OpenFileDialog()

            stDialogTitle = fd.Title()
            stInitDirectory = fd.InitialDirectory()
            fd.Filter = "CSV Files (*.csv)|*.csv"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True

            If fd.ShowDialog() = DialogResult.OK Then
                stFileName = fd.FileName
                File.AppendAllText(stFileName, row)

                txtArtist.Text = ""
                txtSongName.Text = ""
                txtAlbumName.Text = ""
                txtYear.Text = ""
                lstGenre.ClearSelected()

                dgvLoadedDb.DataSource = Nothing 'clear table
                dgvLoadedDb.Rows.Clear()
                Dim TextLine As String = ""
                Dim objReader As New System.IO.StreamReader(stFileName)
                Dim lines As List(Of String) = File.ReadAllLines(fd.FileName).ToList()
                fill_Columns(lines)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    addElements(
                data(0),
                data(1),
                data(2),
                data(3),
                data(4)
            ) 'All this elements has to match with the -fill_Columns- elements
                Next
                objReader.Close()
            End If
            MessageBox.Show("Data loaded successfully!")
        Else
            File.AppendAllText(stFileName, row)

            txtArtist.Text = ""
            txtSongName.Text = ""
            txtAlbumName.Text = ""
            txtYear.Text = ""
            lstGenre.ClearSelected()

            dgvLoadedDb.DataSource = Nothing 'clear table
            dgvLoadedDb.Rows.Clear()
            Dim TextLine As String = ""
            Dim objReader As New System.IO.StreamReader(stFileName)
            Dim lines As List(Of String) = File.ReadAllLines(stFileName).ToList()
            fill_Columns(lines)
            For i As Integer = 1 To lines.Count - 1
                Dim data As String() = lines(i).Split(",")
                addElements(
            data(0),
            data(1),
            data(2),
            data(3),
            data(4)
        ) 'All this elements has to match with the -fill_Columns- elements
            Next
            objReader.Close()
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim stDialogTitle As String = "Please Select a CSV File"
        Dim stInitDirectory As String = "C:\Users\Public\Documents"
        Dim fd As OpenFileDialog = New OpenFileDialog()

        stDialogTitle = fd.Title()
        stInitDirectory = fd.InitialDirectory()
        fd.Filter = "CSV Files (*.csv)|*.csv"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then

            dgvLoadedDb.DataSource = Nothing 'clear table
            dgvLoadedDb.Rows.Clear()
            stFileName = fd.FileName
            Dim TextLine As String = ""
            Dim objReader As New System.IO.StreamReader(stFileName)
            Dim lines As List(Of String) = File.ReadAllLines(fd.FileName).ToList()
            fill_Columns(lines)
            For i As Integer = 1 To lines.Count - 1
                Dim data As String() = lines(i).Split(",")
                addElements(
                data(0),
                data(1),
                data(2),
                data(3),
                data(4)
            ) 'All this elements has to match with the -fill_Columns- elements
            Next
            objReader.Close()
            MessageBox.Show("Data loaded successfully!")

        End If

    End Sub

    Private Sub fill_Columns(lines As List(Of String))
        Dim columns() As String = lines(0).Split(",")
        For Each item In columns
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = item
            col.Name = item
            col.DataPropertyName = item
            dgvLoadedDb.Columns.Add(col)
        Next
    End Sub

    Private Sub addElements(Artist As String, SongName As String, ALbumName As String, Year As String, Genre As String)
        dgvLoadedDb.Rows.Add(
            Artist,
            SongName,
            ALbumName,
            Year,
            Genre
        ) 'You add or delete as you need
    End Sub

    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        If dgvLoadedDb.SelectedRows.Count > 0 Then

            dgvLoadedDb.Rows.RemoveAt(dgvLoadedDb.CurrentRow.Index)
            Dim headers = (From header As DataGridViewColumn In dgvLoadedDb.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In dgvLoadedDb.Rows.Cast(Of DataGridViewRow)()
                       Where Not row.IsNewRow
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            Using sw As New IO.StreamWriter(stFileName)
                sw.WriteLine(String.Join(",", headers))
                For Each r In rows
                    sw.WriteLine(String.Join(",", r))
                Next
            End Using


        Else

            MessageBox.Show("You must select a row")

        End If
    End Sub

    Private Sub btnCreateNewDb_Click(sender As Object, e As EventArgs) Handles btnCreateNewDb.Click
        Dim stInitDirectory As String = "C:\Users\Public\Documents"
        Dim fullPath As String = stInitDirectory & "\" & "music_db.csv"


        If File.Exists(fullPath) Then

            MsgBox("File music_db.csv already exists and will not be overwritten.")
        Else
            'Create or overwrite the file.
            Dim fs As FileStream = File.Create(fullPath)
            fs.Close()

            'Add headers to the file
            Dim row As String = "Artist" & "," & "Song Name" & "," & "Album Name" & "," & "Year" & "," & "Genre" & Environment.NewLine
            File.AppendAllText(fullPath, row)
        End If

    End Sub
End Class
