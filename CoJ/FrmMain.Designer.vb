<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.btnLaunchServer = New System.Windows.Forms.Button()
        Me.btnConfigServer = New System.Windows.Forms.Button()
        Me.btnModding = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiveToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomMapsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dialRuta = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblHttp = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLaunchServer
        '
        Me.btnLaunchServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLaunchServer.Location = New System.Drawing.Point(85, 73)
        Me.btnLaunchServer.Name = "btnLaunchServer"
        Me.btnLaunchServer.Size = New System.Drawing.Size(324, 54)
        Me.btnLaunchServer.TabIndex = 0
        Me.btnLaunchServer.Text = "Launch Coj2 Dedicated Server"
        Me.btnLaunchServer.UseVisualStyleBackColor = False
        '
        'btnConfigServer
        '
        Me.btnConfigServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnConfigServer.Location = New System.Drawing.Point(85, 190)
        Me.btnConfigServer.Name = "btnConfigServer"
        Me.btnConfigServer.Size = New System.Drawing.Size(324, 54)
        Me.btnConfigServer.TabIndex = 1
        Me.btnConfigServer.Text = "Config Dedicated Server"
        Me.btnConfigServer.UseVisualStyleBackColor = False
        '
        'btnModding
        '
        Me.btnModding.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnModding.Location = New System.Drawing.Point(85, 307)
        Me.btnModding.Name = "btnModding"
        Me.btnModding.Size = New System.Drawing.Size(324, 54)
        Me.btnModding.TabIndex = 2
        Me.btnModding.Text = "Modding Coj2 Game"
        Me.btnModding.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(493, 583)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiveToolStripMenuItem, Me.DownloadsToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchiveToolStripMenuItem
        '
        Me.ArchiveToolStripMenuItem.AutoSize = False
        Me.ArchiveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiveToolStripMenuItem1, Me.ArchiveToolStripMenuItem2})
        Me.ArchiveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ArchiveToolStripMenuItem.Name = "ArchiveToolStripMenuItem"
        Me.ArchiveToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ArchiveToolStripMenuItem.Text = "Archive   "
        '
        'ArchiveToolStripMenuItem1
        '
        Me.ArchiveToolStripMenuItem1.Name = "ArchiveToolStripMenuItem1"
        Me.ArchiveToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.ArchiveToolStripMenuItem1.Text = "Close"
        '
        'ArchiveToolStripMenuItem2
        '
        Me.ArchiveToolStripMenuItem2.Name = "ArchiveToolStripMenuItem2"
        Me.ArchiveToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
        Me.ArchiveToolStripMenuItem2.Text = "About Mod Coj Controller"
        '
        'DownloadsToolStripMenuItem
        '
        Me.DownloadsToolStripMenuItem.AutoSize = False
        Me.DownloadsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomMapsToolStripMenuItem})
        Me.DownloadsToolStripMenuItem.Name = "DownloadsToolStripMenuItem"
        Me.DownloadsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.DownloadsToolStripMenuItem.Text = "Downloads"
        '
        'CustomMapsToolStripMenuItem
        '
        Me.CustomMapsToolStripMenuItem.Name = "CustomMapsToolStripMenuItem"
        Me.CustomMapsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CustomMapsToolStripMenuItem.Text = "Custom Maps"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(255, 20)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'dialRuta
        '
        Me.dialRuta.Description = "Select your CoJ Bound in Blood dedicated server folder."
        Me.dialRuta.ShowNewFolderButton = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(182, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 23)
        Me.Label1.TabIndex = 6
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(12, 555)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(54, 12)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Ver. 500.0.0"
        '
        'lblHttp
        '
        Me.lblHttp.AutoSize = True
        Me.lblHttp.BackColor = System.Drawing.Color.Transparent
        Me.lblHttp.Font = New System.Drawing.Font("Segoe UI", 8.139131!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHttp.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblHttp.Location = New System.Drawing.Point(9, 571)
        Me.lblHttp.Name = "lblHttp"
        Me.lblHttp.Size = New System.Drawing.Size(131, 13)
        Me.lblHttp.TabIndex = 8
        Me.lblHttp.Text = "http://coj2controller.hol.es"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(493, 607)
        Me.Controls.Add(Me.lblHttp)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModding)
        Me.Controls.Add(Me.btnConfigServer)
        Me.Controls.Add(Me.btnLaunchServer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(509, 646)
        Me.MinimumSize = New System.Drawing.Size(509, 646)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coj2 Controller"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaunchServer As System.Windows.Forms.Button
    Friend WithEvents btnConfigServer As System.Windows.Forms.Button
    Friend WithEvents btnModding As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dialRuta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiveToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DownloadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomMapsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblHttp As System.Windows.Forms.Label
End Class
