using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmHostel : Form
    {
        public readonly HostelContext context = new();
        public frmHostel()
        {
            InitializeComponent();
        }

        public void ReLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            var location = context.HostelLocations.Select(l => l.LocationDetail).ToList();
            cbLocation.DataSource = location;
            Lessor lessor = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);
            var hostel = context.Hostels.Where(h => h.LessorId == lessor.LessorId).ToList();
            foreach (var h in hostel)
            {
                Button button1 = new Button();
                button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
                button1.ForeColor = Color.MediumSlateBlue;
                button1.Image = Properties.Resources.circle_dynamic_gradient;
                button1.Name = h.HostelId.ToString();
                button1.Size = new Size(256, 110);
                button1.Text = h.HostelName;
                button1.TextImageRelation = TextImageRelation.ImageAboveText;
                button1.Click += click;
                flowLayoutPanel1.Controls.Add(button1);
            }
            flowLayoutPanel1.AutoScroll = true;
        }

        private void frmHostel_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void click(object sender, EventArgs e)
        {
            Lessor lessor = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);
            int hostelID = Convert.ToInt32(((Button)sender).Name);
            var hostel = context.Hostels.FirstOrDefault(h => h.HostelId == hostelID);
            txtHostelID.Text = hostel.HostelId.ToString();
            txtHostelName.Text = hostel.HostelName;
            var location = context.HostelLocations.Select(l => l.LocationDetail).ToList();
            cbLocation.DataSource = location;
            //string location = context.HostelLocations.FirstOrDefault(hl => hl.LocationId == hostel.LocationId).LocationDetail;
            cbLocation.SelectedItem = context.HostelLocations.FirstOrDefault(hl => hl.LocationId == hostel.LocationId).LocationDetail;
            txtLessor.Text = lessor.LessorName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLocation frmLocation = new frmLocation();
            frmLocation.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HostelLocation hl = context.HostelLocations.FirstOrDefault(hl => hl.LocationDetail == cbLocation.SelectedValue);
            Lessor l = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);

            context.Hostels.Add(new Hostel
            {
                HostelName = txtHostelName.Text,
                LocationId = hl.LocationId,
                LessorId = l.LessorId
            });
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hostel = context.Hostels.FirstOrDefault(h => h.HostelId == Convert.ToInt32(txtHostelID.Text));
            hostel.HostelName = txtHostelName.Text;
            hostel.LocationId = context.HostelLocations.FirstOrDefault(hl => hl.LocationDetail == cbLocation.SelectedValue).LocationId;
            //context.Hostels.Update(hostel);
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoad();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
