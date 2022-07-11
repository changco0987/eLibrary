namespace eLibrary
{
    partial class userProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfile));
            this.profilePic = new eLibrary.OvalPictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.nameLb = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.contactLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.borrowedLb = new System.Windows.Forms.Label();
            this.donatedLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(202, 58);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(140, 140);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 29;
            this.profilePic.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(179, 270);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(189, 23);
            this.label.TabIndex = 28;
            this.label.Text = "Personal Information";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email Address:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Contact Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Borrowed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Donated:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.editProfileBtn.FlatAppearance.BorderSize = 0;
            this.editProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfileBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editProfileBtn.Location = new System.Drawing.Point(180, 212);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(185, 27);
            this.editProfileBtn.TabIndex = 36;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.UseVisualStyleBackColor = false;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // nameLb
            // 
            this.nameLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(160, 344);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(56, 19);
            this.nameLb.TabIndex = 37;
            this.nameLb.Text = "Name:";
            this.nameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLb
            // 
            this.emailLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLb.AutoSize = true;
            this.emailLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLb.Location = new System.Drawing.Point(161, 380);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(56, 19);
            this.emailLb.TabIndex = 38;
            this.emailLb.Text = "Name:";
            this.emailLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contactLb
            // 
            this.contactLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contactLb.AutoSize = true;
            this.contactLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactLb.Location = new System.Drawing.Point(161, 419);
            this.contactLb.Name = "contactLb";
            this.contactLb.Size = new System.Drawing.Size(56, 19);
            this.contactLb.TabIndex = 39;
            this.contactLb.Text = "Name:";
            this.contactLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLb
            // 
            this.addressLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addressLb.AutoSize = true;
            this.addressLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLb.Location = new System.Drawing.Point(161, 458);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(56, 19);
            this.addressLb.TabIndex = 40;
            this.addressLb.Text = "Name:";
            this.addressLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borrowedLb
            // 
            this.borrowedLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borrowedLb.AutoSize = true;
            this.borrowedLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrowedLb.Location = new System.Drawing.Point(161, 496);
            this.borrowedLb.Name = "borrowedLb";
            this.borrowedLb.Size = new System.Drawing.Size(56, 19);
            this.borrowedLb.TabIndex = 41;
            this.borrowedLb.Text = "Name:";
            this.borrowedLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // donatedLb
            // 
            this.donatedLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.donatedLb.AutoSize = true;
            this.donatedLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donatedLb.Location = new System.Drawing.Point(161, 533);
            this.donatedLb.Name = "donatedLb";
            this.donatedLb.Size = new System.Drawing.Size(56, 19);
            this.donatedLb.TabIndex = 42;
            this.donatedLb.Text = "Name:";
            this.donatedLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(-1, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 22);
            this.panel1.TabIndex = 43;
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 44;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 609);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.donatedLb);
            this.Controls.Add(this.borrowedLb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.contactLb);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userProfile";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox profilePic;
        private Label label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button editProfileBtn;
        private Label nameLb;
        private Label emailLb;
        private Label contactLb;
        private Label addressLb;
        private Label borrowedLb;
        private Label donatedLb;
        private Panel panel1;
        private Button backBtn;
    }
}