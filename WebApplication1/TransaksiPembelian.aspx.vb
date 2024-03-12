Imports pos.BLL
Imports pos.BLL.DTO

Public Class TransaksiPembelian
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnTransaction_Click(sender As Object, e As EventArgs)
        Try
            Dim _transaksiPenjualanBLL As New TransaksiPenjualanBLL
            Dim _transaksiPenjualanDto As New TransaksiPenjualanDTO
            _transaksiPenjualanDto.nama_menu = txtNamaMenu.Text
            _transaksiPenjualanDto.harga_menu = txtHargaMenu.Text
            _transaksiPenjualanDto.jumlah_pesanan = txtJumlahPembelian.Text
            _transaksiPenjualanDto.amount = txtAmount.Text
            _transaksiPenjualanDto.no_meja = txtNoMeja.Text
            _transaksiPenjualanDto.nama_pelanggan = txtNamaPelanggan.Text


            _transaksiPenjualanBLL.InsertPayment(_transaksiPenjualanDto)



            ltMessage.Text = "<span class='alert alert-success'>User Registration Success</span><br/><br/>"
        Catch ex As Exception
            ltMessage.Text = "<span class='alert alert-danger'>Error: " & ex.Message & "</span><br/><br/>"
        End Try




    End Sub
    Protected Sub btnKeLogout_Click(sender As Object, e As EventArgs)
        Session.Abandon()
        Response.Redirect("Login")
    End Sub
End Class