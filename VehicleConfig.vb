Public Class VehicleConfig

    Private Vnameclick As Boolean
    Private Scodeclick As Boolean
    Private Hashclick As Boolean
    Private Linkclick As Boolean
    Private pagination As Integer

    Private Sub VehicleConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vnameclick = False
        Scodeclick = False
        Hashclick = False
        Linkclick = False
        cboxPagination.SelectedIndex = 0
        Me.Show()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        carpackConfig.Show()
        carpackConfig.Hide()
        carpackConfig.Refresh()
    End Sub
    Private Sub BtnCarpack_Click(sender As Object, e As EventArgs) Handles btnCarpack.Click
        SuspendLayout()
        carpackConfig.Visible = True
        Me.Visible = False
        ResumeLayout()
    End Sub
    Private Sub BtnVconfig_Click(sender As Object, e As EventArgs) Handles btnVconfig.Click
        SuspendLayout()
        Me.Visible = True
        carpackConfig.Visible = False
        ResumeLayout()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        tboxOutput1.Text = "	 		['" & tboxScode.Text & "'] = {
				['name'] = """ & tboxVname.Text & """,
	 			['price_to_customer'] = 0,
	 			['price_to_owner'] = 0,
				['price_to_export'] = 0,
	 			['amount_to_owner'] = 0,
				['max_stock'] = 100,
	 			['img'] = '" & tboxLink.Text & "',
	 			['page'] = " & pagination & "
	 		},"
        tboxOutput2.Text = "{ ['name'] = """ & tboxScode.Text & """, ['hash'] = " & nudHash.Value & " },"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPagination.SelectedIndexChanged
        If cboxPagination.SelectedIndex = 0 Then
            pagination = 0
        ElseIf cboxPagination.SelectedIndex = 1 Then
            pagination = 1
        ElseIf cboxPagination.SelectedIndex = 2 Then
            pagination = 2
        ElseIf cboxPagination.SelectedIndex = 3 Then
            pagination = 3
        ElseIf cboxPagination.SelectedIndex = 4 Then
            pagination = 4
        ElseIf cboxPagination.SelectedIndex = 5 Then
            pagination = 5
        ElseIf cboxPagination.SelectedIndex = 6 Then
            pagination = 6
        ElseIf cboxPagination.SelectedIndex = 7 Then
            pagination = 7
        End If
    End Sub

    Private Sub TboxVname_Click(sender As Object, e As EventArgs) Handles tboxVname.Click
        If Vnameclick = False Then
            tboxVname.Clear()
            Vnameclick = True
        End If
    End Sub

    Private Sub TboxScode_Click(sender As Object, e As EventArgs) Handles tboxScode.Click
        If Scodeclick = False Then
            tboxScode.Clear()
            Scodeclick = True
        End If
    End Sub

    Private Sub NudHash_Click(sender As Object, e As EventArgs) Handles nudHash.Click
        If Hashclick = False Then
            nudHash.Controls.Item(1).Text = ""
            Hashclick = True
        End If
    End Sub

    Private Sub TboxLink_Click(sender As Object, e As EventArgs) Handles tboxLink.Click
        If Linkclick = False Then
            tboxLink.Clear()
            Linkclick = True
        End If
    End Sub

    Private Sub TboxOutput1_Click(sender As Object, e As EventArgs) Handles tboxOutput1.Click
        If tboxOutput1.Text IsNot "" Then
            Clipboard.SetText(tboxOutput1.Text)
            Copied.Active = True
            Copied.SetToolTip(tboxOutput1, "Copied to Clipboard!")
        End If
    End Sub

    Private Sub TboxOutput2_Click(sender As Object, e As EventArgs) Handles tboxOutput2.Click
        If tboxOutput2.Text IsNot "" Then
            Clipboard.SetText(tboxOutput2.Text)
            Copied.Active = True
            Copied.SetToolTip(tboxOutput2, "Copied to Clipboard!")
        End If
    End Sub
    Private Sub TboxOutput1_MouseHover(sender As Object, e As EventArgs) Handles tboxOutput1.MouseLeave
        Copied.Active = False
    End Sub
    Private Sub TboxOutput2_MouseHover(sender As Object, e As EventArgs) Handles tboxOutput2.MouseLeave
        Copied.Active = False
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        Me.Close()
        carpackConfig.Close()
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
            carpackConfig.Location = carpackConfig.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, lblTitle.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub
#End Region
    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If tboxScode.Text IsNot "" Then
            Clipboard.SetText(tboxScode.Text)
            Copied.Active = True
            Copied.SetToolTip(tboxScode, "Copied to Clipboard!")
        End If
    End Sub
    Private Sub BtnCopy_MouseLeave(sender As Object, e As EventArgs) Handles btnCopy.MouseLeave
        Copied.Active = False
    End Sub
End Class
