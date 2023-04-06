using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // X Create 2 Interfaces called IVehicle & ICompany

            // X Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* X Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /* X Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /* X Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * X Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            // X Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car prius = new Car { 
                SeatMaterial = "Leather",
                TopSpeed = "160mph",
                NumberOfWheels = 4,
                NumberOfDoors = 5,
                HasBackseats = true,
                Logo = "Toyota",
                Slogan = "Let's Go Places"
            };

            string carScript = $"It has has silky {prius.SeatMaterial} and can reach a blazing top speed of {prius.TopSpeed}";

            Truck f150 = new Truck
            {
                HaulCapacity = "2 tons",
                BedArea = 66,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                HasBackseats = true,
                Logo = "Ford",
                Slogan = "We Build the Future"
            };

            string truckScript = $"This beast hauls cargo up to {f150.HaulCapacity} and a spacious bed area of {f150.BedArea} inches";

            SUV palisade = new SUV
            {
                HasFoldingSeats = true,
                NumberOfTVMonitors = 4,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                HasBackseats = true,
                Logo = "Hyundai",
                Slogan = "New Thinking New Possibilities"
            };

            string suvScript = palisade.HasFoldingSeats ?
                $"The space in this SUV is very modular with its folding seats and entertainment for everyone with its {palisade.NumberOfTVMonitors} contractible monitors"
                : "It has entertainment for everyone with its {palisade.NumberOfTVMonitors} contractible monitors";
            
            string GeneralScript (int NumberOfWheels, int NumberOfDoors, bool HasBackseats, string Logo, string Slogan) {
                string script = $"This vehicle sports {NumberOfWheels} wheel drive, and {NumberOfDoors} doors. {Logo} - {Slogan}";
                Console.WriteLine(script);
                return script;
            }
            GeneralScript(prius.NumberOfWheels, prius.NumberOfDoors, prius.HasBackseats, prius.Logo, prius.Slogan);
            GeneralScript(f150.NumberOfWheels, f150.NumberOfDoors, f150.HasBackseats, f150.Logo, f150.Slogan);
            GeneralScript(palisade.NumberOfWheels, palisade.NumberOfDoors, palisade.HasBackseats, palisade.Logo, palisade.Slogan);
        }
    }
}
