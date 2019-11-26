using System.Collections.Generic;
using System;

namespace generics{

    public class GasStation : Station<GasVehicle>
    {
        public override void refuel(List<GasVehicle> vehicles)
        {
            foreach (GasVehicle vehicle in vehicles)
            {
                vehicle.fuel = 100;
                Console.WriteLine($"{vehicle.name} was fueled to 100%!");
            }
        }
    }
}