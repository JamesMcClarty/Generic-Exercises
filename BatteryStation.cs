using System.Collections.Generic;
using System;

namespace generics{

    public class BatteryStation : IStation<ElectricVehicle>
    {
        public int capacity { get; set; }

        public void refuel(List<ElectricVehicle> vehicles)
        {
            foreach (ElectricVehicle vehicle in vehicles)
            {
                vehicle.fuel = 100;
                Console.WriteLine($"{vehicle.name} was charged to 100% battery life!");
            }
        }
    }
}