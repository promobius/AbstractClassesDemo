using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        //Added 3 properties of year, make , and model to Vehicle class
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";


        // Added stubbed out method DriveAbstract that has no implementation
        public abstract void DriveAbstract();

        // Added the method DriveVirtual and gave it a base implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This{GetType().Name} is virtually in drive");
        }
    }
}
