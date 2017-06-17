using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittlePwFinder
{
    public partial class HelpPopupForm : Form
    {
        public HelpPopupForm()
        {
            InitializeComponent();
            versionValueLabel.Text = "1.0";
        }

        private void createdByLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.berkersonmez.com");
        }
    }
}
