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

        public CarReserver()
        {
            InitializeComponent();
        }

        private void Reservebutton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarReserver_Load(object sender, EventArgs e)
        {
            foreach (CarModel car in Database.GetCars())
            {
                CarGridView.Rows.Add(car.Brand, car.Model, car.PS, car.Seats, car.Speed, car.Price, car.Fuel, car.Gearbox, car.Colour);
            }
        }
    }
}
