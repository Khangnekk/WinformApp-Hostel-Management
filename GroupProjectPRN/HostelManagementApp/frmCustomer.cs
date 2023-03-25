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
            _ = checkout ? (dateTimePickerCheckOut.Enabled = true) : (dateTimePickerCheckOut.Enabled = false);

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
            lbRoomID.Text = Room.RoomId.ToString();
            dataGridView2.DataSource = context.Customers.Where(c => c.RoomId == Room.RoomId).ToList();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = (string)cbType.SelectedItem;
            int hostelID = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            cbRoom.DataSource = context.Rooms.Where(r => r.HostelId == hostelID && r.RoomType == type).Select(r => r.RoomNumber).ToList();
        }

        void ReLoadInRoom()
        {
            dataGridView2.DataSource = context.Customers.Where(c => c.RoomId == Convert.ToInt32(lbRoomID.Text)).Select(c => new Customer
            {
                CustomerId = c.CustomerId,
                CustomerName = c.CustomerName,
                Cccd = c.Cccd,
                Phone = c.Phone,
                CheckInDate = c.CheckInDate,
                CheckoutDate = c.CheckoutDate,
                PlaceOfOrigin = c.PlaceOfOrigin,
            }).ToList();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["CustomerId"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    int CustomerId = Convert.ToInt32(cellValue);
                    Customer customer = context.Customers.FirstOrDefault(c => c.CustomerId == CustomerId);
                    txtFullName.Text = customer.CustomerName;
                    txtCCCD.Text = customer.Cccd;
                    txtPhone.Text = customer.Phone;
                    txtPlace.Text = customer.PlaceOfOrigin;
                    txtCustomerID.Text = customer.CustomerId.ToString();
                    dateTimePickerCheckIn.Value = customer.CheckInDate;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            if (dateTimePickerCheckOut.Enabled == true)
            {
                dt = dateTimePickerCheckOut.Value;
            }
            else
            {
                dt = DateTime.Now;
            }

            context.Customers.Add(new Customer
            {
                CustomerName = txtFullName.Text,
                Phone = txtPhone.Text,
                PlaceOfOrigin = txtPlace.Text,
                Cccd = txtCCCD.Text,
                RoomId = Convert.ToInt32(lbRoomID.Text),
                CheckInDate = dateTimePickerCheckIn.Value,
                CheckoutDate = dt,
            });
            Room room = context.Rooms.FirstOrDefault(r => r.RoomId == Convert.ToInt32(lbRoomID.Text));
            room.Status = true;
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoadInRoom();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            if (dateTimePickerCheckOut.Enabled == true)
            {
                dt = dateTimePickerCheckOut.Value;
            }
            else
            {
                dt = DateTime.Now;
            }

            var Customer = context.Customers.FirstOrDefault(x => x.CustomerId == Convert.ToInt32(txtCustomerID.Text));
            Customer.CustomerName = txtFullName.Text;
            Customer.Phone = txtPhone.Text;
            Customer.Cccd = txtCCCD.Text;
            Customer.CheckInDate = dateTimePickerCheckIn.Value;
            Customer.PlaceOfOrigin = txtPlace.Text;
            Customer.CheckoutDate = dt;
            Customer.RoomId = Convert.ToInt32(lbRoomID.Text);
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoadInRoom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            if (dateTimePickerCheckOut.Enabled == true)
            {
                dt = dateTimePickerCheckOut.Value;
            }
            else
            {
                dt = DateTime.Now;
            }

            var Customer = context.Customers.FirstOrDefault(x => x.CustomerId == Convert.ToInt32(txtCustomerID.Text));
            var Room = context.Rooms.Where(r => r.RoomId == Customer.RoomId).ToList();
            if (Room.Count == 0)
            {
                var r = context.Rooms.FirstOrDefault(r => r.RoomId == Customer.RoomId);
                r.Status = false;
                Customer.CheckoutDate = dt;
            }
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoadInRoom();
        }
    }
}
