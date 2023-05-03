<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUitslagKoers
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
        Me.btnTerug = New System.Windows.Forms.Button()
        Me.lblBoodschap = New System.Windows.Forms.Label()
        Me.mnMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnUitslag = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnToevoegen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTerug
        '
        Me.btnTerug.Location = New System.Drawing.Point(1086, 676)
        Me.btnTerug.Name = "btnTerug"
        Me.btnTerug.Size = New System.Drawing.Size(75, 27)
        Me.btnTerug.TabIndex = 0
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'lblBoodschap
        '
        Me.lblBoodschap.AutoSize = True
        Me.lblBoodschap.Location = New System.Drawing.Point(12, 676)
        Me.lblBoodschap.Name = "lblBoodschap"
        Me.lblBoodschap.Size = New System.Drawing.Size(79, 17)
        Me.lblBoodschap.TabIndex = 1
        Me.lblBoodschap.Text = "Boodschap"
        '
        'mnMenuStrip
        '
        Me.mnMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnUitslag})
        Me.mnMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnMenuStrip.Name = "mnMenuStrip"
        Me.mnMenuStrip.Size = New System.Drawing.Size(1173, 28)
        Me.mnMenuStrip.TabIndex = 2
        Me.mnMenuStrip.Text = "MenuStrip1"
        '
        'mnUitslag
        '
        Me.mnUitslag.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnToevoegen})
        Me.mnUitslag.Name = "mnUitslag"
        Me.mnUitslag.Size = New System.Drawing.Size(67, 24)
        Me.mnUitslag.Text = "Uitslag"
        '
        'mnToevoegen
        '
        Me.mnToevoegen.Name = "mnToevoegen"
        Me.mnToevoegen.Size = New System.Drawing.Size(151, 24)
        Me.mnToevoegen.Text = "Toevoegen"
        '
        'frmUitslagKoers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 715)
        Me.Controls.Add(Me.lblBoodschap)
        Me.Controls.Add(Me.btnTerug)
        Me.Controls.Add(Me.mnMenuStrip)
        Me.MainMenuStrip = Me.mnMenuStrip
        Me.Name = "frmUitslagKoers"
        Me.Text = "frmUitslagKoers"
        Me.mnMenuStrip.ResumeLayout(False)
        Me.mnMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents lblBoodschap As System.Windows.Forms.Label
    Friend WithEvents mnMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnUitslag As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnToevoegen As System.Windows.Forms.ToolStripMenuItem
End Class
