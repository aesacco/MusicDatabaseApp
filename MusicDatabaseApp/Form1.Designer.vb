<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblSongName = New System.Windows.Forms.Label()
        Me.lblAlbumName = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtSongName = New System.Windows.Forms.TextBox()
        Me.txtAlbumName = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lstGenre = New System.Windows.Forms.ListBox()
        Me.dgvLoadedDb = New System.Windows.Forms.DataGridView()
        Me.btnCloseApp = New System.Windows.Forms.Button()
        Me.btnCreateNewDb = New System.Windows.Forms.Button()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        CType(Me.dgvLoadedDb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(567, 243)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(114, 29)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(567, 278)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 29)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(63, 21)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(44, 20)
        Me.lblArtist.TabIndex = 2
        Me.lblArtist.Text = "Artist"
        '
        'lblSongName
        '
        Me.lblSongName.AutoSize = True
        Me.lblSongName.Location = New System.Drawing.Point(63, 68)
        Me.lblSongName.Name = "lblSongName"
        Me.lblSongName.Size = New System.Drawing.Size(87, 20)
        Me.lblSongName.TabIndex = 3
        Me.lblSongName.Text = "Song Name"
        '
        'lblAlbumName
        '
        Me.lblAlbumName.AutoSize = True
        Me.lblAlbumName.Location = New System.Drawing.Point(63, 113)
        Me.lblAlbumName.Name = "lblAlbumName"
        Me.lblAlbumName.Size = New System.Drawing.Size(97, 20)
        Me.lblAlbumName.TabIndex = 4
        Me.lblAlbumName.Text = "Album Name"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(63, 163)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(37, 20)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(63, 227)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(48, 20)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Genre"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(170, 21)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(381, 27)
        Me.txtArtist.TabIndex = 7
        '
        'txtSongName
        '
        Me.txtSongName.Location = New System.Drawing.Point(170, 68)
        Me.txtSongName.Name = "txtSongName"
        Me.txtSongName.Size = New System.Drawing.Size(381, 27)
        Me.txtSongName.TabIndex = 8
        '
        'txtAlbumName
        '
        Me.txtAlbumName.Location = New System.Drawing.Point(170, 113)
        Me.txtAlbumName.Name = "txtAlbumName"
        Me.txtAlbumName.Size = New System.Drawing.Size(381, 27)
        Me.txtAlbumName.TabIndex = 9
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(170, 163)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(381, 27)
        Me.txtYear.TabIndex = 10
        '
        'lstGenre
        '
        Me.lstGenre.FormattingEnabled = True
        Me.lstGenre.ItemHeight = 20
        Me.lstGenre.Items.AddRange(New Object() {"Blues", "Country", "Easy Listening", "Electronic", "Contemporary Folk", "Hip Hop", "Jazz", "Pop", "R&B and Soul", "Rock", "Metal", "Punk", "Latin", "Religious", "Traditional Folk"})
        Me.lstGenre.Location = New System.Drawing.Point(170, 214)
        Me.lstGenre.Name = "lstGenre"
        Me.lstGenre.Size = New System.Drawing.Size(381, 224)
        Me.lstGenre.TabIndex = 11
        '
        'dgvLoadedDb
        '
        Me.dgvLoadedDb.AllowUserToAddRows = False
        Me.dgvLoadedDb.AllowUserToDeleteRows = False
        Me.dgvLoadedDb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLoadedDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoadedDb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLoadedDb.Location = New System.Drawing.Point(691, 113)
        Me.dgvLoadedDb.Name = "dgvLoadedDb"
        Me.dgvLoadedDb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvLoadedDb.RowTemplate.Height = 29
        Me.dgvLoadedDb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvLoadedDb.Size = New System.Drawing.Size(679, 293)
        Me.dgvLoadedDb.TabIndex = 12
        '
        'btnCloseApp
        '
        Me.btnCloseApp.Location = New System.Drawing.Point(567, 409)
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Size = New System.Drawing.Size(114, 29)
        Me.btnCloseApp.TabIndex = 13
        Me.btnCloseApp.Text = "Close App"
        Me.btnCloseApp.UseVisualStyleBackColor = True
        '
        'btnCreateNewDb
        '
        Me.btnCreateNewDb.Location = New System.Drawing.Point(567, 313)
        Me.btnCreateNewDb.Name = "btnCreateNewDb"
        Me.btnCreateNewDb.Size = New System.Drawing.Size(114, 55)
        Me.btnCreateNewDb.TabIndex = 14
        Me.btnCreateNewDb.Text = "Create New Db"
        Me.btnCreateNewDb.UseVisualStyleBackColor = True
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Location = New System.Drawing.Point(567, 374)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(114, 29)
        Me.btnDeleteRecord.TabIndex = 15
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1393, 450)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnCreateNewDb)
        Me.Controls.Add(Me.btnCloseApp)
        Me.Controls.Add(Me.dgvLoadedDb)
        Me.Controls.Add(Me.lstGenre)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtAlbumName)
        Me.Controls.Add(Me.txtSongName)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblAlbumName)
        Me.Controls.Add(Me.lblSongName)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Form1"
        Me.Text = "Alex's Music Database Application"
        CType(Me.dgvLoadedDb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblSongName As Label
    Friend WithEvents lblAlbumName As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtSongName As TextBox
    Friend WithEvents txtAlbumName As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lstGenre As ListBox
    Friend WithEvents dgvLoadedDb As DataGridView
    Friend WithEvents btnCloseApp As Button
    Friend WithEvents btnCreateNewDb As Button
    Friend WithEvents btnDeleteRecord As Button
End Class
