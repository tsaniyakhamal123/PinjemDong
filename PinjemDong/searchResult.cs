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
    public partial class searchResult : Form
    {
        public searchResult()
        {
            InitializeComponent();
        }

        private void searchResult_Load(object sender, EventArgs e)
        {

        }

        private void pbBackBUtton_Click(object sender, EventArgs e)
        {
            homePage homeForm = new homePage();
            homeForm.Show();
            this.Close();
        }
    }
}
