using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class TransaksiDetailTransaksi
    {
        public int id_detail_penjualan { get; set; }
        public int? id_penjualan { get; set; }
        public int? id_menu { get; set; }
        public int? jumlah_pesanan { get; set; }
        public decimal? harga_pesanan { get; set; }
        public decimal? total_penjualan { get; set; }

        public TransaksiPenjualan TransaksiPenjualan { get; set; }
        public MasterMenu MasterMenu { get; set; }
    }
}
