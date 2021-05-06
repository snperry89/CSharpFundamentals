﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter}
    public class Vehicle
    {
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)

            //Constructor
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }
        
        //Contructor Overload, allows for multiple versions of the same method
        public Vehicle() { }


        //1 Access Modifier
        //2 Type - type the property holds
        //3 Name
        //4 Getters and setters

        //1     //2     //3     //4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }
        
        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle.");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle.");
        }

        public bool RightIndicator { get; private set; }
        public bool LeftIndicator { get; private set; }

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            RightIndicator = false;
            LeftIndicator = true;
        }

        public void TurnOnHazards()
        {
            RightIndicator = true;
            LeftIndicator = true;
        }

        public void TurnOffHazards()
        {
            RightIndicator = false;
            LeftIndicator = false;
        }



        //Challenge
        // make Indicator it's own custom class
        // properties including IsFlashing
        // method for TurnOn() and TurnOff()
        // - methods would set value of IsFlashing
        // can use custom classes as types like we did in ClassTests.cs
    }

    public class Indicator
    {
        public bool isFlashing { get; private set; }

        public void TurnOn()
        {
            isFlashing = true;
        }

        public void TurnOff()
        {
            isFlashing = false;
        }     

    }
}
