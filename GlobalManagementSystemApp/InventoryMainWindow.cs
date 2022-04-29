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
 
    public partial class InventoryMainWindow : Form //MetroFramework.Forms.MetroForm
    {
                
        private readonly Gms_DbEntities _gmsDb;
        public InventoryMainWindow()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
           
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
              {
                  bool IsOpen = false;

                  foreach (Form frm in Application.OpenForms)
                  {
                      if (frm.Text == "Inventory")
                      {
                          IsOpen = true;
                          frm.Focus();
                        MessageBox.Show("Another Instance of Inventory is Already Running", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                      }
                  }
                  if (IsOpen == false)
                  {
                      InventoryFrm inv = new InventoryFrm();                    
                      inv.MdiParent = this;
                      inv.Dock = DockStyle.Fill;
                      inv.Show();
                  }
              }
              catch (Exception)
              {
                  MessageBox.Show("Something went wrong","", MessageBoxButtons.OK,MessageBoxIcon.Error);
              }
     

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsOpen = false;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Text == "Products")
                    {
                        IsOpen = true;
                        frm.Focus();
                        MessageBox.Show("Another Instance of Products is Already Running","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    Products prod = new Products();
                    prod.MdiParent = this;
                    prod.Dock = DockStyle.Left;
                    prod.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsOpen = false;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Text == "SupplierFrm")
                    {
                        IsOpen = true;
                        frm.Focus();
                        MessageBox.Show("Another Instance of Supplier is Already Running", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    SupplierFrm supplier = new SupplierFrm();
                    supplier.MdiParent = this;
                    supplier.Dock = DockStyle.Left;
                    supplier.Show();          
                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
