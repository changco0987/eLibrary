namespace eLibrary
{
    partial class synopsisPage
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.synopsisLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.backBtn.Location = new System.Drawing.Point(624, 471);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 28);
            this.backBtn.TabIndex = 22;
            this.backBtn.Text = "Confirm";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Synopsis";
            // 
            // synopsisLb
            // 
            this.synopsisLb.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synopsisLb.Location = new System.Drawing.Point(12, 87);
            this.synopsisLb.Name = "synopsisLb";
            this.synopsisLb.Size = new System.Drawing.Size(707, 381);
            this.synopsisLb.TabIndex = 24;
            this.synopsisLb.Text = "Synopsis";
            this.synopsisLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // synopsisPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(731, 511);
            this.Controls.Add(this.synopsisLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "synopsisPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "synopsisPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private Label label1;
        private Label synopsisLb;
    }
}