using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace CarSharer
{
    public partial class MainForm : MetroForm
    {
        public BindingList<Car> Cars = new BindingList<Car>();
        LoginForm motherForm;

        public MainForm(LoginForm loginForm, bool isAdmin)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            carListBox.DataSource = Cars;
            motherForm = loginForm;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // select all Items from the database and list  them in cars
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
                    carListBox.BackColor = Color.White;
                    carListBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    carListBox.ForeColor = Color.Black;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    carListBox.BackColor = Color.FromArgb(29, 29, 29);
                    carListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    carListBox.ForeColor = Color.White;
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
        private void addTile_Click(object sender, EventArgs e)
        {
            // should add a car to the database and refresh the carlistbox (insert into)
            if (!(string.IsNullOrEmpty(brandTextBox.Text) && string.IsNullOrEmpty(modelTextBox.Text) && string.IsNullOrEmpty(priceTextBox.Text) 
                && string.IsNullOrEmpty(gearboxTextBox.Text) && string.IsNullOrEmpty(fuelTextBox.Text) && string.IsNullOrEmpty(colourTextBox.Text) 
                && string.IsNullOrEmpty(licenseclassTextBox.Text)) && string.IsNullOrEmpty(powerTextBox.Text) && string.IsNullOrEmpty(seatsTextBox.Text)
                && string.IsNullOrEmpty(maxSpeedTextBox.Text))
            {
                DbController.InsertCar(new Car(0, brandTextBox.Text, modelTextBox.Text, Int32.Parse(powerTextBox.Text), Int32.Parse(seatsTextBox.Text), 
                    Int32.Parse(maxSpeedTextBox.Text), Int32.Parse(priceTextBox.Text), gearboxTextBox.Text, fuelTextBox.Text, colourTextBox.Text, 
                    licenseclassTextBox.Text, statusTextBox.Text, false) , this);
            }
            else MetroMessageBox.Show(this,"More details, please.");
        }
        private void EntfernenTile_Click(object sender, EventArgs e)
        {
            if (carListBox.SelectedItem != null)
            {
                using (MySqlConnection con = new MySqlConnection(@"host=mysql8.db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
                {
                    try
                    {
                        // open connection to database 
                        con.Open();
                        Car car = (Car)carListBox.SelectedItem;
                        using (MySqlCommand command = new MySqlCommand("DELETE FROM Car WHERE ID = " + car.id, con))
                        {
                            command.ExecuteNonQuery();
                            Cars.Remove(car);
                            carListBox.DataSource = Cars;
                            carListBox.SelectedItem = null;
                            MetroMessageBox.Show(this, "Car (#" + car.id + ") deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Need more details. " + ex.Message);
                    }
                    finally
                    {
                        // close connection to database
                        con.Close();
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "You have to select a Car!");
            }
        }

        private void BearbeitenTile_Click(object sender, EventArgs e)
        {
            // should update a car from the database and refresh the carlistbox (update set)
        }

        /// <summary>
        /// Shows the attibutes of the selected Item (or Car).
        /// </summary>
        private void SpieleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carListBox.SelectedIndex != -1)
            {
                modelLabel.Text = Cars[carListBox.SelectedIndex].model; // you could also do this with carListBox.Item.xxx but i would have had to change more of my "paste"
                brandLabel.Text = Cars[carListBox.SelectedIndex].brand;
                powerLabel.Text = Cars[carListBox.SelectedIndex].power.ToString();
                seatsLabel.Text = Cars[carListBox.SelectedIndex].seats.ToString();
                gearboxLabel.Text = Cars[carListBox.SelectedIndex].gearbox;
                fuelLabel.Text = Cars[carListBox.SelectedIndex].fuel;
                statusLabel.Text = Cars[carListBox.SelectedIndex].status;
                priceLabel.Text = Cars[carListBox.SelectedIndex].price.ToString();
            }
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
        /// Lets you favoritise some cars.
        /// </summary>
        private void FavoritTile_Click(object sender, EventArgs e)
        {
            if (carListBox.SelectedIndex != -1)
            {
                if (Cars[carListBox.SelectedIndex].favourite)
                {
                    Cars[carListBox.SelectedIndex].favourite = false;
                    favoritTile.Text = "Favoritisieren";
                }
                else
                {
                    Cars[carListBox.SelectedIndex].favourite = true;
                    favoritTile.Text = "Defavoritisieren";
                }
                Cars = new BindingList<Car>(Cars.OrderBy(x => x.ToString()).ToList());
                carListBox.DataSource = Cars;
                if (!string.IsNullOrEmpty(searchTextBox.Text))
                {
                    searchTextBox.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Sets value of the Textbox empty.
        /// </summary>
        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            carListBox.SelectedIndex = -1;
            searchTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Some settings for the Searchtextbox.
        /// </summary>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(searchTextBox.Text == "Suchen  (@help)"))
            {
                if (searchTextBox.Text == "@help")
                {
                    MessageBox.Show("Sie können nach bestimmten Attributen suchen(Usk, Kategorie, und Publisher). @model, @power, @price, @seats, @favoriten");
                    searchTextBox.Text = string.Empty;
                }
                else if (searchTextBox.Text == "@model")
                {
                    List<Car> searches = new List<Car>();
                    foreach (Car car in Cars)
                    {
                        searches.Add(car);
                    }
                    Cars = new BindingList<Car>(Order(searches, "model"));
                    searches = Order(searches, "model");
                    carListBox.DataSource = searches;
                    carListBox.DisplayMember = "model";
                }
                else if (searchTextBox.Text == "@price")
                {
                    List<Car> searches = new List<Car>();
                    foreach (Car game in Cars)
                    {
                        searches.Add(game);
                    }
                    Cars = new BindingList<Car>(Order(searches, "price"));
                    searches = Order(searches, "price");
                    carListBox.DataSource = searches;
                    carListBox.DisplayMember = "price";
                }
                else if (searchTextBox.Text == "@seats")
                {
                    List<Car> searches = new List<Car>();
                    foreach (Car game in Cars)
                    {
                        searches.Add(game);
                    }
                    Cars = new BindingList<Car>(Order(searches, "seats"));
                    searches = Order(searches, "seats");
                    carListBox.DataSource = searches;
                    carListBox.DisplayMember = "seats";
                }
                else if (searchTextBox.Text == "@power")
                {
                    List<Car> searches = new List<Car>();
                    foreach (Car game in Cars)
                    {
                        searches.Add(game);
                    }
                    Cars = new BindingList<Car>(Order(searches, "model"));
                    searches = Order(searches, "power");
                    carListBox.DataSource = searches;
                    carListBox.DisplayMember = "power";
                }
                else if (searchTextBox.Text == "@power")
                {
                    List<Car> searches = new List<Car>();
                    foreach (Car car in Cars)
                    {
                        if (car.favourite)
                        {
                            searches.Add(car);
                        }
                    }
                    searches = Order(searches, "favorite");
                    carListBox.DataSource = searches;
                    carListBox.DisplayMember = "ToString()";
                }
                else if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    carListBox.DataSource = Cars;
                    carListBox.DisplayMember = "";
                }
                else
                {
                    List<Car> searches = new List<Car>();
                    foreach (Car car in Cars)
                    {
                        if (car.brand.Contains(searchTextBox.Text))
                        {
                            searches.Add(car);
                        }
                        if (car.model.Contains(searchTextBox.Text))
                        {

                        }
                    }
                    carListBox.DataSource = searches;
                }
            }
        }

        /// <summary>
        /// Orders a List upon a few settings.
        /// </summary>
        /// <param name="cars">List of Cars the method should sort.</param>
        /// <param name="kriterium">An Option, how should the list be sorted.</param>
        /// <returns>Returns a sorted list of cars.</returns>
        private List<Car> Order(List<Car> cars, string kriterium)
        {
            if (ordnenComboBox.SelectedIndex == 0 && kriterium == "model")
            {
                return  cars.OrderBy(x => x.model).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 0 && kriterium == "power")
            {
                return cars.OrderBy(x => x.power).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 0 && kriterium == "price")
            {
                return cars.OrderBy(x => x.price).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 1 && kriterium == "seats")
            {
                return cars.OrderBy(o => o.seats).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 1 && kriterium == "model")
            {
                return cars.OrderByDescending(o => o.model).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 1 && kriterium == "power")
            {
                return cars.OrderByDescending(o => o.power).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 1 && kriterium == "price")
            {
                return cars.OrderByDescending(o => o.price).ToList();
            }
            else if (ordnenComboBox.SelectedIndex == 1 && kriterium == "seats")
            {
                return cars.OrderByDescending(o => o.seats).ToList();
            }
            else
            {
                return cars;
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
    }
}
