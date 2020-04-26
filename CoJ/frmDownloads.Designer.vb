<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownloads
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownloads))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgMaps = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblDownloadingMap = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.FileExist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enlace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMaps
        '
        Me.dgMaps.AllowUserToAddRows = False
        Me.dgMaps.AllowUserToDeleteRows = False
        Me.dgMaps.AllowUserToResizeColumns = False
        Me.dgMaps.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgMaps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMaps.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMaps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMaps.ColumnHeadersHeight = 66
        Me.dgMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMaps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileExist, Me.colMaps, Me.ColMode, Me.Enlace, Me.NombrePak})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMaps.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgMaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaps.EnableHeadersVisualStyles = False
        Me.dgMaps.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgMaps.Location = New System.Drawing.Point(0, 0)
        Me.dgMaps.Margin = New System.Windows.Forms.Padding(2, 20, 2, 2)
        Me.dgMaps.Name = "dgMaps"
        Me.dgMaps.ReadOnly = True
        Me.dgMaps.RowHeadersVisible = False
        Me.dgMaps.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMaps.RowTemplate.ReadOnly = True
        Me.dgMaps.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMaps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgMaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMaps.Size = New System.Drawing.Size(724, 534)
        Me.dgMaps.StandardTab = True
        Me.dgMaps.TabIndex = 48
        Me.dgMaps.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(724, 34)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDownload.Location = New System.Drawing.Point(5, 5)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(129, 25)
        Me.btnDownload.TabIndex = 50
        Me.btnDownload.Text = "DOWNLOAD NOW"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(509, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(160, 9)
        Me.ProgressBar1.TabIndex = 51
        '
        'lblDownloadingMap
        '
        Me.lblDownloadingMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDownloadingMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblDownloadingMap.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloadingMap.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDownloadingMap.Location = New System.Drawing.Point(168, 8)
        Me.lblDownloadingMap.Name = "lblDownloadingMap"
        Me.lblDownloadingMap.Size = New System.Drawing.Size(334, 17)
        Me.lblDownloadingMap.TabIndex = 52
        Me.lblDownloadingMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPercent
        '
        Me.lblPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblPercent.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPercent.Location = New System.Drawing.Point(674, 9)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(29, 15)
        Me.lblPercent.TabIndex = 53
        Me.lblPercent.Text = "99%"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnActualizar.Location = New System.Drawing.Point(140, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnActualizar.Size = New System.Drawing.Size(27, 25)
        Me.btnActualizar.TabIndex = 54
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'FileExist
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FileExist.DefaultCellStyle = DataGridViewCellStyle3
        Me.FileExist.HeaderText = "  File Exist"
        Me.FileExist.Name = "FileExist"
        Me.FileExist.ReadOnly = True
        Me.FileExist.Width = 90
        '
        'colMaps
        '
        Me.colMaps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMaps.DefaultCellStyle = DataGridViewCellStyle4
        Me.colMaps.HeaderText = "List of downloadable maps"
        Me.colMaps.MinimumWidth = 210
        Me.colMaps.Name = "colMaps"
        Me.colMaps.ReadOnly = True
        Me.colMaps.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMaps.ToolTipText = "Maps available to download from Mods Coj2 Controller."
        Me.colMaps.Width = 210
        '
        'ColMode
        '
        Me.ColMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.139131!)
        Me.ColMode.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColMode.HeaderText = "Game Modes"
        Me.ColMode.MinimumWidth = 275
        Me.ColMode.Name = "ColMode"
        Me.ColMode.ReadOnly = True
        Me.ColMode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColMode.ToolTipText = "Game modes contained in each map."
        '
        'Enlace
        '
        Me.Enlace.HeaderText = "Enlace"
        Me.Enlace.Name = "Enlace"
        Me.Enlace.ReadOnly = True
        Me.Enlace.Visible = False
        '
        'NombrePak
        '
        Me.NombrePak.HeaderText = "Nombre Pak"
        Me.NombrePak.Name = "NombrePak"
        Me.NombrePak.ReadOnly = True
        Me.NombrePak.Visible = False
        '
        'frmDownloads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 534)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblDownloadingMap)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgMaps)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1500, 800)
        Me.MinimumSize = New System.Drawing.Size(742, 579)
        Me.Name = "frmDownloads"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoJ2 Controller - Maps Download"
        CType(Me.dgMaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgMaps As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDownloadingMap As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents FileExist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMaps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Enlace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrePak As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
