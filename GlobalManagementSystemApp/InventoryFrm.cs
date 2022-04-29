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
   
    public partial class InventoryFrm : Form
    {
       
        private readonly Gms_DbEntities _gmsDb;
        Dashboard _dashboard;
        public InventoryFrm()
        {
            InitializeComponent();
           _gmsDb = new Gms_DbEntities();
            
            
        }
        private void InventoryFrm_Load(object sender, EventArgs e)
        {
            _dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (_dashboard.UserRoll() == gmsUtil.ViewOnly())
            {
                MessageBox.Show("You are logged in with a View Only profile. CREATE, UPDATE, and DELETE Operations are Restricted!", "View Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btAddNewStock.Enabled = false;
                btnUpdateStock.Enabled = false;
                btDeleteStock.Enabled = false;
            }
            InventoryFrm_Load();
        }

        public void InventoryFrm_Load()
        {
            var invProd = _gmsDb.Inventories.Include(nameof(Product_details)).Include(nameof(Supplier))
               .Select(o => new { invId = o.ID, ProdName = o.Product_details.Name, SupName = o.Supplier.Name, prodQty = o.Qty_base, o.Date_time_mod }).ToList();

            gvInventory.DataSource = invProd;
            gvInventory.Columns[0].HeaderText = "Inventory ID";
            gvInventory.Columns[0].Visible=false;
            gvInventory.Columns[1].HeaderText = "Product Name";
            gvInventory.Columns[2].HeaderText = "Supplier";
            gvInventory.Columns[3].HeaderText = "Quantity";
            gvInventory.Columns[4].HeaderText = " Date Time Last Modified";

        }
        private void btAddNewStock_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsOpen = false;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Text == "InventoryFrmCrud")
                    {
                        IsOpen = true;
                        frm.Focus();
                        MessageBox.Show("Another Instance of Add New Stock is Already Running");
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    InventoryFrmCrud invCrud = new InventoryFrmCrud();
                    invCrud.MdiParent = this.MdiParent;
                    invCrud.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            

        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvInventory.SelectedRows[0].Cells["invId"].Value;
                //query database
                var item = _gmsDb.Inventories.FirstOrDefault(o => o.ID == id);
                //launch window
                
                bool IsOpen = false;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Text == "InventoryFrmCrud")
                    {
                        IsOpen = true;
                        frm.Focus();
                        MessageBox.Show("Another Instance of Update Stock is Already Running");
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    InventoryFrmCrud invCrud = new InventoryFrmCrud(item);
                    invCrud.MdiParent = this.MdiParent;
                    invCrud.Show();

                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please slecect the row you wish to perform the operation on", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception )
            {
                MessageBox.Show("Something went wrong", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
            
        }

        private void btDeleteStock_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvInventory.SelectedRows[0].Cells["invId"].Value;
                //query database
                var stock = _gmsDb.Inventories.FirstOrDefault(o => o.ID == id);
                //delete
                _gmsDb.Inventories.Remove(stock);
                _gmsDb.SaveChanges();
                MessageBox.Show("Operation Successfully Completed");
                 gvInventory.Refresh();
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

        private void btRefresh_Click(object sender, EventArgs e)
        {
           
           InventoryFrm_Load();
        }


        private void cbProd_MouseClick(object sender, MouseEventArgs e)
        {
            var ProdId = _gmsDb.Product_details.ToList();

            cbProd.ValueMember = "ID";
            cbProd.DisplayMember = "Name";
            cbProd.DataSource = ProdId;
        }

        private void cbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = int.Parse(cbProd.SelectedValue.ToString());
            
            gvInventory.DataSource = _gmsDb.Inventories.Include(nameof(Product_details)).Include(nameof(Supplier))
               .Select(o => new { Id = o.Product_details.ID, ProdName = o.Product_details.Name, SupName = o.Supplier.Name, prodQty = o.Qty_base, o.Date_time_mod }).Where(q => q.Id == selectedIndex).ToList();

            
            gvInventory.Columns[0].HeaderText = "Product ID";
            gvInventory.Columns[0].Visible = false;
            gvInventory.Columns[1].HeaderText = "Product Name";
            gvInventory.Columns[2].HeaderText = "Supplier";
            gvInventory.Columns[3].HeaderText = "Quantity";
            gvInventory.Columns[4].HeaderText = " Date Time Last Modified";

        }

         private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = Convert.ToInt32(cbSuppliers.SelectedValue.ToString());

            gvInventory.DataSource = _gmsDb.Inventories.Include(nameof(Product_details)).Include(nameof(Supplier))
               .Select(o => new { SupId = o.Supplier.ID, ProdName = o.Product_details.Name, SupName = o.Supplier.Name, prodQty = o.Qty_base, o.Date_time_mod }).Where(q => q.SupId == selectedIndex).ToList();


            gvInventory.Columns[0].HeaderText = "Supplier ID";
            gvInventory.Columns[0].Visible = false;
            gvInventory.Columns[1].HeaderText = "Product Name";
            gvInventory.Columns[2].HeaderText = "Supplier";
            gvInventory.Columns[3].HeaderText = "Quantity";
            gvInventory.Columns[4].HeaderText = " Date Time Last Modified";
        }

        private void cbSuppliers_MouseClick(object sender, MouseEventArgs e)
        {
            var SupId = _gmsDb.Suppliers.ToList();
            cbSuppliers.ValueMember = "ID";
            cbSuppliers.DisplayMember = "Name";
            cbSuppliers.DataSource = SupId;
        }

      
    }
}
