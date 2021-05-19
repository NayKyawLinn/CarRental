using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntites3 _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntites3();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;
                var hashed_password = Utils.HashPassword(password);
              var user = _db.Users.FirstOrDefault(q => q.UserName == username && q.Password == hashed_password && q.isActive==true);
                if(user==null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainWindow = new MainWindow(this,user);
                    mainWindow.Show();
                    Hide();
                }
          
            }catch(Exception ex)
            {
                MessageBox.Show("Something went wrong.Please Try again");
                MessageBox.Show(ex.Message);
            }

        }
    }
}
