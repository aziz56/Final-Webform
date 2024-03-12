using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class TransaksiDetailReservasi
    {
        public int id_detail_reservasi { get; set; }
        public int? id_reservasi { get; set; }
        public int? id_meja { get; set; }

        public TransaksiReservasi TransaksiReservasi { get; set; }
        public MasterMeja MasterMeja { get; set; }
    }
}
