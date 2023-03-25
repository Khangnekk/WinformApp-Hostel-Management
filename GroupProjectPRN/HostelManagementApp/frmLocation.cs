using HostelManagementApp.Models;

namespace HostelManagementApp
{
    public partial class frmLocation : Form
    {
        public readonly HostelContext context = new();
        public frmLocation()
        {
            InitializeComponent();
        }

        void Reload()
        {
            dataGridView1.DataSource = context.HostelLocations.Select(h => new
            {
                h.LocationId,
                h.LocationDetail
            }).ToList();
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["LocationId"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    int LocationID = Convert.ToInt32(cellValue);
                    HostelLocation hl = context.HostelLocations.FirstOrDefault(hl => hl.LocationId == LocationID);
                    txtLocationID.Text = hl.LocationId.ToString();
                    txtLocationDetail.Text = hl.LocationDetail.ToString();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.HostelLocations.Add(new HostelLocation
            {
                LocationDetail = txtLocationDetail.Text,
            });
            context.SaveChanges();
            MessageBox.Show("Successful");
            Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HostelLocation hl = context.HostelLocations.FirstOrDefault(hl => hl.LocationId == Convert.ToInt32(txtLocationID.Text));
            hl.LocationDetail = txtLocationDetail.Text;
            context.SaveChanges();
            MessageBox.Show("Successful");
            Reload();
        }
    }
}
