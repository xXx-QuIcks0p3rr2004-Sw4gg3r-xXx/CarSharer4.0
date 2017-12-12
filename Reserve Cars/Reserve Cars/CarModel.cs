using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_Cars
{
    public class CarModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int ps;
        public int PS
        {
            get { return ps; }
            set { ps = value; }
        }

        private int seats;
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        private string speed;
        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private string fuel;
        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        private string gearbox;
        public string Gearbox
        {
            get { return gearbox; }
            set { gearbox = value; }
        }

        private DateTime reserved;
        public DateTime Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }

        private string colour;
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        private int maxspeed;
        public int Maxspeed
        {
            get { return maxspeed; }
            set { maxspeed = value; }
        }

        public CarModel()
        {

        }
    }
}
