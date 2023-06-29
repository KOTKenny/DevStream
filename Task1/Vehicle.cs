using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1
{
    public class Vehicle : IVehicle
    {
        public int MaxSpeed { get; private set; }
        public int WheelsCount { get; private set; }
        public string Model { get; private set; }
        public VehicleColors Color { get; private set; }

        public Vehicle()
        {

        }

        public Vehicle(int maxSpeed, int wheelsCount, string model, VehicleColors color)
        {
            MaxSpeed = maxSpeed;
            WheelsCount = wheelsCount;
            Model = model;
            Color = color;
        }
    }
}
