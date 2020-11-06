using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicles
            // Created a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            // Added 1 new car and motorcycle
            var focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2020 };
            var harley = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "Chopper", Year = 2012 };

            //Added 1 new car and motorcycle through the vehicle class with respective constructors
            Vehicle sedan = new Car() { HasTrunk = true, Make = "Chevy", Model = "Malibu", Year = 2015 };
            Vehicle crotchrocket = new Motorcycle() { HasSideCart = false, Make = "Honda", Model = "CBR 1000", Year = 2018 };

            //Added all of my vehicles to list vehicles
            vehicles.Add(focus);
            vehicles.Add(harley);
            vehicles.Add(sedan);
            vehicles.Add(crotchrocket);

            //created a loop to print the properties of all vehicles in my list vehicles

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make:{veh.Make} Model: {veh.Model} Year: {veh.Year}");

                // Called the Drive method that was most suited to each class
                veh.DriveVirtual();
                Console.WriteLine("_______________________________________________");
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
