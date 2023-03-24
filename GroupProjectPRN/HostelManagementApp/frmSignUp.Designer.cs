namespace HostelManagementApp
{
    partial class frmSignUp
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
            button1 = new Button();
            btnSignUp = new Button();
            txtRePass = new TextBox();
            txtPass = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(316, 354);
            button1.Name = "button1";
            button1.Size = new Size(178, 39);
            button1.TabIndex = 21;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.Location = new Point(504, 354);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(178, 39);
            btnSignUp.TabIndex = 22;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtRePass
            // 
            txtRePass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRePass.Location = new Point(316, 296);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(366, 34);
            txtRePass.TabIndex = 20;
            txtRePass.UseSystemPasswordChar = true;
            txtRePass.Enter += txtRePass_Enter;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(316, 233);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(366, 34);
            txtPass.TabIndex = 19;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(316, 169);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(366, 34);
            txtUsername.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(119, 296);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 16;
            label4.Text = "Repeat password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 236);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 169);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 18;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 57);
            label1.Name = "label1";
            label1.Size = new Size(305, 46);
            label1.TabIndex = 14;
            label1.Text = "Create an account";
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSignUp);
            Controls.Add(txtRePass);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSignUp;
        private TextBox txtRePass;
        private TextBox txtPass;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}