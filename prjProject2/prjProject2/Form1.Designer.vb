<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblBoodschap = New System.Windows.Forms.Label()
        Me.mnMenu = New System.Windows.Forms.MenuStrip()
        Me.mnPloegen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWorldTourPloeg = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbWorldTourPloegen = New System.Windows.Forms.ToolStripComboBox()
        Me.mnProContinentaalPloeg = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbProContinentaalPloegen = New System.Windows.Forms.ToolStripComboBox()
        Me.mnContinentaalPloeg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWedstrijden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWorldTourWedstrijden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEendagskoersenWT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRondesWT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnUCIPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnKalender = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnParijsRoubaix = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(1058, 664)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblBoodschap
        '
        Me.lblBoodschap.AutoSize = True
        Me.lblBoodschap.Location = New System.Drawing.Point(12, 667)
        Me.lblBoodschap.Name = "lblBoodschap"
        Me.lblBoodschap.Size = New System.Drawing.Size(79, 17)
        Me.lblBoodschap.TabIndex = 1
        Me.lblBoodschap.Text = "Boodschap"
        '
        'mnMenu
        '
        Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPloegen, Me.mnWedstrijden, Me.mnKalender})
        Me.mnMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnMenu.Name = "mnMenu"
        Me.mnMenu.Size = New System.Drawing.Size(1145, 28)
        Me.mnMenu.TabIndex = 2
        '
        'mnPloegen
        '
        Me.mnPloegen.AutoToolTip = True
        Me.mnPloegen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnWorldTourPloeg, Me.mnProContinentaalPloeg, Me.mnContinentaalPloeg})
        Me.mnPloegen.Name = "mnPloegen"
        Me.mnPloegen.Size = New System.Drawing.Size(75, 24)
        Me.mnPloegen.Text = "Ploegen"
        '
        'mnWorldTourPloeg
        '
        Me.mnWorldTourPloeg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbWorldTourPloegen})
        Me.mnWorldTourPloeg.Name = "mnWorldTourPloeg"
        Me.mnWorldTourPloeg.Size = New System.Drawing.Size(188, 24)
        Me.mnWorldTourPloeg.Text = "WorldTour"
        '
        'cmbWorldTourPloegen
        '
        Me.cmbWorldTourPloegen.Name = "cmbWorldTourPloegen"
        Me.cmbWorldTourPloegen.Size = New System.Drawing.Size(121, 28)
        '
        'mnProContinentaalPloeg
        '
        Me.mnProContinentaalPloeg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbProContinentaalPloegen})
        Me.mnProContinentaalPloeg.Name = "mnProContinentaalPloeg"
        Me.mnProContinentaalPloeg.Size = New System.Drawing.Size(188, 24)
        Me.mnProContinentaalPloeg.Text = "Pro Continentaal"
        '
        'cmbProContinentaalPloegen
        '
        Me.cmbProContinentaalPloegen.Name = "cmbProContinentaalPloegen"
        Me.cmbProContinentaalPloegen.Size = New System.Drawing.Size(121, 28)
        '
        'mnContinentaalPloeg
        '
        Me.mnContinentaalPloeg.Name = "mnContinentaalPloeg"
        Me.mnContinentaalPloeg.Size = New System.Drawing.Size(188, 24)
        Me.mnContinentaalPloeg.Text = "Continentaal"
        '
        'mnWedstrijden
        '
        Me.mnWedstrijden.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnWorldTourWedstrijden, Me.mnUCIPro, Me.mn11, Me.mn12, Me.ToolStripMenuItem2})
        Me.mnWedstrijden.Name = "mnWedstrijden"
        Me.mnWedstrijden.Size = New System.Drawing.Size(100, 24)
        Me.mnWedstrijden.Text = "Wedstrijden"
        '
        'mnWorldTourWedstrijden
        '
        Me.mnWorldTourWedstrijden.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnEendagskoersenWT, Me.mnRondesWT})
        Me.mnWorldTourWedstrijden.Name = "mnWorldTourWedstrijden"
        Me.mnWorldTourWedstrijden.Size = New System.Drawing.Size(152, 24)
        Me.mnWorldTourWedstrijden.Text = "WorldTour"
        '
        'mnEendagskoersenWT
        '
        Me.mnEendagskoersenWT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnParijsRoubaix})
        Me.mnEendagskoersenWT.Name = "mnEendagskoersenWT"
        Me.mnEendagskoersenWT.Size = New System.Drawing.Size(185, 24)
        Me.mnEendagskoersenWT.Text = "Eéndagskoersen"
        '
        'mnRondesWT
        '
        Me.mnRondesWT.Name = "mnRondesWT"
        Me.mnRondesWT.Size = New System.Drawing.Size(185, 24)
        Me.mnRondesWT.Text = "Rondes"
        '
        'mnUCIPro
        '
        Me.mnUCIPro.Name = "mnUCIPro"
        Me.mnUCIPro.Size = New System.Drawing.Size(152, 24)
        Me.mnUCIPro.Text = "UCI Pro"
        '
        'mn11
        '
        Me.mn11.Name = "mn11"
        Me.mn11.Size = New System.Drawing.Size(152, 24)
        Me.mn11.Text = "1.1"
        '
        'mn12
        '
        Me.mn12.Name = "mn12"
        Me.mn12.Size = New System.Drawing.Size(152, 24)
        Me.mn12.Text = "1.2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 24)
        Me.ToolStripMenuItem2.Text = "2.1"
        '
        'mnKalender
        '
        Me.mnKalender.Name = "mnKalender"
        Me.mnKalender.Size = New System.Drawing.Size(80, 24)
        Me.mnKalender.Text = "Kalender"
        '
        'mnParijsRoubaix
        '
        Me.mnParijsRoubaix.Name = "mnParijsRoubaix"
        Me.mnParijsRoubaix.Size = New System.Drawing.Size(172, 24)
        Me.mnParijsRoubaix.Text = "Parijs-Roubaix"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 693)
        Me.Controls.Add(Me.lblBoodschap)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.mnMenu)
        Me.MainMenuStrip = Me.mnMenu
        Me.Name = "frmStart"
        Me.Text = "Start"
        Me.mnMenu.ResumeLayout(False)
        Me.mnMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lblBoodschap As System.Windows.Forms.Label
    Friend WithEvents mnMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnPloegen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnWorldTourPloeg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnProContinentaalPloeg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnContinentaalPloeg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnWedstrijden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnWorldTourWedstrijden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnUCIPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEendagskoersenWT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRondesWT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbWorldTourPloegen As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents mnKalender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbProContinentaalPloegen As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents mnParijsRoubaix As System.Windows.Forms.ToolStripMenuItem

End Class
