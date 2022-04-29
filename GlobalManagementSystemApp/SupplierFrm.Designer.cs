namespace GlobalManagementSystemApp
{
    partial class SupplierFrm
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
            this.gpRightCrud = new GlobalManagementSystemApp.gradientPanel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gpAddEdit = new GlobalManagementSystemApp.gradientPanel();
            this.cbParish = new System.Windows.Forms.ComboBox();
            this.lbSupId = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbParish = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gpLeft = new GlobalManagementSystemApp.gradientPanel();
            this.gvSupplier = new System.Windows.Forms.DataGridView();
            this.gpTop = new GlobalManagementSystemApp.gradientPanel();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.gpRightCrud.SuspendLayout();
            this.gpAddEdit.SuspendLayout();
            this.gpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.gpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpRightCrud
            // 
            this.gpRightCrud.Angle = 0F;
            this.gpRightCrud.BackgroundImage = global::GlobalManagementSystemApp.Properties.Resources.Supplier1;
            this.gpRightCrud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpRightCrud.BottomColor = System.Drawing.Color.Empty;
            this.gpRightCrud.Controls.Add(this.btDelete);
            this.gpRightCrud.Controls.Add(this.btUpdate);
            this.gpRightCrud.Controls.Add(this.btAdd);
            this.gpRightCrud.Controls.Add(this.gpAddEdit);
            this.gpRightCrud.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpRightCrud.Location = new System.Drawing.Point(825, 100);
            this.gpRightCrud.Name = "gpRightCrud";
            this.gpRightCrud.Size = new System.Drawing.Size(540, 573);
            this.gpRightCrud.TabIndex = 0;
            this.gpRightCrud.TopColor = System.Drawing.Color.Empty;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Turquoise;
            this.btDelete.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(393, 19);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(97, 52);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.btUpdate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(225, 19);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(97, 52);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btAdd.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(71, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 52);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gpAddEdit
            // 
            this.gpAddEdit.Angle = 0F;
            this.gpAddEdit.BottomColor = System.Drawing.Color.Empty;
            this.gpAddEdit.Controls.Add(this.cbParish);
            this.gpAddEdit.Controls.Add(this.lbSupId);
            this.gpAddEdit.Controls.Add(this.btCancel);
            this.gpAddEdit.Controls.Add(this.btSave);
            this.gpAddEdit.Controls.Add(this.label4);
            this.gpAddEdit.Controls.Add(this.label1);
            this.gpAddEdit.Controls.Add(this.lbParish);
            this.gpAddEdit.Controls.Add(this.label3);
            this.gpAddEdit.Controls.Add(this.label2);
            this.gpAddEdit.Controls.Add(this.tbContact);
            this.gpAddEdit.Controls.Add(this.tbEmail);
            this.gpAddEdit.Controls.Add(this.tbAddress);
            this.gpAddEdit.Controls.Add(this.tbName);
            this.gpAddEdit.Location = new System.Drawing.Point(3, 77);
            this.gpAddEdit.Name = "gpAddEdit";
            this.gpAddEdit.Size = new System.Drawing.Size(534, 496);
            this.gpAddEdit.TabIndex = 1;
            this.gpAddEdit.TopColor = System.Drawing.Color.Empty;
            this.gpAddEdit.Visible = false;
            // 
            // cbParish
            // 
            this.cbParish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParish.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParish.FormattingEnabled = true;
            this.cbParish.Location = new System.Drawing.Point(125, 250);
            this.cbParish.Name = "cbParish";
            this.cbParish.Size = new System.Drawing.Size(362, 31);
            this.cbParish.TabIndex = 4;
            // 
            // lbSupId
            // 
            this.lbSupId.AutoSize = true;
            this.lbSupId.Location = new System.Drawing.Point(35, 166);
            this.lbSupId.Name = "lbSupId";
            this.lbSupId.Size = new System.Drawing.Size(44, 16);
            this.lbSupId.TabIndex = 3;
            this.lbSupId.Text = "label5";
            this.lbSupId.Visible = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btCancel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(269, 450);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(97, 34);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btSave.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(390, 450);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(97, 34);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // lbParish
            // 
            this.lbParish.AutoSize = true;
            this.lbParish.BackColor = System.Drawing.Color.Transparent;
            this.lbParish.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParish.Location = new System.Drawing.Point(13, 251);
            this.lbParish.Name = "lbParish";
            this.lbParish.Size = new System.Drawing.Size(66, 23);
            this.lbParish.TabIndex = 2;
            this.lbParish.Text = "Parish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(125, 382);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(362, 30);
            this.tbContact.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(125, 314);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(362, 30);
            this.tbEmail.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(125, 110);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(362, 122);
            this.tbAddress.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(125, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(362, 30);
            this.tbName.TabIndex = 0;
            // 
            // gpLeft
            // 
            this.gpLeft.Angle = 0F;
            this.gpLeft.BottomColor = System.Drawing.Color.Empty;
            this.gpLeft.Controls.Add(this.gvSupplier);
            this.gpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpLeft.Location = new System.Drawing.Point(0, 100);
            this.gpLeft.Name = "gpLeft";
            this.gpLeft.Size = new System.Drawing.Size(828, 573);
            this.gpLeft.TabIndex = 0;
            this.gpLeft.TopColor = System.Drawing.Color.Empty;
            // 
            // gvSupplier
            // 
            this.gvSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplier.Location = new System.Drawing.Point(0, 0);
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.RowHeadersWidth = 51;
            this.gvSupplier.RowTemplate.Height = 24;
            this.gvSupplier.Size = new System.Drawing.Size(825, 573);
            this.gvSupplier.TabIndex = 0;
            // 
            // gpTop
            // 
            this.gpTop.Angle = 50F;
            this.gpTop.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.gpTop.Controls.Add(this.lbSupplier);
            this.gpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpTop.Location = new System.Drawing.Point(0, 0);
            this.gpTop.Name = "gpTop";
            this.gpTop.Size = new System.Drawing.Size(1365, 100);
            this.gpTop.TabIndex = 0;
            this.gpTop.TopColor = System.Drawing.Color.RoyalBlue;
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lbSupplier.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSupplier.Location = new System.Drawing.Point(461, 9);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(499, 75);
            this.lbSupplier.TabIndex = 0;
            this.lbSupplier.Text = "MANAGE SUPPLIERS\'";
            // 
            // SupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 673);
            this.Controls.Add(this.gpRightCrud);
            this.Controls.Add(this.gpLeft);
            this.Controls.Add(this.gpTop);
            this.Name = "SupplierFrm";
            this.Text = "SupplierFrm";
            this.Load += new System.EventHandler(this.SupplierFrm_Load);
            this.gpRightCrud.ResumeLayout(false);
            this.gpAddEdit.ResumeLayout(false);
            this.gpAddEdit.PerformLayout();
            this.gpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.gpTop.ResumeLayout(false);
            this.gpTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private gradientPanel gpTop;
        private gradientPanel gpRightCrud;
        private gradientPanel gpLeft;
        private System.Windows.Forms.DataGridView gvSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbSupplier;
        private gradientPanel gpAddEdit;
        private System.Windows.Forms.Label lbSupId;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbParish;
        private System.Windows.Forms.Label lbParish;
    }
}