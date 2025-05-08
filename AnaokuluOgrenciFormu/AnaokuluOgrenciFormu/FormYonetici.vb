Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FormYonetici
    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"

    Private Sub FormYonetici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OgrencileriGetir()
        SiniflariYukle()
        VelileriYukle()

        cmbCinsiyet.Items.Clear()
        cmbCinsiyet.Items.Add("E") ' Erkek
        cmbCinsiyet.Items.Add("K") ' Kız
    End Sub

    Private Sub OgrencileriGetir()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim adaptor As New OleDbDataAdapter("SELECT * FROM Ogrenci", baglanti)
        Dim tablo As New DataTable()
        adaptor.Fill(tablo)
        dgvOgrenciler.DataSource = tablo
    End Sub

    Private Sub SiniflariYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("SELECT * FROM Sinif", baglanti)
        Dim tablo As New DataTable()
        baglanti.Open()
        tablo.Load(komut.ExecuteReader())
        baglanti.Close()

        cmbSinif.DataSource = tablo
        cmbSinif.DisplayMember = "Sinif_Adi"
        cmbSinif.ValueMember = "Sinif_ID"
    End Sub

    Private Sub VelileriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("SELECT * FROM Veli", baglanti)
        Dim tablo As New DataTable()
        baglanti.Open()
        tablo.Load(komut.ExecuteReader())
        baglanti.Close()

        cmbVeli.DataSource = tablo
        cmbVeli.DisplayMember = "Veli_Ad"
        cmbVeli.ValueMember = "Veli_ID"
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("INSERT INTO Ogrenci (Ogr_Adi, Ogr_Soyad, Ogr_TC, Sinif_ID, Veli_ID, Ogr_Cinsiyet, Ogr_Yas, Ogrenci_Adresi, Ogr_DogumT, Ogr_Boy, Ogr_Kilo) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", baglanti)

        komut.Parameters.AddWithValue("?", txtAd.Text)
        komut.Parameters.AddWithValue("?", txtSoyad.Text)
        komut.Parameters.AddWithValue("?", txtTC.Text)
        komut.Parameters.AddWithValue("?", cmbSinif.SelectedValue)
        komut.Parameters.AddWithValue("?", cmbVeli.SelectedValue)
        komut.Parameters.AddWithValue("?", cmbCinsiyet.Text)
        komut.Parameters.AddWithValue("?", txtYas.Text)
        komut.Parameters.AddWithValue("?", txtAdres.Text)
        komut.Parameters.AddWithValue("?", dtpDogumTarihi.Value)
        komut.Parameters.AddWithValue("?", txtBoy.Text)
        komut.Parameters.AddWithValue("?", txtKilo.Text)

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Öğrenci başarıyla kaydedildi.")
        OgrencileriGetir()
    End Sub

    Private Sub dgvOgrenciler_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOgrenciler.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim satir = dgvOgrenciler.Rows(e.RowIndex)
            txtAd.Text = satir.Cells("Ogr_Adi").Value.ToString()
            txtSoyad.Text = satir.Cells("Ogr_Soyad").Value.ToString()
            txtTC.Text = satir.Cells("Ogr_TC").Value.ToString()
            cmbSinif.SelectedValue = satir.Cells("Sinif_ID").Value
            cmbVeli.SelectedValue = satir.Cells("Veli_ID").Value
            cmbCinsiyet.Text = satir.Cells("Ogr_Cinsiyet").ToString()
            txtYas.Text = satir.Cells("Ogr_Yas").ToString()
            txtAdres.Text = satir.Cells("Ogrenci_Adresi").ToString()
            dtpDogumTarihi.Value = Convert.ToDateTime(satir.Cells("Ogr_DogumT").Value)
            txtBoy.Text = satir.Cells("Ogr_Boy").ToString()
            txtKilo.Text = satir.Cells("Ogr_Kilo").ToString()
        End If
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If dgvOgrenciler.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen güncellenecek öğrenciyi seçin.")
            Exit Sub
        End If

        Dim ogrID As Integer = dgvOgrenciler.SelectedRows(0).Cells("Ogr_ID").Value
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("UPDATE Ogrenci SET Ogr_Adi=?, Ogr_Soyad=?, Ogr_TC=?, Sinif_ID=?, Veli_ID=?, Ogr_Cinsiyet=?, Ogr_Yas=?, Ogrenci_Adresi=?, Ogr_DogumT=?, Ogr_Boy=?, Ogr_Kilo=? WHERE Ogr_ID=?", baglanti)

        komut.Parameters.AddWithValue("?", txtAd.Text)
        komut.Parameters.AddWithValue("?", txtSoyad.Text)
        komut.Parameters.AddWithValue("?", txtTC.Text)
        komut.Parameters.AddWithValue("?", cmbSinif.SelectedValue)
        komut.Parameters.AddWithValue("?", cmbVeli.SelectedValue)
        komut.Parameters.AddWithValue("?", cmbCinsiyet.Text)
        komut.Parameters.AddWithValue("?", txtYas.Text)
        komut.Parameters.AddWithValue("?", txtAdres.Text)
        komut.Parameters.AddWithValue("?", dtpDogumTarihi.Value)
        komut.Parameters.AddWithValue("?", txtBoy.Text)
        komut.Parameters.AddWithValue("?", txtKilo.Text)
        komut.Parameters.AddWithValue("?", ogrID)

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Öğrenci bilgileri güncellendi.")
        OgrencileriGetir()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If dgvOgrenciler.SelectedRows.Count = 0 Then
            MessageBox.Show("Silinecek öğrenciyi seçin.")
            Exit Sub
        End If

        Dim ogrID As Integer = dgvOgrenciler.SelectedRows(0).Cells("Ogr_ID").Value
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("DELETE FROM Ogrenci WHERE Ogr_ID=?", baglanti)
        komut.Parameters.AddWithValue("?", ogrID)

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Öğrenci silindi.")
        OgrencileriGetir()
    End Sub




    Private Sub btnRapor_Click(sender As Object, e As EventArgs) Handles btnRapor.Click
        Dim belge As New Document(PageSize.A4.Rotate(), 30, 30, 30, 30)
        Dim yol As String = "C:\Users\omerf\OneDrive\Masaüstü\ogrenci_raporu.pdf"
        PdfWriter.GetInstance(belge, New FileStream(yol, FileMode.Create))
        belge.Open()
        ' Yazı tipleri
        Dim baslikFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 14, iTextSharp.text.Font.BOLD)
        Dim normalFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.NORMAL)

        ' Başlık
        belge.Add(New Paragraph("ANAOKULU - TÜM ÖGRENCI RAPORU", baslikFont))
        belge.Add(New Paragraph("Tarih: " & DateTime.Now.ToString(), normalFont))
        belge.Add(New Paragraph(" "))

        ' 8 sütunlu tablo (Ad, Soyad, Cinsiyet, Yaş, Adres, Doğum Tarihi, Boy, Kilo)
        Dim tablo As New PdfPTable(8)
        tablo.WidthPercentage = 100
        tablo.SetWidths({2, 2, 1, 1, 3, 2, 1, 1}) ' Genişlik oranları

        ' Başlıklar
        Dim basliklar() As String = {"Ad", "Soyad", "Cinsiyet", "Yaş", "Adres", "Doğum Tarihi", "Boy", "Kilo"}
        For Each b In basliklar
            Dim hucre As New PdfPCell(New Phrase(b, baslikFont))
            hucre.BackgroundColor = BaseColor.LIGHT_GRAY
            hucre.HorizontalAlignment = Element.ALIGN_CENTER
            tablo.AddCell(hucre)
        Next

        ' Veritabanı bağlantısı ve verileri çekme
        Dim baglanti As New OleDb.OleDbConnection(baglantiYolu)
        Dim adaptor As New OleDb.OleDbDataAdapter("SELECT Ogr_Adi, Ogr_Soyad, Ogr_Cinsiyet, Ogr_Yas, Ogrenci_Adresi, Ogr_DogumT, Ogr_Boy, Ogr_Kilo FROM Ogrenci", baglanti)
        Dim dt As New DataTable()
        adaptor.Fill(dt)

        For Each satir As DataRow In dt.Rows
            tablo.AddCell(New Phrase(satir("Ogr_Adi").ToString(), normalFont))
            tablo.AddCell(New Phrase(satir("Ogr_Soyad").ToString(), normalFont))
            tablo.AddCell(New Phrase(satir("Ogr_Cinsiyet").ToString(), normalFont))
            tablo.AddCell(New Phrase(satir("Ogr_Yas").ToString(), normalFont))
            tablo.AddCell(New Phrase(satir("Ogrenci_Adresi").ToString(), normalFont))
            tablo.AddCell(New Phrase(Convert.ToDateTime(satir("Ogr_DogumT")).ToShortDateString(), normalFont))
            tablo.AddCell(New Phrase(satir("Ogr_Boy").ToString(), normalFont))
            tablo.AddCell(New Phrase(satir("Ogr_Kilo").ToString(), normalFont))
        Next

        belge.Add(tablo)
        belge.Close()

        MessageBox.Show("PDF raporu başarıyla oluşturuldu: " & yol)
    End Sub

    Private Sub btnOdemeFormu_Click(sender As Object, e As EventArgs) Handles btnOdemeFormu.Click
        Dim form As New FormOdeme()
        form.Show()

    End Sub
End Class
