namespace GlobalManagementSystemApp
{
    partial class Transactions
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
            this.gvTransactions = new System.Windows.Forms.DataGridView();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.gradientPanel2 = new GlobalManagementSystemApp.gradientPanel();
            this.gradientPanel1 = new GlobalManagementSystemApp.gradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalTransactions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemsSold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactions)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvTransactions
            // 
            this.gvTransactions.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTransactions.Location = new System.Drawing.Point(0, 229);
            this.gvTransactions.Name = "gvTransactions";
            this.gvTransactions.RowHeadersWidth = 51;
            this.gvTransactions.RowTemplate.Height = 24;
            this.gvTransactions.Size = new System.Drawing.Size(1204, 394);
            this.gvTransactions.TabIndex = 2;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchName.Location = new System.Drawing.Point(228, 166);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(289, 30);
            this.tbSearchName.TabIndex = 3;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Turquoise;
            this.btRefresh.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(1077, 172);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(91, 30);
            this.btRefresh.TabIndex = 4;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbProd
            // 
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(756, 172);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(250, 24);
            this.cbProd.TabIndex = 5;
            this.cbProd.SelectedIndexChanged += new System.EventHandler(this.cbProd_SelectedIndexChanged);
            this.cbProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbProd_MouseClick);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.gradientPanel1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1204, 100);
            this.gradientPanel2.TabIndex = 1;
            this.gradientPanel2.TopColor = System.Drawing.Color.Empty;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 250F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.RoyalBlue;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.ForeColor = System.Drawing.Color.Turquoise;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1204, 100);
            this.gradientPanel1.TabIndex = 4;
            this.gradientPanel1.TopColor = System.Drawing.Color.Turquoise;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(437, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACTIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find by Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Find by Product Name";
            // 
            // tbTotalTransactions
            // 
            this.tbTotalTransactions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbTotalTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalTransactions.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalTransactions.Location = new System.Drawing.Point(184, 623);
            this.tbTotalTransactions.Name = "tbTotalTransactions";
            this.tbTotalTransactions.Size = new System.Drawing.Size(100, 25);
            this.tbTotalTransactions.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Transactions:";
            // 
            // tbItemsSold
            // 
            this.tbItemsSold.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbItemsSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItemsSold.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemsSold.Location = new System.Drawing.Point(1098, 625);
            this.tbItemsSold.Name = "tbItemsSold";
            this.tbItemsSold.Size = new System.Drawing.Size(100, 25);
            this.tbItemsSold.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(926, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Items Sold:";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 656);
            this.Controls.Add(this.tbItemsSold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTotalTransactions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.gvTransactions);
            this.Controls.Add(this.gradientPanel2);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactions)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridView gvTransactions;
        private gradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemsSold;
        private System.Windows.Forms.Label label5;
    }
}