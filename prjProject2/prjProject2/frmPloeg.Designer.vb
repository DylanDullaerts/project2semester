<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPloeg
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
        Me.lstbRenners = New System.Windows.Forms.ListBox()
        Me.btnTerug = New System.Windows.Forms.Button()
        Me.lblBoodschap = New System.Windows.Forms.Label()
        Me.pictRenner = New System.Windows.Forms.PictureBox()
        Me.lstbResultaten = New System.Windows.Forms.ListBox()
        CType(Me.pictRenner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstbRenners
        '
        Me.lstbRenners.FormattingEnabled = True
        Me.lstbRenners.ItemHeight = 16
        Me.lstbRenners.Location = New System.Drawing.Point(12, 12)
        Me.lstbRenners.Name = "lstbRenners"
        Me.lstbRenners.Size = New System.Drawing.Size(444, 580)
        Me.lstbRenners.TabIndex = 0
        '
        'btnTerug
        '
        Me.btnTerug.Location = New System.Drawing.Point(1176, 721)
        Me.btnTerug.Name = "btnTerug"
        Me.btnTerug.Size = New System.Drawing.Size(75, 23)
        Me.btnTerug.TabIndex = 1
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'lblBoodschap
        '
        Me.lblBoodschap.AutoSize = True
        Me.lblBoodschap.Location = New System.Drawing.Point(12, 730)
        Me.lblBoodschap.Name = "lblBoodschap"
        Me.lblBoodschap.Size = New System.Drawing.Size(79, 17)
        Me.lblBoodschap.TabIndex = 2
        Me.lblBoodschap.Text = "Boodschap"
        '
        'pictRenner
        '
        Me.pictRenner.Location = New System.Drawing.Point(462, 12)
        Me.pictRenner.Name = "pictRenner"
        Me.pictRenner.Size = New System.Drawing.Size(206, 224)
        Me.pictRenner.TabIndex = 3
        Me.pictRenner.TabStop = False
        '
        'lstbResultaten
        '
        Me.lstbResultaten.FormattingEnabled = True
        Me.lstbResultaten.ItemHeight = 16
        Me.lstbResultaten.Location = New System.Drawing.Point(674, 12)
        Me.lstbResultaten.Name = "lstbResultaten"
        Me.lstbResultaten.Size = New System.Drawing.Size(456, 580)
        Me.lstbResultaten.TabIndex = 4
        '
        'frmPloeg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 756)
        Me.Controls.Add(Me.lstbResultaten)
        Me.Controls.Add(Me.pictRenner)
        Me.Controls.Add(Me.lblBoodschap)
        Me.Controls.Add(Me.btnTerug)
        Me.Controls.Add(Me.lstbRenners)
        Me.Name = "frmPloeg"
        Me.Text = "frmPloeg"
        CType(Me.pictRenner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbRenners As System.Windows.Forms.ListBox
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents lblBoodschap As System.Windows.Forms.Label
    Friend WithEvents pictRenner As System.Windows.Forms.PictureBox
    Friend WithEvents lstbResultaten As System.Windows.Forms.ListBox
End Class
