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

namespace PinjemDong
{
    public partial class dashboardPemilik : Form
    {
        public dashboardPemilik()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connString = "Host=localhost;Username=postgres;Password=nasywa;Database=PinjemDong";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public void dashboardPemilik_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
        }

        private void filterbtn_Click(object sender, EventArgs e)
        {

        }

        private void productData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = productData.Rows[e.RowIndex];
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                productData.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                productData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                UpdateBarang pageUpdate = new UpdateBarang();
                pageUpdate.Show();
                conn.Open();
                sql = @"select * from st_update(:_id, :_nama_produk, :_gambar_cover, :_gambar_1, :_gambar_2, :_harga_sewa, :_deskripsi_produk)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_nama_produk"].Value.ToString()+"?", "Hapus data terkonfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"select * from st_delete(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btn_load.PerformClick();
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
