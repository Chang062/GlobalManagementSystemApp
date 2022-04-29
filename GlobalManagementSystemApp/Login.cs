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
    public partial class Login : Form
    {
        Gms_DbEntities _gmsdb;
       
        public Login()
        {
            InitializeComponent();
            _gmsdb = new Gms_DbEntities();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                var hashedPw = gmsUtil.EncryptedPW(password);
                var defaultPw = gmsUtil.DefaultPassword();

                
                    var user = _gmsdb.Users.FirstOrDefault(p => p.userName == username && p.password == hashedPw && p.isActive == true );
                    if (user != null)
                    {

                        if (hashedPw != defaultPw)
                        {
                            var role = user.UserRoles.FirstOrDefault();
                            var rolename = role.Role.name;
                            var usrname = user.userName;
                            var dash = new Dashboard(this, user);
                            dash.Show();
                            tbPassword.Text = "";
                            tbUserName.Text = "";
                            Hide();
                         }

                        else
                        {
                        MessageBox.Show("Default Password detected, You will be prompted to change your password before continuing", "Default Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var changepw = new ChangePassword(user);
                        changepw.ShowDialog();
                        }
                           
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid credentials","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                    }            
                   

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            
        }
        public string getUserName()
        {
            var user = tbUserName.Text.Trim();

                return user;
        }

        private void tbUserName_MouseHover(object sender, EventArgs e)
        {
            stlDescription.Text = "Please enter your Username";
        }

        private void tbPassword_MouseHover(object sender, EventArgs e)
        {
            stlDescription.Text = "Please enter your Password";
        }
    }
}
