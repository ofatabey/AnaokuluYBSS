<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOgretmen
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
        Me.lblSinifListesi = New System.Windows.Forms.Label()
        Me.dgvSinifListesi = New System.Windows.Forms.DataGridView()
        Me.btnAktiviteOlustur = New System.Windows.Forms.Button()
        Me.btnKatilimGirisi = New System.Windows.Forms.Button()
        CType(Me.dgvSinifListesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSinifListesi
        '
        Me.lblSinifListesi.AutoSize = True
        Me.lblSinifListesi.BackColor = System.Drawing.Color.FloralWhite
        Me.lblSinifListesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSinifListesi.Location = New System.Drawing.Point(47, 49)
        Me.lblSinifListesi.Name = "lblSinifListesi"
        Me.lblSinifListesi.Size = New System.Drawing.Size(105, 16)
        Me.lblSinifListesi.TabIndex = 0
        Me.lblSinifListesi.Text = "SINIF LİSTESİ"
        '
        'dgvSinifListesi
        '
        Me.dgvSinifListesi.BackgroundColor = System.Drawing.Color.Beige
        Me.dgvSinifListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinifListesi.Location = New System.Drawing.Point(41, 85)
        Me.dgvSinifListesi.Name = "dgvSinifListesi"
        Me.dgvSinifListesi.RowHeadersWidth = 51
        Me.dgvSinifListesi.RowTemplate.Height = 24
        Me.dgvSinifListesi.Size = New System.Drawing.Size(1146, 307)
        Me.dgvSinifListesi.TabIndex = 1
        '
        'btnAktiviteOlustur
        '
        Me.btnAktiviteOlustur.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAktiviteOlustur.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAktiviteOlustur.Location = New System.Drawing.Point(450, 446)
        Me.btnAktiviteOlustur.Name = "btnAktiviteOlustur"
        Me.btnAktiviteOlustur.Size = New System.Drawing.Size(159, 59)
        Me.btnAktiviteOlustur.TabIndex = 2
        Me.btnAktiviteOlustur.Text = "Aktivite Oluştur"
        Me.btnAktiviteOlustur.UseVisualStyleBackColor = False
        '
        'btnKatilimGirisi
        '
        Me.btnKatilimGirisi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnKatilimGirisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKatilimGirisi.Location = New System.Drawing.Point(663, 447)
        Me.btnKatilimGirisi.Name = "btnKatilimGirisi"
        Me.btnKatilimGirisi.Size = New System.Drawing.Size(159, 58)
        Me.btnKatilimGirisi.TabIndex = 3
        Me.btnKatilimGirisi.Text = "Katılım Girişi"
        Me.btnKatilimGirisi.UseVisualStyleBackColor = False
        '
        'FormOgretmen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1226, 564)
        Me.Controls.Add(Me.btnKatilimGirisi)
        Me.Controls.Add(Me.btnAktiviteOlustur)
        Me.Controls.Add(Me.dgvSinifListesi)
        Me.Controls.Add(Me.lblSinifListesi)
        Me.Name = "FormOgretmen"
        Me.Text = "FormOgretmen"
        CType(Me.dgvSinifListesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSinifListesi As Label
    Friend WithEvents dgvSinifListesi As DataGridView
    Friend WithEvents btnAktiviteOlustur As Button
    Friend WithEvents btnKatilimGirisi As Button
End Class
