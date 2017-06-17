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
    public partial class TipsPopupForm : Form
    {
        public TipsPopupForm()
        {
            InitializeComponent();

            tipsTextBox.Text =
@"How to use Little Password Finder:
- Write parts of the possible password into the input textbox line by line.
- Click ""Find Results"" button.
- Method One: paste the password and press CTRL+N to switch to the next password and repeat.
- Method Two: Create click simulation to automate password trials. For method two, record where to click to return to the password entry phase after a trial. To record a mouse position, press CTRL+R. To stop the simulations, press CTRL+Q";
        }
    }
}
