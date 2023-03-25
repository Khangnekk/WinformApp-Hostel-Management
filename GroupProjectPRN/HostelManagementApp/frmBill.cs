using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmBill : Form
    {
        public readonly HostelContext context = new();
        public frmBill()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtServiceID_TextChanged(object sender, EventArgs e)
        {
        }

        private void Room_Click(object sender, EventArgs e)
        {

        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            Lessor lessor = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);
            var hostel = context.Hostels.Where(h => h.LessorId == lessor.LessorId).Select(h => h.HostelName).ToList();
            cbHostel.DataSource = hostel;
        }

        private void cbHostel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hostelID = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            cbRoom.DataSource = context.Rooms.Where(r => r.HostelId == hostelID).Select(r => r.RoomNumber).ToList();
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Room = context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue));
            dataGridView1.DataSource = context.Bills.Where(b => b.RoomId == Room.RoomId).ToList();
            dataGridView2.DataSource = context.Customers.Where(c => c.RoomId == Room.RoomId).ToList();
        }
    }
}
