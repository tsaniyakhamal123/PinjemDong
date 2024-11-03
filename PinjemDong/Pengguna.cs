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


        public void checkout()
        {

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
}