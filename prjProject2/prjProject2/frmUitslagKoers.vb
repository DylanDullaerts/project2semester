Public Class frmUitslagKoers
    Dim dgvUitslag As New DataGridView
    Private Sub btnTerug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        Me.Close()

    End Sub

    Private Sub frmUitslagKoers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = strKoers
        lblBoodschap.Text = ""

        Call lees_bestand()

        dgvUitslag.Name = "dgvUitslag"
        dgvUitslag.Size = New Size(400, 400)
        dgvUitslag.Left = intLeft + intWidth * 2 + intcstMarge * 2
        dgvUitslag.Top = intTop
        Me.Controls.Add(dgvUitslag)
        dgvUitslag.Visible = False
    End Sub
    Sub lees_bestand()
        Dim strBestand As String
        Dim intTeller, intFree, intFout As Integer

        intFree = FreeFile()

        strBestand = Application.StartupPath & "\bestanden\koersen" & strKoers & ".csv"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)

            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
            lblBoodschap.Text = lblBoodschap.Text & vbCrLf & "De uitslag is nog niet toegevoegd, indien U dit wil doen, klik op de knop 'Uitslag' en kies daarna voor 'Toevoegen'"
            intFout = 1
        End Try

        If intFout = 1 Then

        End If

        FileClose(intFree)

    End Sub
    Sub ingeven()
        Dim lblRenner As New Label

        lblRenner.Name = "lblRenner"
        lblRenner.Text = "Renner"
        lblRenner.Location = New Point(20, 40)
        lblRenner.Size = New Size(100, 20)

        Me.Controls.Add(lblRenner)

        Dim txtRenner As New TextBox

        txtRenner.Top = intTop
        txtRenner.Left = intLeft + intWidth + intcstMarge
        txtRenner.Size = New Size(intWidth, intHeight)
        Me.Controls.Add(txtRenner)


    End Sub
    Sub initialiseer_dgv()
        dgvUitslag.ColumnCount = intcstAantalTitels


    End Sub

    Private Sub mnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnToevoegen.Click
        Dim frmToevoegen1 As New frmToevoegen
        frmToevoegen1.ShowDialog()

    End Sub
End Class