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
            txtServiceName = new TextBox();
            txtServiceID = new TextBox();
            Room = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            btnCreateBill = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(890, 554);
            dataGridView1.TabIndex = 0;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(924, 231);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(343, 27);
            txtServiceName.TabIndex = 38;
            txtServiceName.TextChanged += txtServiceName_TextChanged;
            // 
            // txtServiceID
            // 
            txtServiceID.Enabled = false;
            txtServiceID.Location = new Point(924, 91);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new Size(343, 27);
            txtServiceID.TabIndex = 39;
            txtServiceID.TextChanged += txtServiceID_TextChanged;
            // 
            // Room
            // 
            Room.AutoSize = true;
            Room.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Room.Location = new Point(924, 200);
            Room.Margin = new Padding(4, 0, 4, 0);
            Room.Name = "Room";
            Room.Size = new Size(65, 28);
            Room.TabIndex = 35;
            Room.Text = "Room";
            Room.Click += Room_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(924, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 36;
            label2.Text = "Bill ID";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(924, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 35;
            label1.Text = "Hostel";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(924, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 38;
            // 
            // btnCreateBill
            // 
            btnCreateBill.Location = new Point(924, 288);
            btnCreateBill.Name = "btnCreateBill";
            btnCreateBill.Size = new Size(343, 43);
            btnCreateBill.TabIndex = 40;
            btnCreateBill.Text = "Create Bill";
            btnCreateBill.UseVisualStyleBackColor = true;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 655);
            Controls.Add(btnCreateBill);
            Controls.Add(textBox1);
            Controls.Add(txtServiceName);
            Controls.Add(txtServiceID);
            Controls.Add(label1);
            Controls.Add(Room);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "frmBill";
            Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtServiceName;
        private TextBox txtServiceID;
        private Label Room;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button btnCreateBill;
    }
}