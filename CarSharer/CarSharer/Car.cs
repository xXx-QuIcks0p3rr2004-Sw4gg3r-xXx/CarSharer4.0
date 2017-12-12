using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharer
{
    class Car
    {
        public class Car
        {
            public int ID
            {
                get;
                private set;
            }
            public string Brand
            {
                get;
                private set;
            }
            public string Model
            {
                get;
                private set;
            }
            public int PS
            {
                get;
                private set;
            }
            public int Seats
            {
                get;
                private set;
            }
            public string MaxSpeed
            {
                get;
                private set;
            }
            public int Price
            {
                get;
                private set;
            }
            public string Fuel
            {
                get;
                private set;
            }
            public string Gearbox
            {
                get;
                private set;
            }
            public string Colour
            {
                get;
                private set;
            }
            public string Licenseclass
            {
                get;
                private set;
            }

            public Car(int id, string brand, string model, int ps, int seats, string maxSpeed, int price, string fuel, string gearbox, string colour, string licensclass)
            {
                ID = id;
                Brand = brand;
                Model = model;
                PS = ps;
                Seats = seats;
                MaxSpeed = maxSpeed;
                Price = price;
                Fuel = fuel;
                Gearbox = gearbox;
                Colour = colour;
                Licenseclass = licensclass;
            }
        }
    }
}
