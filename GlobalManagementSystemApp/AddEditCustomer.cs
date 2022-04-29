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
    public partial class AddEditCustomer : Form
    {
        private readonly Gms_DbEntities _gmsDb;

        
       
        bool isEditMode = false;
        public AddEditCustomer()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            AddEditCustomer_Load();
            lbAddEdit.Text = "Add Customer";
        }

        public AddEditCustomer(Customer cust)
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            PopulateFields(cust);
            AddEditCustomer_Load();
            lbAddEdit.Text = "Update Customer";
            isEditMode = true;
        }

        private void PopulateFields(Customer customer)
        {
            lbCustId.Text = customer.ID.ToString();
            tbAddress.Text = customer.Address;
            tbContactNumber.Text = customer.Contact_no.ToString();
            tbEmail.Text = customer.Email_addr;
            tbFname.Text = customer.Fname;
            tbLname.Text = customer.Lname;
            cbParish.Text = customer.Parish.Name;

        }

        private void AddEditCustomer_Load(object sender, EventArgs e)
        {
                AddEditCustomer_Load();
           
        }

        public void AddEditCustomer_Load()
        {
            var parish = _gmsDb.Parishes.ToList();

            cbParish.DisplayMember = "Name";
            cbParish.ValueMember = "ID";
            cbParish.DataSource = parish;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(isEditMode)
                {
                    var id = int.Parse(lbCustId.Text);
                    var customer = _gmsDb.Customers.FirstOrDefault(o => o.ID == id);
                    customer.Fname = tbFname.Text;
                    customer.Lname = tbLname.Text;
                    customer.Address = tbAddress.Text;
                    customer.Parish_ID = Convert.ToInt32(cbParish.SelectedValue);
                    customer.Contact_no = Convert.ToInt64(tbContactNumber.Text);
                    customer.Email_addr = tbEmail.Text;
                    
                    
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // _customer.Customers_Load();
                    this.Close();
                }
                else
                {
                    Customer addNew = new Customer()
                    {
                        Fname = tbFname.Text,
                        Lname = tbLname.Text,
                        Address = tbAddress.Text,
                        Parish_ID = Convert.ToInt32(cbParish.SelectedValue),
                        Contact_no = Convert.ToInt64(tbContactNumber.Text),
                        Email_addr = tbEmail.Text
                        
                    };
                    _gmsDb.Customers.Add(addNew);
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation Successfully Completed", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //_customer.Customers_Load();
                    this.Close();

                }

            }
            catch (Exception)
            {

                throw;
                //MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
