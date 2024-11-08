﻿using System;
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

        public Pemilik(int userId, string pass, string username, string name, string email) : base(userId, pass, username)
        {
            Name = name;
            Email = email;
        }

        public void InsertPemilik(NpgsqlConnection conn)
        {
            string query = "INSERT INTO pemilik (user_id, name, email) VALUES (@userId, @name, @email)";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.ExecuteNonQuery();
            }
        }

        public override void TambahBarang() { /* Method to add barang */ }
        public override void EditBarang() { /* Method to update barang */ }
        public override void HapusBarang() { /* Method to delete barang */ }
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

        public void Checkout() { /* Implement checkout method */ }
    }

    public class Admin : Pengguna
    {
        public Admin(int userId, string pass, string username) : base(userId, pass, username) { }

        public override void SignUp()
        {
            throw new InvalidOperationException("Admin cannot sign up. Use the provided username and password.");
        }

        public override void EditBarang() { /* Method to update barang */ }
        public override void HapusBarang() { /* Method to delete barang */ }
    }

    //public class Payment
    //{
    //    public int PaymentId { get; set; }
    //    public string MetodePayment { get; set; } = string.Empty;
    //    public double TotalPembayaran { get; set; }
    //    public string StatusPayment { get; set; } = string.Empty;

    //    public void ProcessPayment() { /* Implement payment process */ }
    //    public void ChoosePaymentMethod() { /* Implement payment method selection */ }
    //}

    //public class Sewa_Barang
    //{
    //    public int RentId { get; set; }
    //    public DateTime RentDate { get; set; }
    //    public DateTime ReturnDate { get; set; }
    //    public int RenterId { get; set; }
    //    public string AlamatPengiriman { get; set; } = string.Empty;
    //    public string Note { get; set; } = string.Empty;
    //    public string StatusOrder { get; set; } = string.Empty;

    //    public void AddUlasan() { /* Implement add review method */ }
    //}
}
