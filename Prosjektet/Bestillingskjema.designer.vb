<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bestillingskjema
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnRegistrerVare = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.teller = New System.Windows.Forms.NumericUpDown()
        Me.btnRegBestilling = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBestilling = New System.Windows.Forms.ComboBox()
        CType(Me.teller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(254, 212)
        Me.ListBox1.TabIndex = 0
        '
        'btnRegistrerVare
        '
        Me.btnRegistrerVare.Location = New System.Drawing.Point(192, 6)
        Me.btnRegistrerVare.Name = "btnRegistrerVare"
        Me.btnRegistrerVare.Size = New System.Drawing.Size(109, 21)
        Me.btnRegistrerVare.TabIndex = 1
        Me.btnRegistrerVare.Text = "Registrer vare"
        Me.btnRegistrerVare.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(47, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Salg"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(95, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Utleie"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'teller
        '
        Me.teller.Location = New System.Drawing.Point(153, 7)
        Me.teller.Name = "teller"
        Me.teller.Size = New System.Drawing.Size(33, 20)
        Me.teller.TabIndex = 5
        '
        'btnRegBestilling
        '
        Me.btnRegBestilling.Location = New System.Drawing.Point(272, 269)
        Me.btnRegBestilling.Name = "btnRegBestilling"
        Me.btnRegBestilling.Size = New System.Drawing.Size(103, 23)
        Me.btnRegBestilling.TabIndex = 6
        Me.btnRegBestilling.Text = "Ferdig"
        Me.btnRegBestilling.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Vare"
        '
        'cbBestilling
        '
        Me.cbBestilling.FormattingEnabled = True
        Me.cbBestilling.Location = New System.Drawing.Point(47, 7)
        Me.cbBestilling.Name = "cbBestilling"
        Me.cbBestilling.Size = New System.Drawing.Size(100, 21)
        Me.cbBestilling.TabIndex = 8
        '
        'Bestillingskjema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 312)
        Me.Controls.Add(Me.cbBestilling)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegBestilling)
        Me.Controls.Add(Me.teller)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnRegistrerVare)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Bestillingskjema"
        Me.Text = "Bestilling"
        CType(Me.teller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnRegistrerVare As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents teller As NumericUpDown
    Friend WithEvents btnRegBestilling As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbBestilling As ComboBox
End Class
