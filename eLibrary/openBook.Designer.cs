namespace eLibrary
{
    partial class openBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openBook));
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.titleTb = new System.Windows.Forms.Label();
            this.borrowedBtn = new System.Windows.Forms.Button();
            this.synopsisBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectLb = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bookImage
            // 
            this.bookImage.Image = ((System.Drawing.Image)(resources.GetObject("bookImage.Image")));
            this.bookImage.Location = new System.Drawing.Point(216, 89);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(162, 167);
            this.bookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookImage.TabIndex = 0;
            this.bookImage.TabStop = false;
            // 
            // titleTb
            // 
            this.titleTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTb.Location = new System.Drawing.Point(70, 37);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(454, 24);
            this.titleTb.TabIndex = 12;
            this.titleTb.Text = "Book Title";
            this.titleTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowedBtn
            // 
            this.borrowedBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.borrowedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowedBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowedBtn.Location = new System.Drawing.Point(206, 301);
            this.borrowedBtn.Name = "borrowedBtn";
            this.borrowedBtn.Size = new System.Drawing.Size(185, 40);
            this.borrowedBtn.TabIndex = 20;
            this.borrowedBtn.Text = "Borrowed";
            this.borrowedBtn.UseVisualStyleBackColor = false;
            this.borrowedBtn.Click += new System.EventHandler(this.borrowedBtn_Click);
            // 
            // synopsisBtn
            // 
            this.synopsisBtn.BackColor = System.Drawing.Color.Transparent;
            this.synopsisBtn.FlatAppearance.BorderSize = 0;
            this.synopsisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.synopsisBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synopsisBtn.Location = new System.Drawing.Point(53, 405);
            this.synopsisBtn.Name = "synopsisBtn";
            this.synopsisBtn.Size = new System.Drawing.Size(185, 40);
            this.synopsisBtn.TabIndex = 21;
            this.synopsisBtn.Text = "Synopsis";
            this.synopsisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.synopsisBtn.UseVisualStyleBackColor = false;
            this.synopsisBtn.Click += new System.EventHandler(this.synopsisBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Author Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(216, 471);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(136, 22);
            this.nameLb.TabIndex = 23;
            this.nameLb.Text = "Author Name:";
            this.nameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Year Published:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLb
            // 
            this.yearLb.AutoSize = true;
            this.yearLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLb.Location = new System.Drawing.Point(216, 526);
            this.yearLb.Name = "yearLb";
            this.yearLb.Size = new System.Drawing.Size(50, 22);
            this.yearLb.TabIndex = 25;
            this.yearLb.Text = "year";
            this.yearLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Subject:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subjectLb
            // 
            this.subjectLb.AutoSize = true;
            this.subjectLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectLb.Location = new System.Drawing.Point(216, 581);
            this.subjectLb.Name = "subjectLb";
            this.subjectLb.Size = new System.Drawing.Size(77, 22);
            this.subjectLb.TabIndex = 27;
            this.subjectLb.Text = "subject";
            this.subjectLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 49);
            this.backBtn.TabIndex = 28;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // openBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 670);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.subjectLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.synopsisBtn);
            this.Controls.Add(this.borrowedBtn);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.bookImage);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "openBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "openBook";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox bookImage;
        private Label titleTb;
        private Button borrowedBtn;
        private Button synopsisBtn;
        private Label label1;
        private Label nameLb;
        private Label label3;
        private Label yearLb;
        private Label label5;
        private Label subjectLb;
        private Button backBtn;
    }
}