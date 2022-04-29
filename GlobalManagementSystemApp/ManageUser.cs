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
    public partial class ManageUser : Form
    {
        private readonly Gms_DbEntities _gmsDb;
       
        public ManageUser()
        {
            InitializeComponent();
        }
        public ManageUser(Login log, User _user)
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();                  
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            var adduser = new AddUser(this);
            adduser.ShowDialog();
        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get id
                var id = (int)gvManageUser.SelectedRows[0].Cells["ID"].Value;
                //query database
                var user = _gmsDb.Users.FirstOrDefault(u => u.ID == id);
                DialogResult dialogResult = MessageBox.Show($"Do you wish to reset {user.userName} password?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var hashedPassword = gmsUtil.DefaultPassword();
                    user.password = hashedPassword;
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Password reset success!!", $"{user.userName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                 

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please slecect the row you wish to perform the operation on", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Something","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }           
            
        }

        private void btActivateDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvManageUser.SelectedRows[0].Cells["ID"].Value;
                var user = _gmsDb.Users.FirstOrDefault(u => u.ID == id);

                DialogResult dialogResult = MessageBox.Show("Do you wish to Activate/Deactivate the selected user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    user.isActive = user.isActive == true ? false : true;
                    _gmsDb.SaveChanges();
                    MessageBox.Show("Operation successfully completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                    
                    
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please slecect the row you wish to perform the operation on", "Activate/Deactivate User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Select the user you wish to perform the operation on ", "Activate/Deactivate User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            var users = _gmsDb.Users.Select(u => new { u.ID, u.userName, u.UserRoles.FirstOrDefault().Role.name, u.isActive }).ToList();
            gvManageUser.DataSource = users;
            gvManageUser.Columns[0].Visible = false;
            gvManageUser.Columns[1].HeaderText = "Username";
            gvManageUser.Columns[2].HeaderText = "Account Type";
            gvManageUser.Columns[3].HeaderText = "Status";

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        
    }
}
