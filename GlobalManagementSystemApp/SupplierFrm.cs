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
    public partial class SupplierFrm : Form
    {
        private readonly Gms_DbEntities _gmsDb;
        private bool IsEditMode = false;
        Dashboard _dashboard;
        public SupplierFrm()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
                

        }      

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
          SupplierFrm_Load();       


        }

        public void SupplierFrm_Load()
        {
            var supDetails = _gmsDb.Suppliers.Select(o => new { ID = o.ID, Name = o.Name, Address = o.Address,Parish = o.Parish.Name, Email = o.Email_addr, Contact = o.Contact_no }).ToList();
            gvSupplier.DataSource = supDetails;

            gvSupplier.Columns[0].HeaderText = "Supplier ID";
            gvSupplier.Columns[1].HeaderText = "Supplier Name";
            gvSupplier.Columns[2].HeaderText = "Address";
            gvSupplier.Columns[3].HeaderText = "Parish";
            gvSupplier.Columns[4].HeaderText = "Email Address";
            gvSupplier.Columns[5].HeaderText = "Contact Number";

            var parish = _gmsDb.Parishes.ToList();
            cbParish.DisplayMember = "Name";
            cbParish.ValueMember = "ID";
            cbParish.DataSource = parish;

            _dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if(_dashboard.UserRoll() == gmsUtil.ViewOnly())
            {
                MessageBox.Show("You are logged in with a View Only profile. CREATE, UPDATE, and DELETE Operations are Restricted!", "View Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                btAdd.Enabled = false;
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
                lbSupId.Text = "MANAGE SUPPLIER (VIEW ONLY)";
            }            

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            gpAddEdit.Visible = true;
            IsEditMode = false;
            btUpdate.BackColor = Color.Turquoise;
            btAdd.BackColor = Color.RosyBrown;
            btDelete.BackColor = Color.Turquoise;
            lbSupId.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbContact.Text = "";
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvSupplier.SelectedRows[0].Cells["ID"].Value;
                //query database
                var supplier = _gmsDb.Suppliers.FirstOrDefault(o => o.ID == id);
                IsEditMode = true;
                gpAddEdit.Visible = true;
                btUpdate.BackColor = Color.RosyBrown;
                btAdd.BackColor = Color.Turquoise;
                btDelete.BackColor = Color.Turquoise;
                populatefields(supplier);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please slecect the row you wish to perform the operation on", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populatefields(Supplier supplier)
        {
            try
            {
                lbSupId.Text = supplier.ID.ToString();
                tbName.Text = supplier.Name;
                tbAddress.Text = supplier.Address;
                cbParish.Text = supplier.Parish.Name;
                tbEmail.Text = supplier.Email_addr;
                tbContact.Text = supplier.Contact_no.ToString();
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode)
                {
                    var id = int.Parse(lbSupId.Text);
                    var editSup = _gmsDb.Suppliers.FirstOrDefault(o => o.ID == id);
                    editSup.Name = tbName.Text;
                    editSup.Address = tbAddress.Text;
                    editSup.Parish_ID = Convert.ToInt32(cbParish.SelectedValue);
                    editSup.Email_addr = tbEmail.Text;
                    editSup.Contact_no = Convert.ToInt64(tbContact.Text);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gpAddEdit.Visible = false;
                    SupplierFrm_Load();
                    btUpdate.BackColor = Color.Turquoise;

                }
                else
                {
                    Supplier supplier = new Supplier {Name = tbName.Text, Address = tbAddress.Text,Parish_ID = Convert.ToInt32(cbParish.SelectedValue) ,Email_addr = tbEmail.Text, Contact_no = Convert.ToInt64(tbContact.Text)};
                    _gmsDb.Suppliers.Add(supplier);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    gpAddEdit.Visible=false;
                    SupplierFrm_Load();
                    btAdd.BackColor = Color.Turquoise;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            gpAddEdit.Visible=false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                gpAddEdit.Visible = false;
                var id = (int)gvSupplier.SelectedRows[0].Cells["ID"].Value;
                var delSup = _gmsDb.Suppliers.FirstOrDefault(o => o.ID == id);
                btUpdate.BackColor = Color.Turquoise;
                btAdd.BackColor = Color.Turquoise;
                btDelete.BackColor = Color.RosyBrown;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record", "Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _gmsDb.Suppliers.Remove(delSup);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SupplierFrm_Load();
                    btDelete.BackColor = Color.Turquoise;
                }
               

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
