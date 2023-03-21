<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Loading
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
        Me.components = New System.ComponentModel.Container()
        Me.PB1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_LoadingPercent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PB1
        '
        Me.PB1.Location = New System.Drawing.Point(0, 0)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(584, 97)
        Me.PB1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PB1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'LBL_LoadingPercent
        '
        Me.LBL_LoadingPercent.AutoSize = True
        Me.LBL_LoadingPercent.BackColor = System.Drawing.Color.Silver
        Me.LBL_LoadingPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_LoadingPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LoadingPercent.Location = New System.Drawing.Point(560, 77)
        Me.LBL_LoadingPercent.Name = "LBL_LoadingPercent"
        Me.LBL_LoadingPercent.Size = New System.Drawing.Size(19, 20)
        Me.LBL_LoadingPercent.TabIndex = 1
        Me.LBL_LoadingPercent.Text = "0"
        Me.LBL_LoadingPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(584, 97)
        Me.Controls.Add(Me.LBL_LoadingPercent)
        Me.Controls.Add(Me.PB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LBL_LoadingPercent As System.Windows.Forms.Label
End Class
