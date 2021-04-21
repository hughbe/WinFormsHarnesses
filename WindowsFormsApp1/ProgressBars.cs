using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
using static Interop;
using static Interop.ComCtl32;

namespace WindowsFormsApp1
{
    public partial class ProgressBars : Form
    {
        public ProgressBars()
        {
            InitializeComponent();
        }

        private void minimumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Minimum = (int)minimumNumericUpDown.Value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void valueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = (int)valueNumericUpDown.Value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void maximumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Maximum = (int)maximumNumericUpDown.Value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (blockComboBox.SelectedIndex)
            {
                case 0:
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    break;
                case 1:
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    break;
                case 2:
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    break;
            }
        }

        private void stepNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Step = (int)stepNumericUpDown.Value;
        }

        private async void stepButton_Click(object sender, EventArgs e)
        {
            using var control = new WebBrowser();
            var source = new TaskCompletionSource<bool>();
            int callCount = 0;
            control.DocumentCompleted += (sender, e) =>
            {
                source.SetResult(true);
                callCount++;
            };

            string s = Path.GetFullPath("documents/example.html");
            await Task.Run(() => control.Url = new Uri(s));
            Assert.True(await source.Task);
            Assert.Null(control.Document);
            Assert.Equal(1, callCount);
            Assert.Equal(File.ReadAllText(s), control.DocumentText);
            try
            {
                progressBar1.PerformStep();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Increment(-(int)incrementNumericUpDown.Value);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Increment((int)incrementNumericUpDown.Value);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void rightToLeftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rightToLeftComboBox.SelectedIndex)
            {
                case 0:
                    progressBar1.RightToLeft = RightToLeft.No;
                    break;
                case 1:
                    progressBar1.RightToLeft = RightToLeft.Yes;
                    break;
                case 2:
                    progressBar1.RightToLeft = RightToLeft.Inherit;
                    break;
            }

            ReloadLabels();
        }

        private void rightToLeftLayoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.RightToLeftLayout = rightToLeftLayoutCheckBox.Checked;
            ReloadLabels();
        }

        private void marqueeAnimationSpeedNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.MarqueeAnimationSpeed = (int)marqueeAnimationSpeedNumericUpDown.Value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            ReloadLabels();
        }

        private void ReloadLabels()
        {
            minimumNumericUpDown.Value = progressBar1.Minimum;
            valueNumericUpDown.Value = progressBar1.Value;
            maximumNumericUpDown.Value = progressBar1.Maximum;
            marqueeAnimationSpeedNumericUpDown.Value = progressBar1.MarqueeAnimationSpeed;
        }

        private void smoothReverseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.SmoothReverse = smoothReverseCheckBox.Checked;
            ReloadLabels();
        }

        private void verticalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Vertical = verticalCheckBox.Checked;
            progressBar1.Size = new Size(progressBar1.Height, progressBar1.Width);
            ReloadLabels();
        }

        private class SubProgressBar : ProgressBar
        {
            private bool _smoothReverse;
            private bool _vertical;

            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    if (SmoothReverse)
                    {
                        cp.Style |= (int)PBS.SMOOTHREVERSE;
                    }
                    if (Vertical)
                    {
                        cp.Style |= (int)PBS.VERTICAL;
                    }

                    return cp;
                }
            }

            public bool SmoothReverse
            {
                get => _smoothReverse;
                set
                {
                    if (_smoothReverse == value)
                    {
                        return;
                    }

                    _smoothReverse = value;
                    UpdateStyles();
                    Reload();
                }
            }

            public bool Vertical
            {
                get => _vertical;
                set
                {
                    if (_vertical == value)
                    {
                        return;
                    }

                    _vertical = value;
                    UpdateStyles();
                    Reload();
                }
            }

            private void Reload()
            {
                int temp = Value;
                Value = Minimum;
                Value = temp;
            }
        }
    }
}
