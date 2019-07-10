<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCorrect
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCorrect))
        Me.PBar = New System.Windows.Forms.ProgressBar()
        Me.PatchButton = New System.Windows.Forms.PictureBox()
        CType(Me.PatchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBar
        '
        Me.PBar.Location = New System.Drawing.Point(50, 88)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(248, 24)
        Me.PBar.TabIndex = 0
        '
        'PatchButton
        '
        Me.PatchButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PatchButton.Image = CType(resources.GetObject("PatchButton.Image"), System.Drawing.Image)
        Me.PatchButton.Location = New System.Drawing.Point(33, 88)
        Me.PatchButton.Name = "PatchButton"
        Me.PatchButton.Size = New System.Drawing.Size(277, 38)
        Me.PatchButton.TabIndex = 1
        Me.PatchButton.TabStop = False
        '
        'FormCorrect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(327, 177)
        Me.Controls.Add(Me.PatchButton)
        Me.Controls.Add(Me.PBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCorrect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bnet fail correction"
        CType(Me.PatchButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBar As ProgressBar
    Friend WithEvents PatchButton As PictureBox
End Class
