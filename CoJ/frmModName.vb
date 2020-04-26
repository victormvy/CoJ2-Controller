' =================================================================================
' frmModName.vb - Mod name input form
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

Public Class frmModName


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtModName.Text <> "" Then

            modName = txtModName.Text

            Me.Close()
        Else
            MsgBox("You must set your mod name", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelModName = True
        Me.Close()
    End Sub

    Private Sub txtModName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub frmModName_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtModName.Focus()
    End Sub


    Private Sub frmModName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModName.Clear()
    End Sub
End Class