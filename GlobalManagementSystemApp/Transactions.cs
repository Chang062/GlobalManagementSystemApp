using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalManagementSystemApp
{
    public partial class Transactions : Form
    {
        Gms_DbEntities _gmsDb;
        public Transactions()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            FrmLoad();
            tbTotalTransactions.Text = TotalTransaction().ToString();
            tbItemsSold.Text = TotalItemsSold().ToString();
           

        }

        public void FrmLoad()
        {
            var viewTransactions = _gmsDb.Invoices.Include(nameof(Transaction_info)).Include(nameof(Customer)).Select(q => new {
                Name = q.Transaction_info.Customer.Fname + " " + q.Transaction_info.Customer.Lname,
                prodName = q.Product_details.Name,
                Quantity = q.Qty,
                Markup = (q.Product_details.Cost * q.Product_details.Markup) + (q.Product_details.Cost * q.Vat) + q.Product_details.Cost,
                TransDate = q.Transaction_info.Transaction_date,
                billingAddress = q.Transaction_info.Customer.Address + " " + q.Transaction_info.Customer.Parish.Name
            }).ToList();
            gvTransactions.DataSource = viewTransactions;

            gvTransactions.Columns[0].HeaderText = "Customer Name";
            gvTransactions.Columns[1].HeaderText = "Product Name";
            gvTransactions.Columns[2].HeaderText = "Quantity";
            gvTransactions.Columns[3].HeaderText = " Sale Price";
            this.gvTransactions.Columns["Markup"].DefaultCellStyle.Format = "c";
            gvTransactions.Columns[4].HeaderText = "Date Purhased";
            gvTransactions.Columns[5].HeaderText = "Billing Address";
            

            
            
            
        }

     
        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {             
                       
                gvTransactions.DataSource = _gmsDb.Invoices.Include(nameof(Transaction_info)).Include(nameof(Customer)).Select(q => new {
                Name = q.Transaction_info.Customer.Fname + " " + q.Transaction_info.Customer.Lname,
                prodName = q.Product_details.Name,
                Quantity = q.Qty,
                Markup = (q.Product_details.Cost * q.Product_details.Markup) + (q.Product_details.Cost * q.Vat) + q.Product_details.Cost,
                TransDate = q.Transaction_info.Transaction_date,
                billingAddress = q.Transaction_info.Customer.Address + " " + q.Transaction_info.Customer.Parish.Name
            }).Where(p => p.Name.Contains(tbSearchName.Text)).ToList();
        }



        private void btRefresh_Click(object sender, EventArgs e)
        {
            FrmLoad();
            

        }

        private void cbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int.TryParse(cbProd.SelectedValue.ToString());
            int selectedIndex = Convert.ToInt32(cbProd.SelectedValue.ToString());

            gvTransactions.DataSource = _gmsDb.Invoices.Include(nameof(Transaction_info)).Include(nameof(Customer)).Select(q => new {
                Name = q.Transaction_info.Customer.Fname + " " + q.Transaction_info.Customer.Lname,
                prodName = q.Product_details.Name,
                Quantity = q.Qty,
                Markup = (q.Product_details.Cost * q.Product_details.Markup) + (q.Product_details.Cost * q.Vat) + q.Product_details.Cost,
                TransDate = q.Transaction_info.Transaction_date,
                billingAddress = q.Transaction_info.Customer.Address + " " + q.Transaction_info.Customer.Parish.Name, ID = q.Product_ID
            }).Where(p => p.ID == selectedIndex).ToList();

            gvTransactions.Columns["ID"].Visible = false;
            

        }
        private void cbProd_MouseClick(object sender, MouseEventArgs e)
        {
            var prodname = _gmsDb.Product_details.ToList();

            cbProd.ValueMember = "ID";
            cbProd.DisplayMember = "Name";
            cbProd.DataSource = prodname;
        }

        private void cbProd_MouseLeave(object sender, EventArgs e)
        {
           
            
        }

        private int TotalTransaction()
        {
            var transactions = _gmsDb.Transaction_info.Select(q => q.ID).ToList();
           
            return transactions.Count;
        }

        private int TotalItemsSold()
        {
            List<int> TotalSold = new List<int>();

            var quantity = _gmsDb.Invoices.Select(q=> q.Qty).ToList();
            foreach (var item in quantity)
            {
                TotalSold.Add(item);
            }

            var totalQuantity = TotalSold.Sum();

            return totalQuantity;
        }

       
    }
}
