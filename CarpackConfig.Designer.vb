<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carpackConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carpackConfig))
        Me.Exit1 = New System.Windows.Forms.PictureBox()
        Me.btnCarpack = New System.Windows.Forms.Button()
        Me.btnVconfig = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tboxFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tboxOutput = New System.Windows.Forms.TextBox()
        Me.btnSelectOutput = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.lblVehicleFolder = New System.Windows.Forms.Label()
        Me.lblPackOutput = New System.Windows.Forms.Label()
        Me.listRecent = New System.Windows.Forms.ListView()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.cheader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cheader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cheaderspace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Exit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exit1
        '
        Me.Exit1.BackColor = System.Drawing.Color.Transparent
        Me.Exit1.BackgroundImage = Global.VehiclePlugin.My.Resources.Resources.xbutton
        Me.Exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Exit1.ErrorImage = Nothing
        Me.Exit1.InitialImage = Nothing
        Me.Exit1.Location = New System.Drawing.Point(726, 12)
        Me.Exit1.Margin = New System.Windows.Forms.Padding(0)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(65, 30)
        Me.Exit1.TabIndex = 17
        Me.Exit1.TabStop = False
        '
        'btnCarpack
        '
        Me.btnCarpack.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCarpack.Location = New System.Drawing.Point(12, 41)
        Me.btnCarpack.Name = "btnCarpack"
        Me.btnCarpack.Size = New System.Drawing.Size(161, 23)
        Me.btnCarpack.TabIndex = 20
        Me.btnCarpack.Text = "Carpack Config"
        Me.btnCarpack.UseVisualStyleBackColor = False
        '
        'btnVconfig
        '
        Me.btnVconfig.BackColor = System.Drawing.Color.Gainsboro
        Me.btnVconfig.Location = New System.Drawing.Point(12, 12)
        Me.btnVconfig.Name = "btnVconfig"
        Me.btnVconfig.Size = New System.Drawing.Size(161, 23)
        Me.btnVconfig.TabIndex = 19
        Me.btnVconfig.Text = "Admin VConfig "
        Me.btnVconfig.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Nexa Text Heavy", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(179, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(449, 45)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Vehicle Config Generator"
        '
        'tboxFolder
        '
        Me.tboxFolder.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxFolder.Location = New System.Drawing.Point(291, 110)
        Me.tboxFolder.Name = "tboxFolder"
        Me.tboxFolder.Size = New System.Drawing.Size(478, 32)
        Me.tboxFolder.TabIndex = 22
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(695, 152)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 23
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'tboxOutput
        '
        Me.tboxOutput.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxOutput.Location = New System.Drawing.Point(291, 198)
        Me.tboxOutput.Name = "tboxOutput"
        Me.tboxOutput.Size = New System.Drawing.Size(479, 32)
        Me.tboxOutput.TabIndex = 24
        '
        'btnSelectOutput
        '
        Me.btnSelectOutput.BackColor = System.Drawing.Color.White
        Me.btnSelectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectOutput.Location = New System.Drawing.Point(688, 243)
        Me.btnSelectOutput.Name = "btnSelectOutput"
        Me.btnSelectOutput.Size = New System.Drawing.Size(82, 23)
        Me.btnSelectOutput.TabIndex = 25
        Me.btnSelectOutput.Text = "Select Output"
        Me.btnSelectOutput.UseVisualStyleBackColor = False
        '
        'btnOutput
        '
        Me.btnOutput.BackColor = System.Drawing.Color.White
        Me.btnOutput.Location = New System.Drawing.Point(387, 291)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(383, 101)
        Me.btnOutput.TabIndex = 26
        Me.btnOutput.Text = "Click to Export"
        Me.btnOutput.UseVisualStyleBackColor = False
        '
        'lblVehicleFolder
        '
        Me.lblVehicleFolder.AutoSize = True
        Me.lblVehicleFolder.BackColor = System.Drawing.Color.Transparent
        Me.lblVehicleFolder.Font = New System.Drawing.Font("Nexa Text Heavy", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleFolder.ForeColor = System.Drawing.Color.White
        Me.lblVehicleFolder.Location = New System.Drawing.Point(27, 104)
        Me.lblVehicleFolder.Name = "lblVehicleFolder"
        Me.lblVehicleFolder.Size = New System.Drawing.Size(250, 41)
        Me.lblVehicleFolder.TabIndex = 27
        Me.lblVehicleFolder.Text = "Vehicle Folder:"
        '
        'lblPackOutput
        '
        Me.lblPackOutput.AutoSize = True
        Me.lblPackOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblPackOutput.Font = New System.Drawing.Font("Nexa Text Heavy", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackOutput.ForeColor = System.Drawing.Color.White
        Me.lblPackOutput.Location = New System.Drawing.Point(12, 197)
        Me.lblPackOutput.Name = "lblPackOutput"
        Me.lblPackOutput.Size = New System.Drawing.Size(267, 31)
        Me.lblPackOutput.TabIndex = 28
        Me.lblPackOutput.Text = "Pack Folder Location:"
        '
        'listRecent
        '
        Me.listRecent.AutoArrange = False
        Me.listRecent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listRecent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cheaderspace, Me.cheader1, Me.cheader2})
        Me.listRecent.Enabled = False
        Me.listRecent.Font = New System.Drawing.Font("Nexa Text Heavy", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listRecent.GridLines = True
        Me.listRecent.HideSelection = False
        Me.listRecent.LabelWrap = False
        Me.listRecent.Location = New System.Drawing.Point(12, 275)
        Me.listRecent.Name = "listRecent"
        Me.listRecent.Size = New System.Drawing.Size(336, 163)
        Me.listRecent.TabIndex = 29
        Me.listRecent.TabStop = False
        Me.listRecent.UseCompatibleStateImageBehavior = False
        Me.listRecent.View = System.Windows.Forms.View.Details
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.BackColor = System.Drawing.Color.Transparent
        Me.lblRecent.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.ForeColor = System.Drawing.Color.White
        Me.lblRecent.Location = New System.Drawing.Point(72, 251)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(207, 21)
        Me.lblRecent.TabIndex = 30
        Me.lblRecent.Text = "Recently Added Vehicles:"
        '
        'cheader1
        '
        Me.cheader1.Text = "Vehicle"
        Me.cheader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cheader1.Width = 168
        '
        'cheader2
        '
        Me.cheader2.Text = "Pack"
        Me.cheader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cheader2.Width = 168
        '
        'cheaderspace
        '
        Me.cheaderspace.Text = ""
        Me.cheaderspace.Width = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(337, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Made by The Unknown"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(681, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "The Unknown © 2021 "
        '
        'carpackConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.VehiclePlugin.My.Resources.Resources.ProjectCityRPBlur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRecent)
        Me.Controls.Add(Me.listRecent)
        Me.Controls.Add(Me.lblPackOutput)
        Me.Controls.Add(Me.lblVehicleFolder)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.btnSelectOutput)
        Me.Controls.Add(Me.tboxOutput)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tboxFolder)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCarpack)
        Me.Controls.Add(Me.btnVconfig)
        Me.Controls.Add(Me.Exit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "carpackConfig"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Pack Config"
        CType(Me.Exit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit1 As PictureBox
    Friend WithEvents btnCarpack As Button
    Friend WithEvents btnVconfig As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tboxFolder As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents tboxOutput As TextBox
    Friend WithEvents btnSelectOutput As Button
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents btnOutput As Button
    Friend WithEvents lblVehicleFolder As Label
    Friend WithEvents lblPackOutput As Label
    Friend WithEvents listRecent As ListView
    Friend WithEvents lblRecent As Label
    Friend WithEvents cheader1 As ColumnHeader
    Friend WithEvents cheader2 As ColumnHeader
    Friend WithEvents cheaderspace As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
