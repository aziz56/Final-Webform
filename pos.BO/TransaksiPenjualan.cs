using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class TransaksiPenjualan
    {
        public TransaksiPenjualan()
        {
            this.Pembayarans = new List<Pembayaran>();
            this.TransaksiDetailTransaksis = new List<TransaksiDetailTransaksi>();
        }

        public int id_penjualan { get; set; }
        public string nama_menu { get; set; }
        public decimal  harga_menu { get; set; }
        public int jumlah_pesanan { get; set; }
        public string nama_pelanggan { get; set; }
        public decimal amount { get; set; }
        public decimal kembalian { get; set; }
        public decimal total_penjualan { get; set; }
        public int no_meja { get; set; }

        public DateTime? tanggal_penjualan { get; set; }
        public TimeSpan? waktu_penjualan { get; set; }
        public int? id_pelanggaan { get; set; }
        public int? id_meja { get; set; }
        public string status_penjualan { get; set; }
        public string Username { get; set; }
        public int? id_pembayaran { get; set; }

        public MasterPelanggan MasterPelanggan { get; set; }
        public MasterMeja MasterMeja { get; set; }
        public User User { get; set; }
        public Pembayaran Pembayaran { get; set; }
        public IEnumerable<Pembayaran> Pembayarans { get; set; }
        public IEnumerable<TransaksiDetailTransaksi> TransaksiDetailTransaksis { get; set; }
    }

}
