using System;
using Task1.Interfaces;

namespace Task1
{
    public class Bicycle : Vehicle
    {
        public Bicycle() : base(20, 2, "Nanone", VehicleColors.Green)
        {

        }

        public Bicycle(int maxSpeed, int wheelsCount, string model, VehicleColors color) : base(maxSpeed, wheelsCount, model, color)
        {

        }
    }
}
