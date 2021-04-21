namespace WindowsFormsApp1
{
    partial class ImageLists
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
            this.original = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.PictureBox();
            this.format32bppRgbButton = new System.Windows.Forms.Button();
            this.format32bppArgb = new System.Windows.Forms.Button();
            this.format32bppPargb = new System.Windows.Forms.Button();
            this.depthComboBox = new System.Windows.Forms.ComboBox();
            this.hasAlpha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(13, 13);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(200, 200);
            this.original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.original.TabIndex = 0;
            this.original.TabStop = false;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(220, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(200, 200);
            this.result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.result.TabIndex = 1;
            this.result.TabStop = false;
            // 
            // format32bppRgbButton
            // 
            this.format32bppRgbButton.Location = new System.Drawing.Point(13, 220);
            this.format32bppRgbButton.Name = "format32bppRgbButton";
            this.format32bppRgbButton.Size = new System.Drawing.Size(75, 23);
            this.format32bppRgbButton.TabIndex = 2;
            this.format32bppRgbButton.Text = "32bpp RGB";
            this.format32bppRgbButton.UseVisualStyleBackColor = true;
            this.format32bppRgbButton.Click += new System.EventHandler(this.format32bppRgbButton_Click);
            // 
            // format32bppArgb
            // 
            this.format32bppArgb.Location = new System.Drawing.Point(94, 220);
            this.format32bppArgb.Name = "format32bppArgb";
            this.format32bppArgb.Size = new System.Drawing.Size(93, 23);
            this.format32bppArgb.TabIndex = 3;
            this.format32bppArgb.Text = "32bpp ARGB";
            this.format32bppArgb.UseVisualStyleBackColor = true;
            this.format32bppArgb.Click += new System.EventHandler(this.format32bppArgb_Click);
            // 
            // format32bppPargb
            // 
            this.format32bppPargb.Location = new System.Drawing.Point(193, 220);
            this.format32bppPargb.Name = "format32bppPargb";
            this.format32bppPargb.Size = new System.Drawing.Size(93, 23);
            this.format32bppPargb.TabIndex = 4;
            this.format32bppPargb.Text = "32bpp PARGB";
            this.format32bppPargb.UseVisualStyleBackColor = true;
            this.format32bppPargb.Click += new System.EventHandler(this.format32bppPArgb_Click);
            // 
            // depthComboBox
            // 
            this.depthComboBox.FormattingEnabled = true;
            this.depthComboBox.Items.AddRange(new object[] {
            "Depth4Bit",
            "Depth8Bit",
            "Depth16Bit",
            "Depth24Bit",
            "Depth32Bit"});
            this.depthComboBox.Location = new System.Drawing.Point(427, 13);
            this.depthComboBox.Name = "depthComboBox";
            this.depthComboBox.Size = new System.Drawing.Size(121, 21);
            this.depthComboBox.TabIndex = 5;
            this.depthComboBox.Text = "Depth32Bit";
            // 
            // hasAlpha
            // 
            this.hasAlpha.AutoSize = true;
            this.hasAlpha.Location = new System.Drawing.Point(427, 41);
            this.hasAlpha.Name = "hasAlpha";
            this.hasAlpha.Size = new System.Drawing.Size(75, 17);
            this.hasAlpha.TabIndex = 6;
            this.hasAlpha.Text = "Has Alpha";
            this.hasAlpha.UseVisualStyleBackColor = true;
            // 
            // ImageLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hasAlpha);
            this.Controls.Add(this.depthComboBox);
            this.Controls.Add(this.format32bppPargb);
            this.Controls.Add(this.format32bppArgb);
            this.Controls.Add(this.format32bppRgbButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.original);
            this.Name = "ImageLists";
            this.Text = "ImageList";
            this.Load += new System.EventHandler(this.ImageLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox original;
        private System.Windows.Forms.PictureBox result;
        private System.Windows.Forms.Button format32bppRgbButton;
        private System.Windows.Forms.Button format32bppArgb;
        private System.Windows.Forms.Button format32bppPargb;
        private System.Windows.Forms.ComboBox depthComboBox;
        private System.Windows.Forms.CheckBox hasAlpha;
    }
}