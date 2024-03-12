<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="TransaksiPembelian.aspx.vb" Inherits="WebApplication1.TransaksiPembelian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Transaksi</h1>
        </div>

        <div class="col-lg-12">
            <!-- Basic Card Example -->
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Transaksi Page</h6>
                </div>
                <div class="card-body">
                    <asp:Literal ID="ltMessage" runat="server" />
                    <div class="form-group">
                        <label for="txtNamaPelanggan">Nama Pelanggan :</label>
                        <asp:TextBox ID="txtNamaPelanggan" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="txtNamaMenu">Nama Menu :</label>
                        <asp:TextBox ID="txtNamaMenu" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="txtHargaMenu">Harga Menu:</label>
                        <asp:TextBox ID="txtHargaMenu" runat="server" CssClass="form-control" />

                    </div>
                    <div class="form-group">
                        <label for="txtJumlahPembelian">Jumlah Pembelian:</label>
                        <asp:TextBox ID="txtJumlahPembelian" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="txtNoMeja">No Meja:</label>
                        <asp:TextBox ID="txtNoMeja" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="txtAmount">Amount:</label>
                        <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="idpenjualan">ID Penjualan</label>
                        <asp:TextBox ID="idpenjualan" runat="server" CssClass="form-control" />
                    </div>

                    <asp:Button ID="btnTransaction" Text="Transaction" CssClass="btn btn-success btn-sm" runat="server" OnClick="btnTransaction_Click" />
                    <asp:Button ID="btnKeLogout" Text="Logout" CssClass="btn btn-success btn-sm" runat="server" OnClick="btnKeLogout_Click" />
                </div>

            </div>
</asp:Content>
