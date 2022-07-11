namespace eLibrary
{
    partial class Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            this.changeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeBtn.Location = new System.Drawing.Point(242, 364);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(128, 43);
            this.changeBtn.TabIndex = 17;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(168, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(168, 234);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(271, 26);
            this.password.TabIndex = 14;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(168, 160);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(271, 26);
            this.username.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reset Password";
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(9, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 11;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(-6, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 34);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(168, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Password";
            // 
            // newPassword
            // 
            this.newPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassword.Location = new System.Drawing.Point(168, 302);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(271, 26);
            this.newPassword.TabIndex = 19;
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button changeBtn;
        private Label label3;
        private Label label2;
        private TextBox password;
        private TextBox username;
        private Label label1;
        private Button backBtn;
        private Panel panel1;
        private Label label4;
        private TextBox newPassword;
    }
}