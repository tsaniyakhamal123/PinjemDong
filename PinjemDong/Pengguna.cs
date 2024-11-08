using System;
using System.Windows.Forms;
using Npgsql;

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

        public void Login() { /* Implement login method */ }
        public void Logout() { /* Implement logout method */ }
        public virtual void SignUp() { }
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

        public Pemilik(int userId, string pass, string username, string name, string email)
            : base(userId, pass, username)
        {
            Name = name;
            Email = email;
        }

        public override void TambahBarang() { /* Implement method */ }
        public override void EditBarang() { /* Implement method */ }
        public override void HapusBarang() { /* Implement method */ }
    }

    public class Penyewa : Pengguna
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Penyewa(int userId, string pass, string username, string name, string email)
            : base(userId, pass, username)
        {
            Name = name;
            Email = email;
        }

        public void checkout() { /* Implement checkout method */ }
    }

    public class Admin : Pengguna
    {
        public Admin(int userId, string pass, string username) : base(userId, pass, username) { }

        public override void SignUp()
        {
            throw new InvalidOperationException("Admin tidak dapat Sign Up. Gunakan username dan password yang telah diberikan.");
        }

        public override void EditBarang() { /* Implement method */ }
        public override void HapusBarang() { /* Implement method */ }
    }  // <-- penutupan kelas Admin


    /*public class Sewa_Barang
    {
        private int rent_ID;
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        private int Renter_ID;
        public string AlamatPengiriman { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string StatusOrder { get; set; } = string.Empty;

        public void AddUlasan() { /* Implement review addition */

}
    

