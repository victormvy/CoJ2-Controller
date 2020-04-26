' =================================================================================
' frmClase.vb - Class selection form
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

Public Class frmClase

    Dim ClaseEnCreacion As Integer = 0


    Private Sub pictureAristocrat_Click(sender As Object, e As EventArgs) Handles pictureAristocrat.Click, lblAristocrat.Click
        ClaseEnCreacion = 0

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"



    End Sub

    Private Sub pictureBandit_Click(sender As Object, e As EventArgs) Handles pictureBandit.Click, lblBandit.Click
        ClaseEnCreacion = 1

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureBarnsby_Click(sender As Object, e As EventArgs) Handles pictureBarnsby.Click, lblBarnsby.Click
        ClaseEnCreacion = 2

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureDoc_Click(sender As Object, e As EventArgs) Handles pictureDoc.Click, lblDoc.Click
        ClaseEnCreacion = 3

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureGunslinger_Click(sender As Object, e As EventArgs) Handles pictureGunslinger.Click, lblGunslinger.Click
        ClaseEnCreacion = 4

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureGunsmith_Click(sender As Object, e As EventArgs) Handles pictureGunsmith.Click, lblGunsmith.Click
        ClaseEnCreacion = 5

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureJuarez_Click(sender As Object, e As EventArgs) Handles pictureJuarez.Click, lblJuarez.Click
        ClaseEnCreacion = 6

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureMiner_Click(sender As Object, e As EventArgs) Handles pictureMiner.Click, lblMiner.Click
        ClaseEnCreacion = 7

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureRifleman_Click(sender As Object, e As EventArgs) Handles pictureRifleman.Click, lblRifleman.Click
        ClaseEnCreacion = 8

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureSniper_Click(sender As Object, e As EventArgs) Handles pictureSniper.Click, lblSniper.Click
        ClaseEnCreacion = 9

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureThief_Click(sender As Object, e As EventArgs) Handles pictureThief.Click, lblThief.Click
        ClaseEnCreacion = 10

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureTrapper_Click(sender As Object, e As EventArgs) Handles pictureTrapper.Click, lblTrapper.Click
        ClaseEnCreacion = 11

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub pictureTribeWarrior_Click(sender As Object, e As EventArgs) Handles pictureTribeWarrior.Click, lblTribeWarrior.Click
        ClaseEnCreacion = 12

        pictureAristocrat.ImageLocation = Application.StartupPath & "\images\characters\" & "Aristocrat" & ".jpg"
        pictureBandit.ImageLocation = Application.StartupPath & "\images\characters\" & "Bandit" & ".jpg"
        pictureBarnsby.ImageLocation = Application.StartupPath & "\images\characters\" & "Barnsby" & ".jpg"
        pictureDoc.ImageLocation = Application.StartupPath & "\images\characters\" & "Doc" & ".jpg"
        pictureGunslinger.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunslinger" & ".jpg"
        pictureGunsmith.ImageLocation = Application.StartupPath & "\images\characters\" & "Gunsmith" & ".jpg"
        pictureJuarez.ImageLocation = Application.StartupPath & "\images\characters\" & "Juarez" & ".jpg"
        pictureMiner.ImageLocation = Application.StartupPath & "\images\characters\" & "Miner" & ".jpg"
        pictureRifleman.ImageLocation = Application.StartupPath & "\images\characters\" & "Rifleman" & ".jpg"
        pictureSniper.ImageLocation = Application.StartupPath & "\images\characters\" & "Sniper" & ".jpg"
        pictureThief.ImageLocation = Application.StartupPath & "\images\characters\" & "Thief" & ".jpg"
        pictureTrapper.ImageLocation = Application.StartupPath & "\images\characters\" & "Trapper" & ".jpg"
        pictureTribeWarrior.ImageLocation = Application.StartupPath & "\images\characters\Selecc_" & "Tribe Warrior" & ".jpg"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, pictureAristocrat.DoubleClick, pictureBandit.DoubleClick, pictureBarnsby.DoubleClick, pictureDoc.DoubleClick, pictureGunslinger.DoubleClick, pictureGunsmith.DoubleClick, pictureJuarez.DoubleClick, pictureMiner.DoubleClick, pictureRifleman.DoubleClick, pictureSniper.DoubleClick, pictureThief.DoubleClick, pictureTrapper.DoubleClick, pictureTribeWarrior.DoubleClick
        frmArmas.cbClass.SelectedIndex = ClaseEnCreacion

        If checkLoadDefault.Checked = True Then

            If frmArmas.cbClass.SelectedIndex = 0 Then 'Explorador
                frmArmas.lbNewChar.Items.Add("Aristocrat")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 3
                frmArmas.cbWeap3.SelectedIndex = 5
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 0

            ElseIf frmArmas.cbClass.SelectedIndex = 1 Then 'Hombre
                frmArmas.lbNewChar.Items.Add("Bandit")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 4
                frmArmas.cbWeap2.SelectedIndex = 4
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 1

            ElseIf frmArmas.cbClass.SelectedIndex = 2 Then 'Veterano
                frmArmas.lbNewChar.Items.Add("Barnsby")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 8
                frmArmas.cbWeap3.SelectedIndex = 2
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 0

            ElseIf frmArmas.cbClass.SelectedIndex = 3 Then 'Duelista
                frmArmas.lbNewChar.Items.Add("Doc")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 6
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 1

            ElseIf frmArmas.cbClass.SelectedIndex = 4 Then 'Artillero
                frmArmas.lbNewChar.Items.Add("Gunslinger")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 5
                frmArmas.cbWeap2.SelectedIndex = 5
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.checkWeap4.Checked = True
                frmArmas.cbAmmo4.SelectedIndex = 1
                frmArmas.cbDefault.SelectedIndex = 1

            ElseIf frmArmas.cbClass.SelectedIndex = 5 Then 'Armero
                frmArmas.lbNewChar.Items.Add("Gunsmith")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 2
                frmArmas.cbWeap2.SelectedIndex = 0
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 1

            ElseIf frmArmas.cbClass.SelectedIndex = 6 Then 'Oficial
                frmArmas.lbNewChar.Items.Add("Juarez")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 7
                frmArmas.cbWeap2.SelectedIndex = 7
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 1

            ElseIf frmArmas.cbClass.SelectedIndex = 7 Then 'Miner
                frmArmas.lbNewChar.Items.Add("Miner")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 7
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.cbWeap2.SelectedIndex = 4
                frmArmas.checkWeap4.Checked = True
                frmArmas.cbAmmo4.SelectedIndex = 4
                frmArmas.cbDefault.SelectedIndex = 2

            ElseIf frmArmas.cbClass.SelectedIndex = 8 Then 'Fusilero
                frmArmas.lbNewChar.Items.Add("Rifleman")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 3
                frmArmas.cbWeap2.SelectedIndex = 3
                frmArmas.cbWeap3.SelectedIndex = 4
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 0

            ElseIf frmArmas.cbClass.SelectedIndex = 9 Then 'Tirador
                frmArmas.lbNewChar.Items.Add("Sniper")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 7
                frmArmas.cbWeap3.SelectedIndex = 3
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 0

            ElseIf frmArmas.cbClass.SelectedIndex = 10 Then 'Spy
                frmArmas.lbNewChar.Items.Add("Thief")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 1
                frmArmas.cbWeap3.SelectedIndex = 6
                frmArmas.checkWeap4.Checked = True
                frmArmas.cbAmmo4.SelectedIndex = 2
                frmArmas.cbDefault.SelectedIndex = 2

            ElseIf frmArmas.cbClass.SelectedIndex = 11 Then 'Trampero
                frmArmas.lbNewChar.Items.Add("Trapper")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 7
                frmArmas.cbWeap3.SelectedIndex = 1
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 0

            ElseIf frmArmas.cbClass.SelectedIndex = 12 Then 'Piel Roja
                frmArmas.lbNewChar.Items.Add("Tribe Warrior")
                frmArmas.lbNewChar.SelectedIndex = frmArmas.lbNewChar.Items.Count - 1
                frmArmas.cbWeap1.SelectedIndex = 8
                frmArmas.cbWeap2.SelectedIndex = 8
                frmArmas.cbWeap3.SelectedIndex = 0
                frmArmas.checkWeap4.Checked = False
                frmArmas.cbDefault.SelectedIndex = 0

            End If

        End If

        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod


        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub


    Private Sub frmClase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class