using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        //Added new property HasTrunk
        public bool HasTrunk { get; set; } = true;

        //Added the stubbed out method from class Vehicle
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }


    }
}
