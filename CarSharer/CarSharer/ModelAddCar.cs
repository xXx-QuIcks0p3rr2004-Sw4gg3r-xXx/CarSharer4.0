using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharer
{
    public class ModelAddCar
    {
        public List<Car> Cars
        {
            get; private set;
        }

        public ModelAddCar()
        {
            Cars = new List<Car>();
        }
    }
}