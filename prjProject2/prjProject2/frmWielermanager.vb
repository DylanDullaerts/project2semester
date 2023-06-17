Imports System.IO

Public Class frmWielermanager
    Dim strTitelsWielermanager(intcstAantalTitelsWielermanager) As String
    Dim strKoersen(intcstAantalTitelsWielermanager) As String 'Het aantal koersen komt overeen met die constante en dus is deze methode
    'flexibeler in het geval dat in de toekomst het aantal koersen verandert.
    Dim intPuntenKoersen(2, 25) As Integer



    Private Sub frmWielermanager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBoodschap.Text = ""
        lblLstbUitleg.Text = ""
        btnOverzicht.Visible = False
        Me.Text = strManager & "manager"
        'lstbOverzichtKoersen.Visible = False
        Call initialiseer_punten()
        Call lees_overzicht_koersen()
        Call lees_titels_wielermanager()
        Call initialiseer_dgv()
        Call initialiseer_dgv_uitslag()
        'Call lees_bestand_uitslag_omloop()
        Call lees_stand_wielermanager()
        Call voeg_punten_toe()
        dgvUitslagKoers.Visible = False

    End Sub
    Sub lees_stand_wielermanager()
        Dim strBestand, strLijn As String
        Dim intFree, intTeller, intFout As Integer

        strBestand = Application.StartupPath & "\bestanden\wielermanager\wielermanager.csv"
        intFree = FreeFile()
        intTeller = 0
        intFout = 0

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                intTeller = intTeller + 1
                Call zet_lijn_in_dgv_wielermanager(strLijn, intTeller)

            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
            intFout = -1
        End Try
        FileClose(intFree)
        If intFout = -1 Then
            lblBoodschap.Text = ""
            Try 
                intFree = FreeFile()
                FileOpen(intFree, strBestand, OpenMode.Output)
            Catch ex As Exception
                lblBoodschap.Text = ex.Message
            End Try
            FileClose(intFree)
        End If
    End Sub
    Sub zet_lijn_in_dgv_wielermanager(ByRef strGelezenLijn, ByVal intPlaats)
        Dim strDeelLijn As String
        Dim intPositie, intKolom As Integer

        strDeelLijn = strGelezenLijn
        intPositie = 0
        intKolom = 0

        dgvWielermanager.Rows.Add()

        While InStr(strDeelLijn, ";") > 0
            intPositie = InStr(strDeelLijn, ";")
            dgvWielermanager.Rows(intPlaats - 1).Cells(intKolom).Value = Mid(strDeelLijn, 1, intPositie - 1)
            intKolom = intKolom + 1
            strDeelLijn = Mid(strDeelLijn, intPositie, Len(strDeelLijn))
        End While

    End Sub
    Sub initialiseer_punten()

        ' Puntenverdeling per plaats in de monumenten
        intPuntenKoersen(0, 0) = 100
        intPuntenKoersen(0, 1) = 80
        intPuntenKoersen(0, 2) = 65
        intPuntenKoersen(0, 3) = 55
        intPuntenKoersen(0, 4) = 45
        intPuntenKoersen(0, 5) = 35
        intPuntenKoersen(0, 6) = 30
        intPuntenKoersen(0, 7) = 25
        intPuntenKoersen(0, 8) = 20
        intPuntenKoersen(0, 9) = 17
        intPuntenKoersen(0, 10) = 14
        intPuntenKoersen(0, 11) = 12
        intPuntenKoersen(0, 12) = 10
        intPuntenKoersen(0, 13) = 8
        intPuntenKoersen(0, 14) = 7
        intPuntenKoersen(0, 15) = 6
        intPuntenKoersen(0, 16) = 6
        intPuntenKoersen(0, 17) = 6
        intPuntenKoersen(0, 18) = 6
        intPuntenKoersen(0, 19) = 6
        intPuntenKoersen(0, 20) = 4
        intPuntenKoersen(0, 21) = 4
        intPuntenKoersen(0, 22) = 4
        intPuntenKoersen(0, 23) = 4
        intPuntenKoersen(0, 24) = 4
        intPuntenKoersen(0, 25) = 2

        ' Puntenverdeling per plaats in World Tour-wedstrijden
        intPuntenKoersen(1, 0) = 80
        intPuntenKoersen(1, 1) = 64
        intPuntenKoersen(1, 2) = 52
        intPuntenKoersen(1, 3) = 44
        intPuntenKoersen(1, 4) = 36
        intPuntenKoersen(1, 5) = 28
        intPuntenKoersen(1, 6) = 24
        intPuntenKoersen(1, 7) = 20
        intPuntenKoersen(1, 8) = 16
        intPuntenKoersen(1, 9) = 14
        intPuntenKoersen(1, 10) = 11
        intPuntenKoersen(1, 11) = 10
        intPuntenKoersen(1, 12) = 8
        intPuntenKoersen(1, 13) = 6
        intPuntenKoersen(1, 14) = 6
        intPuntenKoersen(1, 15) = 5
        intPuntenKoersen(1, 16) = 5
        intPuntenKoersen(1, 17) = 5
        intPuntenKoersen(1, 18) = 5
        intPuntenKoersen(1, 19) = 5
        intPuntenKoersen(1, 20) = 3
        intPuntenKoersen(1, 21) = 3
        intPuntenKoersen(1, 22) = 3
        intPuntenKoersen(1, 23) = 3
        intPuntenKoersen(1, 24) = 3
        intPuntenKoersen(1, 25) = 1

        ' Puntenverdeling per plaats in niet-World Tour-wedstrijden
        intPuntenKoersen(2, 0) = 60
        intPuntenKoersen(2, 1) = 48
        intPuntenKoersen(2, 2) = 39
        intPuntenKoersen(2, 3) = 33
        intPuntenKoersen(2, 4) = 27
        intPuntenKoersen(2, 5) = 21
        intPuntenKoersen(2, 6) = 18
        intPuntenKoersen(2, 7) = 15
        intPuntenKoersen(2, 8) = 12
        intPuntenKoersen(2, 9) = 10
        intPuntenKoersen(2, 10) = 8
        intPuntenKoersen(2, 11) = 7
        intPuntenKoersen(2, 12) = 6
        intPuntenKoersen(2, 13) = 5
        intPuntenKoersen(2, 14) = 4
        intPuntenKoersen(2, 15) = 4
        intPuntenKoersen(2, 16) = 3
        intPuntenKoersen(2, 17) = 3
        intPuntenKoersen(2, 18) = 3
        intPuntenKoersen(2, 19) = 3
        intPuntenKoersen(2, 20) = 2
        intPuntenKoersen(2, 21) = 2
        intPuntenKoersen(2, 22) = 2
        intPuntenKoersen(2, 23) = 2
        intPuntenKoersen(2, 24) = 2
        intPuntenKoersen(2, 25) = 1

    End Sub
    Sub voeg_punten_toe()
        'Deze sub wordt nog niet gecalld, hier ga ik elke renner toevoegen aan de 1e dgv.
        'Ik check per renner, dus per lijn uit de 2e dgv, hoeveel punten ze verdiend hebben en dit sla ik op in de 1e dgv.
        'Wanneer ik dan een sub maak die werkt voor alle koersen, moet ik eerst testen of de renner al in de 1e dgv staat.

        Dim strMap, strBestand, strLijn, strRenner, strCategorie, strOverzichtKoers As String
        Dim intTeller, intFree, intFout, intPlaats, intTellerControle, intPositie, intPositie2, intPunten, intTellerRenner As Integer
        'De intPositie dient twee maal om de positie van de puntkomma in een lijn te bepalen.

        intFout = 0
        intPositie = 0
        intPositie2 = 0
        intPlaats = 0

        strMap = Application.StartupPath & "\bestanden\koersen"

        For intTeller = 0 To intcstAantalTitelsWielermanager
            strBestand = strMap & "\" & strKoersen(intTeller) & ".csv"
            intFree = FreeFile()
            Try
                FileOpen(intFree, strBestand, OpenMode.Input)
                While Not EOF(intFree)
                    strLijn = LineInput(intFree)
                    intPlaats = intPlaats + 1
                    If strLijn = "" Then
                        lblBoodschap.Text = lblBoodschap.Text & "De uitslag van " & strKoersen(intTeller) & " is niet toegevoegd."
                    Else
                        If InStr(strLijn, ";") > 0 Then
                            intPositie2 = InStr(strLijn, ";")
                        End If
                        strRenner = Mid(strLijn, intPositie2 + 1, Len(strLijn))
                        For intTellerControle = 0 To lstbOverzichtKoersen.Items.Count - 1
                            strOverzichtKoers = lstbOverzichtKoersen.Items.Item(intTellerControle)
                            intPositie = InStr(strOverzichtKoers, ";")
                            If Mid(strOverzichtKoers, 1, intPositie - 1) = strKoersen(intTeller) Then
                                strCategorie = Trim(Mid(strOverzichtKoers, intPositie + 1, Len(strOverzichtKoers)))
                                Select Case strCategorie
                                    Case "M"
                                        If intPlaats > 26 Then
                                            intPunten = intPuntenKoersen(0, 25)
                                        Else
                                            intPunten = intPuntenKoersen(0, intPlaats - 1)
                                        End If
                                    Case "WT"
                                        If intPlaats > 26 Then
                                            intPunten = intPuntenKoersen(1, 25)
                                        Else
                                            intPunten = intPuntenKoersen(1, intPlaats - 1)
                                        End If
                                    Case "nWT"
                                        If intPlaats > 26 Then
                                            intPunten = intPuntenKoersen(2, 25)
                                        Else
                                            intPunten = intPuntenKoersen(2, intPlaats - 1)
                                        End If
                                End Select
                            End If
                        Next
                        For intTellerRenner = 0 To dgvWielermanager.RowCount - 1
                            If strRenner = dgvWielermanager.Rows(1).Cells(intTellerRenner).Value Then
                                dgvWielermanager.Rows(intTellerRenner).Cells(intTeller + 2).Value = intPunten
                            Else
                                dgvWielermanager.Rows.Add()
                                dgvWielermanager.Rows(dgvWielermanager.RowCount - 1).Cells(intTeller + 2).Value = intPunten
                            End If
                        Next

                    End If

                End While
            Catch ex As Exception
                lblBoodschap.Text = ex.Message
                intFout = -1
            End Try
            FileClose(intFree)
            'If intFout = -1 Then
            '    lblBoodschap.Text = ""
            '    Try 'Dit is een tweede Try, Catch om de bestanden aan te maken wanneer ze nog niet bestaan, anders crasht mijn programma 
            '        'als het bestand niet bestaat. Dit zou een probleem geven wanneer nog niet alle koersen gereden zijn en er dus ook geen
            '        'uitslag van bestaat.
            '        intFree = FreeFile()
            '        FileOpen(intFree, strBestand, OpenMode.Output)
            '    Catch ex As Exception
            '        lblBoodschap.Text = ex.Message
            '    End Try
            '    FileClose(intFree)
            'End If

        Next



    End Sub
    Sub initialiseer_dgv_uitslag()
        dgvUitslagKoers.ColumnCount = intcstAantalTitels
        'dgvUitslagKoers.Rows.Add()
        dgvUitslagKoers.Columns(0).HeaderCell.Value = strTitels(0)
        dgvUitslagKoers.Columns(1).HeaderCell.Value = strTitels(1)
        dgvUitslagKoers.Columns(2).HeaderCell.Value = strTitels(2)
        dgvUitslagKoers.Columns(3).HeaderCell.Value = strTitels(3)

    End Sub
    'Sub lees_bestand_uitslag_omloop()
    '    'Dit is een testsub omdat er nog maar één uitslag beschikbaar is, deze wordt nog nergens gecalld.
    '    'Eerst volledig uitwerken, callen waar nodig en uitvoerig testen.
    '    'Daarna deze code omzetten naar een code die werkt voor alle koersen die meetellen voor de wielermanager.

    '    Dim strBestand, strLijn As String
    '    Dim intTeller, intFree As Integer



    '    intTeller = 0
    '    intFree = FreeFile()

    '    strBestand = Application.StartupPath & "\bestanden\koersen\Omloop Het Nieuwsblad.csv"

    '    Try
    '        FileOpen(intFree, strBestand, OpenMode.Input)
    '        While Not EOF(intFree)
    '            strLijn = LineInput(intFree)
    '            intTeller = intTeller + 1
    '            Call zet_lijn_in_dgv(strLijn, intTeller)

    '        End While
    '    Catch ex As Exception
    '        lblBoodschap.Text = ex.Message
    '    End Try

    '    FileClose(intFree)

    'End Sub
    Sub zet_lijn_in_dgv_uitslag(ByRef strLijnGelezen As String, ByVal intLijnNummer As Integer)
        Dim strDeelLijn As String
        Dim intPositie, intKolom As Integer
        intPositie = 0
        intKolom = 0
        strDeelLijn = strLijnGelezen
        dgvUitslagKoers.Rows.Add()
        While InStr(strDeelLijn, ";") > 0
            intPositie = InStr(strDeelLijn, ";")
            dgvUitslagKoers.Rows(intLijnNummer - 1).Cells(intKolom).Value = Mid(strDeelLijn, 1, intPositie - 1)
            intKolom = intKolom + 1
            strDeelLijn = Mid(strDeelLijn, intPositie + 1, Len(strDeelLijn))

        End While

    End Sub
    'Sub lees_bestanden_uitslagen()
    '    Dim intTeller, intFree As Integer
    '    Dim strBestand As String

    '    For intTeller = 0 To intcstAantalTitelsWielermanager

    '    Next
    'End Sub
    Sub lees_titels_wielermanager()
        Dim intFree, intTeller As Integer
        Dim strBestand As String

        intFree = FreeFile()
        intTeller = 0
        strBestand = Application.StartupPath & "\bestanden\titels wielermanager.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strTitelsWielermanager(intTeller) = LineInput(intFree)
                intTeller = intTeller + 1
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message

        End Try

        FileClose(intFree)
    End Sub
    Sub lees_overzicht_koersen()

        Dim intFree, intIndex, intTeller As Integer
        Dim strBestand, strLijn As String

        intIndex = 0
        intTeller = 0

        If strManager = "Sporza Wieler" Then
            intFree = FreeFile()
            strBestand = Application.StartupPath & "\bestanden\koersen\Koersen Wielermanager voorjaar.txt"

            Try
                FileOpen(intFree, strBestand, OpenMode.Input)
                While Not EOF(intFree)
                    strLijn = LineInput(intFree)
                    lstbOverzichtKoersen.Items.Add(strLijn)
                    intIndex = InStr(strLijn, ";")
                    strKoersen(intTeller) = Mid(strLijn, 1, intIndex - 1)
                    intTeller = intTeller + 1
                End While
            Catch ex As Exception

            End Try

            FileClose(intFree)
        End If

        lblLstbUitleg.Text = "'M' = Monument" & vbCrLf & "'WT' = WorldTour" & vbCrLf & "'nWT' = niet WorldTour"
        lblBoodschap.Text = "Klik op een koers om de uitslag ervan te bekijken."

    End Sub

    Sub initialiseer_dgv()
        Dim intTeller As Integer

        dgvWielermanager.ColumnCount = intcstAantalTitelsWielermanager + 5
        dgvWielermanager.Rows.Add()
        dgvWielermanager.Columns(0).HeaderCell.Value = strTitelsWielermanager(0)
        dgvWielermanager.Columns(1).HeaderCell.Value = strTitelsWielermanager(1)
        For intTeller = 0 To intcstAantalTitelsWielermanager
            dgvWielermanager.Columns(intTeller + 2).HeaderCell.Value = strTitelsWielermanager(2) + " " + strKoersen(intTeller)
        Next
        dgvWielermanager.Columns(20).HeaderCell.Value = strTitelsWielermanager(3)
        dgvWielermanager.Columns(21).HeaderCell.Value = strTitelsWielermanager(4)
        dgvWielermanager.Columns(22).HeaderCell.Value = strTitelsWielermanager(5)


    End Sub

    Private Sub btnTerug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        Me.Close()

    End Sub

    Private Sub lstbOverzichtKoersen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbOverzichtKoersen.SelectedIndexChanged

        Call initialiseer_dgv_uitslag()

        Dim intPositie As Integer
        Dim strLijn, strKoers As String

        dgvUitslagKoers.Visible = True
        lstbOverzichtKoersen.Visible = False
        lblLstbUitleg.Visible = False
        btnOverzicht.Visible = True
        lblBoodschap.Text = "Klik op 'Overzicht' om de lijst met koersen terug te zien."

        strLijn = lstbOverzichtKoersen.SelectedItem

        intPositie = InStr(strLijn, ";")

        strKoers = Trim(Mid(strLijn, 1, intPositie - 1))

        Call lees_bestand_uitslag(strKoers)

    End Sub
    Sub lees_bestand_uitslag(ByRef strGekozenKoers)
        'Dit is een testsub omdat er nog maar één uitslag beschikbaar is, deze wordt nog nergens gecalld.
        'Eerst volledig uitwerken, callen waar nodig en uitvoerig testen.
        'Daarna deze code omzetten naar een code die werkt voor alle koersen die meetellen voor de wielermanager.

        Dim strBestand, strLijn As String
        Dim intTeller, intFree As Integer



        intTeller = 0
        intFree = FreeFile()

        strBestand = Application.StartupPath & "\bestanden\koersen\" & strGekozenKoers & ".csv"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                intTeller = intTeller + 1
                Call zet_lijn_in_dgv_uitslag(strLijn, intTeller)

            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)

    End Sub

    Private Sub btnOverzicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverzicht.Click
        dgvUitslagKoers.Rows.Clear()
        dgvUitslagKoers.Columns.Clear()
        dgvUitslagKoers.Visible = False
        lstbOverzichtKoersen.Visible = True
        lblBoodschap.Text = "Klik op een koers om de uitslag ervan te bekijken."

    End Sub
End Class