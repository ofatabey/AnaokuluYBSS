<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOdeme
    Inherits System.Windows.Forms.Form

    'Form, bileşenleri temizlemek için Dispose özelliğini geçersiz kılar.
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

    'Windows Form Designer tarafından gereklidir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki prosedür Windows Form Designer için gereklidir
    'Windows Form Designer kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvOdeme = New System.Windows.Forms.DataGridView()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.cmbOgrenci = New System.Windows.Forms.ComboBox()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.txtTur = New System.Windows.Forms.TextBox()
        Me.txtMiktar = New System.Windows.Forms.TextBox()
        Me.txtToplam = New System.Windows.Forms.TextBox()
        Me.lblOgrenci = New System.Windows.Forms.Label()
        Me.lblTarih = New System.Windows.Forms.Label()
        Me.lblTur = New System.Windows.Forms.Label()
        Me.lblMiktar = New System.Windows.Forms.Label()
        Me.lblToplam = New System.Windows.Forms.Label()
        CType(Me.dgvOdeme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOdeme
        '
        Me.dgvOdeme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOdeme.Location = New System.Drawing.Point(33, 218)
        Me.dgvOdeme.Name = "dgvOdeme"
        Me.dgvOdeme.RowHeadersWidth = 51
        Me.dgvOdeme.RowTemplate.Height = 24
        Me.dgvOdeme.Size = New System.Drawing.Size(776, 200)
        Me.dgvOdeme.TabIndex = 0
        '
        'btnEkle
        '
        Me.btnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.Location = New System.Drawing.Point(706, 56)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(93, 46)
        Me.btnEkle.TabIndex = 1
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Location = New System.Drawing.Point(706, 126)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(93, 46)
        Me.btnSil.TabIndex = 2
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'cmbOgrenci
        '
        Me.cmbOgrenci.FormattingEnabled = True
        Me.cmbOgrenci.Location = New System.Drawing.Point(127, 33)
        Me.cmbOgrenci.Name = "cmbOgrenci"
        Me.cmbOgrenci.Size = New System.Drawing.Size(200, 24)
        Me.cmbOgrenci.TabIndex = 3
        '
        'dtpTarih
        '
        Me.dtpTarih.Location = New System.Drawing.Point(127, 63)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(200, 22)
        Me.dtpTarih.TabIndex = 4
        '
        'txtTur
        '
        Me.txtTur.Location = New System.Drawing.Point(127, 93)
        Me.txtTur.Name = "txtTur"
        Me.txtTur.Size = New System.Drawing.Size(200, 22)
        Me.txtTur.TabIndex = 5
        '
        'txtMiktar
        '
        Me.txtMiktar.Location = New System.Drawing.Point(127, 123)
        Me.txtMiktar.Name = "txtMiktar"
        Me.txtMiktar.Size = New System.Drawing.Size(200, 22)
        Me.txtMiktar.TabIndex = 6
        '
        'txtToplam
        '
        Me.txtToplam.Location = New System.Drawing.Point(127, 153)
        Me.txtToplam.Name = "txtToplam"
        Me.txtToplam.Size = New System.Drawing.Size(200, 22)
        Me.txtToplam.TabIndex = 7
        '
        'lblOgrenci
        '
        Me.lblOgrenci.AutoSize = True
        Me.lblOgrenci.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblOgrenci.Location = New System.Drawing.Point(37, 36)
        Me.lblOgrenci.Name = "lblOgrenci"
        Me.lblOgrenci.Size = New System.Drawing.Size(65, 16)
        Me.lblOgrenci.TabIndex = 8
        Me.lblOgrenci.Text = "Öğrenci:"
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTarih.Location = New System.Drawing.Point(37, 68)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(47, 16)
        Me.lblTarih.TabIndex = 9
        Me.lblTarih.Text = "Tarih:"
        '
        'lblTur
        '
        Me.lblTur.AutoSize = True
        Me.lblTur.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTur.Location = New System.Drawing.Point(37, 96)
        Me.lblTur.Name = "lblTur"
        Me.lblTur.Size = New System.Drawing.Size(34, 16)
        Me.lblTur.TabIndex = 10
        Me.lblTur.Text = "Tür:"
        '
        'lblMiktar
        '
        Me.lblMiktar.AutoSize = True
        Me.lblMiktar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMiktar.Location = New System.Drawing.Point(37, 126)
        Me.lblMiktar.Name = "lblMiktar"
        Me.lblMiktar.Size = New System.Drawing.Size(53, 16)
        Me.lblMiktar.TabIndex = 11
        Me.lblMiktar.Text = "Miktar:"
        '
        'lblToplam
        '
        Me.lblToplam.AutoSize = True
        Me.lblToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplam.Location = New System.Drawing.Point(37, 156)
        Me.lblToplam.Name = "lblToplam"
        Me.lblToplam.Size = New System.Drawing.Size(64, 16)
        Me.lblToplam.TabIndex = 12
        Me.lblToplam.Text = "Toplam:"
        '
        'FormOdeme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(842, 475)
        Me.Controls.Add(Me.lblToplam)
        Me.Controls.Add(Me.lblMiktar)
        Me.Controls.Add(Me.lblTur)
        Me.Controls.Add(Me.lblTarih)
        Me.Controls.Add(Me.lblOgrenci)
        Me.Controls.Add(Me.txtToplam)
        Me.Controls.Add(Me.txtMiktar)
        Me.Controls.Add(Me.txtTur)
        Me.Controls.Add(Me.dtpTarih)
        Me.Controls.Add(Me.cmbOgrenci)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.dgvOdeme)
        Me.Name = "FormOdeme"
        Me.Text = "Ödeme Paneli"
        CType(Me.dgvOdeme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOdeme As DataGridView
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents cmbOgrenci As ComboBox
    Friend WithEvents dtpTarih As DateTimePicker
    Friend WithEvents txtTur As TextBox
    Friend WithEvents txtMiktar As TextBox
    Friend WithEvents txtToplam As TextBox
    Friend WithEvents lblOgrenci As Label
    Friend WithEvents lblTarih As Label
    Friend WithEvents lblTur As Label
    Friend WithEvents lblMiktar As Label
    Friend WithEvents lblToplam As Label
End Class
