<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerConfig
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServerConfig))
        Me.panelServerConfig = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPublicSlots = New System.Windows.Forms.TextBox()
        Me.checkFF = New System.Windows.Forms.CheckBox()
        Me.txtPlayersToStart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbInternetLan = New System.Windows.Forms.ComboBox()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtServerPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpWanted = New System.Windows.Forms.GroupBox()
        Me.panelMin4 = New System.Windows.Forms.Panel()
        Me.lblMin4 = New System.Windows.Forms.Label()
        Me.txtTimeWanted = New System.Windows.Forms.TextBox()
        Me.txtBountyWanted = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gpManhunt = New System.Windows.Forms.GroupBox()
        Me.panelMin3 = New System.Windows.Forms.Panel()
        Me.lblMin3 = New System.Windows.Forms.Label()
        Me.txtTimeManhunt = New System.Windows.Forms.TextBox()
        Me.txtPointsManhunt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gpPosse = New System.Windows.Forms.GroupBox()
        Me.panelMin2 = New System.Windows.Forms.Panel()
        Me.lblMin2 = New System.Windows.Forms.Label()
        Me.txtTimePosse = New System.Windows.Forms.TextBox()
        Me.txtBountyPosse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gpDeathmatch = New System.Windows.Forms.GroupBox()
        Me.panelMin1 = New System.Windows.Forms.Panel()
        Me.lblMin1 = New System.Windows.Forms.Label()
        Me.txtTimeDM = New System.Windows.Forms.TextBox()
        Me.txtBountyDM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabMaps = New System.Windows.Forms.TabControl()
        Me.tabTechlandMaps = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgTechlandSelMaps = New System.Windows.Forms.DataGridView()
        Me.Dg2ColumTextBoxMapName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg2ColumTextBoxGamemode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg2ColumTextBoxMapRealName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg2ColumTextBoxGameModeReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTechlandBajar = New System.Windows.Forms.Button()
        Me.btnTechlandSubir = New System.Windows.Forms.Button()
        Me.btnTechlandDel = New System.Windows.Forms.Button()
        Me.btnTechlandAdd = New System.Windows.Forms.Button()
        Me.cbTechlandGameMode = New System.Windows.Forms.ComboBox()
        Me.lbTechlandMaps = New System.Windows.Forms.ListBox()
        Me.tabCustomMaps = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgCustomSelMaps = New System.Windows.Forms.DataGridView()
        Me.Dg3ColumTextBoxMapName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg3ColumTextBoxGameMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg3ColumTextBoxRealName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg3ColumTextBoxGameModeReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCustomBajar = New System.Windows.Forms.Button()
        Me.btnCustomSubir = New System.Windows.Forms.Button()
        Me.btnCustomDel = New System.Windows.Forms.Button()
        Me.btnCustomAdd = New System.Windows.Forms.Button()
        Me.cbCustomGameMode = New System.Windows.Forms.ComboBox()
        Me.lbCustomMaps = New System.Windows.Forms.ListBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnApplyAdmins = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgAdmins = New System.Windows.Forms.DataGridView()
        Me.Dg1ColumTextBoxUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg1ColumTextBoxPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg1ColumTextBoxLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.panelServerConfig.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpWanted.SuspendLayout()
        Me.panelMin4.SuspendLayout()
        Me.gpManhunt.SuspendLayout()
        Me.panelMin3.SuspendLayout()
        Me.gpPosse.SuspendLayout()
        Me.panelMin2.SuspendLayout()
        Me.gpDeathmatch.SuspendLayout()
        Me.panelMin1.SuspendLayout()
        Me.tabMaps.SuspendLayout()
        Me.tabTechlandMaps.SuspendLayout()
        CType(Me.dgTechlandSelMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustomMaps.SuspendLayout()
        CType(Me.dgCustomSelMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelServerConfig
        '
        Me.panelServerConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelServerConfig.Controls.Add(Me.Label16)
        Me.panelServerConfig.Controls.Add(Me.txtPublicSlots)
        Me.panelServerConfig.Controls.Add(Me.checkFF)
        Me.panelServerConfig.Controls.Add(Me.txtPlayersToStart)
        Me.panelServerConfig.Controls.Add(Me.Label4)
        Me.panelServerConfig.Controls.Add(Me.cbInternetLan)
        Me.panelServerConfig.Controls.Add(Me.txtServerPort)
        Me.panelServerConfig.Controls.Add(Me.Label3)
        Me.panelServerConfig.Controls.Add(Me.txtServerPassword)
        Me.panelServerConfig.Controls.Add(Me.Label2)
        Me.panelServerConfig.Controls.Add(Me.txtServerName)
        Me.panelServerConfig.Controls.Add(Me.Label1)
        Me.panelServerConfig.Location = New System.Drawing.Point(12, 21)
        Me.panelServerConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.panelServerConfig.Name = "panelServerConfig"
        Me.panelServerConfig.Size = New System.Drawing.Size(430, 147)
        Me.panelServerConfig.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 113)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Public Slots"
        '
        'txtPublicSlots
        '
        Me.txtPublicSlots.Location = New System.Drawing.Point(140, 110)
        Me.txtPublicSlots.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPublicSlots.MaxLength = 2
        Me.txtPublicSlots.Name = "txtPublicSlots"
        Me.txtPublicSlots.Size = New System.Drawing.Size(40, 22)
        Me.txtPublicSlots.TabIndex = 5
        Me.txtPublicSlots.Text = "10"
        Me.txtPublicSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPublicSlots, "Type here the number of players who can join your server")
        '
        'checkFF
        '
        Me.checkFF.AutoSize = True
        Me.checkFF.Location = New System.Drawing.Point(296, 81)
        Me.checkFF.Margin = New System.Windows.Forms.Padding(4)
        Me.checkFF.Name = "checkFF"
        Me.checkFF.Size = New System.Drawing.Size(105, 21)
        Me.checkFF.TabIndex = 4
        Me.checkFF.Text = "Friendly Fire"
        Me.ToolTip1.SetToolTip(Me.checkFF, "If activated, players can kill their own team players")
        Me.checkFF.UseVisualStyleBackColor = True
        '
        'txtPlayersToStart
        '
        Me.txtPlayersToStart.Location = New System.Drawing.Point(371, 110)
        Me.txtPlayersToStart.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayersToStart.MaxLength = 2
        Me.txtPlayersToStart.Name = "txtPlayersToStart"
        Me.txtPlayersToStart.Size = New System.Drawing.Size(40, 22)
        Me.txtPlayersToStart.TabIndex = 6
        Me.txtPlayersToStart.Text = "1"
        Me.txtPlayersToStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Players to start"
        '
        'cbInternetLan
        '
        Me.cbInternetLan.FormattingEnabled = True
        Me.cbInternetLan.Items.AddRange(New Object() {"LAN", "Internet"})
        Me.cbInternetLan.Location = New System.Drawing.Point(295, 46)
        Me.cbInternetLan.Margin = New System.Windows.Forms.Padding(4)
        Me.cbInternetLan.Name = "cbInternetLan"
        Me.cbInternetLan.Size = New System.Drawing.Size(116, 24)
        Me.cbInternetLan.TabIndex = 2
        Me.cbInternetLan.Text = "LAN"
        Me.ToolTip1.SetToolTip(Me.cbInternetLan, "Select LAN or INTERNET to set up your Coj2 server.")
        '
        'txtServerPort
        '
        Me.txtServerPort.Location = New System.Drawing.Point(140, 79)
        Me.txtServerPort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServerPort.MaxLength = 5
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(105, 22)
        Me.txtServerPort.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtServerPort, "Enter here the port you are going to use to set up your server, which have to be " & _
        "open in your firewall")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Server Port"
        '
        'txtServerPassword
        '
        Me.txtServerPassword.Location = New System.Drawing.Point(140, 46)
        Me.txtServerPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServerPassword.MaxLength = 20
        Me.txtServerPassword.Name = "txtServerPassword"
        Me.txtServerPassword.Size = New System.Drawing.Size(145, 22)
        Me.txtServerPassword.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtServerPassword, "Choose a password for your Dedicated Server")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server Password"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(140, 12)
        Me.txtServerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServerName.MaxLength = 40
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(271, 22)
        Me.txtServerName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtServerName, "Choose a name for your Dedicated Server")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.gpWanted)
        Me.Panel1.Controls.Add(Me.gpManhunt)
        Me.Panel1.Controls.Add(Me.gpPosse)
        Me.Panel1.Controls.Add(Me.gpDeathmatch)
        Me.Panel1.Location = New System.Drawing.Point(12, 176)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 267)
        Me.Panel1.TabIndex = 1
        '
        'gpWanted
        '
        Me.gpWanted.BackColor = System.Drawing.SystemColors.Control
        Me.gpWanted.Controls.Add(Me.panelMin4)
        Me.gpWanted.Controls.Add(Me.txtBountyWanted)
        Me.gpWanted.Controls.Add(Me.Label11)
        Me.gpWanted.Controls.Add(Me.Label12)
        Me.gpWanted.Location = New System.Drawing.Point(222, 133)
        Me.gpWanted.Margin = New System.Windows.Forms.Padding(4)
        Me.gpWanted.Name = "gpWanted"
        Me.gpWanted.Padding = New System.Windows.Forms.Padding(4)
        Me.gpWanted.Size = New System.Drawing.Size(195, 117)
        Me.gpWanted.TabIndex = 5
        Me.gpWanted.TabStop = False
        Me.gpWanted.Text = "Wanted"
        '
        'panelMin4
        '
        Me.panelMin4.BackColor = System.Drawing.SystemColors.Window
        Me.panelMin4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMin4.Controls.Add(Me.lblMin4)
        Me.panelMin4.Controls.Add(Me.txtTimeWanted)
        Me.panelMin4.Location = New System.Drawing.Point(103, 74)
        Me.panelMin4.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMin4.Name = "panelMin4"
        Me.panelMin4.Size = New System.Drawing.Size(68, 24)
        Me.panelMin4.TabIndex = 103
        '
        'lblMin4
        '
        Me.lblMin4.AutoSize = True
        Me.lblMin4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMin4.Location = New System.Drawing.Point(35, 2)
        Me.lblMin4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMin4.Name = "lblMin4"
        Me.lblMin4.Size = New System.Drawing.Size(30, 17)
        Me.lblMin4.TabIndex = 2
        Me.lblMin4.Text = "min"
        '
        'txtTimeWanted
        '
        Me.txtTimeWanted.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeWanted.Location = New System.Drawing.Point(1, 4)
        Me.txtTimeWanted.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeWanted.MaxLength = 3
        Me.txtTimeWanted.Name = "txtTimeWanted"
        Me.txtTimeWanted.Size = New System.Drawing.Size(39, 15)
        Me.txtTimeWanted.TabIndex = 14
        Me.txtTimeWanted.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtTimeWanted, "0 = No time limit")
        '
        'txtBountyWanted
        '
        Me.txtBountyWanted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBountyWanted.Location = New System.Drawing.Point(103, 32)
        Me.txtBountyWanted.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBountyWanted.MaxLength = 5
        Me.txtBountyWanted.Name = "txtBountyWanted"
        Me.txtBountyWanted.Size = New System.Drawing.Size(68, 22)
        Me.txtBountyWanted.TabIndex = 13
        Me.txtBountyWanted.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtBountyWanted, "0 = No bounty limit")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 76)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Time Limit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 36)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Bounty Limit"
        '
        'gpManhunt
        '
        Me.gpManhunt.BackColor = System.Drawing.SystemColors.Control
        Me.gpManhunt.Controls.Add(Me.panelMin3)
        Me.gpManhunt.Controls.Add(Me.txtPointsManhunt)
        Me.gpManhunt.Controls.Add(Me.Label9)
        Me.gpManhunt.Controls.Add(Me.Label10)
        Me.gpManhunt.Location = New System.Drawing.Point(9, 133)
        Me.gpManhunt.Margin = New System.Windows.Forms.Padding(4)
        Me.gpManhunt.Name = "gpManhunt"
        Me.gpManhunt.Padding = New System.Windows.Forms.Padding(4)
        Me.gpManhunt.Size = New System.Drawing.Size(198, 117)
        Me.gpManhunt.TabIndex = 4
        Me.gpManhunt.TabStop = False
        Me.gpManhunt.Text = "Manhunt"
        '
        'panelMin3
        '
        Me.panelMin3.BackColor = System.Drawing.SystemColors.Window
        Me.panelMin3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMin3.Controls.Add(Me.lblMin3)
        Me.panelMin3.Controls.Add(Me.txtTimeManhunt)
        Me.panelMin3.Location = New System.Drawing.Point(103, 73)
        Me.panelMin3.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMin3.Name = "panelMin3"
        Me.panelMin3.Size = New System.Drawing.Size(68, 24)
        Me.panelMin3.TabIndex = 102
        '
        'lblMin3
        '
        Me.lblMin3.AutoSize = True
        Me.lblMin3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMin3.Location = New System.Drawing.Point(36, 2)
        Me.lblMin3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMin3.Name = "lblMin3"
        Me.lblMin3.Size = New System.Drawing.Size(30, 17)
        Me.lblMin3.TabIndex = 2
        Me.lblMin3.Text = "min"
        '
        'txtTimeManhunt
        '
        Me.txtTimeManhunt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeManhunt.Location = New System.Drawing.Point(1, 4)
        Me.txtTimeManhunt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeManhunt.MaxLength = 3
        Me.txtTimeManhunt.Name = "txtTimeManhunt"
        Me.txtTimeManhunt.Size = New System.Drawing.Size(39, 15)
        Me.txtTimeManhunt.TabIndex = 12
        Me.txtTimeManhunt.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtTimeManhunt, "0 = No time limit")
        '
        'txtPointsManhunt
        '
        Me.txtPointsManhunt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPointsManhunt.Location = New System.Drawing.Point(103, 32)
        Me.txtPointsManhunt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPointsManhunt.MaxLength = 2
        Me.txtPointsManhunt.Name = "txtPointsManhunt"
        Me.txtPointsManhunt.Size = New System.Drawing.Size(68, 22)
        Me.txtPointsManhunt.TabIndex = 11
        Me.txtPointsManhunt.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtPointsManhunt, "0 = No points limit")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Time Limit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Points Limit"
        '
        'gpPosse
        '
        Me.gpPosse.BackColor = System.Drawing.SystemColors.Control
        Me.gpPosse.Controls.Add(Me.panelMin2)
        Me.gpPosse.Controls.Add(Me.txtBountyPosse)
        Me.gpPosse.Controls.Add(Me.Label7)
        Me.gpPosse.Controls.Add(Me.Label8)
        Me.gpPosse.Location = New System.Drawing.Point(222, 9)
        Me.gpPosse.Margin = New System.Windows.Forms.Padding(4)
        Me.gpPosse.Name = "gpPosse"
        Me.gpPosse.Padding = New System.Windows.Forms.Padding(4)
        Me.gpPosse.Size = New System.Drawing.Size(195, 114)
        Me.gpPosse.TabIndex = 3
        Me.gpPosse.TabStop = False
        Me.gpPosse.Text = "Posse"
        '
        'panelMin2
        '
        Me.panelMin2.BackColor = System.Drawing.SystemColors.Window
        Me.panelMin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMin2.Controls.Add(Me.lblMin2)
        Me.panelMin2.Controls.Add(Me.txtTimePosse)
        Me.panelMin2.Location = New System.Drawing.Point(109, 72)
        Me.panelMin2.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMin2.Name = "panelMin2"
        Me.panelMin2.Size = New System.Drawing.Size(65, 24)
        Me.panelMin2.TabIndex = 101
        '
        'lblMin2
        '
        Me.lblMin2.AutoSize = True
        Me.lblMin2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMin2.Location = New System.Drawing.Point(33, 2)
        Me.lblMin2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMin2.Name = "lblMin2"
        Me.lblMin2.Size = New System.Drawing.Size(30, 17)
        Me.lblMin2.TabIndex = 2
        Me.lblMin2.Text = "min"
        '
        'txtTimePosse
        '
        Me.txtTimePosse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimePosse.Location = New System.Drawing.Point(1, 4)
        Me.txtTimePosse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimePosse.MaxLength = 3
        Me.txtTimePosse.Name = "txtTimePosse"
        Me.txtTimePosse.Size = New System.Drawing.Size(39, 15)
        Me.txtTimePosse.TabIndex = 10
        Me.txtTimePosse.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtTimePosse, "0 = No time limit")
        '
        'txtBountyPosse
        '
        Me.txtBountyPosse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBountyPosse.Location = New System.Drawing.Point(109, 31)
        Me.txtBountyPosse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBountyPosse.MaxLength = 5
        Me.txtBountyPosse.Name = "txtBountyPosse"
        Me.txtBountyPosse.Size = New System.Drawing.Size(65, 22)
        Me.txtBountyPosse.TabIndex = 9
        Me.txtBountyPosse.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtBountyPosse, "0 = No bounty limit")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Time Limit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Bounty Limit"
        '
        'gpDeathmatch
        '
        Me.gpDeathmatch.BackColor = System.Drawing.SystemColors.Control
        Me.gpDeathmatch.Controls.Add(Me.panelMin1)
        Me.gpDeathmatch.Controls.Add(Me.txtBountyDM)
        Me.gpDeathmatch.Controls.Add(Me.Label6)
        Me.gpDeathmatch.Controls.Add(Me.Label5)
        Me.gpDeathmatch.Location = New System.Drawing.Point(12, 9)
        Me.gpDeathmatch.Margin = New System.Windows.Forms.Padding(4)
        Me.gpDeathmatch.Name = "gpDeathmatch"
        Me.gpDeathmatch.Padding = New System.Windows.Forms.Padding(4)
        Me.gpDeathmatch.Size = New System.Drawing.Size(195, 114)
        Me.gpDeathmatch.TabIndex = 2
        Me.gpDeathmatch.TabStop = False
        Me.gpDeathmatch.Text = "Deathmatch"
        '
        'panelMin1
        '
        Me.panelMin1.BackColor = System.Drawing.SystemColors.Window
        Me.panelMin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMin1.Controls.Add(Me.lblMin1)
        Me.panelMin1.Controls.Add(Me.txtTimeDM)
        Me.panelMin1.Location = New System.Drawing.Point(106, 71)
        Me.panelMin1.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMin1.Name = "panelMin1"
        Me.panelMin1.Size = New System.Drawing.Size(68, 24)
        Me.panelMin1.TabIndex = 100
        '
        'lblMin1
        '
        Me.lblMin1.AutoSize = True
        Me.lblMin1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMin1.Location = New System.Drawing.Point(37, 2)
        Me.lblMin1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMin1.Name = "lblMin1"
        Me.lblMin1.Size = New System.Drawing.Size(30, 17)
        Me.lblMin1.TabIndex = 2
        Me.lblMin1.Text = "min"
        '
        'txtTimeDM
        '
        Me.txtTimeDM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeDM.Location = New System.Drawing.Point(1, 4)
        Me.txtTimeDM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeDM.MaxLength = 3
        Me.txtTimeDM.Name = "txtTimeDM"
        Me.txtTimeDM.Size = New System.Drawing.Size(39, 15)
        Me.txtTimeDM.TabIndex = 8
        Me.txtTimeDM.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtTimeDM, "0 = No time limit")
        '
        'txtBountyDM
        '
        Me.txtBountyDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBountyDM.Location = New System.Drawing.Point(106, 32)
        Me.txtBountyDM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBountyDM.MaxLength = 5
        Me.txtBountyDM.Name = "txtBountyDM"
        Me.txtBountyDM.Size = New System.Drawing.Size(68, 22)
        Me.txtBountyDM.TabIndex = 7
        Me.txtBountyDM.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtBountyDM, "0 = No bounty limit")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Time Limit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bounty Limit"
        '
        'tabMaps
        '
        Me.tabMaps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMaps.Controls.Add(Me.tabTechlandMaps)
        Me.tabMaps.Controls.Add(Me.tabCustomMaps)
        Me.tabMaps.Location = New System.Drawing.Point(457, 21)
        Me.tabMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMaps.Name = "tabMaps"
        Me.tabMaps.SelectedIndex = 0
        Me.tabMaps.Size = New System.Drawing.Size(627, 640)
        Me.tabMaps.TabIndex = 2
        '
        'tabTechlandMaps
        '
        Me.tabTechlandMaps.BackColor = System.Drawing.SystemColors.Control
        Me.tabTechlandMaps.Controls.Add(Me.Label14)
        Me.tabTechlandMaps.Controls.Add(Me.dgTechlandSelMaps)
        Me.tabTechlandMaps.Controls.Add(Me.btnTechlandBajar)
        Me.tabTechlandMaps.Controls.Add(Me.btnTechlandSubir)
        Me.tabTechlandMaps.Controls.Add(Me.btnTechlandDel)
        Me.tabTechlandMaps.Controls.Add(Me.btnTechlandAdd)
        Me.tabTechlandMaps.Controls.Add(Me.cbTechlandGameMode)
        Me.tabTechlandMaps.Controls.Add(Me.lbTechlandMaps)
        Me.tabTechlandMaps.Location = New System.Drawing.Point(4, 25)
        Me.tabTechlandMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.tabTechlandMaps.Name = "tabTechlandMaps"
        Me.tabTechlandMaps.Padding = New System.Windows.Forms.Padding(4)
        Me.tabTechlandMaps.Size = New System.Drawing.Size(619, 616)
        Me.tabTechlandMaps.TabIndex = 0
        Me.tabTechlandMaps.Text = "Techland Maps"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(4, 567)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(528, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "*Custom maps will never be mixed with Official Techland maps in dedicated servers" & _
    ""
        '
        'dgTechlandSelMaps
        '
        Me.dgTechlandSelMaps.AllowUserToAddRows = False
        Me.dgTechlandSelMaps.AllowUserToResizeColumns = False
        Me.dgTechlandSelMaps.AllowUserToResizeRows = False
        Me.dgTechlandSelMaps.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTechlandSelMaps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTechlandSelMaps.ColumnHeadersHeight = 25
        Me.dgTechlandSelMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgTechlandSelMaps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dg2ColumTextBoxMapName, Me.Dg2ColumTextBoxGamemode, Me.Dg2ColumTextBoxMapRealName, Me.Dg2ColumTextBoxGameModeReal})
        Me.dgTechlandSelMaps.EnableHeadersVisualStyles = False
        Me.dgTechlandSelMaps.Location = New System.Drawing.Point(334, 19)
        Me.dgTechlandSelMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTechlandSelMaps.MultiSelect = False
        Me.dgTechlandSelMaps.Name = "dgTechlandSelMaps"
        Me.dgTechlandSelMaps.ReadOnly = True
        Me.dgTechlandSelMaps.RowHeadersVisible = False
        Me.dgTechlandSelMaps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTechlandSelMaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTechlandSelMaps.Size = New System.Drawing.Size(268, 484)
        Me.dgTechlandSelMaps.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.dgTechlandSelMaps, "Map list to set up the server.")
        '
        'Dg2ColumTextBoxMapName
        '
        Me.Dg2ColumTextBoxMapName.Frozen = True
        Me.Dg2ColumTextBoxMapName.HeaderText = "Map Name"
        Me.Dg2ColumTextBoxMapName.Name = "Dg2ColumTextBoxMapName"
        Me.Dg2ColumTextBoxMapName.ReadOnly = True
        Me.Dg2ColumTextBoxMapName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dg2ColumTextBoxMapName.Width = 130
        '
        'Dg2ColumTextBoxGamemode
        '
        Me.Dg2ColumTextBoxGamemode.Frozen = True
        Me.Dg2ColumTextBoxGamemode.HeaderText = "Game Mode"
        Me.Dg2ColumTextBoxGamemode.Name = "Dg2ColumTextBoxGamemode"
        Me.Dg2ColumTextBoxGamemode.ReadOnly = True
        Me.Dg2ColumTextBoxGamemode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dg2ColumTextBoxGamemode.Width = 107
        '
        'Dg2ColumTextBoxMapRealName
        '
        Me.Dg2ColumTextBoxMapRealName.Frozen = True
        Me.Dg2ColumTextBoxMapRealName.HeaderText = "Real Name"
        Me.Dg2ColumTextBoxMapRealName.Name = "Dg2ColumTextBoxMapRealName"
        Me.Dg2ColumTextBoxMapRealName.ReadOnly = True
        Me.Dg2ColumTextBoxMapRealName.Visible = False
        '
        'Dg2ColumTextBoxGameModeReal
        '
        Me.Dg2ColumTextBoxGameModeReal.Frozen = True
        Me.Dg2ColumTextBoxGameModeReal.HeaderText = "Game Mode Real"
        Me.Dg2ColumTextBoxGameModeReal.Name = "Dg2ColumTextBoxGameModeReal"
        Me.Dg2ColumTextBoxGameModeReal.ReadOnly = True
        Me.Dg2ColumTextBoxGameModeReal.Visible = False
        '
        'btnTechlandBajar
        '
        Me.btnTechlandBajar.Location = New System.Drawing.Point(263, 186)
        Me.btnTechlandBajar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTechlandBajar.Name = "btnTechlandBajar"
        Me.btnTechlandBajar.Size = New System.Drawing.Size(43, 28)
        Me.btnTechlandBajar.TabIndex = 6
        Me.btnTechlandBajar.TabStop = False
        Me.btnTechlandBajar.Text = "↓"
        Me.btnTechlandBajar.UseVisualStyleBackColor = True
        '
        'btnTechlandSubir
        '
        Me.btnTechlandSubir.Location = New System.Drawing.Point(263, 84)
        Me.btnTechlandSubir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTechlandSubir.Name = "btnTechlandSubir"
        Me.btnTechlandSubir.Size = New System.Drawing.Size(43, 28)
        Me.btnTechlandSubir.TabIndex = 5
        Me.btnTechlandSubir.TabStop = False
        Me.btnTechlandSubir.Text = "↑"
        Me.btnTechlandSubir.UseVisualStyleBackColor = True
        '
        'btnTechlandDel
        '
        Me.btnTechlandDel.Location = New System.Drawing.Point(263, 153)
        Me.btnTechlandDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTechlandDel.Name = "btnTechlandDel"
        Me.btnTechlandDel.Size = New System.Drawing.Size(43, 28)
        Me.btnTechlandDel.TabIndex = 4
        Me.btnTechlandDel.TabStop = False
        Me.btnTechlandDel.Text = "←"
        Me.btnTechlandDel.UseVisualStyleBackColor = True
        '
        'btnTechlandAdd
        '
        Me.btnTechlandAdd.Location = New System.Drawing.Point(263, 117)
        Me.btnTechlandAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTechlandAdd.Name = "btnTechlandAdd"
        Me.btnTechlandAdd.Size = New System.Drawing.Size(43, 28)
        Me.btnTechlandAdd.TabIndex = 3
        Me.btnTechlandAdd.TabStop = False
        Me.btnTechlandAdd.Text = "→"
        Me.btnTechlandAdd.UseVisualStyleBackColor = True
        '
        'cbTechlandGameMode
        '
        Me.cbTechlandGameMode.FormattingEnabled = True
        Me.cbTechlandGameMode.Items.AddRange(New Object() {"Deathmatch", "Posse", "Manhunt", "Wanted", "WWL"})
        Me.cbTechlandGameMode.Location = New System.Drawing.Point(19, 518)
        Me.cbTechlandGameMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTechlandGameMode.Name = "cbTechlandGameMode"
        Me.cbTechlandGameMode.Size = New System.Drawing.Size(219, 24)
        Me.cbTechlandGameMode.TabIndex = 17
        Me.cbTechlandGameMode.Text = "Deathmatch"
        Me.ToolTip1.SetToolTip(Me.cbTechlandGameMode, "Choose the game mode for each map when you add them.")
        '
        'lbTechlandMaps
        '
        Me.lbTechlandMaps.FormattingEnabled = True
        Me.lbTechlandMaps.ItemHeight = 16
        Me.lbTechlandMaps.Items.AddRange(New Object() {"Taos Pueblo", "Burnside's Bridge", "Coffeyville", "Frisco", "Magnificent", "Nogales", "Stinking Springs", "Tombstone"})
        Me.lbTechlandMaps.Location = New System.Drawing.Point(18, 19)
        Me.lbTechlandMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.lbTechlandMaps.Name = "lbTechlandMaps"
        Me.lbTechlandMaps.Size = New System.Drawing.Size(220, 484)
        Me.lbTechlandMaps.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.lbTechlandMaps, "Available official map list.")
        '
        'tabCustomMaps
        '
        Me.tabCustomMaps.BackColor = System.Drawing.SystemColors.Control
        Me.tabCustomMaps.Controls.Add(Me.Label17)
        Me.tabCustomMaps.Controls.Add(Me.Label13)
        Me.tabCustomMaps.Controls.Add(Me.dgCustomSelMaps)
        Me.tabCustomMaps.Controls.Add(Me.btnCustomBajar)
        Me.tabCustomMaps.Controls.Add(Me.btnCustomSubir)
        Me.tabCustomMaps.Controls.Add(Me.btnCustomDel)
        Me.tabCustomMaps.Controls.Add(Me.btnCustomAdd)
        Me.tabCustomMaps.Controls.Add(Me.cbCustomGameMode)
        Me.tabCustomMaps.Controls.Add(Me.lbCustomMaps)
        Me.tabCustomMaps.Location = New System.Drawing.Point(4, 25)
        Me.tabCustomMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCustomMaps.Name = "tabCustomMaps"
        Me.tabCustomMaps.Padding = New System.Windows.Forms.Padding(4)
        Me.tabCustomMaps.Size = New System.Drawing.Size(619, 611)
        Me.tabCustomMaps.TabIndex = 1
        Me.tabCustomMaps.Text = "Custom Maps"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(4, 567)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(528, 17)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "*Custom maps will never be mixed with Official Techland maps in dedicated servers" & _
    ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.IndianRed
        Me.Label13.Location = New System.Drawing.Point(4, 546)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(473, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "*You should know which game modes are supported for each custom map"
        '
        'dgCustomSelMaps
        '
        Me.dgCustomSelMaps.AllowUserToAddRows = False
        Me.dgCustomSelMaps.AllowUserToResizeColumns = False
        Me.dgCustomSelMaps.AllowUserToResizeRows = False
        Me.dgCustomSelMaps.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCustomSelMaps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgCustomSelMaps.ColumnHeadersHeight = 25
        Me.dgCustomSelMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCustomSelMaps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dg3ColumTextBoxMapName, Me.Dg3ColumTextBoxGameMode, Me.Dg3ColumTextBoxRealName, Me.Dg3ColumTextBoxGameModeReal})
        Me.dgCustomSelMaps.EnableHeadersVisualStyles = False
        Me.dgCustomSelMaps.Location = New System.Drawing.Point(334, 19)
        Me.dgCustomSelMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.dgCustomSelMaps.MultiSelect = False
        Me.dgCustomSelMaps.Name = "dgCustomSelMaps"
        Me.dgCustomSelMaps.ReadOnly = True
        Me.dgCustomSelMaps.RowHeadersVisible = False
        Me.dgCustomSelMaps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgCustomSelMaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCustomSelMaps.Size = New System.Drawing.Size(268, 484)
        Me.dgCustomSelMaps.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.dgCustomSelMaps, "Map list to set up the server.")
        '
        'Dg3ColumTextBoxMapName
        '
        Me.Dg3ColumTextBoxMapName.Frozen = True
        Me.Dg3ColumTextBoxMapName.HeaderText = "Map Name"
        Me.Dg3ColumTextBoxMapName.Name = "Dg3ColumTextBoxMapName"
        Me.Dg3ColumTextBoxMapName.ReadOnly = True
        Me.Dg3ColumTextBoxMapName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dg3ColumTextBoxMapName.Width = 130
        '
        'Dg3ColumTextBoxGameMode
        '
        Me.Dg3ColumTextBoxGameMode.Frozen = True
        Me.Dg3ColumTextBoxGameMode.HeaderText = "Game Mode"
        Me.Dg3ColumTextBoxGameMode.Name = "Dg3ColumTextBoxGameMode"
        Me.Dg3ColumTextBoxGameMode.ReadOnly = True
        Me.Dg3ColumTextBoxGameMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dg3ColumTextBoxGameMode.Width = 107
        '
        'Dg3ColumTextBoxRealName
        '
        Me.Dg3ColumTextBoxRealName.Frozen = True
        Me.Dg3ColumTextBoxRealName.HeaderText = "Real Name"
        Me.Dg3ColumTextBoxRealName.Name = "Dg3ColumTextBoxRealName"
        Me.Dg3ColumTextBoxRealName.ReadOnly = True
        Me.Dg3ColumTextBoxRealName.Visible = False
        '
        'Dg3ColumTextBoxGameModeReal
        '
        Me.Dg3ColumTextBoxGameModeReal.Frozen = True
        Me.Dg3ColumTextBoxGameModeReal.HeaderText = "Game Mode Real"
        Me.Dg3ColumTextBoxGameModeReal.Name = "Dg3ColumTextBoxGameModeReal"
        Me.Dg3ColumTextBoxGameModeReal.ReadOnly = True
        Me.Dg3ColumTextBoxGameModeReal.Visible = False
        '
        'btnCustomBajar
        '
        Me.btnCustomBajar.Location = New System.Drawing.Point(263, 203)
        Me.btnCustomBajar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomBajar.Name = "btnCustomBajar"
        Me.btnCustomBajar.Size = New System.Drawing.Size(43, 28)
        Me.btnCustomBajar.TabIndex = 13
        Me.btnCustomBajar.TabStop = False
        Me.btnCustomBajar.Text = "↓"
        Me.btnCustomBajar.UseVisualStyleBackColor = True
        '
        'btnCustomSubir
        '
        Me.btnCustomSubir.Location = New System.Drawing.Point(263, 101)
        Me.btnCustomSubir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomSubir.Name = "btnCustomSubir"
        Me.btnCustomSubir.Size = New System.Drawing.Size(43, 28)
        Me.btnCustomSubir.TabIndex = 12
        Me.btnCustomSubir.TabStop = False
        Me.btnCustomSubir.Text = "↑"
        Me.btnCustomSubir.UseVisualStyleBackColor = True
        '
        'btnCustomDel
        '
        Me.btnCustomDel.Location = New System.Drawing.Point(263, 170)
        Me.btnCustomDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomDel.Name = "btnCustomDel"
        Me.btnCustomDel.Size = New System.Drawing.Size(43, 28)
        Me.btnCustomDel.TabIndex = 11
        Me.btnCustomDel.TabStop = False
        Me.btnCustomDel.Text = "←"
        Me.btnCustomDel.UseVisualStyleBackColor = True
        '
        'btnCustomAdd
        '
        Me.btnCustomAdd.Location = New System.Drawing.Point(263, 134)
        Me.btnCustomAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomAdd.Name = "btnCustomAdd"
        Me.btnCustomAdd.Size = New System.Drawing.Size(43, 28)
        Me.btnCustomAdd.TabIndex = 10
        Me.btnCustomAdd.TabStop = False
        Me.btnCustomAdd.Text = "→"
        Me.btnCustomAdd.UseVisualStyleBackColor = True
        '
        'cbCustomGameMode
        '
        Me.cbCustomGameMode.FormattingEnabled = True
        Me.cbCustomGameMode.Items.AddRange(New Object() {"Deathmatch", "Posse", "Manhunt", "Wanted", "WWL"})
        Me.cbCustomGameMode.Location = New System.Drawing.Point(19, 518)
        Me.cbCustomGameMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCustomGameMode.Name = "cbCustomGameMode"
        Me.cbCustomGameMode.Size = New System.Drawing.Size(219, 24)
        Me.cbCustomGameMode.TabIndex = 17
        Me.cbCustomGameMode.Text = "Deathmatch"
        Me.ToolTip1.SetToolTip(Me.cbCustomGameMode, "Choose the game mode for each map when you add them.")
        '
        'lbCustomMaps
        '
        Me.lbCustomMaps.FormattingEnabled = True
        Me.lbCustomMaps.ItemHeight = 16
        Me.lbCustomMaps.Location = New System.Drawing.Point(18, 19)
        Me.lbCustomMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.lbCustomMaps.Name = "lbCustomMaps"
        Me.lbCustomMaps.Size = New System.Drawing.Size(220, 484)
        Me.lbCustomMaps.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.lbCustomMaps, "Available custom map list.")
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(968, 676)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(100, 28)
        Me.btnApply.TabIndex = 3
        Me.btnApply.TabStop = False
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnApplyAdmins)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.dgAdmins)
        Me.Panel2.Location = New System.Drawing.Point(12, 472)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 232)
        Me.Panel2.TabIndex = 4
        '
        'btnApplyAdmins
        '
        Me.btnApplyAdmins.Location = New System.Drawing.Point(291, 196)
        Me.btnApplyAdmins.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApplyAdmins.Name = "btnApplyAdmins"
        Me.btnApplyAdmins.Size = New System.Drawing.Size(120, 28)
        Me.btnApplyAdmins.TabIndex = 19
        Me.btnApplyAdmins.TabStop = False
        Me.btnApplyAdmins.Text = "Apply Admins"
        Me.btnApplyAdmins.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Info
        Me.Label15.Location = New System.Drawing.Point(-1, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(430, 28)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Server Admins Login"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgAdmins
        '
        Me.dgAdmins.AllowUserToResizeColumns = False
        Me.dgAdmins.AllowUserToResizeRows = False
        Me.dgAdmins.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAdmins.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgAdmins.ColumnHeadersHeight = 25
        Me.dgAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgAdmins.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dg1ColumTextBoxUser, Me.Dg1ColumTextBoxPassword, Me.Dg1ColumTextBoxLevel})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAdmins.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgAdmins.EnableHeadersVisualStyles = False
        Me.dgAdmins.Location = New System.Drawing.Point(-1, 28)
        Me.dgAdmins.Margin = New System.Windows.Forms.Padding(4)
        Me.dgAdmins.MultiSelect = False
        Me.dgAdmins.Name = "dgAdmins"
        Me.dgAdmins.RowHeadersWidth = 15
        Me.dgAdmins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgAdmins.Size = New System.Drawing.Size(430, 160)
        Me.dgAdmins.TabIndex = 15
        '
        'Dg1ColumTextBoxUser
        '
        Me.Dg1ColumTextBoxUser.Frozen = True
        Me.Dg1ColumTextBoxUser.HeaderText = "User"
        Me.Dg1ColumTextBoxUser.MaxInputLength = 15
        Me.Dg1ColumTextBoxUser.Name = "Dg1ColumTextBoxUser"
        Me.Dg1ColumTextBoxUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dg1ColumTextBoxUser.Width = 130
        '
        'Dg1ColumTextBoxPassword
        '
        Me.Dg1ColumTextBoxPassword.Frozen = True
        Me.Dg1ColumTextBoxPassword.HeaderText = "Password"
        Me.Dg1ColumTextBoxPassword.MaxInputLength = 15
        Me.Dg1ColumTextBoxPassword.Name = "Dg1ColumTextBoxPassword"
        Me.Dg1ColumTextBoxPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dg1ColumTextBoxPassword.Width = 130
        '
        'Dg1ColumTextBoxLevel
        '
        Me.Dg1ColumTextBoxLevel.Frozen = True
        Me.Dg1ColumTextBoxLevel.HeaderText = "Level"
        Me.Dg1ColumTextBoxLevel.Items.AddRange(New Object() {"Standard", "Full"})
        Me.Dg1ColumTextBoxLevel.Name = "Dg1ColumTextBoxLevel"
        Me.Dg1ColumTextBoxLevel.Width = 93
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 350
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEstado.Location = New System.Drawing.Point(464, 673)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(476, 28)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Label Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.AutoSize = True
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(984, 7)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 29)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "CoJ Mods.chm"
        '
        'frmServerConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 718)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.tabMaps)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelServerConfig)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1557, 894)
        Me.MinimumSize = New System.Drawing.Size(1117, 764)
        Me.Name = "frmServerConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coj2 Controller - Server Config"
        Me.panelServerConfig.ResumeLayout(False)
        Me.panelServerConfig.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gpWanted.ResumeLayout(False)
        Me.gpWanted.PerformLayout()
        Me.panelMin4.ResumeLayout(False)
        Me.panelMin4.PerformLayout()
        Me.gpManhunt.ResumeLayout(False)
        Me.gpManhunt.PerformLayout()
        Me.panelMin3.ResumeLayout(False)
        Me.panelMin3.PerformLayout()
        Me.gpPosse.ResumeLayout(False)
        Me.gpPosse.PerformLayout()
        Me.panelMin2.ResumeLayout(False)
        Me.panelMin2.PerformLayout()
        Me.gpDeathmatch.ResumeLayout(False)
        Me.gpDeathmatch.PerformLayout()
        Me.panelMin1.ResumeLayout(False)
        Me.panelMin1.PerformLayout()
        Me.tabMaps.ResumeLayout(False)
        Me.tabTechlandMaps.ResumeLayout(False)
        Me.tabTechlandMaps.PerformLayout()
        CType(Me.dgTechlandSelMaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustomMaps.ResumeLayout(False)
        Me.tabCustomMaps.PerformLayout()
        CType(Me.dgCustomSelMaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelServerConfig As System.Windows.Forms.Panel
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbInternetLan As System.Windows.Forms.ComboBox
    Friend WithEvents txtServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPlayersToStart As System.Windows.Forms.TextBox
    Friend WithEvents checkFF As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpDeathmatch As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimeDM As System.Windows.Forms.TextBox
    Friend WithEvents txtBountyDM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpPosse As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimePosse As System.Windows.Forms.TextBox
    Friend WithEvents txtBountyPosse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gpManhunt As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimeManhunt As System.Windows.Forms.TextBox
    Friend WithEvents txtPointsManhunt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gpWanted As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimeWanted As System.Windows.Forms.TextBox
    Friend WithEvents txtBountyWanted As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tabMaps As System.Windows.Forms.TabControl
    Friend WithEvents tabTechlandMaps As System.Windows.Forms.TabPage
    Friend WithEvents tabCustomMaps As System.Windows.Forms.TabPage
    Friend WithEvents lbTechlandMaps As System.Windows.Forms.ListBox
    Friend WithEvents btnTechlandDel As System.Windows.Forms.Button
    Friend WithEvents btnTechlandAdd As System.Windows.Forms.Button
    Friend WithEvents cbTechlandGameMode As System.Windows.Forms.ComboBox
    Friend WithEvents btnTechlandSubir As System.Windows.Forms.Button
    Friend WithEvents btnTechlandBajar As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCustomBajar As System.Windows.Forms.Button
    Friend WithEvents btnCustomSubir As System.Windows.Forms.Button
    Friend WithEvents btnCustomDel As System.Windows.Forms.Button
    Friend WithEvents btnCustomAdd As System.Windows.Forms.Button
    Friend WithEvents cbCustomGameMode As System.Windows.Forms.ComboBox
    Friend WithEvents lbCustomMaps As System.Windows.Forms.ListBox
    Friend WithEvents dgTechlandSelMaps As System.Windows.Forms.DataGridView
    Friend WithEvents dgCustomSelMaps As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgAdmins As System.Windows.Forms.DataGridView
    Friend WithEvents btnApplyAdmins As System.Windows.Forms.Button
    Friend WithEvents panelMin2 As System.Windows.Forms.Panel
    Friend WithEvents panelMin4 As System.Windows.Forms.Panel
    Friend WithEvents lblMin4 As System.Windows.Forms.Label
    Friend WithEvents panelMin3 As System.Windows.Forms.Panel
    Friend WithEvents lblMin3 As System.Windows.Forms.Label
    Friend WithEvents lblMin2 As System.Windows.Forms.Label
    Friend WithEvents panelMin1 As System.Windows.Forms.Panel
    Friend WithEvents lblMin1 As System.Windows.Forms.Label
    Friend WithEvents txtPublicSlots As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Dg2ColumTextBoxMapName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg2ColumTextBoxGamemode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg2ColumTextBoxMapRealName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg2ColumTextBoxGameModeReal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg3ColumTextBoxMapName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg3ColumTextBoxGameMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg3ColumTextBoxRealName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg3ColumTextBoxGameModeReal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg1ColumTextBoxUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg1ColumTextBoxPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dg1ColumTextBoxLevel As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
