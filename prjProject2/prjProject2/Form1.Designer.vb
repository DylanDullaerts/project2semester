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
        Me.mnProContinentaalPloeg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnContinentaalPloeg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWedstrijden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWorldTourWedstrijden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMonumenten = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEendagskoersenWT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRondesWT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnUCIPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnKalender = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWielermanager = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstbOverzicht = New System.Windows.Forms.ListBox()
        Me.mn1Pro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEuropeTour = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPloegen, Me.mnWedstrijden, Me.mnKalender, Me.mnWielermanager})
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
        Me.mnWorldTourPloeg.Name = "mnWorldTourPloeg"
        Me.mnWorldTourPloeg.Size = New System.Drawing.Size(188, 24)
        Me.mnWorldTourPloeg.Text = "WorldTour"
        '
        'mnProContinentaalPloeg
        '
        Me.mnProContinentaalPloeg.Name = "mnProContinentaalPloeg"
        Me.mnProContinentaalPloeg.Size = New System.Drawing.Size(188, 24)
        Me.mnProContinentaalPloeg.Text = "Pro Continentaal"
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
        Me.mnWorldTourWedstrijden.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnMonumenten, Me.mnEendagskoersenWT, Me.mnRondesWT})
        Me.mnWorldTourWedstrijden.Name = "mnWorldTourWedstrijden"
        Me.mnWorldTourWedstrijden.Size = New System.Drawing.Size(152, 24)
        Me.mnWorldTourWedstrijden.Text = "WorldTour"
        '
        'mnMonumenten
        '
        Me.mnMonumenten.Name = "mnMonumenten"
        Me.mnMonumenten.Size = New System.Drawing.Size(185, 24)
        Me.mnMonumenten.Text = "Monumenten"
        '
        'mnEendagskoersenWT
        '
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
        Me.mnUCIPro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mn1Pro})
        Me.mnUCIPro.Name = "mnUCIPro"
        Me.mnUCIPro.Size = New System.Drawing.Size(152, 24)
        Me.mnUCIPro.Text = "UCI Pro"
        '
        'mn11
        '
        Me.mn11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnEuropeTour})
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
        'mnWielermanager
        '
        Me.mnWielermanager.Name = "mnWielermanager"
        Me.mnWielermanager.Size = New System.Drawing.Size(173, 24)
        Me.mnWielermanager.Text = "Sporza Wielermanager"
        '
        'lstbOverzicht
        '
        Me.lstbOverzicht.FormattingEnabled = True
        Me.lstbOverzicht.ItemHeight = 16
        Me.lstbOverzicht.Location = New System.Drawing.Point(785, 47)
        Me.lstbOverzicht.Name = "lstbOverzicht"
        Me.lstbOverzicht.Size = New System.Drawing.Size(329, 516)
        Me.lstbOverzicht.TabIndex = 3
        '
        'mn1Pro
        '
        Me.mn1Pro.Name = "mn1Pro"
        Me.mn1Pro.Size = New System.Drawing.Size(152, 24)
        Me.mn1Pro.Text = "1.Pro"
        '
        'mnEuropeTour
        '
        Me.mnEuropeTour.Name = "mnEuropeTour"
        Me.mnEuropeTour.Size = New System.Drawing.Size(158, 24)
        Me.mnEuropeTour.Text = "Europe Tour"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 693)
        Me.Controls.Add(Me.lstbOverzicht)
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
    Friend WithEvents mnEendagskoersenWT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRondesWT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnKalender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstbOverzicht As System.Windows.Forms.ListBox
    Friend WithEvents mnWielermanager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMonumenten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn1Pro As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnUCIPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEuropeTour As System.Windows.Forms.ToolStripMenuItem

End Class
