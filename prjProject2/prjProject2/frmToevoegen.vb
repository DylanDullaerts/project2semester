Public Class frmToevoegen
    Structure strucUitslagen
        Dim intPositie As Integer
        Dim strRenner As String
        Dim strPloeg As String
        Dim strTijdsverschil As String
    End Structure
    Structure strucRennersDNF
        Dim strPositie As String
        Dim strRenner As String
        Dim strPloeg As String
    End Structure
    Dim strucRennerDNF(intcstAantalRenners) As strucRennersDNF
    Dim strucUitslag(intcstAantalRenners) As strucUitslagen
    Dim intPositie As Integer
    Dim strRenner As String
    Dim strPloeg As String
    Dim strAllePloegen(100) As String
    Dim intTellerPloegen As Integer



    Private Sub frmToevoegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBoodschap.Text = ""
        lblTijdsverschilUitleg.Text = ""
        cmbPloegen.Items.Clear()
        intTellerPloegen = 0

        Call initialiseer_dgv()
        Call initialiseer_structuur_uitslagen()
        Call initialiseer_structuur_rennersdnf()



        btnOKDNF.Visible = False
        Call lees_bestand()
        strRenner = ""

        If dgvUitslag.Rows(0).Cells(0).Value = "" Then
            txtPositie.Text = "1"
        End If

        txtPositie.Enabled = False
        'intPositie = 0
    End Sub

    Sub vul_cmbPloegen()
        intTellerPloegen = 0
        Call lees_worldtourploegen()
        Call lees_procontinentaalploegen()

    End Sub
    Sub lees_worldtourploegen()
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\ploegen\worldtourploegen.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                cmbPloegen.Items.Add(strLijn)
                strAllePloegen(intTellerPloegen) = strLijn
                intTellerPloegen = intTellerPloegen + 1
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message

        End Try

        FileClose(intFree)

    End Sub
    Sub lees_procontinentaalploegen()
        Dim intFree As Integer
        Dim strBestand, strLijn As String

        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\ploegen\procontinentaalploegen.txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                cmbPloegen.Items.Add(strLijn)
                strAllePloegen(intTellerPloegen) = strLijn
                intTellerPloegen = intTellerPloegen + 1
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message

        End Try

        FileClose(intFree)
    End Sub
    Sub lees_bestand()
        Dim strBestand, strLijn As String
        Dim intTeller, intFree, intFout As Integer


        intFout = 0
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
            'lblBoodschap.Text = ex.Message
            'lblBoodschap.Text = lblBoodschap.Text & vbCrLf & "De uitslag is nog niet toegevoegd, indien U dit wil doen, klik op de knop 'Uitslag' en kies daarna voor 'Toevoegen'"
            intFout = -1
        End Try

        If intFout = -1 Then
            intTeller = 0
        End If

        FileClose(intFree)
        intPositie = intTeller

        While Not intTeller = 0
            If dgvUitslag.Rows(intTeller).Cells(0).Value = "DNF" Then
                Call DNF()
                intTeller = 1
            Else
                txtPositie.Text = intPositie + 1
            End If
            intTeller = intTeller - 1
        End While



    End Sub
    Sub zet_lijn_in_dgv(ByRef strLijnGelezen As String, ByVal intLijnNummer As Integer)
        Dim strDeelLijn As String
        Dim intPositie, intKolom As Integer
        intPositie = 0
        intKolom = 0
        strDeelLijn = strLijnGelezen
        dgvUitslag.Rows.Add()
        While InStr(strDeelLijn, ";") > 0
            intPositie = InStr(strDeelLijn, ";")
            dgvUitslag.Rows(intLijnNummer - 1).Cells(intKolom).Value = Mid(strDeelLijn, 1, intPositie - 1)
            intKolom = intKolom + 1
            strDeelLijn = Mid(strDeelLijn, intPositie + 1, Len(strDeelLijn))

        End While

    End Sub
    Sub initialiseer_structuur_rennersdnf()
        Dim intTeller As Integer

        For intTeller = 0 To intcstAantalRenners
            strucRennerDNF(intTeller).strPositie = ""
            strucRennerDNF(intTeller).strRenner = ""
            strucRennerDNF(intTeller).strPloeg = ""
        Next
    End Sub
    Sub initialiseer_structuur_uitslagen()
        Dim intTeller As Integer

        For intTeller = 0 To intcstAantalRenners
            strucUitslag(intTeller).intPositie = intTeller
            strucUitslag(intTeller).strRenner = ""
            strucUitslag(intTeller).strPloeg = ""
            strucUitslag(intTeller).strTijdsverschil = ""
        Next
    End Sub
    Sub initialiseer_dgv()
        dgvUitslag.ColumnCount = intcstAantalTitels
        dgvUitslag.Rows.Add()
        dgvUitslag.Columns(0).HeaderCell.Value = strTitels(0)
        dgvUitslag.Columns(1).HeaderCell.Value = strTitels(1)
        dgvUitslag.Columns(2).HeaderCell.Value = strTitels(2)
        dgvUitslag.Columns(3).HeaderCell.Value = strTitels(3)


    End Sub

    Private Sub btnAnnuleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuleer.Click
        Dim result As DialogResult = MessageBox.Show("Bent U zeker dat U wilt annuleren", "Annuleren", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Code die moet worden uitgevoerd als op Ja wordt geklikt
            Me.Close()
        ElseIf result = DialogResult.No Then
            ' Code die moet worden uitgevoerd als op Nee wordt geklikt

        End If
    End Sub
    Private Sub btnOKDNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKDNF.Click
        Dim strHulp As String

        strHulp = "DNF"
        strucRennerDNF(intPositie).strPositie = strHulp
        dgvUitslag.Rows.Item(intPositie).Cells(0).Value = strHulp
        If txtRenner.Text = "" Then
            lblBoodschap.Text = "Gelieve een renner toe te voegen."
        Else
            strHulp = txtRenner.Text
            strucRennerDNF(intPositie).strRenner = strHulp
            dgvUitslag.Rows.Item(intPositie).Cells(1).Value = strHulp
            If cmbPloegen.Text = "" Then
                lblBoodschap.Text = "Gelieve een ploeg toe te voegen."
            Else
                strHulp = cmbPloegen.Text
                strucRennerDNF(intPositie).strPloeg = strHulp
                dgvUitslag.Rows.Item(intPositie).Cells(2).Value = strHulp
            End If
        End If
        intPositie = intPositie + 1
        dgvUitslag.Rows.Add()
        Call maak_leeg()
        txtPositie.Text = "DNF"


    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim strHulp As String
        Dim intMinuten, intSeconden, intTijd As Integer
        Dim strTijd As String

        intMinuten = 0
        intSeconden = 0


        If Len(strRenner) > 0 Then

        Else
            dgvUitslag.Rows.Item(intPositie).Cells(0).Value = intPositie + 1
            If txtRenner.Text = "" Then
                lblBoodschap.Text = "Gelieve een renner toe te voegen."
            Else
                strHulp = txtRenner.Text
                strucUitslag(intPositie).strRenner = strHulp
                dgvUitslag.Rows.Item(intPositie).Cells(1).Value = strHulp
                If cmbPloegen.Text = "" Then
                    lblBoodschap.Text = "Gelieve een ploeg toe te voegen."
                Else
                    strHulp = cmbPloegen.Text
                    strucUitslag(intPositie).strPloeg = strHulp
                    dgvUitslag.Rows.Item(intPositie).Cells(2).Value = strHulp
                End If

                If txtTijdsverschil.Text = "" Then
                    strTijd = ""
                Else
                    If IsNumeric(txtTijdsverschil.Text) Then
                        intTijd = Integer.Parse(txtTijdsverschil.Text)
                        intMinuten = Math.Floor(intTijd / 60)
                        intSeconden = intTijd Mod 60
                        strTijd = String.Format("{0:00}:{1:00}", intMinuten, intSeconden)
                        strHulp = strTijd
                        strucUitslag(intPositie).strTijdsverschil = strHulp
                        dgvUitslag.Rows.Item(intPositie).Cells(3).Value = strHulp
                    Else
                        lblBoodschap.Text = "Geef een geldig tijdsverschil in."
                    End If

                End If


            End If

            intPositie = intPositie + 1
            dgvUitslag.Rows.Add()
            Call maak_leeg()
        End If
        txtTijdsverschil.Text = intTijd

    End Sub
    Sub maak_leeg()
        txtPositie.Text = intPositie + 1
        txtRenner.Text = ""
        cmbPloegen.Text = ""
        txtTijdsverschil.Text = ""
        lblBoodschap.Text = ""
    End Sub

    Private Sub txtTijdsverschil_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTijdsverschil.GotFocus
        lblTijdsverschilUitleg.Text = "Gelieve het tijdsverschil in seconden in te geven"
    End Sub

    Private Sub txtTijdsverschil_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTijdsverschil.LostFocus
        lblTijdsverschilUitleg.Text = ""
    End Sub

    Private Sub btnOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpslaan.Click
        Dim intFree, intTeller, intKolom As Integer
        Dim strBestand, strLijn As String

        strLijn = ""
        intFree = FreeFile()
        strBestand = Application.StartupPath & "\bestanden\koersen\" & strKoers & ".csv"

        Try
            FileOpen(intFree, strBestand, OpenMode.Output)
            For intTeller = 0 To dgvUitslag.Rows.Count - 1
                strLijn = ""
                For intKolom = 0 To dgvUitslag.ColumnCount - 1
                    strLijn = strLijn & dgvUitslag.Rows(intTeller).Cells(intKolom).Value & ";"
                Next
                If Len(strLijn) = 4 Then

                Else
                    PrintLine(intFree, strLijn)
                End If
            Next

        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try



        FileClose(intFree)
        lblBoodschap.Text = "U heeft de aanpassingen opgeslagen."
    End Sub

    Private Sub dgvUitslag_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvUitslag.RowHeaderMouseClick
        Dim strTijd As String
        Dim intMinuten, intSeconden, intTotaleSeconden, intPositie As Integer

        txtPositie.Text = dgvUitslag.CurrentRow.Cells(0).Value
        txtRenner.Text = dgvUitslag.CurrentRow.Cells(1).Value
        strRenner = txtRenner.Text
        If Len(strRenner) = 0 Then
            Call maak_leeg()
        Else
            cmbPloegen.Text = dgvUitslag.CurrentRow.Cells(2).Value
            txtTijdsverschil.Text = dgvUitslag.CurrentRow.Cells(3).Value
            strTijd = txtTijdsverschil.Text
            intPositie = InStr(strTijd, ":")
            intMinuten = Integer.Parse(Mid(strTijd, 1, intPositie - 1))
            intSeconden = Integer.Parse(Mid(strTijd, intPositie + 1, Len(strTijd) - intPositie))
            intTotaleSeconden = intMinuten * 60 + intSeconden
            txtTijdsverschil.Text = intTotaleSeconden
        End If




    End Sub

    Private Sub btnPasAan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasAan.Click
        Dim intMinuten, intSeconden, intTijd As Integer
        Dim strTijd As String

        If Len(strRenner) = 0 Then

        Else
            dgvUitslag.CurrentRow.Cells(0).Value = txtPositie.Text
            dgvUitslag.CurrentRow.Cells(1).Value = txtRenner.Text
            dgvUitslag.CurrentRow.Cells(2).Value = cmbPloegen.Text
            intTijd = Integer.Parse(txtTijdsverschil.Text)
            intMinuten = Math.Floor(intTijd / 60)
            intSeconden = intTijd Mod 60
            strTijd = String.Format("{0:00}:{1:00}", intMinuten, intSeconden)
            dgvUitslag.CurrentRow.Cells(3).Value = strTijd
            lblBoodschap.Text = "U heeft de huidige lijn aangepast."
        End If

    End Sub

    Private Sub cmbPloegen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPloegen.GotFocus
        Call vul_cmbPloegen()
    End Sub

    Private Sub cmbPloegen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPloegen.SelectedIndexChanged
        cmbPloegen.Text = cmbPloegen.SelectedItem

    End Sub

    'Private Sub cmbPloegen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPloegen.TextChanged
    '    Dim strGetypt, strMogelijkePloeg As String
    '    Dim intTeller, intIndex As Integer



    '    cmbPloegen.Items.Clear()

    '    strGetypt = cmbPloegen.Text
    '    intTeller = Len(strGetypt)

    '    For intIndex = 0 To intTellerPloegen - 1
    '        If strGetypt = Mid(Replace(Trim(strAllePloegen(intIndex)), "-", ""), 1, intTeller) Then
    '            strMogelijkePloeg = strAllePloegen(intIndex)
    '            cmbPloegen.Items.Add(strMogelijkePloeg)
    '        End If
    '    Next



    'End Sub
    Sub DNF()
        btnOK.Visible = False
        btnOKDNF.Visible = True
        txtPositie.Text = "DNF"
        txtPositie.Enabled = False
        txtTijdsverschil.Enabled = False

    End Sub

    Private Sub btnDNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDNF.Click
        Call DNF()

    End Sub
End Class