using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinjemDong
{
    public class Barang
    {
        public int barang_id;
        public string nama_barang { get; set; } = string.Empty;
        public double harga_barang { get; set; }
        public string deskripsi_barang { get; set; } = string.Empty;
        public string ulasan { get; set; } = string.Empty;

        //metode read barang
        public void get_details()
        {
            //
        }
    }
}
