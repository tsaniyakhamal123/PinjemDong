using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace PinjemDong
{
    public class Pengguna
    {
        public int UserId { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

        public Pengguna(int userId, string pass, string username) 
        {
            UserId = userId;
            Password = pass;
            Username = username;
        }
        // Metode untuk login
        public void Login()
        {

        }

        // Metode untuk logout
        public void Logout()
        {

        }

        // Metode untuk registrasi
        public void Register()
        {

        }
    }

    public class Pemilik : Pengguna 
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Pemilik(int userId, string pass, string username, string name, string email) : base(userId, pass, username) 
        {
            Name = name;
            Email = email;
        }

        public void TambahBarang() { }
    }

    public class Penyewa : Pengguna
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Penyewa(int userId, string pass, string username, string name, string email) : base(userId, pass, username)
        {
            Name = name;
            Email = email;
        }
    }
    public class Admin : Pengguna
    {
        public Admin(int userId, string pass, string username) : base(userId, pass, username) { }
    }

    public class Barang
    {
        private int barang_id;
        public string nama_barang { get; set; } = string.Empty;
        public double harga_barang { get; set; }
        public int stock { get; set; }
        public string lokasi { get; set; } = string.Empty;
        public string ulasan { get; set; } = string.Empty;
        public string kategori { get; set; } = string.Empty;

        //metode read barang
        public void get_details()
        {
            //
        }
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public string MetodePayment { get; set; } = string.Empty;
        public double TotalPembayaran { get; set; }
        public string StatusPayment { get; set; } = string.Empty;

        public void payment()
        {

        }

        public void payment_method()
        {

        }
    }

    public class Sewa_Barang
    {
        private int rent_ID;
        public DateTime rent_date { get; set; }
        public DateTime return_date { get; set; }
        private int renter_ID;
        public string alamat_pengiriman { get; set; } = string.Empty;
        public string note { get; set; } = string.Empty;
        public string status_order { get; set; } = string.Empty;
        public void add_ulasan()
        {

        }

        public void make_order()
        {

        }
    }
}