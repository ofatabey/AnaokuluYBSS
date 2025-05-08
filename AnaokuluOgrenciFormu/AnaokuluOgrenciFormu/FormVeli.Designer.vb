<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVeli
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvKatilimlar = New System.Windows.Forms.DataGridView()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.btnYenile = New System.Windows.Forms.Button()
        Me.btnRapor = New System.Windows.Forms.Button()
        CType(Me.dgvKatilimlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VELİ PANELİ"
        '
        'dgvKatilimlar
        '
        Me.dgvKatilimlar.BackgroundColor = System.Drawing.Color.Azure
        Me.dgvKatilimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKatilimlar.Location = New System.Drawing.Point(74, 114)
        Me.dgvKatilimlar.Name = "dgvKatilimlar"
        Me.dgvKatilimlar.RowHeadersWidth = 51
        Me.dgvKatilimlar.RowTemplate.Height = 24
        Me.dgvKatilimlar.Size = New System.Drawing.Size(446, 287)
        Me.dgvKatilimlar.TabIndex = 1
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.CadetBlue
        Me.btnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCikis.Location = New System.Drawing.Point(305, 442)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(124, 47)
        Me.btnCikis.TabIndex = 2
        Me.btnCikis.Text = "ÇIKIŞ "
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'btnYenile
        '
        Me.btnYenile.BackColor = System.Drawing.Color.CadetBlue
        Me.btnYenile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYenile.Location = New System.Drawing.Point(142, 442)
        Me.btnYenile.Name = "btnYenile"
        Me.btnYenile.Size = New System.Drawing.Size(120, 47)
        Me.btnYenile.TabIndex = 3
        Me.btnYenile.Text = "YENİLE"
        Me.btnYenile.UseVisualStyleBackColor = False
        '
        'btnRapor
        '
        Me.btnRapor.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnRapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRapor.Location = New System.Drawing.Point(216, 516)
        Me.btnRapor.Name = "btnRapor"
        Me.btnRapor.Size = New System.Drawing.Size(144, 41)
        Me.btnRapor.TabIndex = 4
        Me.btnRapor.Text = "RAPOR AL"
        Me.btnRapor.UseVisualStyleBackColor = False
        '
        'FormVeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(602, 650)
        Me.Controls.Add(Me.btnRapor)
        Me.Controls.Add(Me.btnYenile)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.dgvKatilimlar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormVeli"
        Me.Text = "FormVeli"
        CType(Me.dgvKatilimlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvKatilimlar As DataGridView
    Friend WithEvents btnCikis As Button
    Friend WithEvents btnYenile As Button
    Friend WithEvents btnRapor As Button
End Class
