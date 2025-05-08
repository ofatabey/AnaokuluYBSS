<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPanel
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
        Me.lblKullaniciAdi = New System.Windows.Forms.Label()
        Me.lblSifre = New System.Windows.Forms.Label()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKullaniciAdi
        '
        Me.lblKullaniciAdi.AutoSize = True
        Me.lblKullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKullaniciAdi.Location = New System.Drawing.Point(233, 494)
        Me.lblKullaniciAdi.Name = "lblKullaniciAdi"
        Me.lblKullaniciAdi.Size = New System.Drawing.Size(126, 20)
        Me.lblKullaniciAdi.TabIndex = 0
        Me.lblKullaniciAdi.Text = "Kullanıcı Adı :"
        '
        'lblSifre
        '
        Me.lblSifre.AutoSize = True
        Me.lblSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSifre.Location = New System.Drawing.Point(290, 548)
        Me.lblSifre.Name = "lblSifre"
        Me.lblSifre.Size = New System.Drawing.Size(61, 20)
        Me.lblSifre.TabIndex = 1
        Me.lblSifre.Text = "Şifre :"
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(372, 495)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(187, 22)
        Me.txtKullaniciAdi.TabIndex = 4
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(372, 546)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(187, 22)
        Me.txtSifre.TabIndex = 5
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGiris.Location = New System.Drawing.Point(333, 617)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(129, 56)
        Me.btnGiris.TabIndex = 8
        Me.btnGiris.Text = "GİRİŞ"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblRol.Location = New System.Drawing.Point(313, 396)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(149, 20)
        Me.lblRol.TabIndex = 9
        Me.lblRol.Text = "Kullanıcı Seçiniz"
        '
        'cmbRol
        '
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(318, 429)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(144, 24)
        Me.cmbRol.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(135, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CAN BUNLAR ANAOKULU"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(821, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'LoginPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 794)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRol)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.lblSifre)
        Me.Controls.Add(Me.lblKullaniciAdi)
        Me.Name = "LoginPanel"
        Me.Text = "LOGİN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKullaniciAdi As Label
    Friend WithEvents lblSifre As Label
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents btnGiris As Button
    Friend WithEvents lblRol As Label
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
