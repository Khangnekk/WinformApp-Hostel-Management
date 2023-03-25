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

        void ReLoad()
        {
            int hostelID = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            dataGridView1.DataSource = context.Rooms.Where(r => r.Status == true && r.HostelId == hostelID).Select(r => new
            {
                r.RoomId,
                r.RoomNumber,
                r.RoomType,
                r.RoomPrice
            }).ToList();
            dataGridView2.DataSource = context.Rooms.Where(r => r.Status == false && r.HostelId == hostelID).Select(r => new
            {
                r.RoomId,
                r.RoomNumber,
                r.RoomType,
                r.RoomPrice
            }).ToList();
            dataGridView3.DataSource = context.Rooms.Where(r => r.HostelId == hostelID).Select(r => new
            {
                r.RoomId,
                r.RoomNumber,
                r.RoomType,
                r.RoomPrice
            }).ToList();
        }

        private void cbHostel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoad();
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmBill frmBill = new frmBill();
            frmBill.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["roomID"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    int roomID = Convert.ToInt32(cellValue);
                    Room r = context.Rooms.FirstOrDefault(r => r.RoomId == roomID);
                    txtRoomID.Text = r.RoomId.ToString();
                    txtRoomNum.Text = r.RoomNumber.ToString();
                    txtPrice.Text = r.RoomPrice.ToString();
                    if (r.Status == true)
                    {
                        txtStatus.Text = "Rented";
                    }
                    else
                    {
                        txtStatus.Text = "Empty";
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["roomID"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    int roomID = Convert.ToInt32(cellValue);
                    Room r = context.Rooms.FirstOrDefault(r => r.RoomId == roomID);
                    txtRoomID.Text = r.RoomId.ToString();
                    txtRoomNum.Text = r.RoomNumber.ToString();
                    txtPrice.Text = r.RoomPrice.ToString();
                    if (r.Status == true)
                    {
                        txtStatus.Text = "Rented";
                    }
                    else
                    {
                        txtStatus.Text = "Empty";
                    }
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["roomID"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    int roomID = Convert.ToInt32(cellValue);
                    Room r = context.Rooms.FirstOrDefault(r => r.RoomId == roomID);
                    txtRoomID.Text = r.RoomId.ToString();
                    txtRoomNum.Text = r.RoomNumber.ToString();
                    txtPrice.Text = r.RoomPrice.ToString();
                    txtType.Text = r.RoomType.ToString();
                    if (r.Status == true)
                    {
                        txtStatus.Text = "Rented";
                    }
                    else
                    {
                        txtStatus.Text = "Empty";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            Room r = new Room();
            r.RoomNumber = Convert.ToInt32(txtRoomNum.Text);
            r.RoomPrice = Convert.ToInt32(txtPrice.Text);
            r.RoomType = txtType.Text;
            r.HostelId = context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue).HostelId;
            var Room = context.Rooms.Where(r => r.HostelId == r.HostelId);
            foreach (Room room in Room)
            {
                if (room.RoomNumber == r.RoomNumber)
                {
                    MessageBox.Show("Room Number Existed");
                }
            }
            context.Rooms.Add(r);
            MessageBox.Show("Successful");
            context.SaveChanges();
            ReLoad();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room r = context.Rooms.FirstOrDefault(r => r.RoomId == Convert.ToInt32(txtRoomID.Text));
            r.RoomPrice = Convert.ToInt32(txtPrice.Text);
            MessageBox.Show("Successful");
            context.SaveChanges();
            ReLoad();
        }
    }
}

