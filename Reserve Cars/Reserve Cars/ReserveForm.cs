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
        int IdOfSelectedCar = 0;

        public CarReserver()
        {
            InitializeComponent();
        }

        private void Reservebutton_Click(object sender, EventArgs e)
        {
            IdOfSelectedCar = CarGridView.CurrentCell.RowIndex + 1;
            Database.SetReserved(IdOfSelectedCar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarReserver_Load(object sender, EventArgs e)
        {
            CarGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarGridView.AllowUserToAddRows = false;
            foreach (CarModel car in Database.GetCars())
            {
                CarGridView.Rows.Add(car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel,  car.Colour);
                i++;
                if(i == 1) FreeCarsLabel.Text = i + " Free Car:";
                else FreeCarsLabel.Text = i + " Free Cars:";
            }

        }
    }
}
