namespace HostelManagementApp
{
    partial class frmRoom
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtType = new TextBox();
            txtRoomNum = new TextBox();
            txtPrice = new TextBox();
            txtRoomID = new TextBox();
            label8 = new Label();
            txtStatus = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            cbHostel = new ComboBox();
            panel1 = new Panel();
            dataGridView3 = new DataGridView();
            menuStrip1 = new MenuStrip();
            allToolStripMenuItem = new ToolStripMenuItem();
            rented = new ToolStripMenuItem();
            empty = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(836, 641);
            button3.Name = "button3";
            button3.Size = new Size(343, 39);
            button3.TabIndex = 49;
            button3.Text = "Create bill";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(836, 585);
            button2.Name = "button2";
            button2.Size = new Size(343, 39);
            button2.TabIndex = 50;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(836, 531);
            button1.Name = "button1";
            button1.Size = new Size(343, 39);
            button1.TabIndex = 51;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtType
            // 
            txtType.Enabled = false;
            txtType.Location = new Point(838, 279);
            txtType.Name = "txtType";
            txtType.Size = new Size(343, 27);
            txtType.TabIndex = 44;
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(838, 218);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.Size = new Size(343, 27);
            txtRoomNum.TabIndex = 45;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(836, 395);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(343, 27);
            txtPrice.TabIndex = 46;
            // 
            // txtRoomID
            // 
            txtRoomID.Enabled = false;
            txtRoomID.Location = new Point(835, 157);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(343, 27);
            txtRoomID.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(836, 248);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 28);
            label8.TabIndex = 39;
            label8.Text = "Room Type";
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(836, 340);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(343, 27);
            txtStatus.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(835, 187);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 40;
            label7.Text = "Room Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(833, 126);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 43;
            label6.Text = "Room ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(835, 364);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 41;
            label3.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(836, 309);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 42;
            label5.Text = "Status";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(760, 562);
            dataGridView2.TabIndex = 35;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 562);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 29);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 37;
            label4.Text = "Select Hostel";
            // 
            // cbHostel
            // 
            cbHostel.FormattingEnabled = true;
            cbHostel.Location = new Point(164, 29);
            cbHostel.Name = "cbHostel";
            cbHostel.Size = new Size(325, 28);
            cbHostel.TabIndex = 52;
            cbHostel.SelectedIndexChanged += cbHostel_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(12, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 568);
            panel1.TabIndex = 53;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(15, 31);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(760, 562);
            dataGridView3.TabIndex = 35;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { allToolStripMenuItem, rented, empty });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(780, 31);
            menuStrip1.TabIndex = 37;
            menuStrip1.Text = "menuStrip1";
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(42, 27);
            allToolStripMenuItem.Text = "All";
            allToolStripMenuItem.Click += allToolStripMenuItem_Click;
            // 
            // rented
            // 
            rented.BackColor = SystemColors.Control;
            rented.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rented.ForeColor = SystemColors.ActiveCaptionText;
            rented.Name = "rented";
            rented.Size = new Size(186, 27);
            rented.Text = "Room already rented";
            rented.Click += roomAlreadyRentedToolStripMenuItem_Click;
            // 
            // empty
            // 
            empty.BackColor = SystemColors.Control;
            empty.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            empty.ForeColor = SystemColors.ActiveCaptionText;
            empty.Name = "empty";
            empty.Size = new Size(124, 27);
            empty.Text = "Empty Room";
            empty.Click += emptyRoomToolStripMenuItem_Click;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 712);
            Controls.Add(panel1);
            Controls.Add(cbHostel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtType);
            Controls.Add(txtRoomNum);
            Controls.Add(txtPrice);
            Controls.Add(txtRoomID);
            Controls.Add(label8);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            MainMenuStrip = menuStrip1;
            Name = "frmRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRoom";
            Load += frmRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtType;
        private TextBox txtRoomNum;
        private TextBox txtPrice;
        private TextBox txtRoomID;
        private Label label8;
        private TextBox txtStatus;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox cbHostel;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rented;
        private ToolStripMenuItem empty;
        private DataGridView dataGridView3;
        private ToolStripMenuItem allToolStripMenuItem;
    }
}