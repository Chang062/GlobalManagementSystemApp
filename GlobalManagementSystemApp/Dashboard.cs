using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace GlobalManagementSystemApp
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm 
    {
        Login _login;
        public string role_name;
        public string usr_name;
        User _user;
        

        private readonly Gms_DbEntities _gmsDb;
        public Dashboard()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
        }

        public Dashboard(Login log, User user )
        {
            InitializeComponent();
            _gmsDb= new Gms_DbEntities();   
            _login = log;
            _user = user;
            this.role_name = user.UserRoles.FirstOrDefault().Role.name;
            this.usr_name = user.userName;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            lbAccountType.Text = role_name;
            lbUserName.Text = usr_name;

            //sum of items sold
            var itemSold = _gmsDb.Invoices.Select(q => new { qty = q.Qty }).ToList();
            var totalSold = 0;
            List<int> productsSold = new List<int>();
            for (int i = 0; i < itemSold.Count; i++)
            {
                productsSold.Add(itemSold[i].qty);
            }
            totalSold = productsSold.Sum();

            //count supplier
            var supDetails = _gmsDb.Suppliers.Select(o => new { ID = o.ID }).ToList();
            lbTotalSupplier.Text = supDetails.Count.ToString();
            //count Customers
            var customers = _gmsDb.Customers.Select(o => new { ID = o.ID }).ToList();
            lbTotalCust.Text = customers.Count.ToString();

            //items in inventory
            List<int> products = new List<int>();
            var inventory = _gmsDb.Inventories.Select(o => new { quantity = o.Qty_base }).ToList();
            int total = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                products.Add(inventory[i].quantity);

            }

            total = products.Sum();
            var difference = total - totalSold;
            lbTotalInv.Text = difference.ToString();

            //total sales 
            List<decimal> sales = new List<decimal>();
            var transactions = _gmsDb.Invoices.Select(q => new { salePrice = (q.Product_details.Cost * q.Product_details.Markup) + (q.Product_details.Cost * q.Vat) + q.Product_details.Cost }).ToList();
            decimal totalSales = 0;
            for (int i = 0; i < transactions.Count; i++)
            {
                sales.Add(transactions[i].salePrice);
            }
            totalSales = sales.Sum();
           lbTotalSales.Text = string.Format("{0:C2}", totalSales);


        }

        private int slideShowImg = 1;
        private void LoadNextImg()
        {
            if(slideShowImg == 4)
            {
                slideShowImg = 1;
            }
            pbSlideShow.ImageLocation = String.Format(@"Images\{0}.png",slideShowImg);
            slideShowImg++;
        }
        private void slideShow_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {
            InventoryMainWindow invMw = new InventoryMainWindow();
            invMw.ShowDialog();
        }

        private void lbInventory_Click(object sender, EventArgs e)
        {
            InventoryMainWindow invMw = new InventoryMainWindow();
            invMw.ShowDialog();
        }    

         private void lbManageUser_Click(object sender, EventArgs e)
        {
            if (role_name == gmsUtil.Admin())
            {
                var mngUser = new ManageUser(_login, _user);
                mngUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pbManageUser_Click(object sender, EventArgs e)
        {
            if (role_name == gmsUtil.Admin())
            {
                var mngUser = new ManageUser(_login, _user);
                mngUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void pbCustomers_Click(object sender, EventArgs e)
        {
            var customerMw = new CustomersFrm();
            customerMw.ShowDialog();
        }

        private void lbCustomer_Click(object sender, EventArgs e)
        {
            var customerMw = new CustomersFrm();
            customerMw.ShowDialog();
        }

        private void lbSalesHistory_Click(object sender, EventArgs e)
        {
            var salesHistory = new Transactions();
            salesHistory.ShowDialog();
        }
        private void pbSalesHistory_Click(object sender, EventArgs e)
        {
            var salesHistory = new Transactions();
            salesHistory.ShowDialog();
        }

        public string UserRoll()
        {
            var currentroll = role_name;
            return currentroll;
        }

        private void pbMessageIcon_Click(object sender, EventArgs e)
        {
            notification.Icon = new System.Drawing.Icon(Path.GetFullPath("Notify.ico"));
           // notification.Text = "No new Messages";
            notification.Visible = true;
            notification.BalloonTipTitle = "No New Message(s)";
            notification.BalloonTipText = "..........";
            notification.ShowBalloonTip(100);
        }

        private void pbNotificationIcon_Click(object sender, EventArgs e)
        {
            notification.Icon = new System.Drawing.Icon(Path.GetFullPath("Notify.ico"));
            // notification.Text = "No new Messages";
            notification.Visible = true;
            notification.BalloonTipTitle = "No New Notification(s)";
            notification.BalloonTipText = "..........";
            notification.ShowBalloonTip(100);
        }

        private void pbLogOut2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _login.Show();
            }

            else
            {
                e.Cancel = true;
            }
        }

       
    }
    public class gradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

       
    }
}
