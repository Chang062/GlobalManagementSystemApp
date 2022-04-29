namespace GlobalManagementSystemApp
{
    partial class InventoryFrm
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
            this.btAddNewStock = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btDeleteStock = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.gradientPanel2 = new GlobalManagementSystemApp.gradientPanel();
            this.gvInventory = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new GlobalManagementSystemApp.gradientPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbInventory = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddNewStock
            // 
            this.btAddNewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btAddNewStock.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAddNewStock.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAddNewStock.Location = new System.Drawing.Point(935, 371);
            this.btAddNewStock.Name = "btAddNewStock";
            this.btAddNewStock.Size = new System.Drawing.Size(156, 52);
            this.btAddNewStock.TabIndex = 2;
            this.btAddNewStock.Text = "Add Stock";
            this.btAddNewStock.UseVisualStyleBackColor = false;
            this.btAddNewStock.Click += new System.EventHandler(this.btAddNewStock_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnUpdateStock.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateStock.Location = new System.Drawing.Point(1155, 368);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(161, 55);
            this.btnUpdateStock.TabIndex = 2;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btDeleteStock
            // 
            this.btDeleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btDeleteStock.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDeleteStock.Location = new System.Drawing.Point(935, 497);
            this.btDeleteStock.Name = "btDeleteStock";
            this.btDeleteStock.Size = new System.Drawing.Size(156, 53);
            this.btDeleteStock.TabIndex = 2;
            this.btDeleteStock.Text = "Delete Stock";
            this.btDeleteStock.UseVisualStyleBackColor = false;
            this.btDeleteStock.Click += new System.EventHandler(this.btDeleteStock_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btRefresh.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRefresh.Location = new System.Drawing.Point(1155, 497);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(156, 53);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(946, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find Product by Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(946, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Find Product by name";
            // 
            // cbProd
            // 
            this.cbProd.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(950, 283);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(355, 31);
            this.cbProd.TabIndex = 5;
            this.cbProd.SelectedIndexChanged += new System.EventHandler(this.cbProd_SelectedIndexChanged);
            this.cbProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbProd_MouseClick);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.gvInventory);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 100);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(911, 621);
            this.gradientPanel2.TabIndex = 1;
            this.gradientPanel2.TopColor = System.Drawing.Color.Empty;
            // 
            // gvInventory
            // 
            this.gvInventory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventory.Location = new System.Drawing.Point(0, 3);
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.RowHeadersWidth = 51;
            this.gvInventory.RowTemplate.Height = 24;
            this.gvInventory.Size = new System.Drawing.Size(1025, 700);
            this.gvInventory.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.gradientPanel1.Controls.Add(this.pictureBox8);
            this.gradientPanel1.Controls.Add(this.lbInventory);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1348, 100);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::GlobalManagementSystemApp.Properties.Resources.inventory21;
            this.pictureBox8.Location = new System.Drawing.Point(22, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(91, 94);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.BackColor = System.Drawing.Color.Transparent;
            this.lbInventory.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbInventory.Location = new System.Drawing.Point(500, 23);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(354, 53);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.Text = "MANAGE INVENTORY";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(950, 170);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(355, 31);
            this.cbSuppliers.TabIndex = 5;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            this.cbSuppliers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSuppliers_MouseClick);
            // 
            // InventoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GlobalManagementSystemApp.Properties.Resources.inventoryimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDeleteStock);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btAddNewStock);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InventoryFrm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryFrm_Load);
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gradientPanel gradientPanel1;
        private gradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridView gvInventory;
        private System.Windows.Forms.Button btAddNewStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btDeleteStock;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.ComboBox cbSuppliers;
    }
}