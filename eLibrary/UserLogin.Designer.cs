namespace eLibrary
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(7, 7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 34);
            this.panel1.TabIndex = 5;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(153, 150);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(271, 26);
            this.username.TabIndex = 6;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(153, 231);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(271, 26);
            this.password.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(153, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(227, 276);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(128, 43);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "No Account?";
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignupBtn.FlatAppearance.BorderSize = 0;
            this.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignupBtn.ForeColor = System.Drawing.Color.Red;
            this.SignupBtn.Location = new System.Drawing.Point(122, 374);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(128, 30);
            this.SignupBtn.TabIndex = 12;
            this.SignupBtn.Text = "Sign-up";
            this.SignupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignupBtn.UseVisualStyleBackColor = false;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.ForeColor = System.Drawing.Color.Red;
            this.resetBtn.Location = new System.Drawing.Point(393, 374);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(160, 30);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Reset Password";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private Label label1;
        private Panel panel1;
        private TextBox username;
        private TextBox password;
        private Label label2;
        private Label label3;
        private Button loginBtn;
        private Label label4;
        private Button SignupBtn;
        private Button resetBtn;
        private FileSystemWatcher fileSystemWatcher1;
    }
}