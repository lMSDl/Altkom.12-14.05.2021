namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : VehicleBuildeFacade
    {
        public VehicleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder SetWheels(int value) { vehicle.Wheels = value; return this; }

        public VehicleBuilder SetSeats(int value) { vehicle.Seats = value; return this; }

        public VehicleBuilder SetDoors(int value) { vehicle.Doors = value; return this; }

        public VehicleBuilder SetTrunkCapacity(int? value) { vehicle.TrunkCapacity = value; return this; }

        public VehicleBuilder SetEnginePower(int? value) { vehicle.EnginePower = value; return this; }

    }
}
