namespace eLibrary
{
    partial class adminSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminSignup));
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.admissionCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.Location = new System.Drawing.Point(289, 693);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(128, 36);
            this.confirmBtn.TabIndex = 52;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(-3, 763);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 34);
            this.panel1.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(92, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Confirm Password:";
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPass.Location = new System.Drawing.Point(92, 534);
            this.confirmPass.MaxLength = 20;
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.PasswordChar = '*';
            this.confirmPass.Size = new System.Drawing.Size(516, 29);
            this.confirmPass.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(92, 444);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "Password:";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(92, 465);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(516, 29);
            this.password.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(92, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Username:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(92, 401);
            this.username.MaxLength = 20;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(516, 29);
            this.username.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(92, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Address:";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(92, 271);
            this.address.MaxLength = 40;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(516, 29);
            this.address.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(92, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Contact Number:";
            // 
            // contactNum
            // 
            this.contactNum.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNum.Location = new System.Drawing.Point(92, 206);
            this.contactNum.MaxLength = 11;
            this.contactNum.Name = "contactNum";
            this.contactNum.Size = new System.Drawing.Size(516, 29);
            this.contactNum.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sign-up";
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(5, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 33;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(92, 139);
            this.name.MaxLength = 20;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(516, 29);
            this.name.TabIndex = 31;
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Librarian",
            "Assistant Librarian",
            "Technical Librarian"});
            this.position.Location = new System.Drawing.Point(92, 336);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(516, 31);
            this.position.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Admission Code:";
            // 
            // admissionCode
            // 
            this.admissionCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admissionCode.Location = new System.Drawing.Point(92, 603);
            this.admissionCode.MaxLength = 6;
            this.admissionCode.Name = "admissionCode";
            this.admissionCode.Size = new System.Drawing.Size(516, 29);
            this.admissionCode.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(92, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Position:";
            // 
            // adminSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 796);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admissionCode);
            this.Controls.Add(this.position);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminSignup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button confirmBtn;
        private Panel panel1;
        private Label label8;
        private TextBox confirmPass;
        private Label label9;
        private TextBox password;
        private Label label10;
        private TextBox username;
        private Label label7;
        private TextBox address;
        private Label label6;
        private TextBox contactNum;
        private Label label1;
        private Button backBtn;
        private Label label2;
        private TextBox name;
        private ComboBox position;
        private Label label3;
        private TextBox admissionCode;
        private Label label4;
    }
}