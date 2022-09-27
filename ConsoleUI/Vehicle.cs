using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //Create an abstract class called Vehicle
    abstract class Vehicle
    {
        //The vehicle class shall have three string properties Year, Make, and Model
        public string Year { get; set; } = "Default value";
        public string Make { get; set; } = "Default value";
        public string Model { get; set; } = "Default value";
        //vehicle shall have an abstract method called DriveAbstract with no implementation
        public abstract void DriveAbstract();

        //Vehicle shall have a virtual method called DriveVirtual with a base implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Default. I am driving my vehicle.(Virtual Drive Method(Vehicle.cs))");
        }
    }
}
