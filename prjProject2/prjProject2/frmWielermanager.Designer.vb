<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWielermanager
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
        Me.dgvWielermanager = New System.Windows.Forms.DataGridView()
        Me.dgvUitslagKoers = New System.Windows.Forms.DataGridView()
        Me.lstbOverzichtKoersen = New System.Windows.Forms.ListBox()
        Me.lblLstbUitleg = New System.Windows.Forms.Label()
        Me.btnOverzicht = New System.Windows.Forms.Button()
        CType(Me.dgvWielermanager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUitslagKoers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTerug
        '
        Me.btnTerug.Location = New System.Drawing.Point(1157, 712)
        Me.btnTerug.Name = "btnTerug"
        Me.btnTerug.Size = New System.Drawing.Size(75, 23)
        Me.btnTerug.TabIndex = 0
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'lblBoodschap
        '
        Me.lblBoodschap.AutoSize = True
        Me.lblBoodschap.Location = New System.Drawing.Point(12, 721)
        Me.lblBoodschap.Name = "lblBoodschap"
        Me.lblBoodschap.Size = New System.Drawing.Size(79, 17)
        Me.lblBoodschap.TabIndex = 1
        Me.lblBoodschap.Text = "Boodschap"
        '
        'dgvWielermanager
        '
        Me.dgvWielermanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWielermanager.Location = New System.Drawing.Point(12, 21)
        Me.dgvWielermanager.Name = "dgvWielermanager"
        Me.dgvWielermanager.RowTemplate.Height = 24
        Me.dgvWielermanager.Size = New System.Drawing.Size(621, 685)
        Me.dgvWielermanager.TabIndex = 2
        '
        'dgvUitslagKoers
        '
        Me.dgvUitslagKoers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUitslagKoers.Location = New System.Drawing.Point(648, 21)
        Me.dgvUitslagKoers.Name = "dgvUitslagKoers"
        Me.dgvUitslagKoers.RowTemplate.Height = 24
        Me.dgvUitslagKoers.Size = New System.Drawing.Size(562, 685)
        Me.dgvUitslagKoers.TabIndex = 3
        '
        'lstbOverzichtKoersen
        '
        Me.lstbOverzichtKoersen.FormattingEnabled = True
        Me.lstbOverzichtKoersen.ItemHeight = 16
        Me.lstbOverzichtKoersen.Location = New System.Drawing.Point(648, 21)
        Me.lstbOverzichtKoersen.Name = "lstbOverzichtKoersen"
        Me.lstbOverzichtKoersen.Size = New System.Drawing.Size(252, 468)
        Me.lstbOverzichtKoersen.TabIndex = 4
        '
        'lblLstbUitleg
        '
        Me.lblLstbUitleg.AutoSize = True
        Me.lblLstbUitleg.Location = New System.Drawing.Point(906, 33)
        Me.lblLstbUitleg.Name = "lblLstbUitleg"
        Me.lblLstbUitleg.Size = New System.Drawing.Size(66, 17)
        Me.lblLstbUitleg.TabIndex = 5
        Me.lblLstbUitleg.Text = "lstbUitleg"
        '
        'btnOverzicht
        '
        Me.btnOverzicht.Location = New System.Drawing.Point(1216, 21)
        Me.btnOverzicht.Name = "btnOverzicht"
        Me.btnOverzicht.Size = New System.Drawing.Size(83, 23)
        Me.btnOverzicht.TabIndex = 6
        Me.btnOverzicht.Text = "Overzicht"
        Me.btnOverzicht.UseVisualStyleBackColor = True
        '
        'frmWielermanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 747)
        Me.Controls.Add(Me.btnOverzicht)
        Me.Controls.Add(Me.lblLstbUitleg)
        Me.Controls.Add(Me.lstbOverzichtKoersen)
        Me.Controls.Add(Me.dgvUitslagKoers)
        Me.Controls.Add(Me.dgvWielermanager)
        Me.Controls.Add(Me.lblBoodschap)
        Me.Controls.Add(Me.btnTerug)
        Me.Name = "frmWielermanager"
        Me.Text = "frmWielermanager"
        CType(Me.dgvWielermanager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUitslagKoers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents lblBoodschap As System.Windows.Forms.Label
    Friend WithEvents dgvWielermanager As System.Windows.Forms.DataGridView
    Friend WithEvents dgvUitslagKoers As System.Windows.Forms.DataGridView
    Friend WithEvents lstbOverzichtKoersen As System.Windows.Forms.ListBox
    Friend WithEvents lblLstbUitleg As System.Windows.Forms.Label
    Friend WithEvents btnOverzicht As System.Windows.Forms.Button
End Class
