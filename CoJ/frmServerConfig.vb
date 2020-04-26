' =================================================================================
' frmServerConfig.vb - Server config form
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

Public Class frmServerConfig

    Dim serverConfig As String
    Dim gameModeConfig As String
    Dim mapConfig As String
    Dim modeConfig As String
    Dim adminsUserConfig As String
    Dim adminPassConfig As String
    Dim adminLevelConfig As String
    Dim leyendoConfig As Boolean = False
    Dim writer As StreamWriter
    Dim reader As StreamReader

    Private Sub frmServerConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMain.Show()
        Me.Dispose()
    End Sub

    Private Sub cbInternetLan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbInternetLan.KeyPress
        e.KeyChar = ""
    End Sub


    Private Sub txtServerPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServerPort.KeyPress, txtPlayersToStart.KeyPress, txtBountyDM.KeyPress, txtPointsManhunt.KeyPress, txtBountyPosse.KeyPress, txtBountyWanted.KeyPress, txtTimeDM.KeyPress, txtTimeManhunt.KeyPress, txtTimePosse.KeyPress, txtTimeWanted.KeyPress
        If IsNumeric(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnAddTechlandMap_Click(sender As Object, e As EventArgs) Handles btnTechlandAdd.Click, lbTechlandMaps.DoubleClick
        If lbTechlandMaps.SelectedItem <> "" Then
            dgTechlandSelMaps.Rows.Add()

            dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(0).Value = lbTechlandMaps.SelectedItem

            dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(1).Value = cbTechlandGameMode.SelectedItem

            If cbTechlandGameMode.SelectedItem = "WWL" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(3).Value = "historical"
            ElseIf cbTechlandGameMode.SelectedItem = "Posse" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(3).Value = "teamdeathmatch"
            ElseIf cbTechlandGameMode.SelectedItem = "Manhunt" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(3).Value = "teamwanted"
            Else
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(3).Value = LCase(cbTechlandGameMode.SelectedItem)

            End If

            'MsgBox(dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(3).Value)

            If lbTechlandMaps.SelectedItem = "Taos Pueblo" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(2).Value = "Adobes"
            ElseIf lbTechlandMaps.SelectedItem = "Burnside's Bridge" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(2).Value = "Civil"
            ElseIf lbTechlandMaps.SelectedItem = "Nogales" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(2).Value = "PrisonBreak2"
            ElseIf lbTechlandMaps.SelectedItem = "Stinking Springs" Then
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(2).Value = "StinkingSprings2"
            Else
                dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(2).Value = lbTechlandMaps.SelectedItem
            End If

            dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Selected = True
            dgTechlandSelMaps.CurrentCell = dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(0)
        End If
    End Sub

    Private Sub btnTechlandSubir_Click(sender As Object, e As EventArgs) Handles btnTechlandSubir.Click

        If dgTechlandSelMaps.CurrentRow.Index = 0 Then Exit Sub

        Dim ArFilaEnMovimiento(3) As String
        Dim ArFilaASustituir(3) As String

        ArFilaEnMovimiento(0) = dgTechlandSelMaps.CurrentRow.Cells(0).Value
        ArFilaEnMovimiento(1) = dgTechlandSelMaps.CurrentRow.Cells(1).Value
        ArFilaEnMovimiento(2) = dgTechlandSelMaps.CurrentRow.Cells(2).Value
        ArFilaEnMovimiento(3) = dgTechlandSelMaps.CurrentRow.Cells(3).Value

        ArFilaASustituir(0) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(0).Value
        ArFilaASustituir(1) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(1).Value
        ArFilaASustituir(2) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(2).Value
        ArFilaASustituir(3) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(3).Value

        dgTechlandSelMaps.CurrentRow.Cells(0).Value = ArFilaASustituir(0)
        dgTechlandSelMaps.CurrentRow.Cells(1).Value = ArFilaASustituir(1)
        dgTechlandSelMaps.CurrentRow.Cells(2).Value = ArFilaASustituir(2)
        dgTechlandSelMaps.CurrentRow.Cells(3).Value = ArFilaASustituir(3)

        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(0).Value = ArFilaEnMovimiento(0)
        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(1).Value = ArFilaEnMovimiento(1)
        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(2).Value = ArFilaEnMovimiento(2)
        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(3).Value = ArFilaEnMovimiento(3)

        dgTechlandSelMaps.CurrentCell = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index - 1).Cells(0)
        dgTechlandSelMaps.CurrentRow.Selected = True

    End Sub

    Private Sub btnTechlandBajar_Click(sender As Object, e As EventArgs) Handles btnTechlandBajar.Click
        If dgTechlandSelMaps.CurrentRow.Index = dgTechlandSelMaps.Rows.Count - 1 Then Exit Sub

        Dim ArFilaEnMovimiento(3) As String
        Dim ArFilaASustituir(3) As String

        ArFilaEnMovimiento(0) = dgTechlandSelMaps.CurrentRow.Cells(0).Value
        ArFilaEnMovimiento(1) = dgTechlandSelMaps.CurrentRow.Cells(1).Value
        ArFilaEnMovimiento(2) = dgTechlandSelMaps.CurrentRow.Cells(2).Value
        ArFilaEnMovimiento(3) = dgTechlandSelMaps.CurrentRow.Cells(3).Value

        ArFilaASustituir(0) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(0).Value
        ArFilaASustituir(1) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(1).Value
        ArFilaASustituir(2) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(2).Value
        ArFilaASustituir(3) = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(3).Value

        dgTechlandSelMaps.CurrentRow.Cells(0).Value = ArFilaASustituir(0)
        dgTechlandSelMaps.CurrentRow.Cells(1).Value = ArFilaASustituir(1)
        dgTechlandSelMaps.CurrentRow.Cells(2).Value = ArFilaASustituir(2)
        dgTechlandSelMaps.CurrentRow.Cells(3).Value = ArFilaASustituir(3)

        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(0).Value = ArFilaEnMovimiento(0)
        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(1).Value = ArFilaEnMovimiento(1)
        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(2).Value = ArFilaEnMovimiento(2)
        dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(3).Value = ArFilaEnMovimiento(3)

        dgTechlandSelMaps.CurrentCell = dgTechlandSelMaps.Rows(dgTechlandSelMaps.CurrentRow.Index + 1).Cells(0)
        dgTechlandSelMaps.CurrentRow.Selected = True
    End Sub




    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        If txtServerName.Text.Trim = "" Or txtServerPassword.Text.Trim = "" Or txtServerPort.Text.Trim = "" Or txtPublicSlots.Text.Trim = "" Or txtPlayersToStart.Text.Trim = "" Then
            If txtPlayersToStart.Text.Trim = "" Then
                txtPlayersToStart.Focus()
                txtPlayersToStart.BackColor = Color.LemonChiffon
            End If
            If txtPublicSlots.Text.Trim = "" Then
                txtPublicSlots.Focus()
                txtPublicSlots.BackColor = Color.LemonChiffon
            End If
            If txtServerPort.Text.Trim = "" Then
                txtServerPort.Focus()
                txtServerPort.BackColor = Color.LemonChiffon
            End If
            If txtServerPassword.Text.Trim = "" Then
                txtServerPassword.Focus()
                txtServerPassword.BackColor = Color.LemonChiffon
            End If
            If txtServerName.Text.Trim = "" Then
                txtServerName.Focus()
                txtServerName.BackColor = Color.LemonChiffon
            End If
            MessageBox.Show("It is neccesary to fill some fields more", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If tabMaps.SelectedTab Is tabTechlandMaps Then

            If dgTechlandSelMaps.Rows.Count <= 0 Then
                MessageBox.Show("There are no Techland Maps added to the server, you should add one at least", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        ElseIf tabMaps.SelectedTab Is tabCustomMaps Then

            If dgCustomSelMaps.Rows.Count <= 0 Then
                MessageBox.Show("There are no custom Maps added to the server, you should add one at least", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If


        If MessageBox.Show("Dedicated Server will be set with " & tabMaps.SelectedTab.Text & "." + Chr(13) + Chr(10) + "Do you want to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = vbNo Then
            Exit Sub
        End If

        mapConfig = ""
        modeConfig = ""
        serverConfig = txtServerName.Text & ";;" & txtServerPassword.Text & ";;" & txtServerPort.Text & ";;" & cbInternetLan.SelectedItem & ";;" & txtPublicSlots.Text & ";;" & txtPlayersToStart.Text & ";;" & checkFF.Checked & ";;"
        gameModeConfig = Trim(Str(Val(txtBountyDM.Text))) & ";;" & Trim(Str(Val(txtTimeDM.Text) * 60)) & ";;" & Trim(Str(Val(txtBountyPosse.Text))) & ";;" & Trim(Str(Val(txtTimePosse.Text) * 60)) & ";;" & Trim(Str(Val(txtPointsManhunt.Text))) & ";;" & Trim(Str(Val(txtTimeManhunt.Text) * 60)) & ";;" & Trim(Str(Val(txtBountyWanted.Text))) & ";;" & Trim(Str(Val(txtTimeWanted.Text) * 60)) & ";;"
        ' MsgBox(serverConfig)
        ' MsgBox(gameModeConfig)

        If tabMaps.SelectedTab Is tabTechlandMaps Then
            mapConfig = "techland;;"
            For i = 0 To dgTechlandSelMaps.Rows.Count - 1

                mapConfig = mapConfig & dgTechlandSelMaps.Rows(i).Cells(2).Value.ToString.Trim & ";;"
                modeConfig = modeConfig & dgTechlandSelMaps.Rows(i).Cells(3).Value.ToString.Trim & ";;"
            Next


        ElseIf tabMaps.SelectedTab Is tabCustomMaps Then
            mapConfig = "custom;;"
            For i = 0 To dgCustomSelMaps.Rows.Count - 1

                mapConfig = mapConfig & dgCustomSelMaps.Rows(i).Cells(0).Value.ToString.Trim & ";;"
                modeConfig = modeConfig & dgCustomSelMaps.Rows(i).Cells(3).Value.ToString.Trim & ";;"
            Next
        End If
        ' MsgBox(mapConfig)
        'MsgBox(modeConfig)



        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\DedicatedServerSettings.ini") Then
            'FileIO.FileSystem.DeleteFile(Application.StartupPath & "\DedicatedServerSettings.ini")
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\DedicatedServerSettings.ini")
        End If

        writer = File.AppendText(rutaAppData & "\Config\DedicatedServerSettings.ini")

        writer.WriteLine("//Next line was created by Mods CoJ. Do not modify!")
        writer.WriteLine("//" & serverConfig & "##" & gameModeConfig & "##" & mapConfig & "##" & modeConfig & "##")
        writer.WriteLine("")

        EscribirCabeceraDS()

        writer.WriteLine("ServerName(""" & txtServerName.Text & """)")
        writer.WriteLine("ServerPassword(""" & txtServerPassword.Text & """)")
        writer.WriteLine("ServerPort(" & txtServerPort.Text & ")")
        writer.WriteLine("InternetServer(" & cbInternetLan.SelectedIndex & ")")
        writer.WriteLine("")
        writer.WriteLine("FriendlyFire(" & checkFF.CheckState & ")")
        writer.WriteLine("")
        writer.WriteLine("PublicSlots(" & txtPublicSlots.Text & ")")
        writer.WriteLine("PlayersToStart(" & txtPlayersToStart.Text & ")")
        writer.WriteLine("")

        'BountyLimit("deathmatch", 300)
        'TimeLimit("deathmatch", 800)

        writer.WriteLine("BountyLimit(""deathmatch""," & txtBountyDM.Text.Trim & ")")
        writer.WriteLine("TimeLimit(""deathmatch""," & (Val(txtTimeDM.Text.Trim) * 60).ToString.Trim & ")")
        writer.WriteLine("")

        writer.WriteLine("BountyLimit(""teamdeathmatch""," & txtBountyPosse.Text.Trim & ")")
        writer.WriteLine("TimeLimit(""teamdeathmatch""," & (Val(txtTimePosse.Text.Trim) * 60).ToString.Trim & ")")
        writer.WriteLine("")

        writer.WriteLine("BountyLimit(""wanted""," & txtBountyWanted.Text.Trim & ")")
        writer.WriteLine("TimeLimit(""wanted""," & (Val(txtTimeWanted.Text.Trim) * 60).ToString.Trim & ")")
        writer.WriteLine("")

        writer.WriteLine("PointsLimit(""teamwanted""," & txtPointsManhunt.Text.Trim & ")")
        writer.WriteLine("TimeLimit(""teamwanted""," & (Val(txtTimeManhunt.Text.Trim) * 60).ToString.Trim & ")")
        writer.WriteLine("")

        If tabMaps.SelectedTab Is tabTechlandMaps Then

            For i = 0 To dgTechlandSelMaps.Rows.Count - 1
                writer.WriteLine("Map(""" & dgTechlandSelMaps.Rows(i).Cells(2).Value.ToString.Trim & """, """ & dgTechlandSelMaps.Rows(i).Cells(3).Value.ToString.Trim & """)")
            Next


        ElseIf tabMaps.SelectedTab Is tabCustomMaps Then
            For i = 0 To dgCustomSelMaps.Rows.Count - 1
                writer.WriteLine("Map(""" & dgCustomSelMaps.Rows(i).Cells(0).Value.ToString.Trim & """, """ & dgCustomSelMaps.Rows(i).Cells(3).Value.ToString.Trim & """)")
            Next
        End If

        writer.WriteLine("")
        writer.WriteLine("")
        writer.WriteLine("")
        writer.WriteLine("//Dedicated server was configurated by Mods CoJ.")
        writer.WriteLine("")

        writer.Close()

        If My.Computer.FileSystem.FileExists(ruta & "\CoJ2\DedicatedServerSettings.ini") Then
            My.Computer.FileSystem.DeleteFile(ruta & "\CoJ2\DedicatedServerSettings.ini")
        End If

        My.Computer.FileSystem.CopyFile(rutaAppData & "\Config\DedicatedServerSettings.ini", ruta & "\CoJ2\DedicatedServerSettings.ini")

        Call EscribeFicheroMapsConfigIni()

        lblEstado.Text = "DedicatedServerSettings.ini saved succesfully"
        Timer1.Enabled = True

    End Sub

    Private Sub frmServerConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblEstado.Text = ""
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.DirectoryExists(ruta & "\CoJ2\Data\mapsnet") Then
            Dim rutaMapsnet As String = ruta & "\CoJ2\Data\mapsnet"
            Dim nameFile As String = ""
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(rutaMapsnet)

                nameFile = Mid(foundFile, Len(rutaMapsnet) + 2, Len(foundFile) - (Len(rutaMapsnet) + 5))   'foundFile.Replace(ruta & "\CoJ2\Data\mapsnet\", "")
                'nameFile = nameFile.Replace(".pak", "")

                lbCustomMaps.Items.Add(nameFile)

            Next
        End If

        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\DedicatedServerSettings.ini") Then
            Call LeerConfiguracion()
        End If

        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\MapsConfig.ini") Then
            Call LeeFicheroMapsConfigIni()
        End If

        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\ServerAdmins.ini") Then
            Call LeerConfigAdmins()
        End If

    End Sub

    Private Sub btnCustomSubir_Click(sender As Object, e As EventArgs) Handles btnCustomSubir.Click
        If dgCustomSelMaps.CurrentRow.Index = 0 Then Exit Sub

        Dim ArFilaEnMovimiento(3) As String
        Dim ArFilaASustituir(3) As String

        ArFilaEnMovimiento(0) = dgCustomSelMaps.CurrentRow.Cells(0).Value
        ArFilaEnMovimiento(1) = dgCustomSelMaps.CurrentRow.Cells(1).Value
        ArFilaEnMovimiento(2) = dgCustomSelMaps.CurrentRow.Cells(2).Value
        ArFilaEnMovimiento(3) = dgCustomSelMaps.CurrentRow.Cells(3).Value

        ArFilaASustituir(0) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(0).Value
        ArFilaASustituir(1) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(1).Value
        ArFilaASustituir(2) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(2).Value
        ArFilaASustituir(3) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(3).Value

        dgCustomSelMaps.CurrentRow.Cells(0).Value = ArFilaASustituir(0)
        dgCustomSelMaps.CurrentRow.Cells(1).Value = ArFilaASustituir(1)
        dgCustomSelMaps.CurrentRow.Cells(2).Value = ArFilaASustituir(2)
        dgCustomSelMaps.CurrentRow.Cells(3).Value = ArFilaASustituir(3)

        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(0).Value = ArFilaEnMovimiento(0)
        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(1).Value = ArFilaEnMovimiento(1)
        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(2).Value = ArFilaEnMovimiento(2)
        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(3).Value = ArFilaEnMovimiento(3)

        dgCustomSelMaps.CurrentCell = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index - 1).Cells(0)
        dgCustomSelMaps.CurrentRow.Selected = True

    End Sub

    Private Sub btnCustomBajar_Click(sender As Object, e As EventArgs) Handles btnCustomBajar.Click
        If dgCustomSelMaps.CurrentRow.Index = dgCustomSelMaps.Rows.Count - 1 Then Exit Sub

        Dim ArFilaEnMovimiento(3) As String
        Dim ArFilaASustituir(3) As String

        ArFilaEnMovimiento(0) = dgCustomSelMaps.CurrentRow.Cells(0).Value
        ArFilaEnMovimiento(1) = dgCustomSelMaps.CurrentRow.Cells(1).Value
        ArFilaEnMovimiento(2) = dgCustomSelMaps.CurrentRow.Cells(2).Value
        ArFilaEnMovimiento(3) = dgCustomSelMaps.CurrentRow.Cells(3).Value

        ArFilaASustituir(0) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(0).Value
        ArFilaASustituir(1) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(1).Value
        ArFilaASustituir(2) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(2).Value
        ArFilaASustituir(3) = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(3).Value

        dgCustomSelMaps.CurrentRow.Cells(0).Value = ArFilaASustituir(0)
        dgCustomSelMaps.CurrentRow.Cells(1).Value = ArFilaASustituir(1)
        dgCustomSelMaps.CurrentRow.Cells(2).Value = ArFilaASustituir(2)
        dgCustomSelMaps.CurrentRow.Cells(3).Value = ArFilaASustituir(3)

        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(0).Value = ArFilaEnMovimiento(0)
        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(1).Value = ArFilaEnMovimiento(1)
        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(2).Value = ArFilaEnMovimiento(2)
        dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(3).Value = ArFilaEnMovimiento(3)

        dgCustomSelMaps.CurrentCell = dgCustomSelMaps.Rows(dgCustomSelMaps.CurrentRow.Index + 1).Cells(0)
        dgCustomSelMaps.CurrentRow.Selected = True
    End Sub

    Private Sub btnCustomAdd_Click(sender As Object, e As EventArgs) Handles btnCustomAdd.Click, lbCustomMaps.DoubleClick

        If lbCustomMaps.SelectedItem <> "" Then
            dgCustomSelMaps.Rows.Add()

            dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(0).Value = lbCustomMaps.SelectedItem

            dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(1).Value = cbCustomGameMode.SelectedItem

            If cbCustomGameMode.SelectedItem = "WWL" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(3).Value = "historical"
            ElseIf cbCustomGameMode.SelectedItem = "Posse" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(3).Value = "teamdeathmatch"
            ElseIf cbCustomGameMode.SelectedItem = "Manhunt" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(3).Value = "teamwanted"
            Else
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(3).Value = LCase(cbCustomGameMode.SelectedItem)

            End If


            If lbCustomMaps.SelectedItem = "Taos Pueblo" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(2).Value = "Adobes"
            ElseIf lbCustomMaps.SelectedItem = "Burnside's Bridge" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(2).Value = "Civil"
            ElseIf lbCustomMaps.SelectedItem = "Nogales" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(2).Value = "PrisonBreak2"
            ElseIf lbCustomMaps.SelectedItem = "Stinking Springs" Then
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(2).Value = "StinkingSprings2"
            Else
                dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(2).Value = lbCustomMaps.SelectedItem
            End If

            dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Selected = True
            dgCustomSelMaps.CurrentCell = dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(0)
        End If

    End Sub

    Private Sub btnCustomDel_Click(sender As Object, e As EventArgs) Handles btnCustomDel.Click
        If dgCustomSelMaps.SelectedRows.Count > 0 Then
            dgCustomSelMaps.Rows.Remove(dgCustomSelMaps.CurrentRow)
        End If
    End Sub

    Private Sub dgTechlandSelMaps_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTechlandSelMaps.CellDoubleClick
        dgTechlandSelMaps.Rows.Remove(dgTechlandSelMaps.CurrentRow)
    End Sub

    Private Sub btnTechlandDel_Click(sender As Object, e As EventArgs) Handles btnTechlandDel.Click
        If dgTechlandSelMaps.SelectedRows.Count > 0 Then
            dgTechlandSelMaps.Rows.Remove(dgTechlandSelMaps.CurrentRow)
        End If
    End Sub

    Private Sub dgCustomSelMaps_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomSelMaps.CellDoubleClick
        dgCustomSelMaps.Rows.Remove(dgCustomSelMaps.CurrentRow)
    End Sub

    Private Sub btnApplyAdmins_Click(sender As Object, e As EventArgs) Handles btnApplyAdmins.Click
        adminsUserConfig = ""
        adminPassConfig = ""
        adminLevelConfig = ""
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\ServerAdmins.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\ServerAdmins.ini")
        End If

        For i = 0 To dgAdmins.Rows.Count - 2
            adminsUserConfig = adminsUserConfig & dgAdmins.Rows(i).Cells(0).Value.ToString.Trim & ";;"
            adminPassConfig = adminPassConfig & dgAdmins.Rows(i).Cells(1).Value.ToString.Trim & ";;"
            adminLevelConfig = adminLevelConfig & dgAdmins.Rows(i).Cells(2).Value.ToString.Trim & ";;"
        Next

        writer = File.AppendText(rutaAppData & "\Config\ServerAdmins.ini")

        writer.WriteLine("//Next line was created by Mods CoJ. Do not modify!")
        writer.WriteLine("//" & adminsUserConfig & "##" & adminPassConfig & "##" & adminLevelConfig & "##")
        writer.WriteLine("")

        writer.WriteLine("!Admin(s, s, i)")
        writer.WriteLine("")
        writer.WriteLine("// Admin( sUserName, sPassword, iRights )")
        writer.WriteLine("// iRights:")
        writer.WriteLine("// 0 - standard")
        writer.WriteLine("// 1 - full")
        writer.WriteLine("// for example:")
        writer.WriteLine("// Admin( ""nick"", ""pass"", 0 )")
        writer.WriteLine("")

        For i = 0 To dgAdmins.Rows.Count - 2
            adminsUserConfig = dgAdmins.Rows(i).Cells(0).Value.ToString.Trim
            adminPassConfig = dgAdmins.Rows(i).Cells(1).Value.ToString.Trim
            adminLevelConfig = dgAdmins.Rows(i).Cells(2).Value.ToString.Trim

            If adminLevelConfig = "Standard" Then
                adminLevelConfig = "0"

            ElseIf adminLevelConfig = "Full" Then
                adminLevelConfig = "1"

            End If

            writer.WriteLine("Admin( """ & adminsUserConfig & """, """ & adminPassConfig & """, " & adminLevelConfig & " )")
        Next
        writer.WriteLine("")
        writer.WriteLine("")
        writer.WriteLine("")
        writer.WriteLine("//Admin setting was configurated by Mods CoJ!")
        writer.Close()

        If My.Computer.FileSystem.FileExists(ruta & "\CoJ2\ServerAdmins.ini") Then
            My.Computer.FileSystem.DeleteFile(ruta & "\CoJ2\ServerAdmins.ini")
        End If

        My.Computer.FileSystem.CopyFile(rutaAppData & "\Config\ServerAdmins.ini", ruta & "\CoJ2\ServerAdmins.ini")

        lblEstado.Text = "ServerAdmins.ini saved succesfully"
        Timer1.Enabled = True

    End Sub

    Sub EscribirCabeceraDS()

        writer.WriteLine("////////////////////////////////////////////////////")
        writer.WriteLine("////////////////////////////////////////////////////")
        writer.WriteLine("// keywords - please don't edit this part of file //")
        writer.WriteLine("////////////////////////////////////////////////////")
        writer.WriteLine("////////////////////////////////////////////////////")
        writer.WriteLine("")
        writer.WriteLine("!Map(s, s)                      // map name, game mode name")
        writer.WriteLine("// map's name are: ""Adobes"" (for Taos Pueblo in the game), ""Civil"" (Burnside's Bridge), ""Coffeyville"" (Coffeyville), ""Frisco"" (Frisco), ""Magnificent"" (Magnificent), ""PrisonBreak2"" (Nogales), ""StinkingSprings2"" (Stinking Springs), ""Tombstone"" (Tombstone)")
        writer.WriteLine("// game's mode are: ""historical"" (for Wild West Legends in the game), ""teamwanted"" (Manhunt), ""wanted"" (Wanted), ""deathmatch"" (Shootout), ""teamdeathmatch"" (Posse)")
        writer.WriteLine("")
        writer.WriteLine("!InternetServer(i)              // 1 means internet server, 0 means LAN server")
        writer.WriteLine("!PublicSlots(i)                 // number of public slots (max players), 12 by default")
        writer.WriteLine("!PlayersToStart(i)              // minimum number of players for the game to begin, 1 by default")
        writer.WriteLine("")
        writer.WriteLine("//common params for all game modes (""teamwanted"" / ""wanted"" / ""deathmatch"" / ""teamdeathmatch""); params for ""historical"" can't be changed")
        writer.WriteLine("!PointsLimitDefault(i)          // target number of points for the game to end (for ""teamwanted"" only)")
        writer.WriteLine("!BountyLimit(s, i)              // target of bounty for the game to end in game modes (for ""wanted"", ""deathmatch"", ""teamdeathmatch"" only)")
        writer.WriteLine("!TimeLimitDefault(i)            // map time limit in seconds (for ""teamwanted"", ""wanted"", ""deathmatch"", ""teamdeathmatch"" only)")
        writer.WriteLine("")
        writer.WriteLine("//specific game mode params for (""teamwanted"" / ""wanted"" / ""deathmatch"" / ""teamdeathmatch""); params for ""historical"" can't be changed; those keywords should be defined ater PointsLimitDefault()/BountyLimitDefault(), TimeLimitDefault() keywords!")
        writer.WriteLine("!PointsLimit(s, i)              // target number of points for the game to end in game mode s (for ""teamwanted"" only)")
        writer.WriteLine("!BountyLimit(s, i)              // target of bounty for the game to end in game modes (for ""wanted"", ""deathmatch"", ""teamdeathmatch"" only)")
        writer.WriteLine("!TimeLimit(s, i)                // map time limit in seconds in game mode s (for ""teamwanted"", ""wanted"", ""deathmatch"", ""teamdeathmatch"" only)")
        writer.WriteLine("")
        writer.WriteLine("")
        writer.WriteLine("!FriendlyFire(i)                // 1 = friendly fire is on 0 = friendly fire is off")
        writer.WriteLine("")
        writer.WriteLine("!ServerName(s)                  // server name visible on the server list")
        writer.WriteLine("!ServerPassword(s)              // password for starting the server - should be defined to prevent other servers from using the same name")
        writer.WriteLine("!ServerPort(i)                  // port the server is running on")
        writer.WriteLine("")
        writer.WriteLine("/////////////////////////////////////////////////")
        writer.WriteLine("/////////////////////////////////////////////////")
        writer.WriteLine("// your dedicated server settings start below  //")
        writer.WriteLine("// you can edit this part as you wish          //")
        writer.WriteLine("/////////////////////////////////////////////////")
        writer.WriteLine("/////////////////////////////////////////////////")
        writer.WriteLine("")



    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles panelMin2.Paint

    End Sub

    Private Sub lblMin1_Click(sender As Object, e As EventArgs) Handles lblMin1.Click, panelMin1.Click
        txtTimeDM.Focus()
    End Sub

    Private Sub lblMin2_Click(sender As Object, e As EventArgs) Handles lblMin2.Click, panelMin2.Click
        txtTimePosse.Focus()
    End Sub

    Private Sub lblMin3_Click(sender As Object, e As EventArgs) Handles lblMin3.Click, panelMin3.Click
        txtTimeManhunt.Focus()
    End Sub

    Private Sub lblMin4_Click(sender As Object, e As EventArgs) Handles lblMin4.Click, panelMin4.Click
        txtTimeWanted.Focus()
    End Sub


    Sub LeerConfiguracion()
        Dim linealeida As String = ""
        Dim lineaPanel1 As String = ""
        Dim lineaPanel2 As String = ""
        Dim lineaMapas As String = ""
        Dim lineaMode As String = ""
        Dim tipoDeMapas As String = ""

        reader = File.OpenText(rutaAppData & "\Config\DedicatedServerSettings.ini")

        reader.ReadLine()
        linealeida = reader.ReadLine()
        reader.Close()

        If Trim(linealeida) = "" Or linealeida Is Nothing Then Exit Sub

        'MsgBox(InStr(linealeida, "##"))

        lineaPanel1 = Mid(linealeida, 3, InStr(linealeida, "##") - 3)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))

        txtServerName.Text = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))
        txtServerPassword.Text = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))
        txtServerPort.Text = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))
        cbInternetLan.Text = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))
        txtPublicSlots.Text = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))
        txtPlayersToStart.Text = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))
        checkFF.Checked = Mid(lineaPanel1, 1, InStr(lineaPanel1, ";;") - 1)
        lineaPanel1 = Mid(lineaPanel1, InStr(lineaPanel1, ";;") + 2, Len(lineaPanel1) - (InStr(lineaPanel1, ";;") + 1))


        lineaPanel2 = Mid(linealeida, 1, InStr(linealeida, "##") - 1)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))
        txtBountyDM.Text = Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtTimeDM.Text = Trim(Str(Val(Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)) / 60))
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtBountyPosse.Text = Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtTimePosse.Text = Trim(Str(Val(Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)) / 60))
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtPointsManhunt.Text = Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtTimeManhunt.Text = Trim(Str(Val(Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)) / 60))
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtBountyWanted.Text = Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))
        txtTimeWanted.Text = Trim(Str(Val(Mid(lineaPanel2, 1, InStr(lineaPanel2, ";;") - 1)) / 60))
        lineaPanel2 = Mid(lineaPanel2, InStr(lineaPanel2, ";;") + 2, Len(lineaPanel2) - (InStr(lineaPanel2, ";;") + 1))


        lineaMapas = Mid(linealeida, 1, InStr(linealeida, "##") - 1)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))

        Dim i As Integer = 0

        tipoDeMapas = Mid(lineaMapas, 1, InStr(lineaMapas, ";;") - 1)
        If tipoDeMapas = "techland" Then
            tabMaps.SelectedTab = tabTechlandMaps
        ElseIf tipoDeMapas = "custom" Then
            tabMaps.SelectedTab = tabCustomMaps
        End If

        lineaMapas = Mid(lineaMapas, InStr(lineaMapas, ";;") + 2, Len(lineaMapas) - (InStr(lineaMapas, ";;") + 1))

        Do While InStr(lineaMapas, ";;") > 0
            If tipoDeMapas = "techland" Then
                dgTechlandSelMaps.Rows.Add()
                dgTechlandSelMaps.Rows(i).Cells(2).Value = Mid(lineaMapas, 1, InStr(lineaMapas, ";;") - 1)
                lineaMapas = Mid(lineaMapas, InStr(lineaMapas, ";;") + 2, Len(lineaMapas) - (InStr(lineaMapas, ";;") + 1))

                If dgTechlandSelMaps.Rows(i).Cells(2).Value = "Adobes" Then
                    dgTechlandSelMaps.Rows(i).Cells(0).Value = "Taos Pueblo"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(2).Value = "Civil" Then
                    dgTechlandSelMaps.Rows(i).Cells(0).Value = "Burnside's Bridge"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(2).Value = "PrisonBreak2" Then
                    dgTechlandSelMaps.Rows(i).Cells(0).Value = "Nogales"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(2).Value = "StinkingSprings2" Then
                    dgTechlandSelMaps.Rows(i).Cells(0).Value = "Stinking Springs"
                Else
                    dgTechlandSelMaps.Rows(i).Cells(0).Value = dgTechlandSelMaps.Rows(i).Cells(2).Value
                End If

            ElseIf tipoDeMapas = "custom" Then
                dgCustomSelMaps.Rows.Add()
                dgCustomSelMaps.Rows(i).Cells(0).Value = Mid(lineaMapas, 1, InStr(lineaMapas, ";;") - 1)
                lineaMapas = Mid(lineaMapas, InStr(lineaMapas, ";;") + 2, Len(lineaMapas) - (InStr(lineaMapas, ";;") + 1))

            End If
            i = i + 1
        Loop



        lineaMode = Mid(linealeida, 1, InStr(linealeida, "##") - 1)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))
        i = 0

        Do While InStr(lineaMode, ";;") > 0
            If tipoDeMapas = "techland" Then
                dgTechlandSelMaps.Rows(i).Cells(3).Value = Mid(lineaMode, 1, InStr(lineaMode, ";;") - 1)
                lineaMode = Mid(lineaMode, InStr(lineaMode, ";;") + 2, Len(lineaMode) - (InStr(lineaMode, ";;") + 1))

                If dgTechlandSelMaps.Rows(i).Cells(3).Value = "deathmatch" Then
                    dgTechlandSelMaps.Rows(i).Cells(1).Value = "Deathmatch"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(3).Value = "teamdeathmatch" Then
                    dgTechlandSelMaps.Rows(i).Cells(1).Value = "Posse"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(3).Value = "teamwanted" Then
                    dgTechlandSelMaps.Rows(i).Cells(1).Value = "Manhunt"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(3).Value = "historical" Then
                    dgTechlandSelMaps.Rows(i).Cells(1).Value = "WWL"
                ElseIf dgTechlandSelMaps.Rows(i).Cells(3).Value = "wanted" Then
                    dgTechlandSelMaps.Rows(i).Cells(1).Value = "Wanted"
                End If

            ElseIf tipoDeMapas = "custom" Then
                dgCustomSelMaps.Rows(i).Cells(3).Value = Mid(lineaMode, 1, InStr(lineaMode, ";;") - 1)
                lineaMode = Mid(lineaMode, InStr(lineaMode, ";;") + 2, Len(lineaMode) - (InStr(lineaMode, ";;") + 1))

                If dgCustomSelMaps.Rows(i).Cells(3).Value = "deathmatch" Then
                    dgCustomSelMaps.Rows(i).Cells(1).Value = "Deathmatch"
                ElseIf dgCustomSelMaps.Rows(i).Cells(3).Value = "teamdeathmatch" Then
                    dgCustomSelMaps.Rows(i).Cells(1).Value = "Posse"
                ElseIf dgCustomSelMaps.Rows(i).Cells(3).Value = "teamwanted" Then
                    dgCustomSelMaps.Rows(i).Cells(1).Value = "Manhunt"
                ElseIf dgCustomSelMaps.Rows(i).Cells(3).Value = "historical" Then
                    dgCustomSelMaps.Rows(i).Cells(1).Value = "WWL"
                ElseIf dgCustomSelMaps.Rows(i).Cells(3).Value = "wanted" Then
                    dgCustomSelMaps.Rows(i).Cells(1).Value = "Wanted"
                End If

            End If
            i = i + 1
        Loop


    End Sub

    Private Sub dgAdmins_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgAdmins.RowsAdded
        If leyendoConfig = False Then dgAdmins.Rows(dgAdmins.Rows.Count - 1).Cells(2).Value = "Standard"
    End Sub

    Sub LeerConfigAdmins()
        leyendoConfig = True
        Dim linealeida As String = ""
        Dim lineaUser As String = ""
        Dim lineaPass As String = ""
        Dim lineaLevel As String = ""

        reader = File.OpenText(rutaAppData & "\Config\ServerAdmins.ini")

        reader.ReadLine()
        linealeida = reader.ReadLine()
        reader.Close()

        lineaUser = Mid(linealeida, 3, InStr(linealeida, "##") - 3)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))

        lineaPass = Mid(linealeida, 1, InStr(linealeida, "##") - 1)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))

        lineaLevel = Mid(linealeida, 1, InStr(linealeida, "##") - 1)
        linealeida = Mid(linealeida, InStr(linealeida, "##") + 2, Len(linealeida) - (InStr(linealeida, "##") + 1))

        Dim admin As String = ""
        Dim pass As String = ""
        Dim level As String = ""

        Do While InStr(lineaUser, ";;") > 0

            dgAdmins.Rows.Add()

            admin = Mid(lineaUser, 1, InStr(lineaUser, ";;") - 1)
            lineaUser = Mid(lineaUser, InStr(lineaUser, ";;") + 2, Len(lineaUser) - (InStr(lineaUser, ";;") + 1))

            dgAdmins.Rows(dgAdmins.Rows.Count - 2).Cells(0).Value = admin

            pass = Mid(lineaPass, 1, InStr(lineaPass, ";;") - 1)
            lineaPass = Mid(lineaPass, InStr(lineaPass, ";;") + 2, Len(lineaPass) - (InStr(lineaPass, ";;") + 1))

            dgAdmins.Rows(dgAdmins.Rows.Count - 2).Cells(1).Value = pass


            level = Mid(lineaLevel, 1, InStr(lineaLevel, ";;") - 1)
            lineaLevel = Mid(lineaLevel, InStr(lineaLevel, ";;") + 2, Len(lineaLevel) - (InStr(lineaLevel, ";;") + 1))

            dgAdmins.Rows(dgAdmins.Rows.Count - 2).Cells(2).Value = level

        Loop
        leyendoConfig = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblEstado.Text = ""
        Timer1.Enabled = False
    End Sub

    Private Sub txtServerName_Leave(sender As Object, e As EventArgs) Handles txtServerName.Leave, txtServerPassword.Leave, txtServerPort.Leave, txtPlayersToStart.Leave, txtPublicSlots.Leave
        txtServerName.BackColor = SystemColors.Window
        txtServerPassword.BackColor = SystemColors.Window
        txtServerPort.BackColor = SystemColors.Window
        txtPlayersToStart.BackColor = SystemColors.Window
        txtPublicSlots.BackColor = SystemColors.Window
    End Sub

    Private Sub frmServerConfig_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Adaptamos las columnas de los dGrid a las distintas pantallas
        Dim AnchoDgAdmins As Integer = Int((dgAdmins.Width - 15) / 3)
        Dg1ColumTextBoxLevel.Width = AnchoDgAdmins
        Dg1ColumTextBoxPassword.Width = AnchoDgAdmins
        Dg1ColumTextBoxUser.Width = AnchoDgAdmins

        Dim AnchoDgMaps As Integer = Int((dgCustomSelMaps.Width) / 2)
        Dg2ColumTextBoxGamemode.Width = AnchoDgMaps
        Dg2ColumTextBoxMapName.Width = AnchoDgMaps

        Dg3ColumTextBoxGameMode.Width = AnchoDgMaps
        Dg3ColumTextBoxMapName.Width = AnchoDgMaps

    End Sub

    Private Sub txtPublicSlots_TextChanged(sender As Object, e As EventArgs) Handles txtPublicSlots.TextChanged
        If Val(txtPublicSlots.Text) > 30 Then
            txtPublicSlots.Text = 30
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Cursor = Cursors.WaitCursor
        Help.ShowHelp(Me, Application.StartupPath & "\CoJ Mods.chm")
        Cursor = Cursors.Default
    End Sub



    'Este fichero lo guardaremos con todos los mapas añadidos tanto en el Dgrid de Techland como en el de Custom
    'para así no perder ninguna de las 2 configuraciones nunca. Por ello este fichero es solo como apoyo, no se usa en el juego
    Private Sub EscribeFicheroMapsConfigIni()

        'Borramos el ficheo MapsConfig.ini antes de grabarlo de nuevo
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\MapsConfig.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\MapsConfig.ini")
        End If

        writer = File.AppendText(rutaAppData & "\Config\MapsConfig.ini")


        writer.WriteLine("//Next line was created by Mods CoJ. Do not modify!")
        writer.WriteLine("techland")

        'Escribimos 1º los mapas y modos de techland
        For i = 0 To dgTechlandSelMaps.Rows.Count - 1
            writer.WriteLine(dgTechlandSelMaps.Rows(i).Cells(0).Value.ToString.Trim & ";;" & dgTechlandSelMaps.Rows(i).Cells(1).Value.ToString.Trim & ";;" & dgTechlandSelMaps.Rows(i).Cells(2).Value.ToString.Trim & ";;" & dgTechlandSelMaps.Rows(i).Cells(3).Value.ToString.Trim & ";;")
        Next

        writer.WriteLine("")
        writer.WriteLine("custom")
        'Escribimos 2º los mapas custom y sus modos
        For i = 0 To dgCustomSelMaps.Rows.Count - 1
            writer.WriteLine(dgCustomSelMaps.Rows(i).Cells(0).Value.ToString.Trim & ";;" & dgCustomSelMaps.Rows(i).Cells(1).Value.ToString.Trim & ";;" & dgCustomSelMaps.Rows(i).Cells(1).Value.ToString.Trim & ";;" & dgCustomSelMaps.Rows(i).Cells(3).Value.ToString.Trim & ";;")
        Next

        writer.Close()
    End Sub

    Sub LeeFicheroMapsConfigIni()
        Dim lineaLeida As String = ""
        dgTechlandSelMaps.Rows.Clear()
        dgCustomSelMaps.Rows.Clear()
        reader = File.OpenText(rutaAppData & "\Config\MapsConfig.ini")

        '1º Leemos los mapas techland que son los primeros escritos en el fichero
        Do While reader.EndOfStream = False
            lineaLeida = reader.ReadLine()
            If lineaLeida = "custom" Then
                Exit Do
            End If
            If InStr(lineaLeida, ";;") > 0 Then
                dgTechlandSelMaps.Rows.Add()
                For i = 0 To 3
                    dgTechlandSelMaps.Rows(dgTechlandSelMaps.Rows.Count - 1).Cells(i).Value = Mid(lineaLeida, 1, InStr(lineaLeida, ";;") - 1)
                    lineaLeida = Mid(lineaLeida, InStr(lineaLeida, ";;") + 2, Len(lineaLeida) - (InStr(lineaLeida, ";;") + 1))
                Next
            End If
        Loop

        '2º Aquí leemos los customs que están al final del fichero
        Do While reader.EndOfStream = False
            lineaLeida = reader.ReadLine()
            If InStr(lineaLeida, ";;") > 0 Then
                dgCustomSelMaps.Rows.Add()
                For i = 0 To 3
                    dgCustomSelMaps.Rows(dgCustomSelMaps.Rows.Count - 1).Cells(i).Value = Mid(lineaLeida, 1, InStr(lineaLeida, ";;") - 1)
                    lineaLeida = Mid(lineaLeida, InStr(lineaLeida, ";;") + 2, Len(lineaLeida) - (InStr(lineaLeida, ";;") + 1))
                Next
            End If
        Loop
        reader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call LeeFicheroMapsConfigIni()
    End Sub
End Class