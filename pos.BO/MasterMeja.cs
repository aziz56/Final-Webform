using System;
using System.Collections.Generic;

namespace pos.BO
{
    public class MasterMeja
    {
        public MasterMeja()
        {
            this.TransaksiDetailReservasis = new List<TransaksiDetailReservasi>();
            this.TransaksiPenjualans = new List<TransaksiPenjualan>();
        }

        public int id_meja { get; set; }
        public int? no_meja { get; set; }
        public int? kapasitas_meja { get; set; }
        public string status_meja { get; set; }
        public IEnumerable<TransaksiDetailReservasi> TransaksiDetailReservasis { get; set; }
        public IEnumerable<TransaksiPenjualan> TransaksiPenjualans { get; set; }
    
    }

}
