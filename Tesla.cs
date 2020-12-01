using System;

namespace gary_garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla just whispers on by.");
        }


    }
}