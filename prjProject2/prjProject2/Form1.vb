'Dit zijn libraries die ik nodig heb om afbeeldingen te kunnen laden.
Imports System.Drawing
Imports System.Windows.Forms


Public Class frmStart
    'Dim intcstMarge As Integer = 10
    'Dim intcstWidthButton As Integer = 20
    Dim strZoekopdracht As String

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Reset()
        FileClose()
        End

    End Sub

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBoodschap.Text = ""
        'Dit is een feature die voorlopig veel te groot is om toe te voegen, ik hoop dit in de toekomst geleidelijk aan toe te voegen.
        mnContinentaalPloeg.Enabled = False
        mnContinentaalPloeg.Visible = False
        'Hier voeg ik de WorldTour-ploegen toe aan de combobox in de menu van ploegen.
        'Call voeg_worldtourploegen_toe()
        'Hier voeg ik de ProContinentale ploegen toe aan de combobox in de menu van ploegen.
        'Call voeg_procontinentaalploegen_toe()
        'Dit is een sub waar ik bepaalde controls toevoeg adhv code.
        Call voeg_controls_toe()
        Call titels_initialiseren()
        lstbOverzicht.Visible = False

    End Sub

    Sub titels_initialiseren()
        Dim intFree, intTeller As Integer
        Dim strBestand As String

        intFree = FreeFile()
        intTeller = 0
        strBestand = Application.StartupPath & "\bestanden\titels.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strTitels(intTeller) = LineInput(intFree)
                intTeller = intTeller + 1
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message

        End Try

        FileClose(intFree)

    End Sub
    Sub voeg_controls_toe()
        'Ik gebruik hier een aantal integers en constanten om de controls op een ordelijke manier op de form te plaatsen.
        Dim txtZoek As New TextBox
        Dim lblZoek As New Label
        Dim btnZoek As New Button
        'Dim intTop, intHeight, intLeft, intWidth As Integer

        lblZoek.Name = "lblZoek"
        lblZoek.Text = "Zoek"
        lblZoek.Location = New Point(20, 40)
        lblZoek.Size = New Size(100, 20)

        Me.Controls.Add(lblZoek)

        For Each Control In Me.Controls
            If TypeOf Control Is Label Then
                If Control.name Is "lblZoek" Then
                    intTop = Control.Top
                    intHeight = Control.Height
                    intLeft = Control.Left
                    intWidth = Control.Width
                End If
            End If
        Next

        txtZoek.Name = "txtZoek"
        txtZoek.Top = intTop
        txtZoek.Left = intLeft + intWidth + intcstMarge
        txtZoek.Size = New Size(intWidth, intHeight)
        Me.Controls.Add(txtZoek)

        btnZoek.Name = "btnZoek"
        btnZoek.Location = New Point(intLeft + intWidth * 2 + intcstMarge * 2, intTop)



        'De afbeelding laden in een variabele
        Dim imgVergrootglas As Image = Image.FromFile(Application.StartupPath & "\bestanden\controls\vergrootglas.png")

        'Hier maak ik een ImageList om de afbeelding in op te slaan
        Dim imageList As New ImageList()
        imageList.Images.Add(imgVergrootglas)

        'De ImageList toekennen aan de knop
        btnZoek.ImageList = imageList
        btnZoek.ImageIndex = 0
        btnZoek.Size = New Size(intcstWidthButton, intHeight)
        btnZoek.AutoSize = True

        Me.Controls.Add(btnZoek)

        Dim pBoxFoto1 As New PictureBox
        pBoxFoto1.Name = "pBoxFoto1"
        pBoxFoto1.Left = intLeft
        pBoxFoto1.Top = intTop + intHeight + intcstMarge

        Me.Controls.Add(pBoxFoto1)

    End Sub

    'Sub voeg_procontinentaalploegen_toe()
    '    Dim intFree As Integer
    '    Dim strBestand, strLijn As String

    '    intFree = FreeFile()
    '    strBestand = Application.StartupPath & "\bestanden\ploegen\procontinentaalploegen.txt"
    '    cmbProContinentaalPloegen.Items.Clear()

    '    Try
    '        FileOpen(intFree, strBestand, OpenMode.Input)
    '        While Not EOF(intFree)
    '            strLijn = LineInput(intFree)
    '            cmbProContinentaalPloegen.Items.Add(strLijn)
    '        End While
    '    Catch ex As Exception
    '        lblBoodschap.Text = ex.Message
    '    End Try

    '    FileClose(intFree)

    'End Sub
    'Sub voeg_worldtourploegen_toe()
    '    Dim intFree As Integer
    '    Dim strBestand, strLijn As String

    '    intFree = FreeFile()
    '    strBestand = Application.StartupPath & "\bestanden\ploegen\worldtourploegen2.txt"


    '    Try
    '        FileOpen(intFree, strBestand, OpenMode.Input)
    '        While Not EOF(intFree)
    '            strLijn = LineInput(intFree)
    '            lstbOverzicht.Items.Add(strLijn)
    '        End While
    '    Catch ex As Exception
    '        lblBoodschap.Text = ex.Message
    '    End Try

    '    FileClose(intFree)


    'End Sub


    Private Sub mnEendagskoersenWT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnEendagskoersenWT.Click
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()
        strZoekopdracht = "Koers"


        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\koersen\Eéndagskoersen WT.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbOverzicht.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)

    End Sub

    Private Sub lstbOverzicht_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbOverzicht.SelectedIndexChanged

        Select Case strZoekopdracht
            Case "Koers"
                strKoers = lstbOverzicht.SelectedItem
                Dim frmUitslagKoers1 As New frmUitslagKoers
                frmUitslagKoers1.ShowDialog()
            Case "Ploeg"
                strPloeg = lstbOverzicht.SelectedItem
                Dim frmPloeg1 As New frmPloeg
                frmPloeg1.ShowDialog()
            Case "Wielermanager"
                strManager = lstbOverzicht.SelectedItem
                If strManager = "Voorjaar" Then
                    strManager = "Sporza Wieler"
                End If
                Dim frmWielermanager1 As New frmWielermanager
                frmWielermanager1.ShowDialog()
        End Select



    End Sub

    Private Sub mnWorldTourPloeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnWorldTourPloeg.Click

        Dim intFree As Integer
        Dim strBestand, strLijn As String

        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()
        strZoekopdracht = "Ploeg"


        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\ploegen\worldtourploegen.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbOverzicht.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)


    End Sub

    Private Sub mnProContinentaalPloeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnProContinentaalPloeg.Click
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()


        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\ploegen\procontinentaalploegen.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbOverzicht.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)

    End Sub

    Private Sub mnWielermanager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnWielermanager.Click
        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()

        lstbOverzicht.Items.Add("Voorjaar")
        lstbOverzicht.Items.Add("Giro")
        lstbOverzicht.Items.Add("Tour")

        strZoekopdracht = "Wielermanager"

    End Sub

    Private Sub mnMonumenten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMonumenten.Click
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()
        strZoekopdracht = "Koers"


        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\koersen\Monumenten.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbOverzicht.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)
    End Sub

    Private Sub mn1Pro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mn1Pro.Click
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()
        strZoekopdracht = "Koers"


        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\koersen\Eéndagskoersen 1.Pro.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbOverzicht.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)
    End Sub

    Private Sub mnEuropeTour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnEuropeTour.Click
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        lstbOverzicht.Visible = True
        lstbOverzicht.Items.Clear()
        strZoekopdracht = "Koers"


        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\koersen\Eéndagskoersen 1.1 Europe Tour.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbOverzicht.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)
    End Sub
End Class
