namespace LittlePwFinder
{
    partial class HelpPopupForm
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
            this.createdByLabel = new System.Windows.Forms.Label();
            this.createdByLinkLabel = new System.Windows.Forms.LinkLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Location = new System.Drawing.Point(88, 50);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(62, 13);
            this.createdByLabel.TabIndex = 0;
            this.createdByLabel.Text = "Created By:";
            // 
            // createdByLinkLabel
            // 
            this.createdByLinkLabel.AutoSize = true;
            this.createdByLinkLabel.Location = new System.Drawing.Point(156, 50);
            this.createdByLinkLabel.Name = "createdByLinkLabel";
            this.createdByLinkLabel.Size = new System.Drawing.Size(79, 13);
            this.createdByLinkLabel.TabIndex = 1;
            this.createdByLinkLabel.TabStop = true;
            this.createdByLinkLabel.Text = "Berker Sönmez";
            this.createdByLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createdByLinkLabel_LinkClicked);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLabel.Location = new System.Drawing.Point(17, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(283, 31);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Little Password Finder";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(105, 76);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version:";
            // 
            // versionValueLabel
            // 
            this.versionValueLabel.AutoSize = true;
            this.versionValueLabel.Location = new System.Drawing.Point(156, 76);
            this.versionValueLabel.Name = "versionValueLabel";
            this.versionValueLabel.Size = new System.Drawing.Size(22, 13);
            this.versionValueLabel.TabIndex = 4;
            this.versionValueLabel.Text = "1.0";
            // 
            // HelpPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 105);
            this.Controls.Add(this.versionValueLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createdByLinkLabel);
            this.Controls.Add(this.createdByLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpPopupForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.LinkLabel createdByLinkLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label versionValueLabel;
    }
}