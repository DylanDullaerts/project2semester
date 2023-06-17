Public Class frmPloeg
    Dim strRenner As String


    Private Sub btnTerug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        Me.Close()

    End Sub

    Private Sub frmPloeg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBoodschap.Text = ""
        Me.Text = strPloeg
        Call voeg_renners_toe()
        lstbResultaten.Visible = False

    End Sub
    Sub voeg_renners_toe()
        Dim strBestand, strLijn As String
        Dim intFree As Integer

        intFree = FreeFile()

        strBestand = Application.StartupPath & "\bestanden\ploegen\" & strPloeg & ".txt"

        Try
            FileOpen(intFree, strBestand, OpenMode.Input)
            While Not EOF(intFree)
                strLijn = LineInput(intFree)
                lstbRenners.Items.Add(strLijn)
            End While
        Catch ex As Exception
            lblBoodschap.Text = ex.Message
        End Try

        FileClose(intFree)

    End Sub

    Private Sub lstbRenners_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbRenners.SelectedIndexChanged

        lstbResultaten.Visible = True

        strRenner = lstbRenners.SelectedItem
        pictRenner.Image = Image.FromFile(Application.StartupPath & "\bestanden\foto's\renners\" & strRenner & ".JPEG")
        pictRenner.SizeMode = PictureBoxSizeMode.StretchImage

        Call zoek_in_uitslagen()


    End Sub
    Sub zoek_in_uitslagen()

    End Sub
End Class