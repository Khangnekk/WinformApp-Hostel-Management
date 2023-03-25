namespace HostelManagementApp
{
    partial class frmCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtPlace = new TextBox();
            txtCCCD = new TextBox();
            dateTimePickerCheckIn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            cbHostel = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cbRoom = new ComboBox();
            groupBox1 = new GroupBox();
            lbRoomID = new Label();
            lbPrice = new Label();
            lbType = new Label();
            lbStatus = new Label();
            lbRoomNum = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label14 = new Label();
            cbType = new ComboBox();
            label15 = new Label();
            txtCustomerID = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(921, 87);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(921, 147);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(921, 201);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 1;
            label3.Text = "Place of origin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(921, 265);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 1;
            label4.Text = "CCCD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(921, 326);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 1;
            label6.Text = "Check-in";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(921, 392);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 1;
            label7.Text = "Check-out";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(921, 118);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(347, 27);
            txtFullName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(921, 178);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(347, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(921, 232);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(347, 27);
            txtPlace.TabIndex = 2;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(921, 296);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(347, 27);
            txtCCCD.TabIndex = 2;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(921, 362);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(347, 27);
            dateTimePickerCheckIn.TabIndex = 3;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Enabled = false;
            dateTimePickerCheckOut.Location = new Point(921, 433);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(241, 27);
            dateTimePickerCheckOut.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(921, 543);
            button1.Name = "button1";
            button1.Size = new Size(347, 39);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(921, 588);
            button2.Name = "button2";
            button2.Size = new Size(347, 39);
            button2.TabIndex = 4;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(921, 633);
            button3.Name = "button3";
            button3.Size = new Size(347, 39);
            button3.TabIndex = 4;
            button3.Text = "Check out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1168, 429);
            button4.Name = "button4";
            button4.Size = new Size(108, 31);
            button4.TabIndex = 4;
            button4.Text = "Check-out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cbHostel
            // 
            cbHostel.FormattingEnabled = true;
            cbHostel.Location = new Point(165, 63);
            cbHostel.Name = "cbHostel";
            cbHostel.Size = new Size(325, 28);
            cbHostel.TabIndex = 54;
            cbHostel.SelectedIndexChanged += cbHostel_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 63);
            label9.Name = "label9";
            label9.Size = new Size(131, 28);
            label9.TabIndex = 53;
            label9.Text = "Select Hostel";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 107);
            label10.Name = "label10";
            label10.Size = new Size(125, 28);
            label10.TabIndex = 53;
            label10.Text = "Select Room";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(165, 107);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(325, 28);
            cbRoom.TabIndex = 54;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbRoomID);
            groupBox1.Controls.Add(lbPrice);
            groupBox1.Controls.Add(lbType);
            groupBox1.Controls.Add(lbStatus);
            groupBox1.Controls.Add(lbRoomNum);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(36, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 471);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room Information";
            // 
            // lbRoomID
            // 
            lbRoomID.AutoSize = true;
            lbRoomID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRoomID.Location = new Point(656, 53);
            lbRoomID.Name = "lbRoomID";
            lbRoomID.Size = new Size(36, 28);
            lbRoomID.TabIndex = 56;
            lbRoomID.Text = "---";
            lbRoomID.Click += label15_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(407, 102);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(36, 28);
            lbPrice.TabIndex = 56;
            lbPrice.Text = "---";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbType.Location = new Point(128, 102);
            lbType.Name = "lbType";
            lbType.Size = new Size(36, 28);
            lbType.TabIndex = 56;
            lbType.Text = "---";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatus.Location = new Point(418, 53);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(36, 28);
            lbStatus.TabIndex = 56;
            lbStatus.Text = "---";
            // 
            // lbRoomNum
            // 
            lbRoomNum.AutoSize = true;
            lbRoomNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRoomNum.Location = new Point(158, 55);
            lbRoomNum.Name = "lbRoomNum";
            lbRoomNum.Size = new Size(36, 28);
            lbRoomNum.TabIndex = 56;
            lbRoomNum.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(562, 53);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 1;
            label5.Text = "Room ID:";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 178);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(844, 358);
            dataGridView2.TabIndex = 55;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(340, 102);
            label13.Name = "label13";
            label13.Size = new Size(61, 28);
            label13.TabIndex = 1;
            label13.Text = "Price:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(340, 55);
            label12.Name = "label12";
            label12.Size = new Size(72, 28);
            label12.TabIndex = 1;
            label12.Text = "Status:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 102);
            label11.Name = "label11";
            label11.Size = new Size(116, 28);
            label11.TabIndex = 1;
            label11.Text = "Room type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 55);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 1;
            label8.Text = "Room Number:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(561, 63);
            label14.Name = "label14";
            label14.Size = new Size(115, 28);
            label14.TabIndex = 53;
            label14.Text = "Select Type";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "small", "medium", "large" });
            cbType.Location = new Point(692, 63);
            cbType.Name = "cbType";
            cbType.Size = new Size(194, 28);
            cbType.TabIndex = 54;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(921, 33);
            label15.Name = "label15";
            label15.Size = new Size(126, 28);
            label15.TabIndex = 1;
            label15.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(921, 64);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(347, 27);
            txtCustomerID.TabIndex = 2;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 709);
            Controls.Add(groupBox1);
            Controls.Add(cbType);
            Controls.Add(cbRoom);
            Controls.Add(cbHostel);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(txtCCCD);
            Controls.Add(txtPlace);
            Controls.Add(txtPhone);
            Controls.Add(txtCustomerID);
            Controls.Add(txtFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label15);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtPlace;
        private TextBox txtCCCD;
        private DateTimePicker dateTimePickerCheckIn;
        private DateTimePicker dateTimePickerCheckOut;
        private Label label8;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox cbHostel;
        private Label label9;
        private Label label10;
        private ComboBox cbRoom;
        private GroupBox groupBox1;
        private Label lbPrice;
        private Label lbType;
        private Label lbStatus;
        private Label lbRoomNum;
        private DataGridView dataGridView2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private ComboBox cbType;
        private Label lbRoomID;
        private Label label5;
        private Label label15;
        private TextBox txtCustomerID;
    }
}