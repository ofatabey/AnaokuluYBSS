Imports System.Data.OleDb

Public Class FormOgretmen
    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"


    Private Sub FormOgretmen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SinifListesiniGetir()



    End Sub


    Private Sub SinifListesiniGetir()
        Dim baglanti As New OleDbConnection(baglantiYolu)
        Dim tablo As New DataTable()
        Dim adaptor As New OleDbDataAdapter("SELECT * FROM Ogrenci", baglanti)

        adaptor.Fill(tablo)
        dgvSinifListesi.DataSource = tablo
    End Sub

    Private Sub btnAktiviteOlustur_Click(sender As Object, e As EventArgs) Handles btnAktiviteOlustur.Click

        ' Aktivite ekleme formu varsa onu aç
        FormAktivite.Show()


    End Sub

    Private Sub btnKatilimGirisi_Click(sender As Object, e As EventArgs) Handles btnKatilimGirisi.Click



        Dim frmKatilim As New FormKatilimEkle()
        frmKatilim.Show()




    End Sub
End Class