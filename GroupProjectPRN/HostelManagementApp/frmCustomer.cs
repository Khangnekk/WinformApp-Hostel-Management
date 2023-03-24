using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmCustomer : Form
    {
        public readonly HostelContext context = new();
        bool checkout = true;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Lessor lessor = context.Lessors.FirstOrDefault(l => l.Username == AccountManager.Instance.Username);
            var hostel = context.Hostels.Where(h => h.LessorId == lessor.LessorId).Select(h => h.HostelName).ToList();
            cbHostel.DataSource = hostel;
            cbType.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _ = checkout ? (dateTimePicker2.Enabled = true) : (dateTimePicker2.Enabled = false);

            checkout = !checkout;
        }

        private void cbHostel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hostelID = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            var Room = context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue));
            lbRoomNum.Text = Room.RoomNumber.ToString();
            lbType.Text = Room.RoomType.ToString();
            lbPrice.Text = Room.RoomPrice.ToString();
            _ = (Room.Status == true) ? lbStatus.Text = "Rented" : lbStatus.Text = "empty";
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = (string)cbType.SelectedItem;
            int hostelID = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            cbRoom.DataSource = context.Rooms.Where(r => r.HostelId == hostelID && r.RoomType == type).Select(r => r.RoomNumber).ToList();
        }
    }
}
