' =================================================================================
' ClosingServer.vb - Closing server progress form
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

Imports System.Environment
Imports System.IO

Public Class frmClosingServer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Declare Function SendMessageSTRING Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
    Private Const WM_CHAR = &H102
    Private Declare Function SendMessageAsLong Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer

    ' Constante para los mensajes

    ' Recupera en un buffer el texto de la linea
    Const EM_GETLINE As Integer = &HC4
    ' Recupera la cantidad de lineas
    Const EM_GETLINECOUNT As Integer = &HBA



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CerrarServidor = False
        Me.Close()
        Me.Dispose()
    End Sub


    Dim btnApagadoPulsado As Boolean = False
    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        btnShutdown.Enabled = False
        btnCancel.Enabled = False
        SumaBarra = (PanelProgresBar.Width - 2) / 80
        btnApagadoPulsado = True
        Timershutdown.Enabled = True
        Label1.Text = "Coj2 Dedicated Server is shutting down"
        Timershutdown.Enabled = True

        Dim vText As String = "/servershutdown"
        Dim vHwnd As Integer = FindWindow("ConsoleWindowClass", vbNullString)

        For i As Integer = 1 To Len(vText)
            SendMessageSTRING(vHwnd, WM_CHAR, Asc(Mid(vText, i, 1)), 0&)
        Next i

        SendMessageSTRING(vHwnd, WM_CHAR, Asc(vbCr), 0&)
        SendMessageSTRING(vHwnd, WM_CHAR, Asc(vbLf), 0&)

        CerrarServidor = True
    End Sub


    Private Sub frmClosingServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnApagadoPulsado = False Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Dim countDown As Integer = 85
    Dim SumaBarra As Double = 0
    Dim Rojo As Double = 255
    Dim Verde As Double = 30
    Dim SumaResta As Double = (Rojo - Verde) / (countDown - 30)
    Private Sub Timershutdown_Tick(sender As Object, e As EventArgs) Handles Timershutdown.Tick
        If countDown < (55) Then
            Rojo = Rojo - SumaResta
            Verde = Verde + SumaResta
        End If


        If countDown = -1 Then
            Timershutdown.Enabled = False
            Me.Close()
            Me.Dispose()
            FrmMain.Show()
        Else
            FrmMain.Hide()
            If Verde < 256 Then
                lblProgressBarr.BackColor = System.Drawing.Color.FromArgb(Int(Rojo), Int(Verde), 30)
            End If
            lblProgressBarr.Width = (lblProgressBarr.Width + Int(SumaBarra))

            If Mid(countDown.ToString.Trim, 2, 1) = "0" Then
                Label1.Text = Label1.Text & "."
                btnShutdown.Text = "Shutdown (" & (countDown / 10).ToString.Trim & ")"
            End If
            countDown = countDown - 1
        End If
    End Sub

    Private Sub frmClosingServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProgressBarr.Width = 0
    End Sub

    Private Sub frmClosingServer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FrmMain.Hide()
        frmConsola.Hide()
    End Sub
End Class