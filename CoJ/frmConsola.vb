' =================================================================================
' frmConsole.vb - Server console form
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

Public Class frmConsola
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

    ' Hwnd de la ventana
    Dim FormCargado As Boolean = False
    Dim LoadingMap As Boolean = True
    Dim commandActivAdLin1 As String = ""
    Dim commandActivAdLin2 As String = ""
    Dim commandActivAdLin3 As String = ""
    Dim commandActivGeneral As String = ""
    Dim GameUnbalanced As Boolean = False
    Dim btnApagarPulsado As Boolean = False

    Private Sub btnEnviar_Click() Handles btnEnviar.Click
        SendToConsole(cboxMess.Text.Trim & " " & txtEnviaTexto.Text.Trim)
        txtEnviaTexto.Text = ""
        TimerReadConsoleInst.Enabled = True
    End Sub

    Private Sub frmConsola_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        vHwnd = FindWindow("ConsoleWindowClass", vbNullString)
        If vHwnd > 0 Then
            If btnApagarPulsado = False Then
                If vApagado <> "restart" And vRestart = False Then
                    frmClosingServer.Show()
                End If
                If CerrarServidor = False Then
                    e.Cancel = True
                    Me.Show()
                ElseIf CerrarServidor = True Then
                    vRestart = False
                    Me.Dispose()
                    FrmMain.Show()
                Else 'Colocado este bucle porque hay veces que la aplicación se queda colgada y oculta, a ver si deja de pasar
                    Application.ExitThread()
                End If

            ElseIf btnApagarPulsado = True Then
                Me.Dispose()
                FrmMain.Show()

            End If
            'SendToConsole("/servershutdown")
        ElseIf vHwnd = 0 And btnApagarPulsado = True Then
            Me.Dispose()
            FrmMain.Show()

        Else 'Colocado este bucle porque hay veces que la aplicación se queda colgada y oculta, a ver si deja de pasar
            Application.ExitThread()
        End If

    End Sub


    Private Sub frmConsola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgPlayersWarned.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 6.886957!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Logs")

        Me.TopLevel = True
        lbConsola.Items.Add(Mid(Date.Now, InStr(Date.Now, " ") + 1, 8) & " ********* STARTING SERVER *********")
        Call ReadFileMsg()
        Call ReadFilePlayer()
        Call ReadFileAdmin()
        Call ReadMaps()
        Call LoadListLogs()
        Call ReadFileCommand()
        Call CreaListaComandosActivos()
        Call ReadCheckMaps()
        Call ReadFileTabRules()

        If chkMess1.Checked = True Then
            Timer1.Enabled = True
        End If
        If chkMess2.Checked = True Then
            Timer2.Enabled = True
        End If
        If chkMess3.Checked = True Then
            Timer3.Enabled = True
        End If

    End Sub

    Private Sub frmConsola_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If TimerLoad.Enabled = False Then TimerLoad.Enabled = True
        Me.SendToBack()
        Me.Focus()
        Me.BringToFront()
        lblQuantityLogs.Text = (lbLogFilesList.SelectedIndex + 1).ToString.Trim & "/" & (lbLogFilesList.Items.Count).ToString.Trim
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtAdMess1.Text.Trim = "" Then
            Exit Sub
        End If

        If Val(txtAdMessTime1.Text.Trim) = 0 Then
            Timer1.Enabled = False
            Exit Sub
        Else
            Timer1.Interval = Val(txtAdMessTime1.Text.Trim) * 1000
            'Dim vHwnd As Integer
            Dim vTexto As String = "/adminsay " & txtAdMess1.Text.Trim

            If LoadingMap = False Then SendToConsole(vTexto)
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If txtAdMess2.Text.Trim = "" Then
            Exit Sub
        End If

        If Val(txtAdMessTime2.Text.Trim) = 0 Then
            Timer2.Enabled = False
            Exit Sub
        Else
            Timer2.Interval = Val(txtAdMessTime2.Text.Trim) * 1000
            'Dim vHwnd As Integer
            Dim vTexto As String = "/adminsay " & txtAdMess2.Text.Trim
            If LoadingMap = False Then SendToConsole(vTexto)
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If txtAdMess3.Text.Trim = "" Then
            Exit Sub
        End If

        If Val(txtAdMessTime3.Text.Trim) = 0 Then
            Timer3.Enabled = False
            Exit Sub
        Else
            Timer3.Interval = Val(txtAdMessTime3.Text.Trim) * 1000
            'Dim vHwnd As Integer
            Dim vTexto As String = ""

            If cboxCabMess3.Text = "/mapnext" Or cboxCabMess3.Text = "/playerlist" Then
                vTexto = cboxCabMess3.Text
            Else
                vTexto = cboxCabMess3.Text & " " & txtAdMess3.Text.Trim
            End If

            If LoadingMap = False Then SendToConsole(vTexto)
        End If

    End Sub


    Dim TimeClose As Integer = 0
    Dim vApagado As String = ""
    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        btnApagarPulsado = True
        vApagado = "shutdown"
        TimerCountDown.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        TimerLoad.Enabled = False
        TimerReadConsole.Enabled = False
        TimerReadConsoleInst.Enabled = False
        'TimerReadPlayer.Enabled = False
        TimeClose = 15
    End Sub


    Private Sub chkMess1_CheckedChanged(sender As Object, e As EventArgs) Handles chkMess1.CheckedChanged
        If chkMess1.Checked = True Then
            If txtAdMessTime1.Text.Trim = "0" Or txtAdMessTime1.Text = "" Then
                txtAdMessTime1.Text = "30"
            End If
            Timer1.Interval = Val(txtAdMessTime1.Text.Trim) * 1000
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub chkMess2_CheckedChanged(sender As Object, e As EventArgs) Handles chkMess2.CheckedChanged
        If chkMess2.Checked = True Then
            If txtAdMessTime2.Text.Trim = "0" Or txtAdMessTime2.Text = "" Then
                txtAdMessTime2.Text = "30"
            End If
            Timer2.Interval = Val(txtAdMessTime2.Text) * 1000
            Timer2.Enabled = True
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub chkMess3_CheckedChanged(sender As Object, e As EventArgs) Handles chkMess3.CheckedChanged
        If chkMess3.Checked = True Then
            If txtAdMessTime3.Text.Trim = "0" Or txtAdMessTime3.Text = "" Then
                txtAdMessTime3.Text = "30"
            End If
            Timer3.Interval = Val(txtAdMessTime3.Text.Trim) * 1000
            Timer3.Enabled = True
        Else
            Timer3.Enabled = False
        End If

    End Sub

    'Private Sub TimerShutDown_Tick(sender As Object, e As EventArgs) Handles TimerShutDown.Tick
    '    TimerShutDown.Enabled = False
    '    Me.Close()
    'End Sub

    Dim warningShutdown As Integer = 5
    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        warningShutdown = warningShutdown - 1
        TimeClose = TimeClose - 1
        If TimeClose = -1 Then
            TimerCountDown.Enabled = False
            Me.Close()
        End If
        If TimeClose = 10 Then
            SendToConsole("/adminsay Starting to " & vApagado)
            SendToConsole("/servershutdown")
            Call writeLog()
        End If
        If TimeClose <= 10 And vApagado = "shutdown" Then
            vRestart = False
            btnShutdown.Text = "Shutdown (" & TimeClose.ToString.Trim & "s.)"
            If TimeClose = 9 Or TimeClose = 7 Or TimeClose = 5 Then
                Exit Sub
            End If
            lbConsola.Items.Add(Mid(Date.Now, InStr(Date.Now, " ") + 1, 8) & " " & "*****Shutting down in " & TimeClose & " seconds")
            lbConsola.SelectedIndex = (lbConsola.Items.Count - 1)
        ElseIf TimeClose <= 10 And vApagado = "restart" Then
            vRestart = True
            If TimeClose = 9 Or TimeClose = 7 Or TimeClose = 5 Then
                Exit Sub
            End If
            lbConsola.Items.Add(Mid(Date.Now, InStr(Date.Now, " ") + 1, 8) & " " & "*****Restarting in " & TimeClose & " seconds")
            lbConsola.SelectedIndex = (lbConsola.Items.Count - 1)
        ElseIf TimeClose > 10 Then
            SendToConsole("/adminsay Server is going to " & vApagado & " in " & warningShutdown & " seconds")
        End If

    End Sub

    Dim rutaLog As String = ""
    Private Sub writeLog()
        Dim Mes As String = Date.Now.Month.ToString
        Dim Dia As String = Date.Now.Day.ToString
        Dim Hora As String = Date.Now.Hour.ToString
        Dim Minuto As String = Date.Now.Minute.ToString
        Dim Segundo As String = Date.Now.Second.ToString

        If Len(Mes) = 1 Then Mes = "0" & Mes
        If Len(Dia) = 1 Then Dia = "0" & Dia
        If Len(Hora) = 1 Then Hora = "0" & Hora
        If Len(Minuto) = 1 Then Minuto = "0" & Minuto
        If Len(Segundo) = 1 Then Segundo = "0" & Segundo

        Dim FileLog As String = Date.Now.Year.ToString & "-" & Mes & "-" & Dia & "-" & Hora & "-" & Minuto & "-" & Segundo & "_console.log"
        rutaLog = Application.StartupPath & "\Logs"
        My.Computer.FileSystem.CreateDirectory(rutaLog)
        Call DeleLog()

        writer = File.AppendText(rutaLog & "\" & FileLog)

        For i = 0 To lbConsola.Items.Count - 1
            writer.WriteLine(lbConsola.Items(i))
        Next

        writer.Close()
    End Sub

    Private Sub DeleLog()
        Dim UltimoBackupExistente As String = ""

        Dim CantidadLogS As Integer = 0

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(rutaLog)

            If foundFile.EndsWith(".log") Then
                CantidadLogS = CantidadLogS + 1
            End If

        Next

        'Mantendremos los ultimos 40 ficheros Console Logs
        Dim CantidadDeArchivosABorrar = CantidadLogS - 49
        If CantidadDeArchivosABorrar < 0 Then CantidadDeArchivosABorrar = 0

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(rutaLog)
            Dim lengthRuta As Integer = rutaLog.Length
            Dim nameFile As String = foundFile.Substring(lengthRuta + 1).ToString()

            Dim Extension As String = ""
            If nameFile.Length > 5 Then Extension = nameFile.Substring(nameFile.Length - 4, 4)

            If CantidadDeArchivosABorrar > 0 Then
                My.Computer.FileSystem.DeleteFile(rutaLog & "\" & nameFile)
                CantidadDeArchivosABorrar = CantidadDeArchivosABorrar - 1
            End If
        Next
    End Sub


    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        vApagado = "restart"
        'Usamos la variable "vRestart" (booleana) pública declarada en Module1
        'para desde frmArmas controlar que hay que volver a iniciar el server
        vRestart = True
        TimerCountDown.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        TimerLoad.Enabled = False
        TimerReadConsole.Enabled = False
        TimerReadConsoleInst.Enabled = False
        TimeClose = 15
    End Sub

    Dim copiaCrash As String = ""
    Dim rutaCrashLog As String = ""
    'Dim NombreVentana = ruta & "\" & "CoJ2Game_x86_ds.exe"
    'Dim NombreVentana = Application.StartupPath & "\" & "CoJMods.Vshost.exe"
    'Dim HwndEscritura As String
    Private Sub TimerLoad_Tick(sender As Object, e As EventArgs) Handles TimerLoad.Tick
        'Buscar la ventana del servidor
        vHwnd = FindWindow("ConsoleWindowClass", vbNullString)
        ' FindWindowEx(   , 0, "ConsoleWindowClass", vbNullString)

        'Dim ret2 = FindWindowEx(0, 0, vbNullString, NombreVentana)
        'HwndEscritura = FindWindowEx(0, 0, "techland_game_class", vbNullString)

        If vHwnd = 0 Then
            ' MsgBox("Error. El Hwnd es 0 ", vbCritical)
        Else
            TimerLoad.Enabled = False
            btnEnviar.Enabled = True
            btnShutdown.Enabled = True
            btnRestart.Enabled = True
            btnMapNext.Enabled = True
            btnPlayerList.Enabled = True
            lbConsola.Enabled = True
            txtEnviaTexto.Enabled = True
            PanelAdminMess.Enabled = True
            txtAdMess1.Enabled = True
            txtAdMess2.Enabled = True
            txtAdMess3.Enabled = True
            txtAdMessTime1.Enabled = True
            txtAdMessTime2.Enabled = True
            txtAdMessTime3.Enabled = True
            chkMess1.Enabled = True
            chkMess2.Enabled = True
            chkMess3.Enabled = True
            cboxCabMess3.Enabled = True
            PanelAdmins.Enabled = True
            PanelPlayer.Enabled = True
            FormCargado = True
        End If

        '************Buscamos fichero salida consola*************
        rutaTemp = GetFolderPath(SpecialFolder.ApplicationData)
        rutaCrashLog = Mid(rutaTemp, 1, (Len(rutaTemp) - 8)) & "\Local\VirtualStore\Program Files (x86)\techland\out\crash.log"
        copiaCrash = Mid(rutaTemp, 1, (Len(rutaTemp) - 8)) & "\Local\VirtualStore\Program Files (x86)\techland\out\copiacrash.log"
        'MsgBox(rutaCrashLog)
        If My.Computer.FileSystem.FileExists(rutaCrashLog) Then
            TimerReadConsole.Enabled = True
        Else
            rutaCrashLog = Mid(rutaTemp, 1, (Len(rutaTemp) - 8)) & "\Local\VirtualStore\Program Files\techland\out\crash.log"
            copiaCrash = Mid(rutaTemp, 1, (Len(rutaTemp) - 8)) & "\Local\VirtualStore\Program Files\techland\out\copiacrash.log"
            If My.Computer.FileSystem.FileExists(rutaCrashLog) Then
                TimerReadConsole.Enabled = True
            Else
                rutaCrashLog = ruta & "\CoJ2\out\logs\crash.log"
                copiaCrash = ruta & "\CoJ2\out\logs\copiacrash.log"
                If My.Computer.FileSystem.FileExists(rutaCrashLog) Then
                    TimerReadConsole.Enabled = True
                Else
                    MsgBox("File not found. You have to reinstall Coj Dedicated Server")
                    SendToConsole("/servershutdown")
                    Me.Close()
                End If
            End If
        End If
        If My.Computer.FileSystem.FileExists(copiaCrash) Then
            My.Computer.FileSystem.DeleteFile(copiaCrash)
        End If
    End Sub


    Dim tiempoMapaActivado As Boolean = False
    Dim contaLineas As Integer = 0
    Dim reader As StreamReader
    Dim readerConfig As StreamReader
    Dim lineaLeida As String = ""
    Dim minutes As Integer = 0
    'Dim totalMinutes As Integer = 0
    Dim seconds As Integer = 59 'Empezamos con 11 segundos de sobra mientras se incorporan jugadores
    Dim ciclosSinContar = 4
    Dim reactivaHwnd As Integer = 0
    Private Sub TimerReadConsole_Tick(sender As Object, e As EventArgs) Handles TimerReadConsole.Tick

        'Cada vez que llegamos a 100 (5m.) reactivamos el Hwnd
        If reactivaHwnd = 100 Then  '(100 x 3 = 300 segundos)
            vHwnd = FindWindow("ConsoleWindowClass", vbNullString)
            reactivaHwnd = 0
        Else
            reactivaHwnd = reactivaHwnd + 1
        End If


        'BORRAR: He movido la lectura a una rutina aparte porque se tendrá que leer desde más sitios
        LeerConsola()


        Dim ceros As String = ""
        'Control del tiempo que resta
        If tiempoMapaActivado = True And minutes > 0 Then
            'timeRemain = timeRemain - 3
            If seconds.ToString.Trim.Length = 1 Then
                ceros = "0"
            Else
                ceros = ""
            End If

            'Empezamos a contar hacia atrás 
            If ciclosSinContar <= 0 Then
                If ciclosSinContar = 0 Then
                    SendToConsole("/adminsay Starting - " & lblCurrentMap.Tag & "  (" & bountyOrPointsToShow & " / Time: " & (Int(timeRemain / 60)).ToString & "m.)")
                    SendToConsole("/adminsay Starting - " & lblCurrentMap.Tag & "  (" & bountyOrPointsToShow & " / Time: " & (Int(timeRemain / 60)).ToString & "m.)")
                End If
                lblTimeMap.Text = "Time Map : " & (Int(timeRemain / 60)).ToString & ":00 m."
                lblRemainTime.Text = "Rem. time : " & (minutes - 1).ToString & ":" & ceros & seconds & " m."
                seconds = seconds - 3
                If seconds = -1 Then
                    seconds = 59
                    minutes = minutes - 1
                End If
            End If

            'Esta variable volverá a tomar valor 4 (x3sec. = 12sec.) en la misma rutina
            'que toma la variable "minutes" el tiempo al cargar un nuevo mapa
            ciclosSinContar = ciclosSinContar - 1



        ElseIf tiempoMapaActivado = True And minutes = 0 Then
            lblRemainTime.Text = "0:00 m."
            tiempoMapaActivado = False
        End If

        'Controlamos si sigue abierto el Server
        Dim myProcesses() As Process
        Dim myProcess As Process
        Dim ExistProcess As Boolean = False
        myProcesses = Process.GetProcesses()
        ' Iterate through the process array.
        For Each myProcess In myProcesses
            '  Console.WriteLine(myProcess.ProcessName)
            If myProcess.ProcessName = "CoJ2Game_x86_ds" Then
                ExistProcess = True
                Exit For
            End If
        Next

        'Si no existe el proceso mientras la consola está abierta
        'mandamos un reset
        If ExistProcess = False Then
            vRestart = True
            Me.Close()
        End If
    End Sub

    'Variables para el control de cambio de mapa  mNextVotesYes mNextPlayersVoted mNextNeededVotes mNextVoteIsActive
    Dim mNextVotesYes As Integer = 0
    Dim mNextPlayersVoted As String = ""
    Dim mNextNeededVotes As Integer = 0
    Dim mNextVoteIsActive As Boolean = False
    Dim changedTeam As Boolean = False
    Dim playerInVote As String = ""

    Private Sub LeerConsola()
        Dim addConsole As Boolean = False
        'changedTeam = False
        Dim lineaPlayer As String = ""
        Dim PlayerLeido As String = ""
        Dim PlayerJoinOrLeave As String = ""
        TimerReadConsole.Enabled = False

        If My.Computer.FileSystem.FileExists(copiaCrash) Then
            My.Computer.FileSystem.DeleteFile(copiaCrash)
        End If
        My.Computer.FileSystem.CopyFile(rutaCrashLog, copiaCrash)

        reader = File.OpenText(copiaCrash)
        For i = 0 To contaLineas
            If i = 0 And contaLineas = 0 Then Exit For
            reader.ReadLine()
        Next
        While reader.EndOfStream = False
            lineaLeida = reader.ReadLine()
            contaLineas = contaLineas + 1

            'Seleccionamos las líneas que añadiremos al listbox
            addConsole = False

            'If creado para que acepte los corchetes en los nombres de los jugadores
            If InStr(lineaLeida, "<") > 0 And InStr(lineaLeida, ">") > 0 Then

                If InStr(lineaLeida, "[") > 0 Or InStr(lineaLeida, "]") > 0 Then

                    If InStr(lineaLeida, "<") < InStr(lineaLeida, "[") And InStr(lineaLeida, ">") > InStr(lineaLeida, "[") Then


                        PlayerLeido = Mid(lineaLeida, InStr(lineaLeida, "<") + 1, InStr(lineaLeida, ">") - (InStr(lineaLeida, "<") + 1))
                        addConsole = True
                    End If

                    If InStr(lineaLeida, "<") < InStr(lineaLeida, "]") And InStr(lineaLeida, ">") > InStr(lineaLeida, "]") Then


                        PlayerLeido = Mid(lineaLeida, InStr(lineaLeida, "<") + 1, InStr(lineaLeida, ">") - (InStr(lineaLeida, "<") + 1))
                        addConsole = True
                    End If

                End If
            End If

            If InStr(lineaLeida, "<") > 0 And InStr(lineaLeida, ">") > 0 And InStr(lineaLeida, "::") = 0 And InStr(lineaLeida, "[") = 0 _
                                          And InStr(lineaLeida, "]") = 0 And InStr(lineaLeida, "Undeclared variable <") = 0 _
                                          And Mid(lineaLeida, 1, 8) <> "WARNING!" Then
                ' If InStr(lineaLeida, "!") > 0 Then
                PlayerLeido = Mid(lineaLeida, InStr(lineaLeida, "<") + 1, InStr(lineaLeida, ">") - (InStr(lineaLeida, "<") + 1))
                'End If
                addConsole = True
                '**************Control palabras prohibidas********************
                Dim RowPlayer As Integer = -1
                If Not lbAdmin.Items.Contains(PlayerLeido) Then

                    For i = 0 To lbWords.Items.Count - 1
                        If InStr(LCase(lineaLeida), lbWords.Items(i).ToString) > 0 Then
                            For u = 0 To dgPlayersWarned.Rows.Count - 1
                                If dgPlayersWarned.Rows(u).Cells(1).Value.ToString.Trim = PlayerLeido Then
                                    RowPlayer = u
                                    Exit For
                                End If
                            Next

                            'Si el jugador no estaba en la lista de avisados
                            If RowPlayer = -1 Then
                                dgPlayersWarned.Rows.Add()
                                RowPlayer = dgPlayersWarned.Rows.Count - 1
                                dgPlayersWarned.Rows(RowPlayer).Cells(0).Value = 1
                                dgPlayersWarned.Rows(RowPlayer).Cells(1).Value = PlayerLeido
                                lblWarnedPlayers.Text = "(" & (Val(Mid(lblWarnedPlayers.Text.Trim, 2, Len(lblWarnedPlayers.Text) - 2)) + 1).ToString.Trim & ")"
                                lblWarnings.Text = (Val(lblWarnings.Text) + 1).ToString.Trim
                                Call CheckRules(PlayerLeido, Val(dgPlayersWarned.Rows(dgPlayersWarned.Rows.Count - 1).Cells(0).Value))
                                Exit For
                            Else 'Si ya estaba advertido el jugador le sumamos un aviso y salimos para que no busque mas palabras en 1 misma frase
                                dgPlayersWarned.Rows(RowPlayer).Cells(0).Value = Val(dgPlayersWarned.Rows(RowPlayer).Cells(0).Value) + 1
                                lblWarnings.Text = (Val(lblWarnings.Text) + 1).ToString.Trim
                                Call CheckRules(PlayerLeido, Val(dgPlayersWarned.Rows(RowPlayer).Cells(0).Value))
                                Exit For
                            End If

                        End If
                    Next

                End If
                '************Fin control Palabras Prohibidas******************



            End If
            If InStr(lineaLeida, "Loaded map file") > 0 Or InStr(lineaLeida, "Running the game") > 0 _
                                                            Or InStr(lineaLeida, "profile signed in") > 0 _
                                                            Or InStr(lineaLeida, "Loading ") > 0 Or InStr(lineaLeida, "Dedicated server") > 0 _
                                                            Or InStr(lineaLeida, "left the game") > 0 Or InStr(lineaLeida, "has joined the game") > 0 _
                                                            Or InStr(lineaLeida, "has joined the LAWMEN (blue) team") > 0 _
                                                            Or InStr(lineaLeida, "has joined the OUTLAWS (red) team") > 0 _
                                                            Or InStr(lineaLeida, "has changed team to OUTLAWS (red)") > 0 _
                                                            Or InStr(lineaLeida, "has changed team to LAWMEN (blue)") > 0 _
                                                            Or InStr(lineaLeida, "has been kicked") > 0 Then

                If InStr(lineaLeida, "left the game") > 0 Or InStr(lineaLeida, "has joined the game") > 0 _
                                                            Or InStr(lineaLeida, "has joined the LAWMEN (blue) team") > 0 _
                                                            Or InStr(lineaLeida, "has joined the OUTLAWS (red) team") > 0 _
                                                            Or InStr(lineaLeida, "has changed team to OUTLAWS (red)") > 0 _
                                                            Or InStr(lineaLeida, "has changed team to LAWMEN (blue)") > 0 _
                                                            Or InStr(lineaLeida, "has been kicked") > 0 Then

                    'Tomamos aqui el nombre del jugador que usaremos si el juego es por equipos para añadirlo a los listbox red o blue.
                    If InStr(lineaLeida, """ has") - (InStr(lineaLeida, """") + 1) > 0 Then
                        PlayerJoinOrLeave = Mid(lineaLeida, InStr(lineaLeida, """") + 1, InStr(lineaLeida, """ has") - (InStr(lineaLeida, """") + 1))
                    End If

                End If

                'Player "playerX" has joined the LAWMEN (blue) team
                '"playerX" has joined the OUTLAWS (red) team
                '"playerX" has changed team to OUTLAWS (red)
                '"playerX" has changed team to LAWMEN (blue)
                'has left the game
                'has joined the game
                'has been kicked
                'No players in game

                If InStr(lineaLeida, "::") = 0 And InStr(lineaLeida, "[") = 0 And InStr(lineaLeida, "]") = 0 _
                                               And InStr(lineaLeida, "Undeclared variable <") = 0 _
                                               And Mid(lineaLeida, 1, 8) <> "WARNING!" Then
                    addConsole = True
                End If
            End If

            'Si el mapa acaba de ser cargado, daremos un tiempo mayor antes de leer los players
            'para esperar a que entren
            If InStr(lineaLeida, "Loaded map file") > 0 Then
                LoadingMap = False
                lineaLeida = "******* " & lineaLeida & " *******"
                lblTeamRed.Text = "0"
                lblTeamBlue.Text = "0"
                LbPlayers.Items.Clear()
                lbPlayers2.Items.Clear()
                lbBlueTeam.Items.Clear()
                lbRedTeam.Items.Clear()
                lblNumPlayers.Text = "Players     : 0"
            End If

            If InStr(lineaLeida, "Game ended") > 0 Then
                If InStr(lineaLeida, "Game ended!") > 0 Then
                    LoadingMap = True
                    tiempoMapaActivado = False
                    If chkCleanPlayersWarned.Checked = True Then
                        dgPlayersWarned.Rows.Clear()
                    End If

                    Dim Mapa As String = dgMaps.Rows(0).Cells(0).Value.ToString
                    Dim Modo As String = dgMaps.Rows(0).Cells(1).Value.ToString
                    dgMaps.Rows.Remove(dgMaps.Rows(0))
                    dgMaps.Rows.Add()
                    dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(0).Value = Mapa
                    dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(1).Value = Modo

                    If chkRememberMaps.Checked = True Then
                        Call ReadAndWriteMapsInDedicatedServerSetting()
                    End If
                End If
                addConsole = True
            End If

            If InStr(lineaLeida, "Loading map <") > 0 And InStr(lineaLeida, "[") = 0 Then
                lblCurrentMap.Text = "Current map:  "
                Dim currMap As String = lineaLeida
                currMap = Mid(currMap, InStr(currMap, "<") + 1, Len(currMap) - InStr(currMap, "<"))
                lblCurrentMap.Text = lblCurrentMap.Text & UCase(Mid(currMap, 1, InStr(currMap, ">") - 1))
                'En la tag guardamos justamente solo el mapa con su gamemode
                lblCurrentMap.Tag = UCase(Mid(currMap, 1, InStr(currMap, ">") - 1))
                currMap = Mid(currMap, InStr(currMap, "<") + 1, Len(currMap) - InStr(currMap, "<"))
                lblCurrentMap.Text = lblCurrentMap.Text & "  <" & Mid(currMap, 1, InStr(currMap, ">") - 1) & ">"
                lblCurrentMap.Tag = lblCurrentMap.Tag & "  <" & Mid(currMap, 1, InStr(currMap, ">") - 1) & ">"
                If InStr(lineaLeida, "Posse") > 0 Then
                    lblTimeMap.Text = "Time Map : " & (Int(timePosse / 60)).ToString & ":00 m."
                    lblRemainTime.Text = "Rem. time : " & (Int(timePosse / 60)).ToString & ":00 m."
                    timeRemain = timePosse
                    bountyOrPointsToShow = bountyPosse
                End If
                If InStr(lineaLeida, "Wanted") > 0 Then
                    lblTimeMap.Text = "Time Map : " & (Int(timeWanted / 60)).ToString & ":00 m."
                    lblRemainTime.Text = "Rem. time : " & (Int(timeWanted / 60)).ToString & ":00 m."
                    timeRemain = timeWanted
                    bountyOrPointsToShow = bountyWanted
                End If
                If InStr(lineaLeida, "Shootout") > 0 Then
                    lblTimeMap.Text = "Time Map : " & (Int(timeShootout / 60)).ToString & ":00 m."
                    lblRemainTime.Text = "Rem. time : " & (Int(timeShootout / 60)).ToString & ":00 m."
                    timeRemain = timeShootout
                    bountyOrPointsToShow = bountyShootout
                End If
                If InStr(lineaLeida, "Manhunt") > 0 Then
                    lblTimeMap.Text = "Time Map : " & (Int(timeManhunt / 60)).ToString & ":00 m."
                    lblRemainTime.Text = "Rem. time : " & (Int(timeManhunt / 60)).ToString & ":00 m."
                    timeRemain = timeManhunt
                    bountyOrPointsToShow = pointsManhunt
                End If

                If InStr(lineaLeida, "Posse") > 0 Or InStr(lineaLeida, "Manhunt") > 0 Or InStr(lineaLeida, "W.W.Legends") > 0 Then
                    PanelTeams.Enabled = True
                    PanelTabTeams.Enabled = True

                Else
                    PanelTeams.Enabled = False
                    PanelTabTeams.Enabled = False
                End If

                lblBountyOrPoints.Text = bountyOrPointsToShow
                'Variable utilizada para ir descontando el tiempo de cada mapa
                'dentro de la rutina TimerReadConsole
                minutes = (Int(timeRemain / 60))
                seconds = 59

                'Variable para dar tiempo de espera desde que se activa el tiempo al unirse un jugador al juego
                'hasta que se une a algún equipo, toma valor 4 (ciclos de 3sec.), total 12 sec.
                ciclosSinContar = 4
            End If

            'Loading map <Adobes> mode <Shootout>

            If InStr(lineaLeida, "Dedicated server") > 0 Then
                Me.Text = Me.Text & " - " & Mid(lineaLeida, InStr(lineaLeida, "<") + 1, InStr(lineaLeida, ">") - (InStr(lineaLeida, "<") + 1))
            End If


            '||||||||||||||||FRASES DE CONTROL DE PLAYERS Y EQUIPOS|||||||||||||||||||||
            'Player "playerX" has joined the LAWMEN (blue) team
            '"playerX" has joined the OUTLAWS (red) team
            '"playerX" has changed team to OUTLAWS (red)
            '"playerX" has changed team to LAWMEN (blue)
            'has left the game
            'has joined the game
            'has been kicked
            'No players in game

            If InStr(lineaLeida, "has been kicked") > 0 Then
                'SendToConsole("/playerlist")
                TimerGetPlayerList.Enabled = True
                LbPlayers.Items.Clear()
                lbPlayers2.Items.Clear()
                addConsole = True
                changedTeam = True
                If PanelTeams.Enabled = True Then
                    If lbRedTeam.Items.Contains(PlayerJoinOrLeave) Then lbRedTeam.Items.Remove(PlayerJoinOrLeave)
                    If lbBlueTeam.Items.Contains(PlayerJoinOrLeave) Then lbBlueTeam.Items.Remove(PlayerJoinOrLeave)
                    lblTeamBlue.Text = (Val(lbBlueTeam.Items.Count)).ToString
                    lblTeamRed.Text = (Val(lbRedTeam.Items.Count)).ToString
                End If
            End If

            If InStr(lineaLeida, "has joined the LAWMEN (blue) team") > 0 And PanelTeams.Enabled = True Then

                If Not lbBlueTeam.Items.Contains(PlayerJoinOrLeave) And Not lbRedTeam.Items.Contains(PlayerJoinOrLeave) Then
                    lbBlueTeam.Items.Add(PlayerJoinOrLeave)
                    lblTeamBlue.Text = (Val(lbBlueTeam.Items.Count)).ToString
                End If

                changedTeam = True

            End If
            If InStr(lineaLeida, "has joined the OUTLAWS (red) team") > 0 And PanelTeams.Enabled = True Then

                If Not lbRedTeam.Items.Contains(PlayerJoinOrLeave) And Not lbBlueTeam.Items.Contains(PlayerJoinOrLeave) Then
                    lbRedTeam.Items.Add(PlayerJoinOrLeave)
                    lblTeamRed.Text = (Val(lbRedTeam.Items.Count)).ToString
                End If

                changedTeam = True

            End If
            If InStr(lineaLeida, "has changed team to OUTLAWS (red)") > 0 And PanelTeams.Enabled = True Then
                If lbBlueTeam.Items.Contains(PlayerJoinOrLeave) Then lbBlueTeam.Items.Remove(PlayerJoinOrLeave)
                If Not lbRedTeam.Items.Contains(PlayerJoinOrLeave) Then lbRedTeam.Items.Add(PlayerJoinOrLeave)
                lblTeamBlue.Text = (Val(lbBlueTeam.Items.Count)).ToString
                lblTeamRed.Text = (Val(lbRedTeam.Items.Count)).ToString
                changedTeam = True

            End If
            If InStr(lineaLeida, "has changed team to LAWMEN (blue)") > 0 And PanelTeams.Enabled = True Then

                If lbRedTeam.Items.Contains(PlayerJoinOrLeave) Then lbRedTeam.Items.Remove(PlayerJoinOrLeave)
                If Not lbBlueTeam.Items.Contains(PlayerJoinOrLeave) Then lbBlueTeam.Items.Add(PlayerJoinOrLeave)
                lblTeamBlue.Text = (Val(lbBlueTeam.Items.Count)).ToString
                lblTeamRed.Text = (Val(lbRedTeam.Items.Count)).ToString
                changedTeam = True

            End If

            If InStr(lineaLeida, "No players in game") > 0 Then

                If PanelTeams.Enabled = True Then
                    lbBlueTeam.Items.Clear()
                    lbRedTeam.Items.Clear()
                End If

                lblTeamRed.Text = "0"
                lblTeamBlue.Text = "0"
                LbPlayers.Items.Clear()
                lbPlayers2.Items.Clear()
                lblNumPlayers.Text = "Players     : 0"
                addConsole = True
            End If
            If InStr(lineaLeida, "has left the game") > 0 Or InStr(lineaLeida, "has joined the game") > 0 Then

                'Comprobamos en que equipo estaba el jugador y actualizamos los jugadores del equipo que corresponda
                If InStr(lineaLeida, "has left the game") > 0 And PanelTeams.Enabled = True Then
                    If lbRedTeam.Items.Contains(PlayerJoinOrLeave) Then
                        lbRedTeam.Items.Remove(PlayerJoinOrLeave)
                        lblTeamRed.Text = (Val(lbRedTeam.Items.Count)).ToString
                        changedTeam = True
                    End If

                    If lbBlueTeam.Items.Contains(PlayerJoinOrLeave) Then
                        lbBlueTeam.Items.Remove(PlayerJoinOrLeave)
                        lblTeamBlue.Text = (Val(lbBlueTeam.Items.Count)).ToString
                    End If

                End If

                'Comprobamos primero si está en la lista de baneados
                'el jugador que se unió, no añade nada a la consola.
                If InStr(lineaLeida, "has joined the game") > 0 Then
                    tiempoMapaActivado = True
                    Dim Player As String = lineaLeida
                    Player = Mid(Player, InStr(Player, """") + 1, Len(Player) - InStr(Player, """"))
                    If InStr(Player, """") > 0 Then
                        Player = Mid(Player, 1, InStr(Player, """") - 1)
                        If FindInListbox(lbBanned, Player) = True Then
                            'ACTIVAR LA SIGUIENTE LINEA CUANDO SE QUIERA EMPEZAR A BANEAR
                            SendToConsole("/kick " & Player & " Banned by Mod Coj Controller")
                        End If
                    End If
                End If




                'Leeremos la lista de jugadores aquí y al iniciar cada mapa
                lineaLeida = "// " & lineaLeida
                addConsole = True
                LbPlayers.Items.Clear()
                lbPlayers2.Items.Clear()
                SendToConsole("/playerlist")
            End If

            If Val(Replace(((Val(lblTeamBlue.Text) - Val(lblTeamRed.Text)).ToString), "-", " ")) >= 2 And chkBalance.Checked = True And changedTeam = True Then
                GameUnbalanced = True
                If TimerKillBalance.Enabled = False And LoadingMap = False Then
                    SendToConsole("/adminsay Activated automatic team BALANCE in the Server. Please, BOTH teams have to be BALANCED NOW.")
                    SendToConsole("/adminsay Last players who joined to the larger team will be 'killed' by the server  every 5 seconds.")
                    SendToConsole("/adminsay Last players who joined to the larger team will be 'killed' by the server  every 5 seconds.")
                End If
                TimerKillBalance.Enabled = True
                changedTeam = False
            ElseIf Val(Replace(((Val(lblTeamBlue.Text) - Val(lblTeamRed.Text)).ToString), "-", " ")) < 2 And chkBalance.Checked = True And changedTeam = True Then
                GameUnbalanced = False
                If TimerKillBalance.Enabled = True And LoadingMap = False Then
                    SendToConsole("/adminsay Teams balance is OK now.")
                End If
                CiclosBalance = 0
                TimerKillBalance.Enabled = False
                changedTeam = False
            End If
            '||||||||||||||||FINAL FRASES DE CONTROL DE PLAYERS Y EQUIPOS|||||||||||||||||||||



            If InStr(lineaLeida, "accepted") > 0 Then
                addConsole = True
            End If



            If InStr(lineaLeida, "lobby") > 0 And InStr(lineaLeida, "disconnected") > 0 Then
                'Se ha apagado el servidor solo, aquí lo reiniciaremos
                vApagado = "restart"
                'Usamos la variable "vRestart" (booleana) pública declarada en Module1
                'para desde frmArmas controlar que hay que volver a iniciar el server
                vRestart = True
                TimerCountDown.Enabled = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
                TimerLoad.Enabled = False
                TimerReadConsole.Enabled = False
                TimerReadConsoleInst.Enabled = False
                TimeClose = 10
                Call writeLog()
            End If

            If InStr(lineaLeida, "will be shutdown") > 0 And TimerCountDown.Enabled = False Then
                TimeClose = 9
                TimerCountDown.Enabled = True
                'TimerShutDown.Enabled = True
            End If





            If InStr(lineaLeida, "host id:") > 0 Then
                'Aqui pasaremos los jugadores a un ListBox antes de mandar la linea a la consola general
                lineaPlayer = Space(5 - Len(Mid(lineaLeida, InStr(lineaLeida, "host id: ") + 9, 5).Trim)) & Mid(lineaLeida, InStr(lineaLeida, "host id: ") + 9, 5) & "    -  " & Mid(lineaLeida, 1, InStr(lineaLeida, ", ") - 1)
                If FindInListbox(LbPlayers, lineaPlayer) = False Then
                    LbPlayers.Items.Add(lineaPlayer & " ")
                    lbPlayers2.Items.Add(lineaPlayer & " ")
                End If
                'Jugador añadido
                lineaLeida = ">>>> " & lineaLeida & " <<<<"
                addConsole = True
                lblNumPlayers.Text = "Players     : " & LbPlayers.Items.Count.ToString.Trim
            End If

            '********************************************************************
            '*******************COMMANDS Admin***********************************
            If lbAdmin.Items.Contains(PlayerLeido) Then
                Dim comando As String = ""
                If InStr(lineaLeida, "!addword") > 0 Then
                    Dim Palabra As String = LCase(Mid(lineaLeida, (InStr(lineaLeida, "!addword") + 9), Len(lineaLeida) - (InStr(lineaLeida, "!addword") + 8)))
                    If Not lbWords.Items.Contains(Palabra) Then
                        AddItemsToListBoxOrdered(lbWords, Palabra)
                        Call WriteFileTabRules()
                    End If
                End If

                If InStr(lineaLeida, "!mapnext") > 0 And chkMapnext.Checked = True Then
                    SendToConsole("/mapnext")
                End If

                If InStr(lineaLeida, "!balance yes") > 0 Then
                    chkBalance.Checked = True
                End If

                If InStr(lineaLeida, "!balance no") > 0 Then
                    chkBalance.Checked = False
                End If

                If InStr(lineaLeida, "!kill ") > 0 And chkKill.Checked = True And FindInListbox(lbBanned, Trim(Mid(lineaLeida, InStr(lineaLeida, "kick ") + 4, (Len(lineaLeida) - (InStr(lineaLeida, "kick ") + 3))))) = False Then
                    comando = "/kill " & Trim(Mid(lineaLeida, InStr(lineaLeida, "kill ") + 4, (Len(lineaLeida) - (InStr(lineaLeida, "kill ") + 3))))
                    SendToConsole(comando)
                End If

                If InStr(lineaLeida, "!kick ") > 0 And chkKick.Checked = True And FindInListbox(lbBanned, Trim(Mid(lineaLeida, InStr(lineaLeida, "kick ") + 4, (Len(lineaLeida) - (InStr(lineaLeida, "kick ") + 3))))) = False Then
                    comando = "/kick " & Trim(Mid(lineaLeida, InStr(lineaLeida, "kick ") + 4, (Len(lineaLeida) - (InStr(lineaLeida, "kick ") + 3))))
                    SendToConsole(comando)
                End If

                If InStr(lineaLeida, "!adminsay ") > 0 And chkAdminsay.Checked = True Then
                    comando = "/adminsay " & Trim(Mid(lineaLeida, InStr(lineaLeida, "adminsay ") + 8, (Len(lineaLeida) - (InStr(lineaLeida, "adminsay ") + 7))))
                    Dim lin As String = "-------------------------------------------------------------------------------------------------------------------------------------------------------"

                    SendToConsole("/adminsay " & Mid(lin, 1, Len(comando) - 10 + ((Len(comando) - 10) / 2)))
                    SendToConsole(comando)
                    SendToConsole("/adminsay " & Mid(lin, 1, Len(comando) - 10 + ((Len(comando) - 10) / 2)))
                End If

                If InStr(lineaLeida, "!playerlist") > 0 And chkPlayerlistAd.Checked = True And PlayerLeido <> "SERVER" Then
                    Dim Line1 As String = "/adminsay"
                    Dim Line2 As String = "/adminsay"
                    Dim Line3 As String = "/adminsay"
                    For i = 0 To LbPlayers.Items.Count - 1
                        If Line1.Length < 75 Then
                            Line1 = Line1 & " ;  " & Replace(LbPlayers.Items(i).ToString.Trim, "    -  ", "-")
                        ElseIf Line2.Length < 75 Then
                            Line2 = Line2 & " ;  " & Replace(LbPlayers.Items(i).ToString.Trim, "    -  ", "-")
                        ElseIf Line3.Length < 75 Then
                            Line3 = Line3 & " ;  " & Replace(LbPlayers.Items(i).ToString.Trim, "    -  ", "-")
                        End If
                    Next

                    SendToConsole(Line1)
                    SendToConsole(Line2)
                    SendToConsole(Line3)

                End If

                If InStr(lineaLeida, "!banlist") > 0 And chkBanlist.Checked = True Then
                    Dim Line1 As String = "/adminsay"
                    Dim Line2 As String = "/adminsay"
                    Dim Line3 As String = "/adminsay"
                    For i = 0 To lbBanned.Items.Count - 1
                        If Line1.Length < 85 Then
                            Line1 = Line1 & " ;  " & lbBanned.Items(i).ToString.Trim
                        ElseIf Line2.Length < 85 Then
                            Line2 = Line2 & " ;  " & lbBanned.Items(i).ToString.Trim
                        ElseIf Line3.Length < 85 Then
                            Line3 = Line3 & " ;  " & lbBanned.Items(i).ToString.Trim
                        End If
                    Next
                    If Line1.Trim = "/adminsay " And chkAdminsay.Checked = True Then
                        Line1 = "/adminsay No players in banned list"
                    End If
                    SendToConsole(Line1)
                    SendToConsole(Line2)
                    SendToConsole(Line3)
                End If

                If InStr(lineaLeida, "!commandlist") > 0 And chkCommandlistAd.Checked = True And PlayerLeido <> "SERVER" Then
                    'Dim Line1 As String = "/adminsay (!commandlist) ; (!mapnext) ; (!maplist) ; (!votemapnext) ; (!newadmin <name>) ; (!kill <name/id>) ; (!kick <name/id>) "
                    'Dim Line2 As String = "/adminsay (!ban <name>) ; (!unban <name>) ; (!banlist) ; (!playerlist) ; (!adminsay) ; (!servershutdown) ; (!restart) "
                    'Dim Line3 As String = "/adminsay"

                    SendToConsole("/adminsay " & commandActivAdLin1)
                    SendToConsole("/adminsay " & commandActivAdLin2)
                    SendToConsole("/adminsay " & commandActivAdLin3)
                End If

                If InStr(lineaLeida, "!ban ") > 0 And chkBan.Checked = True And FindInListbox(lbBanned, Trim(Mid(lineaLeida, InStr(lineaLeida, "ban ") + 3, (Len(lineaLeida) - (InStr(lineaLeida, "ban ") + 2))))) = False Then
                    comando = Trim(Mid(lineaLeida, InStr(lineaLeida, "ban ") + 3, (Len(lineaLeida) - (InStr(lineaLeida, "ban ") + 2))))
                    If FindInListbox(lbBanned, comando & " ") = False Then lbBanned.Items.Add(Mid(Date.Now.ToString, 1, 10) & "   " & comando & " ")
                    Call WriteFileBanned()
                    SendToConsole("/kick " & comando)
                End If

                If InStr(lineaLeida, "!unban ") > 0 And chkUnban.Checked = True Then
                    comando = Trim(Mid(lineaLeida, InStr(lineaLeida, "unban ") + 5, (Len(lineaLeida) - (InStr(lineaLeida, "unban ") + 4))))
                    If FindInListbox(lbBanned, comando) Then
                        For i = 0 To lbBanned.Items.Count - 1
                            If InStr(lbBanned.Items(i), comando) > 0 Then
                                lbBanned.Items.Remove(lbBanned.Items(i))
                            End If
                        Next
                    End If

                    Call WriteFileBanned()
                End If

                If InStr(lineaLeida, "!newadmin ") > 0 And chkNewadmin.Checked = True Then
                    comando = Trim(Mid(lineaLeida, InStr(lineaLeida, "newadmin ") + 8, (Len(lineaLeida) - (InStr(lineaLeida, "newadmin ") + 7))))
                    If Not lbAdmin.Items.Contains(comando) Then lbAdmin.Items.Add(comando)
                    Call WriteFileAdmins()
                    SendToConsole("/adminsay " & comando & " has been added to Admins List.")
                End If

                If InStr(lineaLeida, "!servershutdown") > 0 And chkServershutdown.Checked = True Then
                    vApagado = "shutdown"
                    TimerCountDown.Enabled = True
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                    Timer3.Enabled = False
                    TimerLoad.Enabled = False
                    TimerReadConsole.Enabled = False
                    TimerReadConsoleInst.Enabled = False
                    'TimerReadPlayer.Enabled = False
                    TimeClose = 15
                    reader.Close()
                    Exit Sub
                End If

                If InStr(lineaLeida, "!restart") > 0 And chkRestart.Checked = True And chkRestart.Checked = True Then
                    vApagado = "restart"
                    'Usamos la variable "vRestart" (booleana) pública declarada en Module1
                    'para desde frmArmas controlar que hay que volver a iniciar el server
                    vRestart = True
                    TimerCountDown.Enabled = True
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                    Timer3.Enabled = False
                    TimerLoad.Enabled = False
                    TimerReadConsole.Enabled = False
                    TimerReadConsoleInst.Enabled = False
                    TimeClose = 15
                End If

                If InStr(lineaLeida, "!maplist") > 0 And TimerGetMapList.Enabled = False And PlayerLeido <> "SERVER" And chkMaplistAd.Checked = True Then
                    Dim nextMapsList As String = "3 next maps are: "
                    For i = 1 To 3
                        nextMapsList = nextMapsList & "(" & i & "- " & dgMaps.Rows(i).Cells(0).Value.ToString.Trim & " " & dgMaps.Rows(i).Cells(1).Value.ToString.Trim & ")  "
                    Next
                    TimerGetMapList.Enabled = True
                    SendToConsole("/adminsay " & nextMapsList)
                End If


            ElseIf Not lbAdmin.Items.Contains(PlayerLeido) Then
                '********************************************************************
                '*******************COMMANDS Normal Players***************************

                If InStr(lineaLeida, "!commandlist") > 0 And PlayerLeido <> "SERVER" And chkCommandlist.Checked = True Then
                    SendToConsole("/adminsay " & commandActivGeneral)
                End If

                If InStr(lineaLeida, "!maplist") > 0 And TimerGetMapList.Enabled = False And PlayerLeido <> "SERVER" And chkMaplist.Checked = True Then
                    Dim nextMapsList As String = "3 next maps are: "
                    For i = 1 To 3
                        nextMapsList = nextMapsList & "(" & i & "- " & dgMaps.Rows(i).Cells(0).Value.ToString.Trim & " " & dgMaps.Rows(i).Cells(1).Value.ToString.Trim & ")  "
                    Next
                    TimerGetMapList.Enabled = True
                    SendToConsole("/adminsay " & nextMapsList)
                End If

                If InStr(lineaLeida, "!playerlist") > 0 And chkPlayerlistAd.Checked = True And PlayerLeido <> "SERVER" Then
                    Dim Line1 As String = "/adminsay"
                    Dim Line2 As String = "/adminsay"
                    Dim Line3 As String = "/adminsay"
                    For i = 0 To LbPlayers.Items.Count - 1
                        If Line1.Length < 75 Then
                            Line1 = Line1 & " ;  " & Replace(LbPlayers.Items(i).ToString.Trim, "    -  ", "-")
                        ElseIf Line2.Length < 75 Then
                            Line2 = Line2 & " ;  " & Replace(LbPlayers.Items(i).ToString.Trim, "    -  ", "-")
                        ElseIf Line3.Length < 75 Then
                            Line3 = Line3 & " ;  " & Replace(LbPlayers.Items(i).ToString.Trim, "    -  ", "-")
                        End If
                    Next

                    SendToConsole(Line1)
                    SendToConsole(Line2)
                    SendToConsole(Line3)

                End If

            End If


            If InStr(lineaLeida, "!votemapnext") > 0 And mNextVoteIsActive = False And chkVotemapnext.Checked = True _
               Or InStr(lineaLeida, "!votekick") > 0 And mNextVoteIsActive = False And chkVotekick.Checked = True _
               Or InStr(lineaLeida, "!voteban") > 0 And mNextVoteIsActive = False And chkVoteBan.Checked = True Then
                playerInVote = ""
                Dim line1 As String = ""
                Dim line2 As String = ""
                mNextNeededVotes = 0
                mNextVotesYes = 0


                If PlayerLeido <> "SERVER" Then


                    If InStr(lineaLeida, "!votemapnext") > 0 Then
                        CommandInVote = "!votemapnext"
                        mNextNeededVotes = Math.Round(LbPlayers.Items.Count / 100 * 76)
                        line1 = "/adminsay Starting vote to change next map.  " & dgMaps.Rows(1).Cells(0).Value.ToString.Trim _
                          & dgMaps.Rows(1).Cells(1).Value.ToString.Trim & ".  45 seconds to vote."
                        line2 = "/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes)"

                    ElseIf InStr(lineaLeida, "!votekick") > 0 Then
                        playerInVote = Trim(Mid(lineaLeida, InStr(lineaLeida, "kick") + 5, (Len(lineaLeida) - (InStr(lineaLeida, "kick") + 4))))
                        If FindInListbox(LbPlayers, playerInVote) = True And FindInListbox(lbAdmin, playerInVote) = False Then
                            CommandInVote = "!votekick"
                            mNextNeededVotes = Math.Round((LbPlayers.Items.Count - 1) / 100 * 76)
                            line1 = "/adminsay Starting vote to kick to " & playerInVote & ".  45 seconds to vote."
                            line2 = "/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes)"
                        Else
                            line1 = "/adminsay Starting vote to kick to " & playerInVote & ". PLAYER NOT FOUND"
                            ' reader.Close()
                            ' Exit Sub
                        End If

                    ElseIf InStr(lineaLeida, "!voteban") > 0 Then
                        playerInVote = Trim(Mid(lineaLeida, InStr(lineaLeida, "ban") + 4, (Len(lineaLeida) - (InStr(lineaLeida, "ban") + 3))))
                        If FindInListbox(LbPlayers, playerInVote) = True And FindInListbox(lbAdmin, playerInVote) = False Then
                            CommandInVote = "!voteban"
                            mNextNeededVotes = Math.Round((LbPlayers.Items.Count - 1) / 100 * 86)
                            line1 = "/adminsay Starting vote to ban to " & playerInVote & ".  45 seconds to vote."
                            line2 = "/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes)"
                        Else
                            line1 = "/adminsay Starting vote to ban to " & playerInVote & ". PLAYER NOT FOUND"
                            'reader.Close()
                            ' Exit Sub
                        End If
                    End If

                    If FindInListbox(LbPlayers, playerInVote) = True And FindInListbox(lbAdmin, playerInVote) = False Or InStr(lineaLeida, "!votemapnext") > 0 Then
                        mNextVotesYes = 0
                        mNextPlayersVoted = ""

                        If LbPlayers.Items.Count = 2 Then mNextNeededVotes = 2
                        mNextVoteIsActive = True
                        CountDownVotes = 48
                        TimerVote.Enabled = True

                        SendToConsole(line1)
                        SendToConsole(line2)
                    End If
                End If
            End If


            If InStr(lineaLeida, "!vote yes") > 0 And mNextVoteIsActive = True And InStr(lineaLeida, "Type '!vote yes'") = 0 Then
                If InStr(mNextPlayersVoted, PlayerLeido & " ") = 0 Then
                    mNextVotesYes = mNextVotesYes + 1
                    mNextPlayersVoted = mNextPlayersVoted & PlayerLeido & " "
                    Dim line2 As String = ""

                    If CommandInVote = "!votemapnext" Then
                        line2 = "/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes).  " & CountDownVotes.ToString.Trim & " seconds remaining" _
                                          & " to change to next map.  " & dgMaps.Rows(1).Cells(0).Value.ToString.Trim _
                                          & " " & dgMaps.Rows(1).Cells(1).Value.ToString.Trim & "."
                        SendToConsole(line2)

                    ElseIf CommandInVote = "!votekick" Then
                        line2 = "/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes).  " & CountDownVotes.ToString.Trim & " seconds remaining" _
                                          & " to KICK to the player '" & playerInVote & "'."
                        SendToConsole(line2)

                    ElseIf CommandInVote = "!voteban" Then
                        line2 = "/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes).  " & CountDownVotes.ToString.Trim & " seconds remaining" _
                                         & " to BAN to the player '" & playerInVote & "'."
                        SendToConsole(line2)
                    End If


                    If mNextVotesYes >= mNextNeededVotes Then

                        If CommandInVote = "!votemapnext" Then
                            SendToConsole("/mapnext")
                            SendToConsole("/adminsay Vote Passed.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes)")
                        ElseIf Mid(CommandInVote, 1, 9) = "!votekick" Then
                            If FindInListbox(lbBanned, playerInVote) = False And FindInListbox(lbAdmin, playerInVote) = False Then
                                SendToConsole("/kick " & playerInVote & " kick by players' votes")
                                SendToConsole("/adminsay Vote Passed.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes). " & playerInVote & " was kicked out!!!")
                            End If
                        ElseIf Mid(CommandInVote, 1, 8) = "!voteban" Then
                            If FindInListbox(lbBanned, playerInVote) = False And FindInListbox(lbAdmin, playerInVote) = False Then
                                SendToConsole("/kick " & playerInVote & " banned by players' votes")
                                lbBanned.Items.Add(Mid(Date.Now.ToString, 1, 10) & "   " & playerInVote & " ")
                                Call WriteFileBanned()
                                SendToConsole("/adminsay Vote Passed.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes). " & playerInVote & " was banned!!!")
                            End If
                        End If

                        TimerVote.Enabled = False
                        mNextVoteIsActive = False
                    End If
                End If

            End If

            'mNextVoteIsActive = False
            If InStr(lineaLeida, "Vote finished") > 0 Then
                SendToConsole("/adminsay Vote not Passed.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes)")
            End If

            If addConsole = True Then
                Dim LineToAdd1 As String = Mid(Date.Now, InStr(Date.Now, " ") + 1, 8) & " " & lineaLeida
                Dim LineToAdd2 As String = ""

                'Si la línea a enviar a la consola es mayor de 80 la enviamos a la funcion RecortaLineToAdd que la envia
                'como 2 lineas separadas al listbox de la consola
                If LineToAdd1.Length > 85 Then
                    RecortaLineToAdd(LineToAdd1)
                    'lbConsola.Items.Add(LineToAdd1)
                    'lbConsola.Items.Add(LineToAdd2)
                Else
                    lbConsola.Items.Add(LineToAdd1)
                End If

                ' lbConsola.Items.Add(Mid(Date.Now, InStr(Date.Now, " ") + 1, 8) & " " & lineaLeida)
                lbConsola.SelectedIndex = (lbConsola.Items.Count - 1)
            End If
        End While

        reader.Close()

        TimerReadConsole.Enabled = True
    End Sub

    'Dim LbPlayersSinId As New ListBox
    'Private Sub LeerLbPlayersSinId()
    '    LbPlayers.Items.Clear()
    '    For i = 0 To LbPlayers.Items.Count - 1
    '        LbPlayersSinId.Items.Add(Mid(LbPlayers.Items(i), InStr(LbPlayers.Items(i), "-") + 2, LbPlayers.Items(i).ToString.Length - (InStr(LbPlayers.Items(i), "-") + 2)))
    '    Next
    'End Sub



    'Contendrá lo que estamos votando (!votemapnext, !voteban player, !votekick player/id)
    Dim CommandInVote As String = ""
    Dim CountDownVotes As Integer = 48
    Private Sub TimerVote_Tick(sender As Object, e As EventArgs) Handles TimerVote.Tick
        If CountDownVotes <= 0 Then
            TimerVote.Enabled = False
            SendToConsole("/adminsay Vote finished!")
            mNextVoteIsActive = False
        End If
        CountDownVotes = CountDownVotes - 1

        If CountDownVotes = 23 Then
            If CommandInVote = "!votemapnext" Then
                SendToConsole("/adminsay (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes). 20 seconds remaining" _
                         & " to change to next map.  " & dgMaps.Rows(1).Cells(0).Value.ToString.Trim & " " & dgMaps.Rows(1).Cells(1).Value.ToString.Trim & ".")
            ElseIf Mid(CommandInVote, 1, 5) = "!kick" Then
                SendToConsole("/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes).  " & CountDownVotes.ToString.Trim & " seconds remaining" _
                                          & " to KICK to the player '" & playerInVote & "'.")
            ElseIf Mid(CommandInVote, 1, 4) = "!ban" Then
                SendToConsole("/adminsay Type '!vote yes' or '!vote no'.  (" & mNextVotesYes.ToString.Trim & "/" & mNextNeededVotes.ToString.Trim & " votes).  " & CountDownVotes.ToString.Trim & " seconds remaining" _
                                         & " to BAN to the player '" & playerInVote & "'.")
            End If

        End If
    End Sub

    'La sacamos fuera para que no cambien de color las lineas demasiado largas al cortarse
    Dim myBrushlbConsola As Brush
    Private Sub lbConsola_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lbConsola.DrawItem
        ' e.DrawBackground()
        ' Define the default color of the brush as black.

        ' Determine the color of the brush to draw each item based on the index of the item to draw.

        'SELECCION DEL COLOR DEPENDIENDO DEL TIPO DE MENSAJE
        'CON lbConsola.Items(e.Index) LEEMOS EL ITEM QUE SE ESTÁ AÑADIENDO
        'PARA COMPROBAR EL TIPO DE MENSAJE QUE SE VA A ESCRIBIR
        'MsgBox(lbConsola.Items(e.Index))

        If Mid(lbConsola.Items(e.Index), InStr(lbConsola.Items(e.Index), ":") + 7, 1) = "/" Then
            myBrushlbConsola = Brushes.Gray
            'ElseIf lbConsola.Items(e.Index) = ... Then
        ElseIf Mid(lbConsola.Items(e.Index), InStr(lbConsola.Items(e.Index), ":") + 7, 8) = "<SERVER>" Then
            myBrushlbConsola = Brushes.Red
        ElseIf Mid(lbConsola.Items(e.Index), InStr(lbConsola.Items(e.Index), ":") + 7, 8) <> "<SERVER>" And Mid(lbConsola.Items(e.Index), InStr(lbConsola.Items(e.Index), ":") + 7, 1) = "<" Then
            myBrushlbConsola = Brushes.Blue
        ElseIf Mid(lbConsola.Items(e.Index), InStr(lbConsola.Items(e.Index), ":") + 7, 1) = "/" Then
            myBrushlbConsola = Brushes.OrangeRed
        ElseIf Mid(lbConsola.Items(e.Index), 1, 8) = "        " Then
            'Este caso se da al partir una línea, no eliminar.
            'Solo hay que detectar este caso para que use el ultimo brush
        Else
            myBrushlbConsola = Brushes.Green
        End If

        ' Draw the current item text based on the current Font and the custom brush settings.
        e.Graphics.DrawString(lbConsola.Items(e.Index), e.Font, myBrushlbConsola, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))

        ' If the ListBox has focus, draw a focus rectangle around the selected item.
        e.DrawFocusRectangle()
    End Sub

    'La sacamos fuera para que no cambien de color las lineas demasiado largas al cortarse
    Dim myBrushlbOldChats As Brush
    Private Sub lbOldChats_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lbOldChats.DrawItem
        e.DrawBackground()
        ' Define the default color of the brush as black.


        ' Determine the color of the brush to draw each item based on the index of the item to draw.

        'SELECCION DEL COLOR DEPENDIENDO DEL TIPO DE MENSAJE
        'CON lbOldChats.Items(e.Index) LEEMOS EL ITEM QUE SE ESTÁ AÑADIENDO
        'PARA COMPROBAR EL TIPO DE MENSAJE QUE SE VA A ESCRIBIR
        'MsgBox(lbOldChats.Items(e.Index))

        If Mid(lbOldChats.Items(e.Index), InStr(lbOldChats.Items(e.Index), ":") + 7, 1) = "/" Then
            myBrushlbOldChats = Brushes.Gray
            'ElseIf lbOldChats.Items(e.Index) = ... Then
        ElseIf Mid(lbOldChats.Items(e.Index), InStr(lbOldChats.Items(e.Index), ":") + 7, 8) = "<SERVER>" Then
            myBrushlbOldChats = Brushes.Red
        ElseIf Mid(lbOldChats.Items(e.Index), InStr(lbOldChats.Items(e.Index), ":") + 7, 8) <> "<SERVER>" And Mid(lbOldChats.Items(e.Index), InStr(lbOldChats.Items(e.Index), ":") + 7, 1) = "<" Then
            myBrushlbOldChats = Brushes.Blue
        ElseIf Mid(lbOldChats.Items(e.Index), InStr(lbOldChats.Items(e.Index), ":") + 7, 1) = "/" Then
            myBrushlbOldChats = Brushes.OrangeRed
        ElseIf Mid(lbOldChats.Items(e.Index), 1, 8) = "        " Then
            'Este caso se da al partir una línea, no eliminar.
            'Solo hay que detectar este caso para que use el ultimo brush
        Else
            myBrushlbOldChats = Brushes.Green
        End If

        ' Draw the current item text based on the current Font and the custom brush settings.
        e.Graphics.DrawString(lbOldChats.Items(e.Index), e.Font, myBrushlbOldChats, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))

        ' If the ListBox has focus, draw a focus rectangle around the selected item.
        e.DrawFocusRectangle()
    End Sub


    Private Sub TimerReadConsoleInst_Tick(sender As Object, e As EventArgs) Handles TimerReadConsoleInst.Tick
        TimerReadConsoleInst.Enabled = False
        LeerConsola()

    End Sub

    Dim vHwnd As Integer
    Sub SendToConsole(vText As String)

        Dim LineToAdd1 As String = Mid(Date.Now, InStr(Date.Now, " ") + 1, 8) & " " & vText
        Dim LineToAdd2 As String = ""

        'Si la linea es mayor de 85 la enviamos partida desde la Subs Recortalinetoadd
        If LineToAdd1.Length > 85 Then
            RecortaLineToAdd(LineToAdd1)
            'lbConsola.Items.Add(LineToAdd1)
            'lbConsola.Items.Add(LineToAdd2)
        Else
            lbConsola.Items.Add(LineToAdd1)
        End If

        lbConsola.SelectedIndex = (lbConsola.Items.Count - 1)



        For i As Integer = 1 To Len(vText)
            SendMessageSTRING(vHwnd, WM_CHAR, Asc(Mid(vText, i, 1)), 0&)
        Next i

        SendMessageSTRING(vHwnd, WM_CHAR, Asc(vbCr), 0&)
        SendMessageSTRING(vHwnd, WM_CHAR, Asc(vbLf), 0&)
    End Sub

    Private Sub RecortaLineToAdd(line1 As String)
        Dim longitud As Integer = 75
        Dim lenCadena1 As Integer = Len(line1)
        Dim line2 As String = ""

        If line1.Length > longitud Then
            Do While Mid(line1, longitud, 1) <> " "
                longitud = longitud - 1
            Loop

            line2 = Mid(line1, longitud, (lenCadena1 - longitud))
            line1 = (Mid(line1, 1, longitud)).Trim
            lbConsola.Items.Add(line1)
            lbConsola.Items.Add("             " & line2)
        End If
    End Sub


    Private Sub btnPlayerList_Click(sender As Object, e As EventArgs) Handles btnPlayerList.Click
        Dim vTexto As String = "/playerlist"
        LbPlayers.Items.Clear()
        lbPlayers2.Items.Clear()
        SendToConsole(vTexto)
    End Sub

    Private Sub btnMapNext_Click(sender As Object, e As EventArgs) Handles btnMapNext.Click
        Dim vTexto As String = "/mapnext"
        SendToConsole(vTexto)
    End Sub

    Private Sub WriteFileMsg()
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\msg.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\msg.ini")
        End If
        writer = File.AppendText(rutaAppData & "\Config\msg.ini")
        writer.WriteLine(txtAdMess1.Text)
        writer.WriteLine(txtAdMess2.Text)
        writer.WriteLine(txtAdMess3.Text)
        writer.WriteLine(txtAdMessTime1.Text)
        writer.WriteLine(txtAdMessTime2.Text)
        writer.WriteLine(txtAdMessTime3.Text)
        writer.WriteLine(cboxCabMess3.Text)
        writer.Close()
    End Sub

    Private Sub ReadFileMsg()
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\msg.ini") Then
            ' MsgBox(Application.StartupPath & "\Config\msg.ini")
            readerConfig = File.OpenText(rutaAppData & "\Config\msg.ini")
            txtAdMess1.Text = readerConfig.ReadLine()
            txtAdMess2.Text = readerConfig.ReadLine()
            txtAdMess3.Text = readerConfig.ReadLine()
            txtAdMessTime1.Text = readerConfig.ReadLine()
            txtAdMessTime2.Text = readerConfig.ReadLine()
            txtAdMessTime3.Text = readerConfig.ReadLine()
            cboxCabMess3.Text = readerConfig.ReadLine()
            readerConfig.Close()
        End If
    End Sub

    Private Sub txtAdMessTime1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdMessTime1.KeyPress, txtAdMessTime2.KeyPress, txtAdMessTime3.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtAdMess1_TextChanged(sender As Object, e As EventArgs) Handles txtAdMess1.TextChanged, txtAdMess2.TextChanged, txtAdMess3.TextChanged
        If FormCargado = True Then
            Call WriteFileMsg()
        End If
    End Sub

    Private Sub txtAdMessTime1_TextChanged(sender As Object, e As EventArgs) Handles txtAdMessTime1.TextChanged, txtAdMessTime2.TextChanged, txtAdMessTime3.TextChanged
        If FormCargado = True Then
            Call WriteFileMsg()
        End If
    End Sub


    Private Sub txtAdMessTime1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAdMessTime1.Validating
        If Val(txtAdMessTime1.Text) < 3 And Val(txtAdMessTime1.Text) <> 0 Then
            txtAdMessTime1.Text = "3"
        End If
    End Sub


    Private Sub txtAdMessTime2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAdMessTime2.Validating
        If Val(txtAdMessTime2.Text) < 3 And Val(txtAdMessTime2.Text) <> 0 Then
            txtAdMessTime2.Text = "3"
        End If
    End Sub

    Private Sub txtAdMessTime3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAdMessTime3.Validating
        If Val(txtAdMessTime3.Text) < 3 And Val(txtAdMessTime3.Text) <> 0 Then
            txtAdMessTime3.Text = "3"
        End If
    End Sub

    Private Sub cboxCabMess3_KeyDown(sender As Object, e As KeyEventArgs) Handles cboxCabMess3.KeyDown
        e.SuppressKeyPress = True
    End Sub


    Private Sub cboxCabMess3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCabMess3.SelectedIndexChanged
        If FormCargado = True Then
            If cboxCabMess3.Text = "/playerlist" Or cboxCabMess3.Text = "/mapnext" Then
                txtAdMess3.Enabled = False
            Else
                txtAdMess3.Enabled = True
            End If
            Call WriteFileMsg()
        End If
    End Sub

    'Variables que se cargan con los valores de configuración del DedicatedServerSettings.ini
    Dim timeManhunt As Integer = 0
    Dim timeWanted As Integer = 0
    Dim timeShootout As Integer = 0
    Dim timePosse As Integer = 0
    Dim pointsManhunt As String = ""
    Dim bountyWanted As String = ""
    Dim bountyShootout As String = ""
    Dim bountyPosse As String = ""
    Dim timeRemain As Integer = 0
    Dim bountyOrPointsToShow As String = ""
    Private Sub ReadMaps()
        If My.Computer.FileSystem.FileExists(ruta & "\CoJ2\DedicatedServerSettings.ini") Then
            Dim linealeida As String = ""
            readerConfig = File.OpenText(ruta & "\CoJ2\DedicatedServerSettings.ini")
            'Map("Adobes", "deathmatch")
            Do While readerConfig.EndOfStream = False
                linealeida = readerConfig.ReadLine()
                If Mid(linealeida, 1, 4) = "Map(" Then
                    Dim Mapa As String = Mid(linealeida, 6, InStr(linealeida, ",") - 7)
                    Dim Modo As String = Mid(linealeida, InStr(linealeida, ", ") + 3, (InStr(linealeida, ")") - (InStr(linealeida, ", ") + 4)))
                    If Mapa = "StinkingSprings2" Then Mapa = "Stinking Springs"
                    If Mapa = "PrisonBreak2" Then Mapa = "Nogales"
                    If Mapa = "Adobes" Then Mapa = "Taos Pueblo"
                    If Mapa = "Civil" Then Mapa = "Burnside's Bridge"
                    If Modo = "teamdeathmatch" Then Modo = "Posse"
                    If Modo = "deathmatch" Then Modo = "Shootout"
                    If Modo = "teamwanted" Then Modo = "Manhunt"
                    If Modo = "historical" Then Modo = "W.W.Legends"

                    dgMaps.Rows.Add()
                    dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(0).Value = Mapa

                    Mapa = Mapa & "  <" & Modo & ">"
                    dgMaps.Rows(dgMaps.Rows.Count - 1).Cells(1).Value = "<" & Modo & ">"
                    'lbMapas.Items.Add(Mapa)

                End If


                Dim valorLeido As String = ""
                If InStr(linealeida, "TimeLimit(") Then
                    valorLeido = Val(Replace(Mid(linealeida, InStr(linealeida, ",") + 1, 7), ")", " "))
                    If InStr(linealeida, "deathmatch") > 0 And InStr(linealeida, "teamdeathmatch") = 0 Then
                        timeShootout = valorLeido
                    End If
                    If InStr(linealeida, "wanted") > 0 And InStr(linealeida, "teamwanted") = 0 Then
                        timeWanted = valorLeido
                    End If

                    If InStr(linealeida, "teamdeathmatch") > 0 Then timePosse = valorLeido
                    If InStr(linealeida, "teamwanted") > 0 Then timeManhunt = valorLeido
                End If


                If InStr(linealeida, "BountyLimit(") Then
                    valorLeido = (Val(Replace(Mid(linealeida, InStr(linealeida, ",") + 1, 7), ")", " "))).ToString.Trim
                    If InStr(linealeida, "deathmatch") > 0 And InStr(linealeida, "teamdeathmatch") = 0 Then
                        If valorLeido = "0" Then
                            bountyShootout = "Bounty = No Limits"
                        Else
                            bountyShootout = "Bounty = " & valorLeido
                        End If
                    End If
                    If InStr(linealeida, "wanted") > 0 And InStr(linealeida, "teamwanted") = 0 Then
                        If valorLeido = "0" Then
                            bountyWanted = "Bounty = No Limits"
                        Else
                            bountyWanted = "Bounty = " & valorLeido
                        End If
                    End If

                    If InStr(linealeida, "teamdeathmatch") > 0 Then
                        If valorLeido = "0" Then
                            bountyPosse = "Bounty = No Limits"
                        Else
                            bountyPosse = "Bounty = " & valorLeido
                        End If
                    End If
                End If

                If InStr(linealeida, "PointsLimit(") Then
                    valorLeido = (Val(Replace(Mid(linealeida, InStr(linealeida, ",") + 1, 7), ")", " "))).ToString.Trim
                    If InStr(linealeida, "teamwanted") > 0 Then
                        If valorLeido = "0" Then
                            pointsManhunt = "Points = No Limits"
                        Else
                            pointsManhunt = "Points = " & valorLeido
                        End If
                    End If
                End If



            Loop
            readerConfig.Close()
        End If
    End Sub


    '***************************************************************************************
    '***************************************************************************************
    '******************Tab Players Subs*****************************************************
    '***************************************************************************************
    '***************************************************************************************
    Dim writer As StreamWriter

    Private Sub btnBan_Click(sender As Object, e As EventArgs) Handles btnBan.Click
        Dim Player As String = ""
        For i = 0 To LbPlayers.SelectedItems.Count - 1
            Player = LbPlayers.SelectedItems.Item(i)
            Player = RTrim(LTrim(Mid(Player, InStr(Player, "-") + 1, Len(Player) - InStr(Player, "-"))))
            If FindInListbox(lbBanned, Player) = False Then
                lbBanned.Items.Add(Mid(Date.Now.ToString, 1, 10) & "   " & Player & " ")

                'ACTIVAR LA SIGUIENTE LINEA CUANDO SE QUIERA EMPEZAR A BANEAR
                SendToConsole("/kick " & Player & " Banned by Mod Coj Controller")
            End If
        Next
        Call WriteFileBanned()
    End Sub

    Private Sub btnClearBan_Click(sender As Object, e As EventArgs) Handles btnClearBan.Click
        Do While lbBanned.SelectedItems.Count > 0
            lbBanned.Items.Remove(lbBanned.SelectedItems.Item(0))
        Loop
        Call WriteFileBanned()
    End Sub

    Private Sub WriteFileBanned()
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Banned.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\Banned.ini")
        End If
        writer = File.AppendText(rutaAppData & "\Config\Banned.ini")
        For i = 0 To lbBanned.Items.Count - 1
            writer.WriteLine(lbBanned.Items(i))
        Next
        writer.Close()

    End Sub

    Private Sub btnKick_Click(sender As Object, e As EventArgs) Handles btnKick.Click
        Dim Player As String = ""
        For i = 0 To LbPlayers.SelectedItems.Count - 1
            Player = (Mid(LbPlayers.SelectedItems.Item(i), 1, 7)).Trim
            If FindInListbox(lbAdmin, Player) = False Then
                SendToConsole("/kick " & Player & " " & cboxReason.Text.ToString & " (by Mods Coj Controller)")
            End If
        Next
    End Sub

    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        Dim Player As String = ""
        For i = 0 To LbPlayers.SelectedItems.Count - 1
            Player = (Mid(LbPlayers.SelectedItems.Item(i), 1, 7)).Trim
            SendToConsole("/kill " & Player)
        Next
    End Sub

    Private Sub ReadFilePlayer()
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Banned.ini") Then
            ' MsgBox(Application.StartupPath & "\Config\msg.ini")
            readerConfig = File.OpenText(rutaAppData & "\Config\Banned.ini")
            Do While readerConfig.EndOfStream = False
                lbBanned.Items.Add(readerConfig.ReadLine())
            Loop
            readerConfig.Close()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call writeLog()
    End Sub

    Private Sub TimerGetPlayerList_Tick(sender As Object, e As EventArgs) Handles TimerGetPlayerList.Tick
        TimerGetPlayerList.Enabled = False
        ' LbPlayers.Items.Clear()
        SendToConsole("/playerlist")
    End Sub

    Private Sub btnAddBannedTBox_Click(sender As Object, e As EventArgs) Handles btnAddBannedTBox.Click
        If FindInListbox(lbBanned, txtNewBanned.Text.Trim) = False And txtNewBanned.Text.Trim <> "" Then
            lbBanned.Items.Add(Mid(Date.Now.ToString, 1, 10) & "   " & txtNewBanned.Text.Trim & " ")
            SendToConsole("/kick " & txtNewBanned.Text.Trim)
            txtNewBanned.Text = ""
            Call WriteFileBanned()
        End If
    End Sub



    '***************************************************************************************
    '***************************************************************************************
    '******************Tab Players Admins*****************************************************
    '***************************************************************************************
    '***************************************************************************************

    'Chk para permitir o No, comandos de consola
    Private Sub chkCommandlistAd_CheckedChanged(sender As Object, e As EventArgs) Handles chkMapnext.CheckedChanged, chkCommandlistAd.CheckedChanged, chkNewadmin.CheckedChanged, chkKick.CheckedChanged, chkKill.CheckedChanged, chkBan.CheckedChanged, chkUnban.CheckedChanged, chkBanlist.CheckedChanged, chkPlayerlistAd.CheckedChanged, chkServershutdown.CheckedChanged, chkRestart.CheckedChanged, chkAdminsay.CheckedChanged, chkCommandlist.CheckedChanged, chkPlayerlist.CheckedChanged, chkVotemapnext.CheckedChanged, chkVoteBan.CheckedChanged, chkVotekick.CheckedChanged, chkMaplist.CheckedChanged, chkBalanceAd.CheckedChanged
        If FormCargado = False Then
            Exit Sub
        End If
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Commands.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\Commands.ini")
        End If
        writer = File.AppendText(rutaAppData & "\Config\Commands.ini")
        'Guardamos en un fichero el estado de cada checkBox de comandos
        writer.WriteLine(chkCommandlistAd.Checked)
        writer.WriteLine(chkNewadmin.Checked)
        writer.WriteLine(chkKill.Checked)
        writer.WriteLine(chkKick.Checked)
        writer.WriteLine(chkBan.Checked)
        writer.WriteLine(chkUnban.Checked)
        writer.WriteLine(chkBanlist.Checked)
        writer.WriteLine(chkPlayerlistAd.Checked)
        writer.WriteLine(chkServershutdown.Checked)
        writer.WriteLine(chkRestart.Checked)
        writer.WriteLine(chkMapnext.Checked)
        writer.WriteLine(chkAdminsay.Checked)
        writer.WriteLine(chkMaplistAd.Checked)
        writer.WriteLine(chkBalanceAd.Checked)
        writer.WriteLine(chkAddWord.Checked)
        writer.WriteLine(chkCommandlist.Checked)
        writer.WriteLine(chkPlayerlist.Checked)
        writer.WriteLine(chkVotemapnext.Checked)
        writer.WriteLine(chkMaplist.Checked)
        writer.WriteLine(chkVotekick.Checked)
        writer.WriteLine(chkVoteBan.Checked)
        writer.Close()

        Call CreaListaComandosActivos()
    End Sub

    'Lectura fichero commands.ini
    Private Sub ReadFileCommand()
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Commands.ini") Then
            readerConfig = File.OpenText(rutaAppData & "\Config\Commands.ini")

            Try
                chkCommandlistAd.Checked = readerConfig.ReadLine()
                chkNewadmin.Checked = readerConfig.ReadLine()
                chkKill.Checked = readerConfig.ReadLine()
                chkKick.Checked = readerConfig.ReadLine()
                chkBan.Checked = readerConfig.ReadLine()
                chkUnban.Checked = readerConfig.ReadLine()
                chkBanlist.Checked = readerConfig.ReadLine()
                chkPlayerlistAd.Checked = readerConfig.ReadLine()
                chkServershutdown.Checked = readerConfig.ReadLine()
                chkRestart.Checked = readerConfig.ReadLine()
                chkMapnext.Checked = readerConfig.ReadLine()
                chkAdminsay.Checked = readerConfig.ReadLine()
                chkMaplistAd.Checked = readerConfig.ReadLine()
                chkBalanceAd.Checked = readerConfig.ReadLine()
                chkAddWord.Checked = readerConfig.ReadLine()
                chkCommandlist.Checked = readerConfig.ReadLine()
                chkPlayerlist.Checked = readerConfig.ReadLine()
                chkVotemapnext.Checked = readerConfig.ReadLine()
                chkMaplist.Checked = readerConfig.ReadLine()
                chkVotekick.Checked = readerConfig.ReadLine()
                chkVoteBan.Checked = readerConfig.ReadLine()
            Catch ex As Exception

            End Try
            readerConfig.Close()
        End If
    End Sub

    Private Sub CreaListaComandosActivos()
        commandActivAdLin1 = ""
        commandActivAdLin2 = ""
        commandActivAdLin3 = ""
        commandActivGeneral = ""
        If chkCommandlistAd.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!commandlist  -  "
        End If
        If chkNewadmin.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!newadmin  -  "
        End If
        If chkKill.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!kill  -  "
        End If
        If chkKick.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!kick  -  "
        End If
        If chkBan.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!ban  -  "
        End If
        If chkUnban.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!unban  -  "
        End If
        If chkBanlist.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!banlist  -  "
        End If
        If chkPlayerlistAd.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!playerlist  -  "
        End If
        If chkServershutdown.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!servershutdown  -  "
        End If
        If chkRestart.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!restart  -  "
        End If
        If chkMapnext.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!mapnext  -  "
        End If
        If chkAdminsay.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!adminsay  -  "
        End If
        If chkMaplistAd.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!maplist  -  "
        End If
        If chkCommandlist.Checked = True Then
            commandActivGeneral = commandActivGeneral & "!commandlist  -  "
        End If
        If chkPlayerlist.Checked = True Then
            commandActivGeneral = commandActivGeneral & "!playerlist  -  "
        End If
        If chkVotemapnext.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!votemapnext  -  "
            commandActivGeneral = commandActivGeneral & "!votemapnext  -  "
        End If
        If chkMaplist.Checked = True Then
            commandActivGeneral = commandActivGeneral & "!maplist  -  "
        End If
        If chkVotekick.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!votekick  -  "
            commandActivGeneral = commandActivGeneral & "!votekick  -  "
        End If
        If chkVoteBan.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!voteban  -  "
            commandActivGeneral = commandActivGeneral & "!voteban  -  "
        End If
        If chkBalanceAd.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!balance yes/no -  "
        End If
        If chkAddWord.Checked = True Then
            commandActivAdLin1 = commandActivAdLin1 & "!addword <word> -  "
        End If

        Dim letra As String = ""
        Dim positionLetra As Integer = 100
        Do While Len(commandActivAdLin1) > 100 Or Len(commandActivAdLin2) > 100
            Do While letra <> "-"
                letra = Mid(commandActivAdLin1, positionLetra, 1)
                positionLetra = positionLetra - 1
            Loop
            If commandActivAdLin1.Length <= (positionLetra + 3) Then
                Exit Do
            Else
                commandActivAdLin2 = Trim(Mid(commandActivAdLin1, positionLetra + 3, Len(commandActivAdLin1) - (positionLetra + 3)))
                commandActivAdLin1 = Trim(Mid(commandActivAdLin1, 1, positionLetra - 1))
            End If

            letra = ""
            positionLetra = 100
            Do While letra <> "-"
                letra = Mid(commandActivAdLin2, positionLetra, 1)
                positionLetra = positionLetra - 1
            Loop

            If commandActivAdLin2.Length <= (positionLetra + 3) Then
                Exit Do
            Else
                commandActivAdLin3 = Trim(Mid(commandActivAdLin2, positionLetra + 3, Len(commandActivAdLin2) - (positionLetra + 3)))
                commandActivAdLin2 = Trim(Mid(commandActivAdLin2, 1, positionLetra - 1))
            End If
        Loop


    End Sub


    Private Sub btnDeleAdmin_Click(sender As Object, e As EventArgs) Handles btnDeleAdmin.Click
        Do While lbAdmin.SelectedItems.Count > 0
            SendToConsole("/adminsay " & lbAdmin.SelectedItems.Item(0) & " has been removed from Admins List.")
            lbAdmin.Items.Remove(lbAdmin.SelectedItems.Item(0))
        Loop
        Call WriteFileAdmins()
    End Sub

    Private Sub WriteFileAdmins()
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Admins.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\Admins.ini")
        End If
        writer = File.AppendText(rutaAppData & "\Config\Admins.ini")
        For i = 0 To lbAdmin.Items.Count - 1
            writer.WriteLine(lbAdmin.Items(i))
        Next
        writer.Close()

    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Dim Player As String = ""
        For i = 0 To lbPlayers2.SelectedItems.Count - 1
            Player = lbPlayers2.SelectedItems.Item(i)
            Player = RTrim(LTrim(Mid(Player, InStr(Player, "-") + 1, Len(Player) - InStr(Player, "-"))))
            If lbAdmin.Items.Contains(Player) = False Then
                lbAdmin.Items.Add(Player)
                SendToConsole("/adminsay " & Player & " has been added to Admins List.")
            End If
        Next
        Call WriteFileAdmins()
    End Sub

    Private Sub lbPlayers2_DoubleClick(sender As Object, e As EventArgs) Handles lbPlayers2.DoubleClick
        If lbPlayers2.SelectedItems.Count > 0 Then
            Dim Player As String = lbPlayers2.SelectedItems.Item(0)
            Player = RTrim(LTrim(Mid(Player, InStr(Player, "-") + 1, Len(Player) - InStr(Player, "-"))))
            lbAdmin.Items.Add(Player)
            SendToConsole("/adminsay " & Player & " has been added to Admins List.")
            Call WriteFileAdmins()
        End If
    End Sub

    Private Sub lbAdmin_DoubleClick(sender As Object, e As EventArgs) Handles lbAdmin.DoubleClick
        If lbAdmin.SelectedItems.Count > 0 Then
            SendToConsole("/adminsay " & lbAdmin.SelectedItems.Item(0) & " has been removed from Admins List.")
            lbAdmin.Items.Remove(lbAdmin.SelectedItems.Item(0))
            Call WriteFileAdmins()
        End If
    End Sub

    Private Sub ReadFileAdmin()
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Admins.ini") Then
            ' MsgBox(Application.StartupPath & "\Config\msg.ini")
            readerConfig = File.OpenText(rutaAppData & "\Config\Admins.ini")
            Do While readerConfig.EndOfStream = False
                lbAdmin.Items.Add(readerConfig.ReadLine())
            Loop
            readerConfig.Close()
        End If
    End Sub

    Private Sub btnAddAdminTbox_Click(sender As Object, e As EventArgs) Handles btnAddAdminTbox.Click
        If Not lbAdmin.Items.Contains(txtNewAdmin.Text.Trim) And txtNewAdmin.Text.Trim <> "" Then
            lbAdmin.Items.Add(txtNewAdmin.Text.Trim)
            txtNewAdmin.Text = ""
            Call WriteFileAdmins()
        End If
    End Sub


    '***************************************************************************************
    '***************************************************************************************
    '****************************Tab Old Console Logs***************************************
    '***************************************************************************************
    '***************************************************************************************

    Private Sub ReadFileLogs(FileLog As String)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Logs\" & FileLog) Then
            Dim linealeida As String = ""
            Dim FirstLine As String = ""
            readerConfig = File.OpenText(Application.StartupPath & "\Logs\" & FileLog)
            lbOldChats.Items.Clear()
            Do While readerConfig.EndOfStream = False
                linealeida = readerConfig.ReadLine()
                If FirstLine.Trim = "" Then FirstLine = Trim(Mid(linealeida, 1, 8))
                lbOldChats.Items.Add(linealeida)
            Loop
            readerConfig.Close()
            FirstLine = Mid(FirstLine, 1, Len(FirstLine) - 2)
            Dim dateChat As String = lbLogFilesList.SelectedItems.Item(0).ToString
            dateChat = Mid(dateChat, 9, 2) & "/" & Mid(dateChat, 6, 2) & "/" & Mid(dateChat, 1, 4) & " from " & FirstLine & " to " & Mid(dateChat, 12, 2) & ":" & Mid(dateChat, 15, 2)
            Label12.Text = "Chat from day  " & dateChat
        End If
    End Sub

    Private Sub lbLogFilesList_DoubleClick(sender As Object, e As EventArgs) Handles lbLogFilesList.DoubleClick, btnLoadLog.Click
        If lbLogFilesList.SelectedItems.Count > 0 Then
            Call ReadFileLogs(lbLogFilesList.SelectedItems.Item(0).ToString)
        End If
    End Sub


    'Busqueda en el list box
    Private Sub btnBuscaEnOldChat_Click() Handles btnBuscaEnOldChat.Click
        Static startIndex As Integer
        Static index As Integer

        ' Obtenemos la lista de elementos coincidentes
        Dim items As List(Of String) = ObtenerLista(txtFindInChat.Text)

        If ((items Is Nothing) OrElse (items.Count = 0)) Then
            ' No hay elementos coincidentes.
            lbOldChats.SelectedIndex = ListBox.NoMatches
            startIndex = 0
            index = 0
            Return
        End If

        Try
            startIndex = lbOldChats.FindString(items(index), startIndex)
        Catch ex As Exception

        End Try

        lbOldChats.SelectedIndex = startIndex

        index += 1
        If (index >= items.Count) Then index = 0
    End Sub
    'Funcion para busqueda en list box
    Private Function ObtenerLista(valor As String) As List(Of String)
        Dim query = From item As String In lbOldChats.Items.OfType(Of String)() _
                    Where item.ToUpperInvariant().Contains(valor.ToUpperInvariant()) _
                    Select item
        Return query.ToList()
    End Function


    Private Sub txtFindInChat_TextChanged(sender As Object, e As EventArgs) Handles txtFindInChat.TextChanged
        If txtFindInChat.Text.Length > 0 Then
            lblFindInChat.Visible = False
        Else
            lblFindInChat.Visible = True
        End If
    End Sub

    Private Sub lblFindInChat_Click(sender As Object, e As EventArgs) Handles lblFindInChat.Click
        txtFindInChat.Focus()
    End Sub

    Private Sub LoadListLogs()
        'Cargamos al ListBox todos los ficheros Logs
        Dim rutaLogs As String = Application.StartupPath & "\Logs"
        Dim Fich As String = ""
        lbLogFilesList.Items.AddRange(Directory.GetFiles(Application.StartupPath & "\Logs"))

        'Array donde pasaremos todos los ficheros para ordenarlos descendente y devolverlos al listbox
        Dim arrayList(lbLogFilesList.Items.Count - 1)
        For i = 0 To lbLogFilesList.Items.Count - 1
            Fich = lbLogFilesList.Items(i)
            arrayList(i) = Mid(Fich, InStr(Fich, "Logs\") + 5, Len(Fich) - InStr(Fich, "Logs\") + 5)
        Next

        'Ordenamos el array en sentido descendente, (ficheros mas nuevos arriba)
        Array.Sort(arrayList)
        Array.Reverse(arrayList)

        'vaciamos el listbox para llenarlo ordenado
        lbLogFilesList.Items.Clear()
        For i = 0 To arrayList.Count - 1
            lbLogFilesList.Items.Add(arrayList(i))
        Next

    End Sub

    Private Sub lbLogFilesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLogFilesList.SelectedIndexChanged
        lblQuantityLogs.Text = (lbLogFilesList.SelectedIndex + 1).ToString.Trim & "/" & (lbLogFilesList.Items.Count).ToString.Trim
    End Sub


    'Lectura fichero commands.ini
    Private Sub ReadAndWriteMapsInDedicatedServerSetting()
        If My.Computer.FileSystem.FileExists(ruta & "\CoJ2\DedicatedServerSettings.ini") Then

            '*****************Leemos el fichero DedicatedServerSetting para modificar orden de mapas*****************
            readerConfig = File.OpenText(ruta & "\CoJ2\DedicatedServerSettings.ini")

            Dim NumLineas As Integer = 0
            Do While readerConfig.EndOfStream = False
                readerConfig.ReadLine()
                NumLineas = NumLineas + 1
            Loop
            readerConfig.Close()

            readerConfig = File.OpenText(ruta & "\CoJ2\DedicatedServerSettings.ini")
            Dim arrLineaLeida(NumLineas) As String
            Dim LineaDgridMap As Integer = 0
            Dim mapa As String = ""
            Dim modo As String = ""
            For i = 0 To NumLineas
                arrLineaLeida(i) = readerConfig.ReadLine()
                If Mid(arrLineaLeida(i), 1, 4) = "Map(" Then
                    Try
                        mapa = dgMaps.Rows(LineaDgridMap).Cells(0).Value.ToString.Trim
                        If mapa = "Taos Pueblo" Then mapa = "Adobes"
                        If mapa = "Burnside's Bridge" Then mapa = "Civil"
                        If mapa = "Nogales" Then mapa = "PrisonBreak2"
                        If mapa = "Stinking Springs" Then mapa = "StinkingSprings2"

                        modo = dgMaps.Rows(LineaDgridMap).Cells(1).Value.ToString.Trim
                        If modo = "<Manhunt>" Then modo = "teamwanted"
                        If modo = "<Posse>" Then modo = "teamdeathmatch"
                        If modo = "<Shootout>" Then modo = "deathmatch"
                        If modo = "<Wanted>" Then modo = "wanted"
                        If modo = "<W.W.Legends>" Then modo = "historical"

                        'Map("Adobes", "deathmatch")

                        arrLineaLeida(i) = "Map(""" & mapa & """, """ & modo & """)"
                        LineaDgridMap = LineaDgridMap + 1
                    Catch ex As Exception

                    End Try
                   
                End If
            Next
            readerConfig.Close()

            '**************Volvemos a escribir DedicatedServerSetting con otro orden de mapas***************
            My.Computer.FileSystem.DeleteFile(ruta & "\CoJ2\DedicatedServerSettings.ini")

            writer = File.AppendText(ruta & "\CoJ2\DedicatedServerSettings.ini")

            For i = 0 To NumLineas
                writer.WriteLine(arrLineaLeida(i))
            Next
            writer.Close()
        End If
    End Sub

    '***************************************************************************************
    '***************************************************************************************
    '********************************** Tab Mapas  *****************************************
    '***************************************************************************************
    '***************************************************************************************

    Private Sub chkRememberMaps_CheckedChanged(sender As Object, e As EventArgs) Handles chkRememberMaps.CheckedChanged
        If FormCargado = False Then
            Exit Sub
        End If

        'Escribimos el fichero de configuración para recordar el estado del checkbox al iniciar
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Maps.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\Maps.ini")
        End If
        writer = File.AppendText(rutaAppData & "\Config\Maps.ini")
        'Guardamos en un fichero el estado de cada checkBox de comandos
        writer.WriteLine(chkRememberMaps.Checked)
        writer.Close()
    End Sub

    'Lectura fichero commands.ini
    Private Sub ReadCheckMaps()
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\Maps.ini") Then
            readerConfig = File.OpenText(rutaAppData & "\Config\Maps.ini")

            Try
                chkRememberMaps.Checked = readerConfig.ReadLine()
            Catch ex As Exception

            End Try
            readerConfig.Close()
        End If
    End Sub


    '***************************************************************************************
    '***************************************************************************************
    '********************************** Tab Rules  *****************************************
    '***************************************************************************************
    '***************************************************************************************
    Private Sub btnAddWord_Click() Handles btnAddWord.Click
        If txtAddWords.Text.Trim <> "" And lbWords.Items.Contains(txtAddWords.Text.Trim) = False Then
            AddItemsToListBoxOrdered(lbWords, txtAddWords.Text.Trim)
            Call WriteFileTabRules()
        End If
        txtAddWords.Text = ""
    End Sub

    Private Sub chkCleanPlayersWarned_CheckedChanged(sender As Object, e As EventArgs) Handles chkCleanPlayersWarned.CheckedChanged
        If FormCargado = True And TabPanel1.SelectedTab.Name = TabRules.Name Then Call WriteFileTabRules()
    End Sub

    Private Sub rbWordsKill_CheckedChanged(sender As Object, e As EventArgs) Handles rbWordsKill.CheckedChanged
        cboxWordKillEachTimes.Enabled = True
        cboxWordBanEachTimes.Enabled = False
        cboxWordKickEachTimes.Enabled = False
        If FormCargado = True And TabPanel1.SelectedTab.Name = TabRules.Name Then Call WriteFileTabRules()
    End Sub

    Private Sub rbWordsKick_CheckedChanged(sender As Object, e As EventArgs) Handles rbWordsKick.CheckedChanged
        cboxWordKillEachTimes.Enabled = False
        cboxWordBanEachTimes.Enabled = False
        cboxWordKickEachTimes.Enabled = True
        If FormCargado = True And TabPanel1.SelectedTab.Name = TabRules.Name Then Call WriteFileTabRules()
    End Sub

    Private Sub rbWordsBan_CheckedChanged(sender As Object, e As EventArgs) Handles rbWordsBan.CheckedChanged
        cboxWordKillEachTimes.Enabled = False
        cboxWordBanEachTimes.Enabled = True
        cboxWordKickEachTimes.Enabled = False
        If FormCargado = True And TabPanel1.SelectedTab.Name = TabRules.Name Then Call WriteFileTabRules()
    End Sub

    Private Sub rbWordsSendWarning_CheckedChanged(sender As Object, e As EventArgs) Handles rbWordsSendWarning.CheckedChanged
        cboxWordKillEachTimes.Enabled = False
        cboxWordBanEachTimes.Enabled = False
        cboxWordKickEachTimes.Enabled = False
        If FormCargado = True And TabPanel1.SelectedTab.Name = TabRules.Name Then Call WriteFileTabRules()
    End Sub

    Private Sub btnRemoveWords_Click(sender As Object, e As EventArgs) Handles btnRemoveWords.Click
        Do While lbWords.SelectedItems.Count > 0
            lbWords.Items.Remove(lbWords.SelectedItems.Item(0))
        Loop
        Call WriteFileTabRules()
    End Sub


    Private Sub txtWarningWords_Validated(sender As Object, e As EventArgs) Handles txtWarningWords.Validated
        Call WriteFileTabRules()
    End Sub

    Private Sub cboxWordKillEachTimes_TextChanged(sender As Object, e As EventArgs) Handles cboxWordKillEachTimes.TextChanged, cboxWordKickEachTimes.TextChanged, cboxWordBanEachTimes.TextChanged
        If FormCargado = True And TabPanel1.SelectedTab.Name = TabRules.Name Then Call WriteFileTabRules()
    End Sub


    'Escritura del fichero rules.ini
    Private Sub WriteFileTabRules()
        My.Computer.FileSystem.CreateDirectory(rutaAppData & "\Config")
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\rules.ini") Then
            My.Computer.FileSystem.DeleteFile(rutaAppData & "\Config\rules.ini")
        End If
        Try
            writer = File.AppendText(rutaAppData & "\Config\rules.ini")
            writer.WriteLine(chkCleanPlayersWarned.Checked)
            writer.WriteLine(rbWordsSendWarning.Checked)
            writer.WriteLine(rbWordsKill.Checked)
            writer.WriteLine(rbWordsKick.Checked)
            writer.WriteLine(rbWordsBan.Checked)
            writer.WriteLine(cboxWordKillEachTimes.Text)
            writer.WriteLine(cboxWordKickEachTimes.Text)
            writer.WriteLine(cboxWordBanEachTimes.Text)
            writer.WriteLine(txtWarningWords.Text)
            writer.WriteLine("-Words-")
            For i = 0 To lbWords.Items.Count - 1
                writer.WriteLine(lbWords.Items(i))
            Next
        Catch ex As Exception

        End Try

        writer.Close()
    End Sub

    'Lectura fichero rules.ini
    Private Sub ReadFileTabRules()
        If My.Computer.FileSystem.FileExists(rutaAppData & "\Config\rules.ini") Then
            readerConfig = File.OpenText(rutaAppData & "\Config\rules.ini")

            Try
                'Leemos la configuración de las reglas
                chkCleanPlayersWarned.Checked = readerConfig.ReadLine()
                rbWordsSendWarning.Checked = readerConfig.ReadLine()
                rbWordsKill.Checked = readerConfig.ReadLine()
                rbWordsKick.Checked = readerConfig.ReadLine()
                rbWordsBan.Checked = readerConfig.ReadLine()
                cboxWordKillEachTimes.Text = readerConfig.ReadLine()
                cboxWordKickEachTimes.Text = readerConfig.ReadLine()
                cboxWordBanEachTimes.Text = readerConfig.ReadLine()
                txtWarningWords.Text = readerConfig.ReadLine()
                readerConfig.ReadLine()

                'A partir de la siguiente línea leemos todas las palabras prohibidas de la lista
                Do While readerConfig.EndOfStream = False
                    lbWords.Items.Add(readerConfig.ReadLine())
                Loop
            Catch ex As Exception

            End Try
            readerConfig.Close()
        End If
    End Sub

    Private Sub CheckRules(Player As String, Warnings As Integer)
        If rbWordsSendWarning.Checked = True Then
            SendToConsole("/adminsay " & txtWarningWords.Text & " (" & Player & ").")
        ElseIf rbWordsKill.Checked = True Then
            If Val(cboxWordKillEachTimes.Text) <= Warnings Then
                SendToConsole("/kill " & Player)
                SendToConsole("/adminsay " & Player & " was killed by Mods Coj2 Controller. Limit reached warnings. (" & Warnings & "/" & cboxWordKillEachTimes.Text.Trim & ").")
            Else
                SendToConsole("/adminsay " & txtWarningWords.Text & " " & Player & " will be killed from " & cboxWordKillEachTimes.Text.Trim & " warnings" & " (" & Player & ").")
            End If

        ElseIf rbWordsKick.Checked = True Then
            If Val(cboxWordKickEachTimes.Text) <= Warnings And FindInListbox(lbBanned, Player) = False Then
                SendToConsole("/kick " & Player & " Limit reached warnings. (" & Warnings & "/" & cboxWordKickEachTimes.Text.Trim & ")")
                SendToConsole("/adminsay " & Player & " was kicked by Mods Coj2 Controller. Limit reached warnings. (" & Warnings & "/" & cboxWordKickEachTimes.Text.Trim & ").")
            Else
                SendToConsole("/adminsay " & txtWarningWords.Text & " " & Player & " will be kicked out from " & cboxWordKickEachTimes.Text.Trim & " warnings" & " (" & Player & ").")
            End If

        ElseIf rbWordsBan.Checked = True Then
            If Val(cboxWordBanEachTimes.Text) <= Warnings And FindInListbox(lbBanned, Player) = False Then
                '                AddItemsToListBoxOrdered(lbBanned, Player)
                lbBanned.Items.Add(Mid(Date.Now.ToString, 1, 10) & "   " & Player & " ")
                SendToConsole("/kick " & Player & " Limit reached warnings. (" & Warnings & "/" & cboxWordBanEachTimes.Text.Trim & ")")
                SendToConsole("/adminsay " & Player & " was banned by Mods Coj2 Controller. Limit reached warnings. (" & Warnings & "/" & cboxWordBanEachTimes.Text.Trim & ").")
            Else
                SendToConsole("/adminsay " & txtWarningWords.Text & " " & Player & " will be banned from " & cboxWordBanEachTimes.Text.Trim & " warnings" & " (" & Player & ").")
            End If

        End If
    End Sub


    '***************************************************************************************
    '***************************************************************************************
    '**************************** Control de teclas  ***************************************
    '***************************************************************************************
    '***************************************************************************************


    Private Sub frmConsola_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            vHwnd = FindWindow("ConsoleWindowClass", vbNullString)
            'MsgBox(vHwnd.ToString)
        End If

        If e.KeyCode = Keys.F1 Then
            Call btnHelp_Click()
        End If

        If e.KeyCode = Keys.F3 Then
            If TabPanel1.SelectedTab.Name = TabLogs.Name Then
                Call btnBuscaEnOldChat_Click()
            End If
        End If

        'TECLAS TAB CHAT
        If TabPanel1.SelectedTab.Name = TabChat.Name Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                btnEnviar_Click()
            End If
        End If

        'TECLAS TAB RULES
        If TabPanel1.SelectedTab.Name = TabRules.Name Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                btnAddWord_Click()
            End If
        End If

    End Sub


    Private Sub btnDeleteLog_Click(sender As Object, e As EventArgs) Handles btnDeleteLog.Click
        Do While lbLogFilesList.SelectedItems.Count > 0
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Logs\" & lbLogFilesList.SelectedItems.Item(0).trim) Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Logs\" & lbLogFilesList.SelectedItems.Item(0).trim)
            End If
            lbLogFilesList.Items.Remove(lbLogFilesList.SelectedItems.Item(0))
        Loop
    End Sub

    Private Sub TimerGetMapList_Tick(sender As Object, e As EventArgs) Handles TimerGetMapList.Tick
        TimerGetMapList.Enabled = False
    End Sub


    Private Sub chkBalance2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBalance2.CheckedChanged
        If chkBalance2.Checked = True And chkBalance.Checked = False Then
            chkBalance.Checked = True
            Exit Sub
        ElseIf chkBalance2.Checked = False And chkBalance.Checked = True Then
            chkBalance.Checked = False
            Exit Sub
        End If
        If chkBalance2.Checked = True And LoadingMap = False Then
            SendToConsole("/adminsay Activated automatic team BALANCE in the Server. Please, BOTH teams have to be BALANCED NOW.")
            SendToConsole("/adminsay Last players who joined to the larger team will be 'killed' by the server  every 5 seconds.")
            If Val(Replace(((Val(lblTeamBlue.Text) - Val(lblTeamRed.Text)).ToString), "-", " ")) >= 2 Then changedTeam = True
        ElseIf chkBalance2.Checked = False And LoadingMap = False Then
            SendToConsole("/adminsay Deactivated automatic balance team.")
            TimerKillBalance.Enabled = False
        End If
    End Sub

    Private Sub chkBalance_CheckedChanged(sender As Object, e As EventArgs) Handles chkBalance.CheckedChanged
        If chkBalance.Checked = True And chkBalance2.Checked = False Then
            chkBalance2.Checked = True
            Exit Sub
        ElseIf chkBalance.Checked = False And chkBalance2.Checked = True Then
            chkBalance2.Checked = False
            Exit Sub
        End If

        If chkBalance.Checked = True And LoadingMap = False Then
            SendToConsole("/adminsay Activated automatic team BALANCE in the Server. Please, BOTH teams have to be BALANCED NOW.")
            SendToConsole("/adminsay Last players who joined to the larger team will be 'killed' by the server  every 5 seconds.")
            If Val(Replace(((Val(lblTeamBlue.Text) - Val(lblTeamRed.Text)).ToString), "-", " ")) >= 2 Then changedTeam = True
        ElseIf chkBalance.Checked = False And LoadingMap = False Then
            SendToConsole("/adminsay Deactivated automatic balance team.")
            TimerKillBalance.Enabled = False
        End If
    End Sub


    'Private Sub lblTeamRed_TextChanged(sender As Object, e As EventArgs) Handles lblTeamRed.TextChanged, lblTeamBlue.TextChanged
    '    ' MsgBox(((Val(lblTeamBlue.Text) - Val(lblTeamRed.Text)).ToString))
    '    Dim variableprueba As Integer = Val(Replace(((Val(lblTeamBlue.Text) - Val(lblTeamRed.Text)).ToString), "-", " "))

    'End Sub
    Dim CiclosBalance As Integer = 0
    Private Sub TimerKillBalance_Tick(sender As Object, e As EventArgs) Handles TimerKillBalance.Tick
        If LoadingMap = True Then
            Exit Sub
        End If
        CiclosBalance = CiclosBalance + 1
        If CiclosBalance >= 5 Then
            If lbBlueTeam.Items.Count > lbRedTeam.Items.Count Then ' MÁS EN EL AZUL
                SendToConsole("/kill " & lbBlueTeam.Items(lbBlueTeam.Items.Count - 1))
                SendToConsole("/adminsay Killing will stop when teams are balanced (" & lbBlueTeam.Items(lbBlueTeam.Items.Count - 1) & ").")
            ElseIf lbBlueTeam.Items.Count < lbRedTeam.Items.Count Then ' MÁS EN EL ROJO
                SendToConsole("/kill " & lbRedTeam.Items(lbRedTeam.Items.Count - 1))
                SendToConsole("/adminsay Killing will stop when teams are balanced (" & lbRedTeam.Items(lbRedTeam.Items.Count - 1) & ").")
            End If
        ElseIf CiclosBalance = 3 Then
            If lbBlueTeam.Items.Count > lbRedTeam.Items.Count Then ' MÁS EN EL AZUL
                SendToConsole("/adminsay Starting to kill in 10 seconds if teams keep unbalanced (" & lbBlueTeam.Items(lbBlueTeam.Items.Count - 1) & ").")
            ElseIf lbBlueTeam.Items.Count < lbRedTeam.Items.Count Then ' MÁS EN EL ROJO
                SendToConsole("/adminsay Starting to kill in 10 seconds if teams keep unbalanced (" & lbRedTeam.Items(lbRedTeam.Items.Count - 1) & ").")
            End If
        End If


    End Sub


    Private Sub btnKickRed_Click(sender As Object, e As EventArgs) Handles btnKickRed.Click
        Dim Player As String = ""
        For i = 0 To lbRedTeam.SelectedItems.Count - 1
            Player = (Mid(lbRedTeam.SelectedItems.Item(i), 1, 7)).Trim
            SendToConsole("/kick " & Player & " " & cboxReasonRed.Text.ToString & " (by Mods Coj Controller)")
        Next
    End Sub

    Private Sub btnKickBlue_Click(sender As Object, e As EventArgs) Handles btnKickBlue.Click
        Dim Player As String = ""
        For i = 0 To lbBlueTeam.SelectedItems.Count - 1
            Player = (Mid(lbBlueTeam.SelectedItems.Item(i), 1, 7)).Trim
            SendToConsole("/kick " & Player & " " & cboxReasonBlue.Text.ToString & " (by Mods Coj Controller)")
        Next
    End Sub

    Private Sub btnKillRed_Click(sender As Object, e As EventArgs) Handles btnKillRed.Click
        Dim Player As String = ""
        For i = 0 To lbRedTeam.SelectedItems.Count - 1
            Player = (Mid(lbRedTeam.SelectedItems.Item(i), 1, 7)).Trim
            SendToConsole("/kill " & Player)
        Next
    End Sub

    Private Sub btnKillBlue_Click(sender As Object, e As EventArgs) Handles btnKillBlue.Click
        Dim Player As String = ""
        For i = 0 To lbBlueTeam.SelectedItems.Count - 1
            Player = (Mid(lbBlueTeam.SelectedItems.Item(i), 1, 7)).Trim
            SendToConsole("/kill " & Player)
        Next
    End Sub

    Private Function FindInListbox(lb As ListBox, findWord As String)
        findWord = findWord & " "
        For i = 0 To lb.Items.Count - 1
            If InStr(lb.Items(i), findWord) > 0 Then
                Return True
            End If
        Next
        Return False
    End Function


    'Subrutina para Ordenar los ListBox cuando añadimos un item
    Private Sub AddItemsToListBoxOrdered(lb As ListBox, itemToAdd As String)
        lb.Items.Add(itemToAdd)
        'Array donde pasaremos todos los ficheros para ordenarlos descendente y devolverlos al listbox
        Dim arrayToOrder(lb.Items.Count - 1)
        For i = 0 To lb.Items.Count - 1
            arrayToOrder(i) = lb.Items(i)
        Next

        'Ordenamos el array 
        Array.Sort(arrayToOrder)

        'vaciamos el listbox para llenarlo ordenado
        lb.Items.Clear()

        lb.Items.AddRange(arrayToOrder)
    End Sub

  
    Private Sub btnHelp_Click() Handles btnHelp.Click
        Cursor = Cursors.WaitCursor
        Help.ShowHelp(Me, Application.StartupPath & "\CoJ Mods.chm")
        Cursor = Cursors.Default
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

    End Sub
End Class