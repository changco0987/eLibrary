namespace eLibrary
{
    partial class editUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editUserProfile));
            this.backBtn = new System.Windows.Forms.Button();
            this.profilePic = new eLibrary.OvalPictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.contactNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 46;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(231, 87);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(140, 140);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 45;
            this.profilePic.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(233, 624);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 36);
            this.saveBtn.TabIndex = 48;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(0, 676);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 24);
            this.panel1.TabIndex = 47;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.Transparent;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uploadBtn.Location = new System.Drawing.Point(214, 245);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(172, 36);
            this.uploadBtn.TabIndex = 49;
            this.uploadBtn.Text = "Change Image";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(50, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Address:";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(50, 546);
            this.address.MaxLength = 50;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(516, 29);
            this.address.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(50, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Email Address:";
            // 
            // emailAdd
            // 
            this.emailAdd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAdd.Location = new System.Drawing.Point(50, 411);
            this.emailAdd.MaxLength = 30;
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(516, 29);
            this.emailAdd.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(50, 348);
            this.nameTb.MaxLength = 20;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(516, 29);
            this.nameTb.TabIndex = 50;
            // 
            // contactNum
            // 
            this.contactNum.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNum.Location = new System.Drawing.Point(50, 475);
            this.contactNum.MaxLength = 11;
            this.contactNum.Name = "contactNum";
            this.contactNum.Size = new System.Drawing.Size(516, 29);
            this.contactNum.TabIndex = 60;
            // 
            // editUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 699);
            this.Controls.Add(this.contactNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.profilePic);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editUserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private OvalPictureBox profilePic;
        private Button saveBtn;
        private Panel panel1;
        private Button uploadBtn;
        private Label label7;
        private TextBox address;
        private Label label6;
        private Label label5;
        private TextBox emailAdd;
        private Label label2;
        private TextBox nameTb;
        private TextBox contactNum;
    }
}