namespace HostelManagementApp
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHostel frmHostel = new frmHostel();
            frmHostel.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            closeAllForm();
        }
        public void closeAllForm()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                formsToClose.Add(form);
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRoom frmRoom = new frmRoom();
            frmRoom.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmService frmService = new frmService();
            frmService.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.ShowDialog();
        }
    }
}
