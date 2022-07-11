namespace eLibrary
{
    partial class message
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.messageLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.Location = new System.Drawing.Point(214, 475);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmBtn.Size = new System.Drawing.Size(108, 44);
            this.confirmBtn.TabIndex = 40;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(167, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(215, 24);
            this.label30.TabIndex = 41;
            this.label30.Text = "Mail of Confirmation";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageLb
            // 
            this.messageLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messageLb.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLb.Location = new System.Drawing.Point(12, 106);
            this.messageLb.Name = "messageLb";
            this.messageLb.Size = new System.Drawing.Size(532, 311);
            this.messageLb.TabIndex = 42;
            this.messageLb.Text = "Mail of Confirmation";
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 555);
            this.Controls.Add(this.messageLb);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.confirmBtn);
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button confirmBtn;
        private Label label30;
        private Label messageLb;
    }
}