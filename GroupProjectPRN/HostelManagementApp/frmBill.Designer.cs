namespace HostelManagementApp
{
    partial class frmBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtBillID = new TextBox();
            label2 = new Label();
            btnCreateBill = new Button();
            cbRoom = new ComboBox();
            cbHostel = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            txtElec = new TextBox();
            txtGar = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddData = new Button();
            txtWater = new TextBox();
            txtInternet = new TextBox();
            label1 = new Label();
            cbStatus = new ComboBox();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(976, 285);
            dataGridView1.TabIndex = 0;
            // 
            // txtBillID
            // 
            txtBillID.Enabled = false;
            txtBillID.Location = new Point(1025, 471);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(343, 27);
            txtBillID.TabIndex = 39;
            txtBillID.TextChanged += txtServiceID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1025, 440);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 36;
            label2.Text = "Bill ID";
            label2.Click += label2_Click;
            // 
            // btnCreateBill
            // 
            btnCreateBill.Location = new Point(1025, 608);
            btnCreateBill.Name = "btnCreateBill";
            btnCreateBill.Size = new Size(343, 43);
            btnCreateBill.TabIndex = 40;
            btnCreateBill.Text = "Create Bill";
            btnCreateBill.UseVisualStyleBackColor = true;
            btnCreateBill.Click += btnCreateBill_Click_1;
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(370, 58);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(325, 28);
            cbRoom.TabIndex = 57;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // cbHostel
            // 
            cbHostel.FormattingEnabled = true;
            cbHostel.Location = new Point(12, 57);
            cbHostel.Name = "cbHostel";
            cbHostel.Size = new Size(325, 28);
            cbHostel.TabIndex = 58;
            cbHostel.SelectedIndexChanged += cbHostel_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(370, 16);
            label10.Name = "label10";
            label10.Size = new Size(125, 28);
            label10.TabIndex = 55;
            label10.Text = "Select Room";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 16);
            label9.Name = "label9";
            label9.Size = new Size(131, 28);
            label9.TabIndex = 56;
            label9.Text = "Select Hostel";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 399);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(976, 253);
            dataGridView2.TabIndex = 59;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtElec);
            groupBox1.Controls.Add(txtGar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAddData);
            groupBox1.Controls.Add(txtWater);
            groupBox1.Controls.Add(txtInternet);
            groupBox1.Location = new Point(1014, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 332);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            // 
            // txtElec
            // 
            txtElec.Location = new Point(5, 239);
            txtElec.Name = "txtElec";
            txtElec.Size = new Size(343, 27);
            txtElec.TabIndex = 38;
            txtElec.TextChanged += txtServiceName_TextChanged;
            // 
            // txtGar
            // 
            txtGar.Location = new Point(6, 163);
            txtGar.Name = "txtGar";
            txtGar.Size = new Size(343, 27);
            txtGar.TabIndex = 38;
            txtGar.TextChanged += txtServiceName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(5, 208);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 35;
            label6.Text = "Electricity";
            label6.Click += Room_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 36;
            label3.Text = "Water";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 35;
            label4.Text = "Garbage collection";
            label4.Click += Room_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 35;
            label5.Text = "Internet";
            // 
            // btnAddData
            // 
            btnAddData.Location = new Point(5, 283);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(343, 43);
            btnAddData.TabIndex = 40;
            btnAddData.Text = "Add Data";
            btnAddData.UseVisualStyleBackColor = true;
            btnAddData.Click += btnAddData_Click;
            // 
            // txtWater
            // 
            txtWater.Location = new Point(6, 40);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(343, 27);
            txtWater.TabIndex = 39;
            txtWater.TextChanged += txtServiceID_TextChanged;
            // 
            // txtInternet
            // 
            txtInternet.Location = new Point(6, 101);
            txtInternet.Name = "txtInternet";
            txtInternet.Size = new Size(343, 27);
            txtInternet.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1025, 501);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 36;
            label1.Text = "Bill Status";
            label1.Click += label2_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "True", "False" });
            cbStatus.Location = new Point(1025, 532);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 61;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 711);
            Controls.Add(cbStatus);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(cbRoom);
            Controls.Add(cbHostel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnCreateBill);
            Controls.Add(txtBillID);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBill";
            Load += frmBill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBillID;
        private Label label2;
        private Button btnCreateBill;
        private ComboBox cbRoom;
        private ComboBox cbHostel;
        private Label label10;
        private Label label9;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private TextBox txtElec;
        private TextBox txtGar;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtWater;
        private TextBox txtInternet;
        private Button btnAddData;
        private Label label1;
        private ComboBox cbStatus;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}