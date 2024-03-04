<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VehicleConfig
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehicleConfig))
        Me.lblSpawnCode = New System.Windows.Forms.Label()
        Me.tboxScode = New System.Windows.Forms.TextBox()
        Me.cboxPagination = New System.Windows.Forms.ComboBox()
        Me.lblPagination = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tboxVname = New System.Windows.Forms.TextBox()
        Me.lblHash = New System.Windows.Forms.Label()
        Me.lblClicktocopy = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tboxOutput1 = New System.Windows.Forms.TextBox()
        Me.tboxOutput2 = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.tboxLink = New System.Windows.Forms.TextBox()
        Me.nudHash = New System.Windows.Forms.NumericUpDown()
        Me.vSpawnTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.vTypeTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.vNameTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.vHashTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.vImage = New System.Windows.Forms.ToolTip(Me.components)
        Me.clickToCopy = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.niOutput1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Copied = New System.Windows.Forms.ToolTip(Me.components)
        Me.Exit1 = New System.Windows.Forms.PictureBox()
        Me.btnVconfig = New System.Windows.Forms.Button()
        Me.btnCarpack = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nudHash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Exit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpawnCode
        '
        Me.lblSpawnCode.AutoSize = True
        Me.lblSpawnCode.BackColor = System.Drawing.Color.Transparent
        Me.lblSpawnCode.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpawnCode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSpawnCode.Location = New System.Drawing.Point(18, 77)
        Me.lblSpawnCode.Name = "lblSpawnCode"
        Me.lblSpawnCode.Size = New System.Drawing.Size(173, 21)
        Me.lblSpawnCode.TabIndex = 2
        Me.lblSpawnCode.Text = "Vehicle Spawn Code:"
        '
        'tboxScode
        '
        Me.tboxScode.AcceptsTab = True
        Me.tboxScode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxScode.Font = New System.Drawing.Font("Nexa Text Heavy", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxScode.Location = New System.Drawing.Point(197, 74)
        Me.tboxScode.Name = "tboxScode"
        Me.tboxScode.Size = New System.Drawing.Size(166, 24)
        Me.tboxScode.TabIndex = 1
        Me.tboxScode.Text = "Spawn Code"
        Me.vSpawnTooltip.SetToolTip(Me.tboxScode, "Spawn Code for Vehicle")
        '
        'cboxPagination
        '
        Me.cboxPagination.AllowDrop = True
        Me.cboxPagination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPagination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxPagination.Font = New System.Drawing.Font("Nexa Text Heavy", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxPagination.FormattingEnabled = True
        Me.cboxPagination.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboxPagination.Items.AddRange(New Object() {"In-Game", "Sports & Classics", "OffRoad", "Drag", "Muscle", "Utility", "Bikes", "Other"})
        Me.cboxPagination.Location = New System.Drawing.Point(507, 74)
        Me.cboxPagination.Name = "cboxPagination"
        Me.cboxPagination.Size = New System.Drawing.Size(236, 22)
        Me.cboxPagination.TabIndex = 2
        Me.vTypeTooltip.SetToolTip(Me.cboxPagination, "Page the Vehicle will be displayed on")
        '
        'lblPagination
        '
        Me.lblPagination.AutoSize = True
        Me.lblPagination.BackColor = System.Drawing.Color.Transparent
        Me.lblPagination.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagination.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPagination.Location = New System.Drawing.Point(387, 74)
        Me.lblPagination.Name = "lblPagination"
        Me.lblPagination.Size = New System.Drawing.Size(114, 21)
        Me.lblPagination.TabIndex = 5
        Me.lblPagination.Text = "Vehicle Type:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName.Location = New System.Drawing.Point(35, 112)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(123, 21)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Vehicle Name:"
        '
        'tboxVname
        '
        Me.tboxVname.AcceptsTab = True
        Me.tboxVname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxVname.Font = New System.Drawing.Font("Nexa Text Heavy", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxVname.Location = New System.Drawing.Point(164, 111)
        Me.tboxVname.Name = "tboxVname"
        Me.tboxVname.Size = New System.Drawing.Size(216, 24)
        Me.tboxVname.TabIndex = 3
        Me.tboxVname.Text = "Insert what you want vehicle named"
        Me.vNameTooltip.SetToolTip(Me.tboxVname, "What the vehicle will be named in the Admin Menu")
        '
        'lblHash
        '
        Me.lblHash.AutoSize = True
        Me.lblHash.BackColor = System.Drawing.Color.Transparent
        Me.lblHash.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHash.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHash.Location = New System.Drawing.Point(422, 112)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(55, 21)
        Me.lblHash.TabIndex = 8
        Me.lblHash.Text = "Hash:"
        '
        'lblClicktocopy
        '
        Me.lblClicktocopy.AutoSize = True
        Me.lblClicktocopy.BackColor = System.Drawing.Color.Transparent
        Me.lblClicktocopy.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicktocopy.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblClicktocopy.Location = New System.Drawing.Point(314, 223)
        Me.lblClicktocopy.Name = "lblClicktocopy"
        Me.lblClicktocopy.Size = New System.Drawing.Size(163, 21)
        Me.lblClicktocopy.TabIndex = 10
        Me.lblClicktocopy.Text = "Click below to copy"
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
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Vehicle Config Generator"
        '
        'tboxOutput1
        '
        Me.tboxOutput1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.tboxOutput1.Location = New System.Drawing.Point(22, 251)
        Me.tboxOutput1.Multiline = True
        Me.tboxOutput1.Name = "tboxOutput1"
        Me.tboxOutput1.ReadOnly = True
        Me.tboxOutput1.Size = New System.Drawing.Size(479, 180)
        Me.tboxOutput1.TabIndex = 0
        Me.tboxOutput1.TabStop = False
        '
        'tboxOutput2
        '
        Me.tboxOutput2.Location = New System.Drawing.Point(507, 251)
        Me.tboxOutput2.Multiline = True
        Me.tboxOutput2.Name = "tboxOutput2"
        Me.tboxOutput2.ReadOnly = True
        Me.tboxOutput2.Size = New System.Drawing.Size(269, 180)
        Me.tboxOutput2.TabIndex = 0
        Me.tboxOutput2.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Location = New System.Drawing.Point(321, 185)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(146, 33)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export Code"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.BackColor = System.Drawing.Color.Transparent
        Me.lblImage.Font = New System.Drawing.Font("Nexa Text Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblImage.Location = New System.Drawing.Point(57, 148)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(101, 21)
        Me.lblImage.TabIndex = 14
        Me.lblImage.Text = "Image Link:"
        '
        'tboxLink
        '
        Me.tboxLink.AcceptsTab = True
        Me.tboxLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxLink.Font = New System.Drawing.Font("Nexa Text Heavy", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxLink.Location = New System.Drawing.Point(164, 149)
        Me.tboxLink.Name = "tboxLink"
        Me.tboxLink.Size = New System.Drawing.Size(579, 24)
        Me.tboxLink.TabIndex = 5
        Me.tboxLink.Text = "Link or ""/images/VNAME.png"""
        Me.vImage.SetToolTip(Me.tboxLink, "Image that will be displayed in the Admin Menu. Can either be a link to somewhere" &
        " online or a file path.")
        '
        'nudHash
        '
        Me.nudHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudHash.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHash.InterceptArrowKeys = False
        Me.nudHash.Location = New System.Drawing.Point(507, 111)
        Me.nudHash.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudHash.Minimum = New Decimal(New Integer() {1215752191, 23, 0, -2147483648})
        Me.nudHash.Name = "nudHash"
        Me.nudHash.Size = New System.Drawing.Size(236, 27)
        Me.nudHash.TabIndex = 4
        Me.vHashTooltip.SetToolTip(Me.nudHash, "Hash code for the vehicle. Type ""/hash <spawncode>"" in chat to get the Hash code " &
        "for the vehicle")
        Me.nudHash.Value = New Decimal(New Integer() {100000000, 0, 0, 0})
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Location = New System.Drawing.Point(364, 75)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(17, 22)
        Me.btnCopy.TabIndex = 19
        Me.btnCopy.TabStop = False
        Me.btnCopy.Text = "C"
        Me.clickToCopy.SetToolTip(Me.btnCopy, "Click to Copy VSpawn Code")
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'niOutput1
        '
        Me.niOutput1.Text = "Copied to Clipboard!"
        Me.niOutput1.Visible = True
        '
        'Copied
        '
        Me.Copied.AutomaticDelay = 0
        Me.Copied.BackColor = System.Drawing.SystemColors.Highlight
        Me.Copied.ForeColor = System.Drawing.SystemColors.HighlightText
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
        Me.Exit1.TabIndex = 16
        Me.Exit1.TabStop = False
        '
        'btnVconfig
        '
        Me.btnVconfig.BackColor = System.Drawing.Color.Gainsboro
        Me.btnVconfig.Location = New System.Drawing.Point(12, 12)
        Me.btnVconfig.Name = "btnVconfig"
        Me.btnVconfig.Size = New System.Drawing.Size(161, 23)
        Me.btnVconfig.TabIndex = 17
        Me.btnVconfig.Text = "Admin VConfig "
        Me.btnVconfig.UseVisualStyleBackColor = False
        '
        'btnCarpack
        '
        Me.btnCarpack.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCarpack.Location = New System.Drawing.Point(12, 41)
        Me.btnCarpack.Name = "btnCarpack"
        Me.btnCarpack.Size = New System.Drawing.Size(161, 23)
        Me.btnCarpack.TabIndex = 18
        Me.btnCarpack.Text = "Carpack Config"
        Me.btnCarpack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(337, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 32
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
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "The Unknown © 2021 "
        '
        'VehicleConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.VehiclePlugin.My.Resources.Resources.ProjectCityRPBlur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnCarpack)
        Me.Controls.Add(Me.btnVconfig)
        Me.Controls.Add(Me.Exit1)
        Me.Controls.Add(Me.nudHash)
        Me.Controls.Add(Me.tboxLink)
        Me.Controls.Add(Me.lblImage)
        Me.Controls.Add(Me.tboxOutput2)
        Me.Controls.Add(Me.tboxOutput1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblClicktocopy)
        Me.Controls.Add(Me.lblHash)
        Me.Controls.Add(Me.tboxVname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblPagination)
        Me.Controls.Add(Me.cboxPagination)
        Me.Controls.Add(Me.tboxScode)
        Me.Controls.Add(Me.lblSpawnCode)
        Me.Controls.Add(Me.btnExport)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VehicleConfig"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Config"
        CType(Me.nudHash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Exit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpawnCode As Label
    Friend WithEvents tboxScode As TextBox
    Friend WithEvents cboxPagination As ComboBox
    Friend WithEvents lblPagination As Label
    Friend WithEvents lblName As Label
    Friend WithEvents tboxVname As TextBox
    Friend WithEvents lblHash As Label
    Friend WithEvents lblClicktocopy As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tboxOutput1 As TextBox
    Friend WithEvents tboxOutput2 As TextBox
    Friend WithEvents btnExport As Button
    Friend WithEvents lblImage As Label
    Friend WithEvents tboxLink As TextBox
    Friend WithEvents nudHash As NumericUpDown
    Friend WithEvents vSpawnTooltip As ToolTip
    Friend WithEvents vTypeTooltip As ToolTip
    Friend WithEvents vNameTooltip As ToolTip
    Friend WithEvents vImage As ToolTip
    Friend WithEvents vHashTooltip As ToolTip
    Friend WithEvents clickToCopy As ToolTip
    Friend WithEvents niOutput1 As NotifyIcon
    Friend WithEvents Copied As ToolTip
    Friend WithEvents Exit1 As PictureBox
    Friend WithEvents btnVconfig As Button
    Friend WithEvents btnCarpack As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
