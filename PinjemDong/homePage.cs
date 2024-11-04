using System;
using System.Windows.Forms;
using Npgsql;

namespace PinjemDong
{
    public partial class homePage : Form
    {
        private int userId;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=ininiya123;Database=JunproBener";

        // Constructor dengan parameter userId
        public homePage(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Check if the user is already in Pemilik table, if not, insert them
            InsertPemilik();
            LoadDataGrid(); // Load existing barang into DataGridView
        }

        // Constructor default tanpa parameter, yang dihasilkan oleh WinForms Designer
        public homePage()
        {
            InitializeComponent();
        }

        // Method untuk load data barang ke DataGridView
        private void LoadDataGrid()
        {
            // Implementasi untuk memuat data barang dari database ke DataGridView
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM barang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; // Mengisi DataGridView dengan data barang
                }
            }
        }

        // Insert Pemilik jika belum ada
        private void InsertPemilik()
        {
            try
            {
                string checkPemilikQuery = "INSERT INTO pemilik (owner_id) " +
                                           "SELECT @userId " +
                                           "WHERE NOT EXISTS (SELECT 1 FROM pemilik WHERE owner_id = @userId)";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(checkPemilikQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting or updating pemilik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method untuk mendapatkan nama pemilik dari database
        private string GetOwnerName()
        {
            string ownerName = string.Empty;
            string query = "SELECT name FROM pengguna WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        ownerName = result.ToString();
                    }
                }
            }
            return ownerName;
        }

        // Method untuk mendapatkan email pemilik dari database
        private string GetOwnerEmail()
        {
            string ownerEmail = string.Empty;
            string query = "SELECT email FROM pengguna WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        ownerEmail = result.ToString();
                    }
                }
            }
            return ownerEmail;
        }

        // Event handler untuk DataError di DataGridView
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Terjadi kesalahan pada data grid: " + e.Exception.Message);
        }

        // Event handler untuk tombol tambah barang
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari TextBox
                string namaBarang = NameTB.Text;
                int stock = int.Parse(stockTB.Text);
                string kategori = kategoriTB.Text;
                decimal harga = decimal.Parse(hargaTB.Text);
                string ulasan = ""; // Tambahkan ulasan jika diperlukan

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Query untuk menambahkan barang
                    string insertBarangQuery = "INSERT INTO barang (nama_barang, stock, ulasan, kategori, harga, owner_id) " +
                                               "VALUES (@namaBarang, @stock, @ulasan, @kategori, @harga, @ownerId)";
                    using (var cmd = new NpgsqlCommand(insertBarangQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@ulasan", ulasan);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@ownerId", userId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Barang berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid(); // Muat ulang DataGridView untuk menampilkan data terbaru
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Format input tidak valid: " + fe.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            // Logika untuk load halaman homePage
        }

        private void stockTB_TextChanged(object sender, EventArgs e)
        {
            // Logika untuk event ini, atau biarkan kosong jika tidak dibutuhkan
        }

        private void hargaTB_TextChanged(object sender, EventArgs e)
        {
            // Logika untuk perubahan teks harga
        }

        private void kategoriTB_TextChanged(object sender, EventArgs e)
        {
            // Logika untuk perubahan teks kategori
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logika untuk perubahan teks pada textBox1
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }
    }
}
