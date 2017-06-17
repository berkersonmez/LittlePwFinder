namespace LittlePwFinder
{
    partial class Form1
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.maxResultsLabel = new System.Windows.Forms.Label();
            this.maxResultsInput = new System.Windows.Forms.NumericUpDown();
            this.maxLengthInput = new System.Windows.Forms.NumericUpDown();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.buttonsGroupBox = new System.Windows.Forms.GroupBox();
            this.simulateButton = new System.Windows.Forms.Button();
            this.nextResultButton = new System.Windows.Forms.Button();
            this.findResultsButton = new System.Windows.Forms.Button();
            this.simulationGroupBox = new System.Windows.Forms.GroupBox();
            this.clickListLabel = new System.Windows.Forms.Label();
            this.clickListClearButton = new System.Windows.Forms.Button();
            this.clickPosListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickDelayLabel = new System.Windows.Forms.Label();
            this.clickDelayTextBox = new System.Windows.Forms.NumericUpDown();
            this.inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxResultsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthInput)).BeginInit();
            this.resultGroupBox.SuspendLayout();
            this.buttonsGroupBox.SuspendLayout();
            this.simulationGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickDelayTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.maxResultsLabel);
            this.inputGroupBox.Controls.Add(this.maxResultsInput);
            this.inputGroupBox.Controls.Add(this.maxLengthInput);
            this.inputGroupBox.Controls.Add(this.maxLengthLabel);
            this.inputGroupBox.Controls.Add(this.inputLabel);
            this.inputGroupBox.Controls.Add(this.inputTextbox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 28);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(321, 198);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // maxResultsLabel
            // 
            this.maxResultsLabel.AutoSize = true;
            this.maxResultsLabel.Location = new System.Drawing.Point(6, 159);
            this.maxResultsLabel.Name = "maxResultsLabel";
            this.maxResultsLabel.Size = new System.Drawing.Size(68, 13);
            this.maxResultsLabel.TabIndex = 5;
            this.maxResultsLabel.Text = "Max Results:";
            // 
            // maxResultsInput
            // 
            this.maxResultsInput.Location = new System.Drawing.Point(91, 157);
            this.maxResultsInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxResultsInput.Name = "maxResultsInput";
            this.maxResultsInput.Size = new System.Drawing.Size(224, 20);
            this.maxResultsInput.TabIndex = 4;
            this.maxResultsInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // maxLengthInput
            // 
            this.maxLengthInput.Location = new System.Drawing.Point(91, 131);
            this.maxLengthInput.Name = "maxLengthInput";
            this.maxLengthInput.Size = new System.Drawing.Size(224, 20);
            this.maxLengthInput.TabIndex = 3;
            this.maxLengthInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.Location = new System.Drawing.Point(6, 133);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(66, 13);
            this.maxLengthLabel.TabIndex = 2;
            this.maxLengthLabel.Text = "Max Length:";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(6, 16);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(259, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Please write parts which may construct the password.";
            // 
            // inputTextbox
            // 
            this.inputTextbox.AcceptsReturn = true;
            this.inputTextbox.Location = new System.Drawing.Point(6, 32);
            this.inputTextbox.Multiline = true;
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(309, 93);
            this.inputTextbox.TabIndex = 0;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.statusLabel);
            this.resultGroupBox.Controls.Add(this.resultListBox);
            this.resultGroupBox.Location = new System.Drawing.Point(339, 28);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(326, 481);
            this.resultGroupBox.TabIndex = 1;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(7, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(194, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Click \"Find Results\" to generate results.";
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(6, 32);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(314, 433);
            this.resultListBox.TabIndex = 0;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // buttonsGroupBox
            // 
            this.buttonsGroupBox.Controls.Add(this.simulateButton);
            this.buttonsGroupBox.Controls.Add(this.nextResultButton);
            this.buttonsGroupBox.Controls.Add(this.findResultsButton);
            this.buttonsGroupBox.Location = new System.Drawing.Point(12, 232);
            this.buttonsGroupBox.Name = "buttonsGroupBox";
            this.buttonsGroupBox.Size = new System.Drawing.Size(315, 118);
            this.buttonsGroupBox.TabIndex = 2;
            this.buttonsGroupBox.TabStop = false;
            this.buttonsGroupBox.Text = "Actions";
            // 
            // simulateButton
            // 
            this.simulateButton.Location = new System.Drawing.Point(6, 77);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(297, 23);
            this.simulateButton.TabIndex = 2;
            this.simulateButton.Text = "Start Click Simulation (CTRL+S)";
            this.simulateButton.UseVisualStyleBackColor = true;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // nextResultButton
            // 
            this.nextResultButton.Location = new System.Drawing.Point(6, 48);
            this.nextResultButton.Name = "nextResultButton";
            this.nextResultButton.Size = new System.Drawing.Size(297, 23);
            this.nextResultButton.TabIndex = 1;
            this.nextResultButton.Text = "Select Next and Copy (CTRL+N)";
            this.nextResultButton.UseVisualStyleBackColor = true;
            this.nextResultButton.Click += new System.EventHandler(this.nextResultButton_Click);
            // 
            // findResultsButton
            // 
            this.findResultsButton.Location = new System.Drawing.Point(6, 19);
            this.findResultsButton.Name = "findResultsButton";
            this.findResultsButton.Size = new System.Drawing.Size(297, 23);
            this.findResultsButton.TabIndex = 0;
            this.findResultsButton.Text = "Find Results";
            this.findResultsButton.UseVisualStyleBackColor = true;
            this.findResultsButton.Click += new System.EventHandler(this.findResultsButton_Click);
            // 
            // simulationGroupBox
            // 
            this.simulationGroupBox.Controls.Add(this.clickDelayTextBox);
            this.simulationGroupBox.Controls.Add(this.clickDelayLabel);
            this.simulationGroupBox.Controls.Add(this.clickListLabel);
            this.simulationGroupBox.Controls.Add(this.clickListClearButton);
            this.simulationGroupBox.Controls.Add(this.clickPosListBox);
            this.simulationGroupBox.Location = new System.Drawing.Point(12, 356);
            this.simulationGroupBox.Name = "simulationGroupBox";
            this.simulationGroupBox.Size = new System.Drawing.Size(315, 153);
            this.simulationGroupBox.TabIndex = 4;
            this.simulationGroupBox.TabStop = false;
            this.simulationGroupBox.Text = "Click Simulation";
            // 
            // clickListLabel
            // 
            this.clickListLabel.AutoSize = true;
            this.clickListLabel.Location = new System.Drawing.Point(9, 21);
            this.clickListLabel.Name = "clickListLabel";
            this.clickListLabel.Size = new System.Drawing.Size(190, 39);
            this.clickListLabel.TabIndex = 2;
            this.clickListLabel.Text = "Record mouse positions with CTRL+R \r\nto simulate clicks after every paste \r\nof th" +
    "e password.";
            // 
            // clickListClearButton
            // 
            this.clickListClearButton.Location = new System.Drawing.Point(6, 66);
            this.clickListClearButton.Name = "clickListClearButton";
            this.clickListClearButton.Size = new System.Drawing.Size(81, 23);
            this.clickListClearButton.TabIndex = 1;
            this.clickListClearButton.Text = "Clear";
            this.clickListClearButton.UseVisualStyleBackColor = true;
            this.clickListClearButton.Click += new System.EventHandler(this.clickListClearButton_Click);
            // 
            // clickPosListBox
            // 
            this.clickPosListBox.FormattingEnabled = true;
            this.clickPosListBox.Location = new System.Drawing.Point(205, 18);
            this.clickPosListBox.Name = "clickPosListBox";
            this.clickPosListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clickPosListBox.Size = new System.Drawing.Size(104, 121);
            this.clickPosListBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tipsToolStripMenuItem.Text = "How To";
            this.tipsToolStripMenuItem.Click += new System.EventHandler(this.tipsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clickDelayLabel
            // 
            this.clickDelayLabel.AutoSize = true;
            this.clickDelayLabel.Location = new System.Drawing.Point(12, 111);
            this.clickDelayLabel.Name = "clickDelayLabel";
            this.clickDelayLabel.Size = new System.Drawing.Size(85, 13);
            this.clickDelayLabel.TabIndex = 3;
            this.clickDelayLabel.Text = "Click Delay (ms):";
            // 
            // clickDelayTextBox
            // 
            this.clickDelayTextBox.Location = new System.Drawing.Point(103, 109);
            this.clickDelayTextBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.clickDelayTextBox.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.clickDelayTextBox.Name = "clickDelayTextBox";
            this.clickDelayTextBox.Size = new System.Drawing.Size(96, 20);
            this.clickDelayTextBox.TabIndex = 4;
            this.clickDelayTextBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 521);
            this.Controls.Add(this.simulationGroupBox);
            this.Controls.Add(this.buttonsGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Little Password Finder";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxResultsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthInput)).EndInit();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.buttonsGroupBox.ResumeLayout(false);
            this.simulationGroupBox.ResumeLayout(false);
            this.simulationGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickDelayTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.GroupBox buttonsGroupBox;
        private System.Windows.Forms.Button findResultsButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label maxResultsLabel;
        private System.Windows.Forms.NumericUpDown maxResultsInput;
        private System.Windows.Forms.NumericUpDown maxLengthInput;
        private System.Windows.Forms.Label maxLengthLabel;
        private System.Windows.Forms.Button nextResultButton;
        private System.Windows.Forms.GroupBox simulationGroupBox;
        private System.Windows.Forms.Label clickListLabel;
        private System.Windows.Forms.Button clickListClearButton;
        private System.Windows.Forms.ListBox clickPosListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.Label clickDelayLabel;
        private System.Windows.Forms.NumericUpDown clickDelayTextBox;
    }
}

