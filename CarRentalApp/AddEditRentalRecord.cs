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
    public partial class AddEditRentalRecord : Form
    {
        private readonly CarRentalEntites3 carRentalEntities;
        private bool isEditMode;
        public string _carName;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            carRentalEntities = new CarRentalEntites3();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit,string carName)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            _carName = carName;
            isEditMode = true;
            carRentalEntities = new CarRentalEntites3();
            PopulateFields(recordToEdit);
        }

        private void AddEditRentalRecord_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.TypeOfCars
                         .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model }).ToList();
            cbCarBox.DisplayMember = "Name";
            cbCarBox.ValueMember = "Id";
            cbCarBox.DataSource = cars;
            if(isEditMode)
            {
                cbCarBox.SelectedIndex = cbCarBox.FindString(_carName);
            }
        }
  
        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text=recordToEdit.CustomerName;
            dtRented.Value=(DateTime)recordToEdit.DateRented;
            dtReturned.Value=(DateTime)recordToEdit.DateReturned; 
            tbCost.Text=recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateout = dtRented.Value;
                var dateIn = dtReturned.Value;
                var carType = cbCarBox.Text;
                var isValid = true;
                var errorMessage = "";
                double cost = Convert.ToDouble(tbCost.Text);

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error:Please enter missing data.\n\r";
                }
                if (dateout > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error:Illegal Date Selection.\n\r";
                }
                //if(isValid==true)
                if (isValid)

                {
                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        var rentalRecord = carRentalEntities.CarRentalRecords.FirstOrDefault(q => q.Id == id);
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dateout;
                        rentalRecord.DateReturned = dateIn;
                        rentalRecord.Cost = (decimal)cost;
                        rentalRecord.TypeOfCarId = (int)cbCarBox.SelectedValue;
                    }
                    else
                    {
                        var rentalRecord = new CarRentalRecord();
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dateout;
                        rentalRecord.DateReturned = dateIn;
                        rentalRecord.Cost = (decimal)cost;
                        rentalRecord.TypeOfCarId = (int)cbCarBox.SelectedValue;
                        carRentalEntities.CarRentalRecords.Add(rentalRecord);
                   }
                    carRentalEntities.SaveChanges();
                    PopulateGrid();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();    
        }
         public void PopulateGrid()
        {
               var records = carRentalEntities.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.Id,
                Cost = q.Cost,
                Car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model
            }).ToList();
        }

    }
}
