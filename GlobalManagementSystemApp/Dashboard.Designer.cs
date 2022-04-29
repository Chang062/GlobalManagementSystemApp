namespace GlobalManagementSystemApp
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.slideShow = new System.Windows.Forms.Timer(this.components);
            this.gpTopPanel = new GlobalManagementSystemApp.gradientPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.pbNotificationIcon = new System.Windows.Forms.PictureBox();
            this.pbMessageIcon = new System.Windows.Forms.PictureBox();
            this.gpLeftPanel = new GlobalManagementSystemApp.gradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbManageUser = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbSalesHistory = new System.Windows.Forms.Label();
            this.lbInventory = new System.Windows.Forms.Label();
            this.pbCompanyLogo = new System.Windows.Forms.PictureBox();
            this.pbLogOut = new System.Windows.Forms.PictureBox();
            this.pbManageUser = new System.Windows.Forms.PictureBox();
            this.pbCustomers = new System.Windows.Forms.PictureBox();
            this.pbInventory = new System.Windows.Forms.PictureBox();
            this.gpCentrePanel = new GlobalManagementSystemApp.gradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lbTotalSupplier = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbTotalCust = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalInv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTotalSales = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.pbSlideShow = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbLogOut2 = new System.Windows.Forms.PictureBox();
            this.gpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageIcon)).BeginInit();
            this.gpLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventory)).BeginInit();
            this.gpCentrePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut2)).BeginInit();
            this.SuspendLayout();
            // 
            // slideShow
            // 
            this.slideShow.Enabled = true;
            this.slideShow.Interval = 4000;
            this.slideShow.Tick += new System.EventHandler(this.slideShow_Tick);
            // 
            // gpTopPanel
            // 
            this.gpTopPanel.Angle = 0F;
            this.gpTopPanel.BottomColor = System.Drawing.Color.RoyalBlue;
            this.gpTopPanel.Controls.Add(this.pictureBox6);
            this.gpTopPanel.Controls.Add(this.lbAccountType);
            this.gpTopPanel.Controls.Add(this.lbUserName);
            this.gpTopPanel.Controls.Add(this.label2);
            this.gpTopPanel.Controls.Add(this.label1);
            this.gpTopPanel.Controls.Add(this.pbuser);
            this.gpTopPanel.Controls.Add(this.pbLogOut);
            this.gpTopPanel.Controls.Add(this.pbNotificationIcon);
            this.gpTopPanel.Controls.Add(this.pbMessageIcon);
            this.gpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpTopPanel.Location = new System.Drawing.Point(266, 60);
            this.gpTopPanel.Name = "gpTopPanel";
            this.gpTopPanel.Size = new System.Drawing.Size(1330, 100);
            this.gpTopPanel.TabIndex = 1;
            this.gpTopPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::GlobalManagementSystemApp.Properties.Resources._26_268998_link_to_manage_travel_problem_solving_skills_icon;
            this.pictureBox6.Location = new System.Drawing.Point(137, 46);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.BackColor = System.Drawing.Color.Transparent;
            this.lbAccountType.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountType.Location = new System.Drawing.Point(1047, 50);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(133, 23);
            this.lbAccountType.TabIndex = 3;
            this.lbAccountType.Text = "Account Type";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(1047, 27);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(111, 23);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Global Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "System";
            // 
            // pbuser
            // 
            this.pbuser.BackColor = System.Drawing.Color.Transparent;
            this.pbuser.Image = global::GlobalManagementSystemApp.Properties.Resources.user;
            this.pbuser.Location = new System.Drawing.Point(947, 12);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(121, 84);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbuser.TabIndex = 0;
            this.pbuser.TabStop = false;
            // 
            // pbNotificationIcon
            // 
            this.pbNotificationIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbNotificationIcon.Image = global::GlobalManagementSystemApp.Properties.Resources.notification1;
            this.pbNotificationIcon.Location = new System.Drawing.Point(815, 27);
            this.pbNotificationIcon.Name = "pbNotificationIcon";
            this.pbNotificationIcon.Size = new System.Drawing.Size(77, 50);
            this.pbNotificationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotificationIcon.TabIndex = 0;
            this.pbNotificationIcon.TabStop = false;
            this.pbNotificationIcon.Click += new System.EventHandler(this.pbNotificationIcon_Click);
            // 
            // pbMessageIcon
            // 
            this.pbMessageIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbMessageIcon.Image = global::GlobalManagementSystemApp.Properties.Resources.Message1;
            this.pbMessageIcon.Location = new System.Drawing.Point(668, 27);
            this.pbMessageIcon.Name = "pbMessageIcon";
            this.pbMessageIcon.Size = new System.Drawing.Size(77, 50);
            this.pbMessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMessageIcon.TabIndex = 0;
            this.pbMessageIcon.TabStop = false;
            this.pbMessageIcon.Click += new System.EventHandler(this.pbMessageIcon_Click);
            // 
            // gpLeftPanel
            // 
            this.gpLeftPanel.Angle = 0F;
            this.gpLeftPanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.gpLeftPanel.Controls.Add(this.label8);
            this.gpLeftPanel.Controls.Add(this.lbManageUser);
            this.gpLeftPanel.Controls.Add(this.lbCustomer);
            this.gpLeftPanel.Controls.Add(this.lbSalesHistory);
            this.gpLeftPanel.Controls.Add(this.lbInventory);
            this.gpLeftPanel.Controls.Add(this.pbCompanyLogo);
            this.gpLeftPanel.Controls.Add(this.pbLogOut2);
            this.gpLeftPanel.Controls.Add(this.pbManageUser);
            this.gpLeftPanel.Controls.Add(this.pbCustomers);
            this.gpLeftPanel.Controls.Add(this.pbInventory);
            this.gpLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpLeftPanel.Location = new System.Drawing.Point(20, 60);
            this.gpLeftPanel.Name = "gpLeftPanel";
            this.gpLeftPanel.Size = new System.Drawing.Size(246, 858);
            this.gpLeftPanel.TabIndex = 0;
            this.gpLeftPanel.TopColor = System.Drawing.Color.RoyalBlue;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 805);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Logout";
            // 
            // lbManageUser
            // 
            this.lbManageUser.AutoSize = true;
            this.lbManageUser.BackColor = System.Drawing.Color.Transparent;
            this.lbManageUser.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageUser.Location = new System.Drawing.Point(26, 662);
            this.lbManageUser.Name = "lbManageUser";
            this.lbManageUser.Size = new System.Drawing.Size(164, 32);
            this.lbManageUser.TabIndex = 3;
            this.lbManageUser.Text = "Manage User";
            this.lbManageUser.Click += new System.EventHandler(this.lbManageUser_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomer.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(10, 508);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(229, 32);
            this.lbCustomer.TabIndex = 3;
            this.lbCustomer.Text = "Manage Customers";
            this.lbCustomer.Click += new System.EventHandler(this.lbCustomer_Click);
            // 
            // lbSalesHistory
            // 
            this.lbSalesHistory.AutoSize = true;
            this.lbSalesHistory.BackColor = System.Drawing.Color.Transparent;
            this.lbSalesHistory.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalesHistory.Location = new System.Drawing.Point(45, 384);
            this.lbSalesHistory.Name = "lbSalesHistory";
            this.lbSalesHistory.Size = new System.Drawing.Size(160, 32);
            this.lbSalesHistory.TabIndex = 3;
            this.lbSalesHistory.Text = "Sales History";
            this.lbSalesHistory.Click += new System.EventHandler(this.lbSalesHistory_Click);
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.BackColor = System.Drawing.Color.Transparent;
            this.lbInventory.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.Location = new System.Drawing.Point(45, 252);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(122, 32);
            this.lbInventory.TabIndex = 3;
            this.lbInventory.Text = "Inventory";
            this.lbInventory.Click += new System.EventHandler(this.lbInventory_Click);
            // 
            // pbCompanyLogo
            // 
            this.pbCompanyLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbCompanyLogo.Image = global::GlobalManagementSystemApp.Properties.Resources.KTM_S_Logo1;
            this.pbCompanyLogo.Location = new System.Drawing.Point(18, -8);
            this.pbCompanyLogo.Name = "pbCompanyLogo";
            this.pbCompanyLogo.Size = new System.Drawing.Size(200, 152);
            this.pbCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyLogo.TabIndex = 2;
            this.pbCompanyLogo.TabStop = false;
            // 
            // pbLogOut
            // 
            this.pbLogOut.BackColor = System.Drawing.Color.Transparent;
            this.pbLogOut.Image = global::GlobalManagementSystemApp.Properties.Resources.logout;
            this.pbLogOut.Location = new System.Drawing.Point(1234, 27);
            this.pbLogOut.Name = "pbLogOut";
            this.pbLogOut.Size = new System.Drawing.Size(77, 50);
            this.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogOut.TabIndex = 0;
            this.pbLogOut.TabStop = false;
            this.pbLogOut.Click += new System.EventHandler(this.pbLogOut_Click);
            // 
            // pbManageUser
            // 
            this.pbManageUser.BackColor = System.Drawing.Color.Transparent;
            this.pbManageUser.Image = global::GlobalManagementSystemApp.Properties.Resources.manage_user;
            this.pbManageUser.Location = new System.Drawing.Point(63, 582);
            this.pbManageUser.Name = "pbManageUser";
            this.pbManageUser.Size = new System.Drawing.Size(89, 85);
            this.pbManageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageUser.TabIndex = 0;
            this.pbManageUser.TabStop = false;
            this.pbManageUser.Click += new System.EventHandler(this.pbManageUser_Click);
            // 
            // pbCustomers
            // 
            this.pbCustomers.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomers.Image = global::GlobalManagementSystemApp.Properties.Resources.client;
            this.pbCustomers.Location = new System.Drawing.Point(68, 448);
            this.pbCustomers.Name = "pbCustomers";
            this.pbCustomers.Size = new System.Drawing.Size(77, 50);
            this.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomers.TabIndex = 0;
            this.pbCustomers.TabStop = false;
            this.pbCustomers.Click += new System.EventHandler(this.pbCustomers_Click);
            // 
            // pbInventory
            // 
            this.pbInventory.BackColor = System.Drawing.Color.Transparent;
            this.pbInventory.Image = global::GlobalManagementSystemApp.Properties.Resources.inventory;
            this.pbInventory.Location = new System.Drawing.Point(65, 199);
            this.pbInventory.Name = "pbInventory";
            this.pbInventory.Size = new System.Drawing.Size(77, 50);
            this.pbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInventory.TabIndex = 0;
            this.pbInventory.TabStop = false;
            this.pbInventory.Click += new System.EventHandler(this.pbInventory_Click);
            // 
            // gpCentrePanel
            // 
            this.gpCentrePanel.Angle = 0F;
            this.gpCentrePanel.BackgroundImage = global::GlobalManagementSystemApp.Properties.Resources.career;
            this.gpCentrePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpCentrePanel.BottomColor = System.Drawing.Color.Empty;
            this.gpCentrePanel.Controls.Add(this.panel2);
            this.gpCentrePanel.Controls.Add(this.panel3);
            this.gpCentrePanel.Controls.Add(this.panel4);
            this.gpCentrePanel.Controls.Add(this.panel1);
            this.gpCentrePanel.Controls.Add(this.pbSlideShow);
            this.gpCentrePanel.Controls.Add(this.monthCalendar1);
            this.gpCentrePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCentrePanel.Location = new System.Drawing.Point(266, 160);
            this.gpCentrePanel.Name = "gpCentrePanel";
            this.gpCentrePanel.Size = new System.Drawing.Size(1330, 758);
            this.gpCentrePanel.TabIndex = 2;
            this.gpCentrePanel.TopColor = System.Drawing.Color.Empty;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.lbTotalSupplier);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(896, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 228);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::GlobalManagementSystemApp.Properties.Resources.Supplier;
            this.pictureBox10.Location = new System.Drawing.Point(138, 79);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(156, 127);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // lbTotalSupplier
            // 
            this.lbTotalSupplier.AutoSize = true;
            this.lbTotalSupplier.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSupplier.Location = new System.Drawing.Point(33, 102);
            this.lbTotalSupplier.Name = "lbTotalSupplier";
            this.lbTotalSupplier.Size = new System.Drawing.Size(0, 75);
            this.lbTotalSupplier.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 38);
            this.label15.TabIndex = 0;
            this.label15.Text = "Suppliers";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.pictureBox9);
            this.panel3.Controls.Add(this.lbTotalCust);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(499, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 219);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GlobalManagementSystemApp.Properties.Resources.clients2;
            this.pictureBox9.Location = new System.Drawing.Point(120, 65);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(156, 127);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // lbTotalCust
            // 
            this.lbTotalCust.AutoSize = true;
            this.lbTotalCust.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCust.Location = new System.Drawing.Point(8, 88);
            this.lbTotalCust.Name = "lbTotalCust";
            this.lbTotalCust.Size = new System.Drawing.Size(119, 75);
            this.lbTotalCust.TabIndex = 0;
            this.lbTotalCust.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 38);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Clients";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lbTotalInv);
            this.panel4.Location = new System.Drawing.Point(362, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 280);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::GlobalManagementSystemApp.Properties.Resources.inventory21;
            this.pictureBox8.Location = new System.Drawing.Point(178, 138);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(156, 127);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Baskerville Old Face", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 49);
            this.label13.TabIndex = 0;
            this.label13.Text = "Inventory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Baskerville Old Face", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 49);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Items in";
            // 
            // lbTotalInv
            // 
            this.lbTotalInv.AutoSize = true;
            this.lbTotalInv.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalInv.Location = new System.Drawing.Point(30, 156);
            this.lbTotalInv.Name = "lbTotalInv";
            this.lbTotalInv.Size = new System.Drawing.Size(126, 75);
            this.lbTotalInv.TabIndex = 0;
            this.lbTotalInv.Text = "200";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.lbTotalSales);
            this.panel1.Controls.Add(this.salesLabel);
            this.panel1.Location = new System.Drawing.Point(37, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 228);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GlobalManagementSystemApp.Properties.Resources.sales;
            this.pictureBox7.Location = new System.Drawing.Point(259, 40);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(156, 127);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // lbTotalSales
            // 
            this.lbTotalSales.AutoSize = true;
            this.lbTotalSales.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSales.Location = new System.Drawing.Point(8, 40);
            this.lbTotalSales.Name = "lbTotalSales";
            this.lbTotalSales.Size = new System.Drawing.Size(252, 48);
            this.lbTotalSales.TabIndex = 0;
            this.lbTotalSales.Text = "$3,000,000.00";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(20, 128);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(161, 38);
            this.salesLabel.TabIndex = 0;
            this.salesLabel.Text = "YTD Sales";
            // 
            // pbSlideShow
            // 
            this.pbSlideShow.Image = ((System.Drawing.Image)(resources.GetObject("pbSlideShow.Image")));
            this.pbSlideShow.Location = new System.Drawing.Point(753, 36);
            this.pbSlideShow.Name = "pbSlideShow";
            this.pbSlideShow.Size = new System.Drawing.Size(535, 338);
            this.pbSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlideShow.TabIndex = 2;
            this.pbSlideShow.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar1.Location = new System.Drawing.Point(27, 36);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // notification
            // 
            this.notification.Text = "notifyIcon1";
            this.notification.Visible = true;
            // 
            // pbLogOut2
            // 
            this.pbLogOut2.BackColor = System.Drawing.Color.Transparent;
            this.pbLogOut2.Image = global::GlobalManagementSystemApp.Properties.Resources.logout;
            this.pbLogOut2.Location = new System.Drawing.Point(68, 752);
            this.pbLogOut2.Name = "pbLogOut2";
            this.pbLogOut2.Size = new System.Drawing.Size(77, 50);
            this.pbLogOut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogOut2.TabIndex = 0;
            this.pbLogOut2.TabStop = false;
            this.pbLogOut2.Click += new System.EventHandler(this.pbLogOut2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1616, 938);
            this.Controls.Add(this.gpCentrePanel);
            this.Controls.Add(this.gpTopPanel);
            this.Controls.Add(this.gpLeftPanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Dashboard";
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gpTopPanel.ResumeLayout(false);
            this.gpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageIcon)).EndInit();
            this.gpLeftPanel.ResumeLayout(false);
            this.gpLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventory)).EndInit();
            this.gpCentrePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private gradientPanel gpLeftPanel;
        private gradientPanel gpTopPanel;
        private System.Windows.Forms.PictureBox pbMessageIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbNotificationIcon;
        private System.Windows.Forms.PictureBox pbCompanyLogo;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbManageUser;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.PictureBox pbInventory;
        private System.Windows.Forms.PictureBox pbCustomers;
        private System.Windows.Forms.PictureBox pbLogOut;
        private System.Windows.Forms.PictureBox pbManageUser;
        private System.Windows.Forms.PictureBox pictureBox6;
        private gradientPanel gpCentrePanel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pbSlideShow;
        private System.Windows.Forms.Timer slideShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTotalSales;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalInv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTotalCust;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotalSupplier;
        private System.Windows.Forms.Label lbSalesHistory;
        private System.Windows.Forms.NotifyIcon notification;
        private System.Windows.Forms.PictureBox pbLogOut2;
    }
}

