namespace GlobalManagementSystemApp
{
    partial class Products
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
            this.gradientPanel2 = new GlobalManagementSystemApp.gradientPanel();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new GlobalManagementSystemApp.gradientPanel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BackgroundImage = global::GlobalManagementSystemApp.Properties.Resources.inventoryimg;
            this.gradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel2.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.btDel);
            this.gradientPanel2.Controls.Add(this.btUpdate);
            this.gradientPanel2.Controls.Add(this.btRefresh);
            this.gradientPanel2.Controls.Add(this.btAdd);
            this.gradientPanel2.Controls.Add(this.gvProducts);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 100);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1062, 573);
            this.gradientPanel2.TabIndex = 3;
            this.gradientPanel2.TopColor = System.Drawing.Color.Empty;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Turquoise;
            this.btDel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(668, 505);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(147, 59);
            this.btDel.TabIndex = 4;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.btUpdate.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(485, 505);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(140, 59);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btRefresh.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRefresh.Location = new System.Drawing.Point(875, 6);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(121, 44);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btAdd.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAdd.Location = new System.Drawing.Point(280, 505);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(135, 59);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gvProducts
            // 
            this.gvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(65, 58);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowHeadersWidth = 51;
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.Size = new System.Drawing.Size(931, 434);
            this.gvProducts.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 25F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.gradientPanel1.Controls.Add(this.lbProducts);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1062, 100);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.RoyalBlue;
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.BackColor = System.Drawing.Color.Transparent;
            this.lbProducts.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbProducts.Location = new System.Drawing.Point(317, 13);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(489, 75);
            this.lbProducts.TabIndex = 2;
            this.lbProducts.Text = "MANAGE PRODUCTS";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private gradientPanel gradientPanel1;
        private System.Windows.Forms.Label lbProducts;
        private gradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDel;
    }
}