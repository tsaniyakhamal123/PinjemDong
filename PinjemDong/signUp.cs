using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Microsoft.VisualBasic.Logging;

namespace PinjemDong
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=postgres-junpro.cpm48umoy5cj.ap-southeast-2.rds.amazonaws.com;Port=5432;Username=postgres;Password=PinjemDong!;Database=pinjemdong";


        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void signButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string email = emailBox.Text;
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            // Check if any fields are empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the password before storing it
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            

            // SQL insert query
            string query = "INSERT INTO pengguna (name, email, username, password) VALUES (@name, @Email, @username, @password)";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Adding parameters to the command
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Notify user of successful sign-up
                        MessageBox.Show("Sign Up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally clear the input fields
                        NameBox.Clear();
                        emailBox.Clear();
                        usernameBox.Clear();
                        passwordBox.Clear();

                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            login loginForm = new login();
            loginForm.Show();
            this.Hide();  // Sembunyikan form sign up sebelum membuka form login


        }


    }
}
