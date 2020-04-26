' =================================================================================
' frmDownloads.vb - Download custom maps form
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
Imports System.Net
Imports System.ComponentModel


Public Class frmDownloads

    Dim reader As StreamReader
    Dim rutaServerMaps As String = ruta & "\CoJ2\Data\mapsnet\"

    Private Sub frmDownloads_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMain.Show()
        Me.Dispose()
    End Sub

    Private Sub frmDownloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(rutaServerMaps)

        Me.dgMaps.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDownloadingMap.Visible = False
        lblPercent.Visible = False
        ProgressBar1.Visible = False
        btnActualizar.Visible = True

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\downloadablemaps.txt") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\downloadablemaps.txt")
        End If

        Try
            If My.Computer.Network.IsAvailable Then
                My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/89811799/downloadablemaps.txt", Application.StartupPath & "\downloadablemaps.txt")
                Call ReaderFileMap()
            Else
                MessageBox.Show("Could not connect to the download server.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Could not connect to the download server.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End Try



    End Sub


    Private Sub ReaderFileMap()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\downloadablemaps.txt") Then
            dgMaps.Rows.Clear()
            Dim linea As String = ""
            Dim trozo As String = ""
            reader = File.OpenText(Application.StartupPath & "\downloadablemaps.txt")

            Do While reader.EndOfStream = False
                linea = reader.ReadLine()
                dgMaps.Rows.Add()
                For i = 0 To 3 'En cada linea tenemos que leer los tres campos(Nombre##Modos##Enlace##).
                    trozo = Mid(linea, 1, InStr(linea, "##") - 1)
                    linea = Mid(linea, InStr(linea, "##") + 2, linea.Length - (trozo.Length + 2))
                    If i = 3 And My.Computer.FileSystem.FileExists(rutaServerMaps & trozo) = True Then
                        dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(0).Value = "Yes"
                    Else
                        dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(0).Value = "No"
                    End If


                    dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(i + 1).Value = trozo
                Next

            Loop

            reader.Close()
        End If

    End Sub

    Private Sub dgMaps_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMaps.CellDoubleClick
        Process.Start("http://www.cojmodding.com/?id=maps&map=" & dgMaps.CurrentRow.Cells(3).Value)
    End Sub
    Dim arrayNombreMapa() As String
    Dim arrayUrlMapa() As String
    Dim numeroDescargas As Integer = 0
    Dim YaDescargados As Integer = 0
    Dim MapasCompletados As String = ""
    Dim MapasNoDescargados As String = ""
    Dim Cancelado As Boolean = False
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim i = dgMaps.SelectedRows.Count - 1
        Do While i > -1
            If dgMaps.SelectedRows(i).Cells(0).Value = "Yes" Then
                dgMaps.SelectedRows(i).Selected = False
            End If
            i = i - 1
        Loop
        If dgMaps.SelectedRows.Count = 0 Then
            Exit Sub
        End If


        If numeroDescargas = YaDescargados Then
            ReDim arrayNombreMapa(dgMaps.SelectedRows.Count)
            ReDim arrayUrlMapa(dgMaps.SelectedRows.Count)
            numeroDescargas = 0
            YaDescargados = 0
            MapasCompletados = ""
            MapasNoDescargados = ""
            Cancelado = False
            For i = 0 To dgMaps.SelectedRows.Count - 1
                arrayNombreMapa(i) = dgMaps.SelectedRows(i).Cells(4).Value
                arrayUrlMapa(i) = dgMaps.SelectedRows(i).Cells(3).Value
            Next
            numeroDescargas = dgMaps.SelectedRows.Count
            btnDownload.Text = "CANCEL"
            Call DownloadMap(arrayUrlMapa(YaDescargados), arrayNombreMapa(YaDescargados))

        Else ' Cuando estamos descargando, cancela.
            btnDownload.Text = "DOWNLOAD NOW"
            lblDownloadingMap.Visible = False
            lblPercent.Visible = False
            ProgressBar1.Visible = False
            btnActualizar.Visible = True

            Cancelado = True
            MyWebClient.CancelAsync()

            MsgBox("Download cancelled", MsgBoxStyle.Information)
            numeroDescargas = 0
            YaDescargados = 0
            If My.Computer.FileSystem.FileExists(rutaServerMaps & arrayNombreMapa(YaDescargados)) Then
                My.Computer.FileSystem.DeleteFile(rutaServerMaps & arrayNombreMapa(YaDescargados))
            End If
            Call ReaderFileMap()
        End If
    End Sub

    Private Sub DownloadProgressCallback(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        ProgressBar1.Maximum = e.TotalBytesToReceive
        ProgressBar1.Value = e.BytesReceived
        lblDownloadingMap.Text = "Downloading file: " & arrayNombreMapa(YaDescargados) & "   File: " & (YaDescargados + 1).ToString & "/" & numeroDescargas.ToString
        lblPercent.Text = e.ProgressPercentage & "%"

        '  Displays the operation identifier, and the transfer progress.
        ' MsgBox(CStr(e.UserState) & "    downloaded " & e.BytesReceived & " of " & e.TotalBytesToReceive & " bytes. " & e.ProgressPercentage & " % complete...")
    End Sub


    Private Sub DownloadFileCallback2(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)

        YaDescargados = YaDescargados + 1
        If numeroDescargas = YaDescargados Then
            If Cancelado = False Then
                lblDownloadingMap.Visible = False
                lblPercent.Visible = False
                ProgressBar1.Visible = False
                btnActualizar.Visible = True
                If MapasNoDescargados.Trim <> "" Then MapasNoDescargados = "Files not downloaded: " & MapasNoDescargados
                If MapasCompletados.Trim <> "" Then MapasCompletados = "Files completed: " & MapasCompletados
                Call ReaderFileMap()
                Call CopiarMapas()
                MsgBox("Completed download. " & MapasCompletados & vbCrLf & vbCrLf & MapasNoDescargados & vbCrLf & "Downloaded maps are now available" & vbCrLf & "in Server Config > Custom Maps.", MsgBoxStyle.Information)
                btnDownload.Text = "DOWNLOAD NOW"
                Exit Sub
            End If
        ElseIf numeroDescargas <> YaDescargados And numeroDescargas > YaDescargados Then
            If Cancelado = False Then
                Call DownloadMap(arrayUrlMapa(YaDescargados), arrayNombreMapa(YaDescargados))

            ElseIf Cancelado = True And YaDescargados = numeroDescargas Then
                Cancelado = False

            End If

        ElseIf numeroDescargas > YaDescargados = False Then
            numeroDescargas = 0
            YaDescargados = 0
        End If
    End Sub
    Dim MyWebClient As New WebClient
    Private Sub DownloadMap(url As String, file As String)


        Try
            AddHandler MyWebClient.DownloadFileCompleted, AddressOf DownloadFileCallback2
            AddHandler MyWebClient.DownloadProgressChanged, AddressOf DownloadProgressCallback
            If My.Computer.FileSystem.FileExists(rutaServerMaps & file) = False Then
                MyWebClient.DownloadFileAsync(New Uri("http://www.cojmodding.com/?id=maps&download=" & url), rutaServerMaps & file)
                lblDownloadingMap.Visible = True
                lblPercent.Visible = True
                ProgressBar1.Visible = True
                btnActualizar.Visible = False
                MapasCompletados = MapasCompletados & vbCrLf & file
            Else
                YaDescargados = YaDescargados + 1
                If numeroDescargas <= YaDescargados Then
                    btnDownload.Text = "DOWNLOAD NOW"
                End If
                MapasNoDescargados = MapasNoDescargados & vbCrLf & file
                If numeroDescargas = YaDescargados Then
                    lblDownloadingMap.Visible = False
                    lblPercent.Visible = False
                    ProgressBar1.Visible = False
                    btnActualizar.Visible = True
                    If MapasNoDescargados.Trim <> "" Then MapasNoDescargados = "Files not downloaded: " & MapasNoDescargados
                    If MapasCompletados.Trim <> "" Then MapasCompletados = "Files completed: " & MapasCompletados
                    Call ReaderFileMap()
                    Call CopiarMapas()
                    MsgBox("Completed download. " & MapasCompletados & vbCrLf & vbCrLf & MapasNoDescargados & vbCrLf & "Downloaded maps are now available" & vbCrLf & "in Server Config > Custom Maps.", MsgBoxStyle.Information)
                    btnDownload.Text = "DOWNLOAD NOW"
                    Exit Sub
                Else
                    If Cancelado = False Then
                        Call DownloadMap(arrayUrlMapa(YaDescargados), arrayNombreMapa(YaDescargados))

                    ElseIf Cancelado = True And YaDescargados = numeroDescargas Then
                        Cancelado = False

                    End If
                End If
            End If
        Catch ex As Exception
            MapasNoDescargados = MapasNoDescargados & vbCrLf & file
            'MessageBox.Show("Could not connect to the download server.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Call ReaderFileMap()
    End Sub

    Private Sub CopiarMapas()
        Dim rutaMapasClient As String = ""

        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Ubisoft\Techland\Call of Juarez - Bound in Blood") Then
            rutaMapasClient = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Ubisoft\Techland\Call of Juarez - Bound in Blood"
        End If

        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & " (x86)\Ubisoft\Techland\Call of Juarez - Bound in Blood") Then
            rutaMapasClient = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & " (x86)\Ubisoft\Techland\Call of Juarez - Bound in Blood"
        End If

        If rutaMapasClient = "" Then
            Exit Sub
        Else
            rutaMapasClient = rutaMapasClient & "\CoJ2\Data\MapsNet\"
            My.Computer.FileSystem.CreateDirectory(rutaMapasClient)
        End If

        For i = 0 To arrayNombreMapa.Count - 1
            If My.Computer.FileSystem.FileExists(rutaServerMaps & arrayNombreMapa(i)) Then

                If My.Computer.FileSystem.FileExists(rutaMapasClient & "\" & arrayNombreMapa(i)) Then
                    My.Computer.FileSystem.DeleteFile(rutaMapasClient & "\" & arrayNombreMapa(i))
                End If

                My.Computer.FileSystem.CopyFile(rutaServerMaps & arrayNombreMapa(i), rutaMapasClient & "\" & arrayNombreMapa(i))
            End If
        Next

    End Sub
End Class