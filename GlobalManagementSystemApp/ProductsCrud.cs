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
    public partial class ProductsCrud : Form
    {
        private readonly Gms_DbEntities _gmsDb;

        private bool IsEditMode = false;
        public ProductsCrud()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            FormLoadProducts();
            lbProd.Text = "Add New Product";
        }

        public ProductsCrud(Product_details prod)
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            IsEditMode = true;
            lbProd.Text = "Update Product";
            FormLoadProducts();
            PopulateFields(prod);
        }

        private void PopulateFields(Product_details upProd)
        {
            lbProdId.Text = upProd.ID.ToString();
            tbProductName.Text = upProd.Name;
            cbBrand.Text = upProd.Brand.Name;
            tbCost.Text = upProd.Cost.ToString();
            cbMarkUp.Text = upProd.Markup.ToString();

            //throw new NotImplementedException();
        }

        public void FormLoadProducts()
        {
            var prodBrand = _gmsDb.Brands.ToList();
            cbBrand.DisplayMember = "Name";
            cbBrand.ValueMember = "ID";
            cbBrand.DataSource = prodBrand;

           /*var prodMUp = _gmsDb.Product_details.ToList();
            cbMarkUp.DisplayMember = "Markup";
            cbMarkUp.ValueMember = "Markup";
            cbMarkUp.DataSource = prodMUp;*/
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode)
                {
                    var id = int.Parse(lbProdId.Text);
                    var product = _gmsDb.Product_details.FirstOrDefault(o => o.ID == id);
                    product.Name = tbProductName.Text;
                    product.Brand_ID = Convert.ToInt32(cbBrand.SelectedValue);
                    product.Cost = Convert.ToDecimal(tbCost.Text);
                    product.Markup = Convert.ToDecimal(cbMarkUp.SelectedItem);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Product_details addNewProd = new Product_details
                    {
                        Name = tbProductName.Text,
                        Brand_ID = Convert.ToInt32(cbBrand.SelectedValue),
                        Cost = Convert.ToDecimal(tbCost.Text),
                        Markup = Convert.ToDecimal(cbMarkUp.SelectedItem)
                    };

                    _gmsDb.Product_details.Add(addNewProd);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed","Add Product",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
