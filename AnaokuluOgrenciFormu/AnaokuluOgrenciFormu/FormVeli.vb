Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports AnaokuluOgrenciFormu
Public Class FormVeli
    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"

    Private Sub FormVeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KatilimlariYukle()
    End Sub



    Private Sub KatilimlariYukle()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim sorgu As String = "SELECT Ogrenci.Ogr_Adi, Aktivite.Aktv_Ad, Ogrenci_Aktivite.Aktv_VeliOnay " &
                          "FROM ((Ogrenci_Aktivite INNER JOIN Ogrenci ON Ogrenci_Aktivite.Ogr_ID = Ogrenci.Ogr_ID) " &
                          "INNER JOIN Aktivite ON Ogrenci_Aktivite.Aktv_ID = Aktivite.Aktv_ID) " &
                          "WHERE Ogrenci.Veli_ID = ?"

        Dim komut As New OleDbCommand(sorgu, baglanti)
        komut.Parameters.AddWithValue("?", girisYapanVeliID)

        Dim adaptor As New OleDbDataAdapter(komut)
        Dim tablo As New DataTable()
        adaptor.Fill(tablo)
        dgvKatilimlar.DataSource = tablo
    End Sub


    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        KatilimlariYukle()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub

    Private Sub btnRapor_Click(sender As Object, e As EventArgs) Handles btnRapor.Click

        Dim belge As New Document()
        Dim yol As String = "C:\Users\omerf\OneDrive\Masaüstü\veli_raporu.pdf"
        PdfWriter.GetInstance(belge, New FileStream(yol, FileMode.Create))

        belge.Open()
        belge.Add(New Paragraph("VELİ RAPORU"))
        belge.Add(New Paragraph("Tarih: " & DateTime.Now.ToString()))
        belge.Add(New Paragraph(" "))

        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim sorgu As String = "SELECT Ogrenci.Ogr_Adi, Aktivite.Aktv_Ad, Ogrenci_Aktivite.Aktv_VeliOnay " &
                              "FROM ((Ogrenci_Aktivite INNER JOIN Ogrenci ON Ogrenci_Aktivite.Ogr_ID = Ogrenci.Ogr_ID) " &
                              "INNER JOIN Aktivite ON Ogrenci_Aktivite.Aktv_ID = Aktivite.Aktv_ID) " &
                              "WHERE Ogrenci.Veli_ID = ?"
        Dim komut As New OleDbCommand(sorgu, baglanti)
        komut.Parameters.AddWithValue("?", girisYapanVeliID)

        Dim adaptor As New OleDbDataAdapter(komut)
        Dim tablo As New DataTable()
        adaptor.Fill(tablo)

        For Each satir As DataRow In tablo.Rows
            belge.Add(New Paragraph("Ad: " & satir("Ogr_Adi").ToString() &
                                    " | Aktivite: " & satir("Aktv_Ad").ToString() &
                                    " | Onay: " & satir("Aktv_VeliOnay").ToString()))
        Next

        belge.Close()
        MessageBox.Show("PDF raporu oluşturuldu.")
    End Sub

End Class
