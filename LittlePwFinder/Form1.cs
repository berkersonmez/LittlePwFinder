using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittlePwFinder
{
    public partial class Form1 : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MouseEventLeftDown = 0x02;
        public const int MouseEventLeftUp = 0x04;

        const int SelectNextAndCopyHotkeyId = 1;
        const int RecordClickPosHotkeyId = 2;
        const int StartSimHotkeyId = 3;
        const int StopSimHotkeyId = 4;

        private int _selected = 0;
        private int _count = 0;
        private BindingList<ClickPosition> _clickPositions;
        private bool _simulate = false;
        private int _clickDelay = 500;

        private delegate void SetResultIndexCallback(int value);
        private void SetResultIndex(int value)
        {
            if (this.resultListBox.InvokeRequired)
            {
                SetResultIndexCallback d = new SetResultIndexCallback(SetResultIndex);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.resultListBox.SelectedIndex = value;
            }
        }

        private delegate void SetStatusTextboxCallback(string value);
        private void SetStatusTextbox(string value)
        {
            if (this.resultListBox.InvokeRequired)
            {
                SetStatusTextboxCallback d = new SetStatusTextboxCallback(SetStatusTextbox);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.statusLabel.Text = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            _clickPositions = new BindingList<ClickPosition>();
            clickPosListBox.DataSource = _clickPositions;
            
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, SelectNextAndCopyHotkeyId, 2, (int)Keys.N);
            RegisterHotKey(this.Handle, RecordClickPosHotkeyId, 2, (int)Keys.R);
            RegisterHotKey(this.Handle, StartSimHotkeyId, 2, (int)Keys.S);
            RegisterHotKey(this.Handle, StopSimHotkeyId, 2, (int)Keys.Q);
        }

        private void findResultsButton_Click(object sender, EventArgs e)
        {
            var text = inputTextbox.Text;
            var lines = text.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim(Environment.NewLine.ToCharArray());
            }
            var maxLength = int.Parse(maxLengthInput.Text);
            var maxResults = int.Parse(maxResultsInput.Text);
            var results = new List<string>();
            _count = 0;
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var result in Combine(lines, i+1))
                {
                    results.Add(result);
                    _count++;
                    if (_count >= maxResults)
                        break;
                }
                if (_count >= maxResults)
                    break;
            }
            resultListBox.DataSource = results;
            SetResultIndex(0);
            _selected = 0;
            Copy();
            FixSelectedText();
        }

        private IEnumerable<string> Combine(IList<string> input, int length)
        {
            if (length <= 0)
            {
                yield return "";
            }
            else
            {
                foreach (var str in input)
                {
                    foreach (var c in Combine(input, length-1))
                    {
                        yield return str + c;
                    }
                }
            }
        }

        private void FixSelectedText()
        {
            SetStatusTextbox("Copied result " + (_selected + 1) + " out of " + _count);
        }

        private void Copy()
        {
            Clipboard.SetText(resultListBox.Items[_selected].ToString());
        }

        private void CopyAndFixText()
        {
            SetResultIndex(_selected);
            FixSelectedText();
            Copy();
        }

        private void RecordClick()
        {
            var clickPos = new ClickPosition
            {
                X = Cursor.Position.X,
                Y = Cursor.Position.Y
            };
            _clickPositions.Add(clickPos);
        }

        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MouseEventLeftDown, xpos, ypos, 0, 0);
            mouse_event(MouseEventLeftUp, xpos, ypos, 0, 0);
        }

        private void SimulateClicks()
        {
            while (_simulate)
            {
                SendKeys.SendWait("^v");
                Thread.Sleep(_clickDelay);
                foreach (var clickPosition in _clickPositions)
                {
                    LeftMouseClick(clickPosition.X, clickPosition.Y);
                    Thread.Sleep(_clickDelay);
                }
                _selected++;
                if (_selected < _count)
                {
                    CopyAndFixText();
                    Thread.Sleep(200);
                }
                else
                {
                    break;
                }
            }
            _simulate = false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == SelectNextAndCopyHotkeyId)
            {
                _selected++;
                if (_selected < _count)
                {
                    CopyAndFixText();
                }
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == RecordClickPosHotkeyId)
            {
                RecordClick();
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == StartSimHotkeyId)
            {
                _simulate = true;
                _clickDelay = int.Parse(clickDelayTextBox.Text);
                var thread = new Thread(SimulateClicks);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == StopSimHotkeyId)
            {
                _simulate = false;
            }
            base.WndProc(ref m);
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selected = resultListBox.SelectedIndex;
            CopyAndFixText();
        }

        private void nextResultButton_Click(object sender, EventArgs e)
        {
            _selected++;
            if (_selected < _count)
            {
                CopyAndFixText();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpPopupForm();
            helpForm.Show(this);
        }

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tipsForm = new TipsPopupForm();
            tipsForm.Show(this);
        }

        private void clickListClearButton_Click(object sender, EventArgs e)
        {
            _clickPositions.Clear();
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            _simulate = true;
            _clickDelay = int.Parse(clickDelayTextBox.Text);
            var thread = new Thread(SimulateClicks);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
