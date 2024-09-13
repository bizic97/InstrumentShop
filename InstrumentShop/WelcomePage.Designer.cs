namespace InstrumentShop
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.continueToStoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.continueToInventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // continueToStoreLabel
            // 
            this.continueToStoreLabel.AutoSize = true;
            this.continueToStoreLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.continueToStoreLabel.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueToStoreLabel.Location = new System.Drawing.Point(25, 286);
            this.continueToStoreLabel.Name = "continueToStoreLabel";
            this.continueToStoreLabel.Size = new System.Drawing.Size(166, 25);
            this.continueToStoreLabel.TabIndex = 19;
            this.continueToStoreLabel.Text = "Continue to store";
            this.continueToStoreLabel.Click += new System.EventHandler(this.continueToStoreLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 325);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // continueToInventoryLabel
            // 
            this.continueToInventoryLabel.AutoSize = true;
            this.continueToInventoryLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.continueToInventoryLabel.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueToInventoryLabel.Location = new System.Drawing.Point(254, 286);
            this.continueToInventoryLabel.Name = "continueToInventoryLabel";
            this.continueToInventoryLabel.Size = new System.Drawing.Size(206, 25);
            this.continueToInventoryLabel.TabIndex = 22;
            this.continueToInventoryLabel.Text = "Continue to inventory";
            this.continueToInventoryLabel.Click += new System.EventHandler(this.continueToInventoryLabel_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 337);
            this.Controls.Add(this.continueToInventoryLabel);
            this.Controls.Add(this.continueToStoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label continueToStoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label continueToInventoryLabel;
    }
}