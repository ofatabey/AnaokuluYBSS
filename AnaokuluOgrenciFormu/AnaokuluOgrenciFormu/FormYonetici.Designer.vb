<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYonetici
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
        Me.lb1Ad = New System.Windows.Forms.Label()
        Me.lbl1Soyad = New System.Windows.Forms.Label()
        Me.lbl1TC = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.dgvOgrenciler = New System.Windows.Forms.DataGridView()
        Me.cmbSinif = New System.Windows.Forms.ComboBox()
        Me.lblSinif = New System.Windows.Forms.Label()
        Me.cmbVeli = New System.Windows.Forms.ComboBox()
        Me.lbl1Veli = New System.Windows.Forms.Label()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYas = New System.Windows.Forms.TextBox()
        Me.dtpDogumTarihi = New System.Windows.Forms.DateTimePicker()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.cmbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.txtBoy = New System.Windows.Forms.TextBox()
        Me.txtKilo = New System.Windows.Forms.TextBox()
        Me.btnRapor = New System.Windows.Forms.Button()
        Me.btnOdemeFormu = New System.Windows.Forms.Button()
        CType(Me.dgvOgrenciler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb1Ad
        '
        Me.lb1Ad.AutoSize = True
        Me.lb1Ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb1Ad.Location = New System.Drawing.Point(447, 63)
        Me.lb1Ad.Name = "lb1Ad"
        Me.lb1Ad.Size = New System.Drawing.Size(34, 16)
        Me.lb1Ad.TabIndex = 0
        Me.lb1Ad.Text = "Ad :"
        '
        'lbl1Soyad
        '
        Me.lbl1Soyad.AutoSize = True
        Me.lbl1Soyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl1Soyad.Location = New System.Drawing.Point(413, 112)
        Me.lbl1Soyad.Name = "lbl1Soyad"
        Me.lbl1Soyad.Size = New System.Drawing.Size(64, 16)
        Me.lbl1Soyad.TabIndex = 1
        Me.lbl1Soyad.Text = "Soyad : "
        '
        'lbl1TC
        '
        Me.lbl1TC.AutoSize = True
        Me.lbl1TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl1TC.Location = New System.Drawing.Point(441, 159)
        Me.lbl1TC.Name = "lbl1TC"
        Me.lbl1TC.Size = New System.Drawing.Size(39, 16)
        Me.lbl1TC.TabIndex = 2
        Me.lbl1TC.Text = "TC : "
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(506, 60)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(138, 22)
        Me.txtAd.TabIndex = 3
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(506, 109)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(138, 22)
        Me.txtSoyad.TabIndex = 4
        '
        'txtTC
        '
        Me.txtTC.Location = New System.Drawing.Point(506, 153)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(138, 22)
        Me.txtTC.TabIndex = 5
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.Location = New System.Drawing.Point(671, 328)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(181, 57)
        Me.btnEkle.TabIndex = 6
        Me.btnEkle.Text = "Öğrenci Ekle"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'dgvOgrenciler
        '
        Me.dgvOgrenciler.BackgroundColor = System.Drawing.Color.BlanchedAlmond
        Me.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOgrenciler.Location = New System.Drawing.Point(81, 400)
        Me.dgvOgrenciler.Name = "dgvOgrenciler"
        Me.dgvOgrenciler.RowHeadersWidth = 51
        Me.dgvOgrenciler.RowTemplate.Height = 24
        Me.dgvOgrenciler.Size = New System.Drawing.Size(1372, 218)
        Me.dgvOgrenciler.TabIndex = 7
        '
        'cmbSinif
        '
        Me.cmbSinif.FormattingEnabled = True
        Me.cmbSinif.Location = New System.Drawing.Point(506, 199)
        Me.cmbSinif.Name = "cmbSinif"
        Me.cmbSinif.Size = New System.Drawing.Size(138, 24)
        Me.cmbSinif.TabIndex = 8
        '
        'lblSinif
        '
        Me.lblSinif.AutoSize = True
        Me.lblSinif.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSinif.Location = New System.Drawing.Point(430, 202)
        Me.lblSinif.Name = "lblSinif"
        Me.lblSinif.Size = New System.Drawing.Size(49, 16)
        Me.lblSinif.TabIndex = 9
        Me.lblSinif.Text = "Sınıf : "
        '
        'cmbVeli
        '
        Me.cmbVeli.FormattingEnabled = True
        Me.cmbVeli.Location = New System.Drawing.Point(506, 247)
        Me.cmbVeli.Name = "cmbVeli"
        Me.cmbVeli.Size = New System.Drawing.Size(138, 24)
        Me.cmbVeli.TabIndex = 10
        '
        'lbl1Veli
        '
        Me.lbl1Veli.AutoSize = True
        Me.lbl1Veli.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl1Veli.Location = New System.Drawing.Point(433, 250)
        Me.lbl1Veli.Name = "lbl1Veli"
        Me.lbl1Veli.Size = New System.Drawing.Size(46, 16)
        Me.lbl1Veli.TabIndex = 11
        Me.lbl1Veli.Text = "Veli : "
        '
        'btnSil
        '
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Location = New System.Drawing.Point(883, 333)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(136, 46)
        Me.btnSil.TabIndex = 12
        Me.btnSil.Text = "Öğrenci Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.Location = New System.Drawing.Point(495, 333)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(138, 46)
        Me.btnGuncelle.TabIndex = 13
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(781, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cinsiyet : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(812, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Yaş : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(796, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Adres : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(738, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Doğum Tarihi : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(812, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Boy : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(812, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Kilo :"
        '
        'txtYas
        '
        Me.txtYas.Location = New System.Drawing.Point(881, 91)
        Me.txtYas.Name = "txtYas"
        Me.txtYas.Size = New System.Drawing.Size(138, 22)
        Me.txtYas.TabIndex = 21
        '
        'dtpDogumTarihi
        '
        Me.dtpDogumTarihi.Location = New System.Drawing.Point(881, 271)
        Me.dtpDogumTarihi.Name = "dtpDogumTarihi"
        Me.dtpDogumTarihi.Size = New System.Drawing.Size(253, 22)
        Me.dtpDogumTarihi.TabIndex = 22
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(881, 136)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(138, 22)
        Me.txtAdres.TabIndex = 23
        '
        'cmbCinsiyet
        '
        Me.cmbCinsiyet.FormattingEnabled = True
        Me.cmbCinsiyet.Location = New System.Drawing.Point(881, 49)
        Me.cmbCinsiyet.Name = "cmbCinsiyet"
        Me.cmbCinsiyet.Size = New System.Drawing.Size(138, 24)
        Me.cmbCinsiyet.TabIndex = 24
        '
        'txtBoy
        '
        Me.txtBoy.Location = New System.Drawing.Point(881, 180)
        Me.txtBoy.Name = "txtBoy"
        Me.txtBoy.Size = New System.Drawing.Size(67, 22)
        Me.txtBoy.TabIndex = 25
        '
        'txtKilo
        '
        Me.txtKilo.Location = New System.Drawing.Point(881, 221)
        Me.txtKilo.Name = "txtKilo"
        Me.txtKilo.Size = New System.Drawing.Size(67, 22)
        Me.txtKilo.TabIndex = 26
        '
        'btnRapor
        '
        Me.btnRapor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRapor.Location = New System.Drawing.Point(572, 637)
        Me.btnRapor.Name = "btnRapor"
        Me.btnRapor.Size = New System.Drawing.Size(184, 51)
        Me.btnRapor.TabIndex = 27
        Me.btnRapor.Text = "RAPOR OLUŞTUR"
        Me.btnRapor.UseVisualStyleBackColor = False
        '
        'btnOdemeFormu
        '
        Me.btnOdemeFormu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOdemeFormu.Location = New System.Drawing.Point(784, 637)
        Me.btnOdemeFormu.Name = "btnOdemeFormu"
        Me.btnOdemeFormu.Size = New System.Drawing.Size(189, 51)
        Me.btnOdemeFormu.TabIndex = 28
        Me.btnOdemeFormu.Text = "ÖDEME PANELİ"
        Me.btnOdemeFormu.UseVisualStyleBackColor = False
        '
        'FormYonetici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1522, 759)
        Me.Controls.Add(Me.btnOdemeFormu)
        Me.Controls.Add(Me.btnRapor)
        Me.Controls.Add(Me.txtKilo)
        Me.Controls.Add(Me.txtBoy)
        Me.Controls.Add(Me.cmbCinsiyet)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.dtpDogumTarihi)
        Me.Controls.Add(Me.txtYas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.lbl1Veli)
        Me.Controls.Add(Me.cmbVeli)
        Me.Controls.Add(Me.lblSinif)
        Me.Controls.Add(Me.cmbSinif)
        Me.Controls.Add(Me.dgvOgrenciler)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.txtTC)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.lbl1TC)
        Me.Controls.Add(Me.lbl1Soyad)
        Me.Controls.Add(Me.lb1Ad)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "FormYonetici"
        Me.Text = "Form1"
        CType(Me.dgvOgrenciler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1Ad As Label
    Friend WithEvents lbl1Soyad As Label
    Friend WithEvents lbl1TC As Label
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtTC As TextBox
    Friend WithEvents btnEkle As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents dgvOgrenciler As DataGridView
    Friend WithEvents cmbSinif As ComboBox
    Friend WithEvents lblSinif As Label
    Friend WithEvents cmbVeli As ComboBox
    Friend WithEvents lbl1Veli As Label
    Friend WithEvents btnSil As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtYas As TextBox
    Friend WithEvents dtpDogumTarihi As DateTimePicker
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents cmbCinsiyet As ComboBox
    Friend WithEvents txtBoy As TextBox
    Friend WithEvents txtKilo As TextBox
    Friend WithEvents btnRapor As Button
    Friend WithEvents btnOdemeFormu As Button
End Class
