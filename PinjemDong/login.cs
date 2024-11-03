using Npgsql;
using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace PinjemDong
{
    public partial class login : Form
    {
        private NpgsqlConnection? conn;  // Nullable untuk mengatasi warning CS8618
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=ininiya123;Database=JunproBener";

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Event load form login
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event untuk klik label1
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Event untuk klik label5
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            // Event untuk perubahan teks pada UsernameBox
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            // Event untuk perubahan teks pada PasswordBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Additional button click handler (if needed)
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = UsernameBox.Text;
            string inputPassword = PasswordBox.Text;

            // Call the method to login the user
            LoginUser(inputUsername, inputPassword);
        }

        private void LoginUser(string username, string password)
        {
            // Query SQL untuk mendapatkan hashed password berdasarkan username
            string query = "SELECT password, user_id FROM public.pengguna WHERE username = @username";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Pastikan password tidak null
                                string storedHashedPassword = reader["password"]?.ToString() ?? string.Empty;
                                int loggedInUserId = (int)reader["user_id"];

                                // Verifikasi password menggunakan BCrypt
                                if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                                {
                                    MessageBox.Show("Log In successful");

                                    // Kirim user_id ke form homePage
                                    homePage home = new homePage(loggedInUserId);
                                    home.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuka form sign up
            signUp signUpPage = new signUp();
            signUpPage.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Event untuk paint panel1
        }

        private void login_Load_1(object sender, EventArgs e)
        {
            // Event load tambahan untuk form login (jika diperlukan)
        }
    }
}
