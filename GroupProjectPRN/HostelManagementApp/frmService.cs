using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmService : Form
    {
        public HostelContext context = new();
        public frmService()
        {
            InitializeComponent();
        }

        void ReLoad()
        {
            dataGridView1.DataSource = context.Services.Select(s => new
            {
                s.ServiceId,
                s.ServiceName,
                s.ServicePrice
            }).ToList();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Services.Add(new Service
            {
                ServiceName = txtServiceName.Text,
                ServicePrice = Convert.ToInt32(txtPrice.Text),
            });
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoad();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["serviceID"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    int serviceID = Convert.ToInt32(cellValue);
                    Service s = context.Services.FirstOrDefault(s => s.ServiceId == serviceID);
                    txtServiceID.Text = s.ServiceId.ToString();
                    txtServiceName.Text = s.ServiceName.ToString();
                    txtPrice.Text = s.ServicePrice.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service s = context.Services.FirstOrDefault(s => s.ServiceId == Convert.ToInt32(txtServiceID.Text));
            s.ServiceName = txtServiceName.Text;
            s.ServicePrice = Convert.ToInt32(txtPrice.Text);
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service s = context.Services.FirstOrDefault(s => s.ServiceId == Convert.ToInt32(txtServiceID.Text));
            context.Remove(s);
            context.SaveChanges();
            MessageBox.Show("Successful");
            ReLoad();
        }
    }
}
