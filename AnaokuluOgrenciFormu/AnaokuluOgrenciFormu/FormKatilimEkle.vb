Imports System.Data.OleDb

Public Class FormKatilimEkle
    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"

    Private Sub FormKatilimEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OgrencileriYukle()
        AktiviteleriYukle()
    End Sub

    Private Sub OgrencileriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim adaptor As New OleDbDataAdapter("SELECT * FROM Ogrenci", baglanti)
        Dim tablo As New DataTable()
        adaptor.Fill(tablo)
        cmbOgrenci.DataSource = tablo
        cmbOgrenci.DisplayMember = "Ogr_Adi"
        cmbOgrenci.ValueMember = "Ogr_ID"
    End Sub

    Private Sub AktiviteleriYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim adaptor As New OleDbDataAdapter("SELECT * FROM Aktivite", baglanti)
        Dim tablo As New DataTable()
        adaptor.Fill(tablo)
        cmbAktivite.DataSource = tablo
        cmbAktivite.DisplayMember = "Aktv_Ad"
        cmbAktivite.ValueMember = "Aktv_ID"
    End Sub

    Private Sub btnKatilimEkle_Click(sender As Object, e As EventArgs) Handles btnKatilimEkle.Click
        Dim ogrenciID As Integer = Convert.ToInt32(cmbOgrenci.SelectedValue)
        Dim aktiviteID As Integer = Convert.ToInt32(cmbAktivite.SelectedValue)
        Dim tarih As Date = dtpKatilimTarih.Value
        Dim veliOnay As Boolean = chkVeliOnay.Checked
        Dim katildi As Boolean = chkKatildi.Checked

        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim komut As New OleDbCommand("INSERT INTO Ogrenci_Aktivite (Ogr_ID, Aktv_ID, Aktv_VeliOnay, Aktv_Katilim, Aktv_Tarih) VALUES (?, ?, ?, ?, ?)", baglanti)
        komut.Parameters.AddWithValue("?", ogrenciID)
        komut.Parameters.AddWithValue("?", aktiviteID)
        komut.Parameters.AddWithValue("?", veliOnay)
        komut.Parameters.AddWithValue("?", katildi)
        komut.Parameters.AddWithValue("?", tarih)

        Try
            baglanti.Open()
            komut.ExecuteNonQuery()
            MessageBox.Show("Katılım başarıyla eklendi.")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        Finally
            baglanti.Close()
        End Try
    End Sub
End Class
