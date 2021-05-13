namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleModelInfoBuilder : VehicleBuildeFacade
    {
        public VehicleModelInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleModelInfoBuilder SetMenufacturer(string value) { vehicle.Manufacturer = value; return this; }

        public VehicleModelInfoBuilder SetModel(string value) { vehicle.Model = value; return this; }

    }
}
