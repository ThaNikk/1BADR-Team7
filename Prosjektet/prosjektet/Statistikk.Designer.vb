<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistikk
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
        Me.cbStatistikk = New System.Windows.Forms.ComboBox()
        Me.lbStatistikk = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbStatistikk
        '
        Me.cbStatistikk.FormattingEnabled = True
        Me.cbStatistikk.Location = New System.Drawing.Point(169, 35)
        Me.cbStatistikk.Name = "cbStatistikk"
        Me.cbStatistikk.Size = New System.Drawing.Size(327, 21)
        Me.cbStatistikk.TabIndex = 0
        '
        'lbStatistikk
        '
        Me.lbStatistikk.FormattingEnabled = True
        Me.lbStatistikk.Location = New System.Drawing.Point(169, 98)
        Me.lbStatistikk.Name = "lbStatistikk"
        Me.lbStatistikk.Size = New System.Drawing.Size(749, 303)
        Me.lbStatistikk.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(518, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbStatistikk)
        Me.Controls.Add(Me.cbStatistikk)
        Me.Name = "Statistikk"
        Me.Text = "Statistikk"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbStatistikk As ComboBox
    Friend WithEvents lbStatistikk As ListBox
    Friend WithEvents Button1 As Button
End Class
