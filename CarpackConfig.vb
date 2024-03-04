Imports System.IO
Imports System.Text

Public Class carpackConfig

    Private Sub CarpackConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub BtnCarpack_Click(sender As Object, e As EventArgs) Handles btnCarpack.Click
        SuspendLayout()
        Me.Visible = True
        VehicleConfig.Visible = False
        ResumeLayout()
    End Sub

    Private Sub BtnVconfig_Click(sender As Object, e As EventArgs) Handles btnVconfig.Click
        SuspendLayout()
        VehicleConfig.Visible = True
        Me.Visible = False
        ResumeLayout()
    End Sub
    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        Me.Close()
        VehicleConfig.Close()
    End Sub

    Private Sub Exit1_MouseHover(sender As Object, e As EventArgs) Handles Exit1.MouseHover
        Exit1.Image = My.Resources.xbutton2
    End Sub

    Private Sub Exit2_MouseHover(sender As Object, e As EventArgs) Handles Exit1.MouseLeave
        Exit1.Image = My.Resources.xbutton
    End Sub

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public Shared MoveForm As Boolean
    Public Shared MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown, lblTitle.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)


        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove, lblTitle.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
#Disable Warning IDE0054 ' Use compound assignment
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
#Enable Warning IDE0054 ' Use compound assignment
            VehicleConfig.Location = VehicleConfig.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, lblTitle.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        tboxFolder.Clear()
        FolderBrowserDialog1.ShowDialog()
        tboxFolder.Text = FolderBrowserDialog1.SelectedPath.ToString()
    End Sub

    Private Sub BtnOutput_Click(sender As Object, e As EventArgs) Handles btnSelectOutput.Click
        tboxOutput.Clear()
        FolderBrowserDialog2.ShowDialog()
        tboxOutput.Text = FolderBrowserDialog2.SelectedPath.ToString()
    End Sub


    Private Sub BtnOutput_Click_1(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim fullpath As String = tboxFolder.Text
        Dim fulltboxoutput As String = tboxOutput.Text
        Dim filesfoundytd() As FileInfo
        Dim filesfoundyft() As FileInfo
        Dim filesfoundmeta() As FileInfo
        Dim FldrInfo As New DirectoryInfo(fullpath)
        Dim filenames As String
        filenames = ""
        Try
            Dim lastfolder As String
            Dim lastoutputfolder As String
            lastfolder = fullpath.Substring(InStrRev(fullpath, "\"))
            lastoutputfolder = fulltboxoutput.Substring(InStrRev(fulltboxoutput, "\"))
            Dim List As New ListViewItem
            List.SubItems.Add(lastfolder)
            List.SubItems.Add(lastoutputfolder)
            listRecent.Items.Add(List)
            Do While listRecent.Items.Count >= 9
                listRecent.Items.Remove(listRecent.Items(0))
            Loop
            Try
            If Not File.Exists(Path.Combine(tboxOutput.Text, "__resource.lua")) Then
                    Dim addInfo As New StreamWriter(tboxOutput.Text & "\__resource.lua")
                    addInfo.WriteLine("resource_manifest_version '77731fab-63ca-442c-a67b-abc70f28dfa5'")
                    addInfo.WriteLine("")
                    addInfo.WriteLine("files {")
                    addInfo.WriteLine("}")
                    addInfo.WriteLine("")
                    addInfo.WriteLine("--" & lastfolder)
                    addInfo.Close()
                Else
                    Dim addInfo As New StreamWriter(tboxOutput.Text & "\__resource.lua", True)
                    addInfo.WriteLine("")
                    addInfo.WriteLine("--" & lastfolder)
                    addInfo.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Create File and Add Process Process Error:" & ex.Message)
            End Try
            My.Computer.FileSystem.CreateDirectory(Path.Combine(tboxOutput.Text, "stream", lastfolder))
            My.Computer.FileSystem.CreateDirectory(Path.Combine(tboxOutput.Text, "data", lastfolder))
            filesfoundytd = FldrInfo.GetFiles("*.ytd", SearchOption.AllDirectories)
            filesfoundyft = FldrInfo.GetFiles("*.yft", SearchOption.AllDirectories)
            filesfoundmeta = FldrInfo.GetFiles("*.meta", SearchOption.AllDirectories)
            For Each SearchFile In filesfoundytd
                Dim streamPath As String = Path.Combine(tboxOutput.Text, "stream", lastfolder, SearchFile.Name)
                File.Copy(SearchFile.FullName, streamPath, True)
            Next
            For Each SearchFile In filesfoundyft
                Dim streamPath As String = Path.Combine(tboxOutput.Text, "stream", lastfolder, SearchFile.Name)
                File.Copy(SearchFile.FullName, streamPath, True)
            Next
            Try
                Dim regexPatternHandling As String = "\b(handling).*\b(.meta)"
                Dim regexPatternVehicles As String = "\b(vehicles).*\b(.meta)"
                Dim regexPatternCarcols As String = "\b(carcols).*\b(.meta)"
                Dim regexPatternCarV As String = "\b(carvariations).*\b(.meta)"
                Dim regexPatternvLayouts As String = "\b(vehiclelayouts).*\b(.meta)"
                For Each SearchFile In filesfoundmeta
                    Dim addInfo As New StreamWriter(tboxOutput.Text & "\__resource.lua", True)
                    If RegularExpressions.Regex.IsMatch(SearchFile.Name.ToLower(), regexPatternHandling) Then
                        Dim renameHandling As String = Path.Combine(tboxOutput.Text, "data", lastfolder, "handling.meta")
                        addInfo.WriteLine("data_file 'HANDLING_FILE' 'data/" & lastfolder & "/handling.meta'")
                        File.Copy(SearchFile.FullName, renameHandling, True)
                    ElseIf RegularExpressions.Regex.IsMatch(SearchFile.Name.ToLower(), regexPatternVehicles) Then
                        Dim renameVehicles As String = Path.Combine(tboxOutput.Text, "data", lastfolder, "vehicles.meta")
                        addInfo.WriteLine("data_file 'VEHICLE_METADATA_FILE' 'data/" & lastfolder & "/vehicles.meta'")
                        File.Copy(SearchFile.FullName, renameVehicles, True)
                    ElseIf RegularExpressions.Regex.IsMatch(SearchFile.Name.ToLower(), regexPatternCarcols) Then
                        Dim renameCarcols As String = Path.Combine(tboxOutput.Text, "data", lastfolder, "carcols.meta")
                        addInfo.WriteLine("data_file 'CARCOLS_FILE' 'data/" & lastfolder & "/carcols.meta'")
                        File.Copy(SearchFile.FullName, renameCarcols, True)
                    ElseIf RegularExpressions.Regex.IsMatch(SearchFile.Name.ToLower(), regexPatternCarV) Then
                        Dim renameCarV As String = Path.Combine(tboxOutput.Text, "data", lastfolder, "carvariations.meta")
                        addInfo.WriteLine("data_file 'VEHICLE_VARIATION_FILE' 'data/" & lastfolder & "/carvariations.meta'")
                        File.Copy(SearchFile.FullName, renameCarV, True)
                    ElseIf RegularExpressions.Regex.IsMatch(SearchFile.Name.ToLower(), regexPatternvLayouts) Then
                        Dim renameVLayouts As String = Path.Combine(tboxOutput.Text, "data", lastfolder, "vehiclelayouts.meta")
                        addInfo.WriteLine("data_file 'VEHICLE_LAYOUTS_FILE' 'data/" & lastfolder & "/vehiclelayouts.meta'")
                        File.Copy(SearchFile.FullName, renameVLayouts, True)
                    End If
                    addInfo.Close()
                Next
            Catch ex As Exception
                MessageBox.Show("Problem with transfering file. " & ex.Message)
            End Try
            Dim newfile As New List(Of String)()
            Try
                For Each line As String In File.ReadAllLines(Path.Combine(tboxOutput.Text, "__resource.lua"))
                    Dim matchFound As Boolean
                    matchFound = line.Contains("files {") ''data/reventonr/*.meta',

                    If matchFound Then
                        newfile.Add(line & vbNewLine & "    'data/" & lastfolder & "/*.meta',")
                    Else
                        newfile.Add(line)
                    End If
                Next
                File.WriteAllLines(Path.Combine(tboxOutput.Text, "__resource.lua"), newfile.ToArray())
                MessageBox.Show("Vehicle Added to Pack!")
            Catch ex As Exception
                MessageBox.Show("Add Meta Line Process:" & ex.Message)
            End Try
        Catch ex As Exception
                Dim attributes = File.GetAttributes(fullpath)
            If FileAttributes.ReadOnly Then
                File.SetAttributes(fullpath, FileAttributes.ReadOnly = 0)
            Else
                Throw
            End If
        End Try

    End Sub

#End Region
End Class