namespace WindowsFormsApp1
{
    partial class HelpForm
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
            this.popupButton = new System.Windows.Forms.Button();
            this.popupCaptionTextBox = new System.Windows.Forms.TextBox();
            this.linkButton = new System.Windows.Forms.Button();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popupButton
            // 
            this.popupButton.Location = new System.Drawing.Point(118, 12);
            this.popupButton.Name = "popupButton";
            this.popupButton.Size = new System.Drawing.Size(123, 23);
            this.popupButton.TabIndex = 0;
            this.popupButton.Text = "Show Popup";
            this.popupButton.UseVisualStyleBackColor = true;
            this.popupButton.Click += new System.EventHandler(this.popupButton_Click);
            // 
            // popupCaptionTextBox
            // 
            this.popupCaptionTextBox.Location = new System.Drawing.Point(12, 14);
            this.popupCaptionTextBox.Name = "popupCaptionTextBox";
            this.popupCaptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.popupCaptionTextBox.TabIndex = 1;
            this.popupCaptionTextBox.Text = "Popup Caption";
            // 
            // linkButton
            // 
            this.linkButton.Location = new System.Drawing.Point(118, 41);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(123, 23);
            this.linkButton.TabIndex = 2;
            this.linkButton.Text = "Show Keyword";
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.Click += new System.EventHandler(this.keywordIndexButton_Click);
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(12, 43);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(100, 20);
            this.keywordTextBox.TabIndex = 3;
            this.keywordTextBox.Text = "Keyword";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Associate Index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.associatedIndexButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 72);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.Text = "Search Query";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Search Query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.searchQueryButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.popupCaptionTextBox);
            this.Controls.Add(this.popupButton);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button popupButton;
        private System.Windows.Forms.TextBox popupCaptionTextBox;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button2;
    }
}