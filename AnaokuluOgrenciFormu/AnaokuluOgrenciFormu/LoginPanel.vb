Imports System.Data.OleDb
Imports System.IO

Public Class LoginPanel
    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"

    Private Sub LoginPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRol.Items.Clear()
        cmbRol.Items.Add("Veli")
        cmbRol.Items.Add("Öğretmen")
        cmbRol.Items.Add("Yemekhane")
        cmbRol.Items.Add("Yönetici")

        ' GÖRSEL EKLE
        If IO.File.Exists("C:\Users\omerf\OneDrive\Masaüstü\anaokulufoti.jpg") Then
            Dim img As New PictureBox
            img.ImageLocation = "C:\Users\omerf\OneDrive\Masaüstü\anaokulufoti.jpg"
            img.SizeMode = PictureBoxSizeMode.StretchImage
            img.SetBounds(0, 0, Me.Width, 150)
            Me.Controls.Add(img)
            img.BringToFront()
        End If

    End Sub

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        Dim kullaniciAdi As String = txtKullaniciAdi.Text.Trim()
        Dim sifre As String = txtSifre.Text.Trim()
        Dim rol As String = cmbRol.SelectedItem?.ToString()

        If kullaniciAdi = "" OrElse sifre = "" OrElse rol Is Nothing Then
            MessageBox.Show("Tüm alanları doldurun.")
            Exit Sub
        End If

        ' Veli girişi
        ' Veli girişinde TC ve Ad kontrolü yap
        If rol = "Veli" Then
            Dim baglanti As New OleDbConnection(baglantiYolu)
            Dim komut As New OleDbCommand("SELECT Veli_ID FROM Veli WHERE Veli_Ad = ?  AND Veli_TC = ? ", baglanti)
            komut.Parameters.AddWithValue("?", kullaniciAdi)
            komut.Parameters.AddWithValue("?", sifre)

            baglanti.Open()
            Dim sonuc = komut.ExecuteScalar()
            baglanti.Close()

            If sonuc IsNot Nothing Then
                girisYapanVeliID = sonuc
                Dim form As New FormVeli()
                form.Show()
                Me.Hide()
            Else
                MessageBox.Show("Geçersiz veli bilgileri.")
            End If

            Exit Sub
        End If


        ' Öğretmen
        If rol = "Öğretmen" Then
            Dim form As New FormOgretmen()
            form.Show()
            Me.Hide()
        End If

        ' Yemekhane
        If rol = "Yemekhane" Then
            Dim form As New FormYemekhane()
            form.Show()
            Me.Hide()
        End If

        ' Yönetici
        If rol = "Yönetici" Then
            Dim form As New FormYonetici()
            form.Show()
            Me.Hide()
        End If
    End Sub
End Class
