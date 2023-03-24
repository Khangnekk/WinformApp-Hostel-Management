namespace HostelManagementApp
{
    partial class frmProfile
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
            groupBox1 = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            button1 = new Button();
            txtName = new TextBox();
            label1 = new Label();
            txtCCCD = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(187, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 590);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Information";
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(298, 422);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 7;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(141, 422);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 7;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(567, 512);
            button1.Name = "button1";
            button1.Size = new Size(170, 47);
            button1.TabIndex = 6;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(24, 165);
            txtName.Name = "txtName";
            txtName.Size = new Size(713, 34);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(32, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(24, 351);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(713, 34);
            txtCCCD.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 132);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 0;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 223);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 0;
            label3.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 320);
            label4.Name = "label4";
            label4.Size = new Size(341, 28);
            label4.TabIndex = 0;
            label4.Text = "CCCD (citizen identification number)";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(24, 68);
            txtID.Name = "txtID";
            txtID.Size = new Size(713, 34);
            txtID.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 417);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 0;
            label5.Text = "Gender";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(24, 271);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(266, 27);
            dtpDateOfBirth.TabIndex = 8;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 660);
            Controls.Add(groupBox1);
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProfile";
            Load += frmProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtName;
        private Label label1;
        private TextBox txtCCCD;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private Label label5;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private DateTimePicker dtpDateOfBirth;
    }
}