<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYemekhane
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
        Me.dgvYemekler = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.cmbOgun = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnYenile = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbOgrenci = New System.Windows.Forms.ComboBox()
        CType(Me.dgvYemekler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvYemekler
        '
        Me.dgvYemekler.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYemekler.Location = New System.Drawing.Point(165, 284)
        Me.dgvYemekler.Name = "dgvYemekler"
        Me.dgvYemekler.RowHeadersWidth = 51
        Me.dgvYemekler.RowTemplate.Height = 24
        Me.dgvYemekler.Size = New System.Drawing.Size(443, 177)
        Me.dgvYemekler.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Serif Armenian", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "YEMEK EKLE"
        '
        'dtpTarih
        '
        Me.dtpTarih.Location = New System.Drawing.Point(295, 144)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(231, 22)
        Me.dtpTarih.TabIndex = 2
        '
        'cmbOgun
        '
        Me.cmbOgun.FormattingEnabled = True
        Me.cmbOgun.Location = New System.Drawing.Point(295, 181)
        Me.cmbOgun.Name = "cmbOgun"
        Me.cmbOgun.Size = New System.Drawing.Size(231, 24)
        Me.cmbOgun.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tarih : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Öğün : "
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.Location = New System.Drawing.Point(413, 230)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(113, 36)
        Me.btnEkle.TabIndex = 6
        Me.btnEkle.Text = "EKLE"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'btnYenile
        '
        Me.btnYenile.BackColor = System.Drawing.Color.PeachPuff
        Me.btnYenile.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYenile.Location = New System.Drawing.Point(247, 490)
        Me.btnYenile.Name = "btnYenile"
        Me.btnYenile.Size = New System.Drawing.Size(135, 46)
        Me.btnYenile.TabIndex = 7
        Me.btnYenile.Text = "YENİLE"
        Me.btnYenile.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCikis.Location = New System.Drawing.Point(392, 490)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(134, 46)
        Me.btnCikis.TabIndex = 8
        Me.btnCikis.Text = "ÇIKIŞ "
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Öğrenci :"
        '
        'cmbOgrenci
        '
        Me.cmbOgrenci.FormattingEnabled = True
        Me.cmbOgrenci.Location = New System.Drawing.Point(295, 107)
        Me.cmbOgrenci.Name = "cmbOgrenci"
        Me.cmbOgrenci.Size = New System.Drawing.Size(231, 24)
        Me.cmbOgrenci.TabIndex = 10
        '
        'FormYemekhane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(800, 635)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.btnYenile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbOgrenci)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbOgun)
        Me.Controls.Add(Me.dtpTarih)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvYemekler)
        Me.Name = "FormYemekhane"
        Me.Text = "Form1"
        CType(Me.dgvYemekler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvYemekler As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTarih As DateTimePicker
    Friend WithEvents cmbOgun As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnYenile As Button
    Friend WithEvents btnCikis As Button
    Friend WithEvents cmbOgrenci As ComboBox
    Friend WithEvents Label4 As Label

End Class
