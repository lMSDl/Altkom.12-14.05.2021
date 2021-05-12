namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder
    {
        private Vehicle vehicle { get; set; }

        public VehicleBuilder()
        {
            vehicle = new Vehicle();
        }

        public VehicleBuilder SetWheels(int value) { vehicle.Wheels = value; return this; }

        public VehicleBuilder SetSeats(int value) { vehicle.Seats = value; return this; }

        public VehicleBuilder SetDoors(int value) { vehicle.Doors = value; return this; }

        public VehicleBuilder SetTrunkCapacity(int? value) { vehicle.TrunkCapacity = value; return this; }

        public VehicleBuilder SetEnginePower(int? value) { vehicle.EnginePower = value; return this; }

        public Vehicle Build()
        {
            return vehicle;
        }
    }
}
