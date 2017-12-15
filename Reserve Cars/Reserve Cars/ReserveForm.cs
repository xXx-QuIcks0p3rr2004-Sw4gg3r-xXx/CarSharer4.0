using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reserve_Cars
{
    public partial class CarReserver : Form
    {
        int i = 0;
        int SelectedCar = 0;
        int SelectedCarId = 0;
        DateTime Date1 = DateTime.Now;
        DateTime DateZero = Convert.ToDateTime(null);

        public CarReserver()
        {
            InitializeComponent();
        }

        private void Reservebutton_Click(object sender, EventArgs e)
        {
            SelectedCar = CarGridView.CurrentCell.RowIndex + 1;
            SelectedCarId = Convert.ToInt16(CarGridView.Rows[CarGridView.CurrentCell.RowIndex].Cells["CarId"].Value);
            
            Database.SetReserved(SelectedCarId);
            CarGridView.Rows.Clear();
            i = 0;
            foreach (CarModel car in Database.GetCars())
            {
                if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                {
                    CarGridView.Rows.Add(car.Id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);
                    
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CarReserver_Load(object sender, EventArgs e)
        {
            CarGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarGridView.AllowUserToAddRows = false;
            BlockButton.Enabled = false;
            
            foreach (CarModel car in Database.GetCars())
            {
                if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                {
                    CarGridView.Rows.Add(car.Id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);
                    
                }
            }

        }

        private void CarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CarCheckBox.Checked == true)
            {
                CarGridView.Rows.Clear();
                i = 0;
                Reservebutton.Enabled = false;
                foreach (CarModel car in Database.GetCars())
                {
                    if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                    {
                        CarGridView.Rows.Add(car.Id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);
                        
                    }

                }
            }
            else
            {
                CarGridView.Rows.Clear();
                i = 0;
                Reservebutton.Enabled = true;
                foreach (CarModel car in Database.GetCars())
                {
                    if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                    {
                        CarGridView.Rows.Add(car.Id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);
                        
                    }

                }
            }
            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            foreach (CarModel car in Database.GetCars())
            {
                Database.SetStatus(car.Id, "Free");
            }
            this.Close();
        }

        private void DriveButton_Click(object sender, EventArgs e)
        {
            SelectedCar = CarGridView.CurrentCell.RowIndex + 1;
            SelectedCarId = Convert.ToInt16(CarGridView.Rows[CarGridView.CurrentCell.RowIndex].Cells["CarId"].Value);

            Database.SetStatus(SelectedCarId, "Riding");
            CarGridView.Rows.Clear();
            i = 0;
            foreach (CarModel car in Database.GetCars())
            {
                if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                {
                    CarGridView.Rows.Add(car.Id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);

                }

            }
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminCheckBox.Checked == true) BlockButton.Enabled = true;
            else BlockButton.Enabled = false;
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            SelectedCar = CarGridView.CurrentCell.RowIndex + 1;
            SelectedCarId = Convert.ToInt16(CarGridView.Rows[CarGridView.CurrentCell.RowIndex].Cells["CarId"].Value);

            Database.SetStatus(SelectedCarId, "Blocked");
            CarGridView.Rows.Clear();
            i = 0;
            foreach (CarModel car in Database.GetCars())
            {
                if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                {
                    CarGridView.Rows.Add(car.Id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);

                }

            }
        }
    }
}
