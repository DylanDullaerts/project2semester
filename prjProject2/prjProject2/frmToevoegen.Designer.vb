<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToevoegen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBoodschap = New System.Windows.Forms.Label()
        Me.btnAnnuleer = New System.Windows.Forms.Button()
        Me.lblRenner = New System.Windows.Forms.Label()
        Me.txtRenner = New System.Windows.Forms.TextBox()
        Me.lblPositie = New System.Windows.Forms.Label()
        Me.txtPositie = New System.Windows.Forms.TextBox()
        Me.lblTijdsverchil = New System.Windows.Forms.Label()
        Me.txtTijdsverschil = New System.Windows.Forms.TextBox()
        Me.dgvUitslag = New System.Windows.Forms.DataGridView()
        Me.btnOpslaan = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblTijdsverschilUitleg = New System.Windows.Forms.Label()
        Me.btnPasAan = New System.Windows.Forms.Button()
        Me.lblPloeg = New System.Windows.Forms.Label()
        Me.cmbPloegen = New System.Windows.Forms.ComboBox()
        Me.btnDNF = New System.Windows.Forms.Button()
        Me.btnOKDNF = New System.Windows.Forms.Button()
        CType(Me.dgvUitslag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBoodschap
        '
        Me.lblBoodschap.AutoSize = True
        Me.lblBoodschap.Location = New System.Drawing.Point(11, 729)
        Me.lblBoodschap.Name = "lblBoodschap"
        Me.lblBoodschap.Size = New System.Drawing.Size(79, 17)
        Me.lblBoodschap.TabIndex = 0
        Me.lblBoodschap.Text = "Boodschap"
        '
        'btnAnnuleer
        '
        Me.btnAnnuleer.Location = New System.Drawing.Point(1177, 720)
        Me.btnAnnuleer.Name = "btnAnnuleer"
        Me.btnAnnuleer.Size = New System.Drawing.Size(85, 26)
        Me.btnAnnuleer.TabIndex = 8
        Me.btnAnnuleer.Text = "Annuleer"
        Me.btnAnnuleer.UseVisualStyleBackColor = True
        '
        'lblRenner
        '
        Me.lblRenner.AutoSize = True
        Me.lblRenner.Location = New System.Drawing.Point(13, 43)
        Me.lblRenner.Name = "lblRenner"
        Me.lblRenner.Size = New System.Drawing.Size(55, 17)
        Me.lblRenner.TabIndex = 2
        Me.lblRenner.Text = "Renner"
        '
        'txtRenner
        '
        Me.txtRenner.Location = New System.Drawing.Point(104, 40)
        Me.txtRenner.Name = "txtRenner"
        Me.txtRenner.Size = New System.Drawing.Size(253, 22)
        Me.txtRenner.TabIndex = 2
        '
        'lblPositie
        '
        Me.lblPositie.AutoSize = True
        Me.lblPositie.Location = New System.Drawing.Point(13, 15)
        Me.lblPositie.Name = "lblPositie"
        Me.lblPositie.Size = New System.Drawing.Size(50, 17)
        Me.lblPositie.TabIndex = 4
        Me.lblPositie.Text = "Positie"
        '
        'txtPositie
        '
        Me.txtPositie.Location = New System.Drawing.Point(104, 12)
        Me.txtPositie.Name = "txtPositie"
        Me.txtPositie.Size = New System.Drawing.Size(253, 22)
        Me.txtPositie.TabIndex = 1
        '
        'lblTijdsverchil
        '
        Me.lblTijdsverchil.AutoSize = True
        Me.lblTijdsverchil.Location = New System.Drawing.Point(13, 99)
        Me.lblTijdsverchil.Name = "lblTijdsverchil"
        Me.lblTijdsverchil.Size = New System.Drawing.Size(86, 17)
        Me.lblTijdsverchil.TabIndex = 6
        Me.lblTijdsverchil.Text = "Tijdsverschil"
        '
        'txtTijdsverschil
        '
        Me.txtTijdsverschil.Location = New System.Drawing.Point(104, 96)
        Me.txtTijdsverschil.Name = "txtTijdsverschil"
        Me.txtTijdsverschil.Size = New System.Drawing.Size(253, 22)
        Me.txtTijdsverschil.TabIndex = 3
        '
        'dgvUitslag
        '
        Me.dgvUitslag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUitslag.Location = New System.Drawing.Point(418, 12)
        Me.dgvUitslag.Name = "dgvUitslag"
        Me.dgvUitslag.RowTemplate.Height = 24
        Me.dgvUitslag.Size = New System.Drawing.Size(844, 702)
        Me.dgvUitslag.TabIndex = 7
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Location = New System.Drawing.Point(15, 193)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(75, 27)
        Me.btnOpslaan.TabIndex = 6
        Me.btnOpslaan.Text = "Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(16, 164)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblTijdsverschilUitleg
        '
        Me.lblTijdsverschilUitleg.AutoSize = True
        Me.lblTijdsverschilUitleg.Location = New System.Drawing.Point(16, 135)
        Me.lblTijdsverschilUitleg.Name = "lblTijdsverschilUitleg"
        Me.lblTijdsverschilUitleg.Size = New System.Drawing.Size(122, 17)
        Me.lblTijdsverschilUitleg.TabIndex = 11
        Me.lblTijdsverschilUitleg.Text = "TijdsverschilUitleg"
        '
        'btnPasAan
        '
        Me.btnPasAan.Location = New System.Drawing.Point(104, 164)
        Me.btnPasAan.Name = "btnPasAan"
        Me.btnPasAan.Size = New System.Drawing.Size(75, 23)
        Me.btnPasAan.TabIndex = 5
        Me.btnPasAan.Text = "Pas Aan"
        Me.btnPasAan.UseVisualStyleBackColor = True
        '
        'lblPloeg
        '
        Me.lblPloeg.AutoSize = True
        Me.lblPloeg.Location = New System.Drawing.Point(13, 71)
        Me.lblPloeg.Name = "lblPloeg"
        Me.lblPloeg.Size = New System.Drawing.Size(44, 17)
        Me.lblPloeg.TabIndex = 12
        Me.lblPloeg.Text = "Ploeg"
        '
        'cmbPloegen
        '
        Me.cmbPloegen.FormattingEnabled = True
        Me.cmbPloegen.Location = New System.Drawing.Point(104, 68)
        Me.cmbPloegen.Name = "cmbPloegen"
        Me.cmbPloegen.Size = New System.Drawing.Size(253, 24)
        Me.cmbPloegen.TabIndex = 13
        '
        'btnDNF
        '
        Me.btnDNF.Location = New System.Drawing.Point(104, 195)
        Me.btnDNF.Name = "btnDNF"
        Me.btnDNF.Size = New System.Drawing.Size(75, 23)
        Me.btnDNF.TabIndex = 14
        Me.btnDNF.Text = "DNF"
        Me.btnDNF.UseVisualStyleBackColor = True
        '
        'btnOKDNF
        '
        Me.btnOKDNF.Location = New System.Drawing.Point(185, 195)
        Me.btnOKDNF.Name = "btnOKDNF"
        Me.btnOKDNF.Size = New System.Drawing.Size(75, 23)
        Me.btnOKDNF.TabIndex = 15
        Me.btnOKDNF.Text = "OK"
        Me.btnOKDNF.UseVisualStyleBackColor = True
        '
        'frmToevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 755)
        Me.Controls.Add(Me.btnOKDNF)
        Me.Controls.Add(Me.btnDNF)
        Me.Controls.Add(Me.cmbPloegen)
        Me.Controls.Add(Me.lblPloeg)
        Me.Controls.Add(Me.btnPasAan)
        Me.Controls.Add(Me.lblTijdsverschilUitleg)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Controls.Add(Me.dgvUitslag)
        Me.Controls.Add(Me.txtTijdsverschil)
        Me.Controls.Add(Me.lblTijdsverchil)
        Me.Controls.Add(Me.txtPositie)
        Me.Controls.Add(Me.lblPositie)
        Me.Controls.Add(Me.txtRenner)
        Me.Controls.Add(Me.lblRenner)
        Me.Controls.Add(Me.btnAnnuleer)
        Me.Controls.Add(Me.lblBoodschap)
        Me.Name = "frmToevoegen"
        Me.Text = "frmToevoegen"
        CType(Me.dgvUitslag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBoodschap As System.Windows.Forms.Label
    Friend WithEvents btnAnnuleer As System.Windows.Forms.Button
    Friend WithEvents lblRenner As System.Windows.Forms.Label
    Friend WithEvents txtRenner As System.Windows.Forms.TextBox
    Friend WithEvents lblPositie As System.Windows.Forms.Label
    Friend WithEvents txtPositie As System.Windows.Forms.TextBox
    Friend WithEvents lblTijdsverchil As System.Windows.Forms.Label
    Friend WithEvents txtTijdsverschil As System.Windows.Forms.TextBox
    Friend WithEvents dgvUitslag As System.Windows.Forms.DataGridView
    Friend WithEvents btnOpslaan As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblTijdsverschilUitleg As System.Windows.Forms.Label
    Friend WithEvents btnPasAan As System.Windows.Forms.Button
    Friend WithEvents lblPloeg As System.Windows.Forms.Label
    Friend WithEvents cmbPloegen As System.Windows.Forms.ComboBox
    Friend WithEvents btnDNF As System.Windows.Forms.Button
    Friend WithEvents btnOKDNF As System.Windows.Forms.Button
End Class
