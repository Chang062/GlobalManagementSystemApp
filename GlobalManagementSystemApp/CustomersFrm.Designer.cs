namespace GlobalManagementSystemApp
{
    partial class CustomersFrm
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
            this.gvCustomers = new System.Windows.Forms.DataGridView();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbFindByName = new System.Windows.Forms.TextBox();
            this.cbFindbyCustId = new System.Windows.Forms.ComboBox();
            this.cbFindByParish = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GlobalManagementSystemApp.gradientPanel();
            this.gradientPanel2 = new GlobalManagementSystemApp.gradientPanel();
            this.lbManageCustomers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvCustomers
            // 
            this.gvCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomers.Location = new System.Drawing.Point(92, 153);
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.RowHeadersWidth = 51;
            this.gvCustomers.RowTemplate.Height = 24;
            this.gvCustomers.Size = new System.Drawing.Size(1165, 417);
            this.gvCustomers.TabIndex = 1;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Turquoise;
            this.btRefresh.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(963, 736);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(184, 59);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Turquoise;
            this.btDelete.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(706, 736);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(184, 59);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Turquoise;
            this.btEdit.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(449, 736);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(184, 59);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btAdd.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(183, 736);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(184, 59);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbFindByName
            // 
            this.tbFindByName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindByName.Location = new System.Drawing.Point(101, 643);
            this.tbFindByName.Name = "tbFindByName";
            this.tbFindByName.Size = new System.Drawing.Size(323, 30);
            this.tbFindByName.TabIndex = 6;
            this.tbFindByName.TextChanged += new System.EventHandler(this.tbFindByName_TextChanged);
            // 
            // cbFindbyCustId
            // 
            this.cbFindbyCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindbyCustId.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindbyCustId.FormattingEnabled = true;
            this.cbFindbyCustId.Location = new System.Drawing.Point(496, 643);
            this.cbFindbyCustId.Name = "cbFindbyCustId";
            this.cbFindbyCustId.Size = new System.Drawing.Size(323, 31);
            this.cbFindbyCustId.TabIndex = 7;
            this.cbFindbyCustId.SelectedIndexChanged += new System.EventHandler(this.cbFindbyCustId_SelectedIndexChanged);
            this.cbFindbyCustId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbFindbyCustId_MouseClick);
            // 
            // cbFindByParish
            // 
            this.cbFindByParish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindByParish.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindByParish.FormattingEnabled = true;
            this.cbFindByParish.Location = new System.Drawing.Point(953, 643);
            this.cbFindByParish.Name = "cbFindByParish";
            this.cbFindByParish.Size = new System.Drawing.Size(323, 31);
            this.cbFindByParish.TabIndex = 7;
            this.cbFindByParish.SelectedIndexChanged += new System.EventHandler(this.cbFindByParish_SelectedIndexChanged);
            this.cbFindByParish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbFindByParish_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find By Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Find By Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(959, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Find By Parish";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1348, 100);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 250F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.RoyalBlue;
            this.gradientPanel2.Controls.Add(this.lbManageCustomers);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.ForeColor = System.Drawing.Color.Turquoise;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1348, 100);
            this.gradientPanel2.TabIndex = 3;
            this.gradientPanel2.TopColor = System.Drawing.Color.Turquoise;
            // 
            // lbManageCustomers
            // 
            this.lbManageCustomers.AutoSize = true;
            this.lbManageCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lbManageCustomers.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageCustomers.ForeColor = System.Drawing.Color.Honeydew;
            this.lbManageCustomers.Location = new System.Drawing.Point(399, 22);
            this.lbManageCustomers.Name = "lbManageCustomers";
            this.lbManageCustomers.Size = new System.Drawing.Size(411, 59);
            this.lbManageCustomers.TabIndex = 0;
            this.lbManageCustomers.Text = "MANAGE CUSTOMERS";
            // 
            // CustomersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1348, 847);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFindByParish);
            this.Controls.Add(this.cbFindbyCustId);
            this.Controls.Add(this.tbFindByName);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gvCustomers);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "CustomersFrm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gradientPanel gradientPanel1;
        private System.Windows.Forms.DataGridView gvCustomers;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private gradientPanel gradientPanel2;
        private System.Windows.Forms.Label lbManageCustomers;
        private System.Windows.Forms.TextBox tbFindByName;
        private System.Windows.Forms.ComboBox cbFindbyCustId;
        private System.Windows.Forms.ComboBox cbFindByParish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}