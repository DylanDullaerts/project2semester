Public Class frmUitslagKoers
    Private Sub btnTerug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        Me.Close()

    End Sub

    Private Sub frmUitslagKoers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = strKoers
        lblBoodschap.Text = ""
        Call initialiseer_dgv()
        Call lees_bestand()

        If dgvUitslagKoers.Rows(0).Cells(1).Value = "" Then
            lblBoodschap.Text = "De uitslag werd nog niet toegevoegd, indien U dit wil doen, klik op de knop 'Uitslag' en kies daarna voor 'Toevoegen'."
        End If

    End Sub
    Sub lees_bestand()
        Dim strBestand, strLijn As String
        Dim intTeller, intFree, intFout As Integer



        intTeller = 0
        intFree = FreeFile()

        strBestand = Application.StartupPath & "\bestanden\koersen\" & strKoers & ".csv"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                intTeller = intTeller + 1
                Call zet_lijn_in_dgv(strLijn, intTeller)

            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
            lblBoodschap.Text = lblBoodschap.Text & vbCrLf & "De uitslag werd nog niet toegevoegd, indien U dit wil doen, klik op de knop 'Uitslag' en kies daarna voor 'Toevoegen'."
            intFout = 1
        End Try

        FileClose(intFree)

    End Sub
    Sub zet_lijn_in_dgv(ByRef strLijnGelezen As String, ByVal intLijnNummer As Integer)
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
    Sub initialiseer_dgv()
        dgvUitslagKoers.ColumnCount = intcstAantalTitels
        'dgvUitslagKoers.Rows.Add()
        dgvUitslagKoers.Columns(0).HeaderCell.Value = strTitels(0)
        dgvUitslagKoers.Columns(1).HeaderCell.Value = strTitels(1)
        dgvUitslagKoers.Columns(2).HeaderCell.Value = strTitels(2)
        dgvUitslagKoers.Columns(3).HeaderCell.Value = strTitels(3)

    End Sub

    Private Sub mnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnToevoegen.Click
        Dim frmToevoegen1 As New frmToevoegen
        frmToevoegen1.ShowDialog()

    End Sub
End Class