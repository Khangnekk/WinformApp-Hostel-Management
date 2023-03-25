namespace HostelManagementApp
{
    partial class frmLocation
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
            button2 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            txtLocationDetail = new TextBox();
            txtLocationID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(584, 345);
            button2.Name = "button2";
            button2.Size = new Size(374, 39);
            button2.TabIndex = 60;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(584, 300);
            button4.Name = "button4";
            button4.Size = new Size(374, 39);
            button4.TabIndex = 61;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(529, 328);
            dataGridView1.TabIndex = 62;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtLocationDetail
            // 
            txtLocationDetail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocationDetail.Location = new Point(584, 182);
            txtLocationDetail.Name = "txtLocationDetail";
            txtLocationDetail.Size = new Size(374, 31);
            txtLocationDetail.TabIndex = 66;
            // 
            // txtLocationID
            // 
            txtLocationID.Enabled = false;
            txtLocationID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocationID.Location = new Point(584, 108);
            txtLocationID.Name = "txtLocationID";
            txtLocationID.Size = new Size(374, 31);
            txtLocationID.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(584, 153);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 63;
            label3.Text = "Location Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(584, 77);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 64;
            label2.Text = "Location ID";
            // 
            // frmLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 409);
            Controls.Add(txtLocationDetail);
            Controls.Add(txtLocationID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button4);
            MaximizeBox = false;
            Name = "frmLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLocation";
            Load += frmLocation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox txtLocationDetail;
        private TextBox txtLocationID;
        private Label label3;
        private Label label2;
    }
}