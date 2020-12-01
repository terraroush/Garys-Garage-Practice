using System;
using System.Collections.Generic;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate each vehicle
            Zero myZero = new Zero()
            {
                MainColor = "smoke"
            };
            Cessna myCessna = new Cessna()
            {
                MainColor = "silver"
            };
            Tesla myTesla = new Tesla()
            {
                MainColor = "black"
            };
            Ram myRam = new Ram()
            {
                MainColor = "red"
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                myZero, myTesla
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.BatteryKWh}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.BatteryKWh}");
            }

            /***********************************************/

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                myRam, myCessna
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.FuelCapacity}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.FuelCapacity}");
            }

            // myCessna.Drive();
            // myCessna.Turn("right");
            // myCessna.Stop();
            // Console.WriteLine("");


            // myTesla.Drive();
            // myTesla.Turn("left");
            // myTesla.Stop();
            // Console.WriteLine("");


            // myRam.Drive();
            // myRam.Turn("right");
            // myRam.Stop();
            // Console.WriteLine("");


            // myZero.Drive();
            // myZero.Turn("left");
            // myZero.Stop();
            // Console.WriteLine("");





        }
    }
}
