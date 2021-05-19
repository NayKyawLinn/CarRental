using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntites3 _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntites3();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalRecord"))
            {
                var addRentalRecords = new AddEditRentalRecord();
                addRentalRecords.MdiParent = this.MdiParent;
                addRentalRecords.Show();
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.Id == id);
                var carName = (string)gvRecordList.SelectedRows[0].Cells["car"].Value;
                //launch AddVehicle window with data
                var addEditRentalRecord = new AddEditRentalRecord(rentalRecord,carName)
                {
                    MdiParent = this.MdiParent
                };
                addEditRentalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                //query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.Id == id);
                //delete Vehicle
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();
                PopulateGrid();
                //gvRecordList.PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
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
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.Id,
                Cost = q.Cost,
                Car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model
            }).ToList();
            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";
            gvRecordList.Columns["Id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}