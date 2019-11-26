using System.Collections.Generic;
using System;

namespace generics{

    public class GasStation : IStation<GasVehicle>
    {
        public int capacity { get; set; }

        public void refuel(List<GasVehicle> vehicles)
        {
            foreach (GasVehicle vehicle in vehicles)
            {
                vehicle.fuel = 100;
                Console.WriteLine($"{vehicle.name} was fueled to 100%!");
            }
        }
    }
}