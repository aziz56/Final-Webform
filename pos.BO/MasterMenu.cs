using System;
using System.Collections.Generic;
using System.Text;

namespace pos.BO
{
    public class MasterMenu
    {
        public MasterMenu()
        {
            this.TransaksiDetailTransaksis = new List<TransaksiDetailTransaksi>();
        }

        public int id_menu { get; set; }
        public string nama_menu { get; set; }
        public int? harga_menu { get; set; }
        public string deskripsi_menu { get; set; }

        public IEnumerable<TransaksiDetailTransaksi> TransaksiDetailTransaksis { get; set; }
    }

}
