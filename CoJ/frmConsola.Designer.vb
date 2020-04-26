<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsola
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsola))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReadConsole = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReadConsoleInst = New System.Windows.Forms.Timer(Me.components)
        Me.TabPanel1 = New System.Windows.Forms.TabControl()
        Me.TabChat = New System.Windows.Forms.TabPage()
        Me.lblWarnings = New System.Windows.Forms.Label()
        Me.lblWarnedPlayers = New System.Windows.Forms.Label()
        Me.PanelTeams = New System.Windows.Forms.Panel()
        Me.chkBalance = New System.Windows.Forms.CheckBox()
        Me.lblTeamRed = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTeamBlue = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblBountyOrPoints = New System.Windows.Forms.Label()
        Me.lblRemainTime = New System.Windows.Forms.Label()
        Me.lblTimeMap = New System.Windows.Forms.Label()
        Me.lblNumPlayers = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCurrentMap = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnMapNext = New System.Windows.Forms.Button()
        Me.btnPlayerList = New System.Windows.Forms.Button()
        Me.cboxMess = New System.Windows.Forms.ComboBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdMessTime3 = New System.Windows.Forms.TextBox()
        Me.txtAdMess3 = New System.Windows.Forms.TextBox()
        Me.chkMess3 = New System.Windows.Forms.CheckBox()
        Me.txtAdMessTime2 = New System.Windows.Forms.TextBox()
        Me.txtAdMess2 = New System.Windows.Forms.TextBox()
        Me.chkMess2 = New System.Windows.Forms.CheckBox()
        Me.txtAdMessTime1 = New System.Windows.Forms.TextBox()
        Me.txtAdMess1 = New System.Windows.Forms.TextBox()
        Me.chkMess1 = New System.Windows.Forms.CheckBox()
        Me.PanelAdminMess = New System.Windows.Forms.Panel()
        Me.cboxCabMess3 = New System.Windows.Forms.ComboBox()
        Me.lbConsola = New System.Windows.Forms.ListBox()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.txtEnviaTexto = New System.Windows.Forms.TextBox()
        Me.TabPlayers = New System.Windows.Forms.TabPage()
        Me.PanelPlayer = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNewBanned = New System.Windows.Forms.TextBox()
        Me.btnAddBannedTBox = New System.Windows.Forms.Button()
        Me.LbPlayers = New System.Windows.Forms.ListBox()
        Me.btnBan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClearBan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbBanned = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxReason = New System.Windows.Forms.ComboBox()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.btnKick = New System.Windows.Forms.Button()
        Me.TabTeams = New System.Windows.Forms.TabPage()
        Me.PanelTabTeams = New System.Windows.Forms.Panel()
        Me.chkBalance2 = New System.Windows.Forms.CheckBox()
        Me.lbRedTeam = New System.Windows.Forms.ListBox()
        Me.cboxReasonBlue = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnKillBlue = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnKickBlue = New System.Windows.Forms.Button()
        Me.lbBlueTeam = New System.Windows.Forms.ListBox()
        Me.cboxReasonRed = New System.Windows.Forms.ComboBox()
        Me.btnKickRed = New System.Windows.Forms.Button()
        Me.btnKillRed = New System.Windows.Forms.Button()
        Me.TabAdmins = New System.Windows.Forms.TabPage()
        Me.PanelAdmins = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNewAdmin = New System.Windows.Forms.TextBox()
        Me.btnAddAdminTbox = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAddWord = New System.Windows.Forms.CheckBox()
        Me.chkBalanceAd = New System.Windows.Forms.CheckBox()
        Me.chkMaplistAd = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkVoteBan = New System.Windows.Forms.CheckBox()
        Me.chkVotekick = New System.Windows.Forms.CheckBox()
        Me.chkMaplist = New System.Windows.Forms.CheckBox()
        Me.chkVotemapnext = New System.Windows.Forms.CheckBox()
        Me.chkPlayerlist = New System.Windows.Forms.CheckBox()
        Me.chkCommandlist = New System.Windows.Forms.CheckBox()
        Me.chkCommandlistAd = New System.Windows.Forms.CheckBox()
        Me.chkRestart = New System.Windows.Forms.CheckBox()
        Me.chkServershutdown = New System.Windows.Forms.CheckBox()
        Me.chkAdminsay = New System.Windows.Forms.CheckBox()
        Me.chkPlayerlistAd = New System.Windows.Forms.CheckBox()
        Me.chkBanlist = New System.Windows.Forms.CheckBox()
        Me.chkUnban = New System.Windows.Forms.CheckBox()
        Me.chkBan = New System.Windows.Forms.CheckBox()
        Me.chkKick = New System.Windows.Forms.CheckBox()
        Me.chkKill = New System.Windows.Forms.CheckBox()
        Me.chkNewadmin = New System.Windows.Forms.CheckBox()
        Me.chkMapnext = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbPlayers2 = New System.Windows.Forms.ListBox()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDeleAdmin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbAdmin = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabLogs = New System.Windows.Forms.TabPage()
        Me.lblQuantityLogs = New System.Windows.Forms.Label()
        Me.btnBuscaEnOldChat = New System.Windows.Forms.Button()
        Me.lblFindInChat = New System.Windows.Forms.Label()
        Me.txtFindInChat = New System.Windows.Forms.TextBox()
        Me.btnLoadLog = New System.Windows.Forms.Button()
        Me.btnDeleteLog = New System.Windows.Forms.Button()
        Me.lbOldChats = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbLogFilesList = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabMaps = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkRememberMaps = New System.Windows.Forms.CheckBox()
        Me.dgMaps = New System.Windows.Forms.DataGridView()
        Me.colMaps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabRules = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkCleanPlayersWarned = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtWarningWords = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboxWordBanEachTimes = New System.Windows.Forms.ComboBox()
        Me.rbWordsBan = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboxWordKickEachTimes = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboxWordKillEachTimes = New System.Windows.Forms.ComboBox()
        Me.rbWordsKick = New System.Windows.Forms.RadioButton()
        Me.rbWordsSendWarning = New System.Windows.Forms.RadioButton()
        Me.rbWordsKill = New System.Windows.Forms.RadioButton()
        Me.dgPlayersWarned = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAddWords = New System.Windows.Forms.TextBox()
        Me.btnAddWord = New System.Windows.Forms.Button()
        Me.btnRemoveWords = New System.Windows.Forms.Button()
        Me.lbWords = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TimerGetPlayerList = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVote = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGetMapList = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerKillBalance = New System.Windows.Forms.Timer(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.TabPanel1.SuspendLayout()
        Me.TabChat.SuspendLayout()
        Me.PanelTeams.SuspendLayout()
        Me.PanelAdminMess.SuspendLayout()
        Me.TabPlayers.SuspendLayout()
        Me.PanelPlayer.SuspendLayout()
        Me.TabTeams.SuspendLayout()
        Me.PanelTabTeams.SuspendLayout()
        Me.TabAdmins.SuspendLayout()
        Me.PanelAdmins.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabLogs.SuspendLayout()
        Me.TabMaps.SuspendLayout()
        CType(Me.dgMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRules.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPlayersWarned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 100000
        '
        'Timer2
        '
        Me.Timer2.Interval = 100000
        '
        'Timer3
        '
        Me.Timer3.Interval = 100000
        '
        'TimerLoad
        '
        Me.TimerLoad.Interval = 3000
        '
        'TimerCountDown
        '
        Me.TimerCountDown.Interval = 1000
        '
        'TimerReadConsole
        '
        Me.TimerReadConsole.Interval = 3000
        '
        'TimerReadConsoleInst
        '
        '
        'TabPanel1
        '
        Me.TabPanel1.Controls.Add(Me.TabChat)
        Me.TabPanel1.Controls.Add(Me.TabPlayers)
        Me.TabPanel1.Controls.Add(Me.TabTeams)
        Me.TabPanel1.Controls.Add(Me.TabAdmins)
        Me.TabPanel1.Controls.Add(Me.TabLogs)
        Me.TabPanel1.Controls.Add(Me.TabMaps)
        Me.TabPanel1.Controls.Add(Me.TabRules)
        Me.TabPanel1.Location = New System.Drawing.Point(-3, 2)
        Me.TabPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPanel1.Name = "TabPanel1"
        Me.TabPanel1.SelectedIndex = 0
        Me.TabPanel1.Size = New System.Drawing.Size(495, 607)
        Me.TabPanel1.TabIndex = 27
        '
        'TabChat
        '
        Me.TabChat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabChat.Controls.Add(Me.lblWarnings)
        Me.TabChat.Controls.Add(Me.lblWarnedPlayers)
        Me.TabChat.Controls.Add(Me.PanelTeams)
        Me.TabChat.Controls.Add(Me.lblBountyOrPoints)
        Me.TabChat.Controls.Add(Me.lblRemainTime)
        Me.TabChat.Controls.Add(Me.lblTimeMap)
        Me.TabChat.Controls.Add(Me.lblNumPlayers)
        Me.TabChat.Controls.Add(Me.Label11)
        Me.TabChat.Controls.Add(Me.lblCurrentMap)
        Me.TabChat.Controls.Add(Me.btnRestart)
        Me.TabChat.Controls.Add(Me.btnMapNext)
        Me.TabChat.Controls.Add(Me.btnPlayerList)
        Me.TabChat.Controls.Add(Me.cboxMess)
        Me.TabChat.Controls.Add(Me.btnEnviar)
        Me.TabChat.Controls.Add(Me.Label3)
        Me.TabChat.Controls.Add(Me.Label2)
        Me.TabChat.Controls.Add(Me.Label1)
        Me.TabChat.Controls.Add(Me.txtAdMessTime3)
        Me.TabChat.Controls.Add(Me.txtAdMess3)
        Me.TabChat.Controls.Add(Me.chkMess3)
        Me.TabChat.Controls.Add(Me.txtAdMessTime2)
        Me.TabChat.Controls.Add(Me.txtAdMess2)
        Me.TabChat.Controls.Add(Me.chkMess2)
        Me.TabChat.Controls.Add(Me.txtAdMessTime1)
        Me.TabChat.Controls.Add(Me.txtAdMess1)
        Me.TabChat.Controls.Add(Me.chkMess1)
        Me.TabChat.Controls.Add(Me.PanelAdminMess)
        Me.TabChat.Controls.Add(Me.lbConsola)
        Me.TabChat.Controls.Add(Me.btnShutdown)
        Me.TabChat.Controls.Add(Me.txtEnviaTexto)
        Me.TabChat.Location = New System.Drawing.Point(4, 25)
        Me.TabChat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabChat.Name = "TabChat"
        Me.TabChat.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabChat.Size = New System.Drawing.Size(487, 578)
        Me.TabChat.TabIndex = 0
        Me.TabChat.Text = "Chat"
        '
        'lblWarnings
        '
        Me.lblWarnings.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarnings.ForeColor = System.Drawing.Color.IndianRed
        Me.lblWarnings.Location = New System.Drawing.Point(184, 481)
        Me.lblWarnings.Name = "lblWarnings"
        Me.lblWarnings.Size = New System.Drawing.Size(24, 15)
        Me.lblWarnings.TabIndex = 61
        Me.lblWarnings.Text = "0"
        Me.lblWarnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblWarnings, "Warnings happened during the game Quantity (from ""X"" Players)")
        '
        'lblWarnedPlayers
        '
        Me.lblWarnedPlayers.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarnedPlayers.ForeColor = System.Drawing.Color.IndianRed
        Me.lblWarnedPlayers.Location = New System.Drawing.Point(208, 481)
        Me.lblWarnedPlayers.Name = "lblWarnedPlayers"
        Me.lblWarnedPlayers.Size = New System.Drawing.Size(28, 15)
        Me.lblWarnedPlayers.TabIndex = 60
        Me.lblWarnedPlayers.Text = "(0)"
        Me.lblWarnedPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblWarnedPlayers, "Warnings happened during the game Quantity (from ""X"" Players)")
        '
        'PanelTeams
        '
        Me.PanelTeams.Controls.Add(Me.chkBalance)
        Me.PanelTeams.Controls.Add(Me.lblTeamRed)
        Me.PanelTeams.Controls.Add(Me.Label16)
        Me.PanelTeams.Controls.Add(Me.lblTeamBlue)
        Me.PanelTeams.Controls.Add(Me.Label15)
        Me.PanelTeams.Location = New System.Drawing.Point(288, 458)
        Me.PanelTeams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTeams.Name = "PanelTeams"
        Me.PanelTeams.Size = New System.Drawing.Size(199, 44)
        Me.PanelTeams.TabIndex = 59
        '
        'chkBalance
        '
        Me.chkBalance.AutoSize = True
        Me.chkBalance.Font = New System.Drawing.Font("Segoe UI Light", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.chkBalance.Location = New System.Drawing.Point(3, 22)
        Me.chkBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBalance.Name = "chkBalance"
        Me.chkBalance.Size = New System.Drawing.Size(98, 19)
        Me.chkBalance.TabIndex = 58
        Me.chkBalance.Text = "Balance Teams"
        Me.ToolTip1.SetToolTip(Me.chkBalance, "On/off automatic team balance in game killing last players joined to the larger t" & _
        "eam every 5 seconds until balance is OK.")
        Me.chkBalance.UseVisualStyleBackColor = True
        '
        'lblTeamRed
        '
        Me.lblTeamRed.AutoSize = True
        Me.lblTeamRed.Font = New System.Drawing.Font("Segoe UI Semibold", 6.886957!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamRed.ForeColor = System.Drawing.Color.Red
        Me.lblTeamRed.Location = New System.Drawing.Point(168, 24)
        Me.lblTeamRed.Name = "lblTeamRed"
        Me.lblTeamRed.Size = New System.Drawing.Size(14, 15)
        Me.lblTeamRed.TabIndex = 57
        Me.lblTeamRed.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblTeamRed, "Players currently into the Red Team OUTLAWS")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(108, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 15)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "TRed     ="
        Me.ToolTip1.SetToolTip(Me.Label16, "Players currently into the Red Team OUTLAWS")
        '
        'lblTeamBlue
        '
        Me.lblTeamBlue.AutoSize = True
        Me.lblTeamBlue.Font = New System.Drawing.Font("Segoe UI Semibold", 6.886957!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamBlue.ForeColor = System.Drawing.Color.Navy
        Me.lblTeamBlue.Location = New System.Drawing.Point(168, 5)
        Me.lblTeamBlue.Name = "lblTeamBlue"
        Me.lblTeamBlue.Size = New System.Drawing.Size(14, 15)
        Me.lblTeamBlue.TabIndex = 56
        Me.lblTeamBlue.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblTeamBlue, "Players currently into the Blue Team LAWMEN")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(108, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 15)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "TBlue    ="
        Me.ToolTip1.SetToolTip(Me.Label15, "Players currently into the Blue Team LAWMEN")
        '
        'lblBountyOrPoints
        '
        Me.lblBountyOrPoints.AutoSize = True
        Me.lblBountyOrPoints.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBountyOrPoints.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblBountyOrPoints.Location = New System.Drawing.Point(123, 459)
        Me.lblBountyOrPoints.Name = "lblBountyOrPoints"
        Me.lblBountyOrPoints.Size = New System.Drawing.Size(110, 15)
        Me.lblBountyOrPoints.TabIndex = 53
        Me.lblBountyOrPoints.Text = "Bounty/Points    :  0"
        Me.lblBountyOrPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblBountyOrPoints, "Bounty or Points set in current round")
        '
        'lblRemainTime
        '
        Me.lblRemainTime.AutoSize = True
        Me.lblRemainTime.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainTime.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblRemainTime.Location = New System.Drawing.Point(3, 459)
        Me.lblRemainTime.Name = "lblRemainTime"
        Me.lblRemainTime.Size = New System.Drawing.Size(70, 15)
        Me.lblRemainTime.TabIndex = 52
        Me.lblRemainTime.Text = "Rem. Time  :"
        Me.lblRemainTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblRemainTime, "Time left to end the current round.")
        '
        'lblTimeMap
        '
        Me.lblTimeMap.AutoSize = True
        Me.lblTimeMap.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeMap.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTimeMap.Location = New System.Drawing.Point(3, 439)
        Me.lblTimeMap.Name = "lblTimeMap"
        Me.lblTimeMap.Size = New System.Drawing.Size(70, 15)
        Me.lblTimeMap.TabIndex = 51
        Me.lblTimeMap.Text = "Time Map   :"
        Me.lblTimeMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblTimeMap, "Total time of the current round.")
        '
        'lblNumPlayers
        '
        Me.lblNumPlayers.AutoSize = True
        Me.lblNumPlayers.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPlayers.ForeColor = System.Drawing.Color.Olive
        Me.lblNumPlayers.Location = New System.Drawing.Point(397, 439)
        Me.lblNumPlayers.Name = "lblNumPlayers"
        Me.lblNumPlayers.Size = New System.Drawing.Size(73, 15)
        Me.lblNumPlayers.TabIndex = 49
        Me.lblNumPlayers.Text = "Players =    0"
        Me.ToolTip1.SetToolTip(Me.lblNumPlayers, "Players currently in game")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.IndianRed
        Me.Label11.Location = New System.Drawing.Point(123, 481)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 15)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Warnings :"
        Me.ToolTip1.SetToolTip(Me.Label11, "Warnings happened during the game Quantity (from ""X"" Players)")
        '
        'lblCurrentMap
        '
        Me.lblCurrentMap.AutoSize = True
        Me.lblCurrentMap.Font = New System.Drawing.Font("Segoe UI Semibold", 6.886957!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCurrentMap.Location = New System.Drawing.Point(124, 439)
        Me.lblCurrentMap.Name = "lblCurrentMap"
        Me.lblCurrentMap.Size = New System.Drawing.Size(82, 15)
        Me.lblCurrentMap.TabIndex = 48
        Me.lblCurrentMap.Text = "Current Map : "
        Me.ToolTip1.SetToolTip(Me.lblCurrentMap, "Map playing now")
        '
        'btnRestart
        '
        Me.btnRestart.AutoSize = True
        Me.btnRestart.BackColor = System.Drawing.Color.Coral
        Me.btnRestart.Enabled = False
        Me.btnRestart.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRestart.Location = New System.Drawing.Point(126, 535)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(73, 32)
        Me.btnRestart.TabIndex = 47
        Me.btnRestart.Text = "Restart"
        Me.ToolTip1.SetToolTip(Me.btnRestart, "Restart the server")
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'btnMapNext
        '
        Me.btnMapNext.Enabled = False
        Me.btnMapNext.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapNext.Location = New System.Drawing.Point(311, 535)
        Me.btnMapNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMapNext.Name = "btnMapNext"
        Me.btnMapNext.Size = New System.Drawing.Size(77, 32)
        Me.btnMapNext.TabIndex = 46
        Me.btnMapNext.Text = "/MapNext"
        Me.ToolTip1.SetToolTip(Me.btnMapNext, "Manually send a ""mapnext"" command")
        Me.btnMapNext.UseVisualStyleBackColor = True
        '
        'btnPlayerList
        '
        Me.btnPlayerList.Enabled = False
        Me.btnPlayerList.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerList.Location = New System.Drawing.Point(226, 535)
        Me.btnPlayerList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlayerList.Name = "btnPlayerList"
        Me.btnPlayerList.Size = New System.Drawing.Size(77, 32)
        Me.btnPlayerList.TabIndex = 45
        Me.btnPlayerList.Text = "/PlayerList"
        Me.ToolTip1.SetToolTip(Me.btnPlayerList, "Manually send a ""playerlist"" command")
        Me.btnPlayerList.UseVisualStyleBackColor = True
        '
        'cboxMess
        '
        Me.cboxMess.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMess.FormattingEnabled = True
        Me.cboxMess.Items.AddRange(New Object() {"/kill", "/kick", "/adminsay"})
        Me.cboxMess.Location = New System.Drawing.Point(5, 479)
        Me.cboxMess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxMess.Name = "cboxMess"
        Me.cboxMess.Size = New System.Drawing.Size(87, 21)
        Me.cboxMess.TabIndex = 44
        Me.cboxMess.Text = "/adminsay"
        Me.ToolTip1.SetToolTip(Me.cboxMess, "Choose the type of command sent via the textbox below")
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(414, 535)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(65, 32)
        Me.btnEnviar.TabIndex = 43
        Me.btnEnviar.Text = "Send"
        Me.ToolTip1.SetToolTip(Me.btnEnviar, "Button to send the message written in the textbox above")
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(-12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 32)
        Me.Label3.TabIndex = 41
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(424, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 32)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "seconds"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(21, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 32)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Automatic Server Messages"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdMessTime3
        '
        Me.txtAdMessTime3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdMessTime3.Enabled = False
        Me.txtAdMessTime3.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMessTime3.Location = New System.Drawing.Point(423, 98)
        Me.txtAdMessTime3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdMessTime3.MaxLength = 3
        Me.txtAdMessTime3.Name = "txtAdMessTime3"
        Me.txtAdMessTime3.Size = New System.Drawing.Size(61, 22)
        Me.txtAdMessTime3.TabIndex = 38
        Me.txtAdMessTime3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtAdMessTime3, "Interval in seconds to send the command in the box on the left")
        '
        'txtAdMess3
        '
        Me.txtAdMess3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdMess3.Enabled = False
        Me.txtAdMess3.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMess3.Location = New System.Drawing.Point(106, 98)
        Me.txtAdMess3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdMess3.MaxLength = 90
        Me.txtAdMess3.Name = "txtAdMess3"
        Me.txtAdMess3.Size = New System.Drawing.Size(313, 22)
        Me.txtAdMess3.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.txtAdMess3, "Send the choosen command if is checked")
        '
        'chkMess3
        '
        Me.chkMess3.AutoSize = True
        Me.chkMess3.Enabled = False
        Me.chkMess3.Location = New System.Drawing.Point(3, 102)
        Me.chkMess3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMess3.Name = "chkMess3"
        Me.chkMess3.Size = New System.Drawing.Size(15, 14)
        Me.chkMess3.TabIndex = 32
        Me.chkMess3.UseVisualStyleBackColor = True
        '
        'txtAdMessTime2
        '
        Me.txtAdMessTime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdMessTime2.Enabled = False
        Me.txtAdMessTime2.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMessTime2.Location = New System.Drawing.Point(423, 69)
        Me.txtAdMessTime2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdMessTime2.MaxLength = 3
        Me.txtAdMessTime2.Name = "txtAdMessTime2"
        Me.txtAdMessTime2.Size = New System.Drawing.Size(61, 22)
        Me.txtAdMessTime2.TabIndex = 37
        Me.txtAdMessTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtAdMessTime2, "Interval in seconds to send the command in the box on the left")
        '
        'txtAdMess2
        '
        Me.txtAdMess2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdMess2.Enabled = False
        Me.txtAdMess2.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMess2.Location = New System.Drawing.Point(21, 69)
        Me.txtAdMess2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdMess2.MaxLength = 90
        Me.txtAdMess2.Name = "txtAdMess2"
        Me.txtAdMess2.Size = New System.Drawing.Size(398, 22)
        Me.txtAdMess2.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.txtAdMess2, "Send an ""adminsay"" command if is checked")
        '
        'chkMess2
        '
        Me.chkMess2.AutoSize = True
        Me.chkMess2.Enabled = False
        Me.chkMess2.Location = New System.Drawing.Point(3, 73)
        Me.chkMess2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMess2.Name = "chkMess2"
        Me.chkMess2.Size = New System.Drawing.Size(15, 14)
        Me.chkMess2.TabIndex = 31
        Me.chkMess2.UseVisualStyleBackColor = True
        '
        'txtAdMessTime1
        '
        Me.txtAdMessTime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdMessTime1.Enabled = False
        Me.txtAdMessTime1.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMessTime1.Location = New System.Drawing.Point(423, 41)
        Me.txtAdMessTime1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdMessTime1.MaxLength = 3
        Me.txtAdMessTime1.Name = "txtAdMessTime1"
        Me.txtAdMessTime1.Size = New System.Drawing.Size(61, 22)
        Me.txtAdMessTime1.TabIndex = 36
        Me.txtAdMessTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtAdMessTime1, "Interval in seconds to send the command in the box on the left")
        '
        'txtAdMess1
        '
        Me.txtAdMess1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdMess1.Enabled = False
        Me.txtAdMess1.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMess1.Location = New System.Drawing.Point(21, 41)
        Me.txtAdMess1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdMess1.MaxLength = 90
        Me.txtAdMess1.Name = "txtAdMess1"
        Me.txtAdMess1.Size = New System.Drawing.Size(398, 22)
        Me.txtAdMess1.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.txtAdMess1, "Send an ""adminsay"" command if is checked")
        '
        'chkMess1
        '
        Me.chkMess1.AutoSize = True
        Me.chkMess1.Enabled = False
        Me.chkMess1.Location = New System.Drawing.Point(3, 46)
        Me.chkMess1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMess1.Name = "chkMess1"
        Me.chkMess1.Size = New System.Drawing.Size(15, 14)
        Me.chkMess1.TabIndex = 30
        Me.chkMess1.UseVisualStyleBackColor = True
        '
        'PanelAdminMess
        '
        Me.PanelAdminMess.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelAdminMess.Controls.Add(Me.cboxCabMess3)
        Me.PanelAdminMess.Enabled = False
        Me.PanelAdminMess.Location = New System.Drawing.Point(-3, 34)
        Me.PanelAdminMess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelAdminMess.Name = "PanelAdminMess"
        Me.PanelAdminMess.Size = New System.Drawing.Size(492, 94)
        Me.PanelAdminMess.TabIndex = 42
        '
        'cboxCabMess3
        '
        Me.cboxCabMess3.Enabled = False
        Me.cboxCabMess3.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCabMess3.FormattingEnabled = True
        Me.cboxCabMess3.Items.AddRange(New Object() {"/kill", "/kick", "/adminsay", "/mapnext", "/playerlist"})
        Me.cboxCabMess3.Location = New System.Drawing.Point(25, 64)
        Me.cboxCabMess3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxCabMess3.Name = "cboxCabMess3"
        Me.cboxCabMess3.Size = New System.Drawing.Size(79, 21)
        Me.cboxCabMess3.TabIndex = 25
        Me.cboxCabMess3.Text = "/adminsay"
        Me.ToolTip1.SetToolTip(Me.cboxCabMess3, "Choose the type of command sent via the textbox on the right.")
        '
        'lbConsola
        '
        Me.lbConsola.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lbConsola.Enabled = False
        Me.lbConsola.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConsola.FormattingEnabled = True
        Me.lbConsola.Location = New System.Drawing.Point(0, 130)
        Me.lbConsola.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbConsola.Name = "lbConsola"
        Me.lbConsola.ScrollAlwaysVisible = True
        Me.lbConsola.Size = New System.Drawing.Size(487, 290)
        Me.lbConsola.TabIndex = 29
        Me.lbConsola.TabStop = False
        '
        'btnShutdown
        '
        Me.btnShutdown.AutoSize = True
        Me.btnShutdown.BackColor = System.Drawing.Color.Firebrick
        Me.btnShutdown.Enabled = False
        Me.btnShutdown.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdown.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnShutdown.Location = New System.Drawing.Point(4, 535)
        Me.btnShutdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(115, 32)
        Me.btnShutdown.TabIndex = 28
        Me.btnShutdown.Text = "Shutdown (10s)"
        Me.ToolTip1.SetToolTip(Me.btnShutdown, "Shutdown the Server")
        Me.btnShutdown.UseVisualStyleBackColor = False
        '
        'txtEnviaTexto
        '
        Me.txtEnviaTexto.Enabled = False
        Me.txtEnviaTexto.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnviaTexto.Location = New System.Drawing.Point(3, 503)
        Me.txtEnviaTexto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEnviaTexto.MaxLength = 80
        Me.txtEnviaTexto.Name = "txtEnviaTexto"
        Me.txtEnviaTexto.Size = New System.Drawing.Size(479, 22)
        Me.txtEnviaTexto.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.txtEnviaTexto, "The text entered in this textbox will be sent through the ""send"" button")
        '
        'TabPlayers
        '
        Me.TabPlayers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPlayers.Controls.Add(Me.PanelPlayer)
        Me.TabPlayers.Location = New System.Drawing.Point(4, 25)
        Me.TabPlayers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPlayers.Name = "TabPlayers"
        Me.TabPlayers.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPlayers.Size = New System.Drawing.Size(487, 578)
        Me.TabPlayers.TabIndex = 1
        Me.TabPlayers.Text = "Players"
        '
        'PanelPlayer
        '
        Me.PanelPlayer.Controls.Add(Me.Label20)
        Me.PanelPlayer.Controls.Add(Me.txtNewBanned)
        Me.PanelPlayer.Controls.Add(Me.btnAddBannedTBox)
        Me.PanelPlayer.Controls.Add(Me.LbPlayers)
        Me.PanelPlayer.Controls.Add(Me.btnBan)
        Me.PanelPlayer.Controls.Add(Me.Label5)
        Me.PanelPlayer.Controls.Add(Me.btnClearBan)
        Me.PanelPlayer.Controls.Add(Me.Label4)
        Me.PanelPlayer.Controls.Add(Me.lbBanned)
        Me.PanelPlayer.Controls.Add(Me.Label6)
        Me.PanelPlayer.Controls.Add(Me.cboxReason)
        Me.PanelPlayer.Controls.Add(Me.btnKill)
        Me.PanelPlayer.Controls.Add(Me.btnKick)
        Me.PanelPlayer.Enabled = False
        Me.PanelPlayer.Location = New System.Drawing.Point(0, 1)
        Me.PanelPlayer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelPlayer.Name = "PanelPlayer"
        Me.PanelPlayer.Size = New System.Drawing.Size(488, 574)
        Me.PanelPlayer.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(267, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 32)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Date"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label20, "Current banned players in this server.")
        '
        'txtNewBanned
        '
        Me.txtNewBanned.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewBanned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtNewBanned.Location = New System.Drawing.Point(291, 485)
        Me.txtNewBanned.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewBanned.MaxLength = 40
        Me.txtNewBanned.Name = "txtNewBanned"
        Me.txtNewBanned.Size = New System.Drawing.Size(192, 22)
        Me.txtNewBanned.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtNewBanned, "The player typed here will be added to the banned list players.")
        '
        'btnAddBannedTBox
        '
        Me.btnAddBannedTBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddBannedTBox.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBannedTBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAddBannedTBox.Location = New System.Drawing.Point(419, 522)
        Me.btnAddBannedTBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddBannedTBox.Name = "btnAddBannedTBox"
        Me.btnAddBannedTBox.Size = New System.Drawing.Size(64, 39)
        Me.btnAddBannedTBox.TabIndex = 57
        Me.btnAddBannedTBox.Text = "ADD "
        Me.ToolTip1.SetToolTip(Me.btnAddBannedTBox, "Send the player typed above to the banned list players.")
        Me.btnAddBannedTBox.UseVisualStyleBackColor = False
        '
        'LbPlayers
        '
        Me.LbPlayers.FormattingEnabled = True
        Me.LbPlayers.ItemHeight = 16
        Me.LbPlayers.Location = New System.Drawing.Point(3, 38)
        Me.LbPlayers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LbPlayers.Name = "LbPlayers"
        Me.LbPlayers.ScrollAlwaysVisible = True
        Me.LbPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LbPlayers.Size = New System.Drawing.Size(216, 436)
        Me.LbPlayers.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.LbPlayers, "Current players in game")
        '
        'btnBan
        '
        Me.btnBan.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBan.Location = New System.Drawing.Point(225, 146)
        Me.btnBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBan.Name = "btnBan"
        Me.btnBan.Size = New System.Drawing.Size(35, 39)
        Me.btnBan.TabIndex = 50
        Me.btnBan.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.btnBan, "Add selected players to Banned Players list.")
        Me.btnBan.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(43, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 32)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Players in Game"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label5, "Current players in game")
        '
        'btnClearBan
        '
        Me.btnClearBan.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClearBan.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBan.Location = New System.Drawing.Point(291, 523)
        Me.btnClearBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearBan.Name = "btnClearBan"
        Me.btnClearBan.Size = New System.Drawing.Size(107, 39)
        Me.btnClearBan.TabIndex = 49
        Me.btnClearBan.Text = "Unban " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selected Players"
        Me.ToolTip1.SetToolTip(Me.btnClearBan, "Unban all selected players in the banned list players above.")
        Me.btnClearBan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 32)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Id."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label4, "Id. of current Players in game")
        '
        'lbBanned
        '
        Me.lbBanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBanned.FormattingEnabled = True
        Me.lbBanned.Location = New System.Drawing.Point(267, 38)
        Me.lbBanned.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbBanned.Name = "lbBanned"
        Me.lbBanned.ScrollAlwaysVisible = True
        Me.lbBanned.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbBanned.Size = New System.Drawing.Size(219, 433)
        Me.lbBanned.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.lbBanned, "Current banned players in this server.")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(331, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 32)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Banned Players List"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label6, "Current banned players in this server.")
        '
        'cboxReason
        '
        Me.cboxReason.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxReason.FormattingEnabled = True
        Me.cboxReason.Items.AddRange(New Object() {"No reason", "Cheater", "Annoying player", "Teamkiller"})
        Me.cboxReason.Location = New System.Drawing.Point(92, 486)
        Me.cboxReason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxReason.MaxLength = 20
        Me.cboxReason.Name = "cboxReason"
        Me.cboxReason.Size = New System.Drawing.Size(127, 21)
        Me.cboxReason.TabIndex = 47
        Me.cboxReason.Text = "No reason"
        Me.ToolTip1.SetToolTip(Me.cboxReason, "Reasons that add to the message sent when you kick out players.")
        '
        'btnKill
        '
        Me.btnKill.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKill.Location = New System.Drawing.Point(5, 522)
        Me.btnKill.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(94, 40)
        Me.btnKill.TabIndex = 45
        Me.btnKill.Text = "Kill Selected"
        Me.ToolTip1.SetToolTip(Me.btnKill, "Kill al selected players in the list above")
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnKick
        '
        Me.btnKick.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKick.Location = New System.Drawing.Point(124, 522)
        Me.btnKick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKick.Name = "btnKick"
        Me.btnKick.Size = New System.Drawing.Size(94, 40)
        Me.btnKick.TabIndex = 46
        Me.btnKick.Text = "Kick Selected"
        Me.ToolTip1.SetToolTip(Me.btnKick, "Kick out all selected players in the list above .")
        Me.btnKick.UseVisualStyleBackColor = True
        '
        'TabTeams
        '
        Me.TabTeams.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabTeams.Controls.Add(Me.PanelTabTeams)
        Me.TabTeams.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabTeams.Location = New System.Drawing.Point(4, 25)
        Me.TabTeams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabTeams.Name = "TabTeams"
        Me.TabTeams.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabTeams.Size = New System.Drawing.Size(487, 578)
        Me.TabTeams.TabIndex = 5
        Me.TabTeams.Text = "Teams"
        '
        'PanelTabTeams
        '
        Me.PanelTabTeams.Controls.Add(Me.chkBalance2)
        Me.PanelTabTeams.Controls.Add(Me.lbRedTeam)
        Me.PanelTabTeams.Controls.Add(Me.cboxReasonBlue)
        Me.PanelTabTeams.Controls.Add(Me.Label17)
        Me.PanelTabTeams.Controls.Add(Me.btnKillBlue)
        Me.PanelTabTeams.Controls.Add(Me.Label18)
        Me.PanelTabTeams.Controls.Add(Me.btnKickBlue)
        Me.PanelTabTeams.Controls.Add(Me.lbBlueTeam)
        Me.PanelTabTeams.Controls.Add(Me.cboxReasonRed)
        Me.PanelTabTeams.Controls.Add(Me.btnKickRed)
        Me.PanelTabTeams.Controls.Add(Me.btnKillRed)
        Me.PanelTabTeams.Location = New System.Drawing.Point(3, 2)
        Me.PanelTabTeams.Name = "PanelTabTeams"
        Me.PanelTabTeams.Size = New System.Drawing.Size(487, 578)
        Me.PanelTabTeams.TabIndex = 28
        '
        'chkBalance2
        '
        Me.chkBalance2.AutoSize = True
        Me.chkBalance2.Font = New System.Drawing.Font("Segoe UI Light", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBalance2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.chkBalance2.Location = New System.Drawing.Point(195, 507)
        Me.chkBalance2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBalance2.Name = "chkBalance2"
        Me.chkBalance2.Size = New System.Drawing.Size(98, 19)
        Me.chkBalance2.TabIndex = 59
        Me.chkBalance2.Text = "Balance Teams"
        Me.ToolTip1.SetToolTip(Me.chkBalance2, "On/off automatic team balance in game killing last players joined to the larger t" & _
        "eam every 5 seconds until balance is OK.")
        Me.chkBalance2.UseVisualStyleBackColor = True
        '
        'lbRedTeam
        '
        Me.lbRedTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbRedTeam.FormattingEnabled = True
        Me.lbRedTeam.ItemHeight = 17
        Me.lbRedTeam.Location = New System.Drawing.Point(-2, 36)
        Me.lbRedTeam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbRedTeam.Name = "lbRedTeam"
        Me.lbRedTeam.ScrollAlwaysVisible = True
        Me.lbRedTeam.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbRedTeam.Size = New System.Drawing.Size(239, 429)
        Me.lbRedTeam.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.lbRedTeam, "Current players in Red team OUTLAWS")
        '
        'cboxReasonBlue
        '
        Me.cboxReasonBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboxReasonBlue.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxReasonBlue.FormattingEnabled = True
        Me.cboxReasonBlue.Items.AddRange(New Object() {"Balance", "No reason", "Cheater", "Annoying player", "Teamkiller"})
        Me.cboxReasonBlue.Location = New System.Drawing.Point(315, 517)
        Me.cboxReasonBlue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxReasonBlue.MaxLength = 20
        Me.cboxReasonBlue.Name = "cboxReasonBlue"
        Me.cboxReasonBlue.Size = New System.Drawing.Size(146, 25)
        Me.cboxReasonBlue.TabIndex = 58
        Me.cboxReasonBlue.Text = "Balance"
        Me.ToolTip1.SetToolTip(Me.cboxReasonBlue, "Cause for which a Blue player is kick out.")
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(-2, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(239, 32)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Red Team OUTLAWS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label17, "Current players in Red team OUTLAWS")
        '
        'btnKillBlue
        '
        Me.btnKillBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKillBlue.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKillBlue.Location = New System.Drawing.Point(315, 486)
        Me.btnKillBlue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKillBlue.Name = "btnKillBlue"
        Me.btnKillBlue.Size = New System.Drawing.Size(62, 27)
        Me.btnKillBlue.TabIndex = 56
        Me.btnKillBlue.Text = "KILL"
        Me.ToolTip1.SetToolTip(Me.btnKillBlue, "Kill selected players in Blue team LAWMEN.")
        Me.btnKillBlue.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(244, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(240, 32)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Blue Team LAWMEN"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label18, "Current players in Blue team LAWMEN")
        '
        'btnKickBlue
        '
        Me.btnKickBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKickBlue.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickBlue.Location = New System.Drawing.Point(399, 486)
        Me.btnKickBlue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKickBlue.Name = "btnKickBlue"
        Me.btnKickBlue.Size = New System.Drawing.Size(62, 27)
        Me.btnKickBlue.TabIndex = 57
        Me.btnKickBlue.Text = "KICK"
        Me.ToolTip1.SetToolTip(Me.btnKickBlue, "Kick out selected players in Blue team LAWMEN by the reason chosen below.")
        Me.btnKickBlue.UseVisualStyleBackColor = False
        '
        'lbBlueTeam
        '
        Me.lbBlueTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbBlueTeam.FormattingEnabled = True
        Me.lbBlueTeam.ItemHeight = 17
        Me.lbBlueTeam.Location = New System.Drawing.Point(244, 36)
        Me.lbBlueTeam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbBlueTeam.Name = "lbBlueTeam"
        Me.lbBlueTeam.ScrollAlwaysVisible = True
        Me.lbBlueTeam.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbBlueTeam.Size = New System.Drawing.Size(240, 429)
        Me.lbBlueTeam.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.lbBlueTeam, "Current players in Blue team LAWMEN")
        '
        'cboxReasonRed
        '
        Me.cboxReasonRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cboxReasonRed.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxReasonRed.FormattingEnabled = True
        Me.cboxReasonRed.Items.AddRange(New Object() {"Balance", "No reason", "Cheater", "Annoying player", "Teamkiller"})
        Me.cboxReasonRed.Location = New System.Drawing.Point(14, 517)
        Me.cboxReasonRed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxReasonRed.MaxLength = 20
        Me.cboxReasonRed.Name = "cboxReasonRed"
        Me.cboxReasonRed.Size = New System.Drawing.Size(146, 25)
        Me.cboxReasonRed.TabIndex = 55
        Me.cboxReasonRed.Text = "Balance"
        Me.ToolTip1.SetToolTip(Me.cboxReasonRed, "Cause for which a Red player is kick out.")
        '
        'btnKickRed
        '
        Me.btnKickRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnKickRed.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickRed.Location = New System.Drawing.Point(98, 486)
        Me.btnKickRed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKickRed.Name = "btnKickRed"
        Me.btnKickRed.Size = New System.Drawing.Size(62, 27)
        Me.btnKickRed.TabIndex = 54
        Me.btnKickRed.Text = "KICK"
        Me.ToolTip1.SetToolTip(Me.btnKickRed, "Kick out selected players in Red team OUTLAWS by the reason chosen below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnKickRed.UseVisualStyleBackColor = False
        '
        'btnKillRed
        '
        Me.btnKillRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnKillRed.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKillRed.Location = New System.Drawing.Point(14, 486)
        Me.btnKillRed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKillRed.Name = "btnKillRed"
        Me.btnKillRed.Size = New System.Drawing.Size(62, 27)
        Me.btnKillRed.TabIndex = 53
        Me.btnKillRed.Text = "KILL"
        Me.ToolTip1.SetToolTip(Me.btnKillRed, "Kill selected players in Red team OUTLAWS.")
        Me.btnKillRed.UseVisualStyleBackColor = False
        '
        'TabAdmins
        '
        Me.TabAdmins.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabAdmins.Controls.Add(Me.PanelAdmins)
        Me.TabAdmins.Location = New System.Drawing.Point(4, 25)
        Me.TabAdmins.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabAdmins.Name = "TabAdmins"
        Me.TabAdmins.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabAdmins.Size = New System.Drawing.Size(487, 578)
        Me.TabAdmins.TabIndex = 2
        Me.TabAdmins.Text = "Admins"
        '
        'PanelAdmins
        '
        Me.PanelAdmins.Controls.Add(Me.Label14)
        Me.PanelAdmins.Controls.Add(Me.txtNewAdmin)
        Me.PanelAdmins.Controls.Add(Me.btnAddAdminTbox)
        Me.PanelAdmins.Controls.Add(Me.Panel1)
        Me.PanelAdmins.Controls.Add(Me.Label10)
        Me.PanelAdmins.Controls.Add(Me.lbPlayers2)
        Me.PanelAdmins.Controls.Add(Me.btnAddAdmin)
        Me.PanelAdmins.Controls.Add(Me.Label7)
        Me.PanelAdmins.Controls.Add(Me.btnDeleAdmin)
        Me.PanelAdmins.Controls.Add(Me.Label8)
        Me.PanelAdmins.Controls.Add(Me.lbAdmin)
        Me.PanelAdmins.Controls.Add(Me.Label9)
        Me.PanelAdmins.Enabled = False
        Me.PanelAdmins.Location = New System.Drawing.Point(0, 1)
        Me.PanelAdmins.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelAdmins.Name = "PanelAdmins"
        Me.PanelAdmins.Size = New System.Drawing.Size(488, 574)
        Me.PanelAdmins.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(339, 390)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 15)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "General Commands"
        Me.ToolTip1.SetToolTip(Me.Label14, "Commans for all players")
        '
        'txtNewAdmin
        '
        Me.txtNewAdmin.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.txtNewAdmin.Location = New System.Drawing.Point(315, 313)
        Me.txtNewAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewAdmin.Name = "txtNewAdmin"
        Me.txtNewAdmin.Size = New System.Drawing.Size(167, 22)
        Me.txtNewAdmin.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.txtNewAdmin, "Introduce name player to add to admin list")
        '
        'btnAddAdminTbox
        '
        Me.btnAddAdminTbox.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdminTbox.Location = New System.Drawing.Point(315, 346)
        Me.btnAddAdminTbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddAdminTbox.Name = "btnAddAdminTbox"
        Me.btnAddAdminTbox.Size = New System.Drawing.Size(59, 28)
        Me.btnAddAdminTbox.TabIndex = 55
        Me.btnAddAdminTbox.Text = "ADD "
        Me.ToolTip1.SetToolTip(Me.btnAddAdminTbox, "Adds the gamer written above to Admins List")
        Me.btnAddAdminTbox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkAddWord)
        Me.Panel1.Controls.Add(Me.chkBalanceAd)
        Me.Panel1.Controls.Add(Me.chkMaplistAd)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.chkCommandlistAd)
        Me.Panel1.Controls.Add(Me.chkRestart)
        Me.Panel1.Controls.Add(Me.chkServershutdown)
        Me.Panel1.Controls.Add(Me.chkAdminsay)
        Me.Panel1.Controls.Add(Me.chkPlayerlistAd)
        Me.Panel1.Controls.Add(Me.chkBanlist)
        Me.Panel1.Controls.Add(Me.chkUnban)
        Me.Panel1.Controls.Add(Me.chkBan)
        Me.Panel1.Controls.Add(Me.chkKick)
        Me.Panel1.Controls.Add(Me.chkKill)
        Me.Panel1.Controls.Add(Me.chkNewadmin)
        Me.Panel1.Controls.Add(Me.chkMapnext)
        Me.Panel1.Location = New System.Drawing.Point(1, 406)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 163)
        Me.Panel1.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.Panel1, "Commands exclusively for admin")
        '
        'chkAddWord
        '
        Me.chkAddWord.AutoSize = True
        Me.chkAddWord.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddWord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkAddWord.Location = New System.Drawing.Point(149, 121)
        Me.chkAddWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAddWord.Name = "chkAddWord"
        Me.chkAddWord.Size = New System.Drawing.Size(122, 19)
        Me.chkAddWord.TabIndex = 70
        Me.chkAddWord.Text = "!addword <word>"
        Me.ToolTip1.SetToolTip(Me.chkAddWord, "Add typed word to list forgiven words")
        Me.chkAddWord.UseVisualStyleBackColor = True
        '
        'chkBalanceAd
        '
        Me.chkBalanceAd.AutoSize = True
        Me.chkBalanceAd.Checked = True
        Me.chkBalanceAd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBalanceAd.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBalanceAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkBalanceAd.Location = New System.Drawing.Point(149, 101)
        Me.chkBalanceAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBalanceAd.Name = "chkBalanceAd"
        Me.chkBalanceAd.Size = New System.Drawing.Size(109, 19)
        Me.chkBalanceAd.TabIndex = 69
        Me.chkBalanceAd.Text = "!balance yes/no"
        Me.ToolTip1.SetToolTip(Me.chkBalanceAd, "On/off automatic team balance in game killing last players joined to the larger t" & _
        "eam every 5 seconds until balance is OK.")
        Me.chkBalanceAd.UseVisualStyleBackColor = True
        '
        'chkMaplistAd
        '
        Me.chkMaplistAd.AutoSize = True
        Me.chkMaplistAd.Checked = True
        Me.chkMaplistAd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaplistAd.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaplistAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMaplistAd.Location = New System.Drawing.Point(149, 81)
        Me.chkMaplistAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMaplistAd.Name = "chkMaplistAd"
        Me.chkMaplistAd.Size = New System.Drawing.Size(68, 19)
        Me.chkMaplistAd.TabIndex = 68
        Me.chkMaplistAd.Text = "!maplist"
        Me.ToolTip1.SetToolTip(Me.chkMaplistAd, "Show the following three maps in the game to all players")
        Me.chkMaplistAd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.chkVoteBan)
        Me.Panel2.Controls.Add(Me.chkVotekick)
        Me.Panel2.Controls.Add(Me.chkMaplist)
        Me.Panel2.Controls.Add(Me.chkVotemapnext)
        Me.Panel2.Controls.Add(Me.chkPlayerlist)
        Me.Panel2.Controls.Add(Me.chkCommandlist)
        Me.Panel2.Location = New System.Drawing.Point(312, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(173, 163)
        Me.Panel2.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.Panel2, "Commands for all players")
        '
        'chkVoteBan
        '
        Me.chkVoteBan.AutoSize = True
        Me.chkVoteBan.Checked = True
        Me.chkVoteBan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVoteBan.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVoteBan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.chkVoteBan.Location = New System.Drawing.Point(8, 101)
        Me.chkVoteBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVoteBan.Name = "chkVoteBan"
        Me.chkVoteBan.Size = New System.Drawing.Size(121, 19)
        Me.chkVoteBan.TabIndex = 67
        Me.chkVoteBan.Text = "!voteban <name>"
        Me.ToolTip1.SetToolTip(Me.chkVoteBan, "Starts a round of voting to ban to the player written below.")
        Me.chkVoteBan.UseVisualStyleBackColor = True
        '
        'chkVotekick
        '
        Me.chkVotekick.AutoSize = True
        Me.chkVotekick.Checked = True
        Me.chkVotekick.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVotekick.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVotekick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.chkVotekick.Location = New System.Drawing.Point(8, 81)
        Me.chkVotekick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVotekick.Name = "chkVotekick"
        Me.chkVotekick.Size = New System.Drawing.Size(137, 19)
        Me.chkVotekick.TabIndex = 66
        Me.chkVotekick.Text = "!votekick <name/id>"
        Me.ToolTip1.SetToolTip(Me.chkVotekick, "Starts a round of voting to kick out to the player written below.")
        Me.chkVotekick.UseVisualStyleBackColor = True
        '
        'chkMaplist
        '
        Me.chkMaplist.AutoSize = True
        Me.chkMaplist.Checked = True
        Me.chkMaplist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaplist.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaplist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.chkMaplist.Location = New System.Drawing.Point(8, 62)
        Me.chkMaplist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMaplist.Name = "chkMaplist"
        Me.chkMaplist.Size = New System.Drawing.Size(68, 19)
        Me.chkMaplist.TabIndex = 65
        Me.chkMaplist.Text = "!maplist"
        Me.ToolTip1.SetToolTip(Me.chkMaplist, "Shows the players list in game. (Active for all players)")
        Me.chkMaplist.UseVisualStyleBackColor = True
        '
        'chkVotemapnext
        '
        Me.chkVotemapnext.AutoSize = True
        Me.chkVotemapnext.Checked = True
        Me.chkVotemapnext.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVotemapnext.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVotemapnext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.chkVotemapnext.Location = New System.Drawing.Point(8, 41)
        Me.chkVotemapnext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVotemapnext.Name = "chkVotemapnext"
        Me.chkVotemapnext.Size = New System.Drawing.Size(98, 19)
        Me.chkVotemapnext.TabIndex = 64
        Me.chkVotemapnext.Text = "!votemapnext"
        Me.ToolTip1.SetToolTip(Me.chkVotemapnext, "Starts a round of voting to change to the next map. (Shows the next map)")
        Me.chkVotemapnext.UseVisualStyleBackColor = True
        '
        'chkPlayerlist
        '
        Me.chkPlayerlist.AutoSize = True
        Me.chkPlayerlist.Checked = True
        Me.chkPlayerlist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPlayerlist.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlayerlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.chkPlayerlist.Location = New System.Drawing.Point(8, 21)
        Me.chkPlayerlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkPlayerlist.Name = "chkPlayerlist"
        Me.chkPlayerlist.Size = New System.Drawing.Size(76, 19)
        Me.chkPlayerlist.TabIndex = 63
        Me.chkPlayerlist.Text = "!playerlist"
        Me.ToolTip1.SetToolTip(Me.chkPlayerlist, "Shows the players list in game. (Active for all players)")
        Me.chkPlayerlist.UseVisualStyleBackColor = True
        '
        'chkCommandlist
        '
        Me.chkCommandlist.AutoSize = True
        Me.chkCommandlist.Checked = True
        Me.chkCommandlist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCommandlist.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCommandlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.chkCommandlist.Location = New System.Drawing.Point(8, 1)
        Me.chkCommandlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkCommandlist.Name = "chkCommandlist"
        Me.chkCommandlist.Size = New System.Drawing.Size(99, 19)
        Me.chkCommandlist.TabIndex = 55
        Me.chkCommandlist.Text = "!commandlist"
        Me.ToolTip1.SetToolTip(Me.chkCommandlist, "Show the General Commands list into the game. (Active for general players)")
        Me.chkCommandlist.UseVisualStyleBackColor = True
        '
        'chkCommandlistAd
        '
        Me.chkCommandlistAd.AutoSize = True
        Me.chkCommandlistAd.Checked = True
        Me.chkCommandlistAd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCommandlistAd.Enabled = False
        Me.chkCommandlistAd.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCommandlistAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkCommandlistAd.Location = New System.Drawing.Point(5, 1)
        Me.chkCommandlistAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkCommandlistAd.Name = "chkCommandlistAd"
        Me.chkCommandlistAd.Size = New System.Drawing.Size(99, 19)
        Me.chkCommandlistAd.TabIndex = 66
        Me.chkCommandlistAd.Text = "!commandlist"
        Me.ToolTip1.SetToolTip(Me.chkCommandlistAd, "Show the Admins Command list into  the game.")
        Me.chkCommandlistAd.UseVisualStyleBackColor = True
        '
        'chkRestart
        '
        Me.chkRestart.AutoSize = True
        Me.chkRestart.Checked = True
        Me.chkRestart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRestart.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRestart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkRestart.Location = New System.Drawing.Point(149, 21)
        Me.chkRestart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRestart.Name = "chkRestart"
        Me.chkRestart.Size = New System.Drawing.Size(62, 19)
        Me.chkRestart.TabIndex = 65
        Me.chkRestart.Text = "!restart"
        Me.ToolTip1.SetToolTip(Me.chkRestart, "Restart the Dedicated Server.")
        Me.chkRestart.UseVisualStyleBackColor = True
        '
        'chkServershutdown
        '
        Me.chkServershutdown.AutoSize = True
        Me.chkServershutdown.Checked = True
        Me.chkServershutdown.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkServershutdown.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServershutdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkServershutdown.Location = New System.Drawing.Point(149, 1)
        Me.chkServershutdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkServershutdown.Name = "chkServershutdown"
        Me.chkServershutdown.Size = New System.Drawing.Size(113, 19)
        Me.chkServershutdown.TabIndex = 64
        Me.chkServershutdown.Text = "!servershutdown"
        Me.ToolTip1.SetToolTip(Me.chkServershutdown, "Shut down the Dedicated Server.")
        Me.chkServershutdown.UseVisualStyleBackColor = True
        '
        'chkAdminsay
        '
        Me.chkAdminsay.AutoSize = True
        Me.chkAdminsay.Checked = True
        Me.chkAdminsay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdminsay.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdminsay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkAdminsay.Location = New System.Drawing.Point(149, 62)
        Me.chkAdminsay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAdminsay.Name = "chkAdminsay"
        Me.chkAdminsay.Size = New System.Drawing.Size(80, 19)
        Me.chkAdminsay.TabIndex = 63
        Me.chkAdminsay.Text = "!adminsay"
        Me.ToolTip1.SetToolTip(Me.chkAdminsay, "Send an Admin warning.")
        Me.chkAdminsay.UseVisualStyleBackColor = True
        '
        'chkPlayerlistAd
        '
        Me.chkPlayerlistAd.AutoSize = True
        Me.chkPlayerlistAd.Checked = True
        Me.chkPlayerlistAd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPlayerlistAd.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlayerlistAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkPlayerlistAd.Location = New System.Drawing.Point(5, 142)
        Me.chkPlayerlistAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkPlayerlistAd.Name = "chkPlayerlistAd"
        Me.chkPlayerlistAd.Size = New System.Drawing.Size(76, 19)
        Me.chkPlayerlistAd.TabIndex = 62
        Me.chkPlayerlistAd.Text = "!playerlist"
        Me.ToolTip1.SetToolTip(Me.chkPlayerlistAd, "Shows the players list in game. (Active for Admins)")
        Me.chkPlayerlistAd.UseVisualStyleBackColor = True
        '
        'chkBanlist
        '
        Me.chkBanlist.AutoSize = True
        Me.chkBanlist.Checked = True
        Me.chkBanlist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBanlist.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBanlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkBanlist.Location = New System.Drawing.Point(5, 121)
        Me.chkBanlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBanlist.Name = "chkBanlist"
        Me.chkBanlist.Size = New System.Drawing.Size(64, 19)
        Me.chkBanlist.TabIndex = 61
        Me.chkBanlist.Text = "!banlist"
        Me.ToolTip1.SetToolTip(Me.chkBanlist, "Show into the game the banned players list.")
        Me.chkBanlist.UseVisualStyleBackColor = True
        '
        'chkUnban
        '
        Me.chkUnban.AutoSize = True
        Me.chkUnban.Checked = True
        Me.chkUnban.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUnban.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnban.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkUnban.Location = New System.Drawing.Point(5, 101)
        Me.chkUnban.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkUnban.Name = "chkUnban"
        Me.chkUnban.Size = New System.Drawing.Size(127, 19)
        Me.chkUnban.TabIndex = 60
        Me.chkUnban.Text = "!unban <name/id>"
        Me.ToolTip1.SetToolTip(Me.chkUnban, "Unban the player who you write by NAME into the command line.")
        Me.chkUnban.UseVisualStyleBackColor = True
        '
        'chkBan
        '
        Me.chkBan.AutoSize = True
        Me.chkBan.Checked = True
        Me.chkBan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBan.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkBan.Location = New System.Drawing.Point(5, 81)
        Me.chkBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBan.Name = "chkBan"
        Me.chkBan.Size = New System.Drawing.Size(98, 19)
        Me.chkBan.TabIndex = 59
        Me.chkBan.Text = "!ban <name>"
        Me.ToolTip1.SetToolTip(Me.chkBan, "Ban the player who you write by NAME into the command line.")
        Me.chkBan.UseVisualStyleBackColor = True
        '
        'chkKick
        '
        Me.chkKick.AutoSize = True
        Me.chkKick.Checked = True
        Me.chkKick.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKick.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkKick.Location = New System.Drawing.Point(5, 62)
        Me.chkKick.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkKick.Name = "chkKick"
        Me.chkKick.Size = New System.Drawing.Size(114, 19)
        Me.chkKick.TabIndex = 58
        Me.chkKick.Text = "!kick <name/id>"
        Me.ToolTip1.SetToolTip(Me.chkKick, "Kick out the player who you write by name into the command line.")
        Me.chkKick.UseVisualStyleBackColor = True
        '
        'chkKill
        '
        Me.chkKill.AutoSize = True
        Me.chkKill.Checked = True
        Me.chkKill.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKill.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkKill.Location = New System.Drawing.Point(5, 41)
        Me.chkKill.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkKill.Name = "chkKill"
        Me.chkKill.Size = New System.Drawing.Size(108, 19)
        Me.chkKill.TabIndex = 57
        Me.chkKill.Text = "!kill <name/id>"
        Me.ToolTip1.SetToolTip(Me.chkKill, "Kill the player who you write by name or id into the command line.")
        Me.chkKill.UseVisualStyleBackColor = True
        '
        'chkNewadmin
        '
        Me.chkNewadmin.AutoSize = True
        Me.chkNewadmin.Checked = True
        Me.chkNewadmin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNewadmin.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNewadmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkNewadmin.Location = New System.Drawing.Point(5, 21)
        Me.chkNewadmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNewadmin.Name = "chkNewadmin"
        Me.chkNewadmin.Size = New System.Drawing.Size(134, 19)
        Me.chkNewadmin.TabIndex = 56
        Me.chkNewadmin.Text = "!newadmin <name>"
        Me.ToolTip1.SetToolTip(Me.chkNewadmin, "Grant administrator privileges to a normal player.")
        Me.chkNewadmin.UseVisualStyleBackColor = True
        '
        'chkMapnext
        '
        Me.chkMapnext.AutoSize = True
        Me.chkMapnext.Checked = True
        Me.chkMapnext.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMapnext.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMapnext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMapnext.Location = New System.Drawing.Point(149, 41)
        Me.chkMapnext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMapnext.Name = "chkMapnext"
        Me.chkMapnext.Size = New System.Drawing.Size(75, 19)
        Me.chkMapnext.TabIndex = 54
        Me.chkMapnext.Text = "!mapnext"
        Me.ToolTip1.SetToolTip(Me.chkMapnext, "Go to the next map in game.")
        Me.chkMapnext.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(24, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Admin Commands"
        Me.ToolTip1.SetToolTip(Me.Label10, "Commands for admins")
        '
        'lbPlayers2
        '
        Me.lbPlayers2.FormattingEnabled = True
        Me.lbPlayers2.ItemHeight = 16
        Me.lbPlayers2.Location = New System.Drawing.Point(3, 38)
        Me.lbPlayers2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbPlayers2.Name = "lbPlayers2"
        Me.lbPlayers2.ScrollAlwaysVisible = True
        Me.lbPlayers2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbPlayers2.Size = New System.Drawing.Size(265, 340)
        Me.lbPlayers2.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.lbPlayers2, "List of people playing online on this server.")
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.Location = New System.Drawing.Point(275, 121)
        Me.btnAddAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(35, 39)
        Me.btnAddAdmin.TabIndex = 50
        Me.btnAddAdmin.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.btnAddAdmin, "Adds all selected gamers from the left list to Admins List.")
        Me.btnAddAdmin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(43, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 32)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Players in Game"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label7, "List of people playing online on this server.")
        '
        'btnDeleAdmin
        '
        Me.btnDeleAdmin.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleAdmin.Location = New System.Drawing.Point(389, 346)
        Me.btnDeleAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleAdmin.Name = "btnDeleAdmin"
        Me.btnDeleAdmin.Size = New System.Drawing.Size(91, 28)
        Me.btnDeleAdmin.TabIndex = 49
        Me.btnDeleAdmin.Text = "Delete Admin"
        Me.ToolTip1.SetToolTip(Me.btnDeleAdmin, "Removes the selected players from the list above.")
        Me.btnDeleAdmin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 32)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Id."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label8, "List of people playing online on this server (id).")
        '
        'lbAdmin
        '
        Me.lbAdmin.FormattingEnabled = True
        Me.lbAdmin.ItemHeight = 16
        Me.lbAdmin.Location = New System.Drawing.Point(316, 38)
        Me.lbAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.ScrollAlwaysVisible = True
        Me.lbAdmin.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbAdmin.Size = New System.Drawing.Size(167, 260)
        Me.lbAdmin.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.lbAdmin, "List admin of this server. All players on this list will have access to use admin" & _
        " commands.")
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(316, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 32)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Admins List"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label9, "List admin of this server. All players on this list will have access to use admin" & _
        " commands.")
        '
        'TabLogs
        '
        Me.TabLogs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabLogs.Controls.Add(Me.lblQuantityLogs)
        Me.TabLogs.Controls.Add(Me.btnBuscaEnOldChat)
        Me.TabLogs.Controls.Add(Me.lblFindInChat)
        Me.TabLogs.Controls.Add(Me.txtFindInChat)
        Me.TabLogs.Controls.Add(Me.btnLoadLog)
        Me.TabLogs.Controls.Add(Me.btnDeleteLog)
        Me.TabLogs.Controls.Add(Me.lbOldChats)
        Me.TabLogs.Controls.Add(Me.Label12)
        Me.TabLogs.Controls.Add(Me.lbLogFilesList)
        Me.TabLogs.Controls.Add(Me.Label13)
        Me.TabLogs.Location = New System.Drawing.Point(4, 25)
        Me.TabLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabLogs.Name = "TabLogs"
        Me.TabLogs.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabLogs.Size = New System.Drawing.Size(487, 578)
        Me.TabLogs.TabIndex = 3
        Me.TabLogs.Text = "Logs"
        '
        'lblQuantityLogs
        '
        Me.lblQuantityLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblQuantityLogs.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblQuantityLogs.Location = New System.Drawing.Point(248, 380)
        Me.lblQuantityLogs.Name = "lblQuantityLogs"
        Me.lblQuantityLogs.Size = New System.Drawing.Size(61, 26)
        Me.lblQuantityLogs.TabIndex = 58
        Me.lblQuantityLogs.Text = "1/50"
        Me.lblQuantityLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblQuantityLogs, "Coj2 Controller automatically keeps the last 50 game log files and delete the res" & _
        "t of older files.")
        '
        'btnBuscaEnOldChat
        '
        Me.btnBuscaEnOldChat.AutoSize = True
        Me.btnBuscaEnOldChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnBuscaEnOldChat.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaEnOldChat.Location = New System.Drawing.Point(267, 4)
        Me.btnBuscaEnOldChat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscaEnOldChat.Name = "btnBuscaEnOldChat"
        Me.btnBuscaEnOldChat.Size = New System.Drawing.Size(49, 31)
        Me.btnBuscaEnOldChat.TabIndex = 57
        Me.btnBuscaEnOldChat.Text = "(F3)"
        Me.ToolTip1.SetToolTip(Me.btnBuscaEnOldChat, "Find the words on the right textbox")
        Me.btnBuscaEnOldChat.UseVisualStyleBackColor = False
        '
        'lblFindInChat
        '
        Me.lblFindInChat.AutoSize = True
        Me.lblFindInChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblFindInChat.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindInChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblFindInChat.Location = New System.Drawing.Point(326, 12)
        Me.lblFindInChat.Name = "lblFindInChat"
        Me.lblFindInChat.Size = New System.Drawing.Size(69, 15)
        Me.lblFindInChat.TabIndex = 56
        Me.lblFindInChat.Text = "Find in chat"
        Me.ToolTip1.SetToolTip(Me.lblFindInChat, "Introduce words to find")
        '
        'txtFindInChat
        '
        Me.txtFindInChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtFindInChat.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindInChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtFindInChat.Location = New System.Drawing.Point(320, 7)
        Me.txtFindInChat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFindInChat.Name = "txtFindInChat"
        Me.txtFindInChat.Size = New System.Drawing.Size(161, 25)
        Me.txtFindInChat.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.txtFindInChat, "Introduce words to find")
        '
        'btnLoadLog
        '
        Me.btnLoadLog.AutoSize = True
        Me.btnLoadLog.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadLog.Location = New System.Drawing.Point(331, 500)
        Me.btnLoadLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoadLog.Name = "btnLoadLog"
        Me.btnLoadLog.Size = New System.Drawing.Size(144, 31)
        Me.btnLoadLog.TabIndex = 54
        Me.btnLoadLog.Text = "Load selected file"
        Me.btnLoadLog.UseVisualStyleBackColor = True
        '
        'btnDeleteLog
        '
        Me.btnDeleteLog.AutoSize = True
        Me.btnDeleteLog.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteLog.Location = New System.Drawing.Point(331, 543)
        Me.btnDeleteLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteLog.Name = "btnDeleteLog"
        Me.btnDeleteLog.Size = New System.Drawing.Size(144, 31)
        Me.btnDeleteLog.TabIndex = 53
        Me.btnDeleteLog.Text = "Delete selected files"
        Me.btnDeleteLog.UseVisualStyleBackColor = True
        '
        'lbOldChats
        '
        Me.lbOldChats.BackColor = System.Drawing.Color.FloralWhite
        Me.lbOldChats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lbOldChats.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOldChats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbOldChats.FormattingEnabled = True
        Me.lbOldChats.Location = New System.Drawing.Point(0, 39)
        Me.lbOldChats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbOldChats.Name = "lbOldChats"
        Me.lbOldChats.ScrollAlwaysVisible = True
        Me.lbOldChats.Size = New System.Drawing.Size(487, 316)
        Me.lbOldChats.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(0, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(487, 38)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Chat"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label12, "Date and time of the log file shown below")
        '
        'lbLogFilesList
        '
        Me.lbLogFilesList.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLogFilesList.FormattingEnabled = True
        Me.lbLogFilesList.Location = New System.Drawing.Point(0, 412)
        Me.lbLogFilesList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbLogFilesList.Name = "lbLogFilesList"
        Me.lbLogFilesList.ScrollAlwaysVisible = True
        Me.lbLogFilesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbLogFilesList.Size = New System.Drawing.Size(317, 160)
        Me.lbLogFilesList.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.lbLogFilesList, "Coj2 Controller automatically keeps the last 50 game log files and delete the res" & _
        "t of older files.")
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label13.Location = New System.Drawing.Point(0, 374)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(317, 39)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Log Files List"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label13, "Coj2 Controller automatically keeps the last 50 game log files and delete the res" & _
        "t of older files.")
        '
        'TabMaps
        '
        Me.TabMaps.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabMaps.Controls.Add(Me.Label19)
        Me.TabMaps.Controls.Add(Me.chkRememberMaps)
        Me.TabMaps.Controls.Add(Me.dgMaps)
        Me.TabMaps.Location = New System.Drawing.Point(4, 25)
        Me.TabMaps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabMaps.Name = "TabMaps"
        Me.TabMaps.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabMaps.Size = New System.Drawing.Size(487, 578)
        Me.TabMaps.TabIndex = 4
        Me.TabMaps.Text = "Maps"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(3, 492)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(475, 48)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "* Coj2 not allow modifying the map list when the server is working. You can modif" & _
    "y it when the server is stopped, by selecting the option ""Server Config"" from th" & _
    "e main menu."
        '
        'chkRememberMaps
        '
        Me.chkRememberMaps.AutoSize = True
        Me.chkRememberMaps.Checked = True
        Me.chkRememberMaps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberMaps.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRememberMaps.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkRememberMaps.Location = New System.Drawing.Point(8, 552)
        Me.chkRememberMaps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRememberMaps.Name = "chkRememberMaps"
        Me.chkRememberMaps.Size = New System.Drawing.Size(317, 19)
        Me.chkRememberMaps.TabIndex = 57
        Me.chkRememberMaps.Text = "Remember last map played when server start next time "
        Me.ToolTip1.SetToolTip(Me.chkRememberMaps, "If enabled, the map list will change to start in the next server reset by the cor" & _
        "responding map below.")
        Me.chkRememberMaps.UseVisualStyleBackColor = True
        '
        'dgMaps
        '
        Me.dgMaps.AllowUserToAddRows = False
        Me.dgMaps.AllowUserToDeleteRows = False
        Me.dgMaps.AllowUserToResizeColumns = False
        Me.dgMaps.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgMaps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMaps.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMaps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMaps.ColumnHeadersHeight = 32
        Me.dgMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMaps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaps, Me.ColMode})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMaps.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgMaps.EnableHeadersVisualStyles = False
        Me.dgMaps.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgMaps.Location = New System.Drawing.Point(0, 0)
        Me.dgMaps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgMaps.MaximumSize = New System.Drawing.Size(615, 786)
        Me.dgMaps.MinimumSize = New System.Drawing.Size(315, 286)
        Me.dgMaps.MultiSelect = False
        Me.dgMaps.Name = "dgMaps"
        Me.dgMaps.ReadOnly = True
        Me.dgMaps.RowHeadersVisible = False
        Me.dgMaps.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.139131!)
        Me.dgMaps.RowTemplate.ReadOnly = True
        Me.dgMaps.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMaps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgMaps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMaps.Size = New System.Drawing.Size(487, 490)
        Me.dgMaps.StandardTab = True
        Me.dgMaps.TabIndex = 47
        Me.dgMaps.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dgMaps, "Maps are going to be play by the order from this list. Can not be modified from h" & _
        "ere.")
        '
        'colMaps
        '
        Me.colMaps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMaps.DefaultCellStyle = DataGridViewCellStyle3
        Me.colMaps.HeaderText = "Maps list in rotation "
        Me.colMaps.MinimumWidth = 210
        Me.colMaps.Name = "colMaps"
        Me.colMaps.ReadOnly = True
        Me.colMaps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMaps.ToolTipText = "Maps are going to be play by the order from this list. Can not be modified from h" & _
    "ere."
        Me.colMaps.Width = 210
        '
        'ColMode
        '
        Me.ColMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.139131!)
        Me.ColMode.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColMode.HeaderText = "GameMode"
        Me.ColMode.MinimumWidth = 275
        Me.ColMode.Name = "ColMode"
        Me.ColMode.ReadOnly = True
        Me.ColMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColMode.ToolTipText = "Maps are going to be play by the order from this list. Can not be modified from h" & _
    "ere."
        Me.ColMode.Width = 275
        '
        'TabRules
        '
        Me.TabRules.Controls.Add(Me.Panel3)
        Me.TabRules.Location = New System.Drawing.Point(4, 25)
        Me.TabRules.Name = "TabRules"
        Me.TabRules.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRules.Size = New System.Drawing.Size(487, 578)
        Me.TabRules.TabIndex = 6
        Me.TabRules.Text = "Rules"
        Me.TabRules.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.chkCleanPlayersWarned)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.dgPlayersWarned)
        Me.Panel3.Controls.Add(Me.txtAddWords)
        Me.Panel3.Controls.Add(Me.btnAddWord)
        Me.Panel3.Controls.Add(Me.btnRemoveWords)
        Me.Panel3.Controls.Add(Me.lbWords)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 572)
        Me.Panel3.TabIndex = 0
        '
        'chkCleanPlayersWarned
        '
        Me.chkCleanPlayersWarned.AutoSize = True
        Me.chkCleanPlayersWarned.Checked = True
        Me.chkCleanPlayersWarned.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCleanPlayersWarned.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Italic)
        Me.chkCleanPlayersWarned.Location = New System.Drawing.Point(248, 314)
        Me.chkCleanPlayersWarned.Name = "chkCleanPlayersWarned"
        Me.chkCleanPlayersWarned.Size = New System.Drawing.Size(217, 17)
        Me.chkCleanPlayersWarned.TabIndex = 67
        Me.chkCleanPlayersWarned.Text = "Clean List Player Warned each new map."
        Me.chkCleanPlayersWarned.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtWarningWords)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cboxWordBanEachTimes)
        Me.GroupBox1.Controls.Add(Me.rbWordsBan)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cboxWordKickEachTimes)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboxWordKillEachTimes)
        Me.GroupBox1.Controls.Add(Me.rbWordsKick)
        Me.GroupBox1.Controls.Add(Me.rbWordsSendWarning)
        Me.GroupBox1.Controls.Add(Me.rbWordsKill)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(239, 347)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 224)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(98, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(132, 13)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Message (max. 60 chars.)"
        '
        'txtWarningWords
        '
        Me.txtWarningWords.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarningWords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtWarningWords.Location = New System.Drawing.Point(6, 143)
        Me.txtWarningWords.MaxLength = 60
        Me.txtWarningWords.Multiline = True
        Me.txtWarningWords.Name = "txtWarningWords"
        Me.txtWarningWords.Size = New System.Drawing.Size(227, 73)
        Me.txtWarningWords.TabIndex = 10
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(155, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "times."
        '
        'cboxWordBanEachTimes
        '
        Me.cboxWordBanEachTimes.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxWordBanEachTimes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboxWordBanEachTimes.FormattingEnabled = True
        Me.cboxWordBanEachTimes.Items.AddRange(New Object() {" 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8"})
        Me.cboxWordBanEachTimes.Location = New System.Drawing.Point(110, 96)
        Me.cboxWordBanEachTimes.MaxLength = 2
        Me.cboxWordBanEachTimes.Name = "cboxWordBanEachTimes"
        Me.cboxWordBanEachTimes.Size = New System.Drawing.Size(42, 21)
        Me.cboxWordBanEachTimes.TabIndex = 8
        Me.cboxWordBanEachTimes.Text = "5"
        '
        'rbWordsBan
        '
        Me.rbWordsBan.AutoSize = True
        Me.rbWordsBan.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWordsBan.Location = New System.Drawing.Point(10, 97)
        Me.rbWordsBan.Name = "rbWordsBan"
        Me.rbWordsBan.Size = New System.Drawing.Size(96, 17)
        Me.rbWordsBan.TabIndex = 7
        Me.rbWordsBan.Text = "BAN him each"
        Me.rbWordsBan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbWordsBan.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(155, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "times."
        '
        'cboxWordKickEachTimes
        '
        Me.cboxWordKickEachTimes.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxWordKickEachTimes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboxWordKickEachTimes.FormattingEnabled = True
        Me.cboxWordKickEachTimes.Items.AddRange(New Object() {" 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8"})
        Me.cboxWordKickEachTimes.Location = New System.Drawing.Point(110, 72)
        Me.cboxWordKickEachTimes.MaxLength = 2
        Me.cboxWordKickEachTimes.Name = "cboxWordKickEachTimes"
        Me.cboxWordKickEachTimes.Size = New System.Drawing.Size(42, 21)
        Me.cboxWordKickEachTimes.TabIndex = 5
        Me.cboxWordKickEachTimes.Text = "3"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(155, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "times."
        '
        'cboxWordKillEachTimes
        '
        Me.cboxWordKillEachTimes.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxWordKillEachTimes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboxWordKillEachTimes.FormattingEnabled = True
        Me.cboxWordKillEachTimes.Items.AddRange(New Object() {" 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8"})
        Me.cboxWordKillEachTimes.Location = New System.Drawing.Point(110, 48)
        Me.cboxWordKillEachTimes.MaxLength = 2
        Me.cboxWordKillEachTimes.Name = "cboxWordKillEachTimes"
        Me.cboxWordKillEachTimes.Size = New System.Drawing.Size(42, 21)
        Me.cboxWordKillEachTimes.TabIndex = 3
        Me.cboxWordKillEachTimes.Text = "2"
        '
        'rbWordsKick
        '
        Me.rbWordsKick.AutoSize = True
        Me.rbWordsKick.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWordsKick.Location = New System.Drawing.Point(10, 73)
        Me.rbWordsKick.Name = "rbWordsKick"
        Me.rbWordsKick.Size = New System.Drawing.Size(96, 17)
        Me.rbWordsKick.TabIndex = 2
        Me.rbWordsKick.Text = "KICK him each"
        Me.rbWordsKick.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbWordsKick.UseVisualStyleBackColor = True
        '
        'rbWordsSendWarning
        '
        Me.rbWordsSendWarning.AutoSize = True
        Me.rbWordsSendWarning.Checked = True
        Me.rbWordsSendWarning.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWordsSendWarning.Location = New System.Drawing.Point(10, 26)
        Me.rbWordsSendWarning.Name = "rbWordsSendWarning"
        Me.rbWordsSendWarning.Size = New System.Drawing.Size(201, 17)
        Me.rbWordsSendWarning.TabIndex = 0
        Me.rbWordsSendWarning.TabStop = True
        Me.rbWordsSendWarning.Text = "Only send a message to the player"
        Me.rbWordsSendWarning.UseVisualStyleBackColor = True
        '
        'rbWordsKill
        '
        Me.rbWordsKill.AutoSize = True
        Me.rbWordsKill.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWordsKill.Location = New System.Drawing.Point(10, 50)
        Me.rbWordsKill.Name = "rbWordsKill"
        Me.rbWordsKill.Size = New System.Drawing.Size(96, 17)
        Me.rbWordsKill.TabIndex = 1
        Me.rbWordsKill.Text = "KILL  him each"
        Me.rbWordsKill.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbWordsKill.UseVisualStyleBackColor = True
        '
        'dgPlayersWarned
        '
        Me.dgPlayersWarned.AllowUserToAddRows = False
        Me.dgPlayersWarned.AllowUserToDeleteRows = False
        Me.dgPlayersWarned.AllowUserToResizeColumns = False
        Me.dgPlayersWarned.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgPlayersWarned.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgPlayersWarned.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPlayersWarned.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgPlayersWarned.ColumnHeadersHeight = 32
        Me.dgPlayersWarned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPlayersWarned.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlayersWarned.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgPlayersWarned.EnableHeadersVisualStyles = False
        Me.dgPlayersWarned.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgPlayersWarned.Location = New System.Drawing.Point(240, 5)
        Me.dgPlayersWarned.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgPlayersWarned.MaximumSize = New System.Drawing.Size(615, 786)
        Me.dgPlayersWarned.MinimumSize = New System.Drawing.Size(220, 286)
        Me.dgPlayersWarned.MultiSelect = False
        Me.dgPlayersWarned.Name = "dgPlayersWarned"
        Me.dgPlayersWarned.ReadOnly = True
        Me.dgPlayersWarned.RowHeadersVisible = False
        Me.dgPlayersWarned.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPlayersWarned.RowTemplate.ReadOnly = True
        Me.dgPlayersWarned.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlayersWarned.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgPlayersWarned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPlayersWarned.Size = New System.Drawing.Size(238, 308)
        Me.dgPlayersWarned.StandardTab = True
        Me.dgPlayersWarned.TabIndex = 64
        Me.dgPlayersWarned.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dgPlayersWarned, "Players list who have been warned")
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Warnings"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 65
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Number of warnings received by each player."
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Players Warned"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 275
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Players list of players who have been warned for breaking the rules"
        Me.DataGridViewTextBoxColumn2.Width = 275
        '
        'txtAddWords
        '
        Me.txtAddWords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddWords.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddWords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtAddWords.Location = New System.Drawing.Point(4, 485)
        Me.txtAddWords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddWords.MaxLength = 42
        Me.txtAddWords.Name = "txtAddWords"
        Me.txtAddWords.Size = New System.Drawing.Size(228, 21)
        Me.txtAddWords.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtAddWords, "Words typed here will be added to the forbidden list words.")
        '
        'btnAddWord
        '
        Me.btnAddWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddWord.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWord.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAddWord.Location = New System.Drawing.Point(155, 525)
        Me.btnAddWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddWord.Name = "btnAddWord"
        Me.btnAddWord.Size = New System.Drawing.Size(77, 39)
        Me.btnAddWord.TabIndex = 62
        Me.btnAddWord.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAddWord, "Add the phrase/word typed above to the list.")
        Me.btnAddWord.UseVisualStyleBackColor = False
        '
        'btnRemoveWords
        '
        Me.btnRemoveWords.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnRemoveWords.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveWords.Location = New System.Drawing.Point(8, 525)
        Me.btnRemoveWords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoveWords.Name = "btnRemoveWords"
        Me.btnRemoveWords.Size = New System.Drawing.Size(74, 39)
        Me.btnRemoveWords.TabIndex = 61
        Me.btnRemoveWords.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.btnRemoveWords, "Remove all selected words in the forbidden list words above.")
        Me.btnRemoveWords.UseVisualStyleBackColor = False
        '
        'lbWords
        '
        Me.lbWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWords.FormattingEnabled = True
        Me.lbWords.HorizontalScrollbar = True
        Me.lbWords.Location = New System.Drawing.Point(3, 36)
        Me.lbWords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbWords.Name = "lbWords"
        Me.lbWords.ScrollAlwaysVisible = True
        Me.lbWords.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbWords.Size = New System.Drawing.Size(229, 433)
        Me.lbWords.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.lbWords, "Current words/phrases forbidden in this server.")
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(3, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(229, 32)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "List of forbidden Phrases/Words"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label21, "Current words/phrases forbidden in this server.")
        '
        'TimerGetPlayerList
        '
        Me.TimerGetPlayerList.Interval = 1000
        '
        'TimerVote
        '
        Me.TimerVote.Interval = 1000
        '
        'TimerGetMapList
        '
        Me.TimerGetMapList.Interval = 20000
        '
        'TimerKillBalance
        '
        Me.TimerKillBalance.Interval = 6000
        '
        'btnHelp
        '
        Me.btnHelp.AutoSize = True
        Me.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 6.26087!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(421, 1)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(62, 23)
        Me.btnHelp.TabIndex = 62
        Me.btnHelp.Text = "Help (F1)"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmConsola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 600)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.TabPanel1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(709, 846)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(509, 646)
        Me.Name = "frmConsola"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Coj2 Controller"
        Me.TabPanel1.ResumeLayout(False)
        Me.TabChat.ResumeLayout(False)
        Me.TabChat.PerformLayout()
        Me.PanelTeams.ResumeLayout(False)
        Me.PanelTeams.PerformLayout()
        Me.PanelAdminMess.ResumeLayout(False)
        Me.TabPlayers.ResumeLayout(False)
        Me.PanelPlayer.ResumeLayout(False)
        Me.PanelPlayer.PerformLayout()
        Me.TabTeams.ResumeLayout(False)
        Me.PanelTabTeams.ResumeLayout(False)
        Me.PanelTabTeams.PerformLayout()
        Me.TabAdmins.ResumeLayout(False)
        Me.PanelAdmins.ResumeLayout(False)
        Me.PanelAdmins.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabLogs.ResumeLayout(False)
        Me.TabLogs.PerformLayout()
        Me.TabMaps.ResumeLayout(False)
        Me.TabMaps.PerformLayout()
        CType(Me.dgMaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRules.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPlayersWarned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents TimerLoad As System.Windows.Forms.Timer
    Friend WithEvents TimerCountDown As System.Windows.Forms.Timer
    Friend WithEvents TimerReadConsole As System.Windows.Forms.Timer
    Friend WithEvents TimerReadConsoleInst As System.Windows.Forms.Timer
    Friend WithEvents TabPanel1 As System.Windows.Forms.TabControl
    Friend WithEvents TabChat As System.Windows.Forms.TabPage
    Friend WithEvents cboxMess As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAdMessTime3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdMess3 As System.Windows.Forms.TextBox
    Friend WithEvents chkMess3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdMessTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdMess2 As System.Windows.Forms.TextBox
    Friend WithEvents chkMess2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdMessTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdMess1 As System.Windows.Forms.TextBox
    Friend WithEvents chkMess1 As System.Windows.Forms.CheckBox
    Friend WithEvents PanelAdminMess As System.Windows.Forms.Panel
    Friend WithEvents cboxCabMess3 As System.Windows.Forms.ComboBox
    Friend WithEvents lbConsola As System.Windows.Forms.ListBox
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents txtEnviaTexto As System.Windows.Forms.TextBox
    Friend WithEvents TabPlayers As System.Windows.Forms.TabPage
    Friend WithEvents LbPlayers As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMapNext As System.Windows.Forms.Button
    Friend WithEvents btnPlayerList As System.Windows.Forms.Button
    Friend WithEvents cboxReason As System.Windows.Forms.ComboBox
    Friend WithEvents btnKick As System.Windows.Forms.Button
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbBanned As System.Windows.Forms.ListBox
    Friend WithEvents btnBan As System.Windows.Forms.Button
    Friend WithEvents btnClearBan As System.Windows.Forms.Button
    Friend WithEvents PanelPlayer As System.Windows.Forms.Panel
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents lblNumPlayers As System.Windows.Forms.Label
    Friend WithEvents lblCurrentMap As System.Windows.Forms.Label
    Friend WithEvents TimerGetPlayerList As System.Windows.Forms.Timer
    Friend WithEvents TabAdmins As System.Windows.Forms.TabPage
    Friend WithEvents PanelAdmins As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbPlayers2 As System.Windows.Forms.ListBox
    Friend WithEvents btnAddAdmin As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDeleAdmin As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbAdmin As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNewAdmin As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAdminTbox As System.Windows.Forms.Button
    Friend WithEvents txtNewBanned As System.Windows.Forms.TextBox
    Friend WithEvents btnAddBannedTBox As System.Windows.Forms.Button
    Friend WithEvents TabLogs As System.Windows.Forms.TabPage
    Friend WithEvents TimerVote As System.Windows.Forms.Timer
    Friend WithEvents TabMaps As System.Windows.Forms.TabPage
    Friend WithEvents dgMaps As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteLog As System.Windows.Forms.Button
    Friend WithEvents lbOldChats As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbLogFilesList As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnLoadLog As System.Windows.Forms.Button
    Friend WithEvents lblFindInChat As System.Windows.Forms.Label
    Friend WithEvents txtFindInChat As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaEnOldChat As System.Windows.Forms.Button
    Friend WithEvents TimerGetMapList As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkVotemapnext As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayerlist As System.Windows.Forms.CheckBox
    Friend WithEvents chkCommandlist As System.Windows.Forms.CheckBox
    Friend WithEvents chkCommandlistAd As System.Windows.Forms.CheckBox
    Friend WithEvents chkRestart As System.Windows.Forms.CheckBox
    Friend WithEvents chkServershutdown As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdminsay As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayerlistAd As System.Windows.Forms.CheckBox
    Friend WithEvents chkBanlist As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnban As System.Windows.Forms.CheckBox
    Friend WithEvents chkBan As System.Windows.Forms.CheckBox
    Friend WithEvents chkKick As System.Windows.Forms.CheckBox
    Friend WithEvents chkKill As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewadmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkMapnext As System.Windows.Forms.CheckBox
    Friend WithEvents chkMaplistAd As System.Windows.Forms.CheckBox
    Friend WithEvents chkMaplist As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoteBan As System.Windows.Forms.CheckBox
    Friend WithEvents chkVotekick As System.Windows.Forms.CheckBox
    Friend WithEvents chkRememberMaps As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblRemainTime As System.Windows.Forms.Label
    Friend WithEvents lblTimeMap As System.Windows.Forms.Label
    Friend WithEvents lblQuantityLogs As System.Windows.Forms.Label
    Friend WithEvents lblBountyOrPoints As System.Windows.Forms.Label
    Friend WithEvents chkBalance As System.Windows.Forms.CheckBox
    Friend WithEvents lblTeamRed As System.Windows.Forms.Label
    Friend WithEvents lblTeamBlue As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PanelTeams As System.Windows.Forms.Panel
    Friend WithEvents chkBalanceAd As System.Windows.Forms.CheckBox
    Friend WithEvents TabTeams As System.Windows.Forms.TabPage
    Friend WithEvents lbBlueTeam As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbRedTeam As System.Windows.Forms.ListBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TimerKillBalance As System.Windows.Forms.Timer
    Friend WithEvents colMaps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkBalance2 As System.Windows.Forms.CheckBox
    Friend WithEvents cboxReasonBlue As System.Windows.Forms.ComboBox
    Friend WithEvents btnKillBlue As System.Windows.Forms.Button
    Friend WithEvents btnKickBlue As System.Windows.Forms.Button
    Friend WithEvents cboxReasonRed As System.Windows.Forms.ComboBox
    Friend WithEvents btnKillRed As System.Windows.Forms.Button
    Friend WithEvents btnKickRed As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PanelTabTeams As System.Windows.Forms.Panel
    Friend WithEvents TabRules As System.Windows.Forms.TabPage
    Friend WithEvents chkAddWord As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtWarningWords As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboxWordBanEachTimes As System.Windows.Forms.ComboBox
    Friend WithEvents rbWordsBan As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboxWordKickEachTimes As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboxWordKillEachTimes As System.Windows.Forms.ComboBox
    Friend WithEvents rbWordsKick As System.Windows.Forms.RadioButton
    Friend WithEvents rbWordsSendWarning As System.Windows.Forms.RadioButton
    Friend WithEvents rbWordsKill As System.Windows.Forms.RadioButton
    Friend WithEvents dgPlayersWarned As System.Windows.Forms.DataGridView
    Friend WithEvents txtAddWords As System.Windows.Forms.TextBox
    Friend WithEvents btnAddWord As System.Windows.Forms.Button
    Friend WithEvents btnRemoveWords As System.Windows.Forms.Button
    Friend WithEvents lbWords As System.Windows.Forms.ListBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkCleanPlayersWarned As System.Windows.Forms.CheckBox
    Friend WithEvents lblWarnings As System.Windows.Forms.Label
    Friend WithEvents lblWarnedPlayers As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
