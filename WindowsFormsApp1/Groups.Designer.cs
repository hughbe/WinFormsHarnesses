namespace WindowsFormsApp1
{
    partial class Groups
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Header", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Group2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Item3");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.listView1 = new WindowsFormsApp1.Groups.SubListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.showHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.footerCheckBox = new System.Windows.Forms.CheckBox();
            this.footerTextBox = new System.Windows.Forms.TextBox();
            this.subtitleTextBox = new System.Windows.Forms.TextBox();
            this.subtitleCheckBox = new System.Windows.Forms.CheckBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTopTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTopCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionBottomCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionBottomTextBox = new System.Windows.Forms.TextBox();
            this.taskCheckBox = new System.Windows.Forms.CheckBox();
            this.titleImageIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleImageIndexLabel = new System.Windows.Forms.Label();
            this.extendedImageIndexLabel = new System.Windows.Forms.Label();
            this.extendedImageIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.headerAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.footerAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.collapsibleCheckBox = new System.Windows.Forms.CheckBox();
            this.collapsedCheckBox = new System.Windows.Forms.CheckBox();
            this.subsetTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.subsetTitleTextBox = new System.Windows.Forms.TextBox();
            this.viewComboBox = new System.Windows.Forms.ComboBox();
            this.updateMetricsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleImageIndexNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedImageIndexNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup1.Header = "Header";
            listViewGroup1.Name = "group1";
            listViewGroup2.Header = "Group2";
            listViewGroup2.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 296);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Column 1";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Column 2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "almogaver24bits.bmp");
            // 
            // showHeaderCheckBox
            // 
            this.showHeaderCheckBox.AutoSize = true;
            this.showHeaderCheckBox.Checked = true;
            this.showHeaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHeaderCheckBox.Location = new System.Drawing.Point(362, 13);
            this.showHeaderCheckBox.Name = "showHeaderCheckBox";
            this.showHeaderCheckBox.Size = new System.Drawing.Size(91, 17);
            this.showHeaderCheckBox.TabIndex = 1;
            this.showHeaderCheckBox.Text = "Show Header";
            this.showHeaderCheckBox.UseVisualStyleBackColor = true;
            this.showHeaderCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // headerTextBox
            // 
            this.headerTextBox.Location = new System.Drawing.Point(362, 37);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(113, 20);
            this.headerTextBox.TabIndex = 2;
            this.headerTextBox.Text = "Header";
            this.headerTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // footerCheckBox
            // 
            this.footerCheckBox.AutoSize = true;
            this.footerCheckBox.Location = new System.Drawing.Point(602, 12);
            this.footerCheckBox.Name = "footerCheckBox";
            this.footerCheckBox.Size = new System.Drawing.Size(86, 17);
            this.footerCheckBox.TabIndex = 3;
            this.footerCheckBox.Text = "Show Footer";
            this.footerCheckBox.UseVisualStyleBackColor = true;
            this.footerCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // footerTextBox
            // 
            this.footerTextBox.Location = new System.Drawing.Point(602, 36);
            this.footerTextBox.Name = "footerTextBox";
            this.footerTextBox.Size = new System.Drawing.Size(113, 20);
            this.footerTextBox.TabIndex = 4;
            this.footerTextBox.Text = "Footer";
            this.footerTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // subtitleTextBox
            // 
            this.subtitleTextBox.Location = new System.Drawing.Point(492, 37);
            this.subtitleTextBox.Name = "subtitleTextBox";
            this.subtitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtitleTextBox.TabIndex = 6;
            this.subtitleTextBox.Text = "Subtitle";
            this.subtitleTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // subtitleCheckBox
            // 
            this.subtitleCheckBox.AutoSize = true;
            this.subtitleCheckBox.Location = new System.Drawing.Point(492, 13);
            this.subtitleCheckBox.Name = "subtitleCheckBox";
            this.subtitleCheckBox.Size = new System.Drawing.Size(91, 17);
            this.subtitleCheckBox.TabIndex = 5;
            this.subtitleCheckBox.Text = "Show Subtitle";
            this.subtitleCheckBox.UseVisualStyleBackColor = true;
            this.subtitleCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(362, 132);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(113, 20);
            this.taskTextBox.TabIndex = 7;
            this.taskTextBox.Text = "Task";
            this.taskTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // descriptionTopTextBox
            // 
            this.descriptionTopTextBox.Location = new System.Drawing.Point(492, 132);
            this.descriptionTopTextBox.Name = "descriptionTopTextBox";
            this.descriptionTopTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTopTextBox.TabIndex = 8;
            this.descriptionTopTextBox.Text = "Description Top";
            this.descriptionTopTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // descriptionTopCheckBox
            // 
            this.descriptionTopCheckBox.AutoSize = true;
            this.descriptionTopCheckBox.Location = new System.Drawing.Point(492, 109);
            this.descriptionTopCheckBox.Name = "descriptionTopCheckBox";
            this.descriptionTopCheckBox.Size = new System.Drawing.Size(131, 17);
            this.descriptionTopCheckBox.TabIndex = 9;
            this.descriptionTopCheckBox.Text = "Show Description Top";
            this.descriptionTopCheckBox.UseVisualStyleBackColor = true;
            this.descriptionTopCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // descriptionBottomCheckBox
            // 
            this.descriptionBottomCheckBox.AutoSize = true;
            this.descriptionBottomCheckBox.Location = new System.Drawing.Point(492, 166);
            this.descriptionBottomCheckBox.Name = "descriptionBottomCheckBox";
            this.descriptionBottomCheckBox.Size = new System.Drawing.Size(153, 17);
            this.descriptionBottomCheckBox.TabIndex = 11;
            this.descriptionBottomCheckBox.Text = "Include Description Bottom";
            this.descriptionBottomCheckBox.UseVisualStyleBackColor = true;
            this.descriptionBottomCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // descriptionBottomTextBox
            // 
            this.descriptionBottomTextBox.Location = new System.Drawing.Point(492, 189);
            this.descriptionBottomTextBox.Name = "descriptionBottomTextBox";
            this.descriptionBottomTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionBottomTextBox.TabIndex = 10;
            this.descriptionBottomTextBox.Text = "Description Bottom";
            this.descriptionBottomTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // taskCheckBox
            // 
            this.taskCheckBox.AutoSize = true;
            this.taskCheckBox.Location = new System.Drawing.Point(362, 109);
            this.taskCheckBox.Name = "taskCheckBox";
            this.taskCheckBox.Size = new System.Drawing.Size(80, 17);
            this.taskCheckBox.TabIndex = 12;
            this.taskCheckBox.Text = "Show Task";
            this.taskCheckBox.UseVisualStyleBackColor = true;
            this.taskCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // titleImageIndexNumericUpDown
            // 
            this.titleImageIndexNumericUpDown.Location = new System.Drawing.Point(362, 240);
            this.titleImageIndexNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.titleImageIndexNumericUpDown.Name = "titleImageIndexNumericUpDown";
            this.titleImageIndexNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.titleImageIndexNumericUpDown.TabIndex = 13;
            this.titleImageIndexNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.titleImageIndexNumericUpDown.ValueChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // titleImageIndexLabel
            // 
            this.titleImageIndexLabel.AutoSize = true;
            this.titleImageIndexLabel.Location = new System.Drawing.Point(362, 221);
            this.titleImageIndexLabel.Name = "titleImageIndexLabel";
            this.titleImageIndexLabel.Size = new System.Drawing.Size(88, 13);
            this.titleImageIndexLabel.TabIndex = 14;
            this.titleImageIndexLabel.Text = "Title Image Index";
            // 
            // extendedImageIndexLabel
            // 
            this.extendedImageIndexLabel.AutoSize = true;
            this.extendedImageIndexLabel.Location = new System.Drawing.Point(362, 269);
            this.extendedImageIndexLabel.Name = "extendedImageIndexLabel";
            this.extendedImageIndexLabel.Size = new System.Drawing.Size(113, 13);
            this.extendedImageIndexLabel.TabIndex = 16;
            this.extendedImageIndexLabel.Text = "Extended Image Index";
            // 
            // extendedImageIndexNumericUpDown
            // 
            this.extendedImageIndexNumericUpDown.Location = new System.Drawing.Point(362, 288);
            this.extendedImageIndexNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.extendedImageIndexNumericUpDown.Name = "extendedImageIndexNumericUpDown";
            this.extendedImageIndexNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.extendedImageIndexNumericUpDown.TabIndex = 15;
            this.extendedImageIndexNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.extendedImageIndexNumericUpDown.ValueChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // headerAlignmentComboBox
            // 
            this.headerAlignmentComboBox.FormattingEnabled = true;
            this.headerAlignmentComboBox.Items.AddRange(new object[] {
            "Left Align",
            "Center Align",
            "Right Align"});
            this.headerAlignmentComboBox.Location = new System.Drawing.Point(362, 64);
            this.headerAlignmentComboBox.Name = "headerAlignmentComboBox";
            this.headerAlignmentComboBox.Size = new System.Drawing.Size(113, 21);
            this.headerAlignmentComboBox.TabIndex = 17;
            this.headerAlignmentComboBox.Text = "Left Align";
            this.headerAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // footerAlignmentComboBox
            // 
            this.footerAlignmentComboBox.FormattingEnabled = true;
            this.footerAlignmentComboBox.Items.AddRange(new object[] {
            "Left Align",
            "Center Align",
            "Right Align"});
            this.footerAlignmentComboBox.Location = new System.Drawing.Point(602, 64);
            this.footerAlignmentComboBox.Name = "footerAlignmentComboBox";
            this.footerAlignmentComboBox.Size = new System.Drawing.Size(113, 21);
            this.footerAlignmentComboBox.TabIndex = 18;
            this.footerAlignmentComboBox.Text = "Left Align";
            this.footerAlignmentComboBox.SelectedIndexChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // collapsibleCheckBox
            // 
            this.collapsibleCheckBox.AutoSize = true;
            this.collapsibleCheckBox.Location = new System.Drawing.Point(492, 242);
            this.collapsibleCheckBox.Name = "collapsibleCheckBox";
            this.collapsibleCheckBox.Size = new System.Drawing.Size(76, 17);
            this.collapsibleCheckBox.TabIndex = 19;
            this.collapsibleCheckBox.Text = "Collapsible";
            this.collapsibleCheckBox.UseVisualStyleBackColor = true;
            this.collapsibleCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // collapsedCheckBox
            // 
            this.collapsedCheckBox.AutoSize = true;
            this.collapsedCheckBox.Location = new System.Drawing.Point(492, 269);
            this.collapsedCheckBox.Name = "collapsedCheckBox";
            this.collapsedCheckBox.Size = new System.Drawing.Size(72, 17);
            this.collapsedCheckBox.TabIndex = 20;
            this.collapsedCheckBox.Text = "Collapsed";
            this.collapsedCheckBox.UseVisualStyleBackColor = true;
            this.collapsedCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // subsetTitleCheckBox
            // 
            this.subsetTitleCheckBox.AutoSize = true;
            this.subsetTitleCheckBox.Location = new System.Drawing.Point(657, 109);
            this.subsetTitleCheckBox.Name = "subsetTitleCheckBox";
            this.subsetTitleCheckBox.Size = new System.Drawing.Size(112, 17);
            this.subsetTitleCheckBox.TabIndex = 22;
            this.subsetTitleCheckBox.Text = "Show Subset Title";
            this.subsetTitleCheckBox.UseVisualStyleBackColor = true;
            this.subsetTitleCheckBox.CheckedChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // subsetTitleTextBox
            // 
            this.subsetTitleTextBox.Location = new System.Drawing.Point(657, 132);
            this.subsetTitleTextBox.Name = "subsetTitleTextBox";
            this.subsetTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.subsetTitleTextBox.TabIndex = 21;
            this.subsetTitleTextBox.Text = "Subset Title";
            this.subsetTitleTextBox.TextChanged += new System.EventHandler(this.ReloadEvent);
            // 
            // viewComboBox
            // 
            this.viewComboBox.FormattingEnabled = true;
            this.viewComboBox.Items.AddRange(new object[] {
            "LargeIcon View",
            "Details View",
            "SmallIcon View",
            "List View",
            "Tile View"});
            this.viewComboBox.Location = new System.Drawing.Point(12, 324);
            this.viewComboBox.Name = "viewComboBox";
            this.viewComboBox.Size = new System.Drawing.Size(121, 21);
            this.viewComboBox.TabIndex = 23;
            this.viewComboBox.Text = "Large Icon View";
            this.viewComboBox.SelectedIndexChanged += new System.EventHandler(this.viewComboBox_SelectedIndexChanged);
            // 
            // updateMetricsButton
            // 
            this.updateMetricsButton.Location = new System.Drawing.Point(139, 324);
            this.updateMetricsButton.Name = "updateMetricsButton";
            this.updateMetricsButton.Size = new System.Drawing.Size(75, 23);
            this.updateMetricsButton.TabIndex = 24;
            this.updateMetricsButton.Text = "Update Metrics";
            this.updateMetricsButton.UseVisualStyleBackColor = true;
            this.updateMetricsButton.Click += new System.EventHandler(this.updateMetricsButton_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateMetricsButton);
            this.Controls.Add(this.viewComboBox);
            this.Controls.Add(this.subsetTitleCheckBox);
            this.Controls.Add(this.subsetTitleTextBox);
            this.Controls.Add(this.collapsedCheckBox);
            this.Controls.Add(this.collapsibleCheckBox);
            this.Controls.Add(this.footerAlignmentComboBox);
            this.Controls.Add(this.headerAlignmentComboBox);
            this.Controls.Add(this.extendedImageIndexLabel);
            this.Controls.Add(this.extendedImageIndexNumericUpDown);
            this.Controls.Add(this.titleImageIndexLabel);
            this.Controls.Add(this.titleImageIndexNumericUpDown);
            this.Controls.Add(this.taskCheckBox);
            this.Controls.Add(this.descriptionBottomCheckBox);
            this.Controls.Add(this.descriptionBottomTextBox);
            this.Controls.Add(this.descriptionTopCheckBox);
            this.Controls.Add(this.descriptionTopTextBox);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.subtitleTextBox);
            this.Controls.Add(this.subtitleCheckBox);
            this.Controls.Add(this.footerTextBox);
            this.Controls.Add(this.footerCheckBox);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.showHeaderCheckBox);
            this.Controls.Add(this.listView1);
            this.Name = "Groups";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.titleImageIndexNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedImageIndexNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SubListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox showHeaderCheckBox;
        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.CheckBox footerCheckBox;
        private System.Windows.Forms.TextBox footerTextBox;
        private System.Windows.Forms.TextBox subtitleTextBox;
        private System.Windows.Forms.CheckBox subtitleCheckBox;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox descriptionTopTextBox;
        private System.Windows.Forms.CheckBox descriptionTopCheckBox;
        private System.Windows.Forms.CheckBox descriptionBottomCheckBox;
        private System.Windows.Forms.TextBox descriptionBottomTextBox;
        private System.Windows.Forms.CheckBox taskCheckBox;
        private System.Windows.Forms.NumericUpDown titleImageIndexNumericUpDown;
        private System.Windows.Forms.Label titleImageIndexLabel;
        private System.Windows.Forms.Label extendedImageIndexLabel;
        private System.Windows.Forms.NumericUpDown extendedImageIndexNumericUpDown;
        private System.Windows.Forms.ComboBox headerAlignmentComboBox;
        private System.Windows.Forms.ComboBox footerAlignmentComboBox;
        private System.Windows.Forms.CheckBox collapsibleCheckBox;
        private System.Windows.Forms.CheckBox collapsedCheckBox;
        private System.Windows.Forms.CheckBox subsetTitleCheckBox;
        private System.Windows.Forms.TextBox subsetTitleTextBox;
        private System.Windows.Forms.ComboBox viewComboBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button updateMetricsButton;
    }
}

