namespace E_shift
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void customerLgnPgBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
            
        }

        private void adminLgnPgBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
