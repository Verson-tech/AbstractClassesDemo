using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //create non-abstract class Car, that inherit from Vehicle
    internal class Car : Vehicle
    {
        //Provide the implementations for the abstract method
        public override void DriveAbstract()
        {
            Console.WriteLine("Car is driving(implementation from the Car.cs)");
        }
        //Add a distict property in the derived class
        public bool HasTrunk { get; set; }
    }



}
