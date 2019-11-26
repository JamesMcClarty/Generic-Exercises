using System.Collections.Generic;
using System;

namespace generics{

    public class BatteryStation : Station<ElectricVehicle>
    {
        public override void refuel(List<ElectricVehicle> vehicles)
        {
            foreach (ElectricVehicle vehicle in vehicles)
            {
                vehicle.fuel = 100;
                Console.WriteLine($"{vehicle.name} was charged to 100% battery life!");
            }
        }
    }
}