namespace gary_garage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }

        void ChargeBattery()
        {
            BatteryKWh = 100.00;
        }
    }
}