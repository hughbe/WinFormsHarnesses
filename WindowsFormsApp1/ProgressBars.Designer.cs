namespace WindowsFormsApp1
{
    partial class ProgressBars
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
            this.progressBar1 = new WindowsFormsApp1.ProgressBars.SubProgressBar();
            this.maximumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blockComboBox = new System.Windows.Forms.ComboBox();
            this.stepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.stepButton = new System.Windows.Forms.Button();
            this.decrementButton = new System.Windows.Forms.Button();
            this.incrementNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.incrementButton = new System.Windows.Forms.Button();
            this.rightToLeftLayoutCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rightToLeftComboBox = new System.Windows.Forms.ComboBox();
            this.marqueeAnimationSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.smoothReverseCheckBox = new System.Windows.Forms.CheckBox();
            this.verticalCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.maximumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeAnimationSpeedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 23);
            this.progressBar1.SmoothReverse = false;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            this.progressBar1.Vertical = false;
            // 
            // maximumNumericUpDown
            // 
            this.maximumNumericUpDown.Location = new System.Drawing.Point(114, 108);
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
            this.maximumNumericUpDown.TabIndex = 18;
            this.maximumNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maximumNumericUpDown.ValueChanged += new System.EventHandler(this.maximumNumericUpDown_ValueChanged);
            // 
            // valueNumericUpDown
            // 
            this.valueNumericUpDown.Location = new System.Drawing.Point(114, 80);
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
            this.valueNumericUpDown.TabIndex = 17;
            this.valueNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.valueNumericUpDown.ValueChanged += new System.EventHandler(this.valueNumericUpDown_ValueChanged);
            // 
            // minimumNumericUpDown
            // 
            this.minimumNumericUpDown.Location = new System.Drawing.Point(114, 53);
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
            this.minimumNumericUpDown.TabIndex = 16;
            this.minimumNumericUpDown.ValueChanged += new System.EventHandler(this.minimumNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Maximum:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minimum:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Style:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // blockComboBox
            // 
            this.blockComboBox.FormattingEnabled = true;
            this.blockComboBox.Items.AddRange(new object[] {
            "Blocks",
            "Continuous",
            "Marquee"});
            this.blockComboBox.Location = new System.Drawing.Point(467, 20);
            this.blockComboBox.Name = "blockComboBox";
            this.blockComboBox.Size = new System.Drawing.Size(121, 21);
            this.blockComboBox.TabIndex = 20;
            this.blockComboBox.Text = "Blocks";
            this.blockComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // stepNumericUpDown
            // 
            this.stepNumericUpDown.Location = new System.Drawing.Point(113, 150);
            this.stepNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.stepNumericUpDown.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.stepNumericUpDown.Name = "stepNumericUpDown";
            this.stepNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.stepNumericUpDown.TabIndex = 22;
            this.stepNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stepNumericUpDown.ValueChanged += new System.EventHandler(this.stepNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Step:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(239, 147);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 23;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // decrementButton
            // 
            this.decrementButton.Location = new System.Drawing.Point(240, 185);
            this.decrementButton.Name = "decrementButton";
            this.decrementButton.Size = new System.Drawing.Size(75, 23);
            this.decrementButton.TabIndex = 26;
            this.decrementButton.Text = "Decrement";
            this.decrementButton.UseVisualStyleBackColor = true;
            this.decrementButton.Click += new System.EventHandler(this.decrementButton_Click);
            // 
            // incrementNumericUpDown
            // 
            this.incrementNumericUpDown.Location = new System.Drawing.Point(114, 188);
            this.incrementNumericUpDown.Name = "incrementNumericUpDown";
            this.incrementNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.incrementNumericUpDown.TabIndex = 25;
            this.incrementNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Step:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // incrementButton
            // 
            this.incrementButton.Location = new System.Drawing.Point(321, 185);
            this.incrementButton.Name = "incrementButton";
            this.incrementButton.Size = new System.Drawing.Size(75, 23);
            this.incrementButton.TabIndex = 27;
            this.incrementButton.Text = "Increment";
            this.incrementButton.UseVisualStyleBackColor = true;
            this.incrementButton.Click += new System.EventHandler(this.incrementButton_Click);
            // 
            // rightToLeftLayoutCheckBox
            // 
            this.rightToLeftLayoutCheckBox.AutoSize = true;
            this.rightToLeftLayoutCheckBox.Location = new System.Drawing.Point(467, 75);
            this.rightToLeftLayoutCheckBox.Name = "rightToLeftLayoutCheckBox";
            this.rightToLeftLayoutCheckBox.Size = new System.Drawing.Size(119, 17);
            this.rightToLeftLayoutCheckBox.TabIndex = 34;
            this.rightToLeftLayoutCheckBox.Text = "Right to Left Layout";
            this.rightToLeftLayoutCheckBox.UseVisualStyleBackColor = true;
            this.rightToLeftLayoutCheckBox.CheckedChanged += new System.EventHandler(this.rightToLeftLayoutCheckBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(393, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 33;
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
            this.rightToLeftComboBox.Location = new System.Drawing.Point(467, 47);
            this.rightToLeftComboBox.Name = "rightToLeftComboBox";
            this.rightToLeftComboBox.Size = new System.Drawing.Size(121, 21);
            this.rightToLeftComboBox.TabIndex = 32;
            this.rightToLeftComboBox.Text = "No";
            this.rightToLeftComboBox.SelectedIndexChanged += new System.EventHandler(this.rightToLeftComboBox_SelectedIndexChanged);
            // 
            // marqueeAnimationSpeedNumericUpDown
            // 
            this.marqueeAnimationSpeedNumericUpDown.Location = new System.Drawing.Point(466, 98);
            this.marqueeAnimationSpeedNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.marqueeAnimationSpeedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.marqueeAnimationSpeedNumericUpDown.Name = "marqueeAnimationSpeedNumericUpDown";
            this.marqueeAnimationSpeedNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.marqueeAnimationSpeedNumericUpDown.TabIndex = 36;
            this.marqueeAnimationSpeedNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.marqueeAnimationSpeedNumericUpDown.ValueChanged += new System.EventHandler(this.marqueeAnimationSpeedNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Marquee Animation Speed:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // smoothReverseCheckBox
            // 
            this.smoothReverseCheckBox.AutoSize = true;
            this.smoothReverseCheckBox.Location = new System.Drawing.Point(466, 124);
            this.smoothReverseCheckBox.Name = "smoothReverseCheckBox";
            this.smoothReverseCheckBox.Size = new System.Drawing.Size(105, 17);
            this.smoothReverseCheckBox.TabIndex = 37;
            this.smoothReverseCheckBox.Text = "Smooth Reverse";
            this.smoothReverseCheckBox.UseVisualStyleBackColor = true;
            this.smoothReverseCheckBox.CheckedChanged += new System.EventHandler(this.smoothReverseCheckBox_CheckedChanged);
            // 
            // verticalCheckBox
            // 
            this.verticalCheckBox.AutoSize = true;
            this.verticalCheckBox.Location = new System.Drawing.Point(466, 150);
            this.verticalCheckBox.Name = "verticalCheckBox";
            this.verticalCheckBox.Size = new System.Drawing.Size(61, 17);
            this.verticalCheckBox.TabIndex = 38;
            this.verticalCheckBox.Text = "Vertical";
            this.verticalCheckBox.UseVisualStyleBackColor = true;
            this.verticalCheckBox.CheckedChanged += new System.EventHandler(this.verticalCheckBox_CheckedChanged);
            // 
            // ProgressBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verticalCheckBox);
            this.Controls.Add(this.smoothReverseCheckBox);
            this.Controls.Add(this.marqueeAnimationSpeedNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rightToLeftLayoutCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rightToLeftComboBox);
            this.Controls.Add(this.incrementButton);
            this.Controls.Add(this.decrementButton);
            this.Controls.Add(this.incrementNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.stepNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blockComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maximumNumericUpDown);
            this.Controls.Add(this.valueNumericUpDown);
            this.Controls.Add(this.minimumNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBars";
            this.Text = "ProgressBars";
            ((System.ComponentModel.ISupportInitialize)(this.maximumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrementNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeAnimationSpeedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SubProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown maximumNumericUpDown;
        private System.Windows.Forms.NumericUpDown valueNumericUpDown;
        private System.Windows.Forms.NumericUpDown minimumNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox blockComboBox;
        private System.Windows.Forms.NumericUpDown stepNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button decrementButton;
        private System.Windows.Forms.NumericUpDown incrementNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button incrementButton;
        private System.Windows.Forms.CheckBox rightToLeftLayoutCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox rightToLeftComboBox;
        private System.Windows.Forms.NumericUpDown marqueeAnimationSpeedNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox smoothReverseCheckBox;
        private System.Windows.Forms.CheckBox verticalCheckBox;
    }
}