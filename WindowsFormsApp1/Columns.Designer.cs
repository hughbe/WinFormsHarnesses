namespace WindowsFormsApp1
{
    partial class Columns
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Columns));
            this.listView1 = new WindowsFormsApp1.Columns.SubListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageIndexLabel = new System.Windows.Forms.Label();
            this.imageIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimumWidthLabel = new System.Windows.Forms.Label();
            this.minimumWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alignComboBox = new System.Windows.Forms.ComboBox();
            this.fixedWidthCheckBox = new System.Windows.Forms.CheckBox();
            this.splitButtonCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndexNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumWidthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 176);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Columns";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 250;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "almogaver24bits.bmp");
            // 
            // imageIndexLabel
            // 
            this.imageIndexLabel.AutoSize = true;
            this.imageIndexLabel.Location = new System.Drawing.Point(340, 44);
            this.imageIndexLabel.Name = "imageIndexLabel";
            this.imageIndexLabel.Size = new System.Drawing.Size(65, 13);
            this.imageIndexLabel.TabIndex = 16;
            this.imageIndexLabel.Text = "Image Index";
            // 
            // imageIndexNumericUpDown
            // 
            this.imageIndexNumericUpDown.Location = new System.Drawing.Point(340, 63);
            this.imageIndexNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.imageIndexNumericUpDown.Name = "imageIndexNumericUpDown";
            this.imageIndexNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.imageIndexNumericUpDown.TabIndex = 15;
            this.imageIndexNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.imageIndexNumericUpDown.ValueChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(340, 13);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(120, 20);
            this.textTextBox.TabIndex = 17;
            this.textTextBox.Text = "Column Text";
            this.textTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(340, 97);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 19;
            this.widthLabel.Text = "Width";
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(340, 116);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthNumericUpDown.TabIndex = 18;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.widthNumericUpDown.ValueChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // minimumWidthLabel
            // 
            this.minimumWidthLabel.AutoSize = true;
            this.minimumWidthLabel.Location = new System.Drawing.Point(340, 150);
            this.minimumWidthLabel.Name = "minimumWidthLabel";
            this.minimumWidthLabel.Size = new System.Drawing.Size(79, 13);
            this.minimumWidthLabel.TabIndex = 21;
            this.minimumWidthLabel.Text = "Minimum Width";
            // 
            // minimumWidthNumericUpDown
            // 
            this.minimumWidthNumericUpDown.Location = new System.Drawing.Point(340, 169);
            this.minimumWidthNumericUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.minimumWidthNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.minimumWidthNumericUpDown.Name = "minimumWidthNumericUpDown";
            this.minimumWidthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimumWidthNumericUpDown.TabIndex = 20;
            this.minimumWidthNumericUpDown.ValueChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // alignComboBox
            // 
            this.alignComboBox.FormattingEnabled = true;
            this.alignComboBox.Items.AddRange(new object[] {
            "Align Left",
            "Align Center",
            "Align Right"});
            this.alignComboBox.Location = new System.Drawing.Point(467, 11);
            this.alignComboBox.Name = "alignComboBox";
            this.alignComboBox.Size = new System.Drawing.Size(121, 21);
            this.alignComboBox.TabIndex = 22;
            this.alignComboBox.Text = "Align Left";
            this.alignComboBox.SelectedIndexChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // fixedWidthCheckBox
            // 
            this.fixedWidthCheckBox.AutoSize = true;
            this.fixedWidthCheckBox.Location = new System.Drawing.Point(467, 63);
            this.fixedWidthCheckBox.Name = "fixedWidthCheckBox";
            this.fixedWidthCheckBox.Size = new System.Drawing.Size(82, 17);
            this.fixedWidthCheckBox.TabIndex = 23;
            this.fixedWidthCheckBox.Text = "Fixed Width";
            this.fixedWidthCheckBox.UseVisualStyleBackColor = true;
            this.fixedWidthCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // splitButtonCheckBox
            // 
            this.splitButtonCheckBox.AutoSize = true;
            this.splitButtonCheckBox.Location = new System.Drawing.Point(467, 116);
            this.splitButtonCheckBox.Name = "splitButtonCheckBox";
            this.splitButtonCheckBox.Size = new System.Drawing.Size(80, 17);
            this.splitButtonCheckBox.TabIndex = 24;
            this.splitButtonCheckBox.Text = "Split Button";
            this.splitButtonCheckBox.UseVisualStyleBackColor = true;
            this.splitButtonCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // Columns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitButtonCheckBox);
            this.Controls.Add(this.fixedWidthCheckBox);
            this.Controls.Add(this.alignComboBox);
            this.Controls.Add(this.minimumWidthLabel);
            this.Controls.Add(this.minimumWidthNumericUpDown);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.imageIndexLabel);
            this.Controls.Add(this.imageIndexNumericUpDown);
            this.Controls.Add(this.listView1);
            this.Name = "Columns";
            this.Text = "Columns";
            ((System.ComponentModel.ISupportInitialize)(this.imageIndexNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumWidthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SubListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label imageIndexLabel;
        private System.Windows.Forms.NumericUpDown imageIndexNumericUpDown;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Label minimumWidthLabel;
        private System.Windows.Forms.NumericUpDown minimumWidthNumericUpDown;
        private System.Windows.Forms.ComboBox alignComboBox;
        private System.Windows.Forms.CheckBox fixedWidthCheckBox;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox splitButtonCheckBox;
    }
}