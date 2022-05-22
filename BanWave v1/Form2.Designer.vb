<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DownloadFame = New System.Windows.Forms.Button()
        Me.Out = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DownloadFame
        '
        Me.DownloadFame.Location = New System.Drawing.Point(13, 13)
        Me.DownloadFame.Name = "DownloadFame"
        Me.DownloadFame.Size = New System.Drawing.Size(75, 23)
        Me.DownloadFame.TabIndex = 0
        Me.DownloadFame.Text = "Download"
        Me.DownloadFame.UseVisualStyleBackColor = True
        '
        'Out
        '
        Me.Out.Location = New System.Drawing.Point(13, 43)
        Me.Out.Multiline = True
        Me.Out.Name = "Out"
        Me.Out.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Out.Size = New System.Drawing.Size(775, 19)
        Me.Out.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 68)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(775, 370)
        Me.TextBox1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Out)
        Me.Controls.Add(Me.DownloadFame)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DownloadFame As Button
    Friend WithEvents Out As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
