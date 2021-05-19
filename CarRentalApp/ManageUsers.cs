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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntites3 _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntites3();
        }
      private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of Selected row
                var id = (int)gvUserList.SelectedRows[0].Cells["Id"].Value;
                //query database from record
                var user = _db.Users.FirstOrDefault(q => q.Id == id);
               
                var hased_password = Utils.DefaultHashedPassword();
                user.Password = hased_password;
                _db.SaveChanges();
                MessageBox.Show($"{user.UserName}'s Password has been reset!");
                PopulateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of Selected row
                var id = (int)gvUserList.SelectedRows[0].Cells["Id"].Value;
                //query database from record
                var user = _db.Users.FirstOrDefault(q => q.Id == id); //id=1
                user.isActive = user.isActive==true ? false : true;
                _db.SaveChanges();
                MessageBox.Show($"{user.UserName}'s Active Status  has changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }

        }
        public void PopulateGrid()
        {
            var users = _db.Users
                           .Select(q => new
                           {
                               q.Id,
                               q.UserName,
                               q.UserRoles.FirstOrDefault().Role.Name,
                               q.isActive
                           }).ToList();
            gvUserList.DataSource = users;
            gvUserList.Columns["UserName"].HeaderText = "User Name";
            gvUserList.Columns["Name"].HeaderText = "Role Name";
            gvUserList.Columns["isActive"].HeaderText = "Active";
            gvUserList.Columns["Id"].Visible = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
