namespace HostelManagementApp
{
    partial class frmHostel
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
            txtHostelName = new TextBox();
            txtHostelID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            txtLessor = new TextBox();
            cbLocation = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(938, 608);
            button2.Name = "button2";
            button2.Size = new Size(343, 39);
            button2.TabIndex = 57;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(938, 554);
            button4.Name = "button4";
            button4.Size = new Size(343, 39);
            button4.TabIndex = 58;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtHostelName
            // 
            txtHostelName.Location = new Point(938, 185);
            txtHostelName.Name = "txtHostelName";
            txtHostelName.Size = new Size(380, 27);
            txtHostelName.TabIndex = 54;
            // 
            // txtHostelID
            // 
            txtHostelID.Enabled = false;
            txtHostelID.Location = new Point(935, 124);
            txtHostelID.Name = "txtHostelID";
            txtHostelID.Size = new Size(380, 27);
            txtHostelID.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(936, 215);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 50;
            label8.Text = "Location";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(935, 154);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(131, 28);
            label7.TabIndex = 51;
            label7.Text = "Hostel Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(933, 93);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 52;
            label6.Text = "Hostel ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 49;
            label1.Text = "List all hostel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(58, 92);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(871, 556);
            flowLayoutPanel1.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(936, 283);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 50;
            label2.Text = "Hostel Owner";
            // 
            // txtLessor
            // 
            txtLessor.Enabled = false;
            txtLessor.Location = new Point(938, 314);
            txtLessor.Name = "txtLessor";
            txtLessor.Size = new Size(380, 27);
            txtLessor.TabIndex = 53;
            // 
            // cbLocation
            // 
            cbLocation.FormattingEnabled = true;
            cbLocation.Location = new Point(938, 252);
            cbLocation.Name = "cbLocation";
            cbLocation.Size = new Size(260, 28);
            cbLocation.TabIndex = 59;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1204, 252);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 60;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1244, 250);
            button3.Name = "button3";
            button3.Size = new Size(71, 30);
            button3.TabIndex = 60;
            button3.Text = "Reload";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // frmHostel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 695);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(cbLocation);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(txtLessor);
            Controls.Add(txtHostelName);
            Controls.Add(label2);
            Controls.Add(txtHostelID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "frmHostel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHostel";
            Load += frmHostel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button4;
        private TextBox txtHostelName;
        private TextBox txtHostelID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox txtLessor;
        private ComboBox cbLocation;
        private Button button1;
        private Button button3;
    }
}