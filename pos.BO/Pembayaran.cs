using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class Pembayaran
    {
        public Pembayaran()
        {
            this.TransaksiPenjualans = new List<TransaksiPenjualan>();
        }

        public int id_pembayaran { get; set; }
        public int? id_penjualan { get; set; }
        public string metode_pembayaran { get; set; }
        public decimal? amount { get; set; }
        public decimal? kembalian { get; set; }
        public DateTime? tanggal_pembayaran { get; set; }
        public TimeSpan? waktu_pembayaran { get; set; }
        public string keterangan { get; set; }

        public TransaksiPenjualan TransaksiPenjualan { get; set; }
        public IEnumerable<TransaksiPenjualan> TransaksiPenjualans { get; set; }
    }
}

