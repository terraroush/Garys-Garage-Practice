using System;

namespace gary_garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }


        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by with a subdued, \"wizzzzzzzz...\"");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero makes a slow and controlled {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"Finally, the Zero halts with slow-motion precision.");
        }
    }
}