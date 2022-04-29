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
    public partial class CustomersFrm : Form
    {
        Gms_DbEntities _gmsDb;
        Dashboard _dashboard;
        public CustomersFrm()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
        }


        public  void Customers_Load()
        {
            var customer = _gmsDb.Customers.Select(c => new {ID = c.ID, frstName = c.Fname, lastName = c.Lname, Address = c.Address, parish = c.Parish.Name, Email = c.Email_addr, contact = c.Contact_no}).ToList();
            gvCustomers.DataSource = customer;
            gvCustomers.Columns[0].HeaderText = "Customer ID";
            gvCustomers.Columns[0].Visible = false;
            gvCustomers.Columns[1].HeaderText = "First Name";
            gvCustomers.Columns[2].HeaderText = "Last Name";
            gvCustomers.Columns[3].HeaderText = "Address";
            gvCustomers.Columns[4].HeaderText = "Parish";
            gvCustomers.Columns[5].HeaderText = "Email Address";
            gvCustomers.Columns[6].HeaderText = "Contact Number";
           
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            _dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (_dashboard.UserRoll() == gmsUtil.ViewOnly())
            {
                MessageBox.Show("You are logged in with a View Only profile. CREATE, UPDATE, and DELETE Operations are Restricted!", "View Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btAdd.Enabled = false;
                btDelete.Enabled = false;
                btEdit.Enabled = false;
              
            }
            Customers_Load();     
            
         }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Customers_Load();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var AddCustomer = new AddEditCustomer();
            AddCustomer.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvCustomers.SelectedRows[0].Cells["ID"].Value;
                var cust = _gmsDb.Customers.FirstOrDefault(c => c.ID == id);
                var EditCustomer = new AddEditCustomer(cust);
                EditCustomer.ShowDialog();

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

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvCustomers.SelectedRows[0].Cells["ID"].Value;
                var cust = _gmsDb.Customers.FirstOrDefault(c => c.ID == id);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
                {
                    _gmsDb.Customers.Remove(cust);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tbFindByName_TextChanged(object sender, EventArgs e)
        {
            gvCustomers.DataSource = _gmsDb.Customers.Select(c => new { ID = c.ID, frstName = c.Fname, lastName = c.Lname, Address = c.Address, parish = c.Parish.Name, 
                Email = c.Email_addr, contact = c.Contact_no }).Where(q => q.lastName == tbFindByName.Text).ToList();
        }

        private void cbFindbyCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = int.Parse(cbFindbyCustId.SelectedValue.ToString());
            gvCustomers.DataSource = _gmsDb.Customers.Select(c => new { ID = c.ID, frstName = c.Fname, lastName = c.Lname, Address = c.Address, parish = c.Parish.Name, Email = c.Email_addr, contact = c.Contact_no }).
                Where(q => q.ID == selectedIndex).ToList();
        }

         private void cbFindbyCustId_MouseClick(object sender, MouseEventArgs e)
        {
            var customer = _gmsDb.Customers.ToList();
            cbFindbyCustId.ValueMember = "ID";
            cbFindbyCustId.DisplayMember = "ID";
            cbFindbyCustId.DataSource = customer;

        }private void cbFindByParish_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = Convert.ToInt32(cbFindByParish.SelectedValue.ToString());
            gvCustomers.DataSource = _gmsDb.Customers.Select(c => new { ID = c.ID, frstName = c.Fname, lastName = c.Lname, Address = c.Address, 
                parish = c.Parish.Name, Email = c.Email_addr, contact = c.Contact_no, parishId = c.Parish.ID }).Where(q => q.parishId == selectedIndex).ToList();
            gvCustomers.Columns["parishId"].Visible = false;


        }

        private void cbFindByParish_MouseClick(object sender, MouseEventArgs e)
        {
            var parish = _gmsDb.Parishes.ToList();
            cbFindByParish.ValueMember = "ID";
            cbFindByParish.DisplayMember = "Name";
            cbFindByParish.DataSource = parish;
        }
    }
}
