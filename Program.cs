using System;
using System.Collections.Generic;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicles
            GasVehicle Honda = new GasVehicle("Honda", 31);
            GasVehicle Ford = new GasVehicle("Ford", 56);

            ElectricVehicle Tesla = new ElectricVehicle("Tesla", 43);
            ElectricVehicle Hybrid = new ElectricVehicle("Hybrid", 43);

            //Lists
            List<GasVehicle> listOfGasVehicles = new List<GasVehicle>();
            List<ElectricVehicle> listOfElecVehicles = new List<ElectricVehicle>();

            listOfElecVehicles.Add(Tesla);
            listOfElecVehicles.Add(Hybrid);
            listOfGasVehicles.Add(Honda);
            listOfGasVehicles.Add(Ford);

            //Stations
            GasStation gasStation = new GasStation();
            BatteryStation batteryStation = new BatteryStation();

            batteryStation.refuel(listOfElecVehicles);
            gasStation.refuel(listOfGasVehicles);
        }
    }
}
