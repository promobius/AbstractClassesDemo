using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        //Added new property HasSideCart
        public bool HasSideCart { get; set; } = true;


        //Added the stubbed out method from class Vehicle
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }

        //Added a way to overide the DriveVirtual method in this class
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }
    }
    
}
