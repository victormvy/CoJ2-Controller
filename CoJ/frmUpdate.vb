' =================================================================================
' frmUpdate.vb - Self update form
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

Imports System.Net
Imports System.ComponentModel


Public Class frmUpdate

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        Dim megabytesIn As String = String.Format("{0:0.00}", bytesIn / 1048576)
        Dim totalMegabytes As String = String.Format("{0:0.00}", totalBytes / 1048576)

        lblFileSize.Text = megabytesIn.ToString.Trim & "/" & totalMegabytes.ToString.Trim & " Mb."
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub


    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Me.Close()
    End Sub

    Private Sub frmUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub


    Private Sub frmUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Dim sfd As New SaveFileDialog
        Dim client As WebClient = New WebClient


        ' If (Not sfd.ShowDialog() = DialogResult.OK) Then
        'Return
        ' End If


        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        Try
            client.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/u/89811799/setup_ModsCoJ.exe"), Application.StartupPath & "\setup_ModsCoJ.exe")
        Catch ex As Exception
            MsgBox("Unable to check for updates. Check your internet connection.")
        End Try
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFileSize.Text = ""
    End Sub
End Class
