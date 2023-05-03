Public Class frmToevoegen
    Structure strucUitslagen
        Dim intPositie As Integer
        Dim strRenner As String
        Dim strTijdsverschil As String
    End Structure
    Dim strucUitslag(intcstAantalRenners) As strucUitslagen
    Dim intPositie As Integer
    Private Sub frmToevoegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBoodschap.Text = ""
        lblTijdsverschilUitleg.Text = ""
        Call initialiseer_dgv()
        Call initialiseer_structuur()

        txtPositie.Enabled = False
        txtPositie.Text = "1"
        intPositie = 0
    End Sub
    Sub initialiseer_structuur()
        Dim intTeller As Integer

        For intTeller = 0 To intcstAantalRenners
            strucUitslag(intTeller).intPositie = intTeller
            strucUitslag(intTeller).strRenner = ""
            strucUitslag(intTeller).strTijdsverschil = ""
        Next
    End Sub
    Sub initialiseer_dgv()
        dgvUitslag.ColumnCount = intcstAantalTitels
        dgvUitslag.Rows.Add()
        dgvUitslag.Columns(0).HeaderCell.Value = strTitels(0)
        dgvUitslag.Columns(1).HeaderCell.Value = strTitels(1)
        dgvUitslag.Columns(2).HeaderCell.Value = strTitels(2)

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

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim strHulp As String
        Dim intMinuten, intSeconden, intTijd As Integer
        Dim strTijd As String

        intMinuten = 0
        intSeconden = 0

        dgvUitslag.Rows.Item(intPositie).Cells(0).Value = intPositie + 1
        If txtRenner.Text = "" Then
            lblBoodschap.Text = "Gelieve een renner toe te voegen."
        Else
            strHulp = txtRenner.Text
            strucUitslag(intPositie).strRenner = strHulp
            dgvUitslag.Rows.Item(intPositie).Cells(1).Value = strHulp

            If txtTijdsverschil.Text = "" Then
                strTijd = ""
            Else
                intTijd = Integer.Parse(txtTijdsverschil.Text)
                intMinuten = Math.Floor(intTijd / 60)
                intSeconden = intTijd Mod 60
                strTijd = String.Format("{0:00}:{1:00}", intMinuten, intSeconden)
                strHulp = strTijd
                strucUitslag(intPositie).strTijdsverschil = strHulp
                dgvUitslag.Rows.Item(intPositie).Cells(2).Value = strHulp
            End If


        End If

        intPositie = intPositie + 1
        dgvUitslag.Rows.Add()
        Call maak_leeg()

    End Sub
    Sub maak_leeg()
        txtPositie.Text = intPositie + 1
        txtRenner.Text = ""
        txtTijdsverschil.Text = ""
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
                PrintLine(intFree, strLijn)
            Next

        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try



        FileClose(intFree)
    End Sub
End Class