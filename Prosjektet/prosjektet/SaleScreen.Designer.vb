<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaleScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLeggTilKunde = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnSlettKunde = New System.Windows.Forms.Button()
        Me.btnOrdre = New System.Windows.Forms.Button()
        Me.btnAvslutt = New System.Windows.Forms.Button()
        Me.btnStatistikk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(418, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(498, 199)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(520, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kundeliste"
        '
        'btnLeggTilKunde
        '
        Me.btnLeggTilKunde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeggTilKunde.Location = New System.Drawing.Point(210, 83)
        Me.btnLeggTilKunde.Name = "btnLeggTilKunde"
        Me.btnLeggTilKunde.Size = New System.Drawing.Size(162, 59)
        Me.btnLeggTilKunde.TabIndex = 2
        Me.btnLeggTilKunde.Text = "Legg til kunde"
        Me.btnLeggTilKunde.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOppdater.Location = New System.Drawing.Point(210, 148)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(162, 59)
        Me.btnOppdater.TabIndex = 3
        Me.btnOppdater.Text = "Oppdater kundeliste"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnSlettKunde
        '
        Me.btnSlettKunde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlettKunde.Location = New System.Drawing.Point(210, 213)
        Me.btnSlettKunde.Name = "btnSlettKunde"
        Me.btnSlettKunde.Size = New System.Drawing.Size(162, 59)
        Me.btnSlettKunde.TabIndex = 4
        Me.btnSlettKunde.Text = "Slett kunde"
        Me.btnSlettKunde.UseVisualStyleBackColor = True
        '
        'btnOrdre
        '
        Me.btnOrdre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdre.Location = New System.Drawing.Point(957, 83)
        Me.btnOrdre.Name = "btnOrdre"
        Me.btnOrdre.Size = New System.Drawing.Size(162, 59)
        Me.btnOrdre.TabIndex = 5
        Me.btnOrdre.Text = "Legg til Ordre"
        Me.btnOrdre.UseVisualStyleBackColor = True
        '
        'btnAvslutt
        '
        Me.btnAvslutt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvslutt.Location = New System.Drawing.Point(1011, 344)
        Me.btnAvslutt.Name = "btnAvslutt"
        Me.btnAvslutt.Size = New System.Drawing.Size(162, 59)
        Me.btnAvslutt.TabIndex = 6
        Me.btnAvslutt.Text = "Avslutt"
        Me.btnAvslutt.UseVisualStyleBackColor = True
        '
        'btnStatistikk
        '
        Me.btnStatistikk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistikk.Location = New System.Drawing.Point(957, 148)
        Me.btnStatistikk.Name = "btnStatistikk"
        Me.btnStatistikk.Size = New System.Drawing.Size(162, 59)
        Me.btnStatistikk.TabIndex = 7
        Me.btnStatistikk.Text = "Se statistikk"
        Me.btnStatistikk.UseVisualStyleBackColor = True
        '
        'SaleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 415)
        Me.Controls.Add(Me.btnStatistikk)
        Me.Controls.Add(Me.btnAvslutt)
        Me.Controls.Add(Me.btnOrdre)
        Me.Controls.Add(Me.btnSlettKunde)
        Me.Controls.Add(Me.btnOppdater)
        Me.Controls.Add(Me.btnLeggTilKunde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "SaleScreen"
        Me.Text = "SaleScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLeggTilKunde As Button
    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnSlettKunde As Button
    Friend WithEvents btnOrdre As Button
    Friend WithEvents btnAvslutt As Button
    Friend WithEvents btnStatistikk As Button
End Class
