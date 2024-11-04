using System;
using System.Windows.Forms;
using Npgsql;

namespace PinjemDong
{
    public class Barang
    {
        public string NamaBarang { get; set; }
        public int Stock { get; set; }
        public string Ulasan { get; set; }
        public string Kategori { get; set; }
        public decimal Harga { get; set; }
        public int OwnerId { get; set; }

        //private string connString = "Host=localhost;Port=5432;Username=postgres;Password=ininiya123;Database=JunproBener";

        //public Barang(string namaBarang, int stock, string ulasan, string kategori, decimal harga, int ownerId)
        //{
        //    NamaBarang = namaBarang;
        //    Stock = stock;
        //    Ulasan = ulasan;
        //    Kategori = kategori;
        //    Harga = harga;
        //    OwnerId = ownerId;
        //}

        // Metode untuk menambahkan barang ke dalam database
        //public bool InsertBarang(Pemilik pemilik)
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(connString))
        //        {
        //            conn.Open();

        //            // Pastikan pemilik sudah ada di database
        //            InsertOrUpdatePemilik(pemilik, conn);

        //            // Masukkan data barang ke tabel barang
        //            string query = "INSERT INTO barang (nama_barang, stock, kategori, harga, owner_id) " +
        //                           "VALUES (@nama_barang, @stock, @kategori, @harga, @owner_id)";

        //            using (var cmd = new NpgsqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@nama_barang", NamaBarang);
        //                cmd.Parameters.AddWithValue("@stock", Stock);
        //                cmd.Parameters.AddWithValue("@kategori", Kategori);
        //                cmd.Parameters.AddWithValue("@harga", Harga);
        //                cmd.Parameters.AddWithValue("@owner_id", pemilik.UserId);

        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                return rowsAffected > 0;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error inserting barang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}


        // Method to insert or update pemilik
        //private void InsertOrUpdatePemilik(Pemilik pemilik, NpgsqlConnection conn)
        //{
        //    try
        //    {
        //        // Cek apakah pemilik sudah ada di database
        //        string checkQuery = "SELECT COUNT(*) FROM pemilik WHERE user_id = @userId";
        //        using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
        //        {
        //            checkCmd.Parameters.AddWithValue("@userId", pemilik.UserId);
        //            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

        //            if (count == 0)
        //            {
        //                pemilik.InsertPemilik(conn); // Insert pemilik dengan koneksi yang sudah terbuka
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error inserting or updating pemilik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

    }

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
            // Implementasi metode login
        }

        // Metode untuk logout
        public void Logout()
        {
            // Implementasi metode logout
        }

        // Metode untuk sign up
        public virtual void SignUp()
        {

        }

        public virtual void TambahBarang() { }
        public void ViewBarang() { }
        public virtual void EditBarang() { }
        public virtual void HapusBarang() { }

    }

    public class Pemilik : Pengguna
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=ininiya123;Database=JunproBener";

        public Pemilik(int userId, string pass, string username, string name, string email) : base(userId, pass, username)
        {
            Name = name;
            Email = email;
        }

        public override void TambahBarang() 
        { 
            //metode add barang
        }
        public override void EditBarang() 
        {
            //metode update barang
        }
        public override void HapusBarang() 
        { 
            //metode delete barang
        }
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

        public override void SignUp()
        {
            throw new InvalidOperationException("Admin tidak dapat Sign Up. Gunakan username dan password yang telah diberikan.");
        }
        public override void EditBarang()
        {
            //metode update barang
        }
        public override void HapusBarang()
        {
            //metode delete barang
        }
    }

    //public class Barang
    //{
    //    public int barang_id;
    //    public string nama_barang { get; set; } = string.Empty;
    //    public double harga_barang { get; set; }
    //    public string deskripsi_barang { get; set; } = string.Empty;
    //    public string ulasan { get; set; } = string.Empty;

    //    //metode read barang
    //    public void get_details()
    //    {
    //        //
    //    }
    //}

    public class Payment
    {
        public int PaymentId { get; set; }
        public string MetodePayment { get; set; } = string.Empty;
        public double TotalPembayaran { get; set; }
        public string StatusPayment { get; set; } = string.Empty;

        // Metode pembayaran
        public void ProcessPayment()
        {
            // Implementasi proses pembayaran
        }

        public void ChoosePaymentMethod()
        {
            // Implementasi pemilihan metode pembayaran
        }
    }

    public class Sewa_Barang
    {
        private int rent_ID;
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        private int Renter_ID;
        public string AlamatPengiriman { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string StatusOrder { get; set; } = string.Empty;

        public void AddUlasan()
        {
            // Implementasi menambah ulasan
        }
    }
}
