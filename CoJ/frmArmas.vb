' =================================================================================
' frmArmas.vb - Weapon mods form
' Date: 2013
' Created by: S!lv3r and Tr!tu.

'    Copyright (C) 2020 S!lv3r and Tr!tu.
'
'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.
'
'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.
'
'   You should have received a copy Of the GNU General Public License
'   along with this program. If Not, see <https://www.gnu.org/licenses/>.
'
'   Email contact: Tr!tu <victormvy@gmail.com>
' =================================================================================

Imports System.IO
Imports System.Environment

Public Class frmArmas
    'Dim write As StreamWriter
    Dim readini As StreamReader
    Dim writeini As StreamWriter
    Dim clase As String
    'Dim weap1 As String
    'Dim weap2 As String
    'Dim weap3 As String
    'Dim weap4 As String = """WeaponDynamiteStickNet"""
    Dim predeterminadaL As String
    Dim predeterminadaR As String
    Dim estabaActivadoHC As Integer = 0
    Dim currentFile As String
    Dim numeroClases As Integer
    'Dim descargando As Boolean = False


    'Variable para dar valor 0 si es false el check de la dinamita o 1 si es true
    Dim TntSiNo As String = ""

    Private Sub frmArmas_Leave(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim IniFinal As String = ""

        If ModIniCabecera = "" Then ModIniCabecera = "0"
        If ModIniCabecera <> "" Then IniFinal = IniFinal & ModIniCabecera
        If Trim(ModIniAristocrat) <> "" Then IniFinal = IniFinal & "Aristocrat" & ModIniAristocrat
        If Trim(ModIniBandit) <> "" Then IniFinal = IniFinal & "Bandit" & ModIniBandit
        If Trim(ModIniBarnsby) <> "" Then IniFinal = IniFinal & "Barnsby" & ModIniBarnsby
        If Trim(ModIniDoc) <> "" Then IniFinal = IniFinal & "Doc" & ModIniDoc
        If Trim(ModIniGunslinger) <> "" Then IniFinal = IniFinal & "Gunslinger" & ModIniGunslinger
        If Trim(ModIniGunsmith) <> "" Then IniFinal = IniFinal & "Gunsmith" & ModIniGunsmith
        If Trim(ModIniJuarez) <> "" Then IniFinal = IniFinal & "Juarez" & ModIniJuarez
        If Trim(ModIniMiner) <> "" Then IniFinal = IniFinal & "Miner" & ModIniMiner
        If Trim(ModIniRifleman) <> "" Then IniFinal = IniFinal & "Rifleman" & ModIniRifleman
        If Trim(ModIniSniper) <> "" Then IniFinal = IniFinal & "Sniper" & ModIniSniper
        If Trim(ModIniThief) <> "" Then IniFinal = IniFinal & "Thief" & ModIniThief
        If Trim(ModIniTrapper) <> "" Then IniFinal = IniFinal & "Trapper" & ModIniTrapper
        If Trim(ModIniTribeWarrior) <> "" Then IniFinal = IniFinal & "TribeWarrior" & ModIniTribeWarrior



        If Trim(ConfiguracionModInicial) <> Trim(IniFinal) And Trim(IniFinal) <> "0" Then
            Dim guardarmsg = MessageBox.Show("The current changes to this mod haven't been saved. Do you want to save now?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If guardarmsg = vbYes Then
                btnSave_Click()
            ElseIf guardarmsg = vbCancel Then
                e.Cancel = True
                Exit Sub
            End If
        End If


        If System.IO.Directory.Exists(ruta & rutaTemp) Then
            My.Computer.FileSystem.DeleteDirectory(ruta & rutaTemp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        FrmMain.Show()
        Me.Dispose()
        'Application.Exit()

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Mods\")

        RecargarMisMods()

        'Activamos o desactivamos el botón de activar mod.
        If lbNewChar.Items.Count = 0 Then
            btnSetMod.Enabled = False
        Else
            btnSetMod.Enabled = True
        End If

        'Cambiamos el color de la caja de predeterminado
        cbDefault.BackColor = Color.SeaGreen

        'Desactivamos por defecto las dinamitas.
        lblAmmo4.Enabled = False
        cbAmmo4.Enabled = False
        cbAmmo4.Text = 0
        pictureWeap4.ImageLocation = Application.StartupPath & "\images\weaps\nodynamite.png"


        'Asignamos los item que estarán seleccionados inicialmente.
        cbClass.SelectedIndex = 0
        cbWeap1.SelectedIndex = 8
        cbWeap2.SelectedIndex = 3
        cbWeap3.SelectedIndex = 5
        cbAmmo1.SelectedIndex = 1
        cbAmmo2.SelectedIndex = 3
        cbAmmo3.SelectedIndex = 3
        cbAmmo5.SelectedIndex = 0
        cbDefault.SelectedIndex = 0

        'Asignamos las imagenes de armas y clase iniciales.
        pictureWeap1.ImageLocation = Application.StartupPath & "\images\weaps\pistol" & cbWeap1.SelectedIndex.ToString & ".png"
        pictureWeap2.ImageLocation = Application.StartupPath & "\images\weaps\pistol" & cbWeap2.SelectedIndex.ToString & ".png"
        pictureWeap3.ImageLocation = Application.StartupPath & "\images\weaps\rifle" & cbWeap3.SelectedIndex.ToString & ".png"
        pictureClass.ImageLocation = Application.StartupPath & "\images\characters\" & cbClass.Text & ".jpg"

        'Si no hay ningun mod seleccionado, desactivamos el tab y el panel de modificacion de armas.
        TabControlMods.Enabled = False
        panelModificarArmas.Enabled = False
        checkHC.Enabled = False
        panelAmmo.Enabled = False
        panelLeftHand.Enabled = False
        panelRightHand.Enabled = False
        panelBothHands.Enabled = False



    End Sub

    Private Sub cbWeap1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWeap1.SelectedIndexChanged
        'Cambiamos la imagen del arma de mano izquierda para mostrar la imagen del arma seleccionada.
        pictureWeap1.ImageLocation = Application.StartupPath & "\images\weaps\pistol" & cbWeap1.SelectedIndex.ToString & ".png"

        ''Asignamos a la variable weap1 el nombre de arma que se utiliza en el archivo NetWeapon
        'If cbWeap1.SelectedIndex = 0 Then
        '    weap1 = """WeaponPistolCogswellNet"""
        'ElseIf cbWeap1.SelectedIndex = 1 Then
        '    weap1 = """WeaponPistolDerringerNet"""
        'ElseIf cbWeap1.SelectedIndex = 2 Then
        '    weap1 = """WeaponPistolLemantNet"""
        'ElseIf cbWeap1.SelectedIndex = 3 Then
        '    weap1 = """WeaponPistolPeacemakerNet"""
        'ElseIf cbWeap1.SelectedIndex = 4 Then
        '    weap1 = """WeaponRifleRemingtonSawOffNet"""
        'ElseIf cbWeap1.SelectedIndex = 5 Then
        '    weap1 = """WeaponPistolSchofieldNet"""
        'ElseIf cbWeap1.SelectedIndex = 6 Then
        '    weap1 = """WeaponPistolVolcanicNet"""
        'ElseIf cbWeap1.SelectedIndex = 7 Then
        '    weap1 = """WeaponPistolWalkerNet"""
        'ElseIf cbWeap1.SelectedIndex = 8 Then
        '    weap1 = ""
        'End If

        If cbWeap1.SelectedIndex = 8 Then
            pictureWeap1.BackColor = Color.Transparent
        Else
            If cbDefault.SelectedIndex = 1 Then
                pictureWeap1.BackColor = Color.SeaGreen
            End If
        End If

        CogeValorInis()

    End Sub

    Private Sub cbWeap2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWeap2.SelectedIndexChanged
        'Cambiamos la imagen del arma de mano derecha para mostrar la imagen del arma seleccionada.
        pictureWeap2.ImageLocation = Application.StartupPath & "\images\weaps\pistol" & cbWeap2.SelectedIndex.ToString & ".png"

        'Asignamos a la variable weap2 el nombre de arma que se utiliza en el archivo NetWeapon
        'If cbWeap2.SelectedIndex = 0 Then
        '    weap2 = """WeaponPistolCogswellNet"""
        'ElseIf cbWeap2.SelectedIndex = 1 Then
        '    weap2 = """WeaponPistolDerringerNet"""
        'ElseIf cbWeap2.SelectedIndex = 2 Then
        '    weap2 = """WeaponPistolLemantNet"""
        'ElseIf cbWeap2.SelectedIndex = 3 Then
        '    weap2 = """WeaponPistolPeacemakerNet"""
        'ElseIf cbWeap2.SelectedIndex = 4 Then
        '    weap2 = """WeaponRifleRemingtonSawOffNet"""
        'ElseIf cbWeap2.SelectedIndex = 5 Then
        '    weap2 = """WeaponPistolSchofieldNet"""
        'ElseIf cbWeap2.SelectedIndex = 6 Then
        '    weap2 = """WeaponPistolVolcanicNet"""
        'ElseIf cbWeap2.SelectedIndex = 7 Then
        '    weap2 = """WeaponPistolWalkerNet"""
        'ElseIf cbWeap2.SelectedIndex = 8 Then
        '    weap2 = ""
        'End If

        'Cambiamos el color del fondo dependiendo de las armas por defecto
        If cbWeap2.SelectedIndex = 8 Then
            pictureWeap2.BackColor = Color.Transparent
        Else

            If cbDefault.SelectedIndex = 1 Or cbDefault.SelectedIndex = 2 Then
                pictureWeap2.BackColor = Color.SeaGreen
            End If

        End If
        CogeValorInis()

    End Sub

    Private Sub cbWeap3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWeap3.SelectedIndexChanged
        'Cambiamos la imagen del arma de dos manos para mostrar la imagen del arma seleccionada.
        pictureWeap3.ImageLocation = Application.StartupPath & "\images\weaps\rifle" & cbWeap3.SelectedIndex.ToString & ".png"

        'Asignamos a la variable weap3 el nombre de arma que se utiliza en el archivo NetWeapon
        'If cbWeap3.SelectedIndex = 0 Then
        '    weap3 = """WeaponBowNet"""
        'ElseIf cbWeap3.SelectedIndex = 1 Then
        '    weap3 = """WeaponRifleRemingtonNet"""
        'ElseIf cbWeap3.SelectedIndex = 2 Then
        '    weap3 = """WeaponRifleSharpsNet"""
        'ElseIf cbWeap3.SelectedIndex = 3 Then
        '    weap3 = """WeaponRifleSharpsScopeNet"""
        'ElseIf cbWeap3.SelectedIndex = 4 Then
        '    weap3 = """WeaponRifleWinchesterNet"""
        'ElseIf cbWeap3.SelectedIndex = 5 Then
        '    weap3 = """WeaponRifleWinchesterScopeNet"""
        'ElseIf cbWeap3.SelectedIndex = 6 Then
        '    weap3 = ""
        'End If
        CogeValorInis()

    End Sub

    Private Sub checkWeap4_CheckedChanged(sender As Object, e As EventArgs) Handles checkWeap4.CheckedChanged
        If checkWeap4.Checked = True Then 'Si marcamos la casilla de TNT, activamos su combobox de cantidad y ponemos por defecto la cantidad de 2 TNTs.
            lblAmmo4.Enabled = True
            cbAmmo4.Enabled = True
            cbAmmo4.SelectedIndex = 1
            pictureWeap4.ImageLocation = Application.StartupPath & "\images\weaps\dynamite.png"

        Else 'Cuando desmarcamos el checkbox se desactiva el combobox y se pone el valor de 0.
            lblAmmo4.Enabled = False
            cbAmmo4.Enabled = False
            cbAmmo4.Text = 0
            pictureWeap4.ImageLocation = Application.StartupPath & "\images\weaps\nodynamite.png"
        End If
        CogeValorInis()



    End Sub

    Private Sub cbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClass.SelectedIndexChanged

        'Cambiamos el nombre del boton de armas por defecto
        btnDefault.Text = "Load default " & cbClass.Text & " weapons"

        'Cuando seleccionamos una clase, asigna un valor a las variables de los nombres de archivo.
        If cbClass.SelectedIndex = 0 Then
            clase = "_NetWeapon_Aristocrat_Properties.scr"

        ElseIf cbClass.SelectedIndex = 1 Then
            clase = "_NetWeapon_Bandit_Properties.scr"

        ElseIf cbClass.SelectedIndex = 2 Then
            clase = "_NetWeapon_Barnsby_Properties.scr"

        ElseIf cbClass.SelectedIndex = 3 Then
            clase = "_NetWeapon_Doc_Properties.scr"

        ElseIf cbClass.SelectedIndex = 4 Then
            clase = "_NetWeapon_Gunslinger_Properties.scr"

        ElseIf cbClass.SelectedIndex = 5 Then
            clase = "_NetWeapon_Gunsmith_Properties.scr"

        ElseIf cbClass.SelectedIndex = 6 Then
            clase = "_NetWeapon_Juarez_Properties.scr"

        ElseIf cbClass.SelectedIndex = 7 Then
            clase = "_NetWeapon_Miner_Properties.scr"

        ElseIf cbClass.SelectedIndex = 8 Then
            clase = "_NetWeapon_Rifleman_Properties.scr"

        ElseIf cbClass.SelectedIndex = 9 Then
            clase = "_NetWeapon_Sniper_Properties.scr"

        ElseIf cbClass.SelectedIndex = 10 Then
            clase = "_NetWeapon_Thief_Properties.scr"

        ElseIf cbClass.SelectedIndex = 11 Then
            clase = "_NetWeapon_Trapper_Properties.scr"

        ElseIf cbClass.SelectedIndex = 12 Then
            clase = "_NetWeapon_TribeWarrior_Properties.scr"

        End If

        'Mostramos la imagen del personaje seleccionado.
        pictureClass.ImageLocation = Application.StartupPath & "\images\characters\" & cbClass.Text & ".jpg"

        'Modificamos la label que muestra la clase que estamos creando.
        lblCreatingEditing.Text = "Creating class: " & cbClass.SelectedItem

    End Sub


    Private Sub cbDefault_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDefault.SelectedIndexChanged

        'Ajustamos los colores de fondo de las armas dependiendo de la seleccion de armas por defecto.
        If cbDefault.SelectedIndex = 0 Then
            pictureWeap1.BackColor = Color.Transparent
            pictureWeap2.BackColor = Color.Transparent
            pictureWeap3.BackColor = Color.SeaGreen
            pictureWeap4.BackColor = Color.Transparent
        ElseIf cbDefault.SelectedIndex = 1 Then
            If cbWeap1.SelectedIndex = 8 Then
                pictureWeap1.BackColor = Color.Transparent
            Else
                pictureWeap1.BackColor = Color.SeaGreen
            End If

            If cbWeap2.SelectedIndex = 8 Then
                pictureWeap2.BackColor = Color.Transparent
            Else
                pictureWeap2.BackColor = Color.SeaGreen
            End If

            pictureWeap3.BackColor = Color.Transparent
            pictureWeap4.BackColor = Color.Transparent
        ElseIf cbDefault.SelectedIndex = 2 Then
            pictureWeap1.BackColor = Color.Transparent
            pictureWeap2.BackColor = Color.SeaGreen
            pictureWeap3.BackColor = Color.Transparent
            pictureWeap4.BackColor = Color.SeaGreen
            checkWeap4.Checked = True
        End If
        CogeValorInis()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim restoreclass As Integer
        restoreclass = MessageBox.Show("WARNING! All classes in dedicated server are going to be restored like original game's classes. Do you want to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If restoreclass = vbYes Then
            checkHC.Checked = False
            If System.IO.Directory.Exists(ruta & rutaPlayer) Then
                My.Computer.FileSystem.DeleteDirectory(ruta & rutaPlayer, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

        End If


    End Sub


    Private Sub cbAmmo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbAmmo1.KeyPress, cbAmmo2.KeyPress, cbAmmo3.KeyPress, cbAmmo4.KeyPress, cbAmmo5.KeyPress, cbClass.KeyPress, cbWeap1.KeyPress, cbWeap2.KeyPress, cbWeap3.KeyPress, cbDefault.KeyPress
        e.KeyChar = "" 'Evitar que se escriba en los combobox
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        If cbClass.SelectedIndex = 0 Then 'Explorador
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 3
            cbWeap3.SelectedIndex = 5
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 0
        ElseIf cbClass.SelectedIndex = 1 Then 'Hombre
            cbWeap1.SelectedIndex = 4
            cbWeap2.SelectedIndex = 4
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 1
        ElseIf cbClass.SelectedIndex = 2 Then 'Veterano
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 8
            cbWeap3.SelectedIndex = 2
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 0
        ElseIf cbClass.SelectedIndex = 3 Then 'Duelista
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 6
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 1
        ElseIf cbClass.SelectedIndex = 4 Then 'Artillero
            cbWeap1.SelectedIndex = 5
            cbWeap2.SelectedIndex = 5
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = True
            cbAmmo4.SelectedIndex = 1
            cbDefault.SelectedIndex = 1
        ElseIf cbClass.SelectedIndex = 5 Then 'Armero
            cbWeap1.SelectedIndex = 2
            cbWeap2.SelectedIndex = 0
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 1
        ElseIf cbClass.SelectedIndex = 6 Then 'Oficial
            cbWeap1.SelectedIndex = 7
            cbWeap2.SelectedIndex = 7
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 1
        ElseIf cbClass.SelectedIndex = 7 Then 'Miner
            cbWeap1.SelectedIndex = 7
            cbWeap2.SelectedIndex = 4
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = True
            cbAmmo4.SelectedIndex = 4
            cbDefault.SelectedIndex = 2
        ElseIf cbClass.SelectedIndex = 8 Then 'Fusilero
            cbWeap1.SelectedIndex = 3
            cbWeap2.SelectedIndex = 3
            cbWeap3.SelectedIndex = 4
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 0
        ElseIf cbClass.SelectedIndex = 9 Then 'Tirador
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 7
            cbWeap3.SelectedIndex = 3
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 0
        ElseIf cbClass.SelectedIndex = 10 Then 'Spy
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 1
            cbWeap3.SelectedIndex = 6
            checkWeap4.Checked = True
            cbAmmo4.SelectedIndex = 2
            cbDefault.SelectedIndex = 2
        ElseIf cbClass.SelectedIndex = 11 Then 'Trampero
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 7
            cbWeap3.SelectedIndex = 1
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 0
        ElseIf cbClass.SelectedIndex = 12 Then 'Piel Roja
            cbWeap1.SelectedIndex = 8
            cbWeap2.SelectedIndex = 8
            cbWeap3.SelectedIndex = 0
            checkWeap4.Checked = False
            cbDefault.SelectedIndex = 0
        End If
    End Sub

    Private Sub checkHC_CheckedChanged(sender As Object, e As EventArgs) Handles checkHC.CheckedChanged

        If checkHC.Checked = True And estabaActivadoHC = 0 Then
            Dim HCmsgbox As Integer
            HCmsgbox = MessageBox.Show("All classes could die with only one shot in this gamemode. Do you want to continue?", "Hardcore Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If HCmsgbox = vbYes Then
                ModIniCabecera = "1"
            Else
                checkHC.Checked = False
            End If

        Else
            ModIniCabecera = "0"

        End If

    End Sub


    Private Sub frmArmas_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Comprobamos si está activado el HC mode
        If System.IO.File.Exists(ruta & rutaTemp & "WeaponsParams.scr") Then
            estabaActivadoHC = 1
            checkHC.Checked = True
            estabaActivadoHC = 0
        End If

        'Vaciamos la label de crear/editar
        lblCreatingEditing.Text = "Weapon Configuration Class: ..."


        pictureClass.ImageLocation = Application.StartupPath & "\images\fondo.jpg"


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmAcercade.Show()
    End Sub

    Private Sub lbNewChar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNewChar.SelectedIndexChanged
        Dim iniActual As String = ""

        If lbNewChar.SelectedItem = "Aristocrat" Then
            currentFile = "_NetWeapon_Aristocrat_Properties.scr"
            iniActual = ModIniAristocrat
        ElseIf lbNewChar.SelectedItem = "Bandit" Then
            currentFile = "_NetWeapon_Bandit_Properties.scr"
            iniActual = ModIniBandit
        ElseIf lbNewChar.SelectedItem = "Barnsby" Then
            currentFile = "_NetWeapon_Barnsby_Properties.scr"
            iniActual = ModIniBarnsby
        ElseIf lbNewChar.SelectedItem = "Doc" Then
            currentFile = "_NetWeapon_Doc_Properties.scr"
            iniActual = ModIniDoc
        ElseIf lbNewChar.SelectedItem = "Gunslinger" Then
            currentFile = "_NetWeapon_Gunslinger_Properties.scr"
            iniActual = ModIniGunslinger
        ElseIf lbNewChar.SelectedItem = "Gunsmith" Then
            currentFile = "_NetWeapon_Gunsmith_Properties.scr"
            iniActual = ModIniGunsmith
        ElseIf lbNewChar.SelectedItem = "Juarez" Then
            currentFile = "_NetWeapon_Juarez_Properties.scr"
            iniActual = ModIniJuarez
        ElseIf lbNewChar.SelectedItem = "Miner" Then
            currentFile = "_NetWeapon_Miner_Properties.scr"
            iniActual = ModIniMiner
        ElseIf lbNewChar.SelectedItem = "Rifleman" Then
            currentFile = "_NetWeapon_Rifleman_Properties.scr"
            iniActual = ModIniRifleman
        ElseIf lbNewChar.SelectedItem = "Sniper" Then
            currentFile = "_NetWeapon_Sniper_Properties.scr"
            iniActual = ModIniSniper
        ElseIf lbNewChar.SelectedItem = "Thief" Then
            currentFile = "_NetWeapon_Thief_Properties.scr"
            iniActual = ModIniThief
        ElseIf lbNewChar.SelectedItem = "Trapper" Then
            currentFile = "_NetWeapon_Trapper_Properties.scr"
            iniActual = ModIniTrapper
        ElseIf lbNewChar.SelectedItem = "Tribe Warrior" Then
            currentFile = "_NetWeapon_TribeWarrior_Properties.scr"
            iniActual = ModIniTribeWarrior
        End If

        If Len(iniActual) > 0 Then
            cbDefault.SelectedIndex = iniActual.Substring(0, 1)
            checkWeap4.Checked = iniActual.Substring(1, 1)
            cbWeap1.SelectedIndex = iniActual.Substring(2, 1)
            cbWeap2.SelectedIndex = iniActual.Substring(3, 1)
            cbWeap3.SelectedIndex = iniActual.Substring(4, 1)
            cbAmmo1.SelectedIndex = iniActual.Substring(5, 1)
            cbAmmo2.SelectedIndex = iniActual.Substring(6, 1)
            cbAmmo5.SelectedIndex = iniActual.Substring(7, 1)
            cbAmmo3.SelectedIndex = iniActual.Substring(8, 1)
            cbAmmo4.SelectedIndex = iniActual.Substring(9, 1)
        End If

        pictureClass.ImageLocation = Application.StartupPath & "\images\characters\" & lbNewChar.Text & ".jpg"

        'Modificamos la label que muestra la clase que se está editando
        lblCreatingEditing.Text = "Weapon Configuration Class: " & UCase(lbNewChar.SelectedItem)
    End Sub

    Private Sub btnSave_Click() Handles btnSave.Click 'sender As Object, e As EventArgs
        If modName = "" Then

            cancelModName = False
            frmModName.ShowDialog()

        End If

        If modName = "" Or cancelModName = True Then
            cancelModName = False
            Exit Sub
        End If

        If System.IO.Directory.Exists(rutaAppData & "\Mods\" & modName) And ModNameComprobacionGuardar <> modName Then

            Dim reemplazarMod As Integer
            reemplazarMod = MessageBox.Show("Existing Mod. Do you want to overwrite the gamemode " & modName.ToUpper & " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If reemplazarMod = vbYes Then

                If System.IO.Directory.Exists(rutaAppData & "\Mods\" & modName) Then
                    My.Computer.FileSystem.DeleteDirectory(rutaAppData & "\Mods\" & modName, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            Else
                If tabNewMod.Text <> "New Mod" Then
                    modName = tabNewMod.Text
                Else
                    modName = ""
                End If
                Exit Sub
            End If
        End If

        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Mods")
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Mods\" & modName)



        tabNewMod.Text = modName
        GuardarClases()
        RecargarMisMods()
        EscribeFicheroModIni()

        lbLoadMod.Text = modName

        ModNameComprobacionGuardar = modName


    End Sub

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click

        cancelModName = False
        frmModName.ShowDialog()

        If modName = "" Or cancelModName = True Then
            cancelModName = False
            Exit Sub
        End If

        If System.IO.Directory.Exists(rutaAppData & "\Mods\" & modName) Then

            Dim reemplazarMod As Integer
            reemplazarMod = MessageBox.Show("Existing Mod. Do you want to overwrite the gamemode " & modName.ToUpper & " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If reemplazarMod = vbYes Then

                If System.IO.Directory.Exists(rutaAppData & "\Mods\" & modName) Then
                    My.Computer.FileSystem.DeleteDirectory(rutaAppData & "\Mods\" & modName, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            Else
                If tabNewMod.Text <> "New Mod" Then
                    modName = tabNewMod.Text
                Else
                    modName = ""
                End If

                Exit Sub
            End If
        End If

        modName = frmModName.txtModName.Text
        tabNewMod.Text = modName
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Mods")
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Mods\" & modName)


        GuardarClases()
        EscribeFicheroModIni()
        RecargarMisMods()

        lbLoadMod.Text = modName

    End Sub

    Private Sub btnDeleteMod_Click(sender As Object, e As EventArgs) Handles btnDeleteMod.Click

        frmDeleteMods.ShowDialog()

        RecargarMisMods()

        'Si no hay ningun mod seleccionado, desactivamos el tab y el panel de modificacion de armas.
        If lbLoadMod.SelectedItem = "" Then
            TabControlMods.Enabled = False
            panelModificarArmas.Enabled = False
            checkHC.Enabled = False
            btnLookMod.Text = "Look Mod ..."
            panelAmmo.Enabled = False
            panelLeftHand.Enabled = False
            panelRightHand.Enabled = False
            panelBothHands.Enabled = False
        Else
            TabControlMods.Enabled = True
            panelModificarArmas.Enabled = True
            checkHC.Enabled = True
            panelAmmo.Enabled = True
            panelLeftHand.Enabled = True
            panelRightHand.Enabled = True
            panelBothHands.Enabled = True
        End If
    End Sub


    Private Sub lbLoadMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLoadMod.SelectedIndexChanged

        lbNewChar.Items.Clear()

        If System.IO.Directory.Exists(ruta & rutaTemp) Then
            My.Computer.FileSystem.DeleteDirectory(ruta & rutaTemp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        If System.IO.Directory.Exists(rutaAppData & "\mods\" & lbLoadMod.SelectedItem & "\") Then
            My.Computer.FileSystem.CopyDirectory(rutaAppData & "\mods\" & lbLoadMod.SelectedItem & "\", ruta & "\temp")
            OcultarCarpeta(ruta & rutaTemp)
        End If


        For Each foundFile As String In My.Computer.FileSystem.GetFiles(rutaAppData & "\mods\" & lbLoadMod.SelectedItem & "\")

            Dim lengthRuta As Integer = foundFile.Length
            Dim FirstCharacter As Integer = foundFile.IndexOf("_NetWeapon")
            Dim nameFile As String = foundFile.Substring(FirstCharacter).ToString()

            ObtenerNombreClase(nameFile)
            lbNewChar.Items.Add(nombreClaseObtenido)

        Next

        TabControlMods.SelectedTab = tabNewMod
        tabNewMod.Text = lbLoadMod.SelectedItem
        modName = lbLoadMod.SelectedItem

        If lbNewChar.Items.Count = 0 Then
            btnSetMod.Enabled = False
        Else
            btnSetMod.Enabled = True
        End If

        LeeFicheroModIni()


        If ModIniCabecera = "1" Then
            estabaActivadoHC = 1
            checkHC.Checked = True
            estabaActivadoHC = 0
        Else
            checkHC.Checked = False
        End If

        'Si no hay ningun mod seleccionado, desactivamos el tab y el panel de modificacion de armas.
        If lbLoadMod.SelectedItem = "" Then
            TabControlMods.Enabled = False
            panelModificarArmas.Enabled = False
            checkHC.Enabled = False
            panelAmmo.Enabled = False
            panelLeftHand.Enabled = False
            panelRightHand.Enabled = False
            panelBothHands.Enabled = False
        Else
            TabControlMods.Enabled = True
            panelModificarArmas.Enabled = True
            checkHC.Enabled = True
            panelAmmo.Enabled = True
            panelLeftHand.Enabled = True
            panelRightHand.Enabled = True
            panelBothHands.Enabled = True
        End If

        'Cambiamos el nombre al boton que abre el formulario de la tabla.
        If modName <> "" Then
            btnLookMod.Text = "Look Mod " & UCase(modName)
        Else
            btnLookMod.Text = "Look Mod ..."
        End If

        'Seleccionamos la primera clase de listbox de clases.
        lbNewChar.SelectedIndex = 0

        ModNameComprobacionGuardar = lbLoadMod.Text

    End Sub

    Private Sub btnSetMod_Click(sender As Object, e As EventArgs) Handles btnSetMod.Click


        'Comprobamos que la ruta especificada es correcta y es de un servidor dedicado.
        If System.IO.File.Exists(ruta & "\CoJ2Game_x86_ds.exe") And System.IO.File.Exists(ruta & "\CoJ2_x86_ds.dll") Then

            Dim myProcesses() As Process
            Dim myProcess As Process
            myProcesses = Process.GetProcesses()
            ' Iterate through the process array.
            For Each myProcess In myProcesses
                '  Console.WriteLine(myProcess.ProcessName)
                If myProcess.ProcessName = "CoJ2Game_x86_ds" Then

                    MessageBox.Show("You must close CoJ2 Dedicated Server before you make some changes. Close the server and try again. The mod has not been set.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next

            Dim msgActiveMod As Integer
            msgActiveMod = MessageBox.Show("Your current server game mod will be changed for this one. Do you want to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If msgActiveMod = vbYes Then

                If System.IO.Directory.Exists(ruta & rutaPlayer) Then
                    My.Computer.FileSystem.DeleteDirectory(ruta & rutaPlayer, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If

                If System.IO.Directory.Exists(ruta & rutaTemp) Then
                    My.Computer.FileSystem.CopyDirectory(ruta & rutaTemp, ruta & rutaPlayer)
                End If

            End If


            If System.IO.File.Exists(ruta & rutaPlayer & "WeaponsParams.scr") And estabaActivadoHC = 0 Then
                My.Computer.FileSystem.DeleteFile(ruta & rutaPlayer & "WeaponsParams.scr")
            End If

            If checkHC.Checked = True Then

                DecryptFile(Application.StartupPath & "\bin\modscoj.dll", ruta & rutaPlayer & "WeaponsParams.scr", sSecretKey)

            Else
                If My.Computer.FileSystem.FileExists(ruta & rutaPlayer & "WeaponsParams.scr") Then
                    My.Computer.FileSystem.DeleteFile(ruta & rutaPlayer & "WeaponsParams.scr")
                End If

            End If


        Else

                'Solicitamos la ruta de la carpeta del juego / servidor
            MessageBox.Show("You have to choose the same path where CoJ Dedicated Server was installed.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dialRuta.ShowDialog()
                ruta = dialRuta.SelectedPath()

                'Si la ruta especificada durante la creacion de las clases es correcta, la añadimos al archivo .ini
                If System.IO.File.Exists(ruta & "\CoJ2Game_x86_ds.exe") And System.IO.File.Exists(ruta & "\CoJ2_x86_ds.dll") Then
                    writeini = File.AppendText(Application.StartupPath & "\cojmods.ini")
                    writeini.WriteLine(ruta)
                    writeini.Close()
                End If
        End If

    End Sub


    'Rutina para que tomen valor los inis cada vez que cambiamos un list box (armas, ammo, class)
    Private Sub CogeValorInis()
        Dim IndexSelecEnCbammo4 As String = ""
        If checkWeap4.Checked = True Then
            IndexSelecEnCbammo4 = cbAmmo4.SelectedIndex.ToString
            TntSiNo = 1
        Else
            IndexSelecEnCbammo4 = 0
            TntSiNo = 0
        End If

        If lbNewChar.Text = "Aristocrat" Then
            ModIniAristocrat = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Bandit" Then
            ModIniBandit = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Barnsby" Then
            ModIniBarnsby = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Doc" Then
            ModIniDoc = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Gunslinger" Then
            ModIniGunslinger = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Gunsmith" Then
            ModIniGunsmith = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Juarez" Then
            ModIniJuarez = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Miner" Then
            ModIniMiner = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Rifleman" Then
            ModIniRifleman = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Sniper" Then
            ModIniSniper = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Thief" Then
            ModIniThief = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Trapper" Then
            ModIniTrapper = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        ElseIf lbNewChar.Text = "Tribe Warrior" Then
            ModIniTribeWarrior = cbDefault.SelectedIndex.ToString & TntSiNo & cbWeap1.SelectedIndex.ToString & cbWeap2.SelectedIndex.ToString & cbWeap3.SelectedIndex.ToString & cbAmmo1.SelectedIndex.ToString & cbAmmo2.SelectedIndex.ToString & cbAmmo5.SelectedIndex.ToString & cbAmmo3.SelectedIndex.ToString & IndexSelecEnCbammo4
        End If
    End Sub

    Private Sub cbAmmo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmmo1.SelectedIndexChanged
        CogeValorInis()
    End Sub

    Private Sub cbAmmo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmmo2.SelectedIndexChanged
        CogeValorInis()
    End Sub

    Private Sub cbAmmo5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmmo5.SelectedIndexChanged
        CogeValorInis()
    End Sub

    Private Sub cbAmmo3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmmo3.SelectedIndexChanged
        CogeValorInis()
    End Sub

    Private Sub cbAmmo4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmmo4.SelectedIndexChanged
        CogeValorInis()
    End Sub

    Private Sub btnLookMod_Click(sender As Object, e As EventArgs) Handles btnLookMod.Click
        frmTablaConfig.Show()
    End Sub

    Private Sub btnNewMod_Click(sender As Object, e As EventArgs) Handles btnNewMod.Click
        lbNewChar.Items.Clear()
        TabControlMods.SelectedTab = tabNewMod
        btnSetMod.Enabled = False
        modName = ""
        tabNewMod.Text = "New Mod"
        checkHC.Checked = False
        'Todas estas variables cogen los valores de las armas por defecto.
        ModIniAristocrat = "0083513030"
        ModIniBandit = "1044613030"
        ModIniBarnsby = "0088213030"
        ModIniCabecera = "0"
        ModIniDoc = "1086613030"
        ModIniGunslinger = "1155613031"
        ModIniGunsmith = "1020613030"
        ModIniJuarez = "1077613030"
        ModIniMiner = "2174613034"
        ModIniRifleman = "0033413030"
        ModIniSniper = "0087313030"
        ModIniThief = "2181613032"
        ModIniTrapper = "0087113030"
        ModIniTribeWarrior = "0088013030"

        lbNewChar.Items.Add("Aristocrat")
        lbNewChar.Items.Add("Bandit")
        lbNewChar.Items.Add("Barnsby")
        lbNewChar.Items.Add("Doc")
        lbNewChar.Items.Add("Gunslinger")
        lbNewChar.Items.Add("Gunsmith")
        lbNewChar.Items.Add("Juarez")
        lbNewChar.Items.Add("Miner")
        lbNewChar.Items.Add("Rifleman")
        lbNewChar.Items.Add("Sniper")
        lbNewChar.Items.Add("Thief")
        lbNewChar.Items.Add("Trapper")
        lbNewChar.Items.Add("Tribe Warrior")

        TabControlMods.Enabled = True
        panelModificarArmas.Enabled = True
        checkHC.Enabled = True
        panelAmmo.Enabled = True
        panelLeftHand.Enabled = True
        panelRightHand.Enabled = True
        panelBothHands.Enabled = True
        lbLoadMod.Text = ""
        btnLookMod.Text = "Look Mod ..."

        'Seleccionamos la primera clase de listbox de clases.
        lbNewChar.SelectedIndex = 0

        ModNameComprobacionGuardar = ""


    End Sub

    Sub GuardarClases()

        'Comprobamos que la ruta especificada es correcta y es de un servidor dedicado.
        If System.IO.File.Exists(ruta & "\CoJ2Game_x86_ds.exe") And System.IO.File.Exists(ruta & "\CoJ2_x86_ds.dll") Then


            Dim WeaponLeft As String = ""
            Dim WeaponRight As String = ""
            Dim WeaponBoth As String = ""
            Dim AmmoPistol As String = ""
            Dim AmmoRifle As String = ""
            Dim AmmoShotgun As String = ""
            Dim AmmoArrows As String = ""
            Dim AmmoTNT As Integer = 0
            Dim TieneTNT As String = ""
            Dim PredeterminadaRight As String = ""
            Dim PredeterminadaLeft As String = ""

            'Antes de llamar a GuardarClases() debe estar creada la carpeta destino del mod



            For i = 1 To 13

                Dim ModIniALeer As String = ""

                If i = 1 And lbNewChar.Items.Contains("Aristocrat") Then
                    clase = "Aristocrat"
                    ModIniALeer = ModIniAristocrat
                End If
                If i = 2 And lbNewChar.Items.Contains("Bandit") Then
                    clase = "Bandit"
                    ModIniALeer = ModIniBandit
                End If
                If i = 3 And lbNewChar.Items.Contains("Barnsby") Then
                    clase = "Barnsby"
                    ModIniALeer = ModIniBarnsby
                End If
                If i = 4 And lbNewChar.Items.Contains("Doc") Then
                    clase = "Doc"
                    ModIniALeer = ModIniDoc
                End If
                If i = 5 And lbNewChar.Items.Contains("Gunslinger") Then
                    clase = "Gunslinger"
                    ModIniALeer = ModIniGunslinger
                End If
                If i = 6 And lbNewChar.Items.Contains("Gunsmith") Then
                    clase = "Gunsmith"
                    ModIniALeer = ModIniGunsmith
                End If
                If i = 7 And lbNewChar.Items.Contains("Juarez") Then
                    clase = "Juarez"
                    ModIniALeer = ModIniJuarez
                End If
                If i = 8 And lbNewChar.Items.Contains("Miner") Then
                    clase = "Miner"
                    ModIniALeer = ModIniMiner
                End If
                If i = 9 And lbNewChar.Items.Contains("Rifleman") Then
                    clase = "Rifleman"
                    ModIniALeer = ModIniRifleman
                End If
                If i = 10 And lbNewChar.Items.Contains("Sniper") Then
                    clase = "Sniper"
                    ModIniALeer = ModIniSniper
                End If
                If i = 11 And lbNewChar.Items.Contains("Thief") Then
                    clase = "Thief"
                    ModIniALeer = ModIniThief
                End If
                If i = 12 And lbNewChar.Items.Contains("Trapper") Then
                    clase = "Trapper"
                    ModIniALeer = ModIniTrapper
                End If
                If i = 13 And lbNewChar.Items.Contains("Tribe Warrior") Then
                    clase = "TribeWarrior"
                    ModIniALeer = ModIniTribeWarrior
                End If

                If ModIniALeer <> "" Then

                    'Borramos el archivo NetWeapon de la clase seleccionada, si existe.
                    If System.IO.File.Exists(rutaAppData & "\Mods\" & modName & "\_NetWeapon_" & clase & "_Properties.scr") Then
                        My.Computer.FileSystem.DeleteFile(rutaAppData & "\Mods\" & modName & "\_NetWeapon_" & clase & "_Properties.scr")
                    End If

                    'Abrimos el archivo de la clase seleccionada para modificarlo.
                    write = File.AppendText(rutaAppData & "\Mods\" & modName & "\_NetWeapon_" & clase & "_Properties.scr")
                    write.WriteLine("!NetAmmo(s, i)")
                    write.WriteLine("!NetWeapon(s)")
                    write.WriteLine("!NetDefaultWeaponL(s)")
                    write.WriteLine("!NetDefaultWeaponR(s)")

                    'Sacamos del modini el arma de la mano izquierda, que está en la tercera posición de la cadena.
                    If ModIniALeer.Substring(2, 1) = 0 Then
                        WeaponLeft = """WeaponPistolCogswellNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 1 Then
                        WeaponLeft = """WeaponPistolDerringerNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 2 Then
                        WeaponLeft = """WeaponPistolLemantNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 3 Then
                        WeaponLeft = """WeaponPistolPeacemakerNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 4 Then
                        WeaponLeft = """WeaponRifleRemingtonSawOffNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 5 Then
                        WeaponLeft = """WeaponPistolSchofieldNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 6 Then
                        WeaponLeft = """WeaponPistolVolcanicNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 7 Then
                        WeaponLeft = """WeaponPistolWalkerNet"""
                    ElseIf ModIniALeer.Substring(2, 1) = 8 Then
                        WeaponLeft = ""
                    End If

                    'Sacamos del modini el arma de la mano derecha, que está en la cuarta posición de la cadena.
                    If ModIniALeer.Substring(3, 1) = 0 Then
                        WeaponRight = """WeaponPistolCogswellNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 1 Then
                        WeaponRight = """WeaponPistolDerringerNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 2 Then
                        WeaponRight = """WeaponPistolLemantNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 3 Then
                        WeaponRight = """WeaponPistolPeacemakerNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 4 Then
                        WeaponRight = """WeaponRifleRemingtonSawOffNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 5 Then
                        WeaponRight = """WeaponPistolSchofieldNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 6 Then
                        WeaponRight = """WeaponPistolVolcanicNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 7 Then
                        WeaponRight = """WeaponPistolWalkerNet"""
                    ElseIf ModIniALeer.Substring(3, 1) = 8 Then
                        WeaponRight = ""
                    End If

                    'Sacamos del modini el arma de dos manos, que está en la quinta posición de la cadena.
                    If ModIniALeer.Substring(4, 1) = 0 Then
                        WeaponBoth = """WeaponBowNet"""
                    ElseIf ModIniALeer.Substring(4, 1) = 1 Then
                        WeaponBoth = """WeaponRifleRemingtonNet"""
                    ElseIf ModIniALeer.Substring(4, 1) = 2 Then
                        WeaponBoth = """WeaponRifleSharpsNet"""
                    ElseIf ModIniALeer.Substring(4, 1) = 3 Then
                        WeaponBoth = """WeaponRifleSharpsScopeNet"""
                    ElseIf ModIniALeer.Substring(4, 1) = 4 Then
                        WeaponBoth = """WeaponRifleWinchesterNet"""
                    ElseIf ModIniALeer.Substring(4, 1) = 5 Then
                        WeaponBoth = """WeaponRifleWinchesterScopeNet"""
                    ElseIf ModIniALeer.Substring(4, 1) = 6 Then
                        WeaponBoth = ""
                    End If

                    'Sacamos del modini la munición de pistola, de la sexta posición.
                    If ModIniALeer.Substring(5, 1) = 0 Then
                        AmmoPistol = 35
                    ElseIf ModIniALeer.Substring(5, 1) = 1 Then
                        AmmoPistol = 45
                    ElseIf ModIniALeer.Substring(5, 1) = 2 Then
                        AmmoPistol = 55
                    ElseIf ModIniALeer.Substring(5, 1) = 3 Then
                        AmmoPistol = 65
                    ElseIf ModIniALeer.Substring(5, 1) = 4 Then
                        AmmoPistol = 75
                    ElseIf ModIniALeer.Substring(5, 1) = 5 Then
                        AmmoPistol = 95
                    ElseIf ModIniALeer.Substring(5, 1) = 6 Then
                        AmmoPistol = 140
                    ElseIf ModIniALeer.Substring(5, 1) = 7 Then
                        AmmoPistol = 190
                    End If

                    'Sacamos del modini la munición de rifle, de la séptima posición.
                    If ModIniALeer.Substring(6, 1) = 0 Then
                        AmmoRifle = 35
                    ElseIf ModIniALeer.Substring(6, 1) = 1 Then
                        AmmoRifle = 45
                    ElseIf ModIniALeer.Substring(6, 1) = 2 Then
                        AmmoRifle = 55
                    ElseIf ModIniALeer.Substring(6, 1) = 3 Then
                        AmmoRifle = 65
                    ElseIf ModIniALeer.Substring(6, 1) = 4 Then
                        AmmoRifle = 75
                    ElseIf ModIniALeer.Substring(6, 1) = 5 Then
                        AmmoRifle = 95
                    ElseIf ModIniALeer.Substring(6, 1) = 6 Then
                        AmmoRifle = 140
                    ElseIf ModIniALeer.Substring(6, 1) = 7 Then
                        AmmoRifle = 190
                    End If

                    'Sacamos del modini la munición de shotgun, de la octava posición.
                    If ModIniALeer.Substring(7, 1) = 0 Then
                        AmmoShotgun = 35
                    ElseIf ModIniALeer.Substring(7, 1) = 1 Then
                        AmmoShotgun = 45
                    ElseIf ModIniALeer.Substring(7, 1) = 2 Then
                        AmmoShotgun = 55
                    ElseIf ModIniALeer.Substring(7, 1) = 3 Then
                        AmmoShotgun = 65
                    ElseIf ModIniALeer.Substring(7, 1) = 4 Then
                        AmmoShotgun = 75
                    ElseIf ModIniALeer.Substring(7, 1) = 5 Then
                        AmmoShotgun = 95
                    ElseIf ModIniALeer.Substring(7, 1) = 6 Then
                        AmmoShotgun = 140
                    ElseIf ModIniALeer.Substring(7, 1) = 7 Then
                        AmmoShotgun = 190
                    End If

                    'Sacamos del modini la munición de arrows, de la novena posición.
                    If ModIniALeer.Substring(8, 1) = 0 Then
                        AmmoArrows = 35
                    ElseIf ModIniALeer.Substring(8, 1) = 1 Then
                        AmmoArrows = 45
                    ElseIf ModIniALeer.Substring(8, 1) = 2 Then
                        AmmoArrows = 55
                    ElseIf ModIniALeer.Substring(8, 1) = 3 Then
                        AmmoArrows = 65
                    ElseIf ModIniALeer.Substring(8, 1) = 4 Then
                        AmmoArrows = 75
                    ElseIf ModIniALeer.Substring(8, 1) = 5 Then
                        AmmoArrows = 95
                    ElseIf ModIniALeer.Substring(8, 1) = 6 Then
                        AmmoArrows = 140
                    ElseIf ModIniALeer.Substring(8, 1) = 7 Then
                        AmmoArrows = 190
                    End If

                    'Sacamos del modini si se utilizarán tnt o no, de la segunda posición.
                    If ModIniALeer.Substring(1, 1) = 0 Then
                        TieneTNT = 0
                    Else
                        TieneTNT = 1
                    End If

                    'Sacamos del modini la cantidad de tnt, de la décima posición.
                    If ModIniALeer.Substring(9, 1) = 0 Then
                        AmmoTNT = 1
                    ElseIf ModIniALeer.Substring(9, 1) = 1 Then
                        AmmoTNT = 2
                    ElseIf ModIniALeer.Substring(9, 1) = 2 Then
                        AmmoTNT = 3
                    ElseIf ModIniALeer.Substring(9, 1) = 3 Then
                        AmmoTNT = 4
                    ElseIf ModIniALeer.Substring(9, 1) = 4 Then
                        AmmoTNT = 5
                    End If

                    'Sacamos las armas predeterminadas del modini, primera posición.
                    If ModIniALeer.Substring(0, 1) = 0 Then 'Arma de dos manos
                        PredeterminadaLeft = ""
                        PredeterminadaRight = WeaponBoth
                    ElseIf ModIniALeer.Substring(0, 1) = 1 Then 'Dos pistolas
                        PredeterminadaLeft = WeaponLeft
                        PredeterminadaRight = WeaponRight
                    ElseIf ModIniALeer.Substring(0, 1) = 2 Then 'PistolaR + TNT
                        PredeterminadaLeft = """WeaponDynamiteStickNet"""
                        PredeterminadaRight = WeaponRight
                    End If

                    'Escritura de todas las armas y municiones en el archivo NetWeapon
                    If WeaponLeft <> "" Then write.WriteLine("NetWeapon(" & WeaponLeft & ")")
                    If WeaponRight <> "" Then write.WriteLine("NetWeapon(" & WeaponRight & ")")
                    If WeaponBoth <> "" Then write.WriteLine("NetWeapon(" & WeaponBoth & ")")
                    If TieneTNT = 1 Then
                        For n = 1 To AmmoTNT
                            write.WriteLine("NetWeapon(""WeaponDynamiteStickNet"")")
                        Next
                    End If
                    write.WriteLine("NetAmmo(""AmmoPistol"", " & AmmoPistol & ")")
                    write.WriteLine("NetAmmo(""AmmoRifle"", " & AmmoRifle & ")")
                    write.WriteLine("NetAmmo(""AmmoShotgun"", " & AmmoShotgun & ")")
                    write.WriteLine("NetAmmo(""AmmoArrows"", " & AmmoArrows & ")")

                    If PredeterminadaLeft <> "" Then write.WriteLine("NetDefaultWeaponL(" & PredeterminadaLeft & ")")
                    If PredeterminadaRight <> "" Then write.WriteLine("NetDefaultWeaponR(" & PredeterminadaRight & ")")

                    write.Close() 'Terminamos la escritura del archivo NetWeapon y lo CERRAMOS.

                End If
            Next

        End If


    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Cursor = Cursors.WaitCursor
        Help.ShowHelp(Me, Application.StartupPath & "\CoJ Mods.chm")
        Cursor = Cursors.Default
    End Sub


End Class
