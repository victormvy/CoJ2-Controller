' =================================================================================
' frmTablaConfig.vb - Mod summary table form
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

Public Class frmTablaConfig



    Private Sub panelAristocrat_Click(sender As Object, e As EventArgs) Handles panelAristocrat.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Aristocrat"
        Me.Hide()
    End Sub

    Private Sub panelBandit_Click(sender As Object, e As EventArgs) Handles panelBandit.DoubleClick

        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Bandit"
        Me.Hide()
    End Sub

    Private Sub panelBarnsby_Click(sender As Object, e As EventArgs) Handles panelBarnsby.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Barnsby"
        Me.Hide()
    End Sub

    Private Sub panelDoc_Click(sender As Object, e As EventArgs) Handles panelDoc.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Doc"
        Me.Hide()
    End Sub

    Private Sub panelGunslinger_Click(sender As Object, e As EventArgs) Handles panelGunslinger.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Gunslinger"
        Me.Hide()
    End Sub

    Private Sub panelGunsmith_Click(sender As Object, e As EventArgs) Handles panelGunsmith.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Gunsmith"
        Me.Hide()
    End Sub

    Private Sub panelJuarez_Click(sender As Object, e As EventArgs) Handles panelJuarez.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Juarez"
        Me.Hide()
    End Sub

    Private Sub panelMiner_Click(sender As Object, e As EventArgs) Handles panelMiner.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Miner"
        Me.Hide()
    End Sub

    Private Sub panelRifleman_Click(sender As Object, e As EventArgs) Handles panelRifleman.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Rifleman"
        Me.Hide()
    End Sub

    Private Sub panelSniper_Click(sender As Object, e As EventArgs) Handles panelSniper.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Sniper"
        Me.Hide()
    End Sub

    Private Sub panelThief_Click(sender As Object, e As EventArgs) Handles panelThief.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Thief"
        Me.Hide()
    End Sub

    Private Sub panelTrapper_Click(sender As Object, e As EventArgs) Handles panelTrapper.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Trapper"
        Me.Hide()
    End Sub

    Private Sub panelTW_Click(sender As Object, e As EventArgs) Handles panelTW.DoubleClick
        frmArmas.Focus()
        frmArmas.TabControlMods.SelectedTab = frmArmas.tabNewMod
        frmArmas.lbNewChar.SelectedItem = "Tribe Warrior"
        Me.Hide()
    End Sub


    Private Sub ArmasClase(modIniTabla As String, ClaseEditando As String)

        If ClaseEditando = "Aristocrat" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelAristocratLeftWeapon.BackColor = SystemColors.Control
                panelAristocratRightWeapon.BackColor = SystemColors.Control
                panelAristocratBothHands.BackColor = Color.SeaGreen
                panelAristocratDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelAristocratLeftWeapon.BackColor = Color.SeaGreen
                panelAristocratRightWeapon.BackColor = Color.SeaGreen
                panelAristocratBothHands.BackColor = SystemColors.Control
                panelAristocratDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelAristocratLeftWeapon.BackColor = SystemColors.Control
                panelAristocratRightWeapon.BackColor = Color.SeaGreen
                panelAristocratBothHands.BackColor = SystemColors.Control
                panelAristocratDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelAristocratDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelAristocratDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelAristocratDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelAristocratDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelAristocratDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelAristocratDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelAristocratLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelAristocratLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelAristocratRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelAristocratRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelAristocratBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelAristocratBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelAristocratBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelAristocratBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelAristocratBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelAristocratBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelAristocratBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoAristocrat.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoAristocrat.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoAristocrat.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoAristocrat.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoAristocrat.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoAristocrat.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoAristocrat.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoAristocrat.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoAristocrat.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoAristocrat.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoAristocrat.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoAristocrat.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoAristocrat.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoAristocrat.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoAristocrat.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoAristocrat.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoAristocrat.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoAristocrat.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoAristocrat.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoAristocrat.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoAristocrat.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoAristocrat.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoAristocrat.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoAristocrat.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsAristocrat.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsAristocrat.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsAristocrat.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsAristocrat.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsAristocrat.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsAristocrat.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsAristocrat.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsAristocrat.Text = "100"
            End If

        ElseIf ClaseEditando = "Bandit" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelBanditLeftWeapon.BackColor = SystemColors.Control
                panelBanditRightWeapon.BackColor = SystemColors.Control
                panelBanditBothHands.BackColor = Color.SeaGreen
                panelBanditDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelBanditLeftWeapon.BackColor = Color.SeaGreen
                panelBanditRightWeapon.BackColor = Color.SeaGreen
                panelBanditBothHands.BackColor = SystemColors.Control
                panelBanditDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelBanditLeftWeapon.BackColor = SystemColors.Control
                panelBanditRightWeapon.BackColor = Color.SeaGreen
                panelBanditBothHands.BackColor = SystemColors.Control
                panelBanditDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelBanditDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelBanditDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelBanditDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelBanditDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelBanditDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelBanditDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelBanditLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelBanditLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelBanditRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelBanditRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelBanditBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelBanditBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelBanditBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelBanditBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelBanditBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelBanditBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelBanditBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoBandit.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoBandit.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoBandit.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoBandit.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoBandit.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoBandit.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoBandit.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoBandit.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoBandit.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoBandit.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoBandit.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoBandit.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoBandit.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoBandit.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoBandit.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoBandit.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoBandit.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoBandit.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoBandit.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoBandit.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoBandit.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoBandit.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoBandit.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoBandit.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsBandit.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsBandit.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsBandit.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsBandit.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsBandit.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsBandit.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsBandit.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsBandit.Text = "100"
            End If

        ElseIf ClaseEditando = "Barnsby" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelBarnsbyLeftWeapon.BackColor = SystemColors.Control
                panelBarnsbyRightWeapon.BackColor = SystemColors.Control
                panelBarnsbyBothHands.BackColor = Color.SeaGreen
                panelBarnsbyDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelBarnsbyLeftWeapon.BackColor = Color.SeaGreen
                panelBarnsbyRightWeapon.BackColor = Color.SeaGreen
                panelBarnsbyBothHands.BackColor = SystemColors.Control
                panelBarnsbyDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelBarnsbyLeftWeapon.BackColor = SystemColors.Control
                panelBarnsbyRightWeapon.BackColor = Color.SeaGreen
                panelBarnsbyBothHands.BackColor = SystemColors.Control
                panelBarnsbyDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelBarnsbyDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelBarnsbyDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelBarnsbyDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelBarnsbyDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelBarnsbyDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelBarnsbyDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelBarnsbyLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelBarnsbyLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelBarnsbyRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelBarnsbyRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelBarnsbyBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelBarnsbyBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelBarnsbyBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelBarnsbyBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelBarnsbyBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelBarnsbyBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelBarnsbyBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoBarnsby.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoBarnsby.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoBarnsby.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoBarnsby.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoBarnsby.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoBarnsby.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoBarnsby.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoBarnsby.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoBarnsby.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoBarnsby.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoBarnsby.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoBarnsby.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoBarnsby.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoBarnsby.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoBarnsby.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoBarnsby.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoBarnsby.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoBarnsby.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoBarnsby.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoBarnsby.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoBarnsby.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoBarnsby.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoBarnsby.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoBarnsby.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsBarnsby.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsBarnsby.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsBarnsby.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsBarnsby.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsBarnsby.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsBarnsby.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsBarnsby.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsBarnsby.Text = "100"
            End If

        ElseIf ClaseEditando = "Doc" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelDocLeftWeapon.BackColor = SystemColors.Control
                panelDocRightWeapon.BackColor = SystemColors.Control
                panelDocBothHands.BackColor = Color.SeaGreen
                panelDocDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelDocLeftWeapon.BackColor = Color.SeaGreen
                panelDocRightWeapon.BackColor = Color.SeaGreen
                panelDocBothHands.BackColor = SystemColors.Control
                panelDocDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelDocLeftWeapon.BackColor = SystemColors.Control
                panelDocRightWeapon.BackColor = Color.SeaGreen
                panelDocBothHands.BackColor = SystemColors.Control
                panelDocDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelDocDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelDocDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelDocDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelDocDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelDocDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelDocDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelDocLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelDocLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelDocRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelDocRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelDocBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelDocBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelDocBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelDocBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelDocBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelDocBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelDocBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoDoc.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoDoc.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoDoc.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoDoc.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoDoc.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoDoc.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoDoc.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoDoc.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoDoc.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoDoc.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoDoc.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoDoc.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoDoc.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoDoc.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoDoc.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoDoc.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoDoc.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoDoc.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoDoc.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoDoc.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoDoc.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoDoc.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoDoc.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoDoc.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsDoc.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsDoc.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsDoc.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsDoc.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsDoc.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsDoc.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsDoc.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsDoc.Text = "100"
            End If

        ElseIf ClaseEditando = "Gunslinger" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelGunslingerLeftWeapon.BackColor = SystemColors.Control
                panelGunslingerRightWeapon.BackColor = SystemColors.Control
                panelGunslingerBothHands.BackColor = Color.SeaGreen
                panelGunslingerDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelGunslingerLeftWeapon.BackColor = Color.SeaGreen
                panelGunslingerRightWeapon.BackColor = Color.SeaGreen
                panelGunslingerBothHands.BackColor = SystemColors.Control
                panelGunslingerDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelGunslingerLeftWeapon.BackColor = SystemColors.Control
                panelGunslingerRightWeapon.BackColor = Color.SeaGreen
                panelGunslingerBothHands.BackColor = SystemColors.Control
                panelGunslingerDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelGunslingerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelGunslingerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelGunslingerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelGunslingerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelGunslingerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelGunslingerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelGunslingerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelGunslingerLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelGunslingerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelGunslingerRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelGunslingerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelGunslingerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelGunslingerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelGunslingerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelGunslingerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelGunslingerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelGunslingerBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoGunslinger.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoGunslinger.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoGunslinger.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoGunslinger.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoGunslinger.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoGunslinger.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoGunslinger.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoGunslinger.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoGunslinger.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoGunslinger.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoGunslinger.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoGunslinger.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoGunslinger.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoGunslinger.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoGunslinger.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoGunslinger.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoGunslinger.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoGunslinger.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoGunslinger.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoGunslinger.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoGunslinger.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoGunslinger.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoGunslinger.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoGunslinger.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsGunslinger.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsGunslinger.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsGunslinger.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsGunslinger.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsGunslinger.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsGunslinger.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsGunslinger.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsGunslinger.Text = "100"
            End If

        ElseIf ClaseEditando = "Gunsmith" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelGunsmithLeftWeapon.BackColor = SystemColors.Control
                panelGunsmithRightWeapon.BackColor = SystemColors.Control
                panelGunsmithBothHands.BackColor = Color.SeaGreen
                panelGunsmithDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelGunsmithLeftWeapon.BackColor = Color.SeaGreen
                panelGunsmithRightWeapon.BackColor = Color.SeaGreen
                panelGunsmithBothHands.BackColor = SystemColors.Control
                panelGunsmithDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelGunsmithLeftWeapon.BackColor = SystemColors.Control
                panelGunsmithRightWeapon.BackColor = Color.SeaGreen
                panelGunsmithBothHands.BackColor = SystemColors.Control
                panelGunsmithDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelGunsmithDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelGunsmithDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelGunsmithDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelGunsmithDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelGunsmithDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelGunsmithDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelGunsmithLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelGunsmithLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelGunsmithRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelGunsmithRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelGunsmithBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelGunsmithBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelGunsmithBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelGunsmithBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelGunsmithBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelGunsmithBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelGunsmithBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoGunsmith.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoGunsmith.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoGunsmith.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoGunsmith.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoGunsmith.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoGunsmith.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoGunsmith.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoGunsmith.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoGunsmith.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoGunsmith.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoGunsmith.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoGunsmith.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoGunsmith.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoGunsmith.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoGunsmith.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoGunsmith.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoGunsmith.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoGunsmith.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoGunsmith.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoGunsmith.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoGunsmith.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoGunsmith.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoGunsmith.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoGunsmith.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsGunsmith.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsGunsmith.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsGunsmith.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsGunsmith.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsGunsmith.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsGunsmith.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsGunsmith.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsGunsmith.Text = "100"
            End If

        ElseIf ClaseEditando = "Juarez" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelJuarezLeftWeapon.BackColor = SystemColors.Control
                panelJuarezRightWeapon.BackColor = SystemColors.Control
                panelJuarezBothHands.BackColor = Color.SeaGreen
                panelJuarezDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelJuarezLeftWeapon.BackColor = Color.SeaGreen
                panelJuarezRightWeapon.BackColor = Color.SeaGreen
                panelJuarezBothHands.BackColor = SystemColors.Control
                panelJuarezDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelJuarezLeftWeapon.BackColor = SystemColors.Control
                panelJuarezRightWeapon.BackColor = Color.SeaGreen
                panelJuarezBothHands.BackColor = SystemColors.Control
                panelJuarezDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelJuarezDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelJuarezDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelJuarezDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelJuarezDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelJuarezDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelJuarezDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelJuarezLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelJuarezLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelJuarezRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelJuarezRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelJuarezBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelJuarezBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelJuarezBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelJuarezBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelJuarezBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelJuarezBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelJuarezBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoJuarez.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoJuarez.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoJuarez.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoJuarez.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoJuarez.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoJuarez.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoJuarez.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoJuarez.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoJuarez.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoJuarez.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoJuarez.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoJuarez.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoJuarez.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoJuarez.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoJuarez.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoJuarez.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoJuarez.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoJuarez.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoJuarez.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoJuarez.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoJuarez.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoJuarez.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoJuarez.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoJuarez.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsJuarez.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsJuarez.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsJuarez.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsJuarez.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsJuarez.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsJuarez.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsJuarez.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsJuarez.Text = "100"
            End If

        ElseIf ClaseEditando = "Miner" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelMinerLeftWeapon.BackColor = SystemColors.Control
                panelMinerRightWeapon.BackColor = SystemColors.Control
                panelMinerBothHands.BackColor = Color.SeaGreen
                panelMinerDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelMinerLeftWeapon.BackColor = Color.SeaGreen
                panelMinerRightWeapon.BackColor = Color.SeaGreen
                panelMinerBothHands.BackColor = SystemColors.Control
                panelMinerDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelMinerLeftWeapon.BackColor = SystemColors.Control
                panelMinerRightWeapon.BackColor = Color.SeaGreen
                panelMinerBothHands.BackColor = SystemColors.Control
                panelMinerDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelMinerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelMinerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelMinerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelMinerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelMinerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelMinerDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelMinerLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelMinerLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelMinerRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelMinerRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelMinerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelMinerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelMinerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelMinerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelMinerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelMinerBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelMinerBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoMiner.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoMiner.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoMiner.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoMiner.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoMiner.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoMiner.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoMiner.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoMiner.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoMiner.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoMiner.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoMiner.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoMiner.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoMiner.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoMiner.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoMiner.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoMiner.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoMiner.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoMiner.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoMiner.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoMiner.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoMiner.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoMiner.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoMiner.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoMiner.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsMiner.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsMiner.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsMiner.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsMiner.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsMiner.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsMiner.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsMiner.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsMiner.Text = "100"
            End If

        ElseIf ClaseEditando = "Rifleman" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelRiflemanLeftWeapon.BackColor = SystemColors.Control
                panelRiflemanRightWeapon.BackColor = SystemColors.Control
                panelRiflemanBothHands.BackColor = Color.SeaGreen
                panelRiflemanDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelRiflemanLeftWeapon.BackColor = Color.SeaGreen
                panelRiflemanRightWeapon.BackColor = Color.SeaGreen
                panelRiflemanBothHands.BackColor = SystemColors.Control
                panelRiflemanDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelRiflemanLeftWeapon.BackColor = SystemColors.Control
                panelRiflemanRightWeapon.BackColor = Color.SeaGreen
                panelRiflemanBothHands.BackColor = SystemColors.Control
                panelRiflemanDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelRiflemanDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelRiflemanDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelRiflemanDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelRiflemanDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelRiflemanDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelRiflemanDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelRiflemanLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelRiflemanLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelRiflemanRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelRiflemanRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelRiflemanBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelRiflemanBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelRiflemanBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelRiflemanBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelRiflemanBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelRiflemanBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelRiflemanBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoRifleman.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoRifleman.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoRifleman.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoRifleman.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoRifleman.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoRifleman.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoRifleman.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoRifleman.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoRifleman.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoRifleman.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoRifleman.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoRifleman.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoRifleman.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoRifleman.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoRifleman.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoRifleman.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoRifleman.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoRifleman.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoRifleman.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoRifleman.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoRifleman.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoRifleman.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoRifleman.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoRifleman.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsRifleman.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsRifleman.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsRifleman.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsRifleman.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsRifleman.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsRifleman.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsRifleman.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsRifleman.Text = "100"
            End If

        ElseIf ClaseEditando = "Sniper" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelSniperLeftWeapon.BackColor = SystemColors.Control
                panelSniperRightWeapon.BackColor = SystemColors.Control
                panelSniperBothHands.BackColor = Color.SeaGreen
                panelSniperDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelSniperLeftWeapon.BackColor = Color.SeaGreen
                panelSniperRightWeapon.BackColor = Color.SeaGreen
                panelSniperBothHands.BackColor = SystemColors.Control
                panelSniperDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelSniperLeftWeapon.BackColor = SystemColors.Control
                panelSniperRightWeapon.BackColor = Color.SeaGreen
                panelSniperBothHands.BackColor = SystemColors.Control
                panelSniperDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelSniperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelSniperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelSniperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelSniperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelSniperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelSniperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelSniperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelSniperLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelSniperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelSniperRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelSniperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelSniperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelSniperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelSniperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelSniperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelSniperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelSniperBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoSniper.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoSniper.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoSniper.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoSniper.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoSniper.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoSniper.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoSniper.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoSniper.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoSniper.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoSniper.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoSniper.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoSniper.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoSniper.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoSniper.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoSniper.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoSniper.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoSniper.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoSniper.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoSniper.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoSniper.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoSniper.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoSniper.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoSniper.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoSniper.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsSniper.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsSniper.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsSniper.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsSniper.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsSniper.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsSniper.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsSniper.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsSniper.Text = "100"
            End If

        ElseIf ClaseEditando = "Thief" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelThiefLeftWeapon.BackColor = SystemColors.Control
                panelThiefRightWeapon.BackColor = SystemColors.Control
                panelThiefBothHands.BackColor = Color.SeaGreen
                panelThiefDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelThiefLeftWeapon.BackColor = Color.SeaGreen
                panelThiefRightWeapon.BackColor = Color.SeaGreen
                panelThiefBothHands.BackColor = SystemColors.Control
                panelThiefDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelThiefLeftWeapon.BackColor = SystemColors.Control
                panelThiefRightWeapon.BackColor = Color.SeaGreen
                panelThiefBothHands.BackColor = SystemColors.Control
                panelThiefDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelThiefDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelThiefDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelThiefDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelThiefDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelThiefDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelThiefDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelThiefLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelThiefLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelThiefRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelThiefRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelThiefBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelThiefBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelThiefBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelThiefBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelThiefBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelThiefBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelThiefBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoThief.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoThief.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoThief.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoThief.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoThief.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoThief.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoThief.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoThief.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoThief.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoThief.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoThief.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoThief.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoThief.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoThief.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoThief.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoThief.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoThief.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoThief.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoThief.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoThief.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoThief.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoThief.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoThief.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoThief.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsThief.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsThief.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsThief.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsThief.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsThief.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsThief.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsThief.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsThief.Text = "100"
            End If

        ElseIf ClaseEditando = "Trapper" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelTrapperLeftWeapon.BackColor = SystemColors.Control
                panelTrapperRightWeapon.BackColor = SystemColors.Control
                panelTrapperBothHands.BackColor = Color.SeaGreen
                panelTrapperDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelTrapperLeftWeapon.BackColor = Color.SeaGreen
                panelTrapperRightWeapon.BackColor = Color.SeaGreen
                panelTrapperBothHands.BackColor = SystemColors.Control
                panelTrapperDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelTrapperLeftWeapon.BackColor = SystemColors.Control
                panelTrapperRightWeapon.BackColor = Color.SeaGreen
                panelTrapperBothHands.BackColor = SystemColors.Control
                panelTrapperDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelTrapperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelTrapperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelTrapperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelTrapperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelTrapperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelTrapperDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelTrapperLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelTrapperLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelTrapperRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelTrapperRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelTrapperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelTrapperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelTrapperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelTrapperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelTrapperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelTrapperBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelTrapperBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoTrapper.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoTrapper.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoTrapper.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoTrapper.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoTrapper.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoTrapper.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoTrapper.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoTrapper.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoTrapper.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoTrapper.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoTrapper.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoTrapper.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoTrapper.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoTrapper.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoTrapper.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoTrapper.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoTrapper.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoTrapper.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoTrapper.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoTrapper.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoTrapper.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoTrapper.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoTrapper.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoTrapper.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsTrapper.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsTrapper.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsTrapper.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsTrapper.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsTrapper.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsTrapper.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsTrapper.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsTrapper.Text = "100"
            End If

        ElseIf ClaseEditando = "TW" Then


            If modIniTabla.Substring(0, 1) = 0 Then
                panelTWLeftWeapon.BackColor = SystemColors.Control
                panelTWRightWeapon.BackColor = SystemColors.Control
                panelTWBothHands.BackColor = Color.SeaGreen
                panelTWDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 1 Then
                panelTWLeftWeapon.BackColor = Color.SeaGreen
                panelTWRightWeapon.BackColor = Color.SeaGreen
                panelTWBothHands.BackColor = SystemColors.Control
                panelTWDynamite.BackColor = SystemColors.Control
            ElseIf modIniTabla.Substring(0, 1) = 2 Then
                panelTWLeftWeapon.BackColor = SystemColors.Control
                panelTWRightWeapon.BackColor = Color.SeaGreen
                panelTWBothHands.BackColor = SystemColors.Control
                panelTWDynamite.BackColor = Color.SeaGreen
            End If



            If modIniTabla.Substring(1, 1) = 0 Then

                panelTWDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\no_TNT.png"

            Else

                If modIniTabla.Substring(9, 1) = 0 Then panelTWDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\1_TNT.png"
                If modIniTabla.Substring(9, 1) = 1 Then panelTWDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\2_TNT.png"
                If modIniTabla.Substring(9, 1) = 2 Then panelTWDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\3_TNT.png"
                If modIniTabla.Substring(9, 1) = 3 Then panelTWDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\4_TNT.png"
                If modIniTabla.Substring(9, 1) = 4 Then panelTWDynamite.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\5_TNT.png"


            End If

            If modIniTabla.Substring(2, 1) = 0 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(2, 1) = 1 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(2, 1) = 2 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(2, 1) = 3 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(2, 1) = 4 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(2, 1) = 5 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(2, 1) = 6 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(2, 1) = 7 Then
                panelTWLeftWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(2, 1) = 8 Then
                panelTWLeftWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(3, 1) = 0 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Cogswell.png"
            ElseIf modIniTabla.Substring(3, 1) = 1 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Derringer.png"
            ElseIf modIniTabla.Substring(3, 1) = 2 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Lemant.png"
            ElseIf modIniTabla.Substring(3, 1) = 3 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Peacemaker.png"
            ElseIf modIniTabla.Substring(3, 1) = 4 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SawOff.png"
            ElseIf modIniTabla.Substring(3, 1) = 5 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Schofield.png"
            ElseIf modIniTabla.Substring(3, 1) = 6 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Volcanic.png"
            ElseIf modIniTabla.Substring(3, 1) = 7 Then
                panelTWRightWeapon.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Walker.png"
            ElseIf modIniTabla.Substring(3, 1) = 8 Then
                panelTWRightWeapon.ImageLocation = ""
            End If

            If modIniTabla.Substring(4, 1) = 0 Then
                panelTWBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Bow.png"
            ElseIf modIniTabla.Substring(4, 1) = 1 Then
                panelTWBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Remington.png"
            ElseIf modIniTabla.Substring(4, 1) = 2 Then
                panelTWBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Sharp.png"
            ElseIf modIniTabla.Substring(4, 1) = 3 Then
                panelTWBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\SharpScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 4 Then
                panelTWBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\Winchester.png"
            ElseIf modIniTabla.Substring(4, 1) = 5 Then
                panelTWBothHands.ImageLocation = Application.StartupPath & "\images\weaps\miniaturas\WinchesterScope.png"
            ElseIf modIniTabla.Substring(4, 1) = 6 Then
                panelTWBothHands.ImageLocation = ""
            End If

            If modIniTabla.Substring(5, 1) = 0 Then
                lblPistolAmmoTW.Text = "35"
            ElseIf modIniTabla.Substring(5, 1) = 1 Then
                lblPistolAmmoTW.Text = "45"
            ElseIf modIniTabla.Substring(5, 1) = 2 Then
                lblPistolAmmoTW.Text = "55"
            ElseIf modIniTabla.Substring(5, 1) = 3 Then
                lblPistolAmmoTW.Text = "65"
            ElseIf modIniTabla.Substring(5, 1) = 4 Then
                lblPistolAmmoTW.Text = "75"
            ElseIf modIniTabla.Substring(5, 1) = 5 Then
                lblPistolAmmoTW.Text = "85"
            ElseIf modIniTabla.Substring(5, 1) = 6 Then
                lblPistolAmmoTW.Text = "95"
            ElseIf modIniTabla.Substring(5, 1) = 7 Then
                lblPistolAmmoTW.Text = "100"
            End If

            If modIniTabla.Substring(6, 1) = 0 Then
                lblRifleAmmoTW.Text = "35"
            ElseIf modIniTabla.Substring(6, 1) = 1 Then
                lblRifleAmmoTW.Text = "45"
            ElseIf modIniTabla.Substring(6, 1) = 2 Then
                lblRifleAmmoTW.Text = "55"
            ElseIf modIniTabla.Substring(6, 1) = 3 Then
                lblRifleAmmoTW.Text = "65"
            ElseIf modIniTabla.Substring(6, 1) = 4 Then
                lblRifleAmmoTW.Text = "75"
            ElseIf modIniTabla.Substring(6, 1) = 5 Then
                lblRifleAmmoTW.Text = "85"
            ElseIf modIniTabla.Substring(6, 1) = 6 Then
                lblRifleAmmoTW.Text = "95"
            ElseIf modIniTabla.Substring(6, 1) = 7 Then
                lblRifleAmmoTW.Text = "100"
            End If

            If modIniTabla.Substring(7, 1) = 0 Then
                lblShotgunAmmoTW.Text = "35"
            ElseIf modIniTabla.Substring(7, 1) = 1 Then
                lblShotgunAmmoTW.Text = "45"
            ElseIf modIniTabla.Substring(7, 1) = 2 Then
                lblShotgunAmmoTW.Text = "55"
            ElseIf modIniTabla.Substring(7, 1) = 3 Then
                lblShotgunAmmoTW.Text = "65"
            ElseIf modIniTabla.Substring(7, 1) = 4 Then
                lblShotgunAmmoTW.Text = "75"
            ElseIf modIniTabla.Substring(7, 1) = 5 Then
                lblShotgunAmmoTW.Text = "85"
            ElseIf modIniTabla.Substring(7, 1) = 6 Then
                lblShotgunAmmoTW.Text = "95"
            ElseIf modIniTabla.Substring(7, 1) = 7 Then
                lblShotgunAmmoTW.Text = "100"
            End If

            If modIniTabla.Substring(8, 1) = 0 Then
                lblArrowsTW.Text = "35"
            ElseIf modIniTabla.Substring(8, 1) = 1 Then
                lblArrowsTW.Text = "45"
            ElseIf modIniTabla.Substring(8, 1) = 2 Then
                lblArrowsTW.Text = "55"
            ElseIf modIniTabla.Substring(8, 1) = 3 Then
                lblArrowsTW.Text = "65"
            ElseIf modIniTabla.Substring(8, 1) = 4 Then
                lblArrowsTW.Text = "75"
            ElseIf modIniTabla.Substring(8, 1) = 5 Then
                lblArrowsTW.Text = "85"
            ElseIf modIniTabla.Substring(8, 1) = 6 Then
                lblArrowsTW.Text = "95"
            ElseIf modIniTabla.Substring(8, 1) = 7 Then
                lblArrowsTW.Text = "100"
            End If

        End If

    End Sub

    Private Sub frmTablaConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmTablaConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        Me.Text = "Modding CoJ2 for Dedicated Servers - Setting Mod " & UCase(modName)

        If ModIniAristocrat <> "" Then ArmasClase(ModIniAristocrat, "Aristocrat")
        If ModIniBandit <> "" Then ArmasClase(ModIniBandit, "Bandit")
        If ModIniBarnsby <> "" Then ArmasClase(ModIniBarnsby, "Barnsby")
        If ModIniDoc <> "" Then ArmasClase(ModIniDoc, "Doc")
        If ModIniGunslinger <> "" Then ArmasClase(ModIniGunslinger, "Gunslinger")
        If ModIniGunsmith <> "" Then ArmasClase(ModIniGunsmith, "Gunsmith")
        If ModIniJuarez <> "" Then ArmasClase(ModIniJuarez, "Juarez")
        If ModIniMiner <> "" Then ArmasClase(ModIniMiner, "Miner")
        If ModIniRifleman <> "" Then ArmasClase(ModIniRifleman, "Rifleman")
        If ModIniSniper <> "" Then ArmasClase(ModIniSniper, "Sniper")
        If ModIniThief <> "" Then ArmasClase(ModIniThief, "Thief")
        If ModIniTrapper <> "" Then ArmasClase(ModIniTrapper, "Trapper")
        If ModIniTribeWarrior <> "" Then ArmasClase(ModIniTribeWarrior, "TW")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class