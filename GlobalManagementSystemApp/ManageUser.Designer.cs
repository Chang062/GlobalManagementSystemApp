namespace GlobalManagementSystemApp
{
    partial class ManageUser
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
            this.btAddUser = new System.Windows.Forms.Button();
            this.btResetPassword = new System.Windows.Forms.Button();
            this.btActivateDeactivate = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gvManageUser = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new GlobalManagementSystemApp.gradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageUser)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddUser
            // 
            this.btAddUser.BackColor = System.Drawing.Color.Turquoise;
            this.btAddUser.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddUser.Location = new System.Drawing.Point(672, 128);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(184, 59);
            this.btAddUser.TabIndex = 0;
            this.btAddUser.Text = "Add User";
            this.btAddUser.UseVisualStyleBackColor = false;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btResetPassword
            // 
            this.btResetPassword.BackColor = System.Drawing.Color.Turquoise;
            this.btResetPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetPassword.Location = new System.Drawing.Point(672, 241);
            this.btResetPassword.Name = "btResetPassword";
            this.btResetPassword.Size = new System.Drawing.Size(184, 59);
            this.btResetPassword.TabIndex = 0;
            this.btResetPassword.Text = "Reset Password";
            this.btResetPassword.UseVisualStyleBackColor = false;
            this.btResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // btActivateDeactivate
            // 
            this.btActivateDeactivate.BackColor = System.Drawing.Color.Turquoise;
            this.btActivateDeactivate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActivateDeactivate.Location = new System.Drawing.Point(672, 358);
            this.btActivateDeactivate.Name = "btActivateDeactivate";
            this.btActivateDeactivate.Size = new System.Drawing.Size(184, 59);
            this.btActivateDeactivate.TabIndex = 0;
            this.btActivateDeactivate.Text = "Activate/Deactivate";
            this.btActivateDeactivate.UseVisualStyleBackColor = false;
            this.btActivateDeactivate.Click += new System.EventHandler(this.btActivateDeactivate_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Turquoise;
            this.btRefresh.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(672, 464);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(184, 59);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // gvManageUser
            // 
            this.gvManageUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManageUser.Location = new System.Drawing.Point(57, 128);
            this.gvManageUser.Name = "gvManageUser";
            this.gvManageUser.RowHeadersWidth = 51;
            this.gvManageUser.RowTemplate.Height = 24;
            this.gvManageUser.Size = new System.Drawing.Size(521, 395);
            this.gvManageUser.TabIndex = 1;
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
            this.gradientPanel1.Size = new System.Drawing.Size(960, 100);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.Turquoise;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(333, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE USERS";
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.gvManageUser);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btActivateDeactivate);
            this.Controls.Add(this.btResetPassword);
            this.Controls.Add(this.btAddUser);
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageUser)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btResetPassword;
        private System.Windows.Forms.Button btActivateDeactivate;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridView gvManageUser;
        private gradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
    }
}