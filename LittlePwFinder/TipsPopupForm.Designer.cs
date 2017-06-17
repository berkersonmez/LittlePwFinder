namespace LittlePwFinder
{
    partial class TipsPopupForm
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
            this.tipsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tipsTextBox
            // 
            this.tipsTextBox.Location = new System.Drawing.Point(12, 12);
            this.tipsTextBox.Multiline = true;
            this.tipsTextBox.Name = "tipsTextBox";
            this.tipsTextBox.ReadOnly = true;
            this.tipsTextBox.Size = new System.Drawing.Size(260, 237);
            this.tipsTextBox.TabIndex = 0;
            // 
            // TipsPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tipsTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipsPopupForm";
            this.Text = "How To Use";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tipsTextBox;
    }
}