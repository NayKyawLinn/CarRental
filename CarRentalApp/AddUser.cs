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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntites3 _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalEntites3();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var role = _db.Roles.ToList();
            cbRole.DataSource = role;
            cbRole.ValueMember = "id";
            cbRole.DisplayMember = "name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try {
                var username = lbUserName.Text;
                var roleId = (int)cbRole.SelectedValue;
                var password = Utils.DefaultHashedPassword();
                var user = new User()
                {
                    UserName = username,
                    Password = password,
                    isActive = true
                };
                _db.Users.Add(user);
                _db.SaveChanges();
                var userid = user.Id;
                var userRole = new UserRole()
                {
                    RoleId = roleId,
                    UserId = userid
                };
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("New User Added Successfully");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An Error Has Occured:{ex.Message}");
            }
        }
    }
}
