namespace PinjemDong
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
            homeAdmin adminForm = new homeAdmin();
            adminForm.Show();
            this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}