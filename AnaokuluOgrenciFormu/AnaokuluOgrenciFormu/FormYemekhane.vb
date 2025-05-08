Imports System.Data.OleDb

Public Class FormYemekhane
    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"

    Private Sub FormYemekhane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OgunleriYukle()
        OgrencileriYukle()
        YemekListesiYukle()
    End Sub

    Private Sub OgunleriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim tablo As New DataTable()
        Dim adaptor As New OleDbDataAdapter("SELECT Yemek_ID, Yemek_Adi FROM Yemek", baglanti)
        adaptor.Fill(tablo)
        cmbOgun.DataSource = tablo
        cmbOgun.DisplayMember = "Yemek_Adi"
        cmbOgun.ValueMember = "Yemek_ID"
    End Sub

    Private Sub OgrencileriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim tablo As New DataTable()
        Dim adaptor As New OleDbDataAdapter("SELECT Ogr_ID, Ogr_Adi FROM Ogrenci", baglanti)
        adaptor.Fill(tablo)
        cmbOgrenci.DataSource = tablo
        cmbOgrenci.DisplayMember = "Ogr_Adi"
        cmbOgrenci.ValueMember = "Ogr_ID"
    End Sub

    Private Sub YemekListesiYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim tablo As New DataTable()
        Dim sorgu As String = "SELECT Ogrenci.Ogr_Adi, Yemek.Yemek_Adi, Ogrenci_Yemek.Yemek_Tarih " &
                              "FROM (Ogrenci_Yemek " &
                              "INNER JOIN Ogrenci ON Ogrenci_Yemek.Ogr_ID = Ogrenci.Ogr_ID) " &
                              "INNER JOIN Yemek ON Ogrenci_Yemek.Yemek_ID = Yemek.Yemek_ID"

        Dim adaptor As New OleDbDataAdapter(sorgu, baglanti)
        adaptor.Fill(tablo)
        dgvYemekler.DataSource = tablo
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If cmbOgrenci.SelectedValue Is Nothing OrElse cmbOgun.SelectedValue Is Nothing Then
            MessageBox.Show("Lütfen öğrenci ve öğün seçiniz.")
            Exit Sub
        End If

        Dim tarih As Date = dtpTarih.Value
        Dim ogrenciID As Integer = Convert.ToInt32(cmbOgrenci.SelectedValue)
        Dim yemekID As Integer = Convert.ToInt32(cmbOgun.SelectedValue)

        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("INSERT INTO Ogrenci_Yemek (Ogr_ID, Yemek_ID, Yemek_Tarih) VALUES (?, ?, ?)", baglanti)
        komut.Parameters.AddWithValue("?", ogrenciID)
        komut.Parameters.AddWithValue("?", yemekID)
        komut.Parameters.AddWithValue("?", tarih)

        Try
            baglanti.Open()
            komut.ExecuteNonQuery()
            MessageBox.Show("Yemek kaydı eklendi.")
            YemekListesiYukle()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            baglanti.Close()
        End Try
    End Sub

    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        YemekListesiYukle()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub
End Class
