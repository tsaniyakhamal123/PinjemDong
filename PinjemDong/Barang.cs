using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinjemDong
{
    public class Barang
    {
        public string NamaBarang { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Ulasan { get; set; } = string.Empty;
        public string Kategori { get; set; } = string.Empty;
        public decimal Harga { get; set; }
        public int OwnerId { get; set; }


        private void InsertOrUpdatePemilik(Pemilik pemilik, NpgsqlConnection conn)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM pemilik WHERE user_id = @userId";
                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userId", pemilik.UserId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        pemilik.InsertPemilik(conn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting or updating pemilik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
