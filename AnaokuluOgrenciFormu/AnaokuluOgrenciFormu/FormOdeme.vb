Imports System.Data.OleDb

Public Class FormOdeme

    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü.accdb"

    Private Sub FormOdeme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OgrencileriYukle()
        OdemeleriYukle()
    End Sub

    ' Öğrenci ComboBox'ına ad soyad verisi yüklenir
    Private Sub OgrencileriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim tablo As New DataTable()
        Dim komut As New OleDbCommand("SELECT Ogr_ID, Ogr_Adi & ' ' & Ogr_Soyad AS TamAd FROM Ogrenci", baglanti)

        baglanti.Open()
        tablo.Load(komut.ExecuteReader())
        baglanti.Close()

        cmbOgrenci.DataSource = tablo
        cmbOgrenci.DisplayMember = "TamAd"
        cmbOgrenci.ValueMember = "Ogr_ID"
    End Sub

    ' DataGridView'e ödeme kayıtlarını yükle
    Private Sub OdemeleriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim tablo As New DataTable()
        Dim komut As New OleDbDataAdapter("SELECT Odm_ID, Ogr_ID, Odm_Tarih, Odm_Tur, Odm_ToplamMiktar, Odm_Miktar FROM Odeme", baglanti)
        komut.Fill(tablo)
        dgvOdeme.DataSource = tablo
    End Sub

    ' Yeni ödeme ekle
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If cmbOgrenci.SelectedValue Is Nothing OrElse txtTur.Text = "" OrElse txtMiktar.Text = "" OrElse txtToplam.Text = "" Then
            MessageBox.Show("Lütfen tüm alanları doldurun.")
            Return
        End If

        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("INSERT INTO Odeme (Ogr_ID, Odm_Tarih, Odm_Tur, Odm_Miktar, Odm_ToplamMiktar) 
                                       VALUES (?, ?, ?, ?, ?)", baglanti)

        komut.Parameters.AddWithValue("?", cmbOgrenci.SelectedValue)
        komut.Parameters.AddWithValue("?", dtpTarih.Value)
        komut.Parameters.AddWithValue("?", txtTur.Text)
        komut.Parameters.AddWithValue("?", Convert.ToDecimal(txtMiktar.Text))
        komut.Parameters.AddWithValue("?", Convert.ToDecimal(txtToplam.Text))

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Ödeme kaydedildi.")
        OdemeleriYukle()
    End Sub

    ' Seçili ödemeyi sil
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If dgvOdeme.SelectedRows.Count = 0 Then
            MessageBox.Show("Silmek için satır seçin.")
            Return
        End If

        Dim secilenID As Integer = dgvOdeme.SelectedRows(0).Cells("Odm_ID").Value

        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("DELETE FROM Odeme WHERE Odm_ID = ?", baglanti)
        komut.Parameters.AddWithValue("?", secilenID)

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Kayıt silindi.")
        OdemeleriYukle()
    End Sub
End Class
