Public Class FormByValByRef

    Private Sub tombolJalankan_Click(sender As Object, e As EventArgs) Handles tombolJalankan.Click
        Dim intNilai As Integer = 100

        listKeluaran.Items.Add("Di dalam tombolJalankan_Click, nilai dari " &
        "intNilai adalah " & intNilai.ToString())

        listKeluaran.Items.Add("Sekarang, saya memanggil UbahArg.")
        UbahArg(intNilai)
        listKeluaran.Items.Add("Sekarang, kembali ke dalam tombolJalankan_Click, " &
        "nilai dari intNilai adalah " & intNilai.ToString())
    End Sub

    Sub UbahArg(ByRef intArg As Integer)
        'Menampilkan nilai dari intArg
        listKeluaran.Items.Add(" ")
        listKeluaran.Items.Add("Di dalam prosedur UbahArg, " & "intArg adalah " & intArg.ToString())
        listKeluaran.Items.Add("Saya akan mengubah nilai dari intArg.")

        'menugaskan 0 kepada intArg
        intArg = 0

        'Menampilkan nilai dari intArg
        listKeluaran.Items.Add("intArg sekarang adalah " & intArg.ToString())
        listKeluaran.Items.Add(" ")
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class
