using System;

namespace gary_garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            FuelCapacity = 23.00;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram speeds on the interstate with an exagerated, \"berrrrrrrrrr!\"");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram makes a sudden and un-signalled {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("Without consideration for parking space lines, the Ram arrests its momentum.");
        }
    }
}