' =================================================================================
' frmDeleteMods.vb - Delete mods form
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

Public Class frmDeleteMods

    Private Sub frmDeleteMods_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmDeleteMods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbDeleteMods.Items.Clear()

        For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(rutaAppData & "\Mods\")

            Dim lengthRuta As Integer = foundDirectory.Length
            Dim FirstCharacter As Integer = foundDirectory.IndexOf("Mods\")
            Dim nameDirectory As String = foundDirectory.Substring(FirstCharacter + 5)


            lbDeleteMods.Items.Add(nameDirectory)


        Next

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lbDeleteMods.SelectedItems.Count > 0 Then
            Dim msgBorrarBackup = MsgBox("Do you want to delete " & lbDeleteMods.SelectedItems.Count & " mod(s) selected?", MsgBoxStyle.YesNo)
            If msgBorrarBackup = vbYes Then

                For i = 0 To lbDeleteMods.SelectedItems.Count - 1
                    If My.Computer.FileSystem.DirectoryExists(rutaAppData & "\Mods\" & lbDeleteMods.SelectedItems.Item(i)) Then
                        My.Computer.FileSystem.DeleteDirectory(rutaAppData & "\Mods\" & lbDeleteMods.SelectedItems.Item(i), FileIO.DeleteDirectoryOption.DeleteAllContents)


                    End If
                Next
            End If

        End If

        lbDeleteMods.Items.Clear()

        For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(rutaAppData & "\Mods\")

            Dim lengthRuta As Integer = foundDirectory.Length
            Dim FirstCharacter As Integer = foundDirectory.IndexOf("Mods\")
            Dim nameDirectory As String = foundDirectory.Substring(FirstCharacter + 5)


            lbDeleteMods.Items.Add(nameDirectory)


        Next



    End Sub
End Class