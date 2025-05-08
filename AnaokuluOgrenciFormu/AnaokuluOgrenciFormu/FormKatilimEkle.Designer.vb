<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKatilimEkle
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKatilimEkle = New System.Windows.Forms.Button()
        Me.cmbOgrenci = New System.Windows.Forms.ComboBox()
        Me.cmbAktivite = New System.Windows.Forms.ComboBox()
        Me.dtpKatilimTarih = New System.Windows.Forms.DateTimePicker()
        Me.chkVeliOnay = New System.Windows.Forms.CheckBox()
        Me.chkKatildi = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KATILIM FORMU "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Öğrenci : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Aktivite : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tarih : "
        '
        'btnKatilimEkle
        '
        Me.btnKatilimEkle.BackColor = System.Drawing.Color.DarkGray
        Me.btnKatilimEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKatilimEkle.Location = New System.Drawing.Point(267, 355)
        Me.btnKatilimEkle.Name = "btnKatilimEkle"
        Me.btnKatilimEkle.Size = New System.Drawing.Size(149, 46)
        Me.btnKatilimEkle.TabIndex = 9
        Me.btnKatilimEkle.Text = "Katılım Ekle"
        Me.btnKatilimEkle.UseVisualStyleBackColor = False
        '
        'cmbOgrenci
        '
        Me.cmbOgrenci.FormattingEnabled = True
        Me.cmbOgrenci.Location = New System.Drawing.Point(267, 112)
        Me.cmbOgrenci.Name = "cmbOgrenci"
        Me.cmbOgrenci.Size = New System.Drawing.Size(222, 24)
        Me.cmbOgrenci.TabIndex = 10
        '
        'cmbAktivite
        '
        Me.cmbAktivite.FormattingEnabled = True
        Me.cmbAktivite.Location = New System.Drawing.Point(267, 157)
        Me.cmbAktivite.Name = "cmbAktivite"
        Me.cmbAktivite.Size = New System.Drawing.Size(222, 24)
        Me.cmbAktivite.TabIndex = 11
        '
        'dtpKatilimTarih
        '
        Me.dtpKatilimTarih.Location = New System.Drawing.Point(267, 209)
        Me.dtpKatilimTarih.Name = "dtpKatilimTarih"
        Me.dtpKatilimTarih.Size = New System.Drawing.Size(222, 22)
        Me.dtpKatilimTarih.TabIndex = 12
        '
        'chkVeliOnay
        '
        Me.chkVeliOnay.AutoSize = True
        Me.chkVeliOnay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chkVeliOnay.Location = New System.Drawing.Point(267, 263)
        Me.chkVeliOnay.Name = "chkVeliOnay"
        Me.chkVeliOnay.Size = New System.Drawing.Size(150, 20)
        Me.chkVeliOnay.TabIndex = 13
        Me.chkVeliOnay.Text = "Veli Onayladı mı?"
        Me.chkVeliOnay.UseVisualStyleBackColor = True
        '
        'chkKatildi
        '
        Me.chkKatildi.AutoSize = True
        Me.chkKatildi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chkKatildi.Location = New System.Drawing.Point(267, 302)
        Me.chkKatildi.Name = "chkKatildi"
        Me.chkKatildi.Size = New System.Drawing.Size(100, 20)
        Me.chkKatildi.TabIndex = 14
        Me.chkKatildi.Text = "Katıldı mı?"
        Me.chkKatildi.UseVisualStyleBackColor = True
        '
        'FormKatilimEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 474)
        Me.Controls.Add(Me.chkKatildi)
        Me.Controls.Add(Me.chkVeliOnay)
        Me.Controls.Add(Me.dtpKatilimTarih)
        Me.Controls.Add(Me.cmbAktivite)
        Me.Controls.Add(Me.cmbOgrenci)
        Me.Controls.Add(Me.btnKatilimEkle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormKatilimEkle"
        Me.Text = "FormKatilimEkle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKatilimEkle As Button
    Friend WithEvents cmbOgrenci As ComboBox
    Friend WithEvents cmbAktivite As ComboBox
    Friend WithEvents dtpKatilimTarih As DateTimePicker
    Friend WithEvents chkVeliOnay As CheckBox
    Friend WithEvents chkKatildi As CheckBox
End Class
