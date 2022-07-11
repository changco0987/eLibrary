namespace eLibrary
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userBt = new System.Windows.Forms.Button();
            this.adminBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBt
            // 
            this.userBt.BackColor = System.Drawing.Color.PaleGreen;
            this.userBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userBt.Location = new System.Drawing.Point(172, 184);
            this.userBt.Name = "userBt";
            this.userBt.Size = new System.Drawing.Size(276, 58);
            this.userBt.TabIndex = 0;
            this.userBt.Text = "User";
            this.userBt.UseVisualStyleBackColor = false;
            this.userBt.Click += new System.EventHandler(this.userBt_Click);
            // 
            // adminBt
            // 
            this.adminBt.BackColor = System.Drawing.Color.LightCoral;
            this.adminBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminBt.Location = new System.Drawing.Point(172, 283);
            this.adminBt.Name = "adminBt";
            this.adminBt.Size = new System.Drawing.Size(276, 58);
            this.adminBt.TabIndex = 1;
            this.adminBt.Text = "Admin";
            this.adminBt.UseVisualStyleBackColor = false;
            this.adminBt.Click += new System.EventHandler(this.adminBt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(-2, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 34);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Your Account";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Salmon;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(597, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 20);
            this.closeBtn.TabIndex = 43;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 455);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminBt);
            this.Controls.Add(this.userBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button userBt;
        private Button adminBt;
        private Panel panel1;
        private Label label1;
        private Button closeBtn;
    }
}