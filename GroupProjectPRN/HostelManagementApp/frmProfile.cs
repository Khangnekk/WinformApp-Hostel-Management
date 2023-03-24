using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmProfile : Form
    {
        public HostelContext context = new();
        public frmProfile()
        {
            InitializeComponent();
        }

        void ReLoad()
        {
            Lessor lessor = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);
            txtID.Text = lessor.LessorId.ToString();
            txtName.Text = lessor.LessorName.ToString();
            dtpDateOfBirth.Value = lessor.LessorDob;
            txtCCCD.Text = lessor.Cccd.ToString();
            _ = (lessor.LessorGender == 1) ? rdMale.Checked = true : rdFemale.Checked = true;
            txtID.Enabled = false;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lessor l = context.Lessors.FirstOrDefault(l => l.LessorId == Convert.ToInt32(txtID.Text));
            l.LessorName = txtName.Text;
            l.Username = AccountManager.Instance.Username;
            l.LessorDob = dtpDateOfBirth.Value;
            l.Cccd = txtCCCD.Text;
            _ = (rdMale.Checked) ? l.LessorGender = 1 : l.LessorGender = 2;
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoad();
        }
    }
}
