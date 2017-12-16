using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace CarSharer
{
    public partial class MainForm : MetroForm
    {
        public BindingList<CarModel> Cars = new BindingList<CarModel>();
        LoginForm motherForm;
        int i = 0;
        int SelectedCar = 0;
        int SelectedCarId = 0;
        DateTime Date1 = DateTime.Now;
        DateTime DateZero = Convert.ToDateTime(null);

        public MainForm(LoginForm loginForm, bool isAdmin)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            motherForm = loginForm;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CarGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarGridView.AllowUserToAddRows = false;
            BlockButton.Enabled = false;

            foreach (CarModel car in DbController.GetCars())
            {
                if ((DateTime.Compare(Date1, car.date) > 0 || CarCheckBox.Checked) && car.status == "Free")
                {
                    CarGridView.Rows.Add(car.id, car.brand, car.model, car.power, car.seats, car.maxv, car.price, car.gearbox, car.fuel, car.colour);
                }
            }
        }

        /// <summary>
        /// Changes the design into one of the given options.
        /// </summary>
        private void LeitmotivComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (leitmotivComboBox.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroThemeStyle.Light;
                    CarGridView.BackColor = Color.White;
                    CarGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    CarGridView.ForeColor = Color.Black;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    CarGridView.BackColor = Color.FromArgb(29, 29, 29);
                    CarGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    CarGridView.ForeColor = Color.White;
                    break;
            }
            Invalidate();
        }

        /// <summary>
        /// Changes the design into one of the given options.
        /// </summary>
        private void FarbeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)Convert.ToInt32(farbeComboBox.SelectedIndex);
            Invalidate();
        }

        private void HinzufügenTile_Click(object sender, EventArgs e)
        {
            // should add a car to the database and refresh the carlistbox (insert into)
        }

        private void EntfernenTile_Click(object sender, EventArgs e)
        {
            // should delete a car from the database and refresh the carlistbox (delete from)
        }

        private void BearbeitenTile_Click(object sender, EventArgs e)
        {
            // should update a car from the database and refresh the carlistbox (update set)
        }



        private void StartenTile_Click(object sender, EventArgs e)
        {
            // should start a timer or stuff like that
        }

        private void BeendenTile_Click(object sender, EventArgs e)
        {
            // should end a timer and show a total price
        }

        /// <summary>
        /// Ensures an error free entry :)
        /// </summary>
        private void PowerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(powerTextBox.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(powerTextBox.Text))
                {
                    try
                    {
                        Convert.ToInt32(powerTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.");
                        powerTextBox.Text = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Also closes the mother (Login) -Form
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            motherForm.Close();
        }

        /// <summary>
        /// Ensures an error free entry :)
        /// </summary>
        private void SeatsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(powerTextBox.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(powerTextBox.Text))
                {
                    try
                    {
                        Convert.ToInt32(powerTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.");
                        powerTextBox.Text = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Ensures an error free entry :)
        /// </summary>
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(powerTextBox.Text);
            }
            catch
            {
                if (!string.IsNullOrEmpty(powerTextBox.Text))
                {
                    try
                    {
                        Convert.ToInt32(powerTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.");
                        powerTextBox.Text = string.Empty;
                    }
                }
            }
        }

        private void ReserveTile_Click(object sender, EventArgs e)
        {
            SelectedCar = CarGridView.CurrentCell.RowIndex + 1;
            SelectedCarId = Convert.ToInt16(CarGridView.Rows[CarGridView.CurrentCell.RowIndex].Cells["CarId"].Value);

            DbController.SetReserved(SelectedCarId);
            CarGridView.Rows.Clear();
            i = 0;
            foreach (CarModel car in DbController.GetCars())
            {
                //if ((DateTime.Compare(Date1, car.Date) > 0 || CarCheckBox.Checked) && car.Status == "Free")
                //{
                //    CarGridView.Rows.Add(car.id, car.Brand, car.Model, car.PS, car.Seats, car.Maxspeed, car.Price, car.Gearbox, car.Fuel, car.Colour);

                //}

            }
        }

        private void DriveTile_Click(object sender, EventArgs e)
        {
            SelectedCar = CarGridView.CurrentCell.RowIndex + 1;
            SelectedCarId = Convert.ToInt16(CarGridView.Rows[CarGridView.CurrentCell.RowIndex].Cells["CarId"].Value);

            DbController.SetStatus(SelectedCarId, "Riding");
            CarGridView.Rows.Clear();
            i = 0;
            foreach (CarModel car in DbController.GetCars())
            {
                if ((DateTime.Compare(Date1, car.date) > 0 || CarCheckBox.Checked) && car.status == "Free")
                {
                    CarGridView.Rows.Add(car.id, car.brand, car.model, car.power, car.seats, car.maxv, car.price, car.gearbox, car.fuel, car.colour);

                }
            }
        }

        private void CarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CarCheckBox.Checked == true)
            {
                CarGridView.Rows.Clear();
                i = 0;
                ReserveTile.Enabled = false;
                foreach (CarModel car in DbController.GetCars())
                {
                    if ((DateTime.Compare(Date1, car.date) > 0 || CarCheckBox.Checked) && car.status == "Free")
                    {
                        CarGridView.Rows.Add(car.id, car.brand, car.model, car.power, car.seats, car.maxv, car.price, car.gearbox, car.fuel, car.colour);

                    }

                }
            }
            else
            {
                CarGridView.Rows.Clear();
                i = 0;
                ReserveTile.Enabled = true;
                foreach (CarModel car in DbController.GetCars())
                {
                    if ((DateTime.Compare(Date1, car.date) > 0 || CarCheckBox.Checked) && car.status == "Free")
                    {
                        CarGridView.Rows.Add(car.id, car.brand, car.model, car.power, car.seats, car.maxv, car.price, car.gearbox, car.fuel, car.colour);

                    }

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

            DbController.SetStatus(SelectedCarId, "Blocked");
            CarGridView.Rows.Clear();
            i = 0;
            foreach (CarModel car in DbController.GetCars())
            {
                if ((DateTime.Compare(Date1, car.date) > 0 || CarCheckBox.Checked) && car.status == "Free")
                {
                    CarGridView.Rows.Add(car.id, car.brand, car.model, car.power, car.seats, car.maxv, car.price, car.gearbox, car.fuel, car.colour);

                }
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            foreach (CarModel car in DbController.GetCars())
            {
                DbController.SetStatus(car.id, "Free");
            }
            this.Close();
        }
    }
}
