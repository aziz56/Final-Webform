using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class TransaksiReservasi
    {
        public TransaksiReservasi()
        {
            this.TransaksiDetailReservasis = new List<TransaksiDetailReservasi>();
        }

        public int id_reservasi { get; set; }
        public int? id_pelanggan { get; set; }
        public DateTime? tanggal_reservasi { get; set; }
        public TimeSpan? jam_reservasi { get; set; }
        public int? jumlah_orang { get; set; }
        public string keterangan { get; set; }
        public string status_reservasi { get; set; }

        public MasterPelanggan MasterPelanggan { get; set; }
        public IEnumerable<TransaksiDetailReservasi> TransaksiDetailReservasis { get; set; }
    }
}


