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
    public partial class InventoryFrmCrud : Form
    {
        private bool IsEditMode = false;
        private readonly Gms_DbEntities _gmsDb;
        public InventoryFrmCrud()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            lbAddUpdateTitle.Text = "Add New Stock";
            InventoryFrmCrud_Load();
        }
        public InventoryFrmCrud(Inventory updateInv)
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            IsEditMode = true;
            lbAddUpdateTitle.Text = "Update Stock";
            InventoryFrmCrud_Load();
            PopulateFields(updateInv);
        }

        private void PopulateFields(Inventory updateInv)
        {
            lbInvId.Text = updateInv.ID.ToString();
            cbProdName.Text = updateInv.Product_details.Name;
            cbSupplier.Text = updateInv.Supplier.Name;
            tbQuantity.Text = updateInv.Qty_base.ToString();

        }
        
        public void InventoryFrmCrud_Load()
        {
            var prod = _gmsDb.Product_details.ToList();
            cbProdName.DisplayMember = "Name";
            cbProdName.ValueMember = "ID";
            cbProdName.DataSource = prod;
            var sup = _gmsDb.Suppliers.ToList();
            cbSupplier.DisplayMember = "Name";
            cbSupplier.ValueMember = "ID";
            cbSupplier.DataSource = sup;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode)
                {
                    //edit code
                    var id = int.Parse(lbInvId.Text);
                    var item = _gmsDb.Inventories.FirstOrDefault(o => o.ID == id);
                    item.Product_ID = Convert.ToInt32(cbProdName.SelectedValue);
                    item.Supplier_ID = Convert.ToInt32(cbSupplier.SelectedValue);
                    item.Qty_base = Convert.ToInt32(tbQuantity.Text);
                    item.Date_time_mod = DateTime.Now;
                    _gmsDb.SaveChanges();
                    this.Close();
                    MessageBox.Show("Operation Successfully Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InventoryFrmCrud_Load();

                }
                else
                {
                    //add code
                    Inventory newAddStock = new Inventory
                    {
                        Product_ID = Convert.ToInt32(cbProdName.SelectedValue),
                        Supplier_ID = Convert.ToInt32(cbSupplier.SelectedValue),
                        Qty_base = Convert.ToInt32(tbQuantity.Text),
                        Date_time_mod = DateTime.Now,
                    };

                    _gmsDb.Inventories.Add(newAddStock);
                    _gmsDb.SaveChanges();
                    this.Close();
                    MessageBox.Show("Operation Successfully Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InventoryFrmCrud_Load();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
