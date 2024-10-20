using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PinjemDong
{
    public partial class homeAdmin : Form
    {
        public homeAdmin()
        {
            InitializeComponent();
        }

        private void filterbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            admin form1 = new admin(); 
            form1.Show();              
            this.Close();
        }
    }
}
