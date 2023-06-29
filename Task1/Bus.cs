using System;
using Task1.Interfaces;

namespace Task1
{
    public class Bus : Vehicle
    {
        public Bus() : base(90, 6, "Neone", VehicleColors.Blue)
        {

        }

        public Bus(int maxSpeed, int wheelsCount, string model, VehicleColors color) : base(maxSpeed, wheelsCount, model, color)
        {

        }
    }
}
