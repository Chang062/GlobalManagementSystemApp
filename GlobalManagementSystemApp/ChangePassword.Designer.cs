namespace GlobalManagementSystemApp
{
    partial class ChangePassword
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
            this.tbDefaultPw = new System.Windows.Forms.TextBox();
            this.tbNewPw = new System.Windows.Forms.TextBox();
            this.tbConfirmPw = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btResetPw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDefaultPw
            // 
            this.tbDefaultPw.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefaultPw.Location = new System.Drawing.Point(262, 112);
            this.tbDefaultPw.Name = "tbDefaultPw";
            this.tbDefaultPw.PasswordChar = '*';
            this.tbDefaultPw.Size = new System.Drawing.Size(290, 30);
            this.tbDefaultPw.TabIndex = 0;
            // 
            // tbNewPw
            // 
            this.tbNewPw.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPw.Location = new System.Drawing.Point(262, 193);
            this.tbNewPw.Name = "tbNewPw";
            this.tbNewPw.PasswordChar = '*';
            this.tbNewPw.Size = new System.Drawing.Size(290, 30);
            this.tbNewPw.TabIndex = 0;
            // 
            // tbConfirmPw
            // 
            this.tbConfirmPw.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPw.Location = new System.Drawing.Point(262, 274);
            this.tbConfirmPw.Name = "tbConfirmPw";
            this.tbConfirmPw.PasswordChar = '*';
            this.tbConfirmPw.Size = new System.Drawing.Size(290, 30);
            this.tbConfirmPw.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.btCancel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(170, 393);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(103, 39);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHANGE PASSWORD";
            // 
            // btResetPw
            // 
            this.btResetPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.btResetPw.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetPw.Location = new System.Drawing.Point(372, 393);
            this.btResetPw.Name = "btResetPw";
            this.btResetPw.Size = new System.Drawing.Size(157, 39);
            this.btResetPw.TabIndex = 1;
            this.btResetPw.Text = "Reset Password";
            this.btResetPw.UseVisualStyleBackColor = false;
            this.btResetPw.Click += new System.EventHandler(this.btResetPw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GlobalManagementSystemApp.Properties.Resources.GMSLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(687, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btResetPw);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbConfirmPw);
            this.Controls.Add(this.tbNewPw);
            this.Controls.Add(this.tbDefaultPw);
            this.DoubleBuffered = true;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDefaultPw;
        private System.Windows.Forms.TextBox tbNewPw;
        private System.Windows.Forms.TextBox tbConfirmPw;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btResetPw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}