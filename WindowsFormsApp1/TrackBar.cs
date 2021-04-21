using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Interop;
using static Interop.ComCtl32;

namespace WindowsFormsApp1
{
    public partial class TrackBars : Form
    {
        public TrackBars()
        {
            InitializeComponent();
            thumbLengthNumericUpDown.Value = trackBar1.ThumbLength;
        }

        private void showThumbCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.ShowThumb = showThumbCheckBox.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tickStyleComboBox.SelectedIndex)
            {
                case 0:
                    trackBar1.TickStyle = TickStyle.BottomRight;
                    break;
                case 1:
                    trackBar1.TickStyle = TickStyle.TopLeft;
                    break;
                case 2:
                    trackBar1.TickStyle = TickStyle.Both;
                    break;
                case 3:
                    trackBar1.TickStyle = TickStyle.None;
                    break;
            }
        }

        private void tickFrequencyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.TickFrequency = (int)tickFrequencyNumericUpDown.Value;
        }

        private void minimumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Minimum = (int)minimumNumericUpDown.Value;
            ReloadLabels();
        }

        private void valueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)valueNumericUpDown.Value;
            ReloadLabels();
        }

        private void maximumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Maximum = (int)maximumNumericUpDown.Value;
            ReloadLabels();
        }

        private void ReloadLabels()
        {
            minimumNumericUpDown.Value = trackBar1.Minimum;
            valueNumericUpDown.Value = trackBar1.Value;
            maximumNumericUpDown.Value = trackBar1.Maximum;
            selectionStartNumericUpDown.Value = trackBar1.SelectionStart;
            selectionEndNumericUpDown.Value = trackBar1.SelectionEnd;
        }

        private void largeChangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.LargeChange = (int)largeChangeNumericUpDown.Value;
        }

        private void smallChangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.SmallChange = (int)smallChangeNumericUpDown.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ConnectThumb();
            ReloadLabels();
        }

        private void showSelectionRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.ShowSelectionRange = showSelectionRangeCheckBox.Checked;
            ConnectThumb();
        }

        private void selectionStartNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.SelectionStart = (int)selectionStartNumericUpDown.Value;
            ReloadLabels();
        }

        private void selectionEndNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.SelectionEnd = (int)selectionEndNumericUpDown.Value;
            if (connectThumbToEndCheckBox.Checked)
            {
                trackBar1.Value = trackBar1.SelectionEnd;
            }
            ReloadLabels();
        }

        private void connectThumbToEndCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConnectThumb();
        }

        private void ConnectThumb()
        {
            if (connectThumbToEndCheckBox.Checked)
            {
                trackBar1.SelectionEnd = trackBar1.Value;
                trackBar1.Invalidate();
            }
        }

        private class SubTrackBar : TrackBar, IHandle
        {
            private bool _fixedLength;
            private bool _showThumb = true;
            private bool _showSelectionRange;
            private int _selectionStart = 0;
            private int _selectionEnd = 0;
            private int _thumbLength = -1;

            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;

                    if (_thumbLength != -1)
                    {
                        cp.Style |= (int)TBS.FIXEDLENGTH;
                    }
                    if (ShowSelectionRange)
                    {
                        cp.Style |= (int)TBS.ENABLESELRANGE;
                    }
                    if (!ShowThumb)
                    {
                        cp.Style |= (int)TBS.NOTHUMB;
                    }

                    return cp;
                }
            }

            protected override void OnHandleCreated(EventArgs e)
            {
                base.OnHandleCreated(e);

                SetSelectedRange(_selectionStart, _selectionEnd);

                if (_thumbLength != -1)
                {
                    User32.SendMessageW(this, (User32.WindowMessage)TBM.SETTHUMBLENGTH, (IntPtr)_thumbLength);
                }
            }

            public bool ShowThumb
            {
                get => _showThumb;
                set
                {
                    if (_showThumb == value)
                    {
                        return;
                    }

                    _showThumb = value;
                    UpdateStyles();
                }
            }

            public bool ShowSelectionRange
            {
                get => _showSelectionRange;
                set
                {
                    if (_showSelectionRange == value)
                    {
                        return;
                    }

                    _showSelectionRange = value;
                    UpdateStyles();
                }
            }

            public int SelectionStart
            {
                get => _selectionStart;
                set
                {
                    if (value < Minimum || value > Maximum)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, string.Format(SR.InvalidBoundArgument, nameof(SelectionStart), value, $"'{nameof(Minimum)}'", $"'${nameof(Maximum)}'"));
                    }

                    if (_selectionStart == value)
                    {
                        return;
                    }

                    if (_selectionEnd < value)
                    {
                        _selectionEnd = value;
                    }
                    _selectionStart = value;
                    if (!ShowSelectionRange)
                    {
                        ShowSelectionRange = true;
                    }

                    SetSelectedRange(value, _selectionEnd);
                }
            }

            public int SelectionEnd
            {
                get => _selectionEnd;
                set
                {
                    if (value < Minimum || value > Maximum)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, string.Format(SR.InvalidBoundArgument, nameof(SelectionEnd), value, $"'{nameof(Minimum)}'", $"'${nameof(Maximum)}'"));
                    }

                    if (_selectionEnd == value)
                    {
                        return;
                    }

                    _selectionEnd = value;
                    if (_selectionStart > value)
                    {
                        _selectionStart = value;
                    }
                    if (!ShowSelectionRange)
                    {
                        ShowSelectionRange = true;
                    }

                    SetSelectedRange(_selectionStart, value);
                }
            }

            public int ThumbLength
            {
                get
                {
                    int length = _thumbLength;
                    if (length != -1)
                    {
                        return length;
                    }

                    if (!IsHandleCreated)
                    {
                        return 13;
                    }

                    IntPtr result = User32.SendMessageW(this, (User32.WindowMessage)TBM.GETTHUMBLENGTH);
                    return PARAM.ToInt(result);
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value));
                    }

                    if (_thumbLength == value)
                    {
                        return;
                    }

                    _thumbLength = value;
                    if (IsHandleCreated)
                    {
                        User32.SendMessageW(this, (User32.WindowMessage)TBM.SETTHUMBLENGTH, (IntPtr)_thumbLength);
                    }
                }
            }

            private void SetSelectedRange(int selectionStart, int selectionEnd)
            {
                if (!IsHandleCreated)
                {
                    return;
                }

                selectionStart = ReflectValue(selectionStart);
                selectionEnd = ReflectValue(selectionEnd);
                if (selectionStart > selectionEnd)
                {
                    int temp = selectionEnd;
                    selectionEnd = selectionStart;
                    selectionStart = temp;
                }

                User32.SendMessageW(this, (User32.WindowMessage)TBM.SETSELSTART, PARAM.FromBool(false), (IntPtr)selectionStart);
                User32.SendMessageW(this, (User32.WindowMessage)TBM.SETSELEND, PARAM.FromBool(true), (IntPtr)selectionEnd);
            }

            private int ReflectValue(int value)
            {
                if (Orientation == Orientation.Vertical || (RightToLeft == RightToLeft.Yes && !IsMirrored))
                {
                    return Minimum + Maximum - value;
                }

                return value;
            }
        }

        private void orientationCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (orientationCheckBox.SelectedIndex)
            {
                case 0:
                    trackBar1.Orientation = Orientation.Horizontal;
                    break;
                case 1:
                    trackBar1.Orientation = Orientation.Vertical;
                    break;
            }

            ReloadLabels();
        }

        private void rightToLeftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rightToLeftComboBox.SelectedIndex)
            {
                case 0:
                    trackBar1.RightToLeft = RightToLeft.No;
                    break;
                case 1:
                    trackBar1.RightToLeft = RightToLeft.Yes;
                    break;
                case 2:
                    trackBar1.RightToLeft = RightToLeft.Inherit;
                    break;
            }

            ReloadLabels();
        }

        private void rightToLeftLayoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.RightToLeftLayout = rightToLeftLayoutCheckBox.Checked;
            ReloadLabels();
        }

        private void thumbLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.ThumbLength = (int)thumbLengthNumericUpDown.Value;
        }
    }
}
