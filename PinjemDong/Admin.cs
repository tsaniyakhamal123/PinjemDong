using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinjemDong
{
    public class Pengguna
    {
        public int User_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

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

    public class Admin
    {
        private int AdminID { get; set; }
        private string AdminName { get; set; } = string.Empty;
        private string AdminUsername { get; set; } = string.Empty;
        private string AdminPassword { get; set; } = string.Empty;
        public void Login() { }
        public void Logout() { }
        public void Register() { }
        public void EditBarang() { }
    }

    public class Penyewa
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

        // Metode Login
        public void Login()
        {

        }

        // Metode Logout
        public void Logout()
        {

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