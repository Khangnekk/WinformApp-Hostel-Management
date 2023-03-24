using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmSignUp : Form
    {
        public readonly HostelContext context = new();
        public frmSignUp()
        {
            InitializeComponent();
        }
        private Account? getAccount()
        {
            string username = txtUsername.Text;
            var account = context.Accounts.FirstOrDefault(acc => acc.Username.Equals(username));
            return account;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp();

        }

        private void SignUp()
        {
            if (txtUsername.Text.Trim() == "" || txtPass.Text.Trim() == "" || txtRePass.Text.Trim() == "")
            {
                MessageBox.Show("Please input information");
            }
            else
            {
                var account = getAccount();
                if (account != null)
                {
                    MessageBox.Show("Account existed");
                }
                else
                {
                    if (txtPass.Text != txtRePass.Text)
                    {
                        MessageBox.Show("Password and repeat password do not match");
                    }
                    else
                    {
                        Account acc = new Account();
                        acc.Username = txtUsername.Text;
                        acc.Password = txtPass.Text;
                        context.Accounts.Add(acc);
                        context.SaveChanges();
                        MessageBox.Show("Successful");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
        }

        private void txtRePass_Enter(object sender, EventArgs e)
        {
            //SignUp();
        }
    }
}
