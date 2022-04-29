namespace GlobalManagementSystemApp
{
    partial class InventoryFrmCrud
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
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbProdName = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbAddUpdateTitle = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInvId = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(312, 183);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(324, 34);
            this.cbSupplier.TabIndex = 0;
            // 
            // cbProdName
            // 
            this.cbProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdName.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdName.FormattingEnabled = true;
            this.cbProdName.Location = new System.Drawing.Point(314, 94);
            this.cbProdName.Name = "cbProdName";
            this.cbProdName.Size = new System.Drawing.Size(324, 34);
            this.cbProdName.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(138)))));
            this.btSave.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(516, 360);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(226, 62);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbAddUpdateTitle
            // 
            this.lbAddUpdateTitle.AutoSize = true;
            this.lbAddUpdateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbAddUpdateTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddUpdateTitle.Location = new System.Drawing.Point(282, 13);
            this.lbAddUpdateTitle.Name = "lbAddUpdateTitle";
            this.lbAddUpdateTitle.Size = new System.Drawing.Size(0, 37);
            this.lbAddUpdateTitle.TabIndex = 3;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(315, 269);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(321, 34);
            this.tbQuantity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // lbInvId
            // 
            this.lbInvId.AutoSize = true;
            this.lbInvId.Location = new System.Drawing.Point(13, 13);
            this.lbInvId.Name = "lbInvId";
            this.lbInvId.Size = new System.Drawing.Size(75, 16);
            this.lbInvId.TabIndex = 6;
            this.lbInvId.Text = "Inventory Id";
            this.lbInvId.Visible = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(138)))));
            this.btCancel.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(245, 360);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(226, 62);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // InventoryFrmCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GlobalManagementSystemApp.Properties.Resources.inventory2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbInvId);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAddUpdateTitle);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbProdName);
            this.Controls.Add(this.cbSupplier);
            this.DoubleBuffered = true;
            this.Name = "InventoryFrmCrud";
            this.Text = "InventoryFrmCrud";
           // this.Load += new System.EventHandler(this.InventoryFrmCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbProdName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbAddUpdateTitle;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInvId;
        private System.Windows.Forms.Button btCancel;
    }
}