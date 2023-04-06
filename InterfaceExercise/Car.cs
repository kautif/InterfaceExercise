using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string SeatMaterial { get; set; }
        public string TopSpeed { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public bool HasBackseats { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
