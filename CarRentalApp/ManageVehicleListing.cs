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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntites3 _db;
        private string sort = string.Empty;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntites3();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Simple Refresh Option
            PopulateGrid();
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.ShowDialog();
            addEditVehicle.MdiParent = this.MdiParent;
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            var cars = _db.TypeOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id
                }).ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }

        public void PopulateGrid()
        {
            var cars = _db.TypeOfCars
               .Select(q => new
               {
                   Make = q.Make,
                   Model = q.Model,
                   VIN = q.VIN,
                   Year = q.Year,
                   LicensePlateNumber = q.LicensePlateNumber,
                   q.Id
               }).ToList();

            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var carVehicle = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
                //launch AddVehicle window with data
                var addEditVehicle = new AddEditVehicle(carVehicle, this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // throw;
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected row
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);
                DialogResult dr = MessageBox.Show("Are You Sure You Want Delete This Records?", "Delete",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    _db.TypeOfCars.Remove(car);
                    _db.SaveChanges();
                    PopulateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void gvVehicleList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sort == "a")
            {
                sort = "d";
                gvVehicleList.DataSource = _db.TypeOfCars
                    .Select(q => new
                    {
                        Make = q.Make,
                        Model = q.Model,
                        VIN = q.VIN,
                        Year = q.Year,
                        LicensePlateNumber = q.LicensePlateNumber,
                        q.Id
                    }).OrderBy(q => q.Id).ToList();
            }
            else
            {
                sort = "a";
                gvVehicleList.DataSource = _db.TypeOfCars
                    .Select(q => new
                    {
                        Make = q.Make,
                        Model = q.Model,
                        VIN = q.VIN,
                        Year = q.Year,
                        LicensePlateNumber = q.LicensePlateNumber,
                        q.Id
                    }).OrderByDescending(q => q.Id).ToList();
            }
        }
    }
}

