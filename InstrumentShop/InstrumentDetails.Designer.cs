namespace InstrumentShop
{
    partial class InstrumentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrumentDetails));
            this.insNameTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.insQuantityTxtB = new System.Windows.Forms.TextBox();
            this.insBrandCOB = new System.Windows.Forms.ComboBox();
            this.insPriceTxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insCategoryCOB = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.filterByBrandCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.insDetailsDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insDetailsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // insNameTxtB
            // 
            this.insNameTxtB.Location = new System.Drawing.Point(12, 59);
            this.insNameTxtB.Name = "insNameTxtB";
            this.insNameTxtB.Size = new System.Drawing.Size(203, 26);
            this.insNameTxtB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instrument name";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Location = new System.Drawing.Point(18, 293);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 48);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // insQuantityTxtB
            // 
            this.insQuantityTxtB.Location = new System.Drawing.Point(6, 145);
            this.insQuantityTxtB.Name = "insQuantityTxtB";
            this.insQuantityTxtB.Size = new System.Drawing.Size(203, 26);
            this.insQuantityTxtB.TabIndex = 4;
            // 
            // insBrandCOB
            // 
            this.insBrandCOB.FormattingEnabled = true;
            this.insBrandCOB.Items.AddRange(new object[] {
            "Fender",
            "Gibson",
            "Ibanez",
            "Yamaha",
            "Korg",
            "Vox",
            "Marshall",
            "JBL"});
            this.insBrandCOB.Location = new System.Drawing.Point(256, 57);
            this.insBrandCOB.Name = "insBrandCOB";
            this.insBrandCOB.Size = new System.Drawing.Size(209, 28);
            this.insBrandCOB.TabIndex = 5;
            // 
            // insPriceTxtB
            // 
            this.insPriceTxtB.Location = new System.Drawing.Point(262, 145);
            this.insPriceTxtB.Name = "insPriceTxtB";
            this.insPriceTxtB.Size = new System.Drawing.Size(203, 26);
            this.insPriceTxtB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(256, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category";
            // 
            // insCategoryCOB
            // 
            this.insCategoryCOB.FormattingEnabled = true;
            this.insCategoryCOB.Items.AddRange(new object[] {
            "Strings",
            "Keyboard",
            "Accesoriess",
            "Percussion"});
            this.insCategoryCOB.Location = new System.Drawing.Point(12, 240);
            this.insCategoryCOB.Name = "insCategoryCOB";
            this.insCategoryCOB.Size = new System.Drawing.Size(209, 28);
            this.insCategoryCOB.TabIndex = 11;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.Location = new System.Drawing.Point(145, 293);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(97, 48);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Location = new System.Drawing.Point(273, 293);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 48);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Location = new System.Drawing.Point(124, 373);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 48);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // filterByBrandCB
            // 
            this.filterByBrandCB.FormattingEnabled = true;
            this.filterByBrandCB.Items.AddRange(new object[] {
            "Fender",
            "Gibson",
            "Ibanez",
            "Yamaha",
            "Korg",
            "Vox",
            "Marshall",
            "JBL"});
            this.filterByBrandCB.Location = new System.Drawing.Point(612, 176);
            this.filterByBrandCB.Name = "filterByBrandCB";
            this.filterByBrandCB.Size = new System.Drawing.Size(209, 28);
            this.filterByBrandCB.TabIndex = 16;
            this.filterByBrandCB.SelectedIndexChanged += new System.EventHandler(this.filterByBrandCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(606, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filter by brand";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetButton.Location = new System.Drawing.Point(848, 156);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 48);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // insDetailsDGV
            // 
            this.insDetailsDGV.CausesValidation = false;
            this.insDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insDetailsDGV.Location = new System.Drawing.Point(461, 210);
            this.insDetailsDGV.Name = "insDetailsDGV";
            this.insDetailsDGV.RowHeadersVisible = false;
            this.insDetailsDGV.RowHeadersWidth = 62;
            this.insDetailsDGV.RowTemplate.Height = 28;
            this.insDetailsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.insDetailsDGV.Size = new System.Drawing.Size(902, 459);
            this.insDetailsDGV.TabIndex = 18;
            this.insDetailsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.insDetailsDGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1375, 741);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(842, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add instrument to the Inventory";
            // 
            // InstrumentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 741);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.insDetailsDGV);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.filterByBrandCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.insCategoryCOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insPriceTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insBrandCOB);
            this.Controls.Add(this.insQuantityTxtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insNameTxtB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InstrumentDetails";
            this.Text = "Instrument Details";
            this.Load += new System.EventHandler(this.InstrumentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insDetailsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insNameTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insQuantityTxtB;
        private System.Windows.Forms.ComboBox insBrandCOB;
        private System.Windows.Forms.TextBox insPriceTxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox insCategoryCOB;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox filterByBrandCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView insDetailsDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}

