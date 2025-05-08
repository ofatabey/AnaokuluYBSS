<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAktivite
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
        Me.txtAktiviteAdi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtxIcerik = New System.Windows.Forms.RichTextBox()
        Me.lblTarih = New System.Windows.Forms.Label()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.btnAktiviteEkle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aktivite Adı : "
        '
        'txtAktiviteAdi
        '
        Me.txtAktiviteAdi.Location = New System.Drawing.Point(224, 83)
        Me.txtAktiviteAdi.Name = "txtAktiviteAdi"
        Me.txtAktiviteAdi.Size = New System.Drawing.Size(245, 22)
        Me.txtAktiviteAdi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AÇIKLAMA : "
        '
        'rtxIcerik
        '
        Me.rtxIcerik.BackColor = System.Drawing.Color.AntiqueWhite
        Me.rtxIcerik.Location = New System.Drawing.Point(76, 164)
        Me.rtxIcerik.Name = "rtxIcerik"
        Me.rtxIcerik.Size = New System.Drawing.Size(490, 147)
        Me.rtxIcerik.TabIndex = 3
        Me.rtxIcerik.Text = ""
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTarih.Location = New System.Drawing.Point(184, 339)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(65, 16)
        Me.lblTarih.TabIndex = 4
        Me.lblTarih.Text = "TARİH : "
        '
        'dtpTarih
        '
        Me.dtpTarih.Location = New System.Drawing.Point(269, 333)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(200, 22)
        Me.dtpTarih.TabIndex = 5
        '
        'btnAktiviteEkle
        '
        Me.btnAktiviteEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAktiviteEkle.Location = New System.Drawing.Point(246, 406)
        Me.btnAktiviteEkle.Name = "btnAktiviteEkle"
        Me.btnAktiviteEkle.Size = New System.Drawing.Size(171, 63)
        Me.btnAktiviteEkle.TabIndex = 6
        Me.btnAktiviteEkle.Text = "AKTİVİTE EKLE"
        Me.btnAktiviteEkle.UseVisualStyleBackColor = True
        '
        'FormAktivite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(667, 511)
        Me.Controls.Add(Me.btnAktiviteEkle)
        Me.Controls.Add(Me.dtpTarih)
        Me.Controls.Add(Me.lblTarih)
        Me.Controls.Add(Me.rtxIcerik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAktiviteAdi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAktivite"
        Me.Text = "FormAktivite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAktiviteAdi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rtxIcerik As RichTextBox
    Friend WithEvents lblTarih As Label
    Friend WithEvents dtpTarih As DateTimePicker
    Friend WithEvents btnAktiviteEkle As Button
End Class
