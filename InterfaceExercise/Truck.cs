using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public bool HasBackseats { get; set; }

        public string HaulCapacity { get; set; }
        public int BedArea { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
