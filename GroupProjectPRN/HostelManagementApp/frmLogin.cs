using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmLogin : Form
    {
        HostelContext context = new();
        public frmLogin()
        {
            InitializeComponent();
        }

        private Account? getAccount()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var account = context.Accounts.FirstOrDefault(acc => acc.Username.Equals(username) && acc.Password.Equals(password));
            return account;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = getAccount();
            if (account == null)
            {
                MessageBox.Show("Account doesn't exist", "Warning");
            }
            else
            {
                AccountManager.Instance.Username = account.Username;
                frmHome frmHome = new frmHome();
                frmHome.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
        }


    }
    public class AccountManager
    {
        private static AccountManager instance = null;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        private AccountManager()
        {
            username = "";
        }

        public static AccountManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountManager();
                }
                return instance;
            }
        }
    }
}
