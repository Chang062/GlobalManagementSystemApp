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
    public partial class ChangePassword : Form
    {
        User _user;
        Gms_DbEntities _gmsdb;
        
        public ChangePassword()
        {
            InitializeComponent();
            _gmsdb = new Gms_DbEntities();
        }

        public ChangePassword(User user )
        {
            InitializeComponent();
            _gmsdb = new Gms_DbEntities();
            _user = user;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btResetPw_Click(object sender, EventArgs e)
        {
            try
            {
                var defaultPw = gmsUtil.DefaultPassword();
                var defaultPwEntered = tbDefaultPw.Text;
                var defaultPwEnteredHashed = gmsUtil.EncryptedPW(defaultPwEntered);

                if (defaultPwEnteredHashed == defaultPw && tbNewPw.Text == tbConfirmPw.Text)
                {
                    var user = _gmsdb.Users.FirstOrDefault(q => q.ID == _user.ID);
                    var newPassword = tbConfirmPw.Text;
                    user.password = gmsUtil.EncryptedPW(newPassword);

                    _gmsdb.SaveChanges();
                    this.Close();
                    MessageBox.Show("Password reset success!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Please enter valid credentials", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
