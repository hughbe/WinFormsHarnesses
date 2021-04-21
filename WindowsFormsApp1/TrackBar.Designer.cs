namespace WindowsFormsApp1
{
    partial class TrackBars
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
            this.trackBar1 = new WindowsFormsApp1.TrackBars.SubTrackBar();
            this.showThumbCheckBox = new System.Windows.Forms.CheckBox();
            this.tickStyleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minimumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.largeChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.smallChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showSelectionRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.selectionEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.selectionStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tickFrequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.connectThumbToEndCheckBox = new System.Windows.Forms.CheckBox();
            this.orientationCheckBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rightToLeftComboBox = new System.Windows.Forms.ComboBox();
            this.rightToLeftLayoutCheckBox = new System.Windows.Forms.CheckBox();
            this.thumbLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeChangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallChangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionEndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionStartNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickFrequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 13);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SelectionEnd = 0;
            this.trackBar1.SelectionStart = 0;
            this.trackBar1.ShowSelectionRange = false;
            this.trackBar1.ShowThumb = true;
            this.trackBar1.Size = new System.Drawing.Size(256, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ThumbLength = 19;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // showThumbCheckBox
            // 
            this.showThumbCheckBox.AutoSize = true;
            this.showThumbCheckBox.Checked = true;
            this.showThumbCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showThumbCheckBox.Location = new System.Drawing.Point(315, 62);
            this.showThumbCheckBox.Name = "showThumbCheckBox";
            this.showThumbCheckBox.Size = new System.Drawing.Size(89, 17);
            this.showThumbCheckBox.TabIndex = 2;
            this.showThumbCheckBox.Text = "Show Thumb";
            this.showThumbCheckBox.UseVisualStyleBackColor = true;
            this.showThumbCheckBox.CheckedChanged += new System.EventHandler(this.showThumbCheckBox_CheckedChanged);
            // 
            // tickStyleComboBox
            // 
            this.tickStyleComboBox.FormattingEnabled = true;
            this.tickStyleComboBox.Items.AddRange(new object[] {
            "BottomRight",
            "TopLeft",
            "Both",
            "None"});
            this.tickStyleComboBox.Location = new System.Drawing.Point(394, 13);
            this.tickStyleComboBox.Name = "tickStyleComboBox";
            this.tickStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.tickStyleComboBox.TabIndex = 3;
            this.tickStyleComboBox.Text = "Bottom Right";
            this.tickStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minimum:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(139, 176);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(0, 13);
            this.maximumLabel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maximum:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minimumNumericUpDown
            // 
            this.minimumNumericUpDown.Location = new System.Drawing.Point(142, 64);
            this.minimumNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.minimumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minimumNumericUpDown.Name = "minimumNumericUpDown";
            this.minimumNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimumNumericUpDown.TabIndex = 10;
            this.minimumNumericUpDown.ValueChanged += new System.EventHandler(this.minimumNumericUpDown_ValueChanged);
            // 
            // valueNumericUpDown
            // 
            this.valueNumericUpDown.Location = new System.Drawing.Point(142, 91);
            this.valueNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.valueNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.valueNumericUpDown.Name = "valueNumericUpDown";
            this.valueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valueNumericUpDown.TabIndex = 11;
            this.valueNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.valueNumericUpDown.ValueChanged += new System.EventHandler(this.valueNumericUpDown_ValueChanged);
            // 
            // maximumNumericUpDown
            // 
            this.maximumNumericUpDown.Location = new System.Drawing.Point(142, 119);
            this.maximumNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.maximumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.maximumNumericUpDown.Name = "maximumNumericUpDown";
            this.maximumNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maximumNumericUpDown.TabIndex = 12;
            this.maximumNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maximumNumericUpDown.ValueChanged += new System.EventHandler(this.maximumNumericUpDown_ValueChanged);
            // 
            // largeChangeNumericUpDown
            // 
            this.largeChangeNumericUpDown.Location = new System.Drawing.Point(168, 161);
            this.largeChangeNumericUpDown.Name = "largeChangeNumericUpDown";
            this.largeChangeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.largeChangeNumericUpDown.TabIndex = 14;
            this.largeChangeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.largeChangeNumericUpDown.ValueChanged += new System.EventHandler(this.largeChangeNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Large Change:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // smallChangeNumericUpDown
            // 
            this.smallChangeNumericUpDown.Location = new System.Drawing.Point(168, 187);
            this.smallChangeNumericUpDown.Name = "smallChangeNumericUpDown";
            this.smallChangeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.smallChangeNumericUpDown.TabIndex = 16;
            this.smallChangeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smallChangeNumericUpDown.ValueChanged += new System.EventHandler(this.smallChangeNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Small Change:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tick Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // showSelectionRangeCheckBox
            // 
            this.showSelectionRangeCheckBox.AutoSize = true;
            this.showSelectionRangeCheckBox.Location = new System.Drawing.Point(315, 85);
            this.showSelectionRangeCheckBox.Name = "showSelectionRangeCheckBox";
            this.showSelectionRangeCheckBox.Size = new System.Drawing.Size(135, 17);
            this.showSelectionRangeCheckBox.TabIndex = 18;
            this.showSelectionRangeCheckBox.Text = "Show Selection Range";
            this.showSelectionRangeCheckBox.UseVisualStyleBackColor = true;
            this.showSelectionRangeCheckBox.CheckedChanged += new System.EventHandler(this.showSelectionRangeCheckBox_CheckedChanged);
            // 
            // selectionEndNumericUpDown
            // 
            this.selectionEndNumericUpDown.Location = new System.Drawing.Point(395, 138);
            this.selectionEndNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.selectionEndNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.selectionEndNumericUpDown.Name = "selectionEndNumericUpDown";
            this.selectionEndNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.selectionEndNumericUpDown.TabIndex = 23;
            this.selectionEndNumericUpDown.ValueChanged += new System.EventHandler(this.selectionEndNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Selection End:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // selectionStartNumericUpDown
            // 
            this.selectionStartNumericUpDown.Location = new System.Drawing.Point(395, 112);
            this.selectionStartNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.selectionStartNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.selectionStartNumericUpDown.Name = "selectionStartNumericUpDown";
            this.selectionStartNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.selectionStartNumericUpDown.TabIndex = 21;
            this.selectionStartNumericUpDown.ValueChanged += new System.EventHandler(this.selectionStartNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Selection Start:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // tickFrequencyNumericUpDown
            // 
            this.tickFrequencyNumericUpDown.Location = new System.Drawing.Point(395, 40);
            this.tickFrequencyNumericUpDown.Name = "tickFrequencyNumericUpDown";
            this.tickFrequencyNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.tickFrequencyNumericUpDown.TabIndex = 25;
            this.tickFrequencyNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tickFrequencyNumericUpDown.ValueChanged += new System.EventHandler(this.tickFrequencyNumericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tick Frequency:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // connectThumbToEndCheckBox
            // 
            this.connectThumbToEndCheckBox.AutoSize = true;
            this.connectThumbToEndCheckBox.Location = new System.Drawing.Point(315, 167);
            this.connectThumbToEndCheckBox.Name = "connectThumbToEndCheckBox";
            this.connectThumbToEndCheckBox.Size = new System.Drawing.Size(136, 17);
            this.connectThumbToEndCheckBox.TabIndex = 26;
            this.connectThumbToEndCheckBox.Text = "Connect Thumb to End";
            this.connectThumbToEndCheckBox.UseVisualStyleBackColor = true;
            this.connectThumbToEndCheckBox.CheckedChanged += new System.EventHandler(this.connectThumbToEndCheckBox_CheckedChanged);
            // 
            // orientationCheckBox
            // 
            this.orientationCheckBox.FormattingEnabled = true;
            this.orientationCheckBox.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.orientationCheckBox.Location = new System.Drawing.Point(607, 12);
            this.orientationCheckBox.Name = "orientationCheckBox";
            this.orientationCheckBox.Size = new System.Drawing.Size(121, 21);
            this.orientationCheckBox.TabIndex = 27;
            this.orientationCheckBox.Text = "Horizontal";
            this.orientationCheckBox.SelectedIndexChanged += new System.EventHandler(this.orientationCheckBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Orientation:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Right to Left:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightToLeftComboBox
            // 
            this.rightToLeftComboBox.FormattingEnabled = true;
            this.rightToLeftComboBox.Items.AddRange(new object[] {
            "No",
            "Yes",
            "Inherit"});
            this.rightToLeftComboBox.Location = new System.Drawing.Point(607, 37);
            this.rightToLeftComboBox.Name = "rightToLeftComboBox";
            this.rightToLeftComboBox.Size = new System.Drawing.Size(121, 21);
            this.rightToLeftComboBox.TabIndex = 29;
            this.rightToLeftComboBox.Text = "No";
            this.rightToLeftComboBox.SelectedIndexChanged += new System.EventHandler(this.rightToLeftComboBox_SelectedIndexChanged);
            // 
            // rightToLeftLayoutCheckBox
            // 
            this.rightToLeftLayoutCheckBox.AutoSize = true;
            this.rightToLeftLayoutCheckBox.Location = new System.Drawing.Point(607, 65);
            this.rightToLeftLayoutCheckBox.Name = "rightToLeftLayoutCheckBox";
            this.rightToLeftLayoutCheckBox.Size = new System.Drawing.Size(119, 17);
            this.rightToLeftLayoutCheckBox.TabIndex = 31;
            this.rightToLeftLayoutCheckBox.Text = "Right to Left Layout";
            this.rightToLeftLayoutCheckBox.UseVisualStyleBackColor = true;
            this.rightToLeftLayoutCheckBox.CheckedChanged += new System.EventHandler(this.rightToLeftLayoutCheckBox_CheckedChanged);
            // 
            // thumbLengthNumericUpDown
            // 
            this.thumbLengthNumericUpDown.Location = new System.Drawing.Point(606, 93);
            this.thumbLengthNumericUpDown.Name = "thumbLengthNumericUpDown";
            this.thumbLengthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.thumbLengthNumericUpDown.TabIndex = 33;
            this.thumbLengthNumericUpDown.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.thumbLengthNumericUpDown.ValueChanged += new System.EventHandler(this.thumbLengthNumericUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Thumb Width:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrackBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.thumbLengthNumericUpDown);
            this.Controls.Add(this.rightToLeftLayoutCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rightToLeftComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.orientationCheckBox);
            this.Controls.Add(this.connectThumbToEndCheckBox);
            this.Controls.Add(this.tickFrequencyNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.selectionEndNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectionStartNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.showSelectionRangeCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.smallChangeNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.largeChangeNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maximumNumericUpDown);
            this.Controls.Add(this.valueNumericUpDown);
            this.Controls.Add(this.minimumNumericUpDown);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tickStyleComboBox);
            this.Controls.Add(this.showThumbCheckBox);
            this.Controls.Add(this.trackBar1);
            this.Name = "TrackBars";
            this.Text = "TrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeChangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallChangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionEndNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionStartNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickFrequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox showThumbCheckBox;
        private System.Windows.Forms.ComboBox tickStyleComboBox;
        private SubTrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minimumNumericUpDown;
        private System.Windows.Forms.NumericUpDown valueNumericUpDown;
        private System.Windows.Forms.NumericUpDown maximumNumericUpDown;
        private System.Windows.Forms.NumericUpDown largeChangeNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown smallChangeNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox showSelectionRangeCheckBox;
        private System.Windows.Forms.NumericUpDown selectionEndNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown selectionStartNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tickFrequencyNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox connectThumbToEndCheckBox;
        private System.Windows.Forms.ComboBox orientationCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox rightToLeftComboBox;
        private System.Windows.Forms.CheckBox rightToLeftLayoutCheckBox;
        private System.Windows.Forms.NumericUpDown thumbLengthNumericUpDown;
        private System.Windows.Forms.Label label13;
    }
}