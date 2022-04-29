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
    public partial class AddUser : Form
    {
        private readonly Gms_DbEntities _gmsDb;
        private ManageUser _manageUser;
        public AddUser()
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
        }

        public AddUser(ManageUser mngUser)
        {
            InitializeComponent();
            _gmsDb = new Gms_DbEntities();
            _manageUser = mngUser;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var role = _gmsDb.Roles.ToList();
            cbAccountType.DataSource = role;
            cbAccountType.ValueMember = "ID";
            cbAccountType.DisplayMember = "Name";
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUserName.Text;
                var role = (int)cbAccountType.SelectedValue;
                var passwrd = gmsUtil.DefaultPassword();
                var newUser = new User
                {
                    userName = userName,
                    password = passwrd,
                    isActive = true,
                };

                _gmsDb.Users.Add(newUser);
                _gmsDb.SaveChanges();

                var userId = newUser.ID;
                var usrRole = new UserRole
                {
                    roleID = role,
                    userID = userId
                };

                _gmsDb.UserRoles.Add(usrRole);
                _gmsDb.SaveChanges();
                _manageUser.LoadUsers();

                this.Close();
                
                MessageBox.Show("Operation successfully completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
