using System;
using System.Windows.Forms;
using Npgsql;

namespace PinjemDong
{
    public partial class homePage : Form
    {
        private int userId;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=ininiya123;Database=JunproBener";
        private byte[] imageBytes;

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
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT nama_barang, stock, ulasan, kategori, harga, gambar FROM barang";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);

                        if (!dt.Columns.Contains("ImageDisplay"))
                            dt.Columns.Add("ImageDisplay", typeof(System.Drawing.Image));

                        foreach (System.Data.DataRow row in dt.Rows)
                        {
                            if (row["gambar"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])row["gambar"];
                                using (var ms = new System.IO.MemoryStream(imgBytes))
                                {
                                    row["ImageDisplay"] = System.Drawing.Image.FromStream(ms);
                                }
                            }
                        }

                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["gambar"].Visible = false;
                        dataGridView1.Columns["ImageDisplay"].HeaderText = "Image";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private string? GetOwnerName()
        {
            string? ownerName = null;
            string query = "SELECT name FROM pengguna WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    var result = cmd.ExecuteScalar();
                    ownerName = result?.ToString() ?? string.Empty; // Use null-coalescing operator
                }
            }
            return ownerName;
        }

        // Method untuk mendapatkan email pemilik dari database
        private string? GetOwnerEmail()
        {
            string? ownerEmail = null;
            string query = "SELECT email FROM pengguna WHERE user_id = @userId";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    var result = cmd.ExecuteScalar();
                    ownerEmail = result?.ToString() ?? string.Empty; // Use null-coalescing operator
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
                // Retrieve data from input fields
                string namaBarang = NameTB.Text;
                int stock = int.Parse(stockTB.Text);
                string kategori = kategoriTB.Text;
                decimal harga = decimal.Parse(hargaTB.Text);
                string ulasan = ""; // Placeholder for reviews if needed

                if (imageBytes == null)
                {
                    MessageBox.Show("Please select an image.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Establish a connection to the database
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // SQL query to insert a new item with image into the barang table
                    string insertBarangQuery = "INSERT INTO barang (nama_barang, stock, ulasan, kategori, harga, owner_id, gambar) " +
                                               "VALUES (@namaBarang, @stock, @ulasan, @kategori, @harga, @ownerId, @gambar)";
                    using (var cmd = new NpgsqlCommand(insertBarangQuery, conn))
                    {
                        // Add parameters to the query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@ulasan", ulasan);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@ownerId", userId);
                        cmd.Parameters.AddWithValue("@gambar", imageBytes);

                        // Execute the query to insert the item
                        cmd.ExecuteNonQuery();
                    }

                    // Show a success message to the user
                    MessageBox.Show("Barang berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh the DataGridView to display the newly added item
                LoadDataGrid();
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

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image and convert it to byte array
                    string filePath = openFileDialog.FileName;
                    imageBytes = System.IO.File.ReadAllBytes(filePath);

                    // Display the selected image in pictureBox1
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }

                    MessageBox.Show("Image selected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
