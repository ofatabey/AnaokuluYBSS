Imports System.Data.OleDb

Public Class FormAktivite

    Dim baglantiYolu As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\omerf\OneDrive\Masaüstü\ANAOKULU1.accdb"

    Private Sub btnAktiviteEkle_Click(sender As Object, e As EventArgs) Handles btnAktiviteEkle.Click

        If txtAktiviteAdi.Text = "" Or rtxIcerik.Text = "" Then
            MessageBox.Show("Lütfen tüm alanları doldurunuz.")
            Exit Sub
        End If

        Try
            Using baglanti As New OleDbConnection(baglantiYolu)
                baglanti.Open()

                Dim komut As New OleDbCommand("INSERT INTO Aktivite (Aktv_Ad, Aktv_Icerik, Aktv_Tarih) VALUES (?, ?, ?)", baglanti)
                komut.Parameters.AddWithValue("?", txtAktiviteAdi.Text)
                komut.Parameters.AddWithValue("?", rtxIcerik.Text)
                komut.Parameters.AddWithValue("?", dtpTarih.Value)


                komut.ExecuteNonQuery()
                MessageBox.Show("Aktivite başarıyla eklendi.")
            End Using

            txtAktiviteAdi.Clear()
            rtxIcerik.Clear()

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try

    End Sub

    Private Sub FormAktivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
