namespace eLibrary
{
    partial class donateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donateBook));
            this.label6 = new System.Windows.Forms.Label();
            this.appointment = new System.Windows.Forms.DateTimePicker();
            this.publishedTb = new System.Windows.Forms.Label();
            this.authorTb = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.agreement = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yearPub = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(118, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Date of Appointment:";
            // 
            // appointment
            // 
            this.appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appointment.Location = new System.Drawing.Point(118, 450);
            this.appointment.Name = "appointment";
            this.appointment.Size = new System.Drawing.Size(254, 23);
            this.appointment.TabIndex = 57;
            // 
            // publishedTb
            // 
            this.publishedTb.AutoSize = true;
            this.publishedTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishedTb.Location = new System.Drawing.Point(118, 364);
            this.publishedTb.Name = "publishedTb";
            this.publishedTb.Size = new System.Drawing.Size(132, 18);
            this.publishedTb.TabIndex = 56;
            this.publishedTb.Text = "Year Published:";
            // 
            // authorTb
            // 
            this.authorTb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorTb.Location = new System.Drawing.Point(118, 254);
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(516, 29);
            this.authorTb.TabIndex = 53;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.Location = new System.Drawing.Point(303, 543);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(128, 36);
            this.confirmBtn.TabIndex = 52;
            this.confirmBtn.Text = "Save";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(0, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 25);
            this.panel1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(118, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Title of Books:";
            // 
            // titleTb
            // 
            this.titleTb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTb.Location = new System.Drawing.Point(118, 191);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(516, 29);
            this.titleTb.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Donate books to library to improve moer experience";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 47;
            this.label1.Text = "Donating Books";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(181, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Answer the form and ensure the data needed is safe";
            // 
            // agreement
            // 
            this.agreement.AutoSize = true;
            this.agreement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.agreement.Location = new System.Drawing.Point(118, 498);
            this.agreement.Name = "agreement";
            this.agreement.Size = new System.Drawing.Size(509, 18);
            this.agreement.TabIndex = 60;
            this.agreement.Text = "By clicking this box I hereby acknowledge and read the Terms of Service of an app" +
    ".";
            this.agreement.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(118, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Subject:";
            // 
            // subject
            // 
            this.subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subject.FormattingEnabled = true;
            this.subject.Items.AddRange(new object[] {
            "Math",
            "Science",
            "English",
            "Filipino",
            "Physical Education",
            "TechVoc"});
            this.subject.Location = new System.Drawing.Point(118, 318);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(516, 31);
            this.subject.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(118, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Author:";
            // 
            // yearPub
            // 
            this.yearPub.Location = new System.Drawing.Point(118, 385);
            this.yearPub.Name = "yearPub";
            this.yearPub.Size = new System.Drawing.Size(516, 26);
            this.yearPub.TabIndex = 64;
            // 
            // donateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 637);
            this.Controls.Add(this.yearPub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.agreement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.appointment);
            this.Controls.Add(this.publishedTb);
            this.Controls.Add(this.authorTb);
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
            this.Name = "donateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "donateBook";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private DateTimePicker appointment;
        private Label publishedTb;
        private TextBox authorTb;
        private Button confirmBtn;
        private Panel panel1;
        private Label label5;
        private TextBox titleTb;
        private Label label3;
        private Label label1;
        private Button backBtn;
        private Label label2;
        private CheckBox agreement;
        private Label label4;
        private ComboBox subject;
        private Label label7;
        private DateTimePicker yearPub;
    }
}