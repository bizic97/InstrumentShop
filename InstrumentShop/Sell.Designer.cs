namespace InstrumentShop
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.insPriceTxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insQuantityTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insNameTxtB = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.insSellDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.amountTotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printPreviewBill = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.insSellDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // insPriceTxtB
            // 
            this.insPriceTxtB.Location = new System.Drawing.Point(244, 55);
            this.insPriceTxtB.Name = "insPriceTxtB";
            this.insPriceTxtB.Size = new System.Drawing.Size(203, 26);
            this.insPriceTxtB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(238, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // insQuantityTxtB
            // 
            this.insQuantityTxtB.Location = new System.Drawing.Point(6, 143);
            this.insQuantityTxtB.Name = "insQuantityTxtB";
            this.insQuantityTxtB.Size = new System.Drawing.Size(203, 26);
            this.insQuantityTxtB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Instrument name";
            // 
            // insNameTxtB
            // 
            this.insNameTxtB.Location = new System.Drawing.Point(12, 55);
            this.insNameTxtB.Name = "insNameTxtB";
            this.insNameTxtB.Size = new System.Drawing.Size(203, 26);
            this.insNameTxtB.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Location = new System.Drawing.Point(16, 207);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(135, 48);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printButton.Location = new System.Drawing.Point(777, 547);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(97, 48);
            this.printButton.TabIndex = 23;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Location = new System.Drawing.Point(759, 639);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 57);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // insSellDGV
            // 
            this.insSellDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.insSellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insSellDGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.insSellDGV.Location = new System.Drawing.Point(18, 352);
            this.insSellDGV.Name = "insSellDGV";
            this.insSellDGV.RowHeadersVisible = false;
            this.insSellDGV.RowHeadersWidth = 62;
            this.insSellDGV.RowTemplate.Height = 28;
            this.insSellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.insSellDGV.Size = new System.Drawing.Size(380, 319);
            this.insSellDGV.TabIndex = 25;
            this.insSellDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.insSellDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(793, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bill";
            // 
            // billDGV
            // 
            this.billDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.billDGV.Location = new System.Drawing.Point(474, 85);
            this.billDGV.Name = "billDGV";
            this.billDGV.RowHeadersVisible = false;
            this.billDGV.RowHeadersWidth = 20;
            this.billDGV.RowTemplate.Height = 28;
            this.billDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDGV.Size = new System.Drawing.Size(665, 377);
            this.billDGV.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 741);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // resButton
            // 
            this.resButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resButton.Location = new System.Drawing.Point(282, 207);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(135, 48);
            this.resButton.TabIndex = 29;
            this.resButton.Text = "Reset";
            this.resButton.UseVisualStyleBackColor = false;
            this.resButton.Click += new System.EventHandler(this.resButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.amountLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amountLabel.Location = new System.Drawing.Point(699, 494);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(102, 33);
            this.amountLabel.TabIndex = 30;
            this.amountLabel.Text = "Amount";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.currencyLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currencyLabel.Location = new System.Drawing.Point(807, 494);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(29, 33);
            this.currencyLabel.TabIndex = 31;
            this.currencyLabel.Text = "$";
            // 
            // amountTotalLabel
            // 
            this.amountTotalLabel.AutoSize = true;
            this.amountTotalLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.amountTotalLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amountTotalLabel.Location = new System.Drawing.Point(845, 494);
            this.amountTotalLabel.Name = "amountTotalLabel";
            this.amountTotalLabel.Size = new System.Drawing.Size(29, 33);
            this.amountTotalLabel.TabIndex = 32;
            this.amountTotalLabel.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(137, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 33);
            this.label5.TabIndex = 33;
            this.label5.Text = "Instrument";
            // 
            // printPreviewBill
            // 
            this.printPreviewBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewBill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewBill.Document = this.printDocumentBill;
            this.printPreviewBill.Enabled = true;
            this.printPreviewBill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewBill.Icon")));
            this.printPreviewBill.Name = "printPreviewBill";
            this.printPreviewBill.Visible = false;
            // 
            // printDocumentBill
            // 
            this.printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBill_PrintPage);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 741);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountTotalLabel);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.resButton);
            this.Controls.Add(this.billDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insSellDGV);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.insPriceTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insQuantityTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insNameTxtB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sell";
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insSellDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insPriceTxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insQuantityTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insNameTxtB;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView insSellDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label amountTotalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewBill;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}