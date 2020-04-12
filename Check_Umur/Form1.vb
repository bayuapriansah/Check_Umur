Public Class Form1
    Public bulan, bulanHitung, DatPic1Bulan, DatPic2Bulan, tahun, DatPic1Tahun, DatPic2Tahun As Integer
    Sub getNilaiSemua()
        DatPic1Bulan = DateTimePicker1.Value.Month
        DatPic1Tahun = DateTimePicker1.Value.Year
        DatPic2Bulan = DateTimePicker2.Value.Month
        DatPic2Tahun = DateTimePicker2.Value.Year
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        getNilaiSemua()
        If DatPic2Tahun < DatPic1Tahun Then
            MsgBox("Tahun Di Tanggal Pembanding Tidak Boleh Lebih Kecil Dari Tahun Lahir")
            Label1.Text = "Ada Kesalahan Input"
        Else
            If DatPic1Bulan > DatPic2Bulan And DatPic1Tahun < DatPic2Tahun Then
                tahun = (DatPic2Tahun - DatPic1Tahun) - 1
                bulanHitung = DatPic2Bulan - DatPic1Bulan
                bulan = 12 + bulanHitung
            ElseIf DatPic1Bulan > DatPic2Bulan And DatPic1Tahun = DatPic2Tahun Then
                MsgBox("Kamu Belum Lahir")
            Else
                tahun = DatPic2Tahun - DatPic1Tahun
                bulan = DatPic2Bulan - DatPic1Bulan
            End If
            Label1.Text = "Umur Kamu " & tahun & " Tahun " & bulan & " Bulan"
        End If
    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged
        getNilaiSemua()
        If DatPic2Tahun < DatPic1Tahun Then
            MsgBox("Tahun Di Tanggal Pembanding Tidak Boleh Lebih Kecil Dari Tahun Lahir")
            Label1.Text = "Ada Kesalahan Input"
        Else
            If DatPic1Bulan > DatPic2Bulan And DatPic1Tahun < DatPic2Tahun Then
                tahun = (DatPic2Tahun - DatPic1Tahun) - 1
                bulanHitung = DatPic2Bulan - DatPic1Bulan
                bulan = 12 + bulanHitung
            ElseIf DatPic1Bulan > DatPic2Bulan And DatPic1Tahun = DatPic2Tahun Then
                MsgBox("Kamu Belum Lahir")
            Else
                tahun = DatPic2Tahun - DatPic1Tahun
                bulan = DatPic2Bulan - DatPic1Bulan
            End If
            Label1.Text = "Umur Kamu " & tahun & " Tahun " & bulan & " Bulan"
        End If
    End Sub
End Class
