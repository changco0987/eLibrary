namespace eLibrary
{
    partial class borrowBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrowBooks));
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.authorTb = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.publishedTb = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.yearPub = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.Location = new System.Drawing.Point(298, 530);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(128, 36);
            this.confirmBtn.TabIndex = 37;
            this.confirmBtn.Text = "Save";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(-3, 596);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 25);
            this.panel1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(110, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Title of Books:";
            // 
            // titleTb
            // 
            this.titleTb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTb.Location = new System.Drawing.Point(110, 199);
            this.titleTb.Name = "titleTb";
            this.titleTb.ReadOnly = true;
            this.titleTb.Size = new System.Drawing.Size(516, 29);
            this.titleTb.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Answer the form and ensure the set date of borrowed books is legitimate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Borrowing Books";
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 31;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // authorTb
            // 
            this.authorTb.AutoSize = true;
            this.authorTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorTb.Location = new System.Drawing.Point(110, 257);
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(68, 18);
            this.authorTb.TabIndex = 39;
            this.authorTb.Text = "Author:";
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author.Location = new System.Drawing.Point(110, 278);
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Size = new System.Drawing.Size(516, 29);
            this.author.TabIndex = 38;
            // 
            // publishedTb
            // 
            this.publishedTb.AutoSize = true;
            this.publishedTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishedTb.Location = new System.Drawing.Point(110, 342);
            this.publishedTb.Name = "publishedTb";
            this.publishedTb.Size = new System.Drawing.Size(132, 18);
            this.publishedTb.TabIndex = 41;
            this.publishedTb.Text = "Year Published:";
            // 
            // returnDate
            // 
            this.returnDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnDate.Location = new System.Drawing.Point(375, 445);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(251, 23);
            this.returnDate.TabIndex = 43;
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDate.Location = new System.Drawing.Point(110, 445);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(251, 23);
            this.startDate.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(110, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Start Date:";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDate.Location = new System.Drawing.Point(375, 424);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(86, 18);
            this.endDate.TabIndex = 46;
            this.endDate.Text = "End Date:";
            // 
            // yearPub
            // 
            this.yearPub.Enabled = false;
            this.yearPub.Location = new System.Drawing.Point(110, 363);
            this.yearPub.Name = "yearPub";
            this.yearPub.Size = new System.Drawing.Size(516, 26);
            this.yearPub.TabIndex = 47;
            // 
            // borrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 620);
            this.Controls.Add(this.yearPub);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.publishedTb);
            this.Controls.Add(this.authorTb);
            this.Controls.Add(this.author);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "borrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "borrowBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button confirmBtn;
        private Panel panel1;
        private Label label5;
        private TextBox titleTb;
        private Label label3;
        private Label label1;
        private Button backBtn;
        private Label authorTb;
        private TextBox author;
        private Label publishedTb;
        private DateTimePicker returnDate;
        private DateTimePicker startDate;
        private Label label6;
        private Label endDate;
        private DateTimePicker yearPub;
    }
}