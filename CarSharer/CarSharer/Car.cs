using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharer
{
    public class Car
    {
        public int id; // let's see if we need this
        public string brand;
        public string model;
        public int power; // in HP (PS)
        public int seats;
        public int maxspeed;
        public int price; // idk why int ???
        public string gearbox;
        public string fuel;
        public string colour;
        public string licenseclass;
        public string status;
        public bool favourite;

        public string DisplayName
        {
            get
            {
                return "[" + id + "] " + brand + " " + model;
            }
        }

        public Car(int _id, string _brand, string _model, int _power, int _seats, int _price, string _gearbox, string _fuel, string _status, bool _favourite)
        public Car(int _id, string _brand, string _model, int _power, int _seats, int _maxspeed, int _price, string _gearbox, string _fuel, string _colour, string _licenseclass, string _status, bool _favourite)
        {
            id = _id;
            brand = _brand;
            model = _model;
            power = _power;
            seats = _seats;
            maxspeed = _maxspeed;
            price = _price;
            gearbox = _gearbox;
            fuel = _fuel;
            colour = _colour;
            licenseclass = _licenseclass;
            status = _status;
            favourite = _favourite;
        }
    }
}
