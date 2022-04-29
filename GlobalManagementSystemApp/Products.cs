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
    public partial class Products : Form
    {
        private readonly Gms_DbEntities _gmsDb;
        private ProductsCrud _productsCrud;
        Dashboard _dashboard;
        public Products()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Products_Load();
        }
        public void Products_Load()
        {
            var prodInfo = _gmsDb.Product_details.Include(nameof(Brand)).Select(p => new { ID = p.ID, Name = p.Name, Brand = p.Brand.Name, Cost = p.Cost, Markup = p.Markup, MPrice = (p.Cost * p.Markup) + p.Cost }).ToList();
            gvProducts.DataSource = prodInfo;
            gvProducts.Columns[0].HeaderText = "Product ID";
            gvProducts.Columns[0].Visible = false;
            gvProducts.Columns[1].HeaderText = "Product Name";
            gvProducts.Columns[2].HeaderText = "Manufacturer";
            gvProducts.Columns[3].HeaderText = "Base Cost ($JA)";
            gvProducts.Columns[3].DefaultCellStyle.Format = "c";
            gvProducts.Columns[4].HeaderText = "MarkUp (%)";
            gvProducts.Columns[5].HeaderText = "MarkUp Price ($JA)";
            gvProducts.Columns[5].DefaultCellStyle.Format = "c";

            _dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

            if (_dashboard.UserRoll() == gmsUtil.ViewOnly())
            {
                MessageBox.Show("You are logged in with a View Only profile. CREATE, UPDATE, and DELETE Operations are Restricted!", "View Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btAdd.Enabled = false;
                btDel.Enabled = false;
                btUpdate.Enabled = false;
                //lbProducts.Text = "MANAGE PRODUCTS (VIEW ONLY)";
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsCrud prodcrud = new ProductsCrud();
                if (gmsUtil.FormIsOpnen(Application.OpenForms, typeof(ProductsCrud)))
                {
                    prodcrud.Focus();
                    MessageBox.Show("Another Instance of Add Product is Already Running", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    prodcrud.MdiParent = this.MdiParent;
                    prodcrud.Show();
                }                    

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Products_Load();
            gvProducts.Refresh();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {               
                //get id
                var id = (int)gvProducts.SelectedRows[0].Cells["ID"].Value;
                //query database
                var prod = _gmsDb.Product_details.FirstOrDefault(o => o.ID == id);
                //launch window
                _productsCrud = new ProductsCrud(prod);

                if (gmsUtil.FormIsOpnen(Application.OpenForms, typeof(ProductsCrud)))
            {
                    _productsCrud.Focus();
                    MessageBox.Show("Another Instance of Update Product is Already Running", "",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
                else
                {
                    _productsCrud.MdiParent = this.MdiParent;
                    _productsCrud.Show();                    
                }                

            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please slecect the row you wish to perform the operation on", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
           {

                MessageBox.Show("Something went wrong", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvProducts.SelectedRows[0].Cells["ID"].Value;
                var delprod = _gmsDb.Product_details.FirstOrDefault(o => o.ID == id);
                _gmsDb.Product_details.Remove(delprod);
                _gmsDb.SaveChanges();
                MessageBox.Show("Operation Successfully Completed");
                gvProducts.Refresh();

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please slecect the row you wish to perform the operation on", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Unable to delete record. This record might be in use by another table.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
