using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //create non-abstract class Motorcycle, that inherit from Vehicle
    internal class Motorcycle : Vehicle
    {
        //Provide the implementations for the abstract method
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is driving (Motorcycle.cs//DriveAbstract())");
        }
        //Add a distict property in the derived class
        public bool HasSideCart { get; set; }

        //Only in the Motorcycle class will you override the virtual drive method
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's virtual drive method.(inside the Motorcycle Class, not the Vehicle.cs, because we did the override.)");
        }
    }
}
