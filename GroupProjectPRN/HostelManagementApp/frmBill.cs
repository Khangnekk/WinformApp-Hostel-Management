using HostelManagementApp.Models;
using System.Drawing.Printing;

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
            cbStatus.SelectedIndex = 0;
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


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["roomID"].Value);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    Room r = context.Rooms.FirstOrDefault(r => r.RoomId == Convert.ToInt32(cellValue));
                    Bill bill = context.Bills.FirstOrDefault(b => b.RoomId == r.RoomId);
                    txtWater.Text = bill.WaterM3.ToString();
                    txtElec.Text = bill.ElectricityKwh.ToString();
                    txtGar.Text = bill.GarbageCollection.ToString();
                    txtInternet.Text = bill.Internet.ToString();
                    txtBillID.Text = bill.BillId.ToString();
                }
            }
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            Room r = context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue));
            Bill bill = new Bill();
            bill.RoomId = r.RoomId;
            bill.CreatedBillDate = DateTime.Now.Date;
            bill.DateOfPayment = DateTime.Now.Date;
            if (cbStatus.Text == "True")
            {
                bill.BillStatus = true;
            }
            else
            {
                bill.BillStatus = false;
            }
            bill.Internet = Convert.ToInt32(txtInternet.Text);
            bill.WaterM3 = Convert.ToInt32(txtWater.Text);
            bill.ElectricityKwh = Convert.ToInt32(txtElec.Text);
            bill.GarbageCollection = Convert.ToInt32(txtGar.Text);
            context.Bills.Add(bill);
            context.SaveChanges();
            MessageBox.Show("Successful");
            Reloaddgv1();
        }

        void Reloaddgv1()
        {
            var Room = context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue));
            dataGridView1.DataSource = context.Bills.Where(b => b.RoomId == Room.RoomId).ToList();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateBill_Click_1(object sender, EventArgs e)
        {
            // Khởi tạo PrintDialog
            PrintDialog printDialog = new PrintDialog();

            // Nếu người dùng chọn OK trong hộp thoại in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Khởi tạo PrintDocument
                PrintDocument printDocument = new PrintDocument();

                // Gán máy in được chọn từ PrintDialog cho PrintDocument
                printDocument.PrinterSettings = printDialog.PrinterSettings;

                // Xử lý sự kiện PrintPage để vẽ nội dung tài liệu lên trang in
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                // Thực hiện in
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Vẽ nội dung tài liệu lên trang in
            // Tạo một font chữ
            Font font = new Font("Arial", 12);

            // Tạo một brush để vẽ văn bản
            Brush brush = Brushes.Black;

            double elecPrice = context.Services.FirstOrDefault(s => s.ServiceName == "Electricity").ServicePrice;
            double waterPrice = context.Services.FirstOrDefault(s => s.ServiceName == "Water").ServicePrice;
            double internetPrice = context.Services.FirstOrDefault(s => s.ServiceName == "internet").ServicePrice;
            double GarPrice = context.Services.FirstOrDefault(s => s.ServiceName == "Garbage collection").ServicePrice;
            double roomPrice = (context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue))).RoomPrice;
            var Room = context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue));
            Bill bill = context.Bills.FirstOrDefault(b => b.RoomId == Room.RoomId);

            double finalElec = (double)(bill.ElectricityKwh * elecPrice);
            double finalWater = (double)(bill.WaterM3 * waterPrice);
            double finalInternet = (double)(bill.Internet * internetPrice);
            double finalGar = (double)(bill.GarbageCollection * GarPrice);
            double finalRoom = Room.RoomPrice;

            double total = finalElec + finalWater + finalInternet + finalGar + finalRoom;

            List<string> list = context.Customers.Where(c => c.RoomId == Room.RoomId).Select(c => c.CustomerName).ToList();

            // Tạo một số văn bản để vẽ
            string[] lines = new string[] {
        $"Hostel: {(context.Hostels.FirstOrDefault(h => h.HostelName == cbHostel.SelectedValue)).HostelName}",
        $"Room: {(context.Rooms.FirstOrDefault(r => r.RoomNumber == Convert.ToInt32(cbRoom.SelectedValue))).RoomNumber}",
        $"",
        $"Room: {finalRoom}/month",
        $"Electricity: {finalElec} - {bill.ElectricityKwh} Kwh",
        $"Water: {finalWater} - {bill.WaterM3} M3",
        $"Garbage collection: {finalGar} - {bill.GarbageCollection}/month",
        $"Internet: {finalInternet} - {bill.Internet}/month",
        $"",
        $"Total: {total}",

         };

            string[] lines2 = new string[list.Count + 2];
            lines2[0] = "All Customer in this room";
            for (int i = 0; i < list.Count; i++)
            {
                lines2[i + 1] = $"Customer {i}: {list[i]}";
            }
            lines2[lines2.Length - 1] = "----------------------------------";
            // Tính toán kích thước của trang in
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            // Tính toán kích thước của văn bản
            SizeF textSize = e.Graphics.MeasureString(lines[0], font);
            float lineHeight = textSize.Height;

            // Tính toán khoảng cách giữa các dòng văn bản
            float lineSpacing = lineHeight * 1.5f;

            // Tính toán vị trí bắt đầu vẽ văn bản
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Vẽ từng dòng văn bản lên trang in
            foreach (string line in lines2)
            {
                // Vẽ dòng văn bản
                e.Graphics.DrawString(line, font, brush, x, y);

                // Tính toán vị trí của dòng tiếp theo
                y += lineSpacing;

                // Kiểm tra xem trang in đã đầy chưa
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    // Trang in đã đầy, yêu cầu in thêm một trang mới
                    e.HasMorePages = true;
                    return;
                }
            }

            foreach (string line in lines)
            {
                // Vẽ dòng văn bản
                e.Graphics.DrawString(line, font, brush, x, y);

                // Tính toán vị trí của dòng tiếp theo
                y += lineSpacing;

                // Kiểm tra xem trang in đã đầy chưa
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    // Trang in đã đầy, yêu cầu in thêm một trang mới
                    e.HasMorePages = true;
                    return;
                }
            }

        }
    }

}
