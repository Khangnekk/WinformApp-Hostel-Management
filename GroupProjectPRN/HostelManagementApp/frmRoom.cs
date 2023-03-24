using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmRoom : Form
    {
        public readonly HostelContext context = new();
        public frmRoom()
        {
            InitializeComponent();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            Lessor lessor = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);
            var hostel = context.Hostels.Where(h => h.LessorId == lessor.LessorId).Select(h => h.HostelName).ToList();
            cbHostel.DataSource = hostel;
            dataGridView3.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //frm
        }

        private void cbHostel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hostelID = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            dataGridView1.DataSource = context.Rooms.Where(r => r.Status == true && r.HostelId == hostelID).Select(r => new
            {
                r.RoomNumber,
                r.RoomType,
                r.RoomPrice
            }).ToList();
            dataGridView2.DataSource = context.Rooms.Where(r => r.Status == false && r.HostelId == hostelID).Select(r => new
            {
                r.RoomNumber,
                r.RoomType,
                r.RoomPrice
            }).ToList();
            dataGridView3.DataSource = context.Rooms.Where(r => r.HostelId == hostelID).Select(r => new
            {
                r.RoomNumber,
                r.RoomType,
                r.RoomPrice
            }).ToList();
        }

        private void roomAlreadyRentedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            rented.BackColor = Color.MediumSlateBlue;
            empty.BackColor = Color.White;
            allToolStripMenuItem.BackColor = Color.White;
        }

        private void emptyRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            empty.BackColor = Color.MediumSlateBlue;
            rented.BackColor = Color.White;
            allToolStripMenuItem.BackColor = Color.White;
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            allToolStripMenuItem.BackColor = Color.MediumSlateBlue;
            rented.BackColor = Color.White;
            empty.BackColor = Color.White;
        }
    }
}
