namespace Task_2
{
    partial class Form1
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
            this.calcProfitButton = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.textbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // calcProfitButton
            // 
            this.calcProfitButton.Location = new System.Drawing.Point(88, 61);
            this.calcProfitButton.Name = "calcProfitButton";
            this.calcProfitButton.Size = new System.Drawing.Size(200, 50);
            this.calcProfitButton.TabIndex = 0;
            this.calcProfitButton.Text = "Calculate Profit";
            this.calcProfitButton.UseVisualStyleBackColor = true;
            this.calcProfitButton.Click += new System.EventHandler(this.calcProfitButton_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textbook,
            this.subject,
            this.purchaser,
            this.seller,
            this.purchasePrice,
            this.salePrice,
            this.profit});
            this.dgvSales.Location = new System.Drawing.Point(88, 161);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 72;
            this.dgvSales.RowTemplate.Height = 31;
            this.dgvSales.Size = new System.Drawing.Size(1709, 532);
            this.dgvSales.TabIndex = 1;
            // 
            // textbook
            // 
            this.textbook.HeaderText = "Textbook";
            this.textbook.MinimumWidth = 9;
            this.textbook.Name = "textbook";
            this.textbook.Width = 175;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 9;
            this.subject.Name = "subject";
            this.subject.Width = 175;
            // 
            // purchaser
            // 
            this.purchaser.HeaderText = "Purchaser";
            this.purchaser.MinimumWidth = 9;
            this.purchaser.Name = "purchaser";
            this.purchaser.Width = 175;
            // 
            // seller
            // 
            this.seller.HeaderText = "Seller";
            this.seller.MinimumWidth = 9;
            this.seller.Name = "seller";
            this.seller.Width = 175;
            // 
            // purchasePrice
            // 
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.MinimumWidth = 9;
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Width = 175;
            // 
            // salePrice
            // 
            this.salePrice.HeaderText = "Sale Price";
            this.salePrice.MinimumWidth = 9;
            this.salePrice.Name = "salePrice";
            this.salePrice.Width = 175;
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.MinimumWidth = 9;
            this.profit.Name = "profit";
            this.profit.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 897);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.calcProfitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcProfitButton;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
    }
}

