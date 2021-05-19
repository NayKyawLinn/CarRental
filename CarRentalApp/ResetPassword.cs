using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntites3 _db;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new CarRentalEntites3();
            _user = user;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbNewPassword.Text;
                var confirm_password = tbConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.Id == _user.Id);
                if (password != confirm_password)
                {
                    MessageBox.Show("Password do not match.Please Try Again");
                }
                user.Password = Utils.HashPassword(password);
                _db.SaveChanges();
                MessageBox.Show("Password was reset successfully");
                Close();

            }
            catch(Exception)
            {
                //Message
                MessageBox.Show("An error has occured");
                
            }
        }
    }
}
