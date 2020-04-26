<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArmas))
        Me.cbClass = New System.Windows.Forms.ComboBox()
        Me.lblWeap1 = New System.Windows.Forms.Label()
        Me.cbWeap1 = New System.Windows.Forms.ComboBox()
        Me.cbWeap2 = New System.Windows.Forms.ComboBox()
        Me.lblWeap2 = New System.Windows.Forms.Label()
        Me.cbWeap3 = New System.Windows.Forms.ComboBox()
        Me.lblWeap3 = New System.Windows.Forms.Label()
        Me.checkWeap4 = New System.Windows.Forms.CheckBox()
        Me.pictureWeap1 = New System.Windows.Forms.PictureBox()
        Me.pictureWeap2 = New System.Windows.Forms.PictureBox()
        Me.pictureWeap3 = New System.Windows.Forms.PictureBox()
        Me.pictureWeap4 = New System.Windows.Forms.PictureBox()
        Me.lblAmmo1 = New System.Windows.Forms.Label()
        Me.cbAmmo1 = New System.Windows.Forms.ComboBox()
        Me.cbAmmo2 = New System.Windows.Forms.ComboBox()
        Me.lblAmmo2 = New System.Windows.Forms.Label()
        Me.cbAmmo3 = New System.Windows.Forms.ComboBox()
        Me.lblAmmo3 = New System.Windows.Forms.Label()
        Me.cbAmmo4 = New System.Windows.Forms.ComboBox()
        Me.lblAmmo4 = New System.Windows.Forms.Label()
        Me.dialRuta = New System.Windows.Forms.FolderBrowserDialog()
        Me.panelAmmo = New System.Windows.Forms.GroupBox()
        Me.cbAmmo5 = New System.Windows.Forms.ComboBox()
        Me.lblAmmo5 = New System.Windows.Forms.Label()
        Me.groupClass = New System.Windows.Forms.GroupBox()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.groupWeap = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panelRightHand = New System.Windows.Forms.GroupBox()
        Me.panelLeftHand = New System.Windows.Forms.GroupBox()
        Me.panelBothHands = New System.Windows.Forms.GroupBox()
        Me.panelModificarArmas = New System.Windows.Forms.Panel()
        Me.lblCreatingEditing = New System.Windows.Forms.Label()
        Me.cbDefault = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureClass = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.checkHC = New System.Windows.Forms.CheckBox()
        Me.pictureHC = New System.Windows.Forms.PictureBox()
        Me.TabControlMods = New System.Windows.Forms.TabControl()
        Me.tabNewMod = New System.Windows.Forms.TabPage()
        Me.btnLookMod = New System.Windows.Forms.Button()
        Me.btnSetMod = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.lbNewChar = New System.Windows.Forms.ListBox()
        Me.btnNewMod = New System.Windows.Forms.Button()
        Me.btnDeleteMod = New System.Windows.Forms.Button()
        Me.lbLoadMod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnServerConfig = New System.Windows.Forms.Button()
        Me.btnLaunchDS = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureWeap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureWeap2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureWeap3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureWeap4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAmmo.SuspendLayout()
        Me.groupClass.SuspendLayout()
        Me.groupWeap.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelRightHand.SuspendLayout()
        Me.panelLeftHand.SuspendLayout()
        Me.panelBothHands.SuspendLayout()
        Me.panelModificarArmas.SuspendLayout()
        CType(Me.pictureClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureHC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlMods.SuspendLayout()
        Me.tabNewMod.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbClass
        '
        Me.cbClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClass.FormattingEnabled = True
        Me.cbClass.Items.AddRange(New Object() {"Aristocrat", "Bandit", "Barnsby", "Doc", "Gunslinger", "Gunsmith", "Juarez", "Miner", "Rifleman", "Sniper", "Thief", "Trapper", "Tribe Warrior"})
        Me.cbClass.Location = New System.Drawing.Point(13, 31)
        Me.cbClass.Margin = New System.Windows.Forms.Padding(4)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(160, 24)
        Me.cbClass.TabIndex = 1
        '
        'lblWeap1
        '
        Me.lblWeap1.AutoSize = True
        Me.lblWeap1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeap1.Location = New System.Drawing.Point(237, 12)
        Me.lblWeap1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeap1.Name = "lblWeap1"
        Me.lblWeap1.Size = New System.Drawing.Size(80, 18)
        Me.lblWeap1.TabIndex = 2
        Me.lblWeap1.Text = "Left Hand"
        '
        'cbWeap1
        '
        Me.cbWeap1.FormattingEnabled = True
        Me.cbWeap1.Items.AddRange(New Object() {"Cogswell", "Derringer", "Lemant", "Peacemaker", "SawOff", "Schofield", "Volcanic", "Walker", "None"})
        Me.cbWeap1.Location = New System.Drawing.Point(281, 44)
        Me.cbWeap1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbWeap1.Name = "cbWeap1"
        Me.cbWeap1.Size = New System.Drawing.Size(259, 24)
        Me.cbWeap1.TabIndex = 1
        '
        'cbWeap2
        '
        Me.cbWeap2.FormattingEnabled = True
        Me.cbWeap2.Items.AddRange(New Object() {"Cogswell", "Derringer", "Lemant", "Peacemaker", "SawOff", "Schofield", "Volcanic", "Walker", "None"})
        Me.cbWeap2.Location = New System.Drawing.Point(8, 46)
        Me.cbWeap2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbWeap2.Name = "cbWeap2"
        Me.cbWeap2.Size = New System.Drawing.Size(259, 24)
        Me.cbWeap2.TabIndex = 0
        '
        'lblWeap2
        '
        Me.lblWeap2.AutoSize = True
        Me.lblWeap2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeap2.Location = New System.Drawing.Point(95, 12)
        Me.lblWeap2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeap2.Name = "lblWeap2"
        Me.lblWeap2.Size = New System.Drawing.Size(91, 18)
        Me.lblWeap2.TabIndex = 4
        Me.lblWeap2.Text = "Right Hand"
        '
        'cbWeap3
        '
        Me.cbWeap3.FormattingEnabled = True
        Me.cbWeap3.Items.AddRange(New Object() {"Bow", "Remington", "Sharps", "Sharps Scope", "Winchester", "Winchester Scope", "None"})
        Me.cbWeap3.Location = New System.Drawing.Point(24, 69)
        Me.cbWeap3.Margin = New System.Windows.Forms.Padding(4)
        Me.cbWeap3.Name = "cbWeap3"
        Me.cbWeap3.Size = New System.Drawing.Size(259, 24)
        Me.cbWeap3.TabIndex = 0
        '
        'lblWeap3
        '
        Me.lblWeap3.AutoSize = True
        Me.lblWeap3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeap3.Location = New System.Drawing.Point(133, 37)
        Me.lblWeap3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeap3.Name = "lblWeap3"
        Me.lblWeap3.Size = New System.Drawing.Size(93, 18)
        Me.lblWeap3.TabIndex = 6
        Me.lblWeap3.Text = "Both hands"
        '
        'checkWeap4
        '
        Me.checkWeap4.AutoSize = True
        Me.checkWeap4.Location = New System.Drawing.Point(88, 48)
        Me.checkWeap4.Margin = New System.Windows.Forms.Padding(4)
        Me.checkWeap4.Name = "checkWeap4"
        Me.checkWeap4.Size = New System.Drawing.Size(86, 21)
        Me.checkWeap4.TabIndex = 0
        Me.checkWeap4.Text = "Dynamite"
        Me.checkWeap4.UseVisualStyleBackColor = True
        '
        'pictureWeap1
        '
        Me.pictureWeap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureWeap1.ErrorImage = Nothing
        Me.pictureWeap1.InitialImage = Nothing
        Me.pictureWeap1.Location = New System.Drawing.Point(281, 78)
        Me.pictureWeap1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureWeap1.Name = "pictureWeap1"
        Me.pictureWeap1.Size = New System.Drawing.Size(259, 95)
        Me.pictureWeap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWeap1.TabIndex = 10
        Me.pictureWeap1.TabStop = False
        '
        'pictureWeap2
        '
        Me.pictureWeap2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureWeap2.ErrorImage = Nothing
        Me.pictureWeap2.Location = New System.Drawing.Point(8, 79)
        Me.pictureWeap2.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureWeap2.Name = "pictureWeap2"
        Me.pictureWeap2.Size = New System.Drawing.Size(259, 95)
        Me.pictureWeap2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWeap2.TabIndex = 11
        Me.pictureWeap2.TabStop = False
        '
        'pictureWeap3
        '
        Me.pictureWeap3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureWeap3.ErrorImage = Nothing
        Me.pictureWeap3.Location = New System.Drawing.Point(24, 102)
        Me.pictureWeap3.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureWeap3.Name = "pictureWeap3"
        Me.pictureWeap3.Size = New System.Drawing.Size(259, 95)
        Me.pictureWeap3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWeap3.TabIndex = 12
        Me.pictureWeap3.TabStop = False
        '
        'pictureWeap4
        '
        Me.pictureWeap4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureWeap4.Location = New System.Drawing.Point(7, 78)
        Me.pictureWeap4.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureWeap4.Name = "pictureWeap4"
        Me.pictureWeap4.Size = New System.Drawing.Size(259, 95)
        Me.pictureWeap4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWeap4.TabIndex = 13
        Me.pictureWeap4.TabStop = False
        '
        'lblAmmo1
        '
        Me.lblAmmo1.AutoSize = True
        Me.lblAmmo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmo1.Location = New System.Drawing.Point(193, 26)
        Me.lblAmmo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmmo1.Name = "lblAmmo1"
        Me.lblAmmo1.Size = New System.Drawing.Size(85, 17)
        Me.lblAmmo1.TabIndex = 4
        Me.lblAmmo1.Text = "Pistol Ammo"
        '
        'cbAmmo1
        '
        Me.cbAmmo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmmo1.FormattingEnabled = True
        Me.cbAmmo1.Items.AddRange(New Object() {"35", "45", "55", "65", "75", "95", "140", "190"})
        Me.cbAmmo1.Location = New System.Drawing.Point(281, 22)
        Me.cbAmmo1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAmmo1.Name = "cbAmmo1"
        Me.cbAmmo1.Size = New System.Drawing.Size(64, 24)
        Me.cbAmmo1.TabIndex = 1
        '
        'cbAmmo2
        '
        Me.cbAmmo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmmo2.FormattingEnabled = True
        Me.cbAmmo2.Items.AddRange(New Object() {"35", "45", "55", "65", "75", "95", "140", "190"})
        Me.cbAmmo2.Location = New System.Drawing.Point(453, 22)
        Me.cbAmmo2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAmmo2.Name = "cbAmmo2"
        Me.cbAmmo2.Size = New System.Drawing.Size(64, 24)
        Me.cbAmmo2.TabIndex = 18
        '
        'lblAmmo2
        '
        Me.lblAmmo2.AutoSize = True
        Me.lblAmmo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmo2.Location = New System.Drawing.Point(371, 26)
        Me.lblAmmo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmmo2.Name = "lblAmmo2"
        Me.lblAmmo2.Size = New System.Drawing.Size(79, 17)
        Me.lblAmmo2.TabIndex = 16
        Me.lblAmmo2.Text = "Rifle Ammo"
        '
        'cbAmmo3
        '
        Me.cbAmmo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmmo3.FormattingEnabled = True
        Me.cbAmmo3.Items.AddRange(New Object() {"35", "45", "55", "65", "75", "95", "140", "190"})
        Me.cbAmmo3.Location = New System.Drawing.Point(796, 22)
        Me.cbAmmo3.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAmmo3.Name = "cbAmmo3"
        Me.cbAmmo3.Size = New System.Drawing.Size(64, 24)
        Me.cbAmmo3.TabIndex = 20
        '
        'lblAmmo3
        '
        Me.lblAmmo3.AutoSize = True
        Me.lblAmmo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmo3.Location = New System.Drawing.Point(741, 26)
        Me.lblAmmo3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmmo3.Name = "lblAmmo3"
        Me.lblAmmo3.Size = New System.Drawing.Size(51, 17)
        Me.lblAmmo3.TabIndex = 18
        Me.lblAmmo3.Text = "Arrows"
        '
        'cbAmmo4
        '
        Me.cbAmmo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmmo4.FormattingEnabled = True
        Me.cbAmmo4.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbAmmo4.Location = New System.Drawing.Point(101, 22)
        Me.cbAmmo4.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAmmo4.Name = "cbAmmo4"
        Me.cbAmmo4.Size = New System.Drawing.Size(64, 24)
        Me.cbAmmo4.TabIndex = 21
        '
        'lblAmmo4
        '
        Me.lblAmmo4.AutoSize = True
        Me.lblAmmo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmo4.Location = New System.Drawing.Point(24, 26)
        Me.lblAmmo4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmmo4.Name = "lblAmmo4"
        Me.lblAmmo4.Size = New System.Drawing.Size(74, 17)
        Me.lblAmmo4.TabIndex = 20
        Me.lblAmmo4.Text = "Dynamites"
        '
        'dialRuta
        '
        Me.dialRuta.Description = "Select your CoJ Bound in Blood dedicated server folder."
        Me.dialRuta.ShowNewFolderButton = False
        '
        'panelAmmo
        '
        Me.panelAmmo.Controls.Add(Me.cbAmmo5)
        Me.panelAmmo.Controls.Add(Me.lblAmmo5)
        Me.panelAmmo.Controls.Add(Me.cbAmmo4)
        Me.panelAmmo.Controls.Add(Me.cbAmmo3)
        Me.panelAmmo.Controls.Add(Me.lblAmmo4)
        Me.panelAmmo.Controls.Add(Me.lblAmmo3)
        Me.panelAmmo.Controls.Add(Me.cbAmmo2)
        Me.panelAmmo.Controls.Add(Me.lblAmmo2)
        Me.panelAmmo.Controls.Add(Me.cbAmmo1)
        Me.panelAmmo.Controls.Add(Me.lblAmmo1)
        Me.panelAmmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAmmo.Location = New System.Drawing.Point(135, 286)
        Me.panelAmmo.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAmmo.Name = "panelAmmo"
        Me.panelAmmo.Padding = New System.Windows.Forms.Padding(4)
        Me.panelAmmo.Size = New System.Drawing.Size(887, 54)
        Me.panelAmmo.TabIndex = 24
        Me.panelAmmo.TabStop = False
        Me.panelAmmo.Text = "Ammunition"
        '
        'cbAmmo5
        '
        Me.cbAmmo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmmo5.FormattingEnabled = True
        Me.cbAmmo5.Items.AddRange(New Object() {"35", "45", "55", "65", "75", "95", "140", "190"})
        Me.cbAmmo5.Location = New System.Drawing.Point(652, 22)
        Me.cbAmmo5.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAmmo5.Name = "cbAmmo5"
        Me.cbAmmo5.Size = New System.Drawing.Size(64, 24)
        Me.cbAmmo5.TabIndex = 19
        '
        'lblAmmo5
        '
        Me.lblAmmo5.AutoSize = True
        Me.lblAmmo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmmo5.Location = New System.Drawing.Point(544, 26)
        Me.lblAmmo5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmmo5.Name = "lblAmmo5"
        Me.lblAmmo5.Size = New System.Drawing.Size(104, 17)
        Me.lblAmmo5.TabIndex = 22
        Me.lblAmmo5.Text = "Shotgun Ammo"
        '
        'groupClass
        '
        Me.groupClass.Controls.Add(Me.btnDefault)
        Me.groupClass.Controls.Add(Me.cbClass)
        Me.groupClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupClass.Location = New System.Drawing.Point(585, 595)
        Me.groupClass.Margin = New System.Windows.Forms.Padding(4)
        Me.groupClass.Name = "groupClass"
        Me.groupClass.Padding = New System.Windows.Forms.Padding(4)
        Me.groupClass.Size = New System.Drawing.Size(192, 132)
        Me.groupClass.TabIndex = 25
        Me.groupClass.TabStop = False
        Me.groupClass.Text = "Class"
        Me.groupClass.Visible = False
        '
        'btnDefault
        '
        Me.btnDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefault.Location = New System.Drawing.Point(13, 71)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(161, 53)
        Me.btnDefault.TabIndex = 2
        Me.btnDefault.Text = "Set default weapons"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'groupWeap
        '
        Me.groupWeap.Controls.Add(Me.GroupBox1)
        Me.groupWeap.Controls.Add(Me.panelBothHands)
        Me.groupWeap.Controls.Add(Me.panelAmmo)
        Me.groupWeap.Controls.Add(Me.panelModificarArmas)
        Me.groupWeap.Location = New System.Drawing.Point(8, 248)
        Me.groupWeap.Margin = New System.Windows.Forms.Padding(4)
        Me.groupWeap.Name = "groupWeap"
        Me.groupWeap.Padding = New System.Windows.Forms.Padding(4)
        Me.groupWeap.Size = New System.Drawing.Size(1176, 352)
        Me.groupWeap.TabIndex = 26
        Me.groupWeap.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.panelRightHand)
        Me.GroupBox1.Controls.Add(Me.panelLeftHand)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 44)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(861, 229)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'panelRightHand
        '
        Me.panelRightHand.Controls.Add(Me.pictureWeap2)
        Me.panelRightHand.Controls.Add(Me.cbWeap2)
        Me.panelRightHand.Controls.Add(Me.lblWeap2)
        Me.panelRightHand.Location = New System.Drawing.Point(569, 25)
        Me.panelRightHand.Margin = New System.Windows.Forms.Padding(4)
        Me.panelRightHand.Name = "panelRightHand"
        Me.panelRightHand.Padding = New System.Windows.Forms.Padding(4)
        Me.panelRightHand.Size = New System.Drawing.Size(279, 186)
        Me.panelRightHand.TabIndex = 15
        Me.panelRightHand.TabStop = False
        '
        'panelLeftHand
        '
        Me.panelLeftHand.Controls.Add(Me.pictureWeap4)
        Me.panelLeftHand.Controls.Add(Me.pictureWeap1)
        Me.panelLeftHand.Controls.Add(Me.checkWeap4)
        Me.panelLeftHand.Controls.Add(Me.cbWeap1)
        Me.panelLeftHand.Controls.Add(Me.lblWeap1)
        Me.panelLeftHand.Location = New System.Drawing.Point(11, 25)
        Me.panelLeftHand.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLeftHand.Name = "panelLeftHand"
        Me.panelLeftHand.Padding = New System.Windows.Forms.Padding(4)
        Me.panelLeftHand.Size = New System.Drawing.Size(549, 186)
        Me.panelLeftHand.TabIndex = 14
        Me.panelLeftHand.TabStop = False
        '
        'panelBothHands
        '
        Me.panelBothHands.Controls.Add(Me.pictureWeap3)
        Me.panelBothHands.Controls.Add(Me.cbWeap3)
        Me.panelBothHands.Controls.Add(Me.lblWeap3)
        Me.panelBothHands.Location = New System.Drawing.Point(880, 44)
        Me.panelBothHands.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBothHands.Name = "panelBothHands"
        Me.panelBothHands.Padding = New System.Windows.Forms.Padding(4)
        Me.panelBothHands.Size = New System.Drawing.Size(296, 229)
        Me.panelBothHands.TabIndex = 14
        Me.panelBothHands.TabStop = False
        '
        'panelModificarArmas
        '
        Me.panelModificarArmas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelModificarArmas.Controls.Add(Me.lblCreatingEditing)
        Me.panelModificarArmas.Controls.Add(Me.cbDefault)
        Me.panelModificarArmas.Controls.Add(Me.Label2)
        Me.panelModificarArmas.Location = New System.Drawing.Point(0, 5)
        Me.panelModificarArmas.Margin = New System.Windows.Forms.Padding(4)
        Me.panelModificarArmas.Name = "panelModificarArmas"
        Me.panelModificarArmas.Size = New System.Drawing.Size(1176, 346)
        Me.panelModificarArmas.TabIndex = 31
        '
        'lblCreatingEditing
        '
        Me.lblCreatingEditing.AutoSize = True
        Me.lblCreatingEditing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatingEditing.Location = New System.Drawing.Point(198, 10)
        Me.lblCreatingEditing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreatingEditing.Name = "lblCreatingEditing"
        Me.lblCreatingEditing.Size = New System.Drawing.Size(447, 24)
        Me.lblCreatingEditing.TabIndex = 29
        Me.lblCreatingEditing.Text = "Weapon Configuration Class: TRIBE WARRIOR"
        '
        'cbDefault
        '
        Me.cbDefault.ForeColor = System.Drawing.Color.White
        Me.cbDefault.FormattingEnabled = True
        Me.cbDefault.Items.AddRange(New Object() {"Both hands Weapon", "Right Weapon + Left Weapon", "Right Weapon + TNT"})
        Me.cbDefault.Location = New System.Drawing.Point(907, 9)
        Me.cbDefault.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDefault.Name = "cbDefault"
        Me.cbDefault.Size = New System.Drawing.Size(249, 24)
        Me.cbDefault.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(761, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Respawn Weapons"
        '
        'pictureClass
        '
        Me.pictureClass.BackgroundImage = CType(resources.GetObject("pictureClass.BackgroundImage"), System.Drawing.Image)
        Me.pictureClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureClass.ErrorImage = Nothing
        Me.pictureClass.Location = New System.Drawing.Point(8, 9)
        Me.pictureClass.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureClass.Name = "pictureClass"
        Me.pictureClass.Size = New System.Drawing.Size(233, 229)
        Me.pictureClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureClass.TabIndex = 27
        Me.pictureClass.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(855, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(948, 625)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(223, 43)
        Me.btnRestore.TabIndex = 23
        Me.btnRestore.Text = "Restore original classes in game"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'checkHC
        '
        Me.checkHC.AutoSize = True
        Me.checkHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkHC.Location = New System.Drawing.Point(68, 638)
        Me.checkHC.Margin = New System.Windows.Forms.Padding(4)
        Me.checkHC.Name = "checkHC"
        Me.checkHC.Size = New System.Drawing.Size(144, 22)
        Me.checkHC.TabIndex = 22
        Me.checkHC.Text = "Hardcore mode"
        Me.checkHC.UseVisualStyleBackColor = True
        '
        'pictureHC
        '
        Me.pictureHC.Image = CType(resources.GetObject("pictureHC.Image"), System.Drawing.Image)
        Me.pictureHC.Location = New System.Drawing.Point(9, 613)
        Me.pictureHC.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureHC.Name = "pictureHC"
        Me.pictureHC.Size = New System.Drawing.Size(55, 62)
        Me.pictureHC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureHC.TabIndex = 35
        Me.pictureHC.TabStop = False
        '
        'TabControlMods
        '
        Me.TabControlMods.Controls.Add(Me.tabNewMod)
        Me.TabControlMods.Location = New System.Drawing.Point(500, 11)
        Me.TabControlMods.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlMods.Name = "TabControlMods"
        Me.TabControlMods.SelectedIndex = 0
        Me.TabControlMods.Size = New System.Drawing.Size(347, 227)
        Me.TabControlMods.TabIndex = 1
        '
        'tabNewMod
        '
        Me.tabNewMod.Controls.Add(Me.btnLookMod)
        Me.tabNewMod.Controls.Add(Me.btnSetMod)
        Me.tabNewMod.Controls.Add(Me.btnSave)
        Me.tabNewMod.Controls.Add(Me.btnSaveAs)
        Me.tabNewMod.Controls.Add(Me.lbNewChar)
        Me.tabNewMod.Location = New System.Drawing.Point(4, 25)
        Me.tabNewMod.Margin = New System.Windows.Forms.Padding(4)
        Me.tabNewMod.Name = "tabNewMod"
        Me.tabNewMod.Padding = New System.Windows.Forms.Padding(4)
        Me.tabNewMod.Size = New System.Drawing.Size(339, 198)
        Me.tabNewMod.TabIndex = 0
        Me.tabNewMod.Text = "New Mod"
        Me.tabNewMod.UseVisualStyleBackColor = True
        '
        'btnLookMod
        '
        Me.btnLookMod.Location = New System.Drawing.Point(216, 139)
        Me.btnLookMod.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookMod.Name = "btnLookMod"
        Me.btnLookMod.Size = New System.Drawing.Size(115, 47)
        Me.btnLookMod.TabIndex = 37
        Me.btnLookMod.Text = "Look Mod ..."
        Me.btnLookMod.UseVisualStyleBackColor = True
        '
        'btnSetMod
        '
        Me.btnSetMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetMod.Location = New System.Drawing.Point(216, 80)
        Me.btnSetMod.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSetMod.Name = "btnSetMod"
        Me.btnSetMod.Size = New System.Drawing.Size(115, 50)
        Me.btnSetMod.TabIndex = 6
        Me.btnSetMod.Text = "Set this mod ingame"
        Me.btnSetMod.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(216, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Location = New System.Drawing.Point(216, 44)
        Me.btnSaveAs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(115, 28)
        Me.btnSaveAs.TabIndex = 5
        Me.btnSaveAs.Text = "Save Mod as"
        Me.btnSaveAs.UseVisualStyleBackColor = True
        '
        'lbNewChar
        '
        Me.lbNewChar.FormattingEnabled = True
        Me.lbNewChar.ItemHeight = 16
        Me.lbNewChar.Location = New System.Drawing.Point(8, 7)
        Me.lbNewChar.Margin = New System.Windows.Forms.Padding(4)
        Me.lbNewChar.Name = "lbNewChar"
        Me.lbNewChar.Size = New System.Drawing.Size(196, 180)
        Me.lbNewChar.TabIndex = 0
        '
        'btnNewMod
        '
        Me.btnNewMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMod.Location = New System.Drawing.Point(250, 106)
        Me.btnNewMod.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewMod.Name = "btnNewMod"
        Me.btnNewMod.Size = New System.Drawing.Size(100, 28)
        Me.btnNewMod.TabIndex = 2
        Me.btnNewMod.Text = "New Mod"
        Me.btnNewMod.UseVisualStyleBackColor = True
        '
        'btnDeleteMod
        '
        Me.btnDeleteMod.Location = New System.Drawing.Point(374, 106)
        Me.btnDeleteMod.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteMod.Name = "btnDeleteMod"
        Me.btnDeleteMod.Size = New System.Drawing.Size(116, 28)
        Me.btnDeleteMod.TabIndex = 3
        Me.btnDeleteMod.Text = "Delete Mod(s)"
        Me.btnDeleteMod.UseVisualStyleBackColor = True
        '
        'lbLoadMod
        '
        Me.lbLoadMod.FormattingEnabled = True
        Me.lbLoadMod.Location = New System.Drawing.Point(250, 52)
        Me.lbLoadMod.Margin = New System.Windows.Forms.Padding(4)
        Me.lbLoadMod.Name = "lbLoadMod"
        Me.lbLoadMod.Size = New System.Drawing.Size(240, 24)
        Me.lbLoadMod.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "My Mods"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(323, 145)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(100, 28)
        Me.btnHelp.TabIndex = 31
        Me.btnHelp.Text = "(F1) Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "CoJ Mods.chm"
        '
        'btnServerConfig
        '
        Me.btnServerConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnServerConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServerConfig.Location = New System.Drawing.Point(377, 644)
        Me.btnServerConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.btnServerConfig.Name = "btnServerConfig"
        Me.btnServerConfig.Size = New System.Drawing.Size(185, 55)
        Me.btnServerConfig.TabIndex = 38
        Me.btnServerConfig.Text = "SERVER CONFIG"
        Me.btnServerConfig.UseVisualStyleBackColor = False
        Me.btnServerConfig.Visible = False
        '
        'btnLaunchDS
        '
        Me.btnLaunchDS.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnLaunchDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunchDS.Location = New System.Drawing.Point(377, 613)
        Me.btnLaunchDS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLaunchDS.Name = "btnLaunchDS"
        Me.btnLaunchDS.Size = New System.Drawing.Size(185, 55)
        Me.btnLaunchDS.TabIndex = 39
        Me.btnLaunchDS.Text = "Launch Dedicated Server"
        Me.btnLaunchDS.UseVisualStyleBackColor = False
        Me.btnLaunchDS.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
        '
        'frmArmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 687)
        Me.Controls.Add(Me.btnLaunchDS)
        Me.Controls.Add(Me.btnServerConfig)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewMod)
        Me.Controls.Add(Me.btnDeleteMod)
        Me.Controls.Add(Me.lbLoadMod)
        Me.Controls.Add(Me.TabControlMods)
        Me.Controls.Add(Me.pictureHC)
        Me.Controls.Add(Me.checkHC)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pictureClass)
        Me.Controls.Add(Me.groupWeap)
        Me.Controls.Add(Me.groupClass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1557, 940)
        Me.MinimumSize = New System.Drawing.Size(1211, 733)
        Me.Name = "frmArmas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modding CoJ2 for Dedicated Servers"
        CType(Me.pictureWeap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureWeap2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureWeap3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureWeap4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAmmo.ResumeLayout(False)
        Me.panelAmmo.PerformLayout()
        Me.groupClass.ResumeLayout(False)
        Me.groupWeap.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.panelRightHand.ResumeLayout(False)
        Me.panelRightHand.PerformLayout()
        Me.panelLeftHand.ResumeLayout(False)
        Me.panelLeftHand.PerformLayout()
        Me.panelBothHands.ResumeLayout(False)
        Me.panelBothHands.PerformLayout()
        Me.panelModificarArmas.ResumeLayout(False)
        Me.panelModificarArmas.PerformLayout()
        CType(Me.pictureClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureHC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlMods.ResumeLayout(False)
        Me.tabNewMod.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbClass As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeap1 As System.Windows.Forms.Label
    Friend WithEvents cbWeap1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbWeap2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeap2 As System.Windows.Forms.Label
    Friend WithEvents cbWeap3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeap3 As System.Windows.Forms.Label
    Friend WithEvents checkWeap4 As System.Windows.Forms.CheckBox
    Friend WithEvents pictureWeap1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureWeap2 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureWeap3 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureWeap4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAmmo1 As System.Windows.Forms.Label
    Friend WithEvents cbAmmo1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAmmo2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAmmo2 As System.Windows.Forms.Label
    Friend WithEvents cbAmmo3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAmmo3 As System.Windows.Forms.Label
    Friend WithEvents cbAmmo4 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAmmo4 As System.Windows.Forms.Label
    Friend WithEvents dialRuta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents panelAmmo As System.Windows.Forms.GroupBox
    Friend WithEvents groupClass As System.Windows.Forms.GroupBox
    Friend WithEvents groupWeap As System.Windows.Forms.GroupBox
    Friend WithEvents pictureClass As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbAmmo5 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAmmo5 As System.Windows.Forms.Label
    Friend WithEvents lblCreatingEditing As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents panelRightHand As System.Windows.Forms.GroupBox
    Friend WithEvents panelLeftHand As System.Windows.Forms.GroupBox
    Friend WithEvents panelBothHands As System.Windows.Forms.GroupBox
    Friend WithEvents cbDefault As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents checkHC As System.Windows.Forms.CheckBox
    Friend WithEvents pictureHC As System.Windows.Forms.PictureBox
    Friend WithEvents TabControlMods As System.Windows.Forms.TabControl
    Friend WithEvents tabNewMod As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents lbNewChar As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteMod As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSetMod As System.Windows.Forms.Button
    Friend WithEvents btnLookMod As System.Windows.Forms.Button
    Friend WithEvents btnNewMod As System.Windows.Forms.Button
    Friend WithEvents panelModificarArmas As System.Windows.Forms.Panel
    Friend WithEvents lbLoadMod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btnServerConfig As System.Windows.Forms.Button
    Friend WithEvents btnLaunchDS As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
